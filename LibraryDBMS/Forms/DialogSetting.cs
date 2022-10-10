using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS.Setting;

namespace LibraryDBMS.Forms
{
    public partial class DialogSetting : Form
    {
        private UserSetting us;
        public DialogSetting()
        {
            InitializeComponent();
            InitializeValues();
        }

        private void InitializeValues()
        {
            SuspendLayout();
            us = new UserSetting();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
            Utils.FillComboBox(cbStartupForm, false ,"Home", "Dashboard");
            AppliedUserSetting();
            ResumeLayout();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnRestart":
                    if (SettingHasChanged())
                        us.Save();
                    DialogResult result = MessageBox.Show("Do you want to restart the application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                        Application.Restart();
                    break;
                case "btnCancel":
                case "btnClose":
                    if (SettingHasChanged())
                        us.Save();
                    this.Close();
                    break;
            }
        }

        private void AppliedUserSetting()
        {
            cbStartupForm.SelectedItem = us.DefaultStartPage;
            tbStartInFullscreen.Checked = us.StartAppInFullscreen;
            tbAutoStartup.Checked = us.SetApplicationAutoRun;
            tbSidebarCollapse.Checked = us.SetSidebarCollapsed;
        }

        private bool SettingHasChanged()
        {
            bool changes = false;
            string defaultStartPage = cbStartupForm.SelectedItem.ToString();
            bool startInFullscreen = tbStartInFullscreen.Checked;
            bool startAppWhenWindowsStarted = tbAutoStartup.Checked;
            bool startAppWithCollapsedSidebar = tbSidebarCollapse.Checked;

            if (us.DefaultStartPage != defaultStartPage)
            {
                us.DefaultStartPage = defaultStartPage;
                changes = true;
            }

            if (us.StartAppInFullscreen != startInFullscreen)
            {
                us.StartAppInFullscreen = startInFullscreen;
                changes = true;
            }

            if (us.SetApplicationAutoRun != startAppWhenWindowsStarted)
            {
                us.SetApplicationAutoRun = startAppWhenWindowsStarted;
                Utils.SetApplicationAutorunAtWindowStartup(startAppWhenWindowsStarted);
                changes = true;
            }

            if (us.SetSidebarCollapsed != startAppWithCollapsedSidebar)
            {
                us.SetSidebarCollapsed = startAppWithCollapsedSidebar;
                changes = true;
            }

            if (changes)
                MessageBox.Show("Some changes will be applied after restarting application!", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            return changes;
        }
    }
}
