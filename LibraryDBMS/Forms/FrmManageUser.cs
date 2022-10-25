using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageUser : Form
    {
        private (int rowIndex, string userID) selected;
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
            lblRowsCount.Text = $"Total Result: {dgvUserList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnActivateDeactivate.Enabled = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPrint":
                    Utils.PrintPreviewDataGridView("User List", dgvUserList);
                    break;
                case "btnSearch":
                    try
                    {
                        if (txtSearchValue.Text.Length > 0)
                        {
                            string searchBy = cbSearchBy.SelectedItem.ToString();
                            string value = txtSearchValue.Text.ToString().Trim();

                            if (searchBy == "Username")
                                LibModule.SearchAndFillDataGrid("viewUserInfo", "username", value, dgvUserList);
                            else if (searchBy == "Name")
                                LibModule.SearchNameAndFillDataGrid("viewUserInfo", value, dgvUserList);
                            lblRowsCount.Text = $"Total Result: {dgvUserList.Rows.Count}";
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
                            LibModule.SearchBetweenDateAndFillDataGrid("viewUserInfo", dgvUserList, "dateAdded", fromDate, toDate);
                            lblRowsCount.Text = $"Total Result: {dgvUserList.Rows.Count}";
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
                        if (selected.userID != "1")
                        {
                            Form frmAddEditUser =
                                                new DialogAddEditUser(this, LibModule.GetSingleRecordFromDB("viewUserInfo", "userID", selected.userID));
                            frmAddEditUser.ShowDialog(); 
                        }
                        else MessageBox.Show("Cannot edit default admin account!", "Default Admin Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnDelete":
                    try
                    {
                        // userID 1 = default admin account
                        if (selected.userID != "1")
                        {
                            if (LibModule.DeleteRecord("tblUser", "userID", selected.userID,
                            Utils.GetDataGridSelectedRowData(dgvUserList, selected.rowIndex)) == true)
                                PopulateDataGrid();
                        }
                        else MessageBox.Show("Cannot delete default admin account!", "Default Admin Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "btnActivateDeactivate":
                    try
                    {
                        if (selected.userID != "1")
                        {
                            string isActive =
                                dgvUserList.SelectedRows[0].Cells["isActive"].Value.ToString() == "Yes" ?
                                "No" : "Yes";
                            List<string> value = new List<string> { isActive };
                            if (LibModule.UpdateRecord("tblUser", "isActive", "userID", selected.userID, value,
                                false) == true)
                            {
                                MessageBox.Show($"{dgvUserList.Rows[selected.rowIndex].Cells["username"].Value}'s " +
                                    $"active status has changed!", "Active Status Updated", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            PopulateDataGrid(); 
                        }
                        else MessageBox.Show("Cannot deactivate default admin account!", "Default Admin Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvUserList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUserList.SelectedRows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnActivateDeactivate.Enabled = true;
            }
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected = (e.RowIndex, dgvUserList.Rows[e.RowIndex].Cells["userID"].Value.ToString());
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnActivateDeactivate.Enabled = true;
            }
        }
    }
}
