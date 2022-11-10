using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using LibraryDBMS.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Libs
{
    public partial class Utils
    {
        public class BlurEffect
        {
            static private FrmBlurScreen blur;
            static BlurEffect() { }

            public static void ShowDialogWithBlurEffect(Form dialog, FrmMainMenu mainMenu)
            {
                var blur = new FrmBlurScreen(mainMenu);
                try
                {
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
