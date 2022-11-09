using LibraryDBMS.Libs;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class FrmSplashScreen : Form
    {
        private Timer timer = new Timer();
        private int index = 0;
        private List<string> texts = new List<string>()
        {
            "Loading assets...",
            "Connecting to SQLite database...",
            "Fetching data from database...",
            "All done...",
            "Starting Library Management System..."
        };
        public FrmSplashScreen()
        {
            InitializeComponent();
            Utils.FixControlFlickering(panel1);
            timer.Interval = 60;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer.Stop();
                var frmMainMenu = new FrmMainMenu();
                frmMainMenu.ShowDialog();
                this.Close();
            }
            else progressBar1.Value += 2;

            if (progressBar1.Value % 20 == 0)
            {
                lblText.Text = texts[index];
                if (progressBar1.Value < 100)
                    index++;
            }
        }
    }
}
