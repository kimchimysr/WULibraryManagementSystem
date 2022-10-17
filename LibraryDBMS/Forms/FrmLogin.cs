using LibraryDBMS.Forms;
using LibraryDBMS.Libs;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string hashedPassword = Utils.HashPassword(password);

                if (LibModule.IsValidLoginCredential(username, hashedPassword, out DataTable user))
                {
                    this.Hide();
                    var frmSplashScreen = new FrmSplashScreen();
                    frmSplashScreen.ShowDialog();
                    var frmMainMenu = new FrmMainMenu(this, user);
                    frmMainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Please provide valid crendentials");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong, please try again.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
                this.txtPassword.UseSystemPasswordChar = false;
            else this.txtPassword.UseSystemPasswordChar = true;
        }
    }
}
