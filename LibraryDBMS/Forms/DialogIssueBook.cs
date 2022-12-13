using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogIssueBook : Form
    {
        private FrmManageBorrowBook frmBorrowBook;
        private IssueBookValidator ibv;
        public DialogIssueBook(FrmManageBorrowBook _frmBorrowBook)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            frmBorrowBook = _frmBorrowBook;
            InitailizeValues();
        }

        private void InitailizeValues()
        {
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            ibv = new IssueBookValidator(txtStudentID, txtBookID, lblBookTitle, lblStudentName, 
                lblBookAvailability, lblStudentStatus, lblBorrowedTitle);
            txtBorrowID.Text = LibModule.GetAutoID("tblBorrows", "borrowID");
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
                    using (var dialogSelectStudent = new DialogSelectStudent())
                    {
                        if (dialogSelectStudent.ShowDialog() == DialogResult.OK)
                            txtStudentID.Text = dialogSelectStudent.StudentID;
                    }
                    txtStudentID.Focus();
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
                        if (LibModule.InsertRecord("tblBorrows", LibModule.GetTableField("tblBorrows"), issueBook) == true)
                        {
                            // reduce 1 qty of the loaned book
                            LibModule.ExecuteQuery($"UPDATE tblBooks SET qty = qty - 1 WHERE bookID='{bookID}'");
                        }
                        frmBorrowBook.PopulateDataGrid();
                        this.Close();
                    }
                    else MessageBox.Show("Please enter valid data!", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "btnClear":
                    Utils.DoClearControl(this, true, true, true, true, true,
                        "txtBookID", "txtStudentID", "lblBookAvailability", "dtpIssueDate");
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
    }
}
