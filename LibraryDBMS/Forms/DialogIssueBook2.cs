using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogIssueBook2 : Form
    {
        private FrmManageBorrowBook frmBorrowBook;
        private IssueBookValidator2 ibv;
        public DialogIssueBook2(FrmManageBorrowBook _frmBorrowBook)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            frmBorrowBook = _frmBorrowBook;
            InitailizeValues();
        }

        private void InitailizeValues()
        {
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            btnSearchStudentID.Enabled = false;
            txtBorrowID.Text = LibModule.GetAutoID("tblBorrows", "borrowID");
            Utils.FillComboBox(cbYear, false, "1", "2", "3", "4");
            EnableAutoCompleteOnComboBoxMajor();
            ibv = new IssueBookValidator2(txtStudentID, txtBookID, txtFirstName, txtLastName, rbMale, rbFemale,
                cbYear, cbMajor, txtTel, dtpDateAdded, lblBookAvailability, lblStudentStatus, lblBorrowedTitle);
            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = dtpIssueDate.Value.Date.AddDays(GetDueDate(dtpIssueDate));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnSearchBookID":
                    using (var dialogSelectBook = new DialogSelectBook())
                    {
                        if (dialogSelectBook.ShowDialog() == DialogResult.OK)
                            txtBookID.Text = dialogSelectBook.BookID;
                    }
                    txtBookID.Focus();
                    break;
                case "btnSearchStudentID":
                    string studentExists = 
                        LibModule.ExecuteScalarQuery($"SELECT studentID FROM tblStudents WHERE studentID='{txtStudentID.Text.Trim()}';");
                    if (!string.IsNullOrEmpty(studentExists))
                    {
                        chbIsWUStudent.Enabled = false;
                        string query =
                        $"SELECT * FROM tblStudents WHERE studentID = '{txtStudentID.Text.Trim()}';";
                        DataTable result = LibModule.GetDataTableFromDBWithQuery(query);
                        if (result.Rows.Count > 0)
                        {
                            txtFirstName.Text = result.Rows[0]["firstName"].ToString();
                            txtLastName.Text = result.Rows[0]["lastName"].ToString();
                            LibModule.SetGender(result.Rows[0]["gender"].ToString(),rbMale,rbFemale,rbMonk);
                            cbYear.Text = result.Rows[0]["year"].ToString();
                            cbMajor.Text = result.Rows[0]["major"].ToString();
                            txtTel.Text = result.Rows[0]["tel"].ToString();
                            dtpDateAdded.Text = result.Rows[0]["dateAdded"].ToString();
                            chbIsWUStudent.Checked = (result.Rows[0]["isWUStudent"].ToString() == "1") ? true : false;
                            txtStudentOther.Text = result.Rows[0]["otherStudent"].ToString();
                        }

                        query = $"SELECT title,loanStatusName FROM viewBorrowedBooks " +
                            $"WHERE studentID = '{txtStudentID.Text.Trim()}' ORDER BY borrowID DESC LIMIT 1;";
                        result = LibModule.GetDataTableFromDBWithQuery(query);

                        if (result.Rows.Count > 0)
                        {
                            lblStudentStatus.Text = "";
                            lblBorrowedTitle.Text = "";
                            if (result.Rows[0]["loanStatusName"].ToString() == "Borrowed")
                                lblStudentStatus.Text = "Student Status: Currently borrowing 1 book";
                            else if (result.Rows[0]["loanStatusName"].ToString() == "Returned")
                                lblStudentStatus.Text = "Student Status: Returned last borrowed book";
                            else if (result.Rows[0]["loanStatusName"].ToString() == "Lost")
                                lblStudentStatus.Text = "Student Status: Lost last borrowed book";
                            lblBorrowedTitle.Text = $"Last Borrowed Title: {result.Rows[0]["title"]}"; 
                        }
                    }
                    else
                    {
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        rbMale.Checked = true;
                        cbYear.SelectedIndex = -1;
                        cbMajor.Text = "";
                        txtTel.Clear();
                        dtpDateAdded.Text = DateTime.Now.ToString("yyyy-MM-dd");
                        chbIsWUStudent.Checked = true;
                        txtStudentOther.Clear();
                        MessageBox.Show("Please enter new student information!", "Student ID doesn't exist!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "btnSave":
                    if (this.ValidateChildren() && IsValidData())
                    {
                        string borrowID = txtBorrowID.Text.Trim();
                        string bookID = txtBookID.Text.Trim();
                        string studentID = txtStudentID.Text.Trim();
                        string dateLoan = dtpIssueDate.Text.Trim();
                        string dateDue = dtpDueDate.Text.Trim();
                        string dateReturned = string.Empty;
                        string overdueFine = string.Empty;
                        // 1 == loaned
                        string loanStatusID = "1";

                        List<string> issueBook = new List<string>
                            {
                                borrowID,
                                bookID,
                                studentID,
                                dateLoan,
                                dateDue,
                                dateReturned,
                                overdueFine,
                                loanStatusID
                            };

                        StudentValidation();
                        LibModule.InsertRecord("tblBorrows", LibModule.GetTableField(DBTable.tblBorrows), issueBook);
                        frmBorrowBook.PopulateDataGrid();
                        this.Close();
                    }
                    else MessageBox.Show("Please enter valid data!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "btnClear":
                    Utils.DoClearControl(this, false, true, false, false, false);
                    btnSearchStudentID.Enabled = false;
                    cbMajor.Text = "";
                    lblBookAvailability.Text = "";
                    lblStudentStatus.Text = "Student Status: ";
                    lblBorrowedTitle.Text = "Last Borrowed Title: ";
                    break;
                case "btnCancel":
                case "btnClose":
                    this.Close();
                    break;
            }
        }

        private bool IsValidData()
        {
            // check if the student has already loan a book
            // each person can only loan 1 book at a time
            if (LibModule.ExecuteScalarQuery
                ($"SELECT borrowID FROM tblBorrows WHERE studentID='{txtStudentID.Text.Trim()}' AND loanStatusID='1';") != string.Empty)
            {
                MessageBox.Show("Each student can not loan more than 1 book at a time!", "Cannot Loan Book",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // check if the book is available to loan
            if (lblBookAvailability.Text == "No")
            {
                MessageBox.Show("Book is not available, cannot issue the book!", "Book is unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpIssueDate.Value > DateTime.Now)
            {
                dtpIssueDate.Value = DateTime.Now;
                return;
            }
            dtpDueDate.Value = dtpIssueDate.Value.Date.AddDays(GetDueDate(dtpIssueDate));
        }

        private void EnableAutoCompleteOnComboBoxMajor()
        {
            DataTable majorDt = LibModule.GetDataTableFromDBWithTableName("viewStudentMajors");
            Utils.EnableControlAutoComplete(cbMajor, majorDt);
        }

        private void StudentValidation()
        {
            string studentID = txtStudentID.Text.Trim();
            string query = $"SELECT * from tblStudents WHERE studentID='{studentID}';";
            DataTable student = LibModule.GetDataTableFromDBWithQuery(query);
            // student exist
            if (student.Rows.Count > 0)
            {
                // if there any changes, update student information
                if (StudentHasAnyChanges(student))
                {
                    string firstName = txtFirstName.Text.Trim();
                    string lastName = txtLastName.Text.Trim();
                    string gender = LibModule.GetGender(rbMale, rbFemale, rbMonk);
                    string year = cbYear.SelectedItem.ToString().Trim();
                    string major = cbMajor.Text.Trim();
                    string telephone = txtTel.Text.Trim();
                    string dateAdded = dtpDateAdded.Text.Trim();
                    string isWUStudent = (chbIsWUStudent.Checked) ? "1" : "0";
                    string otherBorrow = txtStudentOther.Text.Trim(); // data for other textbox

                    List<string> borrower = new List<string>
                    {
                        studentID,
                        firstName,
                        lastName,
                        gender,
                        year,
                        major,
                        telephone,
                        dateAdded,
                        isWUStudent,
                        otherBorrow
                    };

                    LibModule.UpdateRecord("tblStudents", LibModule.GetTableField(DBTable.tblStudents),
                                           "studentID", studentID, borrower, true);
                }
            }
            // insert new student
            else
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string gender = LibModule.GetGender(rbMale, rbFemale, rbMonk);
                string year = cbYear.SelectedItem.ToString().Trim();
                string major = cbMajor.Text.Trim();
                string telephone = txtTel.Text.Trim();
                string dateAdded = dtpDateAdded.Text.Trim();
                string isWUStudent = (chbIsWUStudent.Checked) ? "1" : "0";
                string otherBorrow = txtStudentOther.Text.Trim();

                List<string> borrower = new List<string>
                {
                    studentID,
                    firstName,
                    lastName,
                    gender,
                    year,
                    major,
                    telephone,
                    dateAdded,
                    isWUStudent,
                    otherBorrow
                };
                LibModule.InsertRecord("tblStudents", LibModule.GetTableField(DBTable.tblStudents), borrower);
            }
        }

        private bool StudentHasAnyChanges(DataTable student)
        {
            string gender = LibModule.GetGender(rbMale, rbFemale, rbMonk);
            string isWUStudentString = (chbIsWUStudent.Checked) ? "1" : "0";
            if (student.Rows[0]["studentID"].ToString() != txtStudentID.Text.Trim() ||
                student.Rows[0]["firstName"].ToString() != txtFirstName.Text.Trim() ||
                student.Rows[0]["lastName"].ToString() != txtLastName.Text.Trim() ||
                student.Rows[0]["gender"].ToString() != gender ||
                student.Rows[0]["year"].ToString() != cbYear.Text.Trim() ||
                student.Rows[0]["major"].ToString() != cbMajor.Text.Trim() ||
                student.Rows[0]["tel"].ToString() != txtTel.Text.Trim() ||
                student.Rows[0]["isWUStudent"].ToString() != isWUStudentString ||
                student.Rows[0]["otherstudent"].ToString() != txtStudentOther.Text.Trim())
                return true;

            return false;
        }

        private int GetDueDate(DateTimePicker dtp)
        {
            // the loan duration is 7 days
            // make sure due date is weekday and not weekend
            switch (dtp.Value.Date.AddDays(7).DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return 9;
                case DayOfWeek.Sunday:
                    return 8;
                default:
                    return 7;
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            Utils.searchButtonTextChanged(sender, btnSearchStudentID);
        }

        private void chbIsWUStudent_CheckedChanged(object sender, EventArgs e)
        {
            txtStudentID.ReadOnly = (chbIsWUStudent.Checked) ? false : true;
            txtStudentID.Text = LibModule.GenerateIDForNonWUStudent();
            if(chbIsWUStudent.Checked )
                txtStudentID.Clear();
        }
    }
}
