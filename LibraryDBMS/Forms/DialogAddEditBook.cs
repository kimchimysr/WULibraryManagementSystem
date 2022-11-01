using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Libs;
namespace LibraryDBMS.Forms
{
    public partial class DialogAddEditBook : Form
    {
        #region Global variable
        private FrmManageBook frmBook;
        private DataTable book;
        private bool isEditMode;
        private BookValidator bv;

        private int cateIDFromDEWEYCode { get; set; }
        private string DEWEYCode { get; set; }
        private int firstThreeDigitsOfDEWEYCode { get; set; }
        #endregion

        #region Method We write
        public DialogAddEditBook(FrmManageBook formOpenFromFrmBook,DataTable dataTableUser = null)
        {
            InitializeComponent();
            isEditMode = dataTableUser != null;
            frmBook = formOpenFromFrmBook; 
            book = dataTableUser;
            InitializeValues();
        }

        private void InitializeValues()
        {
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            bv = new BookValidator(txtISBN, txtDEWEYCode, txtTitle, txtAuthor, txtPublisher, txtYear, nudPages, nudQty);
            if (!isEditMode)
            {
                lblHeader.Text = "New Book";
                txtBookID.Text = LibModule.GetAutoID("tblBooks","bookID");
                dtpDateAdded.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                lblHeader.Text = "Edit Book";
                PopulateFields();
                btnClear.Visible = false;
            }
        }

        private void PopulateFields()
        {
            this.txtBookID.Text = book.Rows[0]["bookID"].ToString();
            this.txtISBN.Text = book.Rows[0]["isbn"].ToString();
            this.txtDEWEYCode.Text = book.Rows[0]["dewey"].ToString();
            this.txtTitle.Text = book.Rows[0]["title"].ToString();
            this.txtAuthor.Text = book.Rows[0]["author"].ToString();
            this.txtPublisher.Text = book.Rows[0]["publisher"].ToString();
            this.txtYear.Text= book.Rows[0]["publishYear"].ToString();
            this.nudPages.Text = book.Rows[0]["pages"].ToString();
            this.txtOthers.Text = book.Rows[0]["other"].ToString();
            this.nudQty.Text = book.Rows[0]["qty"].ToString();
            this.dtpDateAdded.Text = book.Rows[0]["dateAdded"].ToString();
        }

        private bool IsDuplicatedRecord()
        {
            

            return false;
        }

        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnSaveChanges":
                    if (this.ValidateChildren() && !IsDuplicatedRecord())
                    {
                        try
                        {
                            string BookID = txtBookID.Text.Trim();
                            string ISBN = txtISBN.Text.Trim();
                            string DEWEYCode = txtDEWEYCode.Text.Trim();
                            string Title = txtTitle.Text.Trim();
                            string Author = txtAuthor.Text.Trim();
                            string Publisher = txtPublisher.Text.Trim();
                            string PublishYear =  txtYear.Text.Trim();
                            string Pages = nudPages.Text.Trim();
                            string Other = txtOthers.Text.Trim();
                            string Quantity = nudQty.Text.Trim();
                            string CategoryID = 
                                CalculateCategoryIDFromDEWEYCode(int.Parse(txtDEWEYCode.Text.Substring(0, 3))).ToString();
                            string DateAdded = DateTime.Now.ToString("yyyy-MM-dd");

                            List<string> book = new List<string>
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
                                LibModule.InsertRecord("tblBooks",LibModule.GetTableField("tblBooks"),book);

                            }
                            else
                            {
                                LibModule.UpdateRecord("tblBooks", LibModule.GetTableField("tblBooks"),"bookID",BookID , book,true);
                            }
                            frmBook.PopulateDataGridView();
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}",
                                $"{ex.GetType()}", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else if (IsDuplicatedRecord())
                    {
                        MessageBox.Show("Book already exist!", "Duplicated Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Please Fill in info, Do not leave them hanging", " Lack Info ", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                case "btnClear":
                    this.txtISBN.Clear();
                    this.txtDEWEYCode.Clear();
                    this.txtTitle.Clear();
                    this.txtAuthor.Clear();
                    this.txtPublisher.Clear();
                    this.txtYear.Clear();
                    this.txtOthers.Clear();
                    this.dtpDateAdded.Value = DateTime.Now;
                    break;
                case "btnCancel":
                case "btnClose":
                    this.Close();
                    break;
            }
        }

        private int CalculateCategoryIDFromDEWEYCode(int DEWEYCode)
        {
            if (DEWEYCode > 0 && DEWEYCode <= 100) { return 1; }
            else if (DEWEYCode > 100 && DEWEYCode <= 200) { return 2; }
            else if (DEWEYCode > 200 && DEWEYCode <= 300) { return 3; }
            else if (DEWEYCode > 300 && DEWEYCode <= 400) { return 4; }
            else if (DEWEYCode > 400 && DEWEYCode <= 500) { return 5; }
            else if (DEWEYCode > 500 && DEWEYCode <= 600) { return 6; }
            else if (DEWEYCode > 600 && DEWEYCode <= 700) { return 7; }
            else if (DEWEYCode > 700 && DEWEYCode <= 800) { return 8; }
            else if (DEWEYCode > 800 && DEWEYCode <= 900) { return 9; }
            else if (DEWEYCode > 900 && DEWEYCode < 1000) { return 10; }
            else { return 11; }
        }
        #endregion
    }
}
