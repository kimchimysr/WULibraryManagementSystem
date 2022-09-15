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
    public partial class DialogIssueBook : Form
    {
        public DialogIssueBook()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnSearchBookID":
                    if (txtBorrowID.Text.Length > 0)
                        LibModule.SearchAndShow("tblBook", "title", "bookID", txtBorrowID.Text.Trim(), lblTitle);
                    break;
                case "btnSearchStudentID":
                    break;
                case "btnBookTitle":
                    break;
                case "btnStudentName":
                    break;
                case "btnSave":
                    break;
                case "btnClear":
                    break;
                case "btnCancel":
                    break;
            }
        }

        private void DialogIssueBook_Load(object sender, EventArgs e)
        {

        }
    }
}
