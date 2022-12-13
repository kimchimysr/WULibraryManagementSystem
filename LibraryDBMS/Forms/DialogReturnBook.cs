using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogReturnBook : Form
    {
        private readonly FrmManageBorrowBook frmBorrowBook;
        private readonly DataTable borrow;
        public DialogReturnBook(FrmManageBorrowBook frm, DataTable _borrow)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            frmBorrowBook = frm;
            borrow = _borrow;
            PopulateFields();
        }

        private bool IsValidData()
        {
            if (dtpReturnDate.Value < dtpIssueDate.Value)
            {
                MessageBox.Show("Return Date must be later than issue date!", "Invalid Return Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool HasAnyChanges()
        {
            if (borrow.Rows[0]["loanStatusName"].ToString() != cbStatus.Text.Trim())
                return true;

            if (string.IsNullOrEmpty(borrow.Rows[0]["dateReturned"].ToString()))
            {
                if (borrow.Rows[0]["loanStatusName"].ToString() != cbStatus.Text.Trim())
                    return true;
            }
            else
            {
                if (borrow.Rows[0]["dateReturned"].ToString() != dtpReturnDate.Text.Trim())
                    return true;
            }

            return false;
        }

        private void PopulateFields()
        {
            Utils.FillComboBox(cbStatus, false, "Borrowed", "Returned", "Lost");
            txtBorrowID.Text = borrow.Rows[0]["borrowID"].ToString();
            txtBookID.Text = borrow.Rows[0]["bookID"].ToString();
            txtStudentID.Text = borrow.Rows[0]["studentID"].ToString();
            lblTitle.Text = borrow.Rows[0]["title"].ToString();
            lblName.Text = borrow.Rows[0]["fullName"].ToString();
            dtpIssueDate.Value = DateTime.Parse(borrow.Rows[0]["dateLoan"].ToString());
            dtpDueDate.Value = DateTime.Parse(borrow.Rows[0]["dateDue"].ToString());
            dtpReturnDate.Value =
                borrow.Rows[0]["dateReturned"].ToString() != string.Empty ? 
                DateTime.Parse(borrow.Rows[0]["dateReturned"].ToString()) : DateTime.Today;
            txtFine.Text = borrow.Rows[0]["overdueFine"].ToString() != string.Empty ?
                borrow.Rows[0]["overdueFine"].ToString() : string.Empty;
            cbStatus.SelectedItem = borrow.Rows[0]["loanStatusName"].ToString();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnSave":
                    if (IsValidData())
                    {
                        string borrowID = txtBorrowID.Text.Trim();
                        string bookID = txtBookID.Text.Trim();
                        string studentID = txtStudentID.Text.Trim();
                        string dateLoan = dtpIssueDate.Text.ToString();
                        string dateDue = dtpDueDate.Text.ToString();
                        string dateReturned = cbStatus.SelectedItem.ToString() == "Returned" ?
                            dtpReturnDate.Text.ToString() : string.Empty;
                        string fine = txtFine.Text.Trim();
                        string status = (cbStatus.SelectedIndex + 1).ToString();
                        List<string> updateStatus = new List<string>
                            {
                                borrowID,
                                bookID,
                                studentID,
                                dateLoan,
                                dateDue,
                                dateReturned,
                                fine,
                                status,
                                dateReturned
                            };
                        if (HasAnyChanges())
                        {
                            LibModule.UpdateRecord("tblBorrows", LibModule.GetTableField("tblBorrows"), "borrowID",
                                borrowID, updateStatus, true);
                            frmBorrowBook.PopulateDataGrid();
                        }
                        this.Close();
                    }
                    break;
                case "btnCancel":
                case "btnClose":
                    this.Close();
                    break;
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateFine();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem.ToString() == "Returned")
            {
                dtpReturnDate.Enabled = true;
                CalculateFine();
            }
            else
            {
                dtpReturnDate.Enabled = false;
                txtFine.Text = string.Empty;
            }
        }

        private void CalculateFine()
        {
            if (dtpReturnDate.Value > dtpDueDate.Value)
            {
                int overdueDays = GetDaysWithoutWeekend(dtpDueDate.Value.Date, dtpReturnDate.Value.Date);
                int fine = overdueDays * 500;
                txtFine.Text = $"{fine:#,##0}";
            }
            else txtFine.Text = string.Empty;
        }

        private int GetDaysWithoutWeekend(DateTime dtStart, DateTime dtEnd)
        {
            int ndays = 1 + Convert.ToInt32((dtEnd - dtStart).TotalDays);
            int nsaturdays = (ndays + Convert.ToInt32(dtStart.DayOfWeek)) / 7;
            return ndays - 2 * nsaturdays
                   - (dtStart.DayOfWeek == DayOfWeek.Sunday ? 1 : 0)
                   + (dtEnd.DayOfWeek == DayOfWeek.Saturday ? 1 : 0) - 1;
        }
    }
}
