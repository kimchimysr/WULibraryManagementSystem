using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private FrmManageUser frmManageUser;
        private DataTable user;
        private bool isEditMode;

        public DialogAddEditUser(FrmManageUser frm, DataTable _user = null)
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
                btnClear.Enabled = false;
                txtUsername.ReadOnly = true;
            }
        }

        private bool IsValidData()
        {
            if (Utils.IsEmptyControl(this))
                return false;
            if (!isEditMode)
            {
                if (LibModule.CheckIfExist("tblUser", "username", txtUsername.Text.Trim(),
                    "Username already exists!"))
                    return false;
            }
            if (!Utils.IsValidEmail(txtEmail.Text.Trim()))
                return false;
            return true;
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
            if (IsValidData())
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

                    if (!isEditMode)
                    {
                        if (LibModule.InsertRecord("tblUser", LibModule.GetTableField("tblUser"),
                            user) == true)
                        {
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
                            LibModule.UpdateRecord("tblUserRole", LibModule.GetTableField("tblUserRole"),
                            "userID", userID, userRole, false);
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Utils.DoClearControl(this, false, true, false, false, false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
