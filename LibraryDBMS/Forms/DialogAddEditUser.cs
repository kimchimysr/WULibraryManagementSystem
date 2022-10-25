using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogAddEditUser : Form
    {
        private readonly FrmManageUser frmManageUser;
        private DataTable user;
        private bool isEditMode;

        private UserValidator uv;

        public DialogAddEditUser(FrmManageUser frm, DataTable _user = null)
        {
            InitializeComponent();
            isEditMode = _user != null; // if null true, else false
            frmManageUser = frm;
            user = _user;
            InitializeValues();
        }

        private void InitializeValues()
        {
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FillComboBox(cbRole, false, "Admin", "Librarian", "Viewer");
            if (!isEditMode)
            {
                lblHeader.Text = "New User";
                txtUserID.Text = LibModule.GetAutoID("tblUser", "userID");
                uv = new UserValidator(txtUsername, txtFirstName, txtLastName, txtAddress, cbRole, txtTelephone, txtEmail); ;
            }
            else
            {
                lblHeader.Text = "Edit User";
                PopulateFields();
                btnClear.Visible = false;
                txtUsername.ReadOnly = true;
                uv = new UserValidator(null, txtFirstName, txtLastName, txtAddress, cbRole, txtTelephone, txtEmail); ;
            }
        }

        private void PopulateFields()
        {
            // populate field using datatable user when isEditMode is true
            txtUserID.Text = user.Rows[0]["userID"].ToString();
            txtUsername.Text = user.Rows[0]["username"].ToString();
            cbRole.SelectedItem = user.Rows[0]["roleName"].ToString();
            txtFirstName.Text = user.Rows[0]["firstName"].ToString();
            txtLastName.Text = user.Rows[0]["lastName"].ToString();
            if (user.Rows[0]["gender"].ToString().Equals("M"))
                rbMale.Checked = true;
            else rbFemale.Checked = true;
            dtpDOB.Text = user.Rows[0]["dob"].ToString();
            txtAddress.Text = user.Rows[0]["addr"].ToString();
            txtTelephone.Text = user.Rows[0]["tel"].ToString();
            txtEmail.Text = user.Rows[0]["email"].ToString();
        }

        private bool HasAnyChanges()
        {
            string gender = rbMale.Checked ? "M" : "F";
            if (user.Rows[0]["username"].ToString() != txtUsername.Text.Trim() ||
                user.Rows[0]["firstName"].ToString() != txtFirstName.Text.Trim() || 
                user.Rows[0]["lastName"].ToString() != txtLastName.Text.Trim() ||
                user.Rows[0]["addr"].ToString() != txtAddress.Text.Trim() ||
                user.Rows[0]["dob"].ToString() != dtpDOB.Text.Trim() ||
                user.Rows[0]["gender"].ToString() != gender || 
                user.Rows[0]["roleName"].ToString() != cbRole.Text.Trim() ||
                user.Rows[0]["tel"].ToString() != txtTelephone.Text.Trim() ||
                user.Rows[0]["email"].ToString() != txtEmail.Text.Trim())
                return true;

            return false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnSaveChanges":
                    if (this.ValidateChildren())
                    {
                        try
                        {
                            int cbSelectedIndex = cbRole.SelectedIndex;
                            string userID = txtUserID.Text.Trim();
                            string username = txtUsername.Text.Trim();
                            string password = Utils.DefaultHashPassword();
                            string roleID = (cbSelectedIndex + 1).ToString().Trim();
                            string isActive =
                                !isEditMode ? "Yes" : this.user.Rows[0]["isActive"].ToString().Trim();
                            string firstName = txtFirstName.Text.Trim();
                            string lastName = txtLastName.Text.Trim();
                            string gender = rbMale.Checked == true ? "M" : "F";
                            string dob = dtpDOB.Text.Trim();
                            string address = txtAddress.Text.Trim();
                            string telephone = txtTelephone.Text.Trim();
                            string email = txtEmail.Text.Trim();
                            string dateAdded =
                                !isEditMode ? DateTime.Now.ToString("yyyy-MM-dd") : this.user.Rows[0]["dateAdded"].ToString().Trim();

                            List<string> user = new List<string>
                            {
                                userID,
                                username,
                                password,
                                isActive,
                                firstName,
                                lastName,
                                gender,
                                dob,
                                address,
                                telephone,
                                email,
                                dateAdded
                            };

                            List<string> userRole = new List<string>
                            {
                                userID,
                                roleID
                            };

                            // Add New Book
                            if (!isEditMode)
                            {
                                if (LibModule.InsertRecord("tblUser", LibModule.GetTableField("tblUser"),
                                    user) == true)
                                {
                                    LibModule.InsertRecord("tblUserRole", LibModule.GetTableField("tblUserRole"),
                                    userRole, false);
                                }
                            }
                            else // Edit Book
                            {
                                if (HasAnyChanges())
                                {
                                    // remove password field because editing password is not allowed
                                    user.Remove(password);
                                    if (LibModule.UpdateRecord("tblUser", LibModule.GetTableField("tblUser"),
                                        "userID", userID, user, true, "password") == true)
                                    {
                                        LibModule.UpdateRecord("tblUserRole", LibModule.GetTableField("tblUserRole"),
                                        "userID", userID, userRole, false);
                                    }
                                }
                            }
                            frmManageUser.PopulateDataGrid();
                            this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                    }
                    else MessageBox.Show("Please enter valid data!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "btnClear":
                    Utils.DoClearControl(this, false, true, false, false, false);
                    break;
                case "btnCancel":
                case "btnClose":
                    this.Close();
                    break;
            }
        }
    }
}
