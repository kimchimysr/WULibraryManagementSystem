using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office.Word;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageBook : Form
    {
        private (int rowIndex, string bookID) selected;
        public FrmManageBook()
        {
            InitializeComponent();
            InitailizeValues();
        }

        private void InitailizeValues()
        {
            Utils.EnableControlDoubleBuffer(dgvBookList);
            Utils.FillComboBox(cbSearchBy, true, "Book ID", "ISBN", "DEWEY", "Title",
                "Author", "Publisher", "Publish Year");
            PopulateDataGridView();
        }

        internal void PopulateDataGridView()
        {
            LibModule.FillDataGrid("viewBook", dgvBookList, "bookID");
            lblBookCount.Text = "Total Books: " +
                    LibModule.ExecuteScalarQuery("SELECT SUM(qty) FROM tblBook;");
            lblTitleCount.Text = "Total Titles: " +
                    LibModule.ExecuteScalarQuery("SELECT COUNT(bookID) FROM tblBook;");
            lblRowsCount.Text = $"Total Result: {dgvBookList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnPrint":
                    Utils.PrintPreviewDataGridView("Books List", dgvBookList);
                    break;
                case "btnFind":
                    try
                    {
                        if (txtSearchValue.Text.Length > 0)
                        {
                            string searchBy = cbSearchBy.SelectedItem.ToString();
                            string value = txtSearchValue.Text.ToString().Trim();

                            if (searchBy == "Book ID")
                                LibModule.SearchAndFillDataGrid("tblBook", "bookID", value, dgvBookList);
                            else if (searchBy == "ISBN")
                                LibModule.SearchAndFillDataGrid("tblBook", "isbn", value, dgvBookList);
                            else if (searchBy == "DEWEY")
                                LibModule.SearchAndFillDataGrid("tblBook", "dewey", value, dgvBookList);
                            else if (searchBy == "Title")
                                LibModule.SearchAndFillDataGrid("tblBook", "title", value, dgvBookList);
                            else if (searchBy == "Author")
                                LibModule.SearchAndFillDataGrid("tblBook", "author", value, dgvBookList);
                            else if (searchBy == "Publisher")
                                LibModule.SearchAndFillDataGrid("tblBook", "publisher", value, dgvBookList);
                            else if (searchBy == "Publish Year")
                                LibModule.SearchAndFillDataGrid("tblBook", "publishYear", value, dgvBookList);
                            lblRowsCount.Text = $"Total Result: {dgvBookList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}", ex.GetType() + "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnFilter":
                    try
                    {
                        if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                        {
                            string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                            string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
                            LibModule.SearchBetweenDateAndFillDataGrid("tblBook", dgvBookList, "dateAdded", fromDate, toDate);
                            lblRowsCount.Text = $"Total Result: {dgvBookList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}", ex.GetType() + "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnAdd":
                    try
                    {
                        Form form = new DialogAddEditBook(this);
                        form.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                            $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnEdit":
                    try
                    {
                        Form frmAddEditBook =
                            new DialogAddEditBook(this, LibModule.GetSingleRecordFromDB("tblBook", "bookID", selected.bookID));
                        frmAddEditBook.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}", ex.GetType() + "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnDelete":
                    try
                    {
                        if (LibModule.DeleteRecord("tblBook", "bookID", selected.bookID,
                            Utils.GetDataGridSelectedRowData(dgvBookList, selected.rowIndex)) == true)
                            PopulateDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}", ex.GetType() + "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnView":
                    Form frmViewDetail = new DialogViewDetail(dgvBookList, selected.rowIndex, "Book");
                    frmViewDetail.ShowDialog();
                    break;
                case "btnRefresh":
                    PopulateDataGridView();
                    break;
            }
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected = (e.RowIndex, dgvBookList.Rows[e.RowIndex].Cells["borrowID"].Value.ToString());
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
            }
        }
    }
}
