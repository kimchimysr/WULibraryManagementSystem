using LibraryDBMS.Libs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmBlurScreen : Form
    {
        public FrmBlurScreen(FrmMainMenu mainMenu)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.Black;
            Size = mainMenu.Size;
            Location = mainMenu.Location;
            Opacity = 0.01;
            ShowInTaskbar = false;
        }

        private void FrmBlurScreen_Load(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => Opacity = 0.50));
        }
    }
}
