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
        public DialogViewDetail()
        {
            InitializeComponent();
        }

        public DialogViewDetail(DataGridView _dgv, string title)
        {
            InitializeComponent();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            dgv = _dgv;
            lblHeader.Text = $"View {title}";
        }

        private void FrmViewDetail_Load(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                StringBuilder columns = new StringBuilder();
                for (i = 0; i < dgv.Columns.Count; i++)
                {
                    columns.AppendLine($"{dgv.Columns[i].HeaderText}: {dgv.SelectedRows[0].Cells[i].Value}");
                }
                lblText.Text = columns.ToString();
                this.Size = new Size(Width, lblText.Height + 160);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
