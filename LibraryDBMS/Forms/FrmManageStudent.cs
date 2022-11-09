using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageStudent : Form
    {
        private (int rowIndex, string studentID) selected;
        public FrmManageStudent()
        {
            InitializeComponent();
            InitializeValues();
        }

        private void InitializeValues()
        {
            Utils.EnableControlDoubleBuffer(dgvStudentList);
            Utils.FillComboBox(cbSearchBy, true, "Student ID", "Name");
            PopulateDataGrid();
        }

        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("tblStudent", dgvStudentList, "dateAdded");
            lblCount.Text = "Total Student: " + 
                LibModule.ExecuteScalarQuery("SELECT COUNT(studentID) FROM tblStudent;");
            lblRowsCount.Text = $"Total Result: {dgvStudentList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            btnFind.Enabled = false;
            txtSearchValue.Clear();
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today;
            cbSearchBy.SelectedIndex = 0;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPrint":
                    Utils.PrintPreviewDataGridView("Book Loan List", dgvStudentList);
                    break;
                case "btnFind":
                    try
                    {
                        if (txtSearchValue.Text.Length > 0)
                        {
                            string searchBy = cbSearchBy.SelectedItem.ToString();
                            string value = txtSearchValue.Text.ToString().Trim();

                            if (searchBy == "Student ID")
                                LibModule.SearchAndFillDataGrid("tblStudent", "studentID", value, dgvStudentList);
                            else if (searchBy == "Name")
                                LibModule.SearchNameAndFillDataGrid("tblStudent", value, dgvStudentList);
                            lblRowsCount.Text = $"Total Result: {dgvStudentList.Rows.Count}";
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
                            LibModule.SearchBetweenDateAndFillDataGrid("tblStudent", dgvStudentList, "dateAdded", fromDate, toDate);
                            lblRowsCount.Text = $"Total Result: {dgvStudentList.Rows.Count}";
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
                        Form frmAddEditUser = new DialogAddEditStudent(this);
                        frmAddEditUser.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}", ex.GetType() + "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnEdit":
                    try
                    {
                        Form frmAddEditUser =
                            new DialogAddEditStudent(this, LibModule.GetSingleRecordFromDB("tblStudent", "studentID", selected.studentID));
                        frmAddEditUser.ShowDialog();
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
                        if (LibModule.DeleteRecord("tblStudent", "studentID", selected.studentID,
                            Utils.GetDataGridSelectedRowData(dgvStudentList, selected.rowIndex)) == true)
                            PopulateDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}\nStack Trace: {ex.StackTrace}", ex.GetType() + "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnView":
                    Form frmViewDetail = new DialogViewDetail(dgvStudentList, selected.rowIndex, "Student");
                    frmViewDetail.ShowDialog();
                    break;
                case "btnRefresh":
                    PopulateDataGrid();
                    break;
            }
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected = (e.RowIndex, dgvStudentList.Rows[e.RowIndex].Cells["studentID"].Value.ToString());
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            Utils.searchButtonTextChanged(sender, btnFind);
        }
    }
}
