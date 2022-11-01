using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IssueBookValidator(TextBox studentID, TextBox bookID, Label lblTitle, Label lblName, Label lblBookAvailability)
        {
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.studentID = studentID;
            this.bookID = bookID;
            this.lblTitle = lblTitle;
            this.lblName = lblName;
            this.lblBookAvailability = lblBookAvailability;
            this.studentID.Validating += StudentID_Validating;
            this.studentID.KeyPress += ID_KeyPress;
            this.bookID.Validating += BookID_Validating;
            this.bookID.KeyPress += ID_KeyPress;
        }

        private void StudentID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lblName.Text = "";
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
                string query = $"SELECT firstName || ' ' || lastName AS fullName " +
                    $"FROM tblStudents WHERE studentID='{studentID.Text.Trim()}';";
                lblName.Text = LibModule.ExecuteScalarQuery(query);
                ep.SetError(studentID, null);
            }
        }

        private void BookID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lblTitle.Text = "";
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
                lblTitle.Text = LibModule.ExecuteScalarQuery(query);
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