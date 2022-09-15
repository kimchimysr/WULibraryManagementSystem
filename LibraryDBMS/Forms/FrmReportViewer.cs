using Microsoft.Reporting.WinForms;
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

namespace LibraryDBMS
{
    public partial class FrmReportViewer : Form
    {
        public FrmReportViewer()
        {
            InitializeComponent();
        }

        public FrmReportViewer(string tableName, string rpPath, string rpDataSet)
        {
            InitializeComponent();
            LibModule.FillReportViewer(tableName, reportViewer1, rpPath, rpDataSet);
            //LibModule.FillReportViewer("tblBorrower", reportViewer1,
            //    "LibraryDBMS.Reports.RpBorrower.rdlc", "Borrower");
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
