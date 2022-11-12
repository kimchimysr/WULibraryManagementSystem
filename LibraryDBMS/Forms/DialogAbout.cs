using LibraryDBMS.Libs;
using System;
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
    }
}
