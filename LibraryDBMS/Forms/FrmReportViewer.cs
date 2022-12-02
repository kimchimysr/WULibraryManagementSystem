using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LibraryDBMS.Libs;
using System.Globalization;

namespace LibraryDBMS
{
    public partial class FrmReportViewer : Form
    {
        private DataTable user;
        private DataTable overview;
        private Dictionary<string, string> setParameters = new Dictionary<string, string>();
        public FrmReportViewer(DataTable _user)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            user = _user;
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
            reportViewer1.Clear();
            ComboBox cb = (ComboBox)sender;
            gbFilterBy.Visible = cbReportsList.SelectedIndex != 4;
            cbMonth.SelectedIndex = 0;
            switch ((string)cb.SelectedItem)
            {
                case "All Students":
                    setParameters.Clear();
                    setParameters.Add("username", user.Rows[0]["username"].ToString());
                    setParameters.Add("month", "");
                    setParameters.Add("year", "");
                    LibModule.FillReportViewer("tblStudents", reportViewer1,
                        "LibraryDBMS.Reports.RpStudent.rdlc", "Student", setParameters);
                    break;
                case "All Books":
                    setParameters.Clear();
                    setParameters.Add("username", user.Rows[0]["username"].ToString());
                    setParameters.Add("totalBook", overview.Rows[0]["bookCount"].ToString());
                    setParameters.Add("month", "");
                    setParameters.Add("year", "");
                    LibModule.FillReportViewer("viewBooks", reportViewer1,
                        "LibraryDBMS.Reports.RpBook.rdlc", "Book", setParameters);
                    break;
                case "All Borrowed Books":
                    setParameters.Clear();
                    setParameters.Add("username", user.Rows[0]["username"].ToString());
                    setParameters.Add("bookReturnedCount", overview.Rows[0]["bookReturnCount"].ToString());
                    setParameters.Add("bookLostCount", overview.Rows[0]["bookLostCount"].ToString());
                    setParameters.Add("month", "");
                    setParameters.Add("year", "");
                    LibModule.FillReportViewer("viewBorrowedBooks", reportViewer1,
                        "LibraryDBMS.Reports.RpBorrowBook.rdlc", "BorrowBook", setParameters);
                    break;
                case "All Users":
                    setParameters.Clear();
                    setParameters.Add("username", user.Rows[0]["username"].ToString());
                    setParameters.Add("month", "");
                    setParameters.Add("year", "");
                    LibModule.FillReportViewer("tblUser", reportViewer1,
                        "LibraryDBMS.Reports.RpUserInfo.rdlc", "UserInfo", setParameters);
                    break;
                case "Overview":
                    setParameters.Clear();
                    setParameters.Add("username", user.Rows[0]["username"].ToString());
                    LibModule.FillReportViewer("viewOverview", reportViewer1,
                        "LibraryDBMS.Reports.RpOverview.rdlc", "Overview", setParameters);
                    break;
                default:
                    break;
            }
            this.reportViewer1.RefreshReport();
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            pMonthlyFilter.Visible = rbMonthly.Checked == true;
            cbMonth.SelectedIndex = 0;
            pYearlyFilter.Visible = rbYearly.Checked == true;
            pDateRangeFilter.Visible = rbDateRange.Checked == true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbReportsList.SelectedIndex = -1;
            cbMonth.SelectedIndex = 0;
            gbFilterBy.Visible = false;
            reportViewer1.Clear();
            overview = LibModule.GetDataTableFromDBWithTableName("viewOverview");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            setParameters.Clear();
            setParameters.Add("username", user.Rows[0]["username"].ToString());
            string query = string.Empty;
            string reportPath = string.Empty;
            string reportDataSet = string.Empty;
            if (cbReportsList.SelectedItem.ToString() == "All Students")
            {
                reportPath = "LibraryDBMS.Reports.RpStudent.rdlc";
                reportDataSet = "Student";
            }
            else if (cbReportsList.SelectedItem.ToString() == "All Books")
            {
                setParameters.Add("totalBook", overview.Rows[0]["bookCount"].ToString());
                reportPath = "LibraryDBMS.Reports.RpBook.rdlc";
                reportDataSet = "Book";
            }
            else if (cbReportsList.SelectedItem.ToString() == "All Borrowed Books")
            {
                setParameters.Add("bookReturnedCount", overview.Rows[0]["bookReturnCount"].ToString());
                setParameters.Add("bookLostCount", overview.Rows[0]["bookLostCount"].ToString());
                reportPath = "LibraryDBMS.Reports.RpBorrowBook.rdlc";
                reportDataSet = "BorrowBook";
            }
            else if (cbReportsList.SelectedItem.ToString() == "All Users")
            {
                reportPath = "LibraryDBMS.Reports.RpUserInfo.rdlc";
                reportDataSet = "UserInfo";
            }

            if (rbMonthly.Checked)
            {
                setParameters.Add("month", GetMonthIndexIntoString(cbMonth.SelectedIndex + 1));
                setParameters.Add("year", $"{dtpYearInMonthly.Text}");
                if (cbReportsList.SelectedItem.ToString() == "All Students")
                {
                    query = $"SELECT * FROM tblStudents " +
                        $"WHERE strftime('%m', dateAdded) = '{GetTwoDigitString(cbMonth.SelectedIndex + 1)}'" +
                        $"AND strftime('%Y', dateAdded) = '{dtpYearInMonthly.Text}';";
                }
                else if (cbReportsList.SelectedItem.ToString() == "All Books")
                {
                    query = $"SELECT * FROM viewBooks " +
                        $"WHERE strftime('%m', dateAdded) = '{GetTwoDigitString(cbMonth.SelectedIndex + 1)}'" +
                        $"AND strftime('%Y', dateAdded) = '{dtpYearInMonthly.Text}';";
                }
                else if (cbReportsList.SelectedItem.ToString() == "All Borrowed Books")
                {
                    query = $"SELECT * FROM viewBorrowedBooks " +
                        $"WHERE strftime('%m', dateLoan) = '{GetTwoDigitString(cbMonth.SelectedIndex + 1)}'" +
                        $"AND strftime('%Y', dateLoan) = '{dtpYearInMonthly.Text}';";
                }
                else if (cbReportsList.SelectedItem.ToString() == "All Users")
                {
                    query = $"SELECT * FROM tblUser " +
                        $"WHERE strftime('%m', dateAdded) = '{GetTwoDigitString(cbMonth.SelectedIndex + 1)}'" +
                        $"AND strftime('%Y', dateAdded) = '{dtpYearInMonthly.Text}';";
                }
            }
            else if (rbYearly.Checked)
            {
                setParameters.Add("month", "");
                setParameters.Add("year", $"{dtpYearInYearly.Text}");
                if (cbReportsList.SelectedItem.ToString() == "All Students")
                {
                    query = $"SELECT * FROM tblStudents WHERE strftime('%Y', dateAdded) = '{dtpYearInYearly.Text}';";
                }
                else if (cbReportsList.SelectedItem.ToString() == "All Books")
                {
                    query = $"SELECT * FROM viewBooks WHERE strftime('%Y', dateAdded) = '{dtpYearInYearly.Text}';";
                }
                else if (cbReportsList.SelectedItem.ToString() == "All Borrowed Books")
                {
                    query = $"SELECT * FROM viewBorrowedBooks WHERE strftime('%Y', dateLoan) = '{dtpYearInYearly.Text}';";
                }
                else if (cbReportsList.SelectedItem.ToString() == "All Users")
                {
                    query = $"SELECT * FROM tblUser WHERE strftime('%Y', dateAdded) = '{dtpYearInYearly.Text}';";
                }
            }
            else if (rbDateRange.Checked)
            {
                if (dtpToDate.Value.Date >= dtpFromDate.Value.Date)
                {
                    setParameters.Add("month", "");
                    setParameters.Add("year", $"{dtpFromDate.Text} - {dtpToDate.Text}");
                    if (cbReportsList.SelectedItem.ToString() == "All Students")
                    {
                        query = $"SELECT * FROM tblStudents WHERE DATE(dateAdded) BETWEEN '{dtpFromDate.Text}' AND '{dtpToDate.Text}';";
                    }
                    else if (cbReportsList.SelectedItem.ToString() == "All Books")
                    {
                        query = $"SELECT * FROM viewBooks WHERE DATE(dateAdded) BETWEEN '{dtpFromDate.Text}' AND '{dtpToDate.Text}';";
                    }
                    else if (cbReportsList.SelectedItem.ToString() == "All Borrowed Books")
                    {
                        query = $"SELECT * FROM viewBorrowedBooks WHERE DATE(dateLoan) BETWEEN '{dtpFromDate.Text}' AND '{dtpToDate.Text}';";
                    }
                    else if (cbReportsList.SelectedItem.ToString() == "All Users")
                    {
                        query = $"SELECT * FROM tblUser WHERE DATE(dateAdded) BETWEEN '{dtpFromDate.Text}' AND '{dtpToDate.Text}';";
                    }
                }
                else return;
            }
            LibModule.FillReportViewerWithQuery(query, reportViewer1,
                reportPath, reportDataSet, setParameters);
            this.reportViewer1.RefreshReport();
        }

        private string GetTwoDigitString(int index)
        {
            return index > 0 && index < 10 ? $"0{index}" : $"{index}";
        }

        private string GetMonthIndexIntoString(int monthIndex)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthIndex);
        }
    }
}
