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
    public partial class DialogAddEditStudent : Form
    {
        private FrmManageStudent frmManageStudent;
        private DataTable user;
        private bool isEditMode;

        public DialogAddEditStudent(FrmManageStudent frm, DataTable _user = null)
        {
            InitializeComponent();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            isEditMode = _user != null ? true : false;
            frmManageStudent = frm;
            user = _user;
            Utils.FillComboBox(cbYear, false, "1", "2", "3", "4");
            if (!isEditMode)
            {
                this.Text = "Add New Student";
                lblHeader.Text = "New Student";
            }
            else
            {
                lblHeader.Text = "Edit Student";
                this.Text = "Edit Student";
                btnSaveChanges.Size = new Size(355, 56);
                PopulateFields();
                btnClear.Visible = false;
                txtStudentID.ReadOnly = true;
            }
        }

        private bool IsValidData()
        {
            if (Utils.IsEmptyControl(this))
                return false;
            if (!isEditMode)
            {
                if (LibModule.CheckIfExist("tblStudent", "studentID", txtStudentID.Text.Trim(),
                    "Student ID is already exists!"))
                    return false;
            }
            return true;
        }

        private void PopulateFields()
        {
            // populate field using datatable user when isEditMode is true
            txtStudentID.Text = user.Rows[0]["studentID"].ToString();
            txtFirstName.Text = user.Rows[0]["firstName"].ToString();
            txtLastName.Text = user.Rows[0]["lastName"].ToString();
            if (user.Rows[0]["gender"].ToString().Equals("M"))
                rbMale.Checked = true;
            else rbFemale.Checked = true;
            cbYear.SelectedItem = user.Rows[0]["year"].ToString();
            txtMajor.Text = user.Rows[0]["major"].ToString();
            txtTel.Text = user.Rows[0]["tel"].ToString();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    string studentID = txtStudentID.Text.Trim();
                    string firstName = txtFirstName.Text.Trim();
                    string lastName = txtLastName.Text.Trim();
                    string gender = rbMale.Checked == true ? "M" : "F";
                    string year = cbYear.SelectedItem.ToString().Trim();
                    string major = txtMajor.Text.Trim();
                    string telephone = txtTel.Text.Trim();
                    string dateAdded =
                        !isEditMode ? DateTime.Now.ToString("yyyy-MM-dd") : this.user.Rows[0]["dateAdded"].ToString().Trim();

                    List<string> borrower = new List<string>
                    {
                        studentID,
                        firstName,
                        lastName,
                        gender,
                        year,
                        major,
                        telephone,
                        dateAdded
                    };

                    if (!isEditMode)
                    {
                        LibModule.InsertRecord("tblStudent", LibModule.GetTableField("tblStudent"), borrower);
                    }
                    else
                    {
                        LibModule.UpdateRecord("tblStudent", LibModule.GetTableField("tblStudent"),
                            "studentID", studentID, borrower, true);
                    }
                    frmManageStudent.PopulateDataGrid();
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

        private void btnClose_Click(object sender, EventArgs e)
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
