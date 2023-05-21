using LibraryDBMS.Libs;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
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
                    var frmMainMenu = new FrmMainMenu(this, user);
                    frmMainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect! Please check again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong, please try again.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
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
