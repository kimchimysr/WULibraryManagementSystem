using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogSelectStudent : Form
    {
        public string StudentID { get; set; }

        public DialogSelectStudent()
        {
            InitializeComponent();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            string query = 
                "SELECT studentID,firstName,lastName,year,major " +
                "FROM tblStudent ORDER BY dateAdded DESC LIMIT 50";
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
                            LibModule.SearchNameAndFillDataGrid("tblStudent", value, dgvStudentList);
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
                    this.Hide();
                    break;
                case "btnClose":
                    this.Hide();
                    break;
            }
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
                btnSelect.Enabled = true;
        }
    }
}
