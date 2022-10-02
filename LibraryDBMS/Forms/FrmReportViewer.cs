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
            Utils.FillComboBox(cbReportsList, false, "All Students", "All Books", "All Loan Books");
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

        private void cbReportsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch ((string)cb.SelectedItem)
            {
                case "All Students":
                    LibModule.FillReportViewer("tblStudent", reportViewer1,
                        "LibraryDBMS.Reports.RpStudent.rdlc", "Borrower");
                    break;
                case "All Books":
                    LibModule.FillReportViewer("viewBook", reportViewer1,
                        "LibraryDBMS.Reports.RpBook.rdlc", "Book");
                    break;
                case "All Loan Books":
                    LibModule.FillReportViewer("tblStudent", reportViewer1,
                        "LibraryDBMS.Reports.RpStudent.rdlc", "Borrower");
                    break;
                default:
                    break;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
