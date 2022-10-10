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
    public partial class FrmRecentActivity : Form
    {
        public FrmRecentActivity()
        {
            InitializeComponent();
            Utils.EnableControlDoubleBuffer(dgvlogList);
            LibModule.FillDataGrid("tblLog", dgvlogList, "logID");
        }

        public override void Refresh()
        {
            base.Refresh();
            LibModule.FillDataGrid("tblLog", dgvlogList, "logID");
        }
    }
}