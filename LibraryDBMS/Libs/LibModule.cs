using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using Microsoft.Reporting.WinForms;
using LibraryDBMS.Forms;

namespace LibraryDBMS.Libs
{
    public static class LibModule
    {
        private static string connectionString;
        public static SQLiteConnection Conn;
        public static SQLiteCommand Cmd;

        static LibModule()
        {
            // sqlite connection string format: data source=databasePath; Version=3; Foreign Keys=True;
            connectionString = $@"Data Source={Utils.databasePath}; Version=3; Foreign Keys=True;";
            Conn = new SQLiteConnection(connectionString);

            if (!File.Exists(Utils.databasePath))
            {
                MessageBox.Show("Cannot locate database file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static string GetTableField(string tableName)
        {
            List<(string Name, string Fields)> dbTables = new List<(string Name, string Fields)>
            {
                ("tblBooks", "bookID,isbn,dewey,title,author,publisher,publishYear,pages,other,qty,cateID,dateAdded"),
                ("tblBookCategories", "cateID,cateName"),
                ("tblStudents", "studentID,firstName,lastName,gender,year,major,tel,dateAdded"),
                ("tblLoanStatus", "loanStatusID,loanStatusName"),
                ("tblBorrows", "borrowID,bookID,studentID,dateLoan,dateDue,dateReturned,overdueFine,loanStatusID"),
                ("tblUser", "userID,username,roleName,firstName,lastName,gender,dob,addr,tel,email,dateAdded"),
                ("tblUserLogs", "username,info")
            };
            int index = dbTables.IndexOf(dbTables.Find(x => x.Name == tableName));
            return dbTables[index].Fields;
        }

        #region Insert,Update,Delete
        public static bool InsertRecord(string tableName, string fieldNames, List<string> values,
            bool showMessage = true)
        {
            StringBuilder parameters = new StringBuilder();
            int index = 1;
            for (int i = 0; i < values.Count; i++)
            {
                if (i == values.Count - 1)
                {
                    parameters.Append($"@Val{i+1}");
                }
                else
                {
                    parameters.Append($"@Val{i+1},");
                }
            }
            string query = $"INSERT INTO {tableName} ({fieldNames}) VALUES ({parameters});";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = query;
                foreach (string val in values)
                {
                    Cmd.Parameters.AddWithValue($"@Val{index++}", val);
                }
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    if(showMessage)
                        Utils.NotificationToast.Show("success", "Record Added Successfully!");
                    return true;
                }
                else Utils.NotificationToast.Show("fail", "Record Cannot Be Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return false;
        }

        // Bulk insert using transaction
        // https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/bulk-insert
        public static bool BulkInsertRecord(DataTable values)
        {
            Conn.Open();
            Cmd = new SQLiteCommand();
            Cmd.Connection = Conn;
            using (var transaction = Conn.BeginTransaction())
            {
                try
                {
                    Cmd.CommandText =
                    @"
                        INSERT OR REPLACE INTO tblBooks(bookID,isbn,dewey,title,author,publisher,publishYear,pages,other,qty,cateID,dateAdded)
                        VALUES ($bookID,$isbn,$dewey,$title,$author,$publisher,$publishYear,$pages,$other,$qty,$cateID,$dateAdded)
                    ";

                    var parameters = new SQLiteParameter[]
                    {
                        new SQLiteParameter("$bookID"),
                        new SQLiteParameter("$isbn"),
                        new SQLiteParameter("$dewey"),
                        new SQLiteParameter("$title"),
                        new SQLiteParameter("$author"),
                        new SQLiteParameter("$publisher"),
                        new SQLiteParameter("$publishYear"),
                        new SQLiteParameter("$pages"),
                        new SQLiteParameter("$other"),
                        new SQLiteParameter("$qty"),
                        new SQLiteParameter("$cateID"),
                        new SQLiteParameter("$dateAdded")
                    };
                    Cmd.Parameters.AddRange(parameters);

                    // Insert a lot of data
                    foreach(DataRow row in values.Rows)
                    {
                        for (int i = 0; i < values.Columns.Count; i++)
                        {
                            parameters[i].Value = row[i].ToString();
                        }
                        Cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                    "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Cmd != null)
                        Cmd.Dispose();
                    if (Conn != null)
                        Conn.Close();
                }
            }
            return false;
        }

        public static bool UpdateRecord(string tableName, string fieldNames,
            string conditionFIeldName, string conditionValue, List<string> values,
            bool showMessage, params string[] fieldExc)
        {
            List<string> fields = new List<string>();
            fields.AddRange(fieldNames.Split(','));
            // remove exclude fields from fieldNamesList
            if(fieldExc.Length > 0)
                foreach(string str in fieldExc)
                    fields.Remove(str);
            StringBuilder setFieldsValue = new StringBuilder();
            int index = 1;
            foreach (string field in fields)
            {
                if (field == fields.Last())
                {
                    setFieldsValue.Append($"{field}=@val{index++}");
                }
                else
                {
                    setFieldsValue.Append($"{field}=@val{index++},");
                }
            }
            string query = $"UPDATE {tableName} SET {setFieldsValue} WHERE {conditionFIeldName}=@condVal;";
            try
            {
                index = 1;
                Conn.Open();
                Cmd = new SQLiteCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = query;
                foreach (string val in values)
                {
                    Cmd.Parameters.AddWithValue($"@val{index++}", val);
                }
                Cmd.Parameters.AddWithValue("@condVal", conditionValue);
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    if (showMessage)
                        Utils.NotificationToast.Show("success", "Record Updated Successfully!");
                    return true;
                }
                else Utils.NotificationToast.Show("fail", "Record Cannot Be Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return false;
        }

        public static bool DeleteRecord(string tableName, string conditionFieldName, string conditionValue,
            string record)
        {
            string query = $"DELETE FROM {tableName} WHERE {conditionFieldName}=@condVal;";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                Cmd.Parameters.AddWithValue("@condVal", conditionValue);
                Form dialogDeleteRecord = new DialogDeleteRecord(record);
                if (dialogDeleteRecord.ShowDialog() == DialogResult.Yes)
                {
                    if (Cmd.ExecuteNonQuery() == 1)
                    {
                        Utils.NotificationToast.Show("success", "Record Deleted Successfully!");
                        return true;
                    }
                    else Utils.NotificationToast.Show("fail", "Record Cannot Be Deleted!");
                }
            }
            catch (SQLiteException ex)
            {
                Utils.BlurEffect.UnBlur();
                SQLiteErrorCode errorCode = (SQLiteErrorCode)ex.ErrorCode;
                if (errorCode == SQLiteErrorCode.Constraint)
                {
                    MessageBox.Show("Record already has relationship with other table! Cannot delete!", "Foreign Key Constraint Falied",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Utils.BlurEffect.UnBlur();
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return false;
        }
        #endregion

        #region Custom Queries
        // custom query
        public static bool ExecuteQuery(string query, bool showMessage = false)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    if(showMessage)
                        MessageBox.Show("Query Executed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    if(showMessage)
                        MessageBox.Show("Query Cannot Execute!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return false;
        }

        // custom scalar query
        public static string ExecuteScalarQuery(string query)
        {
            string str = string.Empty;
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                var result = Cmd.ExecuteScalar();
                if(result != null)
                    str = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return str;
        }

        public static string ExecuteScalarQueryWithSQLiteParameters(string query, string paramSign, params string[] values)
        {
            string str = string.Empty;
            int i = 1;
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                foreach (string paramValue in values)
                    Cmd.Parameters.AddWithValue($"{paramSign}{i++}", paramValue);
                var result = Cmd.ExecuteScalar();
                if (result != null)
                    str = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return str;
        }
        #endregion

        #region Fill
        public static void FillDataGrid(string tableName, DataGridView dgv, string fieldToSort = null)
        {
            try
            {
                Conn.Open();
                string query = fieldToSort == null ?
                    $"SELECT * FROM {tableName} LIMIT 100;" :
                    $"SELECT * FROM {tableName} ORDER BY {fieldToSort} DESC LIMIT 100;";
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.DataBindingComplete += Dgv_DataBindingComplete;
                void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
                {
                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
        }

        public static void FillDataGrid(string query, DataGridView dgv)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.DataBindingComplete += Dgv_DataBindingComplete;
                void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
                {
                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
        }

        public static void FillReportViewer(string tableName, ReportViewer rpv, string rpPath,
                    string rpDataSet, Dictionary<string,string> parameters = null)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName};", Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                rpv.LocalReport.ReportEmbeddedResource = rpPath;
                if (parameters != null)
                {
                    List<ReportParameter> listReportParameter = new List<ReportParameter>();
                    foreach(var p in parameters)
                        listReportParameter.Add(new ReportParameter(p.Key, p.Value));
                    rpv.LocalReport.SetParameters(listReportParameter);
                }
                ReportDataSource rds = new ReportDataSource(rpDataSet, ds.Tables[0]);
                rpv.LocalReport.DataSources.Clear();
                rpv.ResetPageSettings();
                rpv.LocalReport.DataSources.Add(rds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
        }

        #endregion

        #region Search
        public static void SearchAndFillDataGrid(string tableName, string conditionField, string conditionValue,
            DataGridView dgv, bool useWildcard = true)
        {
                string query = useWildcard == true ? $"SELECT * FROM {tableName} " +
                        $"WHERE {conditionField}=@val1 " +
                        $"OR {conditionField} LIKE @val2 " :
                        $"SELECT * FROM {tableName} " +
                        $"WHERE {conditionField}=@val1 ";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                Cmd.Parameters.AddWithValue("@val1", conditionValue);
                if (useWildcard)
                    Cmd.Parameters.AddWithValue("@val2", conditionValue + "%");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                    $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
        }

        public static void SearchNameAndFillDataGrid(string tableName, string conditionValue,
            DataGridView dgv)
        {
            string query = $"SELECT * FROM {tableName} " +
                    $"WHERE firstName || lastName LIKE @val1 " +
                    $"OR firstName || ' ' || lastName LIKE @val1";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                Cmd.Parameters.AddWithValue("@val1", "%" + conditionValue + "%");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                    $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
        }

        public static void SearchBetweenDateAndFillDataGrid(string tableName, DataGridView dgv, string conditionField,
            string fromDate, string toDate)
        {
            string query = $"SELECT * FROM {tableName} " +
                $"WHERE DATE({conditionField}) BETWEEN '{fromDate}' AND '{toDate}';";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                    $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
        }

        public static void FilterByColumn(string tableName, DataGridView dgv, string conditionField, string conditionValue)
        {
            string query = $"SELECT * FROM {tableName} WHERE {conditionField}='{conditionValue}'";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                    $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
        }
        #endregion

        #region Tools
        public static DataTable GetSingleRecordFromDB(string tableName,
            string conditionFIeldName, string conditionValue)
        {
            DataTable dt = new DataTable();
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName} " +
                    $"WHERE {conditionFIeldName}=@val1;", Conn);
                Cmd.Parameters.AddWithValue("@val1", conditionValue);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(Cmd != null)
                    Cmd.Dispose();
                if(Conn != null)
                    Conn.Close();
            }
            return dt;
        }

        public static DataTable GetDataTableFromDB(string tableName, string recordCount = null)
        {
            DataTable dt = new DataTable();
            try
            {
                Conn.Open();
                string query = recordCount == null ?
                    $"SELECT * FROM {tableName};" :
                    $"SELECT * FROM {tableName} LIMIT {recordCount};";
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return dt;
        }

        public static string GetAutoID(string tableName, string primaryKeyField)
        {
            string autoID = string.Empty;
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName} ORDER BY {primaryKeyField} DESC;", Conn);
                object result = Cmd.ExecuteScalar();
                if (result != null)
                {
                    int increment = int.Parse(result.ToString()) + 1;
                    autoID = increment.ToString();
                }
                else
                {
                    autoID = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            return autoID;
        }

        public static bool CheckIfExist(string tableName, string fieldName, string checkDuplicateValue,
            bool showMessage = true)
        {
            bool duplicate = false;
            string query = $"SELECT {fieldName} FROM {tableName};";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                using (SQLiteDataReader reader = Cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //if (reader.GetString(reader.GetOrdinal(fieldName)) == checkDuplicateValue)
                            if (reader[fieldName].ToString() == checkDuplicateValue)
                            {
                                duplicate = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
                if (showMessage == true && duplicate == true)
                    MessageBox.Show("Record already exists!", $"Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return duplicate;
        }

        public static (string,string) GetLoanBookDueAndOverdue()
        {
            (string bookDue, string bookOverdue) book = (string.Empty, string.Empty);
            string query = "SELECT " +
                "COUNT(CASE WHEN date(dateDue)=date('now') AND loanStatusID='1' THEN dateDue END) AS bookDue, " +
                "COUNT(CASE WHEN date(dateDue)<date('now') AND loanStatusID='1' THEN dateDue END) AS bookOverdue " +
                "FROM tblBorrows;";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string bookDue = dt.Rows[0]["bookDue"].ToString();
                    string bookOverdue = dt.Rows[0]["bookOverdue"].ToString();
                    if (bookDue != "0" || bookOverdue != "0")
                    {
                        book = (bookDue, bookOverdue);
                        return book;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Cmd != null)
                    Cmd.Dispose();
                if (Conn != null)
                    Conn.Close();
            }
            book = ("0", "0");
            return book;
        }

        public static void LogTimestampUserLogin(DataTable user)
        {
            string username = user.Rows[0]["username"].ToString();
            string info = $"Logged in at {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}";
            List<string> userLog = new List<string>()
            {
                username,
                info
            };
            InsertRecord("tblUserLogs", GetTableField("tblUserLogs"), userLog, false);
        }

        public static void LogTimestampUserLogout(DataTable user)
        {
            string username = user.Rows[0]["username"].ToString();
            string info = $"Logged out at {DateTime.Now:yyyy-MM-dd hh:mm:ss}";
            List<string> userLog = new List<string>()
            {
                username,
                info
            };
            InsertRecord("tblUserLogs", GetTableField("tblUserLogs"), userLog, false);
        }
        #endregion
    }
}