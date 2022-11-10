using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Libs
{
    public class StudentValidator
    {
        private ErrorProvider ep = new ErrorProvider();
        private TextBox studentID;
        private TextBox fName;
        private TextBox lName;
        private ComboBox year;
        private TextBox major;
        private TextBox tel;

        public StudentValidator(TextBox studentID, TextBox fName, TextBox lName, ComboBox year, TextBox major, TextBox tel)
        {
            this.ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            if (studentID != null)
            {
                this.studentID = studentID;
                this.studentID.Validating += StudentID_Validating;
                this.studentID.KeyPress += StudentID_KeyPress;
            }
            this.fName = fName;
            this.lName = lName;
            this.year = year;
            this.major = major;
            this.tel = tel;
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
            if (string.IsNullOrEmpty(studentID.Text))
            {
                ep.SetError(studentID, "Student ID is required!");
                e.Cancel = true;
            }
            else if (LibModule.CheckIfExist("tblStudents", "studentID", studentID.Text.Trim(),
                    "Student ID is already exists!", false))
            {
                ep.SetError(studentID, "Student ID is already exists!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(studentID, null);
            }
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
                ep.SetError(year, "Role is required!");
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
