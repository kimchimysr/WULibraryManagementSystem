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
using System.Runtime.DesignerServices;

namespace LibraryDBMS.Forms
{
    public partial class FrmBorrowBook : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private (int rowIndex, string borrowID) selected;

        public FrmBorrowBook()
        {
            InitializeComponent();
            InitializeValues();
        }
        
        public FrmBorrowBook(FrmMainMenu frm)
        {
            InitializeComponent();
            InitializeValues();
            frmMainMenu = frm;
        }

        private void InitializeValues()
        {
            Utils.EnableControlDoubleBuffer(dgvBorrowList);
            Utils.FillComboBox(cbStatus, false, "Borrowed", "Returned", "Lost");
            Utils.FillComboBox(cbSearchBy, true, "Borrow ID", "Book ID", "Student ID", "Title", "Name");
            PopulateDataGrid();
        }

        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewBorrowedBooks", dgvBorrowList, "borrowID");
            lblRecordCount.Text = "Total Record: " +
                LibModule.ExecuteScalarQuery("SELECT COUNT(borrowID) FROM viewBorrowedBooks;");
            lblBookLoanCount.Text = "Book Loan: " +
                LibModule.ExecuteScalarQuery
                ("SELECT COUNT(borrowID) FROM viewBorrowedBooks WHERE loanStatusName='Borrowed';");
            lblBookLostCount.Text = "Book Lost: " +
                LibModule.ExecuteScalarQuery
                ("SELECT COUNT(borrowID) FROM viewBorrowedBooks WHERE loanStatusName='Lost';");
            (string due, string overdue) book = LibModule.GetLoanBookDueAndOverdue();
            lblBookDueCount.Text = "Book Due: " + book.due;
            lblBookOverdueCount.Text = "Book Overdue: " + book.overdue;
            lblRowsCount.Text = $"Total Result: {dgvBorrowList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPrint":
                    Utils.PrintPreviewDataGridView("Book Loan List", dgvBorrowList);
                    break;
                case "btnSearch":
                    try
                    {
                        if (txtSearchValue.Text.Length > 0)
                        {
                            string searchBy = cbSearchBy.SelectedItem.ToString();
                            string value = txtSearchValue.Text.Trim();
                            switch (searchBy)
                            {
                                case "Borrow ID":
                                    LibModule.SearchAndFillDataGrid("viewBorrowedBooks", "borrowID", value, dgvBorrowList);
                                    break;
                                case "Book ID":
                                    LibModule.SearchAndFillDataGrid("viewBorrowedBooks", "bookID", value, dgvBorrowList);
                                    break;
                                case "Student ID":
                                    LibModule.SearchAndFillDataGrid("viewBorrowedBooks", "studentID", value, dgvBorrowList);
                                    break;
                                case "Title":
                                    LibModule.SearchAndFillDataGrid("viewBorrowedBooks", "title", value, dgvBorrowList);
                                    break;
                                case "Name":
                                    LibModule.SearchAndFillDataGrid("viewBorrowedBooks", "fullName", value, dgvBorrowList);
                                    break;
                            }
                            lblRowsCount.Text = $"Total Result: {dgvBorrowList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnRefresh":
                    cbStatus.SelectedIndex = -1;
                    PopulateDataGrid();
                    break;
                case "btnFilter":
                    try
                    {
                        if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                        {
                            string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                            string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
                            LibModule.SearchBetweenDateAndFillDataGrid("viewBorrowedBooks", dgvBorrowList, "dateLoan", fromDate, toDate);
                            lblRowsCount.Text = $"Total Result: {dgvBorrowList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnAdd":
                    DialogIssueBook dialogIssueBook = new DialogIssueBook(this);
                    dialogIssueBook.ShowDialog();
                    CheckBookLoanNotificationChanged();
                    break;
                case "btnEdit":
                    try
                    {
                        Form dialogReturnBook =
                            new DialogReturnBook(this, LibModule.GetSingleRecordFromDB("viewBorrowedBooks", "borrowID", selected.borrowID));
                        dialogReturnBook.ShowDialog();
                        CheckBookLoanNotificationChanged();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnDelete":
                    try
                    {
                        if(LibModule.DeleteRecord("tblBorrows", "borrowID", selected.borrowID,
                            Utils.GetDataGridSelectedRowData(dgvBorrowList, selected.rowIndex)) == true)
                        {
                            PopulateDataGrid();
                            CheckBookLoanNotificationChanged();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnView":
                    DialogViewDetail frmViewDetail = new DialogViewDetail(dgvBorrowList, selected.rowIndex, "Borrow Book");
                    frmViewDetail.ShowDialog();
                    break;
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex >= 0)
            {
                switch (cbStatus.SelectedItem.ToString())
                {
                    case "Borrowed":
                        LibModule.FilterByColumn("viewBorrowedBooks", dgvBorrowList, "loanStatusName", "Borrowed");
                        break;
                    case "Returned":
                        LibModule.FilterByColumn("viewBorrowedBooks", dgvBorrowList, "loanStatusName", "Returned");
                        break;
                    case "Lost":
                        LibModule.FilterByColumn("viewBorrowedBooks", dgvBorrowList, "loanStatusName", "Lost");
                        break;
                    default:
                        break;
                }
                lblRowsCount.Text = $"Total Result: {dgvBorrowList.Rows.Count}";
            }
        }

        private void CheckBookLoanNotificationChanged()
        {
            // check if there are no book due or overdue then disable the notification in system tray
            (string bookDue, string bookOverdue) book = LibModule.GetLoanBookDueAndOverdue();
            if (book == ("0", "0") && frmMainMenu.niBookLoan != null)
                frmMainMenu.niBookLoan.Visible = false;
        }

        private void dgvBorrowList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected = (e.RowIndex, dgvBorrowList.Rows[e.RowIndex].Cells["borrowID"].Value.ToString());
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
            }
        }
    }
}