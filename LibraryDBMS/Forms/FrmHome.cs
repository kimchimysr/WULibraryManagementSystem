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
    public partial class FrmHome : Form
    {
        Timer dateTime;
        public FrmHome()
        {
            InitializeComponent();
            DisplayDateTime();
        }

        private void DisplayDateTime()
        {
            dateTime = new Timer();
            dateTime.Tick += DateTime_Tick;
            dateTime.Start();
        }

        private void DateTime_Tick(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.ToLongDateString();
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
