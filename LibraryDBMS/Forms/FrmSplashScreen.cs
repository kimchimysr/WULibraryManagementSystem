using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.IO;
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
            "Starting Library Management System...",
            "All done..."
        };
        public FrmSplashScreen()
        {
            if (!File.Exists(Utils.databasePath))
            {
                var dialogDatabaseCreationMode = new DialogDatabaseCreationMode();
                DialogResult result = dialogDatabaseCreationMode.ShowDialog();
                // yes == create new database
                if (result == DialogResult.Yes)
                    Utils.CopyDatabaseToLocalUserAppDataFolder();
                // no == import old database
                else if (result == DialogResult.No)
                    Utils.ImportOldDatabase();
            }

            InitializeComponent();
            Utils.SetFormIcon(this);
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
