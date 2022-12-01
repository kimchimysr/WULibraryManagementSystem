using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryDBMS.Libs
{
    public class IssueBookValidator2
    {
        private ErrorProvider ep = new ErrorProvider();
        private TextBox studentID;
        private TextBox bookID;
        private TextBox fName;
        private TextBox lName;
        private RadioButton male;
        private RadioButton female;
        private ComboBox year;
        private ComboBox major;
        private TextBox tel;
        private DateTimePicker dateAdded;
        private Label lblBookAvailability;
        private Label lblStudentStatus;
        private Label lblBorrowedTitle;

        public IssueBookValidator2(TextBox studentID, TextBox bookID, TextBox fName, TextBox lName, RadioButton male, RadioButton female,
            ComboBox year, ComboBox major, TextBox tel, DateTimePicker dateAdded, Label lblBookAvailability, Label lblStudentStatus, Label lblBorrowedTitle)
        {
            this.studentID = studentID;
            this.bookID = bookID;
            this.fName = fName;
            this.lName = lName;
            this.male = male;
            this.female = female;
            this.year = year;
            this.major = major;
            this.tel = tel;
            this.dateAdded = dateAdded;
            this.lblBookAvailability = lblBookAvailability;
            this.lblStudentStatus = lblStudentStatus;
            this.lblBorrowedTitle = lblBorrowedTitle;

            this.studentID.Validating += StudentID_Validating;
            this.studentID.KeyPress += ID_KeyPress;
            this.bookID.Validating += BookID_Validating;
            this.bookID.KeyPress += ID_KeyPress;
            this.tel.Validating += Tel_Validating;
            this.tel.KeyPress += Tel_KeyPress;
            this.major.Validating += Major_Validating;
            this.year.Validating += Year_Validating;
            this.lName.Validating += LName_Validating;
            this.lName.KeyPress += Name_KeyPress;
            this.fName.Validating += FName_Validating;
            this.fName.KeyPress += Name_KeyPress;
        }

        private void StudentID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lblStudentStatus.Text = "Student Status: ";
            lblBorrowedTitle.Text = "Last Borrowed Title: ";
            if (string.IsNullOrEmpty(studentID.Text))
            {
                ep.SetError(studentID, "Student ID is required!");
                e.Cancel = true;
                return;
            }
            //string studentExists = LibModule.ExecuteScalarQuery($"SELECT studentID FROM tblStudents WHERE studentID='{studentID.Text.Trim()}';");
            //if (string.IsNullOrEmpty(studentExists))
            //{
            //    ep.SetError(studentID, "Student ID doesn't exists!");
            //    e.Cancel = true;
            //}
            else
            {
                ep.SetError(studentID, null);
            }
        }

        private void BookID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
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

        private void FName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(fName.Text))
            {
                ep.SetError(fName, "First name is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(fName, null);
            }
        }

        private void LName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(lName.Text))
            {
                ep.SetError(lName, "Last name is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(lName, null);
            }
        }

        private void Year_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (year.SelectedIndex == -1)
            {
                ep.SetError(year, "Year is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(year, null);
            }
        }

        private void Major_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(major.Text))
            {
                ep.SetError(major, "Major is required");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(major, null);
            }
        }

        private void Tel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tel.Text))
            {
                ep.SetError(tel, "Telephone is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(tel, null);
            }
        }

        private void StudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

    }
}
