using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageStudent : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private (int rowIndex, string studentID) selected;
        public FrmManageStudent(FrmMainMenu _frmMainMenu)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            frmMainMenu = _frmMainMenu;
            InitializeValues();
        }

        private void InitializeValues()
        {
            Utils.EnableControlDoubleBuffer(dgvStudentList);
            Utils.ClearSelectionAfterDataBindingDataGridView(dgvStudentList);
            Utils.EnableRightClickInCells(dgvStudentList);
            Utils.FillComboBox(cbSearchBy, true, "Student ID", "Name");
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvStudentList);
            Utils.ToolTipOnControlMouseHover
                ("Shortcuts Combination Key:" +
                 "\n* Add Button (Alt + A)" +
                 "\n* Edit Button (Alt + E)" +
                 "\n* Delete Button (Alt + D)" +
                 "\n* View Information Button (Alt + V)", pShortcuts);
            PopulateDataGrid();
            SetUserPermission();
            btnPrint.Enabled = dgvStudentList.RowCount > 0 ? true : false;
        }

        private void SetUserPermission()
        {
            if (frmMainMenu.user.Rows[0]["roleName"].ToString().ToLower() == "viewer")
                Utils.SetControlVisibility(false, btnAdd, btnEdit, btnDelete, btnImport);
            else
                Utils.SetControlVisibility(true, btnAdd, btnEdit, btnDelete, btnImport);
        }

        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewStudents", dgvStudentList, "dateAdded");
            lblCount.Text = Convert.ToInt32(LibModule.ExecuteScalarQuery("SELECT COUNT(studentID) FROM tblStudents;")) <= 1 ? "Total Student: " + 
                LibModule.ExecuteScalarQuery("SELECT COUNT(studentID) FROM tblStudents;") : "Total Students: " +
                LibModule.ExecuteScalarQuery("SELECT COUNT(studentID) FROM tblStudents;");
            lblRowsCount.Text = $"Display Result: {dgvStudentList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
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
                    var dialogReportViewer = new DialogReportViewer(dgvStudentList,
                        "LibraryDBMS.Reports.RpStudent.rdlc", "Student", parameters);
                    dialogReportViewer.ShowDialog();
                    Utils.BlurEffect.UnBlur();
                    break;
                case "btnSearch":
                    if (txtSearchValue.Text.Length > 0)
                    {
                        string searchBy = cbSearchBy.SelectedItem.ToString();
                        string value = txtSearchValue.Text.ToString().Trim();

                        if (searchBy == "Student ID")
                            LibModule.SearchAndFillDataGrid("tblStudents", "studentID", value, dgvStudentList);
                        else if (searchBy == "Name")
                            LibModule.SearchNameAndFillDataGrid("tblStudents", value, dgvStudentList);
                        lblRowsCount.Text = $"Display Result: {dgvStudentList.Rows.Count}";
                    }
                    break;
                case "btnFilter":
                    if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                    {
                        if (dtpToDate.Value > DateTime.Now)
                            dtpToDate.Value = DateTime.Now;
                        string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                        string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
                        LibModule.SearchBetweenDateAndFillDataGrid("tblStudents", dgvStudentList, "dateAdded", fromDate, toDate);
                        lblRowsCount.Text = $"Display Result: {dgvStudentList.Rows.Count}";
                    }
                    else
                    {
                        MessageBox.Show("From Datepicker should not be more than To Datepicker", "Warning Invalid Date Span",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpFromDate.Focus();
                    }
                    break;
                case "btnAdd":
                    var frmAddUser = new DialogAddEditStudent(frmMainMenu, this);
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmAddUser, frmMainMenu);
                    break;
                case "btnEdit":
                    var frmEditUser =
                        new DialogAddEditStudent(frmMainMenu, this, LibModule.GetSingleRecordFromDB("tblStudents", "studentID", selected.studentID));
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmEditUser, frmMainMenu);
                    break;
                case "btnDelete":
                    Utils.BlurEffect.Blur(frmMainMenu);
                    if (LibModule.DeleteRecord("tblStudents", "studentID", selected.studentID,
                        Utils.GetDataGridSelectedRowData(dgvStudentList, selected.rowIndex)) == true)
                        PopulateDataGrid();
                    Utils.BlurEffect.UnBlur();
                    break;
                case "btnView":
                    var frmViewDetail = new DialogViewDetail(dgvStudentList, selected.rowIndex, "Student");
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmViewDetail, frmMainMenu);
                    break;
                case "btnRefresh":
                    PopulateDataGrid();
                    break;
                case "btnImport":
                    //Utils.ImportExcelDataIntoDatabase();
                    break;
                case "btnExport":
                    Utils.ExportDatabaseTableToExcel("tblStudents");
                    break;
            }
            btnPrint.Enabled = dgvStudentList.RowCount > 0 ? true : false;
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
