using System;
using System.Text;
using System.Text.RegularExpressions;
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
            if(quantity != null)
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
            //// https://social.msdn.microsoft.com/Forums/vstudio/en-US/6cd13bf6-1cd6-4702-bcdd-fd15b7529aca/insert-quotquot-for-every-5-characters-in-a-text-box?forum=csharpgeneral
            //string text = isbn.Text;
            //if(e.KeyCode != Keys.Back)
            //{
            //    if (text.Replace("-", "").Length % 4 == 0 && text.Length != 0 && text.Substring(text.Length - 1) != "-")
            //    {
            //        isbn.Text += "-";
            //        isbn.SelectionStart = isbn.TextLength;
            //    }
            //}
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
            else if(int.Parse(publishYear.Text) > System.DateTime.Now.Year)
            {
                ep.SetError(publishYear, $"Publish Year cannot be more than " +
                    $"{System.DateTime.Now.Year}");
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
            else if (dewey.Text.Length > 0)
            {
                // format: 1 ABC to 123.123 ABC
                Regex pattern = new Regex(@"^(\d{3}|\d{3}\.[0-9]{1,3}) [A-Z]{3}$");
                if (pattern.IsMatch(dewey.Text))
                {
                    ep.SetError(dewey, null);
                }
                else
                {
                    ep.SetError(dewey, "DEWEY is not valid!");
                    e.Cancel = true;
                }
            }
        }

        private void Isbn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(isbn.Text))
            {
                ep.SetError(isbn, "ISBN is required!");
                e.Cancel = true;
            }
            else if (isbn.Text.Length > 0)
            {
                // 12-34-1-234-12 (digit atleast 10) or 12-34-12-34-1234-1 (digit atleast 13)
                Regex pattern = new Regex(@"^-*(\d-*){9}(\d{1}|X)|^-*(\d-*){13}$");
                if (pattern.IsMatch(isbn.Text))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in isbn.Text)
                        if (char.IsDigit(c) || c == 'X')
                            sb.Append(c);

                    if (CheckISBNDigits(sb.ToString()) || sb.ToString() == "0000000000")
                    {
                        // for every 4 characters, add -
                        string newIsbn = Regex.Replace(sb.ToString(), ".{4}", "$0-");
                        isbn.Text = newIsbn;
                        ep.SetError(isbn, null);
                    }
                    else
                    {
                        ep.SetError(isbn, "ISBN is not valid!");
                        e.Cancel = true;
                    }
                }
                else
                {
                    ep.SetError(isbn, "ISBN is not valid!");
                    e.Cancel = true;
                }
            }
        }
        // https://isbn-information.com/the-10-digit-isbn.html
        // https://isbn-information.com/check-digit-for-the-13-digit-isbn.html
        private bool CheckISBNDigits(string isbn)
        {

            string isbnValueNoMinus = isbn;
            if (isbn.Length == 10)
            {
                //isbnValueNoMinus.Remove(4);
                //isbnValueNoMinus.Remove(8);
                // assign number to char array
                char[] isbnValueArray = isbnValueNoMinus.ToCharArray();
                int sum = 0;
                if (isbnValueNoMinus.EndsWith("X"))
                {
                    for(int i = 0; i < isbnValueArray.Length - 1; i++)
                    {
                        sum += Convert.ToInt32(Char.GetNumericValue(isbnValueArray[i])) * (10 - i);
                    }
                    sum += 10;
                    if (sum % 11 == 0) { return true; }
                }
                else
                {
                    for (int i = 0; i < isbnValueArray.Length; i++)
                    {
                        sum += Convert.ToInt32(Char.GetNumericValue(isbnValueArray[i])) * (10 - i);
                    }

                    if (sum % 11 == 0) { return true; }
                }

            }
            else if (isbn.Length == 13)
            {
                int resultModulus;

                /*isbnValueNoMinus.Remove(4);
                isbnValueNoMinus.Remove(8);
                isbnValueNoMinus.Remove(12);*/

                char[] isbnValueArray = isbnValueNoMinus.ToCharArray();
                int sum = 0;
                for (int i = 0; i < isbnValueArray.Length - 1; i++)
                {
                    if (i % 2 == 0) //if digit is odd
                    {
                        sum += (Convert.ToInt32(Char.GetNumericValue(isbnValueArray[i])) * 1);
                    }
                    else //if digit is even
                    {
                        sum += (Convert.ToInt32(Char.GetNumericValue(isbnValueArray[i])) * 3);
                    }
                }
                resultModulus = sum % 10;
                if (resultModulus == 0)
                {
                    if (resultModulus == Convert.ToInt32(Char.GetNumericValue(isbnValueArray[isbnValueArray.Length - 1])))
                        return  true;
                }
                if (resultModulus != 0)
                {
                    if ((10 - resultModulus) == Convert.ToInt32(Char.GetNumericValue(isbnValueArray[isbnValueArray.Length-1])))
                    {
                        return true;
                    }
                }
                //if (resultModulus == 0) { return  true; }
            }
            return false;

        }
    }
}
