using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WesternLibraryManagementSystem.Temp
{
    public partial class FrmMainMenu2 : Form
    {
        public FrmMainMenu2()
        {
            InitializeComponent();
            int style = NativeWinAPI.GetWindowLong(this.pForm.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            pForm.Controls.Clear();
            Form frm = new FrmSQLiteConnection();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pForm.Controls.Add(frm);
            frm.Show();
        }

        private void btnUserControl_Click(object sender, EventArgs e)
        {
            pForm.Controls.Clear();
            pForm.Controls.Add(new UserControl1());
        }
    }
}
