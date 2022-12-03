using LibraryDBMS.Libs;
using System;
using System.Windows.Forms;
using LibraryDBMS.Setting;
using System.Data;

namespace LibraryDBMS.Forms
{
    public partial class DialogSetting : Form
    {
        private UserSetting us;
        private readonly DataTable user;
        public DialogSetting(DataTable _user)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            user = _user;
            InitializeValues();
        }

        private void InitializeValues()
        {
            SuspendLayout();
            us = new UserSetting();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
            Utils.FillComboBox(cbStartupForm, false ,"Home", "Dashboard");
            Utils.FillComboBox(cbTable, true, "All", "tblBooks", "tblBookCategories", "tblBorrows", "tblLoanStatus",
                "tblLogs", "tblStudents", "tblUser", "tblUserLogs", "viewOverview");
            AppliedUserSetting();
            ResumeLayout();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnImport":
                    Utils.ImportExcelDataIntoDatabase();
                    break;
                case "btnExport":
                    Utils.ExportDatabaseTableToExcel(cbTable.SelectedItem.ToString());
                    break;
                case "btnBackup":
                    DialogResult databaseType =
                        MessageBox.Show("Do you want to backup database for new user?" +
                        "\nYes (Current User will not be included)" +
                        "\nNo (Current User will be included)", "Choose Backup Mode", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (databaseType == DialogResult.Yes)
                        LibModule.BackupDatabaseForNewUser();
                    else if (databaseType == DialogResult.No)
                        Utils.BackupDatabase();
                    else return;
                    break;
                case "btnRestore":
                    if (Utils.RestoreDatabase())
                    {
                        LibModule.LogTimestampUserLogout(user);
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    break;
                case "btnLoginHistory":
                    var dialogLoginHistory = new DialogLoginHistory();
                    dialogLoginHistory.ShowDialog();
                    break;
                case "btnRestart":
                    if (SettingHasChanged())
                        us.Save();
                    DialogResult result = MessageBox.Show("Do you want to restart the application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        LibModule.LogTimestampUserLogout(user);
                        Application.Restart();
                        Environment.Exit(0);
                    }
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
