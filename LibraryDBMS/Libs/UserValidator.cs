using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Libs
{
    // Data Validation using ErrorProvider
    // https://stackoverflow.com/questions/36824606/errorprovider-c-sharp-winforms
    public class UserValidator
    {
        private ErrorProvider ep = new ErrorProvider();
        private TextBox username;
        private TextBox fName;
        private TextBox lName;
        private TextBox address;
        private ComboBox role;
        private TextBox tel;
        private TextBox email;

        public UserValidator(TextBox username, TextBox fName, TextBox lName, TextBox address, 
            ComboBox role, TextBox tel, TextBox email)
        {
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            if (username != null)
            {
                this.username = username;
                this.username.Validating += Username_Validating;
                this.username.KeyPress += Username_KeyPress;
            }
            this.fName = fName;
            this.lName = lName;
            this.address = address;
            this.role = role;
            this.tel = tel;
            this.email = email;
            this.fName.Validating += FName_Validating;
            this.fName.KeyPress += Name_KeyPress;
            this.lName.Validating += LName_Validating;
            this.lName.KeyPress += Name_KeyPress;
            this.address.Validating += Address_Validating;
            this.role.Validating += Role_Validating;
            this.tel.Validating += Tel_Validating;
            this.tel.KeyPress += Tel_KeyPress;
            this.email.Validating += Email_Validating;
        }

        private void Username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                ep.SetError(username, "Username is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(username, null);
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

        private void Address_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(address.Text))
            {
                ep.SetError(address, "Address is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(address, null);
            }
        }

        private void Role_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (role.SelectedIndex == -1)
            {
                ep.SetError(role, "Role is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(role, null);
            }
        }

        private void Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // a valid email format: (randomString)@(randomString2).(2-3 characters)
            Regex regex = new Regex("[a-z0-9]+@[a-z]+\\.[a-z]{2,3}");
            if (string.IsNullOrEmpty(email.Text))
            {
                ep.SetError(email, "Email is required!");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(email.Text))
            {
                ep.SetError(email, "Please enter a valid email!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(email, null);
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

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar))
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
