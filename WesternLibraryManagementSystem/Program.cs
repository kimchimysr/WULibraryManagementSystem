using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WesternLibraryManagement.Forms;

namespace WesternLibraryManagementSystem.Forms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmBook());
            /*
            make it easier to run the form fast in production but when release please only use main form
            Application.Run(new FormViewBookCategory());
            Application.Run(new FrmBook());
            Application.Run(new FrmUser());
            Application.Run(new Form1());
            Application.Run(new FormBorrowBook());
            Application.Run(new FrmManageUser());
            */
        }
    }
}