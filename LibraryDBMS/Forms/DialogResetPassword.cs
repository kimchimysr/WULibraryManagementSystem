using DocumentFormat.OpenXml.Wordprocessing;
using LibraryDBMS.Libs;
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
    public partial class DialogResetPassword : Form
    {
        private readonly DataTable user;
        public DialogResetPassword(DataTable _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = cbShowPass.Checked != true;
            txtConfirmNewPassword.UseSystemPasswordChar = cbShowPass.Checked != true;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text.Length > 5)
                {
                    string password = txtNewPassword.Text;
                    string confirmPassword = txtConfirmNewPassword.Text;

                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Password do not match, Please try again.");
                    }

                    string userID = user.Rows[0]["userID"].ToString();
                    password = Utils.HashPassword(password);

                    if (LibModule.ChangeUserPassword(userID, password))
                        MessageBox.Show("Password reset successfully.");
                    this.Close();
                }
                else MessageBox.Show("Password length must be more than 5 characters!", "Password Too Weak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured, please try again!");
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // does not allow whitespace whtn typing
            if (!char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
