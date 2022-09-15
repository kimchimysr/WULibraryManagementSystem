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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LibModule.FillDataGridView("tblBook", LibModule.GetTableField("tblBook"), dgvBooks);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>
            {
                LibModule.GetAutoID("tblBook", "bookID"),
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
            if (!LibModule.IsDuplicated("tblBook", "title", "Harry Potter"))
            {
                LibModule.InsertRecord("tblBook", LibModule.GetTableField("tblBook"), values);
                //LibModule.FillDataGridView("tblBook", LibModule.GetTableField("tblBook"), dgvBooks);
            }        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedBookID = "2302";
            List<string> values = new List<string>
            {
                "2302",
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

            LibModule.UpdateRecord("tblBook", LibModule.GetTableField("tblBook"),
                "bookID", selectedBookID, values, true);
            //LibModule.FillDataGridView("tblBook", LibModule.GetTableField("tblBook"), dgvBooks);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedBookID = "2302";
            LibModule.DeleteRecord("tblBook", "bookID", selectedBookID);
            //LibModule.FillDataGridView("tblBook", LibModule.GetTableField("tblBook"), dgvBooks);
        }
    }
}
