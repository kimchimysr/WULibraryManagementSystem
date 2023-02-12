using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryDBMS.Forms
{
    public partial class FrmDashboard : Form
    {
        private FrmMainMenu frmMainMenu;
        private DataTable overview = new DataTable();
        private DateTime startTime = new DateTime();
        private Timer upTime = new Timer();

        public FrmDashboard(FrmMainMenu frm)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            startTime = DateTime.Now;
            upTime.Tick += UpTime_Tick;
            upTime.Start();
            void UpTime_Tick(object sender, EventArgs e)
            {
                lblUpTime.Text = (DateTime.Now - startTime).ToString("hh\\:mm\\:ss");
            }
            frmMainMenu = frm;
            InitializeValues();
        }
        
        private void InitializeValues()
        {
            overview = LibModule.GetDataTableFromDBWithTableName("viewOverview");
            lblBookCount.Text = overview.Rows[0]["bookCount"].ToString().ToKMString();
            lblBookTitleCount.Text = overview.Rows[0]["bookTitleCount"].ToString().ToKMString();
            lblStudentCount.Text = overview.Rows[0]["studentCount"].ToString().ToKMString();
            lblBookLoanCount.Text = overview.Rows[0]["bookLoanCount"].ToString().ToKMString();
            lblBookReturnCount.Text = overview.Rows[0]["bookReturnCount"].ToString().ToKMString();
            lblUsername.Text = frmMainMenu.user.Rows[0]["username"].ToString();
            lblRole.Text = frmMainMenu.user.Rows[0]["roleName"].ToString();
            (string due, string overdue) book = LibModule.GetLoanBookDueAndOverdue();
            lblBookDue.Text = book.due.ToKMString();
            lblBookOverdueCount.Text = book.overdue.ToKMString();
            lblActivityCount.Text =
                LibModule.ExecuteScalarQuery("SELECT COUNT(logID) FROM tblLogs WHERE DATE(timestamp)=DATE('NOW');");
            lblBooks.Text = Convert.ToInt32(overview.Rows[0]["bookCount"].ToString()) > 1 ?
                "Books" : "Book";
            lblTitles.Text = Convert.ToInt32(overview.Rows[0]["bookTitleCount"].ToString()) > 1 ?
                "Titles" : "Title" ;
            lblStudents.Text = Convert.ToInt32(overview.Rows[0]["studentCount"].ToString()) > 1 ?
                "Students" : "Student";
            lblBorrowedBooks.Text = Convert.ToInt32(overview.Rows[0]["bookLoanCount"].ToString()) > 1 ?
                "Borrowed Books" : "Borrowed Book";
            lblReturnedBooks.Text = Convert.ToInt32(overview.Rows[0]["bookReturnCount"].ToString()) > 1 ?
                "Returned Books" : "Returned Book";
            lblBooksDueToday.Text = Convert.ToInt32(book.due) > 1 ? "Books Due Today" : "Book Due Today";
            lblOverdueBooks.Text = Convert.ToInt32(book.overdue) > 1 ? "Overdue Books" : "Overdue Book";
            lblTodayActivities.Text = Convert.ToInt32(LibModule.ExecuteScalarQuery
                ("SELECT COUNT(logID) FROM tblLogs WHERE DATE(timestamp)=DATE('NOW');")) > 1 ?
                "Today Activities" : "Today Activity";
            #region set pie chart data
            //reset your chart series and legends
            chartBookBySubject.Series.Clear();
            chartBookBySubject.Legends.Clear();
            //Title title = new Title("Books Count by Subjects", Docking.Top, new Font("Trebuchet MS", 14, FontStyle.Bold), Color.Black);
            //chartBookBySubject.Titles.Add(title);

            //Add a new Legend(if needed) and do some formating
            chartBookBySubject.Legends.Add("MyLegend");
            chartBookBySubject.Legends[0].LegendStyle = LegendStyle.Table;
            chartBookBySubject.Legends[0].Docking = Docking.Bottom;
            chartBookBySubject.Legends[0].Alignment = StringAlignment.Center;
            chartBookBySubject.Legends[0].Title = "Subjects";
            chartBookBySubject.Legends[0].BorderColor = Color.Black;
            chartBookBySubject.Legends[0].Font = new Font("Trebuchet MS", 10, FontStyle.Bold);

            //Add a new chart-series
            string seriesname = "Subjects";
            chartBookBySubject.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chartBookBySubject.Series[seriesname].ChartType = SeriesChartType.Pie;

            //set display value
            chartBookBySubject.Series[seriesname].IsValueShownAsLabel = true;
            chartBookBySubject.Series[seriesname].Font = new Font("Trebuchet MS", 12, FontStyle.Bold);

            List<int> values = GetBookCountBySubject();

            //Add some datapoints so the series. in this case you can pass the values to this method
            chartBookBySubject.Series[seriesname].Points.AddXY("Computer science, information and general works(#PERCENT)", values[0]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Philosophy and psychology(#PERCENT)", values[1]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Religion(#PERCENT)", values[2]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Social sciences(#PERCENT)", values[3]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Language(#PERCENT)", values[4]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Science(#PERCENT)", values[5]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Technology(#PERCENT)", values[6]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Arts and recreation(#PERCENT)", values[7]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Literature(#PERCENT)", values[8]);
            chartBookBySubject.Series[seriesname].Points.AddXY("History and geography(#PERCENT)", values[9]);
            chartBookBySubject.Series[seriesname].Points.AddXY("Others(#PERCENT)", values[10]);
            #endregion
        }

        public override void Refresh()
        {
            base.Refresh();
            InitializeValues();
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control ctrl = sender as Control;
            switch (ctrl.Name)
            {
                case "lblBooks":
                case "lblTitles":
                case "lblBookCount":
                case "lblBookTitleCount":
                case "btnBooksIcon":
                case "btnTitlesIcon":
                case "pBooks":
                case "pTitles":
                    frmMainMenu.ActivateButton(frmMainMenu.btnManageBook);
                    frmMainMenu.OpenChildForm(new FrmManageBook(frmMainMenu), frmMainMenu.pManageBook);
                    break;
                case "lblBorrowedBooks":
                case "lblReturnedBooks":
                case "lblBookLoanCount":
                case "lblBookReturnCount":
                case "btnBorrowedBooksIcon":
                case "btnReturnedBooksIcon":
                case "pBorrowedBooks":
                case "pReturnedBooks":
                    frmMainMenu.ActivateButton(frmMainMenu.btnBookLoanReturn);
                    frmMainMenu.OpenChildForm(new FrmManageBorrowBook(frmMainMenu), frmMainMenu.pBookLoanReturn);
                    break;
                case "lblBooksDueToday":
                case "lblOverdueBooks":
                case "lblBookDue":
                case "lblBookOverdueCount":
                case "btnBooksDueTodayIcon":
                case "btnOverdueBooksIcon":
                case "pDueTodayBooks":
                case "pOverdueBooks":
                    frmMainMenu.ActivateButton(frmMainMenu.btnNotification);
                    frmMainMenu.OpenChildForm(new FrmNotification(), frmMainMenu.pNotification);
                    break;
                case "lblStudents":
                case "lblStudentCount":
                case "btnStudentsIcon":
                case "pStudents":
                    frmMainMenu.ActivateButton(frmMainMenu.btnManageStudent);
                    frmMainMenu.OpenChildForm(new FrmManageStudent(frmMainMenu), frmMainMenu.pManageStudent);
                    break;
                case "lblTodayActivities":
                case "lblActivityCount":
                case "btnTodayActivitiesIcon":
                case "pActivities":
                    frmMainMenu.ActivateButton(frmMainMenu.btnRecentActivity);
                    frmMainMenu.OpenChildForm(new FrmRecentActivity(), frmMainMenu.pRecentActivity);
                    break;
                case "lblCurrentUser":
                case "lblUsername":
                case "lblRole":
                case "btnCurrentUserIcon":
                case "pCurrentUser":
                    var dialogUserAccount = new DialogUserAccount(frmMainMenu.user);
                    Utils.BlurEffect.ShowDialogWithBlurEffect(dialogUserAccount, frmMainMenu);
                    break;
            }
        }

        private List<int> GetBookCountBySubject()
        {
            List<int> bookCountBySubject = new List<int>();
            // subject count from column 6 to 16 in datatable overview
            for (int i = 6; i < 17; i++)
                bookCountBySubject.Add(int.Parse(overview.Rows[0][i].ToString()));
            return bookCountBySubject;
        }
    }
}
