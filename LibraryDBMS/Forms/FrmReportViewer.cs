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
using LibraryDBMS.Forms;
using System.Drawing.Printing;

namespace LibraryDBMS
{
    public partial class FrmReportViewer : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private DataTable overview;
        private Dictionary<string, string> setParameters = new Dictionary<string, string>();
        public FrmReportViewer()
        {
            InitializeComponent();
            overview = LibModule.GetDataTableFromDB("viewOverview");
            Utils.FillComboBox(cbReportsList, false, 
                "All Students", "All Books", "All Loan Books", "All Users", "Overview");
        }

        public FrmReportViewer(FrmMainMenu frm, string tableName, string rpPath, string rpDataSet)
        {
            InitializeComponent();
            frmMainMenu = frm;
            LibModule.FillReportViewer(tableName, reportViewer1, rpPath, rpDataSet);
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

        private void cbReportsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch ((string)cb.SelectedItem)
            {
                case "All Students":
                    //SetParameters.Add("username", frmMainMenu.user.username);
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    LibModule.FillReportViewer("tblStudent", reportViewer1,
                        "LibraryDBMS.Reports.RpStudent.rdlc", "Student", setParameters);
                    break;
                case "All Books":
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    setParameters.Add("totalBook", overview.Rows[0]["bookCount"].ToString());
                    LibModule.FillReportViewer("viewBook", reportViewer1,
                        "LibraryDBMS.Reports.RpBook.rdlc", "Book", setParameters);
                    break;
                case "All Loan Books":
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    setParameters.Add("bookReturnedCount", overview.Rows[0]["bookReturnCount"].ToString());
                    setParameters.Add("bookLostCount", overview.Rows[0]["bookLostCount"].ToString());
                    LibModule.FillReportViewer("viewBorrowBook", reportViewer1,
                        "LibraryDBMS.Reports.RpBorrowBook.rdlc", "BorrowBook", setParameters);
                    break;
                case "All Users":
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    LibModule.FillReportViewer("viewUserInfo", reportViewer1,
                        "LibraryDBMS.Reports.RpUserInfo.rdlc", "UserInfo", setParameters);
                    break;
                case "Overview":
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    LibModule.FillReportViewer("viewOverview", reportViewer1,
                        "LibraryDBMS.Reports.RpOverview.rdlc", "Overview", setParameters);
                    break;
                default:
                    break;
            }
            this.reportViewer1.RefreshReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbReportsList.SelectedIndex = -1;
            reportViewer1.Clear();
            overview = LibModule.GetDataTableFromDB("viewOverview");
        }
    }
}
