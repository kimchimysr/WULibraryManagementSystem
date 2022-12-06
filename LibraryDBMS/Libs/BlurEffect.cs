using LibraryDBMS.Forms;
using System;
using System.Windows.Forms;

namespace LibraryDBMS.Libs
{
    public partial class Utils
    {
        // C# - Pop up Form with Fade Background in Windows Forms Application
        // https://youtu.be/jB8q__utFwA
        public class BlurEffect
        {
            static private FrmBlurScreen blur;
            static BlurEffect() { }

            public static void ShowDialogWithBlurEffect(Form dialog, FrmMainMenu mainMenu)
            {
                var blur = new FrmBlurScreen(mainMenu);
                try
                {
                    blur.Owner = mainMenu;
                    blur.Show();
                    dialog.ShowDialog();
                    blur.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                    "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    blur.Dispose();
                }
            }

            public static void Blur(FrmMainMenu mainMenu)
            {
                blur = new FrmBlurScreen(mainMenu);
                blur.Show();
            }

            public static void UnBlur()
            {
                if(blur != null)
                    blur.Dispose();
            }
        }
    }
}
