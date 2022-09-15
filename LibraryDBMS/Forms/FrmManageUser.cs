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
using LibraryDBMS.Temp;

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
            Utils.FillComboBox(cbSearchBy, "Username", "Name");
            cbSearchBy.SelectedIndex = 0;
            PopulateDataGrid();
        }
        
        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewUserInfo", dgvUserList);
            lblCount.Text = 
                LibModule.ExecuteScalarQuery("SELECT COUNT(userID) FROM viewUserInfo;") + " user(s)";
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
                case "btnFindUser":
                    Search();
                    break;
                case "btnFilter":
                    Search(isFilterDates: true);
                    break;
                case "btnAddUser":
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
                case "btnEditUser":
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
                case "btnDeleteUser":
                    try
                    {
                        string userID = dgvUserList.SelectedRows[0].Cells["userID"].Value.ToString();
                        LibModule.DeleteRecord("tblUser", "userID", userID,
                            Utils.GetDataGridSelectedRowData(dgvUserList));
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
                case "btnActivateDeactivateUser":
                    try
                    {
                        string userID = dgvUserList.SelectedRows[0].Cells["userID"].Value.ToString();
                        string isActive =
                            dgvUserList.SelectedRows[0].Cells["isActive"].Value.ToString() == "1" ?
                            "0" : "1";
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
                        LibModule.SearchAndShow("viewUserInfo", dgvUserList, "dateAdded", fromDate, toDate);
                    }
                }
                else
                {
                    if (txtSearchValue.Text.Length > 0)
                    {
                        string searchBy = cbSearchBy.SelectedItem.ToString();
                        string value = txtSearchValue.Text.ToString().Trim();

                        if (searchBy == "Username")
                            LibModule.SearchAndShow("viewUserInfo", "username", value, dgvUserList);
                        else if (searchBy == "Name")
                            LibModule.SearchAndShow("viewUserInfo", "firstName,lastName", value, dgvUserList, true);
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
