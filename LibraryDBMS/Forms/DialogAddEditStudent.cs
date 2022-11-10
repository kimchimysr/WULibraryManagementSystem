using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogAddEditStudent : Form
    {
        private FrmManageStudent frmManageStudent;
        private DataTable user;
        private bool isEditMode;

        private StudentValidator sv;

        public DialogAddEditStudent(FrmManageStudent frm, DataTable _user = null)
        {
            InitializeComponent();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            isEditMode = _user != null;
            frmManageStudent = frm;
            user = _user;
            Utils.FillComboBox(cbYear, false, "1", "2", "3", "4");
            if (!isEditMode)
            {
                lblHeader.Text = "New Student";
                sv = new StudentValidator(txtStudentID, txtFirstName, txtLastName, cbYear, txtMajor, txtTel);
            }
            else
            {
                sv = new StudentValidator(null, txtFirstName, txtLastName, cbYear, txtMajor, txtTel);
                lblHeader.Text = "Edit Student";
                btnSaveChanges.Size = new Size(355, 56);
                PopulateFields();
                btnClear.Visible = false;
                txtStudentID.ReadOnly = true;
            }
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

        private bool HasAnyChanges()
        {
            string gender = rbMale.Checked ? "M" : "F";
            if (user.Rows[0]["studentID"].ToString() != txtStudentID.Text.Trim() ||
                user.Rows[0]["firstName"].ToString() != txtFirstName.Text.Trim() ||
                user.Rows[0]["lastName"].ToString() != txtLastName.Text.Trim() ||
                user.Rows[0]["gender"].ToString() != gender ||
                user.Rows[0]["year"].ToString() != cbYear.Text.Trim() ||
                user.Rows[0]["major"].ToString() != txtMajor.Text.Trim() ||
                user.Rows[0]["tel"].ToString() != txtTel.Text.Trim())
                return true;

            return false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnSaveChanges":
                    if (this.ValidateChildren())
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
                                !isEditMode ? DateTime.Now.ToString("yyyy-MM-dd") : user.Rows[0]["dateAdded"].ToString().Trim();

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
                                LibModule.InsertRecord("tblStudents", LibModule.GetTableField("tblStudents"), borrower);
                            }
                            else
                            {
                                if (HasAnyChanges())
                                {
                                    LibModule.UpdateRecord("tblStudents", LibModule.GetTableField("tblStudents"),
                                                        "studentID", studentID, borrower, true);
                                }
                            }
                            frmManageStudent.PopulateDataGrid();
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
