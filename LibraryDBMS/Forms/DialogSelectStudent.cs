using LibraryDBMS.Libs;
using System;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogSelectStudent : Form
    {
        public string StudentID { get; set; }

        public DialogSelectStudent()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
            Utils.EnableControlDoubleBuffer(dgvStudentList);
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvStudentList);
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            txtSearchValue.Clear();
            btnFind.Enabled = false;
            string query = 
                "SELECT studentID,firstName,lastName,year,major " +
                "FROM tblStudents ORDER BY dateAdded DESC LIMIT 50";
            LibModule.FillDataGrid(query, dgvStudentList);
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
                            LibModule.SearchNameAndFillDataGrid("tblStudents", value, dgvStudentList);
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
                    StudentID = dgvStudentList.SelectedRows[0].Cells["studentID"].Value.ToString();
                    break;
                case "btnClose":
                    this.Close();
                    break;
            }
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
                btnSelect.Enabled = true;
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            Utils.searchButtonTextChanged(sender, btnFind);
            if (txtSearchValue.Text.Length == 0)
                btnRefresh.PerformClick();
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
