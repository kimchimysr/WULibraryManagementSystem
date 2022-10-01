using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WesternLibraryManagementSystem.Libs;

namespace WesternLibraryManagement.Forms
{
    public partial class FrmViewBookCategory : Form
    {
        private string categorySelectedID { get; set; }
        public FrmViewBookCategory()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnCopyToClipboard":
                    Clipboard.SetText(categorySelectedID);
                    break;
            }
                
        }
        private void FormViewBookCategory_Load(object sender, EventArgs e)
        {
            this.btnCopyToClipboard.Enabled = false;
            LibModule.FillDataGridView("tblBookCategory",dgvBookCategories);
        }

        private void dgvBookCategories_Click(object sender, EventArgs e)
        {
            this.btnCopyToClipboard.Enabled = true;
            categorySelectedID = dgvBookCategories.SelectedRows[0].Cells["Column1"].Value.ToString();
        }
    }
}
