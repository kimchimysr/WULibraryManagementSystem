using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace WesternLibraryManagementSystem.Forms
{
    public partial class FrmSQLiteConnection : Form
    {
        // connection object
        SQLiteConnection conn = new SQLiteConnection(Path.Combine("Data Source=" + Environment.CurrentDirectory, "Database/library.db"));

        public FrmSQLiteConnection()
        {
            InitializeComponent();
        }

        private void FrmSQLiteConnection_Load(object sender, EventArgs e)
        {
            conn.Open();
            // command object
            string query = "SELECT * FROM book";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            // adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            // datatable
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // set dgvBooks data source
            dgvBooks.DataSource = dt;
        }

        private void FrmSQLiteConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
