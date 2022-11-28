using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using LibraryDBMS.Libs;
using Color = System.Drawing.Color;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageBorrowBook : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private (int rowIndex, string borrowID) selected;

        public FrmManageBorrowBook()
        {
            InitializeComponent();
            InitializeValues();
        }
        
        public FrmManageBorrowBook(FrmMainMenu frm)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            InitializeValues();
            frmMainMenu = frm;
        }

        private void InitializeValues()
        {
            Utils.EnableControlDoubleBuffer(dgvBorrowList);
            Utils.FillComboBox(cbStatus, false, "Borrowed", "Returned", "Lost");
            Utils.FillComboBox(cbSearchBy, true, "Borrow ID", "Book ID", "Student ID", "Title", "Name");
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvBorrowList);
            Utils.ToolTipOnControlMouseHover
                ("Shortcuts Combination Key:" +
                 "\n* Add Button (Alt + A)" +
                 "\n* Edit Button (Alt + E)" +
                 "\n* Delete Button (Alt + D)" +
                 "\n* View Information Button (Alt + V)", pShortcuts);
            PopulateDataGrid();
            btnPrint.Enabled = dgvBorrowList.RowCount > 0 ? true : false;
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
            lblRowsCount.Text = $"Display Result: {dgvBorrowList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            txtSearchValue.Clear();
            btnSearch.Enabled = false;
            Utils.SetFromDateAYearFromNow(dtpFromDate,dtpToDate);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPrint":
                    Utils.BlurEffect.Blur(frmMainMenu);
                    var parameters = new Dictionary<string, string>();
                    parameters.Add("username", frmMainMenu.user.Rows[0]["username"].ToString());
                    parameters.Add("bookReturnedCount", "-");
                    parameters.Add("bookLostCount", lblBookLostCount.Text.Substring(11));
                    var dialogReportViewer = new DialogReportViewer(dgvBorrowList,
                        "LibraryDBMS.Reports.RpBorrowBook.rdlc", "BorrowBook", parameters);
                    dialogReportViewer.ShowDialog();
                    Utils.BlurEffect.UnBlur();
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
                            lblRowsCount.Text = $"Display Result: {dgvBorrowList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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
                            lblRowsCount.Text = $"Display Result: {dgvBorrowList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnAdd":
                    var dialogIssueBook = new DialogIssueBook(this);
                    Utils.BlurEffect.ShowDialogWithBlurEffect(dialogIssueBook, frmMainMenu);
                    CheckBookLoanNotificationChanged();
                    break;
                case "btnEdit":
                    try
                    {
                        var dialogReturnBook =
                            new DialogReturnBook(this, LibModule.GetSingleRecordFromDB("viewBorrowedBooks", "borrowID", selected.borrowID));
                        Utils.BlurEffect.ShowDialogWithBlurEffect(dialogReturnBook, frmMainMenu);
                        CheckBookLoanNotificationChanged();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnDelete":
                    try
                    {
                        Utils.BlurEffect.Blur(frmMainMenu);
                        if(LibModule.DeleteRecord("tblBorrows", "borrowID", selected.borrowID,
                            Utils.GetDataGridSelectedRowData(dgvBorrowList, selected.rowIndex)) == true)
                        {
                            PopulateDataGrid();
                            CheckBookLoanNotificationChanged();
                        }
                        Utils.BlurEffect.UnBlur();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnView":
                    var frmViewDetail = new DialogViewDetail(dgvBorrowList, selected.rowIndex, "Borrow Book");
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmViewDetail, frmMainMenu);
                    break;
            }
            btnPrint.Enabled = dgvBorrowList.RowCount > 0 ? true : false;
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
                lblRowsCount.Text = $"Display Result: {dgvBorrowList.Rows.Count}";
            }
        }

        private void CheckBookLoanNotificationChanged()
        {
            // check if there are no book due or overdue then disable the notification in system tray
            (string bookDue, string bookOverdue) book = LibModule.GetLoanBookDueAndOverdue();
            if (book == ("0", "0") && frmMainMenu.niBookLoan != null)
                frmMainMenu.niBookLoan.Visible = false;

            frmMainMenu.ShowNotificationBadge(book);
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

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            Utils.searchButtonTextChanged(sender, btnSearch);
            if (txtSearchValue.Text.Length == 0)
                btnRefresh.PerformClick();
        }

        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearchValue.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                // disable beep sounde
                //e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // format datagrid event. Check this link below for more info 
        // https://www.aspsnippets.com/Articles/Change-DataGridView-Cell-Color-based-on-condition-in-Windows-Application-using-C-and-VBNet.aspx
        private void dgvBorrowList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                string loanStatus = e.Value.ToString();
                if (loanStatus == "Borrowed")
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 235, 0); // yellow
                }
                else if (loanStatus == "Returned")
                {
                    e.CellStyle.BackColor = Color.FromArgb(144, 238, 145); // green
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 73, 109); // red
                }
            }
        }
    }
}