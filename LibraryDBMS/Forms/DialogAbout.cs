using LibraryDBMS.Libs;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogAbout : Form
    {
        public DialogAbout()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
            InitializeValues();
        }

        private void InitializeValues()
        {
            string version = Application.ProductVersion;
            lblVersion.Text = $"Version {version}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kimchimysr/WULibraryManagementSystem/releases");
        }
    }
}
