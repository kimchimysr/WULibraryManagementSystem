using LibraryDBMS.Forms;
using LibraryDBMS.Libs;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogReturnBook : Form
    {
        private readonly FrmBorrowBook frmBorrowBook;
        private readonly DataTable borrow;
        public DialogReturnBook(FrmBorrowBook frm, DataTable _borrow)
        {
            InitializeComponent();
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

        private void PopulateFields()
        {
            Utils.FillComboBox(cbStatus, "Loaned", "Returned", "Lost");
            txtBorrowID.Text = borrow.Rows[0]["borrowID"].ToString();
            txtBookID.Text = borrow.Rows[0]["bookID"].ToString();
            txtStudentID.Text = borrow.Rows[0]["studentID"].ToString();
            lblTitle.Text = borrow.Rows[0]["title"].ToString();
            lblName.Text = $"{borrow.Rows[0]["firstName"]} {borrow.Rows[0]["lastName"]}";
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
                        try
                        {
                            string borrowID = txtBorrowID.Text.Trim();
                            string bookID = txtBookID.Text.Trim();
                            string studentID = txtStudentID.Text.Trim();
                            // need to modify later
                            string userID = "1";
                            string dateLoan = dtpIssueDate.Text.ToString();
                            string dateDue = dtpDueDate.Text.ToString();
                            string dateReturned = dtpReturnDate.Text.ToString();
                            string fine = txtFine.Text.Trim();
                            string status = (cbStatus.SelectedIndex + 1).ToString();
                            List<string> updateStatus = new List<string>
                            {
                                borrowID,
                                bookID,
                                studentID,
                                userID,
                                dateLoan,
                                dateDue,
                                dateReturned,
                                fine,
                                status,
                                dateReturned
                            };

                            LibModule.UpdateRecord("tblBorrow", LibModule.GetTableField("tblBorrow"), "borrowID",
                                borrowID, updateStatus, true);
                            frmBorrowBook.PopulateDataGrid();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        } 
                    }
                    break;
                case "btnCancel":
                    break;
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpReturnDate.Value > dtpDueDate.Value)
            {
                int overdueDays = GetDaysWithoutWeekend(dtpDueDate.Value.Date, dtpReturnDate.Value.Date);
                int fine = overdueDays * 500;
                txtFine.Text = $"{fine:#,##0}";
            }
            else txtFine.Text = string.Empty;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem == "Returned")
                dtpReturnDate.Enabled = true;
            else dtpReturnDate.Enabled = false;
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
