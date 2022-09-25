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
            typeof(DataGridView).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               dgvBorrowerList,
               new object[] { true });
        }

        private void FrmBorrower_Load(object sender, EventArgs e)
        {
            Utils.FillComboBox(cbSearchBy, "Student ID", "Name");
            cbSearchBy.SelectedIndex = 0;
            PopulateDataGrid();
        }

        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("tblStudent", dgvBorrowerList);
            lblCount.Text =
                LibModule.ExecuteScalarQuery("SELECT COUNT(studentID) FROM tblStudent;") + " borrower(s)";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnFind":
                    Search();
                    break;
                case "btnFilter":
                    Search(isFilterDates: true);
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
                        string studentID = dgvBorrowerList.SelectedRows[0].Cells["studentID"].Value.ToString();
                        Form frmAddEditUser =
                            new DialogAddEditStudent(this, LibModule.GetSingleRecordDB("tblStudent", "studentID", studentID));
                        frmAddEditUser.ShowDialog();
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
                        string studentID = dgvBorrowerList.SelectedRows[0].Cells["studentID"].Value.ToString();
                        LibModule.DeleteRecord("tblStudent", "studentID", studentID,
                            Utils.GetDataGridSelectedRowData(dgvBorrowerList));
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
                case "btnView":
                    try
                    {
                        if (dgvBorrowerList.SelectedRows[0].Cells[0].Value != null)
                        {
                            DialogViewDetail frmViewDetail = new DialogViewDetail(dgvBorrowerList, "Student");
                            frmViewDetail.ShowDialog();
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please select a record!", "No record Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnRefresh":
                    PopulateDataGrid();
                    break;
            }
        }

        private void Search(bool isFilterDates = false)
        {
            try
            {
                if (isFilterDates)
                {
                    if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                    {
                        string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                        string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
                        LibModule.SearchAndShow("tblStudent", dgvBorrowerList, "dateAdded", fromDate, toDate);
                    }
                }
                else
                {
                    if (txtSearchValue.Text.Length > 0)
                    {
                        string searchBy = cbSearchBy.SelectedItem.ToString();
                        string value = txtSearchValue.Text.ToString().Trim();

                        if (searchBy == "Student ID")
                            LibModule.SearchAndShow("tblStudent", "studentID", value, dgvBorrowerList);
                        else if (searchBy == "Name")
                            LibModule.SearchAndShow("tblStudent", "firstName,lastName", value, dgvBorrowerList, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
