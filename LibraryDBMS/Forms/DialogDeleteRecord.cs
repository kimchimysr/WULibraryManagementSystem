using LibraryDBMS.Libs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogDeleteRecord : Form
    {
        private readonly string record;
        public DialogDeleteRecord(string _record)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            record = _record;
            lblText.Text = record;
            this.Size = new Size(Width, lblText.Height + 170);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
