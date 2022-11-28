using LibraryDBMS.Libs;
using System;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogLoginHistory : Form
    {
        public DialogLoginHistory()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.EnableControlDoubleBuffer(dgvLoginList);
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvLoginList);
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            LibModule.FillDataGrid("tblUserLogs", dgvLoginList, "userLogID");
            lblRowsCount.Text = $"Display Result: {dgvLoginList.Rows.Count}";
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                {
                    string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd hh:mm:ss");
                    string toDate = dtpToDate.Value.ToString("yyyy-MM-dd hh:mm:ss");
                    LibModule.SearchBetweenDateAndFillDataGrid("tblUserLogs", dgvLoginList, "dateTime", fromDate, toDate);
                    lblRowsCount.Text = $"Display Result: {dgvLoginList.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Message: {ex.Message}\nStack Trace:\n{ex.StackTrace}", $"{ex.GetType()}", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
