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

namespace LibraryDBMS.Forms
{
    public partial class FrmMainMenu : Form
    {
        FrmLogin frmLogin;
        public readonly (string username, string roleName) user;
        private Form currentChildForm;

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
            this.DoubleBuffered = true;
            int style = NativeWinAPI.GetWindowLong(this.panelChildForm.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnDashboard":
                    ActivateButton(btnDashboard);
                    break;
                case "btnManageBook":
                    ActivateButton(btnManageBook);
                    OpenChildForm(new FrmManageBook());
                    break;
                case "btnManageStudent":
                    ActivateButton(btnManageStudent);
                    OpenChildForm(new FrmManageStudent());
                    break;
                case "btnBookLoanReturn":
                    ActivateButton(btnBookLoanReturn);
                    OpenChildForm(new FrmBorrowBook());
                    break;
                case "btnReport":
                    ActivateButton(btnReport);
                    OpenChildForm(new FrmReportViewer());
                    break;
                case "btnManageUser":
                    ActivateButton(btnManageUser);
                    OpenChildForm(new FrmManageUser());
                    break;
                case "btnAccount":
                    ActivateButton(btnAccount);
                    OpenChildForm(new FrmBorrowBook());
                    break;
                case "btnNotification":
                    ActivateButton(btnNotification);
                    Stopwatch timer = Stopwatch.StartNew();

                    panelChildForm.Controls.Clear();
                    panelChildForm.Controls.Add(new UserControl1());
                    MessageBox.Show($"{timer.ElapsedMilliseconds} s");

                    break;
                case "btnSetting":
                    ActivateButton(btnSetting);
                    break;
            }
        }

        private void btnUserControl_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(new UserControl1());
        }

        private void ActivateButton(Button button)
        {
            panelSelected.Visible = true;
            panelSelected.Height = button.Height;
            panelSelected.Top = button.Top;
        }

        private void OpenChildForm(Form childForm)
        {
            Stopwatch timer = Stopwatch.StartNew();
            if (currentChildForm != null)
            {
                //open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            panelChildForm.Size = childForm.Size;
            this.Size = new Size(childForm.Width + 220, childForm.Height + 60);
            this.StartPosition = FormStartPosition.CenterScreen;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
            MessageBox.Show($"{timer.ElapsedMilliseconds} ms");
        }

        private void Reset()
        {
            //DisableButton();
            //leftBorderBtn.Visible = false;
            //iconCurrentChildForm.IconChar = IconChar.Home;
            //iconCurrentChildForm.IconColor = Color.WhiteSmoke;
            //lblTitleChildForm.Text = "Home";
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

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmLogin.Close();
        }
    }
}
