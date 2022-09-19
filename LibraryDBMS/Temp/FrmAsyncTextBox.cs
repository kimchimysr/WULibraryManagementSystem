using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WesternLibraryManagementSystem.Temp
{
    public partial class FrmAsyncTextBox : Form
    {
        public FrmAsyncTextBox()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var bfSingleThread = 
                new BreakfastSingleThread((text) => txtMainThread.AppendText(text + Environment.NewLine));
            bfSingleThread.MakeBreakfast();
        }

        private async void btnRunAsync_Click(object sender, EventArgs e)
        {
            var progress = new Progress<string>();
            progress.ProgressChanged += (s, message) =>
            {
                if (!txtMultipleThreadHeavy.IsDisposed)
                    txtMultipleThreadHeavy.AppendText(message + Environment.NewLine);
            };

            var bfMultipleThread = new BreakfastHeavilyDigested(progress);
            await Task.Run(() => bfMultipleThread.MakeBreakfastAsync());
        }
    }
}
