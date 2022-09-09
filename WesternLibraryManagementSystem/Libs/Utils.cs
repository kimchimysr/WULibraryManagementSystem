using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WesternLibraryManagementSystem.Libs
{
    public static class Utils
    {
        public static bool FormIsOpen(string form)
        {
            // check if window has already open
            var OpenForms = Application.OpenForms.Cast<Form>();

            return OpenForms.Any(x => x.Name == form);
        }

        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            // convert the input string to a byte array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // create a new stringBuilder to collect the bytes
            // and create a string
            StringBuilder sb = new StringBuilder();

            // loop through each byte of the hashed data
            // and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }

        public static string DefaultHashPassword()
        {
            return HashPassword("Password@123");
        }

        //public static void ChangeControlEnabled(Form form, bool enabled, params string[] controlName)
        //{
        //    foreach (Control ctrl in form.Controls.OfType<Control>().OrderBy(c => c.TabIndex))
        //    {
        //        if (ctrl is TextBox tb)
        //        {
        //            if (controlName.Length == 0 || controlName.Any(x => x == tb.Name))
        //                tb.Enabled = enabled;                }
        //        else if (ctrl is Button btn)
        //        {
        //            if (controlName.Length == 0 || controlName.Any(x => x == btn.Name))
        //                btn.Enabled = enabled;                }
        //        else if (ctrl is ComboBox cb)
        //        {
        //            if (controlName.Length == 0 || controlName.Any(x => x == cb.Name))
        //                cb.Enabled = enabled;
        //        }
        //        else if (ctrl is DateTimePicker dtp)
        //        {
        //            if (controlName.Length == 0 || controlName.Any(x => x == dtp.Name))
        //                dtp.Enabled = enabled;
        //        }
        //        else if (ctrl is RadioButton rb)
        //        {
        //            if (controlName.Length == 0 || controlName.Any(x => x == rb.Name))
        //                rb.Enabled = enabled;
        //        }
        //    }
        //}

        public static bool IsEmptyControl(Form form)
        {
            foreach (Control ctrl in form.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.TabIndex != 0) //Optional TextBox
                        if (string.IsNullOrEmpty(ctrl.Text.Trim()))
                        {
                            MessageBox.Show("Empty TextBox field(s)!", "Empty Field",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return true;
                        }
                }
                if (ctrl is ComboBox)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        MessageBox.Show("Please select items in ComboBox(s)!", "Empty ComboBox",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
                if (ctrl is NumericUpDown)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        MessageBox.Show("Empty NumericUpDown field(s)!", "Empty NumericUpDown",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool DoClearControl(Form frm, bool textboxCond, bool labelCond, bool comboboxCond,
                                    bool numCond, bool dtpCond, params string[] controlname)
        {
            foreach (Control ctrl in frm.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                if (ctrl is TextBox tb)
                {
                    if(ctrl.TabIndex != 0)
                        if (textboxCond)
                        {
                            foreach (string txtname in controlname)
                                if (tb.Name.Equals(txtname))
                                    tb.Text = string.Empty;
                        }
                        else tb.Text = string.Empty;
                }
                else if (ctrl is Label lbl)
                {
                    if (labelCond)
                    {
                        foreach (string slabel in controlname)
                            if (lbl.Name.Equals(slabel))
                                lbl.Text = string.Empty;
                    }
                    else lbl.Text = string.Empty;
                }
                else if (ctrl is ComboBox cb)
                {
                    if (comboboxCond)
                    {
                        foreach (string cboname in controlname)
                            if (cb.Name.Equals(cboname))
                                cb.SelectedIndex = -1;
                    }
                    else cb.SelectedIndex = -1;
                }
                else if (ctrl is NumericUpDown nud)
                {
                    if (numCond)
                    {
                        foreach (string numname in controlname)
                            if (nud.Name.Equals(numname))
                                nud.Value = 0;
                    }
                    else nud.Value = 0;
                }
                else if (ctrl is DateTimePicker dtp)
                {
                    if (dtpCond)
                    {
                        foreach (string dtpname in controlname)
                            if (dtp.Name.Equals(dtpname))
                                dtp.Value = DateTime.Today;
                    }
                    else dtp.Value = DateTime.Today;
                }
            return true;
        }

        public static void FillComboBox(ComboBox cb, params string[] items)
        {
            if(items.Length > 0)
                foreach(string str in items)
                    cb.Items.Add(str);
        }

        public static string GetDataGridViewSelectedRowData(DataGridView dgv)
        {
            StringBuilder row = new StringBuilder();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                row.AppendLine($"{dgv.Columns[i].HeaderText}: {dgv.SelectedRows[0].Cells[i].Value}");
            }
            return row.ToString();
        }
    }
}