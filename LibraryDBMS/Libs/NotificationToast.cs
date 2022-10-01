using LibraryDBMS.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
