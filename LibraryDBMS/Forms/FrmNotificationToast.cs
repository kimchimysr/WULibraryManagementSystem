using LibraryDBMS.Libs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmNotificationToast : Form
    {
        private Timer timer;
        public FrmNotificationToast(string condition, string message)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            SetTypeOfNotification(condition, message);
            InitializeValues();
        }

        private void InitializeValues()
        {
            this.DoubleBuffered = true;
            // We want our window to be the top most
            TopMost = true;
            // Pop doesn't need to be shown in task bar
            ShowInTaskbar = false;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - (Size.Width),
                                      workingArea.Bottom - (Size.Height));
            // Create and run timer for animation
            timer = new Timer();
            timer.Interval = (3000);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // show toast without focusing
        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        private void SetTypeOfNotification(string condition, string message)
        {
            if (condition == "success")
            {
                this.BackColor = ColorTranslator.FromHtml("#218559");
                btnClose.BackColor = ColorTranslator.FromHtml("#218559");
                lblText.Text = message;
            }
            else if (condition == "fail")
            {
                this.BackColor = ColorTranslator.FromHtml("#DD1E2F");
                btnClose.BackColor = ColorTranslator.FromHtml("#DD1E2F");
                lblText.Text = message;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
