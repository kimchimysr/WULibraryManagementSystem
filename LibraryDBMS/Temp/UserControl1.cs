using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBMS;

namespace LibraryDBMS
{
    public partial class UserControl1 : UserControl
    {
        // connection object
        SQLiteConnection conn = new SQLiteConnection(Path.Combine("Data Source=" + Environment.CurrentDirectory, "Database/library.db"));
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            conn.Open();
            // command object
            string query = "SELECT * FROM tblBook";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            // adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            // datatable
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // set dgvBooks data source
            dgvBooks.DataSource = dt;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            conn.Close();
        }
    }
}
