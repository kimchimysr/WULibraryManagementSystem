using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmManageBook : Form
    {
        public FrmManageBook()
        {
            InitializeComponent();
            LibModule.FillDataGrid("tblBook", dgvBooks, "bookID");
            typeof(DataGridView).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               dgvBooks,
               new object[] { true });
        }
    }
}
