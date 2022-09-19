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
using WesternLibraryManagementSystem.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmBorrowBook : Form
    {
        public FrmBorrowBook()
        {
            InitializeComponent();
        }

        private void FrmBorrowBook_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewBorrowBook", dgvBorrowList);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
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
                        LibModule.DeleteRecord("tblBorrow", "borrowID", borrowID,
                            Utils.GetDataGridSelectedRowData(dgvBorrowList));
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
                case "btnVIew":
                    break;
            }
        }
    }
}
