using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Temp
{
    public partial class FrmAsyncDataGrid : Form
    {
        private List<(string order, string action)> makeBreakfast;
        public FrmAsyncDataGrid()
        {
            InitializeComponent();
            FillMakeBreakfast();
        }

        private void FillMakeBreakfast()
        {
            makeBreakfast = new List<(string order, string action)>
            {
                ("0", "Making Breakfast"),
                ("1", "Starting Coffee"),
                ("2", "Coffee Brewed"),
                ("3", "Coffee Poured"),
                ("4", "Coffee Flavored"),
                ("5", "Finished Coffee"),
                ("6", "Starting Orange Juice"),
                ("7", "Got Orange Juice"),
                ("8", "Poured Orange Juice"),
                ("9", "Finished Orange Juice"),
                ("10", "Starting Breakfast Sandwich"),
                ("11", "Got Food"),
                ("12", "Started Bacon"),
                ("13", "Placed Bacon in Pan"),
                ("14", "Fried Bacon"),
                ("15", "Finished Bacon"),
                ("16", "Started Eggs"),
                ("17", "Cracked Eggs"),
                ("18", "Placed Eggs in Pan"),
                ("19", "Fried Eggs"),
                ("20", "Finished Eggs"),
                ("21", "Toasted Bread"),
                ("22", "Remove Cheese From Package"),
                ("23", "Assembled Sandwich"),
                ("24", "Placed Sandwich on Plate"),
                ("25", "Finished Breakfast Sandwich"),
                ("26", "Enjoy"),
                ("27", "All Done!"),
            };
        }

        private void FillDataGridSingleThread()
        {
            Stopwatch timer = Stopwatch.StartNew();
            foreach (var item in makeBreakfast)
            {
                Thread.Sleep(1000);
                dgvSingleThread.Rows.Add(item.order, item.action);
                dgvSingleThread.Refresh();
            }
            lblTimeS.Text += $"{timer.ElapsedMilliseconds / 1000} ms";
        }

        private async Task FIllDataGridMultipleThreads()
        {
            Stopwatch timer = Stopwatch.StartNew();
            DataTable dt = new DataTable();
            dt.Columns.Add("order");
            dt.Columns.Add("action");
            var tasks = new List<Task>();
            for (int i = 0; i < makeBreakfast.Count; i++)
            {
                tasks.Add(AddRowAsync(dt, i));
            }
            await Task.WhenAll(tasks);
            lblTimeM.Text += $"{timer.ElapsedMilliseconds / 1000} s";
            StringBuilder str = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                str.AppendLine($"{row["order"]} {row["action"]}");
            }
            MessageBox.Show($"{str}");
        }

        private async Task AddRowAsync(DataTable dt, int index)
        {
            Task.Run(() => Thread.Sleep(1000));
            await Task.Run(() => dt.Rows.Add(makeBreakfast[index]));
        }

        private void btnRunSingleThread_Click(object sender, EventArgs e)
        {
            FillDataGridSingleThread();
        }

        private async void btnRunMultipleThreads_Click(object sender, EventArgs e)
        {
            await FIllDataGridMultipleThreads();
        }
    }
}
