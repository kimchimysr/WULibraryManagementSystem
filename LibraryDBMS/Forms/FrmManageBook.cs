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
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageBook : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private (int rowIndex, string bookID) selected;
        public FrmManageBook(FrmMainMenu _frmMainMenu)
        {
            InitializeComponent();
            frmMainMenu = _frmMainMenu;
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
            LibModule.FillDataGrid("viewBooks", dgvBookList, "bookID");
            lblBookCount.Text = "Total Books: " +
                    LibModule.ExecuteScalarQuery("SELECT SUM(qty) FROM tblBooks;");
            lblTitleCount.Text = "Total Titles: " +
                    LibModule.ExecuteScalarQuery("SELECT COUNT(bookID) FROM tblBooks;");
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
                    Utils.BlurEffect.Blur(frmMainMenu);
                    Utils.PrintPreviewDataGridView("Books List", dgvBookList);
                    Utils.BlurEffect.UnBlur();
                    break;
                case "btnFind":
                    try
                    {
                        if (txtSearchValue.Text.Length > 0)
                        {
                            string searchBy = cbSearchBy.SelectedItem.ToString();
                            string value = txtSearchValue.Text.ToString().Trim();

                            if (searchBy == "Book ID")
                                LibModule.SearchAndFillDataGrid("viewBooks", "bookID", value, dgvBookList);
                            else if (searchBy == "ISBN")
                                LibModule.SearchAndFillDataGrid("viewBooks", "isbn", value, dgvBookList);
                            else if (searchBy == "DEWEY")
                                LibModule.SearchAndFillDataGrid("viewBooks", "dewey", value, dgvBookList);
                            else if (searchBy == "Title")
                                LibModule.SearchAndFillDataGrid("viewBooks", "title", value, dgvBookList);
                            else if (searchBy == "Author")
                                LibModule.SearchAndFillDataGrid("viewBooks", "author", value, dgvBookList);
                            else if (searchBy == "Publisher")
                                LibModule.SearchAndFillDataGrid("viewBooks", "publisher", value, dgvBookList);
                            else if (searchBy == "Publish Year")
                                LibModule.SearchAndFillDataGrid("viewBooks", "publishYear", value, dgvBookList);
                            lblRowsCount.Text = $"Total Result: {dgvBookList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
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
                            LibModule.SearchBetweenDateAndFillDataGrid("viewBooks", dgvBookList, "dateAdded", fromDate, toDate);
                            lblRowsCount.Text = $"Total Result: {dgvBookList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnAdd":
                    try
                    {
                        var dialogAddEditBook = new DialogAddEditBook(this);
                        Utils.BlurEffect.ShowDialogWithBlurEffect(dialogAddEditBook, frmMainMenu);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnEdit":
                    try
                    {
                        var frmAddEditBook =
                            new DialogAddEditBook(this, LibModule.GetSingleRecordFromDB("tblBooks", "bookID", selected.bookID));
                        Utils.BlurEffect.ShowDialogWithBlurEffect(frmAddEditBook, frmMainMenu);
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
                        if (LibModule.DeleteRecord("tblBooks", "bookID", selected.bookID,
                            Utils.GetDataGridSelectedRowData(dgvBookList, selected.rowIndex)) == true)
                            PopulateDataGridView();
                        Utils.BlurEffect.UnBlur();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnView":
                    var frmViewDetail = new DialogViewDetail(dgvBookList, selected.rowIndex, "Book");
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmViewDetail, frmMainMenu);
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
                selected = (e.RowIndex, dgvBookList.Rows[e.RowIndex].Cells["bookID"].Value.ToString());
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
            }
        }
    }
}
