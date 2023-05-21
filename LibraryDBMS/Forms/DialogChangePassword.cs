using LibraryDBMS.Libs;
using System;
using System.Windows.Forms;
namespace LibraryDBMS.Forms
{
    public partial class DialogChangePassword : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        public DialogChangePassword(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.frmMainMenu = frmMainMenu;
        }

        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnSaveChanges":
                    if (string.IsNullOrEmpty(txtOldPassword.Text.Trim()) ||
                        string.IsNullOrEmpty(txtNewPassword.Text.Trim()) ||
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

                    if (!IsCorrectOldPassword() || (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim()))
                    {
                        MessageBox.Show("Incorrect Old Password Or New Password and Confirm Password does not matched! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        string newPassword = Utils.HashPassword(txtNewPassword.Text.Trim());
                        string username = frmMainMenu.user.Rows[0]["username"].ToString();

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

        private bool IsCorrectOldPassword()
        {
            string username = frmMainMenu.user.Rows[0]["username"].ToString();
            string password = Utils.HashPassword(txtOldPassword.Text.Trim());
            string query = $"SELECT count(1) FROM tblUser WHERE username='{username}' and password='{password}' AND isActive='Yes';";
            bool isCorrectPassword = LibModule.ExecuteScalarQuery(query) == "1" ? true : false;

            return isCorrectPassword;
        }
    }
}