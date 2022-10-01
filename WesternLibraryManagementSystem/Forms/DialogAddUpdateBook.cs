using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WesternLibraryManagement.Forms;
using WesternLibraryManagementSystem.Libs;

namespace WesternLibraryManagementSystem.Forms
{
    public partial class DialogAddUpdateBook : Form
    {
        private FrmBook frmBook;
        private DataTable dataTable;
        private bool isEditMode;

        public DialogAddUpdateBook()
        {
            InitializeComponent();
        }
        #region Method We write
        public DialogAddUpdateBook(FrmBook formOpenFromFrmBook,DataTable dataTableUser = null)
        {
            InitializeComponent();
            isEditMode = dataTableUser == null ? false : true;
            frmBook = formOpenFromFrmBook; 
            dataTable = dataTableUser;
            if (!isEditMode)
            {
                this.Text = "Adding New Book Data";
                this.lblBook.Text = "Add New Book Data";
                this.txtBookID.Text = LibModule.GetAutoID("tblBook","bookID");
                this.btnOperation.Text = "Add";
            }
            else
            {
                this.Text = " Editing Book Data";
                this.lblBook.Text = "Edit Book Data";
                this.btnOperation.Text = "Edit";
                this.PopulateFields();
            }
        }
        private void PopulateFields()
        {
            int index = 0;
            this.txtBookID.Text = dataTable.Rows[index]["bookID"].ToString();
            this.txtISBN.Text = dataTable.Rows[++index]["bookID"].ToString();
            this.txtDEWEYCode.Text = dataTable.Rows[++index]["deweyCode"].ToString();
            this.txtTitle.Text = dataTable.Rows[++index]["title"].ToString();
            this.txtAuthor.Text = dataTable.Rows[++index]["author"].ToString();
            this.txtPublisher.Text = dataTable.Rows[++index]["publisher"].ToString();
            this.dtpPublishYear.Value= Convert.ToDateTime(dataTable.Rows[++index]["publishYear"].ToString());
            this.txtPages.Text = dataTable.Rows[++index]["pages"].ToString();
            this.txtOthers.Text = dataTable.Rows[++index]["other"].ToString();
            this.txtQuantity.Text = dataTable.Rows[++index]["qty"].ToString();
            this.txtCategoryID.Text = dataTable.Rows[++index]["cateID"].ToString();
            this.dtpDateAdded.Value = Convert.ToDateTime(dataTable.Rows[++index]["bookID"].ToString());

        }
        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnOperation":
                    if (!Utils.IsEmptyControl(this))
                    {
                        try
                        {
                            string BookID = this.txtBookID.Text.Trim();
                            string ISBN = this.txtISBN.Text.Trim();
                            string DEWEYCode = this.txtDEWEYCode.Text.Trim();
                            string Title = this.txtTitle.Text.Trim();
                            string Author = this.txtAuthor.Text.Trim();
                            string Publisher = this.txtPublisher.Text.Trim();
                            string PublishYear =  this.dtpPublishYear.Value.ToString("yyyy");
                            string Pages = this.txtPages.Text.Trim();
                            string Other = this.txtOthers.Text.Trim();
                            string Quantity = this.txtQuantity.Text.Trim();
                            string CategoryID = this.txtCategoryID.Text.Trim();
                            string DateAdded = this.dtpDateAdded.Value.ToString("dd-MM-yyyy");
                            List<string> book = new List<string>()
                            {
                                BookID,
                                ISBN,
                                DEWEYCode,
                                Title,
                                Author,
                                Publisher,
                                PublishYear,
                                Pages,
                                Other,
                                Quantity,
                                CategoryID,
                                DateAdded
                            };
                            if (!isEditMode)
                            {
                                LibModule.InsertRecord("tblBook",LibModule.GetTableField("tblBooks"),book);
                            }
                            else
                            {
                                LibModule.UpdateRecord("tblBook", LibModule.GetTableField("tblBooks"), "bookID",BookID , book,true);
                            }
                            frmBook.PopulateDataGridView();
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Error Type: {ex.GetType()} \n Error Message: {ex.Message}", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Fill in info, Do not leave them hanging"," Lack Info ",MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                case "btnCategory":
                    Form formViewBookCategory = new FrmViewBookCategory();
                    formViewBookCategory.ShowDialog();
                    break ;
            }
        }
        #endregion


    }
}
