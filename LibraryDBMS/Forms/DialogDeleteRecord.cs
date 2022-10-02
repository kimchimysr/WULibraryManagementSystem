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
    public partial class DialogDeleteRecord : Form
    {
        string record;
        public DialogDeleteRecord(string _record)
        {
            InitializeComponent();
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
