using LibraryDBMS.Forms;

namespace LibraryDBMS.Libs
{
    public static partial class Utils
    {
        public class NotificationToast
        {
            public static void Show(string condition, string message)
            {
                var toast = new FrmNotificationToast(condition, message);
                toast.Show();
            }
        }
    }
}
