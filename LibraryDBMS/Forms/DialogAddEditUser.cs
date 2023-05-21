using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogAddEditUser : Form
    {
        private FrmManageUser frmManageUser;
        private DataTable user;
        private bool isEditMode;
        private UserValidator uv;

        public DialogAddEditUser(FrmManageUser frm, DataTable _user = null)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            isEditMode = _user != null;
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
                //dtpDateAdded.Text = DateTime.Now.ToString("yyyy-MM-dd");
                uv = new UserValidator(txtUsername, txtFirstName, txtLastName, txtAddress, cbRole, txtTelephone, txtEmail);
            }
            else
            {
                lblHeader.Text = "Edit User";
                PopulateFields();
                btnClear.Visible = false;
                txtUsername.ReadOnly = true;
                uv = new UserValidator(txtUsername, txtFirstName, txtLastName, txtAddress, cbRole, txtTelephone, txtEmail);
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
            string gender = LibModule.GetGender(rbMale, rbFemale, rbMonk);
            if (user.Rows[0]["username"].ToString() != txtUsername.Text.Trim() ||
                user.Rows[0]["firstName"].ToString() != txtFirstName.Text.Trim() ||
                user.Rows[0]["lastName"].ToString() != txtLastName.Text.Trim() ||
                user.Rows[0]["gender"].ToString() != gender ||
                user.Rows[0]["dob"].ToString() != dtpDOB.Text.Trim() ||
                user.Rows[0]["addr"].ToString() != txtAddress.Text.Trim() ||
                user.Rows[0]["tel"].ToString() != txtTelephone.Text.Trim() || 
                user.Rows[0]["email"].ToString() != txtEmail.Text.Trim() ||
                user.Rows[0]["roleName"].ToString() != cbRole.SelectedText.Trim())
                return true;

            return false;
        }

        private bool IsDuplicatedRecord()
        {
            string username = txtUsername.Text.Trim();

            string query = $"SELECT (1) FROM tblUser WHERE username=@val1;";

            if (!string.IsNullOrEmpty(LibModule.ExecuteScalarQueryWithSQLiteParameters
                (query, "@val", username)))
                return true;

            return false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnSaveChanges":
                    if (this.ValidateChildren())
                    {
                        string UserID = txtUserID.Text.Trim();
                        string Username = txtUsername.Text.Trim();
                        string Password = Utils.DefaultHashPassword();
                        string IsActive = "Yes";
                        string FirstName = txtFirstName.Text.Trim();
                        string LastName = txtLastName.Text.Trim();
                        string Gender = LibModule.GetGender(rbMale, rbFemale, rbMonk);
                        string DOB = dtpDOB.Text.Trim();
                        string Address = txtAddress.Text.Trim();
                        string Tel = txtTelephone.Text.Trim();
                        string Email = txtEmail.Text.Trim();
                        string DateAdded = DateTime.Now.ToString("yyyy-MM-dd");

                        List<string> user;
                        if (!isEditMode)
                        {
                            user = new List<string>
                            {
                                UserID,
                                Username,
                                Password,
                                IsActive,
                                FirstName,
                                LastName,
                                Gender,
                                DOB,
                                Address,
                                Tel,
                                Email,
                                DateAdded
                            };
                        }
                        else
                        {
                            user = new List<string>
                            {
                                UserID,
                                Username,
                                FirstName,
                                LastName,
                                Gender,
                                DOB,
                                Address,
                                Tel,
                                Email,
                                DateAdded
                            };
                        }


                        string RoleID = (cbRole.SelectedIndex + 1).ToString();

                        List<string> userRole = new List<string>
                        {
                            UserID,
                            RoleID
                        };

                        if (!isEditMode)
                        {
                            if (!IsDuplicatedRecord())
                            {
                                LibModule.InsertRecord("tblUser", LibModule.GetTableField(DBTable.tblUser), user);
                                LibModule.InsertRecord("tblUserRole", LibModule.GetTableField(DBTable.tblUserRole), userRole);

                                frmManageUser.PopulateDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("Username already exist!", "Duplicated Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (HasAnyChanges())
                            {
                                // 1 = Admin Role
                                // cannot change role of admin to other role if there's only 1 admin left
                                if (this.user.Rows[0]["roleName"].ToString().ToLower() == "admin")
                                    if (cbRole.SelectedItem.ToString().Trim().ToLower() != "admin")
                                        if (Utils.GetAmountOfActiveAdminUser() == 1)
                                        {
                                            MessageBox.Show("Active admin user must be at least 1! Cannot change role of current user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }

                                LibModule.UpdateRecord("tblUser", LibModule.GetTableField(DBTable.tblUser), "userID", UserID, user, false,"isActive","password");
                                LibModule.UpdateRecord("tblUserRole", LibModule.GetTableField(DBTable.tblUserRole), "userID", UserID, userRole, true);
                                frmManageUser.PopulateDataGrid();
                            }
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Input Valid data", " Lack Info ", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                case "btnClear":
                    this.txtUsername.Clear();
                    this.txtFirstName.Clear();
                    this.txtLastName.Clear();
                    this.txtAddress.Clear();
                    this.txtTelephone.Clear();
                    this.dtpDOB.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    break;
                case "btnCancel":
                case "btnClose":
                    this.Close();
                    break;
            }
        }

    }

}
