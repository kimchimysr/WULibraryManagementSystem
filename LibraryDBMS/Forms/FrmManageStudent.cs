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
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnEdit":
                    try
                    {
                        string studentID = dgvStudentList.SelectedRows[0].Cells["studentID"].Value.ToString();
                        Form frmAddEditUser =
                            new DialogAddEditStudent(this, LibModule.GetSingleRecordFromDB("tblStudent", "studentID", studentID));
                        frmAddEditUser.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnDelete":
                    try
                    {
                        string studentID = dgvStudentList.SelectedRows[0].Cells["studentID"].Value.ToString();
                        if (LibModule.DeleteRecord("tblStudent", "studentID", studentID,
                            Utils.GetDataGridSelectedRowData(dgvStudentList)) == true)
                            PopulateDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnView":
                    DialogViewDetail frmViewDetail = new DialogViewDetail(dgvStudentList, "Student");
                    frmViewDetail.ShowDialog();
                    break;
                case "btnRefresh":
                    PopulateDataGrid();
                    break;
            }
        }

        private void dgvStudentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnView.Enabled = true;
            }
        }
    }
}
