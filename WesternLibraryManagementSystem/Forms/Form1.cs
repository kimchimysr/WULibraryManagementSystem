using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            LibModule.FillDataGridView(LibModule.TableBook.Name, dgvBooks);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>
            {
                "1234567890123",
                "800 HAR",
                "Harry Potter",
                "JK Rowling",
                "HP",
                "2004",
                "849",
                "Original",
                "5"
            };
            LibModule.InsertRecord(LibModule.TableBook.Name, LibModule.TableBook.Fields, values);
            LibModule.FillDataGridView(LibModule.TableBook.Name, dgvBooks);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> fieldNames = new List<string>();
            fieldNames.AddRange(LibModule.TableBook.Fields.Split(','));

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
                "5"
            };
            LibModule.UpdateRecord(LibModule.TableBook.Name, fieldNames, "bookID", selectedBookID, values);
            LibModule.FillDataGridView(LibModule.TableBook.Name, dgvBooks);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedBookID = "4423";
            LibModule.DeleteRecord(LibModule.TableBook.Name, "bookID", selectedBookID);
            LibModule.FillDataGridView(LibModule.TableBook.Name, dgvBooks);
        }
    }
}
