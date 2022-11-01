using LibraryDBMS.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDBMS.Forms
{
    public partial class FrmRecentActivity : Form
    {
        public FrmRecentActivity()
        {
            InitializeComponent();
            Utils.EnableControlDoubleBuffer(dgvlogList);
            Utils.FillComboBox(cbDay, true, "All", "Today", "Yesterday", "Older");
            lblRowsCount.Text = $"Total Result: {dgvlogList.Rows.Count}";
        }

        public override void Refresh()
        {
            base.Refresh();
            LibModule.FillDataGrid("tblLogs", dgvlogList, "logID");
            lblRowsCount.Text = $"Total Result: {dgvlogList.Rows.Count}";
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDay.SelectedIndex >= 0)
            {
                string query = string.Empty;
                switch (cbDay.SelectedItem.ToString())
                {
                    case "All":
                        LibModule.FillDataGrid("tblLogs", dgvlogList, "logID");
                        break;
                    case "Today":
                        query = 
                            "SELECT * FROM tblLogs WHERE DATE(timestamp) = DATE('NOW') ORDER BY timestamp DESC";
                        LibModule.FillDataGrid(query, dgvlogList);
                        break;
                    case "Yesterday":
                        query =
                            "SELECT * FROM tblLogs WHERE DATE(timestamp) = DATE('NOW', '-1 day') ORDER BY timestamp DESC";
                        LibModule.FillDataGrid(query, dgvlogList);
                        break;
                    case "Older":
                        query =
                            "SELECT * FROM tblLogs WHERE DATE(timestamp) < DATE('NOW', '-1 day') ORDER BY timestamp DESC";
                        LibModule.FillDataGrid(query, dgvlogList);
                        break;
                    default:
                        break;
                }
                lblRowsCount.Text = $"Total Result: {dgvlogList.Rows.Count}";
            }
        }
    }
}