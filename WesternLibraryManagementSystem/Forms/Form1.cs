using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using WesternLibraryManagementSystem.Libs;

namespace WesternLibraryManagementSystem.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LibModule.FillDataGridView("tblBook", dgvBooks);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>
            {
                LibModule.GetAutoID("book", "bookID"),
                "1234567890123",
                "800 HAR",
                "Harry Potter",
                "JK Rowling",
                "HP",
                "2004",
                "849",
                "Original",
                "5",
                "3",
                "2022-09-10"
            };
            LibModule.InsertRecord("tblBook", LibModule.GetDBTableFields("tblBook"), values);
            LibModule.FillDataGridView("tblBook", dgvBooks);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> fieldNames = new List<string>();
            fieldNames.AddRange(LibModule.GetDBTableFields("tblBook").Split(','));

            string selectedBookID = "4423";
            List<string> values = new List<string>
            {
                "1234567890123",
                "800 HAR",
                "Harry Potter",
                "JK Rowling",
                "HP",
                "2004",
                "849",
                "Copy",
                "5",
                "3",
                "2022-09-10"
            };

            LibModule.UpdateRecord("tblBook", fieldNames, "bookID", selectedBookID, values);
            LibModule.FillDataGridView("tblBook", dgvBooks);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedBookID = "4423";
            LibModule.DeleteRecord("tblBook", "bookID", selectedBookID);
            LibModule.FillDataGridView("tblBook", dgvBooks);
        }
    }
}
