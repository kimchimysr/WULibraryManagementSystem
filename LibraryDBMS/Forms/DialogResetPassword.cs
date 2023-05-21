using LibraryDBMS.Libs;
using System;
using System.Data;
using System.Windows.Forms;
namespace LibraryDBMS.Forms
{
    public partial class DialogResetPassword : Form
    {
        private DataTable user;

        public DialogResetPassword(DataTable user)
        {
            InitializeComponent();
            this.user = user;
            this.lblHeader.Text = $" Reset Password For {user.Rows[0]["username"]}";
        }

        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnSaveChanges":

                    if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()) ||
                        string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
                    {
                        MessageBox.Show("Please enter valid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txtNewPassword.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("Password should be atleast 3 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if ((txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim()))
                    {
                        MessageBox.Show("New Password and Confirm Password does not matched! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        string newPassword = Utils.HashPassword(txtNewPassword.Text.Trim());
                        string username = user.Rows[0]["username"].ToString();

                        string query = "UPDATE tblUser SET password=@val1 WHERE username=@val2;";
                        LibModule.ExecuteScalarQueryWithSQLiteParameters(query, "@val", newPassword, username);

                        MessageBox.Show("Password has been changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), " Error ", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnCancel":
                case "btnClose":
                    this.Close();
                    break;
            }
        }
    }
}