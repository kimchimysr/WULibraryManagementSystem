using LibraryDBMS.Libs;
using System;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmNotification : Form
    {
        public FrmNotification()
        {
            InitializeComponent();
            Utils.AutoSizeChildrenInFlowLayoutPanel(flpContainer);
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvBookDue);
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvBookDueTmr);
            Utils.AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(dgvBookOverdue);
            SetBookCount();
        }

        public override void Refresh()
        {
            base.Refresh();
            SetBookCount();
        }

        // C# - DropDown Panel in Windows Form Application C#
        // https://www.youtube.com/watch?v=CQBl1l27dL0

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnBookDue":
                    if(pBookDue.Height == pBookDue.MinimumSize.Height)
                        PopulateDataGrid(dgvBookDue);
                    CollapseExpandPanel(btnBookDue, pBookDue);
                    break;
                case "btnBookDueTmr":
                    if (pBookDueTmr.Height == pBookDueTmr.MinimumSize.Height)
                        PopulateDataGrid(dgvBookDueTmr);
                    CollapseExpandPanel(btnBookDueTmr, pBookDueTmr);
                    break;
                case "btnBookOverdue":
                    if (pBookOverdue.Height == pBookOverdue.MinimumSize.Height)
                        PopulateDataGrid(dgvBookOverdue);
                    CollapseExpandPanel(btnBookOverdue, pBookOverdue);
                    break;
            }
        }
        private void SetBookCount()
        {
            (string due, string overdue) book = LibModule.GetLoanBookDueAndOverdue();
            string bookDue = book.due;
            string bookOverdue = book.overdue;
            string bookDueTmr = 
                LibModule.ExecuteScalarQuery("SELECT COUNT(CASE WHEN date(dateDue)=date('now','+1 day') " +
                "AND loanStatusID='1' THEN dateDue END) AS bookDueTmr FROM tblBorrows;");
            btnBookDue.Text = $"Book Due Today ({(bookDue != "0" ? bookDue : "0")})";
            btnBookDueTmr.Text = $"Book Due Tomorrow ({(bookDueTmr != "0" ? bookDueTmr : "0")})";
            btnBookOverdue.Text = $"Book Overdue ({(bookOverdue != "0" ? bookOverdue : "0")})";
        }

        private void CollapseExpandPanel(Button btn, Panel panel)
        {
            btn.Image = panel.Height == panel.MinimumSize.Height ?
                Properties.Resources.collapse_arrow_26px : 
                Properties.Resources.expand_arrow_26px;
            panel.Height = panel.Height == panel.MinimumSize.Height ?
                panel.MaximumSize.Height : panel.MinimumSize.Height;
        }

        private void PopulateDataGrid(DataGridView dgv)
        {
            string query = string.Empty;
            switch (dgv.Name)
            {
                case "dgvBookDue":
                    query = "SELECT * FROM viewBorrowedBooks WHERE date(dateDue)=date('now') AND loanStatusName='Borrowed';";
                    break;
                case "dgvBookDueTmr":
                    query = "SELECT * FROM viewBorrowedBooks WHERE date(dateDue)=date('now','+1 day') AND loanStatusName='Borrowed';";
                    break;
                case "dgvBookOverdue":
                    query = "SELECT * FROM viewBorrowedBooks WHERE date(dateDue)<date('now') AND loanStatusName='Borrowed';";
                    break;
            }
            LibModule.FillDataGrid(query, dgv);
        }
    }
}
