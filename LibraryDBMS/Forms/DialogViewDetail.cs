using LibraryDBMS.Libs;
using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogViewDetail : Form
    {
        private readonly DataGridView dgv;
        private readonly int rowIndex;

        public DialogViewDetail(DataGridView _dgv, int _rowIndex, string title)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            dgv = _dgv;
            rowIndex = _rowIndex;
            lblHeader.Text = $"View {title}";
            FillAndResizeForm();
        }

        private void FillAndResizeForm()
        {
            Regex datetimeregex = new Regex(@"^[0-9]{4}-[0-9]{2}-[0-9]{2}$");
            int i = 0;
            StringBuilder columns = new StringBuilder();
            for (i = 0; i < dgv.Columns.Count; i++)
            {
                string datagridvalue = dgv.Rows[rowIndex].Cells[i].Value.ToString();
                if (datetimeregex.IsMatch(datagridvalue))
                {
                    DateTime dateValue = Convert.ToDateTime(datagridvalue);
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: {dateValue.ToLongDateString()}");
                }
                else if(datagridvalue == "M")
                {
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: Male");
                }
                else if(datagridvalue == "F")
                {
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: Female");
                }
                else if(datagridvalue =="1" && dgv.Columns[i].HeaderText == "WU Student")
                {
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: Yes");
                }
                else if (datagridvalue == "0" && dgv.Columns[i].HeaderText == "WU Student")
                {
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: No");
                }
                else if (dgv.Columns[i].HeaderText == "Book ID")
                {
                    string bookIDNumOnly = dgv.Rows[rowIndex].Cells[i].Value.ToString();
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: {"Book" + bookIDNumOnly.PadLeft(8, '0')}");
                }
                else
                {
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: {dgv.Rows[rowIndex].Cells[i].Value}");
                }
            }
            lblText.Text = columns.ToString();
            this.Size = new Size(Width, lblText.Height + 160);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
