using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace WesternLibraryManagementSystem.Libs
{
    public static class LibModule
    {
        private static string connectionString =
            Path.Combine("Data Source=" + Environment.CurrentDirectory, "Database/library.db");
        public static SQLiteConnection Conn = new SQLiteConnection(connectionString);
        public static SQLiteCommand Cmd;

        public static string GetDBTableFields(string tableName)
        {
            List<(string Name, string Fields)> dbTables = new List<(string Name, string Fields)>
            {
                ("tblBook", "bookID,isbn,dewey,title,author,publisher,publishYear,page,other,qty,cateID,dayAdded"),
                ("tblBookCate", "cateID,cateName"),
                ("tblBorrower", "studentID,firstName,lastName,gender,year,major,tel"),
                ("tblLoanStatus", "loanStatusID,loanStatusName"),
                ("tblBorrow", "borrowID,bookID,studentID,userID,dateLoan,dateDue,dateReturned,overdueFine,loanStatusID"),
                ("tblUser", "userID,firstName,lastName,gender,dob,addr,tel,email"),
                ("tblRole", "roleID,roleName"),
                ("tblUserROle", "userRoleID,userID,roleID")
            };
            int index = dbTables.IndexOf(dbTables.Find(x => x.Name == tableName));
            return dbTables[index].Fields;
        }

        public static void InsertRecord(string tableName, string fieldNames, List<string> values)
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
                    MessageBox.Show("Record Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        public static void UpdateRecord(string tableName, List<string> fieldNames,
            string conditionFIeldName, string conditionValue, List<string> values)
        {
            // remove ID field from fieldNames list
            fieldNames.RemoveAt(0);
            StringBuilder setFieldsValue = new StringBuilder();
            int index = 1;
            foreach (string field in fieldNames)
            {
                if (field == fieldNames.Last())
                {
                    setFieldsValue.Append($"{field}=@val{index++}");
                }
                else
                {
                    setFieldsValue.Append($"{field}=@val{index++},");
                }
            }
            string query = $"UPDATE {tableName} SET {setFieldsValue} WHERE {conditionFIeldName}={conditionValue};";
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
                    MessageBox.Show("Record Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
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
        }

        public static void DeleteRecord(string tableName, string conditionFieldName, string conditionValue)
        {
            string query = $"DELETE FROM {tableName} WHERE {conditionFieldName}={conditionValue};";
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand(query, Conn);
                if (Cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Record Has Been Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        public static void FillDataGridView(string tableName, DataGridView dataGridView)
        {
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT * FROM {tableName}", Conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
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

        public static string GetAutoID(string tableName, string primaryKeyField)
        {
            string autoID = String.Empty;
            try
            {
                Conn.Open();
                Cmd = new SQLiteCommand($"SELECT MAX({primaryKeyField})+1 FROM {tableName};", Conn);
                object result = Cmd.ExecuteScalar();
                if (result != null)
                {
                    autoID = result.ToString();
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
    }
}
