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
using LibraryDBMS.Forms;
using System.Runtime.DesignerServices;

namespace LibraryDBMS.Forms
{
    public partial class FrmBorrowBook : Form
    {
        public FrmBorrowBook()
        {
            InitializeComponent();
            InitializeValues();
        }

        private void InitializeValues()
        {
            Utils.FillComboBox(cbStatus, false, "Loaned", "Returned", "Lost");
            Utils.FillComboBox(cbSearchBy, true, "Book ID", "Student ID", "Title", "Name");
            PopulateDataGrid();
        }

        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewBorrowBook", dgvBorrowList, "borrowID");
            lblRecordCount.Text = "Total Record: " +
                LibModule.ExecuteScalarQuery("SELECT COUNT(borrowID) FROM viewBorrowBook;");
            lblBookLoanCount.Text = "Book Loan: " +
                LibModule.ExecuteScalarQuery
                ("SELECT COUNT(borrowID) FROM viewBorrowBook WHERE loanStatusName='Loaned';");
            lblBookLostCount.Text = "Book Lost: " +
                LibModule.ExecuteScalarQuery
                ("SELECT COUNT(borrowID) FROM viewBorrowBook WHERE loanStatusName='Lost';");
            (string due, string overdue) book = LibModule.HasLoanBookDueAndOverdue();
            lblBookDueCount.Text = "Book Due: " + book.due;
            lblBookOverdueCount.Text = "Book Overdue: " + book.overdue;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnSearch":
                    try
                    {
                        string searchBy = cbSearchBy.SelectedItem.ToString();
                        string value = txtSearchValue.Text.Trim();
                        if (value.Length > 0)
                        {
                            switch (searchBy)
                            {
                                case "Book ID":
                                    LibModule.SearchAndFillDataGrid("viewBorrowBook", "bookID", value, dgvBorrowList);
                                    break;
                                case "Student ID":
                                    LibModule.SearchAndFillDataGrid("viewBorrowBook", "studentID", value, dgvBorrowList);
                                    break;
                                case "Title":
                                    LibModule.SearchAndFillDataGrid("viewBorrowBook", "title", value, dgvBorrowList);
                                    break;
                                case "Name":
                                    LibModule.SearchAndFillDataGrid("viewBorrowBook", "fullName", value, dgvBorrowList);
                                    break;
                            }
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
                            LibModule.SearchBetweenDateAndFillDataGrid("viewBorrowBook", dgvBorrowList, "dateLoan", fromDate, toDate);
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
                    break;
                case "btnEdit":
                    try
                    {
                        string id = dgvBorrowList.SelectedRows[0].Cells["borrowID"].Value.ToString();
                        Form dialogReturnBook =
                            new DialogReturnBook(this, LibModule.GetSingleRecordDB("viewBorrowBook", "borrowID", id));
                        dialogReturnBook.ShowDialog();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please select a record!", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnDelete":
                    try
                    {
                        string borrowID = dgvBorrowList.SelectedRows[0].Cells["borrowID"].Value.ToString();
                        if(LibModule.DeleteRecord("tblBorrow", "borrowID", borrowID,
                            Utils.GetDataGridSelectedRowData(dgvBorrowList)) == true)
                            PopulateDataGrid();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please select a record!", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnView":
                    try
                    {
                        if (dgvBorrowList.SelectedRows[0].Cells[0].Value != null)
                        {
                            DialogViewDetail frmViewDetail = new DialogViewDetail(dgvBorrowList, "Borrow Book");
                            frmViewDetail.ShowDialog();
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please select a record!", "No record Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex >= 0)
            {
                switch (cbStatus.SelectedItem.ToString())
                {
                    case "Loaned":
                        LibModule.FilterByColumn("viewBorrowBook", dgvBorrowList, "loanStatusName", "Loaned");
                        break;
                    case "Returned":
                        LibModule.FilterByColumn("viewBorrowBook", dgvBorrowList, "loanStatusName", "Returned");
                        break;
                    case "Lost":
                        LibModule.FilterByColumn("viewBorrowBook", dgvBorrowList, "loanStatusName", "Lost");
                        break;
                    default:
                        break;
                } 
            }
        }
    }
}
