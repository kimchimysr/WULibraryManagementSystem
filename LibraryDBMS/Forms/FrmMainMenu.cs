using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using LibraryDBMS.Temp;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmMainMenu : Form
    {
        FrmLogin frmLogin;
        public readonly (string username, string roleName) user;
        Panel currentPanel;

        private Size formSize;
        private int borderSize = 2;

        public FrmMainMenu()
        {
            InitializeComponent();
            InitializeValues();
        }
        public FrmMainMenu(FrmLogin frm, (string, string) _user)
        {
            InitializeComponent();
            frmLogin = frm;
            user = _user;
            InitializeValues();
        }

        private void InitializeValues()
        {
            int style = NativeWinAPI.GetWindowLong(this.pHome.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.pHome.Handle, NativeWinAPI.GWL_EXSTYLE, style);
            ShowBooksDueAndOverdueNotification();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelSelected.Visible = false;
            OpenChildForm(new FrmDashboard(), pDashboard);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnDashboard":
                    ActivateButton(btnDashboard);
                    OpenChildForm(new FrmDashboard(), pDashboard);
                    break;
                case "btnManageBook":
                    ActivateButton(btnManageBook);
                    OpenChildForm(new FrmManageBook(), pManageBook);
                    break;
                case "btnManageStudent":
                    ActivateButton(btnManageStudent);
                    OpenChildForm(new FrmManageStudent(), pManageStudent);
                    break;
                case "btnBookLoanReturn":
                    ActivateButton(btnBookLoanReturn);
                    OpenChildForm(new FrmBorrowBook(), pBookLoanReturn);
                    break;
                case "btnReport":
                    ActivateButton(btnReport);
                    OpenChildForm(new FrmReportViewer(), pReport);
                    break;
                case "btnManageUser":
                    ActivateButton(btnManageUser);
                    OpenChildForm(new FrmManageUser(), pManageUser);
                    break;
                case "btnAccount":
                    ActivateButton(btnAccount);
                    //OpenChildForm(new FrmBorrowBook());
                    break;
                case "btnNotification":
                    ActivateButton(btnNotification);
                    //OpenUserControl(new UcManageStudent());
                    break;
                case "btnSetting":
                    ActivateButton(btnSetting);
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
                    Application.Exit();
                    break;
            }
        }

        private void ActivateButton(Button button)
        {
            panelSelected.Visible = true;
            panelSelected.Height = button.Height;
            panelSelected.Top = button.Top;
        }

        private void OpenChildForm(Form childForm, Panel panel)
        {
            Stopwatch timer = Stopwatch.StartNew();
            if (panel.Controls.Count == 0)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel.Controls.Add(childForm);
                panel.Tag = childForm;
                childForm.Show();
                panel.BringToFront();
            }
            else panel.BringToFront();
            //lblTitleChildForm.Text = childForm.Text;
            MessageBox.Show($"{timer.ElapsedMilliseconds} ms");
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmLogin.Close();
            niBookLoan.Icon.Dispose();
            niBookLoan.Dispose();
        }

        private void FrmMainMenu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ShowBooksDueAndOverdueNotification()
        {
            (string bookDue, string bookOverdue) book = LibModule.LoanBookDueAndOverdue();
            if (book != (string.Empty, string.Empty))
            {
                niBookLoan.Icon = SystemIcons.Information;
                niBookLoan.Visible = true;
                niBookLoan.BalloonTipClicked += Notication_BalloonTipClicked;
                niBookLoan.ShowBalloonTip(10000, "Loan Book Notification",
                    $"Due Today: {book.bookDue} book(s)\nOverdue: {book.bookOverdue} book(s)",
                    ToolTipIcon.Info);
            }
        }

        private void Notication_BalloonTipClicked(object sender, EventArgs e)
        {
            ActivateButton(btnBookLoanReturn);
            OpenChildForm(new FrmBorrowBook(), pBookLoanReturn);
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Wnd, int wMsg, int wParam, int lParam);

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

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
    }
}
