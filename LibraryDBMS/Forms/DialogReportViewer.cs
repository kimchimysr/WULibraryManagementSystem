using LibraryDBMS.Libs;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogReportViewer : Form
    {
        public DialogReportViewer(DataGridView dgv, string rpPath, string rpDataSet, Dictionary<string,string> parameters)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            reportViewer1.Clear();
            Utils.FillReportViewerWithDGVDataSource(dgv, reportViewer1, rpPath, rpDataSet, parameters);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
