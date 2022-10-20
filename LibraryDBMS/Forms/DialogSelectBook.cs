using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogSelectBook : Form
    {
        public string BookID { get; set; }

        public DialogSelectBook()
        {
            InitializeComponent();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            string query = "SELECT bookID,title,author,qty FROM tblBook ORDER BY bookID DESC LIMIT 50";
            LibModule.FillDataGrid(query, dgvBookList);
            btnSelect.Enabled = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnFind":
                    try
                    {
                        if (txtSearchValue.Text.Length > 0)
                        {
                            string value = txtSearchValue.Text.ToString().Trim();
                            LibModule.SearchAndFillDataGrid("tblBook", "title", value, dgvBookList);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnRefresh":
                    PopulateDataGrid();
                    break;
                case "btnSelect":
                    BookID = dgvBookList.SelectedRows[0].Cells["bookID"].Value.ToString();
                    this.Hide();
                    break;
                case "btnClose":
                    this.Hide();
                    break;
            }
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
                btnSelect.Enabled = true;
        }
    }
}
