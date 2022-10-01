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

namespace LibraryDBMS.Forms
{
    public partial class FrmManageUser : Form
    {
        public FrmManageUser()
        {
            InitializeComponent();
        }

        private void FrmManageUser_Load(object sender, EventArgs e)
        {
            Utils.FillComboBox(cbSearchBy, true, "Username", "Name");
            cbSearchBy.SelectedIndex = 0;
            PopulateDataGrid();
        }
        
        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewUserInfo", dgvUserList, "userID");
            lblUserCount.Text = "Total User: " + 
                LibModule.ExecuteScalarQuery("SELECT COUNT(userID) FROM viewUserInfo;");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPrint":
                    FrmReportViewer frmReportViewer = new FrmReportViewer("viewUserInfo", 
                        "WesternLibraryManagementSystem.Reports.RpUserInfo.rdlc", "UserInfo");
                    frmReportViewer.ShowDialog();
                    break;
                case "btnSearch":
                    Search();
                    break;
                case "btnFilter":
                    Search(isFilterDates: true);
                    break;
                case "btnAdd":
                    try
                    {
                        Form frmAddEditUser = new DialogAddEditUser(this);
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
                        string id = dgvUserList.SelectedRows[0].Cells["userID"].Value.ToString();
                        Form frmAddEditUser =
                            new DialogAddEditUser(this, LibModule.GetSingleRecordDB("viewUserInfo", "userID", id));
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
                        string userID = dgvUserList.SelectedRows[0].Cells["userID"].Value.ToString();
                        if(LibModule.DeleteRecord("tblUser", "userID", userID,
                            Utils.GetDataGridSelectedRowData(dgvUserList)) == true)
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
                case "btnActivateDeactivate":
                    try
                    {
                        string userID = dgvUserList.SelectedRows[0].Cells["userID"].Value.ToString();
                        string isActive =
                            dgvUserList.SelectedRows[0].Cells["isActive"].Value.ToString() == "Yes" ?
                            "No" : "Yes";
                        List<string> value = new List<string>{ isActive };
                        if (LibModule.UpdateRecord("tblUser", "isActive", "userID", userID, value, 
                            false) == true)
                        {
                            MessageBox.Show($"{dgvUserList.SelectedRows[0].Cells["username"].Value}'s " +
                                $"active status has changed!", "Active Status Updated", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        PopulateDataGrid();
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
                        LibModule.SearchBetweenDateAndFillDataGrid("viewUserInfo", dgvUserList, "dateAdded", fromDate, toDate);
                    }
                }
                else
                {
                    if (txtSearchValue.Text.Length > 0)
                    {
                        string searchBy = cbSearchBy.SelectedItem.ToString();
                        string value = txtSearchValue.Text.ToString().Trim();

                        if (searchBy == "Username")
                            LibModule.SearchAndFillDataGrid("viewUserInfo", "username", value, dgvUserList);
                        else if (searchBy == "Name")
                            LibModule.SearchNameAndFillDataGrid("viewUserInfo", value, dgvUserList);
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
