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
    public partial class DialogIssueBook : Form
    {
        FrmBorrowBook frmBorrowBook;
        public DialogIssueBook(FrmBorrowBook _frmBorrowBook)
        {
            InitializeComponent();
            frmBorrowBook = _frmBorrowBook;
            InitailizeValues();
        }

        private void InitailizeValues()
        {
            txtBorrowID.Text = LibModule.GetAutoID("tblBorrow", "borrowID");
            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = dtpIssueDate.Value.Date.AddDays(GetDueDate(dtpIssueDate));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnSearchBookID":
                    try
                    {
                        if (txtBookID.Text.Length > 0)
                        {
                            LibModule.SearchAndShow("tblBook", "title", "bookID", txtBookID.Text.Trim(), lblTitle);
                            // check if the book qty > 0
                            string qty = LibModule.ExecuteScalarQuery
                                ($"SELECT qty FROM tblBook WHERE bookID='{txtBookID.Text.Trim()}'");
                            if (int.Parse(qty) > 0)
                            {
                                lblBookAvailability.ForeColor = Color.Green;
                                lblBookAvailability.Text = "Yes";
                            }
                            else
                            {
                                lblBookAvailability.ForeColor = Color.Red;
                                lblBookAvailability.Text = "No";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                            $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "btnSearchStudentID":
                    try
                    {
                        if (txtStudentID.Text.Length > 0)
                            LibModule.SearchAndShow("tblStudent", "firstName,lastName", "studentID", txtStudentID.Text.Trim(), lblName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                            $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "btnSave":
                    try
                    {
                        if (IsValidData())
                        {
                            string borrowID = txtBorrowID.Text.Trim();
                            string bookID = txtBookID.Text.Trim();
                            string studentID = txtStudentID.Text.Trim();
                            // userID is automatic
                            // need to modify later
                            string userID = "1";
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
                                userID,
                                dateLoan,
                                dateDue,
                                dateReturned,
                                overdueFine,
                                loanStatusID
                            };
                            if(LibModule.InsertRecord("tblBorrow", LibModule.GetTableField("tblBorrow"), issueBook) == true)
                            {
                                // reduce 1 qty of the loaned book
                                LibModule.ExecuteQuery($"UPDATE tblBook SET qty = qty - 1 WHERE bookID='{bookID}'");
                            }
                            frmBorrowBook.PopulateDataGrid();
                            this.Close();
                        }                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                            $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "btnClear":
                    Utils.DoClearControl(this, true, true, true, true, true,
                        "txtBookID", "txtStudentID", "lblBookAvailability", "dtpIssueDate");
                    break;
                case "btnCancel":
                    this.Close();
                    break;
            }
        }

        private bool IsValidData()
        {
            if (Utils.IsEmptyControl(this))
                return false;
            if (!LibModule.CheckIfExist("tblBook", "bookID", txtBookID.Text.Trim(), "", false))
            {
                MessageBox.Show("Please enter a valid book id!", "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!LibModule.CheckIfExist("tblStudent", "studentID", txtStudentID.Text.Trim(), "", false))
            {
                MessageBox.Show("Please enter a valid student id!", "Invalid Student ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // check if the student has already loan a book
            // each person can only loan 1 book at a time
            if (LibModule.ExecuteScalarQuery
                ($"SELECT borrowID FROM tblBorrow WHERE studentID='{txtStudentID.Text.Trim()}' AND loanStatusID='1';") != string.Empty)
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
