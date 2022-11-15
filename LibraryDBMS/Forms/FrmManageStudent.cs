using System;
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
            Utils.FillComboBox(cbSearchBy, true, "Student ID", "Name");
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvStudentList);
            Utils.ToolTipOnControlMouseHover
                ("Shortcuts Combination Key:" +
                 "\n* Add Button (Alt + A)" +
                 "\n* Edit Button (Alt + E)" +
                 "\n* Delete Button (Alt + D)" +
                 "\n* View Information Button (Alt + V)", pShortcuts);
            PopulateDataGrid();
        }

        internal void PopulateDataGrid()
        {
            LibModule.FillDataGrid("tblStudents", dgvStudentList, "dateAdded");
            lblCount.Text = "Total Student: " + 
                LibModule.ExecuteScalarQuery("SELECT COUNT(studentID) FROM tblStudents;");
            lblRowsCount.Text = $"Display Result: {dgvStudentList.Rows.Count}";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            btnSearch.Enabled = false;
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
                    Utils.BlurEffect.Blur(frmMainMenu);
                    Utils.PrintPreviewDataGridView("Book Loan List", dgvStudentList);
                    Utils.BlurEffect.UnBlur();
                    break;
                case "btnSearch":
                    try
                    {
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
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
                            LibModule.SearchBetweenDateAndFillDataGrid("tblStudents", dgvStudentList, "dateAdded", fromDate, toDate);
                            lblRowsCount.Text = $"Total Result: {dgvStudentList.Rows.Count}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnAdd":
                    try
                    {
                        var frmAddEditUser = new DialogAddEditStudent(this);
                        Utils.BlurEffect.ShowDialogWithBlurEffect(frmAddEditUser, frmMainMenu);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnEdit":
                    try
                    {
                        var frmAddEditUser =
                            new DialogAddEditStudent(this, LibModule.GetSingleRecordFromDB("tblStudents", "studentID", selected.studentID));
                        Utils.BlurEffect.ShowDialogWithBlurEffect(frmAddEditUser, frmMainMenu);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnDelete":
                    try
                    {
                        Utils.BlurEffect.Blur(frmMainMenu);
                        if (LibModule.DeleteRecord("tblStudents", "studentID", selected.studentID,
                            Utils.GetDataGridSelectedRowData(dgvStudentList, selected.rowIndex)) == true)
                            PopulateDataGrid();
                        Utils.BlurEffect.UnBlur();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    break;
                case "btnView":
                    var frmViewDetail = new DialogViewDetail(dgvStudentList, selected.rowIndex, "Student");
                    Utils.BlurEffect.ShowDialogWithBlurEffect(frmViewDetail, frmMainMenu);
                    break;
                case "btnRefresh":
                    PopulateDataGrid();
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
    }
}
