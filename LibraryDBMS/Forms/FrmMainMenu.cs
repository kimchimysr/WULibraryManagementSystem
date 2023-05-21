using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using LibraryDBMS.Libs;
using LibraryDBMS.Setting;
using Squirrel;

namespace LibraryDBMS.Forms
{
    public partial class FrmMainMenu : Form
    {
        private FrmLogin frmLogin;
        public DataTable user { get; set; }
        public NotifyIcon niBookLoan = new NotifyIcon();
        private UserSetting us = new UserSetting();

        private bool isMenuCollapsed;
        private Size formSize;
        private int borderSize = 3;

        internal bool hasClickExitOrRestartButton = false;

        public FrmMainMenu(FrmLogin frmLogin,DataTable user)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            this.frmLogin = frmLogin;
            this.user = user;
            InitializeValues();
        }

        private void InitializeValues()
        {
            // load splash screen
            var frmSplashScreen = new FrmSplashScreen();
            frmSplashScreen.ShowDialog();
            //// show user registration dialog if application launch for the first time
            //if (IsFirstTimeApplicationLaunch())
            //{
            //    var dialogUserRegistration = new DialogUserRegistration();
            //    dialogUserRegistration.ShowDialog();
            //}
            // drag form
            Utils.DragFormWithControlMouseDown(this, pTitleBar);
            // fix flickering
            Utils.FixControlFlickering(pContainer);
            //// get user information
            //user = LibModule.GetDataTableFromDBWithTableName("tblUser");
            // add application version
            lblAppTitle.Text += $" v{Application.ProductVersion}";
            // open form to start counting uptime
            OpenChildForm(new FrmDashboard(this), pDashboard);
            SetUserPermission();
            AppliedUserSetting();
            LibModule.LogTimestampUserLogin(user);
            ShowBooksDueAndOverdueNotification();
        }

        private bool IsFirstTimeApplicationLaunch()
        {
            string query = "SELECT userID FROM tblUser;";
            if (!string.IsNullOrEmpty(LibModule.ExecuteScalarQuery(query)))
                return false;

            return true;
        }

        private void SetUserPermission()
        {
            if (user.Rows[0]["roleName"].ToString().ToLower() == "admin")
                Utils.SetControlVisibility(true, btnManageUser);
            else
                Utils.SetControlVisibility(false, btnManageUser);
        }

        private void AppliedUserSetting()
        {
            if (us.SetAutoUpdateInBackground)
            {
                // check if application is installed through Squirrel installtaion
                var assembly = Assembly.GetEntryAssembly();
                string updateDotExe = Path.Combine(Path.GetDirectoryName(assembly.Location), "..", "Update.exe");
                bool isSquirrelInstall = File.Exists(updateDotExe);

                if (isSquirrelInstall && Utils.IsInternetAvailable("www.google.com"))
                    CheckForUpdate();
            }

            if (us.SetSidebarCollapsed)
            {
                isMenuCollapsed = true;
                CollapseMenu();
            }

            this.WindowState = us.StartAppInFullscreen == true ? 
                FormWindowState.Maximized : FormWindowState.Normal;
            if (us.DefaultStartPage == "Dashboard")
            {
                ActivateButton(btnDashboard);
                OpenChildForm(new FrmDashboard(this), pDashboard);
            }
            else OpenChildForm(new FrmHome(), pHome);
        }

        private async void CheckForUpdate()
        {
            using (var manager = new UpdateManager(@"https://raw.githubusercontent.com/kimchimysr/WULibraryManagementSystem/release/published/"))
            {
                await manager.UpdateApp();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnMenu":
                    isMenuCollapsed = isMenuCollapsed != true;
                    CollapseMenu();
                    break;
                case "btnHome":
                    panelSelected.Visible = false;
                    OpenChildForm(new FrmHome(), pHome);
                    break;
                case "btnHomeCollapsed":
                    panelSelected.Visible = false;
                    OpenChildForm(new FrmHome(), pHome);
                    break;
                case "btnDashboard":
                    ActivateButton(btnDashboard);
                    OpenChildForm(new FrmDashboard(this), pDashboard);
                    break;
                case "btnManageBook":
                    ActivateButton(btnManageBook);
                    OpenChildForm(new FrmManageBook(this), pManageBook);
                    break;
                case "btnManageStudent":
                    ActivateButton(btnManageStudent);
                    OpenChildForm(new FrmManageStudent(this), pManageStudent);
                    break;
                case "btnBookLoanReturn":
                    ActivateButton(btnBookLoanReturn);
                    OpenChildForm(new FrmManageBorrowBook(this), pBookLoanReturn);
                    break;
                case "btnReport":
                    ActivateButton(btnReport);
                    OpenChildForm(new FrmReportViewer(user), pReport);
                    break;
                case "btnRecentActivity":
                    ActivateButton(btnRecentActivity);
                    OpenChildForm(new FrmRecentActivity(), pRecentActivity);
                    break;
                case "btnNotification":
                    ActivateButton(btnNotification);
                    OpenChildForm(new FrmNotification(), pNotification);
                    break;
                case "btnManageUser":
                    ActivateButton(btnManageUser);
                    OpenChildForm(new FrmManageUser(this), pManageUser);
                    break;
                case "btnAccount":
                    OpenChildFormAsDialog(new DialogUserAccount(user));
                    break;
                case "btnSetting":
                    OpenChildFormAsDialog(new DialogSetting(this, user));
                    break;
                case "btnLogout":
                    DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        LibModule.LogTimestampUserLogout(user);
                        hasClickExitOrRestartButton = true;
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    break;
                case "btnChangePassword":
                    OpenChildFormAsDialog(new DialogChangePassword(this));
                    break;
                case "btnAbout":
                    OpenChildFormAsDialog(new DialogAbout());
                    break;
                case "btnMinimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "btnMaximize":
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        formSize = this.ClientSize;
                        this.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Normal;
                        this.Size = formSize;
                    }
                    break;
                case "btnExit":
                    DialogResult result1 = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result1 == DialogResult.Yes)
                    {
                        hasClickExitOrRestartButton = true;
                        LibModule.LogTimestampUserLogout(user);
                        Application.Exit();
                    }
                    break;
            }
        }

        private void CollapseMenu()
        {
            btnHomeCollapsed.Visible = isMenuCollapsed == true;
            btnHome.Visible = isMenuCollapsed != true;
            pHomeBorder.Visible = isMenuCollapsed != true;
            pSidebar.Width = isMenuCollapsed == true ?
                pSidebar.MinimumSize.Width : pSidebar.MaximumSize.Width;
        }

        internal void ActivateButton(Button button)
        {
            panelSelected.Visible = true;
            panelSelected.Height = button.Height;
            panelSelected.Top = button.Top;
        }

        internal void OpenChildForm(Form childForm, Panel panel)
        {
            //Stopwatch timer = Stopwatch.StartNew();
            if (panel.Controls.Count == 0)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.BackColor = SystemColors.Control;
                panel.Controls.Add(childForm);
                panel.Tag = childForm;
                childForm.Show();
                panel.BringToFront();
            }
            else
            {
                panel.Controls[childForm.Name].Refresh();
                panel.BringToFront();
            }
            SetMenuTitleIcon(childForm);
            //MessageBox.Show($"{timer.ElapsedMilliseconds} ms");
        }

        private void OpenChildFormAsDialog(Form form)
        {
            Utils.BlurEffect.ShowDialogWithBlurEffect(form, this);
        }

        private void SetMenuTitleIcon(Form frm)
        {
            switch (frm.Text)
            {
                case "Home":
                    btnMenuTitle.Image = Properties.Resources.home_26px;
                    break;
                case "Dashboard":
                    btnMenuTitle.Image = Properties.Resources.pie_26px;
                    break;
                case "Manage Books":
                    btnMenuTitle.Image = Properties.Resources.books_26px;
                    break;
                case "Manage Students":
                    btnMenuTitle.Image = Properties.Resources.student_male_26px;
                    break;
                case "Manage Borrow/Return Books":
                    btnMenuTitle.Image = Properties.Resources.bookmark_26px;
                    break;
                case "Reports":
                    btnMenuTitle.Image = Properties.Resources.document_26px;
                    break;
                case "Recent Activity":
                    btnMenuTitle.Image = Properties.Resources.time_machine_26px;
                    break;
                case "Notification":
                    btnMenuTitle.Image = Properties.Resources.notification_26px;
                    break;
            }
            btnMenuTitle.Text = $"  {frm.Text}";
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // handle when user right click application in taskbar and
            //  click Close window instead of exit button
            if (!hasClickExitOrRestartButton)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    LibModule.LogTimestampUserLogout(user);
                    if (frmLogin != null)
                        frmLogin.Close();
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }

            // close notification if it existed
            if (niBookLoan.Visible == true)
            {
                niBookLoan.Icon.Dispose();
                niBookLoan.Dispose();
            }
        }

        private void FrmMainMenu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        #region Windows Popup Notification
        private void ShowBooksDueAndOverdueNotification()
        {
            niBookLoan.Visible = false;
            (string bookDue, string bookOverdue) book = LibModule.GetLoanBookDueAndOverdue();
            ShowNotificationBadge(book);
            if (book != ("0", "0"))
            {
                niBookLoan.Icon = SystemIcons.Information;
                niBookLoan.Visible = true;
                niBookLoan.BalloonTipClicked += Notication_BalloonTipClicked;
                niBookLoan.ShowBalloonTip(10000, "Borrowed Books Notification",
                    $"Due Today: {book.bookDue} book(s)\nOverdue: {book.bookOverdue} book(s)",
                    ToolTipIcon.Info);
                niBookLoan.Text = "Borrowed Books Notification";
                niBookLoan.Click += NiBookLoan_Click;
            }

            void NiBookLoan_Click(object sender, EventArgs e)
            {
                ActivateButton(btnNotification);
                OpenChildForm(new FrmNotification(), pNotification);
            }

            void Notication_BalloonTipClicked(object sender, EventArgs e)
            {
                ActivateButton(btnNotification);
                OpenChildForm(new FrmNotification(), pNotification);
            }

        }

        internal void ShowNotificationBadge((string due, string overdue) book)
        {
            if (book != ("0", "0"))
            {
                int bookCount = int.Parse(book.due) + int.Parse(book.overdue);
                lblNotificationBadge.Text = bookCount > 99 ? "99" : $"{bookCount}";
                lblNotificationBadge.Visible = true;
            }
            else lblNotificationBadge.Visible = false;
        }
        #endregion

        #region Maximize and Disable Form Border
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 15;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion
    }
}
