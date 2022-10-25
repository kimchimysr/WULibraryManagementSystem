using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Libs
{
    public class BookValidator
    {
        private ErrorProvider ep = new ErrorProvider();
        private TextBox isbn;
        private TextBox dewey;
        private TextBox title;
        private TextBox author;
        private TextBox publisher;
        private TextBox publishYear;
        private NumericUpDown pages;
        private NumericUpDown quantity;

        public BookValidator(TextBox isbn, TextBox dewey, TextBox title, TextBox author, TextBox publisher,
            TextBox publishYear, NumericUpDown pages, NumericUpDown quantity)
        {
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.isbn = isbn;
            this.dewey = dewey;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.publishYear = publishYear;
            this.pages = pages;
            this.quantity = quantity;
            this.isbn.Validating += Isbn_Validating;
            this.isbn.KeyDown += Isbn_KeyDown;
            this.dewey.Validating += Dewey_Validating;
            this.title.Validating += Title_Validating;
            this.author.Validating += Author_Validating;
            this.publisher.Validating += Publisher_Validating;
            this.publishYear.Validating += PublishYear_Validating;
            this.publishYear.KeyPress += PublishYear_KeyPress;
            this.pages.Validating += Pages_Validating;
            this.quantity.Validating += Quantity_Validating;
        }

        private void PublishYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Isbn_KeyDown(object sender, KeyEventArgs e)
        {
            // https://social.msdn.microsoft.com/Forums/vstudio/en-US/6cd13bf6-1cd6-4702-bcdd-fd15b7529aca/insert-quotquot-for-every-5-characters-in-a-text-box?forum=csharpgeneral
            string text = isbn.Text;
            if(e.KeyCode != Keys.Back)
            {
                if (text.Replace("-", "").Length % 4 == 0 && text.Length != 0 && text.Substring(text.Length - 1) != "-")
                {
                    isbn.Text += "-";
                    isbn.SelectionStart = isbn.TextLength;
                }
            }
        }

        private void Quantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (quantity.Value <= 0)
            {
                ep.SetError(quantity, "Quantity must be greater than 0!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(quantity, null);
            }
        }

        private void Pages_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (pages.Value <= 0)
            {
                ep.SetError(pages, "Pages must be greater than 0!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(pages, null);
            }
        }

        private void PublishYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(publishYear.Text))
            {
                ep.SetError(publishYear, "Publish Year is required!");
                e.Cancel = true;
            }
            else if (int.Parse(publishYear.Text) <= 1800)
            {
                ep.SetError(publishYear, "Publish Year is not valid!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(publishYear, null);
            }
        }

        private void Publisher_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(publisher.Text))
            {
                ep.SetError(publisher, "Publisher is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(publisher, null);
            }
        }

        private void Author_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(author.Text))
            {
                ep.SetError(author, "Author is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(author, null);
            }
        }

        private void Title_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(title.Text))
            {
                ep.SetError(title, "Title is required!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(title, null);
            }
        }

        private void Dewey_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dewey.Text))
            {
                ep.SetError(dewey, "DEWEY is required!");
                e.Cancel = true;
            }
            else if (!int.TryParse(dewey.Text.Substring(0, 3), out int i))
            {
                ep.SetError(dewey, "DEWEY is not valid!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(dewey, null);
            }
        }

        private void Isbn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(isbn.Text))
            {
                ep.SetError(isbn, "ISBN is required!");
                e.Cancel = true;
            }
            else if(isbn.Text.Length < 12)
            {
                ep.SetError(isbn, "ISBN is not valid!");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(isbn, null);
            }
        }
    }
}
