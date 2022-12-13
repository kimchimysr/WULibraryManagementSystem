using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogAddEditStudent : Form
    {
        private FrmManageStudent frmManageStudent;
        private DataTable student;
        private bool isEditMode;

        private StudentValidator sv;

        public DialogAddEditStudent(FrmManageStudent frm, DataTable _student = null)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            isEditMode = _student != null;
            frmManageStudent = frm;
            student = _student;
            Utils.FillComboBox(cbYear, false, "1", "2", "3", "4");
            EnableAutoCompleteOnComboBoxMajor();
            if (!isEditMode)
            {
                lblHeader.Text = "New Student";
                sv = new StudentValidator(txtStudentID, txtFirstName, txtLastName, cbYear, cbMajor, txtTel);
            }
            else
            {
                sv = new StudentValidator(null, txtFirstName, txtLastName, cbYear, cbMajor, txtTel);
                lblHeader.Text = "Edit Student";
                btnSaveChanges.Size = new Size(365, 56);
                PopulateFields();
                btnClear.Visible = false;
                txtStudentID.ReadOnly = true;
            }
        }

        private void EnableAutoCompleteOnComboBoxMajor()
        {
            DataTable majorDt = LibModule.GetDataTableFromDBWithTableName("viewStudentMajors");
            Utils.EnableControlAutoComplete(cbMajor, majorDt);
        }

        private void PopulateFields()
        {
            // populate field using datatable user when isEditMode is true
            txtStudentID.Text = student.Rows[0]["studentID"].ToString();
            txtFirstName.Text = student.Rows[0]["firstName"].ToString();
            txtLastName.Text = student.Rows[0]["lastName"].ToString();
            if (student.Rows[0]["gender"].ToString().Equals("M"))
                rbMale.Checked = true;
            else rbFemale.Checked = true;
            cbYear.SelectedItem = student.Rows[0]["year"].ToString();
            cbMajor.Text = student.Rows[0]["major"].ToString();
            txtTel.Text = student.Rows[0]["tel"].ToString();
            dtpDateAdded.Text = student.Rows[0]["dateAdded"].ToString();
        }

        private bool HasAnyChanges()
        {
            string gender = rbMale.Checked ? "M" : "F";
            if (student.Rows[0]["studentID"].ToString() != txtStudentID.Text.Trim() ||
                student.Rows[0]["firstName"].ToString() != txtFirstName.Text.Trim() ||
                student.Rows[0]["lastName"].ToString() != txtLastName.Text.Trim() ||
                student.Rows[0]["gender"].ToString() != gender ||
                student.Rows[0]["year"].ToString() != cbYear.Text.Trim() ||
                student.Rows[0]["major"].ToString() != cbMajor.Text.Trim() ||
                student.Rows[0]["tel"].ToString() != txtTel.Text.Trim())
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
                        string studentID = txtStudentID.Text.Trim();
                        string firstName = txtFirstName.Text.Trim();
                        string lastName = txtLastName.Text.Trim();
                        string gender = rbMale.Checked == true ? "M" : "F";
                        string year = cbYear.SelectedItem.ToString().Trim();
                        string major = cbMajor.Text.Trim();
                        string telephone = txtTel.Text.Trim();
                        string dateAdded = dtpDateAdded.Text.Trim();

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
                            frmManageStudent.PopulateDataGrid();
                        }
                        else
                        {
                            if (HasAnyChanges())
                            {
                                LibModule.UpdateRecord("tblStudents", LibModule.GetTableField("tblStudents"),
                                                    "studentID", studentID, borrower, true);
                                frmManageStudent.PopulateDataGrid();
                            }
                        }
                        this.Close();
                    }
                    else MessageBox.Show("Please enter valid data!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "btnClear":
                    Utils.DoClearControl(this, false, true, false, false, false);
                    cbMajor.Text = "";
                    break;
                case "btnCancel":
                case "btnClose":
                    this.Close();
                    break;
            }
        }
    }
}
