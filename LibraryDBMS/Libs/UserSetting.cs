using System.Configuration;

// reference: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-application-settings?view=netframeworkdesktop-4.8
namespace LibraryDBMS.Setting
{
    public class UserSetting : ApplicationSettingsBase
    {
        public UserSetting()
        {
            // set default value of DefaultStartPage
            if (string.IsNullOrEmpty(DefaultStartPage))
            {
                DefaultStartPage = "Home";
                Save();
            }
        }

        [UserScopedSetting]
        public string DefaultStartPage
        {
            get { return ((string)(this["DefaultStartPage"])); }
            set { this["DefaultStartPage"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("False")]
        public bool StartAppInFullscreen
        {
            get { return (bool)this["StartAppInFullscreen"]; }
            set { this["StartAppInFullscreen"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("False")]
        public bool SetApplicationAutoRun
        {
            get { return (bool)this["SetApplicationAutoRun"]; }
            set { this["SetApplicationAutoRun"] = value; }
        }

        [UserScopedSetting]
        [DefaultSettingValue("False")]
        public bool SetSidebarCollapsed
        {
            get { return (bool)this["SetSidebarCollapsed"]; }
            set { this["SetSidebarCollapsed"] = value; }
        }
    }
}
