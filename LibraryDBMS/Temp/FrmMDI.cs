using LibraryDBMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Temp
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            switch (tsmi.Name)
            {
                case "ManageBook":
                    var frmManageBook = new FrmManageBook();
                    frmManageBook.MdiParent = this;
                    frmManageBook.Show();
                    break;
                case "ManageStudent":
                    var frmManageStudent = new FrmManageStudent();
                    frmManageStudent.MdiParent = this;
                    frmManageStudent.Show();
                    break;
                case "ManageBookLoanReturn":
                    var frmManageBookLoanReturn = new FrmBorrowBook();
                    frmManageBookLoanReturn.MdiParent = this;
                    frmManageBookLoanReturn.Show();
                    break;
                case "Report":
                    var frmReport = new FrmReportViewer();
                    frmReport.MdiParent = this;
                    frmReport.Show();
                    break;
            }
        }
    }
}
