using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageUser : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private (int rowIndex, string userID) selected;

        public FrmManageUser(FrmMainMenu _frmMainMenu)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            frmMainMenu = _frmMainMenu;
            InitializeValues();
        }

        private void InitializeValues()
        {
            Utils.EnableControlDoubleBuffer(dgvUserList);
            Utils.ClearSelectionAfterDataBindingDataGridView(dgvUserList);
            Utils.EnableRightClickInCells(dgvUserList);
            Utils.FillComboBox(cbSearchBy, true, "Username", "Name");
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvUserList);
            Utils.ToolTipOnControlMouseHover
                ("Shortcuts Combination Key:" +
                 "\n* Add Button (Alt + A)" +
                 "\n* Edit Button (Alt + E)" +
                 "\n* Reset Password Button (Alt + R)" +
                 "\n* Activate|Deactivate Button (Alt + V)", pShortcuts);
            PopulateDataGrid();
            btnPrint.Enabled = dgvUserList.RowCount > 0 ? true : false;
        }
        
        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewUserInfo", dgvUserList, "userID");
            lblUserCount.Text = "Total User: " + 
                LibModule.ExecuteScalarQuery("SELECT COUNT(userID) FROM viewUserInfo;");
            lblRowsCount.Text = $"Display Result: {dgvUserList.Rows.Count}";
            btnEdit.Enabled = false;
            btnResetPassword.Enabled = false;
            btnActivateDeactivate.Enabled = false;
            btnSearch.Enabled = false;
            btnFilter.Enabled = true;
            txtSearchValue.Clear();
            Utils.SetFromDateAYearFromNow(dtpFromDate, dtpToDate);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPrint":
                    Utils.BlurEffect.Blur(frmMainMenu);
                    var parameters = new Dictionary<string, string>();
                    parameters.Add("username", frmMainMenu.user.Rows[0]["username"].ToString());
                    var dialogReportViewer = new DialogReportViewer(dgvUserList,
                        "LibraryDBMS.Reports.RpUserInfo.rdlc", "Student", parameters);
                    dialogReportViewer.ShowDialog();
                    Utils.BlurEffect.UnBlur();
                    break;
                case "btnSearch":
                    if (txtSearchValue.Text.Length > 0)
                    {
                        string searchBy = cbSearchBy.SelectedItem.ToString();
                        string value1 = txtSearchValue.Text.ToString().Trim();

                        if (searchBy == "Username")
                            LibModule.SearchAndFillDataGrid("viewUserInfo", "username", value1, dgvUserList);
                        else if (searchBy == "Name")
                            LibModule.SearchNameAndFillDataGrid("viewUserInfo", value1, dgvUserList);
                        lblRowsCount.Text = $"Display Result: {dgvUserList.Rows.Count}";
                    }
                    break;
                case "btnFilter":
                    if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                    {
                        if (dtpToDate.Value > DateTime.Now)
                            dtpToDate.Value = DateTime.Now;
                        string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                        string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
                        LibModule.SearchBetweenDateAndFillDataGrid("viewUserInfo", dgvUserList, "dateAdded", fromDate, toDate);
                        lblRowsCount.Text = $"Display Result: {dgvUserList.Rows.Count}";
                    }
                    else
                    {
                        MessageBox.Show("From Datepicker should not be more than To Datepicker", "Warning Invalid Date Span",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpFromDate.Focus();
                    }
                    break;
                case "btnAdd":
                        Form frmAddEditUser = new DialogAddEditUser(this);
                        Utils.BlurEffect.ShowDialogWithBlurEffect(frmAddEditUser, frmMainMenu);
                    break;
                case "btnEdit":
                        var frmEditUser =
                        new DialogAddEditUser(this, LibModule.GetSingleRecordFromDB("viewUserInfo", "userID", selected.userID));
                        Utils.BlurEffect.ShowDialogWithBlurEffect(frmEditUser, frmMainMenu);
                    break;
                //case "btnDelete":
                //        Utils.BlurEffect.Blur(frmMainMenu);
                //        if (LibModule.DeleteRecord("tblUser", "userID", selected.userID,
                //            Utils.GetDataGridSelectedRowData(dgvUserList, selected.rowIndex)) == true)
                //            PopulateDataGrid();
                //        Utils.BlurEffect.UnBlur();
                //    break;
                case "btnResetPassword":
                    var frmResetPassword =
                    new DialogResetPassword(LibModule.GetSingleRecordFromDB("viewUserInfo", "userID", selected.userID));
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmResetPassword, frmMainMenu);
                    break;
                case "btnActivateDeactivate":
                    int rowIndex = dgvUserList.CurrentCell.RowIndex;

                    if (dgvUserList.Rows[rowIndex].Cells["roleName"].Value.ToString() == "Admin" && dgvUserList.Rows[rowIndex].Cells["isActive"].Value.ToString() == "Yes")
                    {
                        if (Utils.GetAmountOfActiveAdminUser() == 1)
                        {
                            MessageBox.Show("Active admin user must be atleast 1! Cannot deactivate current user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string userID = selected.userID;
                    string isActive =
                        dgvUserList.Rows[rowIndex].Cells["isActive"].Value.ToString() == "Yes" ?
                        "No" : "Yes";

                    string prompt = dgvUserList.Rows[rowIndex].Cells["isActive"].Value.ToString() == "Yes" ? "Deactivate" : "Activate";
                    if (MessageBox.Show($"Do you want to {prompt} this user({dgvUserList.Rows[rowIndex].Cells["username"].Value.ToString()})?", $"{prompt}?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;

                        List<string> value = new List<string>{ isActive };
                    if (LibModule.UpdateRecord("tblUser", "isActive", "userID", userID, value, 
                        false) == true)
                    {
                        MessageBox.Show($"{dgvUserList.Rows[rowIndex].Cells["username"].Value}'s " +
                            $"Active status has changed!", "Active Status Updated", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    PopulateDataGrid();
                    break;
                case "btnRefresh":
                    PopulateDataGrid();
                    break;
            }
        }



        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected = (e.RowIndex, dgvUserList.Rows[e.RowIndex].Cells["userID"].Value.ToString());
                btnEdit.Enabled = true;
                btnResetPassword.Enabled = true;
                btnActivateDeactivate.Enabled = true;
            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            Utils.searchButtonTextChanged(sender, btnSearch);
            if (txtSearchValue.Text.Length == 0)
                btnRefresh.PerformClick();
        }

        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearchValue.Text.Length > 0 && e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                // disable beep sounde
                //e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void dtpFromAndToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value && dtpFromDate.Value < DateTime.Now)
            {
                btnFilter.Enabled = false;
                Utils.ToolTipOnControlMouseHover("The From Date Value is more" +
                    " than To Date Value", dtpFromDate);
            }
            else if (dtpFromDate.Value > DateTime.Now)
            {
                btnFilter.Enabled = false;
                Utils.ToolTipOnControlMouseHover("The From Date value should not" +
                    " set in the future", btnFilter);
            }
            else
                btnFilter.Enabled = true;
        }

    }
}
