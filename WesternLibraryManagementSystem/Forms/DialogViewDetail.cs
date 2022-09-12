using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WesternLibraryManagementSystem.Forms
{
    public partial class DialogViewDetail : Form
    {
        private DataGridView dgv;
        public DialogViewDetail()
        {
            InitializeComponent();
        }

        public DialogViewDetail(DataGridView _dgv, string title)
        {
            InitializeComponent();
            dgv = _dgv;
            Text = $"View {title}";
            lblTitle.Text = $"View {title}";
        }

        private void FrmVIewDetail_Load(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                StringBuilder sb = new StringBuilder();
                for (i = 0; i < dgv.Columns.Count; i++)
                {
                    sb.AppendLine($"{dgv.Columns[i].HeaderText}: {dgv.SelectedRows[0].Cells[i].Value}");
                }
                lblText.Text = sb.ToString();
                this.Size = new Size(Width, (i * 25) + 200);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
