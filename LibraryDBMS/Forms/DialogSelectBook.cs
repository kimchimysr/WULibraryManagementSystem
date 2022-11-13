using LibraryDBMS.Libs;
using System;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogSelectBook : Form
    {
        public string BookID { get; set; }

        public DialogSelectBook()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
            Utils.EnableControlDoubleBuffer(dgvBookList);
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvBookList);
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            txtSearchValue.Clear();
            btnFind.Enabled = false;
            string query = "SELECT bookID,title,author,qty FROM tblBooks ORDER BY bookID DESC LIMIT 50";
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
                            LibModule.SearchAndFillDataGrid("tblBooks", "title", value, dgvBookList);
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
                    break;
                case "btnClose":
                    this.Close();
                    break;
            }
        }

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
                btnSelect.Enabled = true;
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            Utils.searchButtonTextChanged(sender, btnFind);
        }

        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearchValue.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
                // disable beep sounde
                //e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
