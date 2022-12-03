using LibraryDBMS.Libs;
using System;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class DialogDatabaseCreationMode : Form
    {
        public DialogDatabaseCreationMode()
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
