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

namespace WesternLibraryManagementSystem.Forms
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LibModule.FillComboBox("tblRole", cbRole, "roleName", "roleID");
            //LibModule.FillDataGridView("tblUser",LibModule.GetTableField("tblUser"), dgvUsers);
            //Utils.ChangeControlEnabled(this, true,
            //    txtSearchID.Name, btnNewUser.Name, btnFindUser.Name, btnRefresh.Name);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnNewUser":
                    txtUserID.Text = LibModule.GetAutoID("tblUser", "userID");
                    //Utils.ChangeControlEnabled(this, true, 
                    //    txtUsername.Name, txtFirstName.Name, txtLastName.Name,
                    //    txtAddress.Name, txtTelephone.Name, txtEmail.Name,
                    //    rbMale.Name, rbFemale.Name, dtpDOB.Name, cbRole.Name,
                    //    btnSaveChanges.Name);
                    break;
                case "btnFindUser":
                    break;
                case "btnSaveChanges":
                    break;
            }
        }
    }
}
