﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using Microsoft.Reporting.WinForms;
using LibraryDBMS.Forms;

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
                ("tblStudent", "studentID,firstName,lastName,gender,year,major,tel,dateAdded"),
                ("tblLoanStatus", "loanStatusID,loanStatusName"),
                ("tblBorrow", "borrowID,bookID,studentID,userID,dateLoan,dateDue,dateReturned,overdueFine,loanStatusID"),
                ("tblUser", "userID,username,password,isActive,firstName,lastName,gender,dob,addr,tel,email,dateAdded"),
                ("tblRole", "roleID,roleName"),
                ("tblUserRole", "userID,roleID")
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
                        MessageBox.Show("Record Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (showMessage)
                        Utils.NotificationToast.Show("success", "Record Updated Successfully!");
                    return true;
                }
                else
                {
                    if(showMessage)
                        Utils.NotificationToast.Show("fail", "Record Cannot Update!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
            return false;
        }

        public static bool DeleteRecord(string tableName, string conditionFieldName, string conditionValue,
            string record)
        {
            string query = $"DELETE FROM {tableName} WHERE {conditionFieldName}='{conditionValue}';";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                Form dialogDeleteRecord = new DialogDeleteRecord(record);
                if (dialogDeleteRecord.ShowDialog() == DialogResult.Yes)
                {
                    if (Cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Record Has Been Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
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
                Cmd.Dispose();
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
                Cmd.Dispose();
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
                    $"SELECT * FROM {tableName};" : 
                    $"SELECT * FROM {tableName} ORDER BY {fieldToSort} DESC;";
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dt;
                dgv.DataBindingComplete += Dgv_DataBindingComplete;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type of Error :" + ex.GetType() + "\nMessage : " + ex.Message.ToString() +
                "\nStack Trace : \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
        }

        private static void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.ClearSelection();
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

        public static void FillReportViewer(string tableName, ReportViewer rpv, string rpPath,
                    string rpDataSet)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName};", Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                System.Data.DataSet ds = new System.Data.DataSet();
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

        #endregion

        #region Search
        public static void SearchAndFillDataGrid(string tableName, string conditionField, string conditionValue,
            DataGridView dgv)
        {
                string query = $"SELECT * FROM {tableName} " +
                        $"WHERE {conditionField}='{conditionValue}' " +
                        $"OR {conditionField} LIKE '%{conditionValue}%' ";
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

        public static void SearchNameAndFillDataGrid(string tableName, string conditionValue,
            DataGridView dgv)
        {
            string query = $"SELECT * FROM {tableName} " +
                    $"WHERE firstName='{conditionValue}' " +
                    $"OR lastName LIKE '%{conditionValue}%' " +
                    $"OR firstName || lastName LIKE '%{conditionValue}%'" +
                    $"OR firstName || ' ' || lastName LIKE '%{conditionValue}%'";
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
                Cmd.Dispose();
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
                Cmd.Dispose();
                Conn.Close();
            }
        }

        public static void SearchAndDisplayLabel(string tableName, string fieldNames, string conditionField,
            string conditionValue, Label disLabel)
        {
            try
            {
                disLabel.Text = string.Empty;
                List<string> fields = new List<string>();
                fields.AddRange(fieldNames.Split(','));
                StringBuilder selectFields = new StringBuilder();
                foreach (string field in fields)
                {
                    if (field == fields.Last())
                        selectFields.Append($"{field}");
                    else selectFields.Append($"{field},");
                }
                Conn.Open();
                string query = $"Select {selectFields} From {tableName} Where {conditionField}='{conditionValue}';";
                Cmd = new SQLiteCommand(query, Conn);
                using (SQLiteDataReader reader = Cmd.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            if(fields.Count > 1)
                                disLabel.Text = reader[fields[0]].ToString()+" "+ reader[fields[1]].ToString();
                            else disLabel.Text = reader[fields[0]].ToString();
                        }
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
        #endregion

        #region Tools
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
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
            return autoID;
        }

        public static bool CheckIfExist(string tableName, string fieldName, string checkDuplicateValue,
                string fieldMessage, bool showMessage = true)
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
                Cmd.Dispose();
                Conn.Close();
                if (showMessage == true && duplicate == true)
                    MessageBox.Show(fieldMessage, $"Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return duplicate;
        }

         public static bool IsValidLoginCredential(string username, string password, out (string,string) user)
        {
            string query = $"SELECT u.username,r.roleName " +
                $"FROM tblUser u, tblUserRole ur, tblRole r " +
                $"WHERE u.username = '{username}' AND u.password = '{password}' " +
                $"AND u.isActive = 'Yes' AND u.userID = ur.UserID AND r.roleID = ur.roleID;";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    user = (dt.Rows[0]["username"].ToString(), dt.Rows[0]["roleName"].ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Type of Error :{ex.GetType()}\nMessage : {ex.Message}" +
                    $"\nStack Trace : \n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cmd.Dispose();
                Conn.Close();
            }
            user = (string.Empty, string.Empty);
            return false;
        }

        public static (string,string) HasLoanBookDueAndOverdue()
        {
            (string bookDue, string bookOverdue) book = (string.Empty, string.Empty);
            string query = $"SELECT " +
                $"COUNT(CASE WHEN date(dateDue)=date('now') AND loanStatusID='1' THEN dateDue END) AS bookDue, " +
                $"COUNT(CASE WHEN date(dateDue)<date('now') AND loanStatusID='1' THEN dateDue END) AS bookOverdue " +
                $"FROM tblBorrow;";
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
                Cmd.Dispose();
                Conn.Close();
            }
            book = ("0", "0");
            return book;
        }

        #endregion
    }
}