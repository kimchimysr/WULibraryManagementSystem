using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Drawing;

namespace LibraryDBMS.Libs
{
    public static class LibModule
    {
        private static string connectionString = Properties.Settings.Default.LibDbConnectionString;
        public static SQLiteConnection Conn = new SQLiteConnection(connectionString);
        public static SQLiteCommand Cmd;

        public static string GetTableField(string tableName)
        {
            List<(string Name, string Fields)> dbTables = new List<(string Name, string Fields)>
            {
                ("tblBook", "bookID,isbn,dewey,title,author,publisher,publishYear,pages,other,qty,cateID,dateAdded"),
                ("tblBookCate", "cateID,cateName"),
                ("tblBorrower", "studentID,firstName,lastName,gender,year,major,tel,dateAdded"),
                ("tblLoanStatus", "loanStatusID,loanStatusName"),
                ("tblBorrow", "borrowID,bookID,studentID,userID,dateLoan,dateDue,dateReturned,overdueFine,loanStatusID"),
                ("tblUser", "userID,username,password,isActive,firstName,lastName,gender,dob,addr,tel,email,dateAdded"),
                ("tblRole", "roleID,roleName"),
                ("tblUserRole", "userID,roleID")
            };
            int index = dbTables.IndexOf(dbTables.Find(x => x.Name == tableName));
            return dbTables[index].Fields;
        }

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
                        MessageBox.Show("Record Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
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
            string query = $"UPDATE {tableName} SET {setFieldsValue} WHERE {conditionFIeldName}='{conditionValue}';";
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

                if (Cmd.ExecuteNonQuery() == 1)
                {
                    if(showMessage)
                        MessageBox.Show("Record Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    if(showMessage)
                        MessageBox.Show("No Record Has Been Updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
            return false;
        }

        public static void DeleteRecord(string tableName, string conditionFieldName, string conditionValue,
            string record = null)
        {
            string query = $"DELETE FROM {tableName} WHERE {conditionFieldName}='{conditionValue}';";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                DialogResult result = MessageBox.Show("Do you want to delete this record?" +
                    $"\n{record}", "Delete Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (Cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Record Has Been Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
        }

        public static bool IsDuplicated(string tableName, string fieldName, string checkDuplicateValue,
            string fieldMessage = "record")
        {
            bool duplicate = false;
            string query = $"SELECT {fieldName} FROM {tableName};";
            Cmd = new SQLiteCommand(query, Conn);
            try
            {
                Conn.Open();
                using(SQLiteDataReader reader = Cmd.ExecuteReader(CommandBehavior.SequentialAccess))
                {
                    if (reader.HasRows)
                    while (reader.Read())
                        if (reader.GetString(reader.GetOrdinal(fieldName)).Equals(checkDuplicateValue))
                            duplicate = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Check Duplicate Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
                if (duplicate == true)
                    MessageBox.Show($"{fieldMessage} Already Exist!", $"Duplicate {fieldMessage}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return duplicate;
        }

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
                Cmd.Dispose();
                Conn.Close();
            }
            return false;
        }

        public static string ExecuteScalarQuery(string query)
        {
            string str = string.Empty;
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                str = Cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
            return str;
        }

        public static void FillDataGrid(string tableName, DataGridView dgv)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName};", Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
        }

        public static void FillComboBox(string tableName, ComboBox comboBox, string displayMember, string valueMember)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName}", Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
                comboBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
        }

        public static DataTable GetSingleRecordDB(string tableName,
            string conditionFIeldName, string conditionValue)
        {
            DataTable dt = new DataTable();
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName} " +
                    $"WHERE {conditionFIeldName}='{conditionValue}';", Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
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
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
            return autoID;
        }

        public static void SearchAndShow(string tableName, string conditionField, string conditionValue,
            DataGridView dgv, bool isNameSearch = false)
        {
            string query = string.Empty;
            if (!isNameSearch)
            {
                query = $"SELECT * FROM {tableName} " +
                $"WHERE {conditionField}='{conditionValue}' " +
                $"OR {conditionField} LIKE '%{conditionValue}%'";
            }
            else
            {
                List<string> condFields = new List<string>();
                condFields.AddRange(conditionField.Split(','));
                query = $"SELECT * FROM {tableName} " +
                $"WHERE {condFields[0]} LIKE '%{conditionValue}%' " +
                $"OR {condFields[1]} LIKE '%{conditionValue}%' " +
                $"OR {condFields[0]} || {condFields[1]} LIKE '%{conditionValue}%'" +
                $"OR {condFields[0]} || ' ' || {condFields[1]} LIKE '%{conditionValue}%'" +
                $"OR {condFields[1]} || {condFields[0]} LIKE '%{conditionValue}%'" +
                $"OR {condFields[1]} || ' ' || {condFields[0]} LIKE '%{conditionValue}%'";
            }
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
                Cmd.Dispose();
                Conn.Close();
            }
        }

        public static void SearchAndShow(string tableName, DataGridView dgv, string conditionField,
            string fromDate, string toDate)
        {
            try
            {
                Conn.Open();
                string query = $"SELECT * FROM {tableName} " +
                    $"WHERE DATE({conditionField}) BETWEEN '{fromDate}' AND '{toDate}';";
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
                Cmd.Dispose();
                Conn.Close();
            }
        }

        public static void SearchAndShow(string tableName, string fieldName, string conditionField,
            string conditionValue, Label disLabel)
        {
            disLabel.Text = string.Empty;
            try
            {
                Conn.Open();
                string query = $"Select {fieldName} From {tableName} Where {conditionField}='{conditionValue}';";
                Cmd = new SQLiteCommand(query, Conn);
                using (SQLiteDataReader reader = Cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (reader.HasRows)
                        while (reader.Read())
                            disLabel.Text = reader[fieldName].ToString();
                    else disLabel.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}\n" +
                    $"Stack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
        }

        public static void FillReportViewer(string tableName, ReportViewer rpv, string rpPath,
            string rpDataSet)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName};", Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                rpv.LocalReport.ReportEmbeddedResource = rpPath;
                ReportDataSource rds = new ReportDataSource(rpDataSet, ds.Tables[0]);
                rpv.LocalReport.DataSources.Clear();
                rpv.LocalReport.DataSources.Add(rds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
        }
    }
}