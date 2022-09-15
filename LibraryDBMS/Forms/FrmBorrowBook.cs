using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class FrmBorrowBook : Form
    {
        public FrmBorrowBook()
        {
            InitializeComponent();
        }

        private void FrmBorrowBook_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            LibModule.FillDataGrid("viewBorrowBook", dgvBorrowList);
        }
    }
}
