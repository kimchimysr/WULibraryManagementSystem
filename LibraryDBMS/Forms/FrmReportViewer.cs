using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS
{
    public partial class FrmReportViewer : Form
    {
        private DataTable overview;
        private Dictionary<string, string> setParameters = new Dictionary<string, string>();
        public FrmReportViewer()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            overview = LibModule.GetDataTableFromDBWithTableName("viewOverview");
            Utils.FillComboBox(cbReportsList, false, 
                "All Students", "All Books", "All Borrowed Books", "All Users", "Overview");
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
                    LibModule.FillReportViewer("tblStudents", reportViewer1,
                        "LibraryDBMS.Reports.RpStudent.rdlc", "Student", setParameters);
                    break;
                case "All Books":
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    setParameters.Add("totalBook", overview.Rows[0]["bookCount"].ToString());
                    LibModule.FillReportViewer("viewBooks", reportViewer1,
                        "LibraryDBMS.Reports.RpBook.rdlc", "Book", setParameters);
                    break;
                case "All Borrowed Books":
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    setParameters.Add("bookReturnedCount", overview.Rows[0]["bookReturnCount"].ToString());
                    setParameters.Add("bookLostCount", overview.Rows[0]["bookLostCount"].ToString());
                    LibModule.FillReportViewer("viewBorrowedBooks", reportViewer1,
                        "LibraryDBMS.Reports.RpBorrowBook.rdlc", "BorrowBook", setParameters);
                    break;
                case "All Users":
                    setParameters.Clear();
                    setParameters.Add("username", "admin");
                    LibModule.FillReportViewer("tblUser", reportViewer1,
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
            overview = LibModule.GetDataTableFromDBWithTableName("viewOverview");
        }
    }
}
