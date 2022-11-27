
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryDBMS.Libs
{
    public class IssueBookValidator
    {
        private ErrorProvider ep = new ErrorProvider();
        private TextBox studentID;
        private TextBox bookID;
        private Label lblTitle;
        private Label lblName;
        private Label lblBookAvailability;
        private Label lblStudentStatus;
        private Label lblBorrowedTitle;

        public IssueBookValidator(TextBox studentID, TextBox bookID, Label lblTitle, Label lblName, Label lblBookAvailability
            , Label lblStudentStatus, Label lblBorrowedTitle)
        {
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.studentID = studentID;
            this.bookID = bookID;
            this.lblTitle = lblTitle;
            this.lblName = lblName;
            this.lblBookAvailability = lblBookAvailability;
            this.lblStudentStatus = lblStudentStatus;
            this.lblBorrowedTitle = lblBorrowedTitle;
            this.studentID.Validating += StudentID_Validating;
            this.studentID.KeyPress += ID_KeyPress;
            this.bookID.Validating += BookID_Validating;
            this.bookID.KeyPress += ID_KeyPress;
        }

        private void StudentID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lblStudentStatus.Text = "Student Status: ";
            lblBorrowedTitle.Text = "Last Borrowed Title: ";
            lblName.Text = "Student Name: ";
            if (string.IsNullOrEmpty(studentID.Text))
            {
                ep.SetError(studentID, "Student ID is required!");
                e.Cancel = true;
                return;
            }
            string studentExists = LibModule.ExecuteScalarQuery($"SELECT studentID FROM tblStudents WHERE studentID='{studentID.Text.Trim()}';");
            if (string.IsNullOrEmpty(studentExists))
            {
                ep.SetError(studentID, "Student ID doesn't exists!");
                e.Cancel= true;
            }
            else
            {
                string query = 
                    $"SELECT fullName,title,loanStatusName FROM viewBorrowedBooks " +
                    $"WHERE studentID = '{studentID.Text.Trim()}' ORDER BY borrowID DESC LIMIT 1;";
                DataTable result = LibModule.GetDataTableFromDBWithQuery(query);
                if (result.Rows.Count > 0)
                {
                    if (result.Rows[0]["loanStatusName"].ToString() == "Borrowed")
                        lblStudentStatus.Text += "Currently borrowing 1 book";
                    else if (result.Rows[0]["loanStatusName"].ToString() == "Returned")
                        lblStudentStatus.Text += "Returned last borrowed book";
                    else if (result.Rows[0]["loanStatusName"].ToString() == "Lost")
                        lblStudentStatus.Text += "Lost last borrowed book";
                    lblBorrowedTitle.Text += result.Rows[0]["title"].ToString();
                    lblName.Text += result.Rows[0]["fullName"].ToString();
                }

                ep.SetError(studentID, null);
            }
        }

        private void BookID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lblTitle.Text = "Book Title: ";
            lblBookAvailability.Text = "";
            if (string.IsNullOrEmpty(bookID.Text))
            {
                ep.SetError(bookID, "Book ID is required!");
                e.Cancel = true;
                return;
            }
            string bookExists = LibModule.ExecuteScalarQuery($"SELECT bookID FROM tblBooks WHERE bookID='{bookID.Text.Trim()}';");
            if (string.IsNullOrEmpty(bookExists))
            {
                ep.SetError(bookID, "Book ID doesn't exists!");
                e.Cancel = true;
            }
            else
            {
                string query = $"SELECT title FROM tblBooks WHERE bookID='{bookID.Text.Trim()}';";
                lblTitle.Text += LibModule.ExecuteScalarQuery(query);
                // check if the book qty > 0
                string qty = LibModule.ExecuteScalarQuery
                    ($"SELECT qty FROM tblBooks WHERE bookID='{bookID.Text.Trim()}';");
                if (int.Parse(qty) > 0)
                {
                    lblBookAvailability.ForeColor = Color.Green;
                    lblBookAvailability.Text = "Yes";
                }
                else
                {
                    lblBookAvailability.ForeColor = Color.Red;
                    lblBookAvailability.Text = "No";
                }
                ep.SetError(bookID, null);
            }
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}