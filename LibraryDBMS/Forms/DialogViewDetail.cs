using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogViewDetail : Form
    {
        private readonly DataGridView dgv;
        private readonly int rowIndex;
        public DialogViewDetail()
        {
            InitializeComponent();
        }

        public DialogViewDetail(DataGridView _dgv, int _rowIndex, string title)
        {
            InitializeComponent();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            dgv = _dgv;
            rowIndex = _rowIndex;
            lblHeader.Text = $"View {title}";
            FillAndResizeForm();
        }

        private void FillAndResizeForm()
        {
            int i = 0;
            StringBuilder columns = new StringBuilder();
            for (i = 0; i < dgv.Columns.Count; i++)
            {
                columns.AppendLine($"{dgv.Columns[i].HeaderText}: {dgv.Rows[rowIndex].Cells[i].Value}");
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
