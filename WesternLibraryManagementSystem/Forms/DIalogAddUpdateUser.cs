using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WesternLibraryManagementSystem.Libs;

namespace WesternLibraryManagementSystem.Forms
{
    public partial class DIalogAddUpdateUser : Form
    {
        private FrmManageUser frmManageUser;
        private DataTable user;
        private bool isEditMode;

        public DIalogAddUpdateUser(FrmManageUser frm, DataTable _user = null)
        {
            InitializeComponent();
            isEditMode = _user != null ? true : false;
            frmManageUser = frm;
            user = _user;
            Utils.FillComboBox(cbRole, "Admin", "Librarian", "Viewer");
            if (!isEditMode)
            {
                this.Text = "Add New User";
                lblHeader.Text = "New User";
                txtUserID.Text = LibModule.GetAutoID("tblUser", "userID");
            }
            else
            {
                lblHeader.Text = "Edit User";
                this.Text = "Edit User";
                PopulateFields();
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!Utils.IsEmptyControl(this))
            {
                try
                {
                    int cbSelectedIndex = cbRole.SelectedIndex;
                    string userID = txtUserID.Text.Trim();
                    string username = txtUsername.Text.Trim();
                    string password = Utils.DefaultHashPassword();
                    string roleID = (cbSelectedIndex + 1).ToString().Trim();
                    string isActive =
                        !isEditMode ? "1" : this.user.Rows[0]["isActive"].ToString().Trim();
                    string firstName = txtFirstName.Text.Trim();
                    string lastName = txtLastName.Text.Trim();
                    string gender = rbMale.Checked == true ? "M" : "F";
                    string dob = dtpDOB.Text.Trim();
                    string address = txtAddress.Text.Trim();
                    string telephone = txtTelephone.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string dateAdded =
                        !isEditMode ? DateTime.Now.ToString("dd-MM-yyyy") : this.user.Rows[0]["dateAdded"].ToString().Trim();

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

                    if (!isEditMode)
                    {
                        if (LibModule.InsertRecord("tblUser", LibModule.GetTableField("tblUser"),
                            user) == true)
                        {
                            List<string> userRole = new List<string>
                            {
                                userID,
                                roleID
                            };
                            LibModule.InsertRecord("tblUserRole", LibModule.GetTableField("tblUserRole"),
                            userRole, false);
                        }
                    }
                    else
                    {
                        // remove password field because editing password is not allowed
                        user.Remove(password);
                        if (LibModule.UpdateRecord("tblUser", LibModule.GetTableField("tblUser"),
                            "userID", userID, user, true, "password") == true)
                        {
                            List<string> editUserRole = new List<string>
                            {
                                userID,
                                roleID
                            };
                            LibModule.UpdateRecord("tblUserRole", LibModule.GetTableField("tblUserRole"),
                            "userID", userID, editUserRole, false);
                        }
                    }
                    frmManageUser.PopulateDataGridView();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Utils.DoClearControl(this, false, true, false, false, false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
