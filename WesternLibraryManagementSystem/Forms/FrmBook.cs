using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WesternLibraryManagementSystem.Libs;

namespace WesternLibraryManagementSystem.Forms
{
    public partial class FrmBook : Form
    {
        DataTable bringEditDataToOtherForm = new DataTable();
        public FrmBook()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnAdd":
                    try
                    {
                        Form form = new DialogAddUpdateBook(this);
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
                        string id = dgvBooks.SelectedRows[0].Cells["Column1"].Value.ToString();
                        Form frmAddEupdateBook =
                            new DialogAddUpdateBook(this, LibModule.GetSingleRecordDB("tblBook", "bookID", id));
                        frmAddEupdateBook.ShowDialog();
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}",ex.GetType()+"",MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;

                case "btnDelete":
                    string bookID = dgvBooks.SelectedRows[0].Cells["Column1"].Value.ToString();
                    //create dialog to check for delete confirmation from user
                    DialogResult result = MessageBox.Show($"Are your sure you want to Delete the Data From BookID: {bookID}",
                        "Confirmation Delection",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        LibModule.DeleteRecord("tblBook", "bookID", bookID);
                        FrmBook_Load(sender, e);
                    }
                    else { FrmBook_Load(sender, e); }
                    break;

                case "btnSearch":
                    this.Search();
                    break ;

                case "btnRefresh":
                    FrmBook_Load(sender, e);
                    break;
            }
        }
        


        private void FrmBook_Load(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnAdd.Enabled = true;
            this.cbbMeanOfSearch.SelectedIndex = -1;
            this.PopulateDataGridView();
        }
        internal DataTable DataTableDataGridViewBook { get; set; }
        private void Search()
        {
            try
            {
                if (this.txtSearch.Text.Length > 0)
                {
                    try
                    {
                        string searchBy = cbbMeanOfSearch.SelectedItem.ToString();
                        string value = this.txtSearch.Text.Trim();
                        if (searchBy == "BookID")
                        {
                            LibModule.SearchAndShow("tblBook", "bookID", value, dgvBooks);
                        }
                        else if (searchBy == "ISBN")
                        {
                            LibModule.SearchAndShow("tblBook", "isbn", value, dgvBooks);
                        }
                        else if (searchBy == "DEWEY")
                        {
                            LibModule.SearchAndShow("tblBook", "dewey", value, dgvBooks);
                        }
                        else if (searchBy == "Title")
                        {
                            LibModule.SearchAndShow("tblBook", "title", value, dgvBooks);
                        }
                        else if (searchBy == "Author")
                        {
                            LibModule.SearchAndShow("tblBook", "author", value, dgvBooks);
                        }
                        else if (searchBy == "Publisher")
                        {
                            LibModule.SearchAndShow("tblBook", "publisher", value, dgvBooks);
                        }
                        else if (searchBy == "Publish Year")
                        {
                            LibModule.SearchAndShow("tblBook", "publishYear", value, dgvBooks);
                        }
                        else
                        {
                            MessageBox.Show("Please Select something from the combobox", "Warning", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                            $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                    $"{ex.GetType()}", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        internal void PopulateDataGridView()
        {

            Utils.FillComboBox(cbbMeanOfSearch, "BookID", "ISBN", "DEWEY", "Title", "Author", "Publisher",
                "Publish Year");
            LibModule.FillDataGridView("tblBook", dgvBooks);
        }

        private void dgvBooks_Click(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = true;
            this.btnEdit.Enabled = true;
        }
    }
}
