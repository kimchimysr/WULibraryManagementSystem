using ClosedXML.Excel;
using IWshRuntimeLibrary;
using Microsoft.Reporting.WinForms;
using SharpCompress.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using File = System.IO.File;

namespace LibraryDBMS.Libs
{
    public static partial class Utils
    {
        // C:\Users\[curentUser]\AppData\Roaming\WULibraryManagementSystem\Database\library.db
        public static string databasePath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                @"WULibraryManagementSystem\Database\library.db");
        #region Security
        /// <summary>
        /// Convert normal string into encrpyted string.
        /// </summary>
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            // convert the input string to a byte array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // create a new stringBuilder to collect the bytes
            // and create a string
            StringBuilder sb = new StringBuilder();

            // loop through each byte of the hashed data
            // and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Get deafult encrypted string.
        /// </summary>
        public static string DefaultHashPassword()
        {
            return HashPassword("Password@123");
        }
        #endregion

        #region Controls Related
        public static bool DoClearControl(Form frm, bool textboxCond, bool labelCond, bool comboboxCond,
                                    bool numCond, bool dtpCond, params string[] controlname)
        {
            foreach (Control ctrl in frm.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
                if (ctrl is TextBox tb)
                {
                    if(ctrl.TabIndex != 0)
                        if (textboxCond)
                        {
                            foreach (string txtname in controlname)
                                if (tb.Name.Equals(txtname))
                                    tb.Text = string.Empty;
                        }
                        else tb.Text = string.Empty;
                }
                else if (ctrl is Label lbl)
                {
                    if (labelCond)
                    {
                        foreach (string label in controlname)
                            if (lbl.Name.Equals(label))
                                lbl.Text = string.Empty;
                    }
                    else lbl.Text = string.Empty;
                }
                else if (ctrl is ComboBox cb)
                {
                    if (comboboxCond)
                    {
                        foreach (string cboname in controlname)
                            if (cb.Name.Equals(cboname))
                                cb.SelectedIndex = -1;
                    }
                    else cb.SelectedIndex = -1;
                }
                else if (ctrl is NumericUpDown nud)
                {
                    if (numCond)
                    {
                        foreach (string numname in controlname)
                            if (nud.Name.Equals(numname))
                                nud.Value = 0;
                    }
                    else nud.Value = 0;
                }
                else if (ctrl is DateTimePicker dtp)
                {
                    if (dtpCond)
                    {
                        foreach (string dtpname in controlname)
                            if (dtp.Name.Equals(dtpname))
                                dtp.Value = DateTime.Today;
                    }
                    else dtp.Value = DateTime.Today;
                }
            return true;
        }

        /// <summary>
        /// Enable double buffer on Control.
        /// </summary>
        public static void EnableControlDoubleBuffer(Control control)
        {
            control.GetType().InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               control,
               new object[] { true });
        }

        /// <summary>
        /// Fixes DataGridView not resize proerly in FlowLayoutPanel.
        /// </summary>
        // https://www.anycodings.com/1questions/1647481/how-can-i-get-a-stackpanel-like-layout-in-winforms
        public static void AutoSizeChildrenInFlowLayoutPanel(FlowLayoutPanel panel, Control fillControl = null)
        {
            // wrapping does not make sense with auto-resizing
            panel.WrapContents = false;

            var isVertical = panel.FlowDirection == FlowDirection.TopDown || panel.FlowDirection == FlowDirection.BottomUp;
            int dim(Control c, bool flowDir = false) => isVertical ^ flowDir ? c.Width : c.Height;
            void setDim(Control c, int size, bool flowDir = false)
            {
                if (isVertical ^ flowDir)
                    c.Width = size;
                else
                    c.Height = size;
            }
            var children = panel.Controls.Cast<Control>().ToList();
            var relSizes = children.ToDictionary(c => c, c => dim(c) - dim(panel));

            // update relative size when controls are resized
            var isPanelResizing = false;
            foreach (var child in children)
            {
                child.Resize += (s, e) => {
                    if (!isPanelResizing)
                        relSizes[child] = dim(child) - dim(panel);
                };
            }

            // resize children when panel is resized
            panel.Resize += (s, e) => {
                isPanelResizing = true;
                foreach (var child in children)
                    setDim(child, dim(panel) + relSizes[child]);
                isPanelResizing = false;
            };

            if (fillControl != null)
            {
                // add the size difference between the panel and its children to the fillControl
                void sizeFill()
                {
                    var childrenSize = children.Sum(c => dim(c, true) + (isVertical ? c.Margin.Vertical : c.Margin.Horizontal));
                    var diff = dim(panel, true) - childrenSize - (isVertical ? panel.Padding.Vertical : panel.Padding.Horizontal);
                    if (diff != 0)
                        setDim(fillControl, dim(fillControl, true) + diff, true);
                }
                panel.Resize += (s, e) => sizeFill();
                foreach (var child in children)
                    child.Resize += (s, e) => sizeFill();
            }
        }
        
        /// <summary>
        /// Modified Search Button by getting amount of character of the textbox with Textboxtextchanged 
        /// Would Recomment use if when we set searchButton.Enabled = false when initializing form
        /// When call this method, make sure you use sender for getting object from Textchanged method
        /// </summary>

        public static void searchButtonTextChanged(object sender, Button searchButton)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length > 0)
            {
                searchButton.Enabled = true;
            }
            else
            {
                searchButton.Enabled = false;
            }
        }

        /// <summary>
        /// Make Columns auto resizes in DataGridView.
        /// </summary>
        public static void AutoSizeDGVColumnsBasedOnContentsAndDGVWidth(params DataGridView[] dgvs)
        {
            foreach (var dgv in dgvs)
            {
                dgv.DataBindingComplete += Dgv_DataBindingComplete;
                dgv.Resize += Dgv_Resize;

                void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
                {
                    AutoSizeColumns();
                }

                void Dgv_Resize(object sender, EventArgs e)
                {
                    AutoSizeColumns();
                }

                void AutoSizeColumns()
                {
                    dgv.SuspendLayout();
                    // set all columns auto size to fit contents
                    foreach (DataGridViewColumn column in dgv.Columns)
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int columnsWidth = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dgv.RowHeadersWidth;

                    // if all columns combined width less than dgv width, then set autosizemode to fill for every columns
                    if (columnsWidth < dgv.Width)
                    {
                        foreach (DataGridViewColumn column in dgv.Columns)
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        // make sure that every columns show all of contents
                        for (int i = 0; dgv.Columns.Count > i; i++)
                        {
                            dgv.AutoResizeColumn(i);
                        }
                    }
                    dgv.ResumeLayout();
                }
            }
        }

        /// <summary>
        /// Show ToolTip when hovering on Control.
        /// </summary>
        public static void ToolTipOnControlMouseHover(string text, Control ctrl)
        {
            ToolTip tip = new ToolTip()
            {
                ShowAlways = true,
                InitialDelay = 10
            };
            ctrl.MouseHover += Ctrl_MouseHover;
            void Ctrl_MouseHover(object sender, EventArgs e)
            {
                tip.Show(text, ctrl);
            }
        }
        /// <summary>
        /// Set The Datepicker a year before the present date when the form was initializing By calling the FromDatepicker and ToDatePicker
        /// </summary>
        public static void SetFromDateAYearFromNow(DateTimePicker dtpFromDate, DateTimePicker dtpToDate)
        {
            dtpToDate.Value = DateTime.Now;
            dtpFromDate.Value = dtpToDate.Value.AddYears(-1);
        }

        /// <summary>
        /// Enable AutoComplete using DataTable on Control.
        /// </summary>
        public static void EnableControlAutoComplete(Control ctl, DataTable dt)
        {
            if (ctl is ComboBox cb)
            {
                var collection = new AutoCompleteStringCollection();
                cb.Items.Clear();
                if(dt != null)
                    if(dt.Rows.Count > 0)
                        foreach (DataRow row in dt.Rows)
                        {
                            string value = row[0].ToString();
                            collection.Add(value);
                            cb.Items.Add(value);
                        }
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteCustomSource = collection;
                cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else if (ctl is TextBox tb)
            {
                var collection = new AutoCompleteStringCollection();
                if (dt != null)
                    if (dt.Rows.Count > 0)
                        foreach (DataRow row in dt.Rows)
                            collection.Add(row[0].ToString());
                tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tb.AutoCompleteCustomSource = collection;
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        /// <summary>
        /// Deselect row after filling DataSource in DataGridView.
        /// </summary>
        public static void ClearSelectionAfterDataBindingDataGridView(params DataGridView[] dgvs)
        {
            foreach (var dgv in dgvs)
            {
                dgv.DataBindingComplete += Dgv_DataBindingComplete;
                void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
                {
                    dgv.ClearSelection();
                }
            }
        }

        public static void SetControlVisibility(bool visibility,params Control[] ctrl)
        {
            foreach (Control ct in ctrl)
            {
                ct.Visible = visibility;
            }
        }

        #endregion

        #region Tool
        /// <summary>
        /// Fill ComboBox with provided string.
        /// </summary>
        public static void FillComboBox(ComboBox cb, bool setSelectedIndex, params string[] items)
        {
            if(items.Length > 0)
                foreach(string str in items)
                    cb.Items.Add(str);
            if(setSelectedIndex)
                cb.SelectedIndex = 0;
        }

        /// <summary>
        /// Get row data from selected row in DataGridView.
        /// </summary>
        public static string GetDataGridSelectedRowData(DataGridView dgv, int rowIndex)
        {
            StringBuilder row = new StringBuilder();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                row.AppendLine($"{dgv.Columns[i].HeaderText}: {dgv.Rows[rowIndex].Cells[i].Value}");
            }
            return row.ToString();
        }

        /// <summary>
        /// Auto convert normal number string into (K,M) formatted.
        /// E.g. 12345 => 123.K, 1234567 => 1.23M
        /// </summary>
        // string extension method
        public static string ToKMString(this string str)
        {
            // 123456 => 123.4K, 1234567 => 1.23M
            int amount = int.Parse(str);
            return amount >= 1_000 && amount < 1_000_000 ? amount.ToString("0,.#K", CultureInfo.InvariantCulture) :
                amount >= 1_000_000 ? amount.ToString("0,,.##M", CultureInfo.InvariantCulture) : str;
        }

        /// <summary>
        /// Show print preview using DataGridView's DataSource.
        /// </summary>
        // Printing of DataGridView
        // https://www.codeproject.com/Articles/28046/Printing-of-DataGridView
        public static void PrintPreviewDataGridView(string title, DataGridView dgvo)
        {
            // clone main dgv to new dgv
            DataGridView dgv = new DataGridView();
            if (dgv.Columns.Count == 0)
            {
                foreach (DataGridViewColumn col in dgvo.Columns)
                    dgv.Columns.Add(col.Clone() as DataGridViewColumn);
            }
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < dgvo.Rows.Count; i++)
            {
                dr = (DataGridViewRow)dgvo.Rows[i].Clone();
                int index = 0;
                foreach (DataGridViewCell cell in dgvo.Rows[i].Cells)
                {
                    dr.Cells[index].Value = cell.Value;
                    index++;
                }
                dgv.Rows.Add(dr);
            }
            dgv.AllowUserToAddRows = false;
            dgv.Font = new Font("Calibri",10, FontStyle.Regular);
            // Wrap contents
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (DataGridViewColumn col in dgv.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            StringFormat strFormat = new StringFormat(); ; //Used to format the grid rows.
            ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
            ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
            int iCellHeight = 0; //Used to get/set the datagridview cell height
            int iTotalWidth = 0; //
            int iRow = 0;//Used as counter
            bool bFirstPage = false; //Used to check whether we are printing first page
            bool bNewPage = false;// Used to check whether we are printing a new page
            int iHeaderHeight = 0; //Used for the header height

            PrintDocument pd = new PrintDocument();
            pd.BeginPrint += Pd_BeginPrint;
            void Pd_BeginPrint(object sender, PrintEventArgs e)
            {
                try
                {
                    strFormat.Alignment = StringAlignment.Near;
                    strFormat.LineAlignment = StringAlignment.Center;
                    strFormat.Trimming = StringTrimming.EllipsisCharacter;

                    arrColumnLefts.Clear();
                    arrColumnWidths.Clear();
                    iCellHeight = 0;
                    iRow = 0;
                    bFirstPage = true;
                    bNewPage = true;

                    // Calculating Total Widths
                    iTotalWidth = 0;
                    foreach (DataGridViewColumn dgvGridCol in dgv.Columns)
                    {
                        iTotalWidth += dgvGridCol.Width;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            pd.PrintPage += Pd_PrintPage;
            void Pd_PrintPage(object sender, PrintPageEventArgs e)
            {
                try
                {
                    //Set the left margin
                    int iLeftMargin = 25;//e.MarginBounds.Left;
                    //Set the top margin
                    int iTopMargin = 50;//e.MarginBounds.Top;
                    //Whether more pages have to print or not
                    bool bMorePagesToPrint = false;
                    int iTmpWidth = 0;
                    //For the first page to print set the cell width and header height
                    if (bFirstPage)
                    {
                        foreach (DataGridViewColumn GridCol in dgv.Columns)
                        {
                            iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                           (double)iTotalWidth * (double)iTotalWidth *
                                           (((double)e.MarginBounds.Width + 150) / (double)iTotalWidth))));

                            iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                        GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                            // Save width and height of headres
                            arrColumnLefts.Add(iLeftMargin);
                            arrColumnWidths.Add(iTmpWidth);
                            iLeftMargin += iTmpWidth;
                        }
                    }
                    //Loop till all the grid rows not get printed
                    while (iRow <= dgv.Rows.Count - 1)
                    {
                        DataGridViewRow GridRow = dgv.Rows[iRow];
                        //Set the cell height
                        iCellHeight = GridRow.Height + 20;
                        int iCount = 0;
                        //Check whether the current page settings allo more rows to print
                        if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                        {
                            bNewPage = true;
                            bFirstPage = false;
                            bMorePagesToPrint = true;
                            break;
                        }
                        else
                        {
                            if (bNewPage)
                            {
                                //Draw Header
                                e.Graphics.DrawString(title, new Font(dgv.Font, FontStyle.Bold),
                                        Brushes.Black, e.MarginBounds.Left, iTopMargin -
                                        e.Graphics.MeasureString(title, new Font(dgv.Font,
                                        FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                                string strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                                //Draw Date
                                e.Graphics.DrawString(strDate, new Font(dgv.Font, FontStyle.Bold),
                                        Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                        e.Graphics.MeasureString(strDate, new Font(dgv.Font,
                                        FontStyle.Bold), e.MarginBounds.Width).Width), iTopMargin -
                                        e.Graphics.MeasureString(title, new Font(new Font(dgv.Font,
                                        FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                                //Draw Columns                 
                                iTopMargin = 50;//e.MarginBounds.Top;
                                foreach (DataGridViewColumn GridCol in dgv.Columns)
                                {
                                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));

                                    e.Graphics.DrawRectangle(Pens.Black,
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));

                                    e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                        new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                    iCount++;
                                }
                                bNewPage = false;
                                iTopMargin += iHeaderHeight;
                            }
                            iCount = 0;
                            //Draw Columns Contents                
                            foreach (DataGridViewCell Cel in GridRow.Cells)
                            {
                                if (Cel.Value != null)
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }
                                //Drawing Cells Borders 
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                        iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                                iCount++;
                            }
                        }
                        iRow++;
                        iTopMargin += iCellHeight;
                    }
                    //Draw Footer
                    e.Graphics.DrawString("Western University", new Font(dgv.Font, FontStyle.Regular),
                            Brushes.Black, e.MarginBounds.Left, iTopMargin -
                            e.Graphics.MeasureString("Western University", new Font(dgv.Font,
                            FontStyle.Bold), e.MarginBounds.Width).Height + 40);

                    //If more lines exist, print another page.
                    if (bMorePagesToPrint)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;

                }
                catch (Exception exc)
                {
                    BlurEffect.UnBlur();
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = pd;
            ((Form)objPPdialog).StartPosition = FormStartPosition.CenterParent;
            //((Form)objPPdialog).WindowState = FormWindowState.Maximized;
            objPPdialog.ShowDialog();
        }

        /// <summary>
        /// Backup Database by copying.
        /// </summary>
        // Backup&Restore SQLite Database in C#
        // https://www.codeproject.com/Questions/1213783/Restore-sqlite-database-in-Csharp
        public static bool BackupDatabase()
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        string fileName = $"librarydb_{DateTime.Now.ToString("yyyy_MM_dd")}.bak";
                        string dbPath = databasePath;
                        string backupDestPath = Path.GetFullPath(fbd.SelectedPath) + $@"\{fileName}";


                        // https://www.codeproject.com/Questions/5280874/How-do-I-automatically-put-the-following-number-be
                        if (File.Exists(backupDestPath))
                        {
                            string folder = Path.GetDirectoryName(backupDestPath);
                            string fileWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                            string extension = Path.GetExtension(fileName);

                            int filecounter = 1;
                            while (File.Exists(backupDestPath))
                            {
                                backupDestPath = Path.Combine(folder, $"{fileWithoutExtension}({filecounter}){extension}");
                                filecounter++;
                            }
                        }

                        File.Copy(dbPath, backupDestPath);

                        Cursor.Current = Cursors.Default;
                        if (File.Exists(backupDestPath))
                        {
                            MessageBox.Show("Successfully backup database!", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Cannot backup database!", "Backup Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Cannot backup to this location! Please try another location!", "Permission Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// Restore Database by copying.
        /// </summary>
        public static bool RestoreDatabase()
        {
            MessageBox.Show("Restoring database will overwrite current database, make sure to do backup first!",
                "Restore Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database Backup Files (*.bak)|*.bak";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                // current database path
                string dbPath = databasePath;
                string backupPath = Path.GetFullPath(ofd.FileName);

                string currentDbBackupPath = Path.GetDirectoryName(dbPath) + @"\library.bak";

                // check if current db exists
                if (File.Exists(dbPath))
                {
                    // delete backup of current db if exists
                    if (File.Exists(currentDbBackupPath))
                        File.Delete(currentDbBackupPath);

                    // backup current db by rename it to .bak
                    File.Move(dbPath, currentDbBackupPath);
                }

                // copy backup db to current db location
                File.Copy(backupPath, dbPath);

                Cursor.Current = Cursors.Default;
                if (File.Exists(dbPath))
                {
                    MessageBox.Show("Successfully restored database! Application will be restarted!", "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Cannot restore database!", "Restore Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Import selected old backup Database.
        /// </summary>
        public static bool ImportOldDatabase()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database Backup Files (*.bak)|*.bak";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                // current database path
                string dbPath = databasePath;
                string backupPath = Path.GetFullPath(ofd.FileName);

                // C:\Users\[curentUser]\AppData\Roaming
                string userAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                // C:\Users\[curentUser]\AppData\Roaming\WULibraryManagementSystem\Database
                string databaseFolder = Path.Combine(userAppDataPath, @"WULibraryManagementSystem\Database\");

                // check if the destination folder is already exist if not, create directory
                if (!Directory.Exists(databaseFolder))
                    Directory.CreateDirectory(databaseFolder);

                // copy backup db to current db location
                File.Copy(backupPath, dbPath);

                Cursor.Current = Cursors.Default;
                if (File.Exists(dbPath))
                {
                    MessageBox.Show("Successfully restored database! Application will be restarted!", "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Cannot restore database!", "Restore Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Export table from Database into Excel file.
        /// </summary>
        // How to Export Data from Database To Excel File in c#
        // https://www.youtube.com/watch?v=ySkUEhNu4t4
        public static void ExportDatabaseTableToExcel(string table)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            string fileName = table == "All" ? "database" : table;
            sfd.FileName = $"{fileName}.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                XLWorkbook workbook = new XLWorkbook();
                if (table == "All")
                {
                    dt = LibModule.GetDataTableFromDBWithTableName("tblBooks");
                    workbook.Worksheets.Add(dt, "tblBooks");
                    dt = LibModule.GetDataTableFromDBWithTableName("tblBookCategories");
                    workbook.Worksheets.Add(dt, "tblBookCategories");
                    dt = LibModule.GetDataTableFromDBWithTableName("tblBorrows");
                    workbook.Worksheets.Add(dt, "tblBorrows");
                    dt = LibModule.GetDataTableFromDBWithTableName("tblLoanStatus");
                    workbook.Worksheets.Add(dt, "tblLoanStatus");
                    dt = LibModule.GetDataTableFromDBWithTableName("tblLogs");
                    workbook.Worksheets.Add(dt, "tblLogs");
                    dt = LibModule.GetDataTableFromDBWithTableName("tblUser");
                    workbook.Worksheets.Add(dt, "tblUser");
                    dt = LibModule.GetDataTableFromDBWithTableName("tblStudents");
                    workbook.Worksheets.Add(dt, "tblStudents");
                    dt = LibModule.GetDataTableFromDBWithTableName("viewOverview");
                    workbook.Worksheets.Add(dt, "viewOverview");
                    workbook.SaveAs(sfd.FileName);
                }
                else
                {
                    dt = LibModule.GetDataTableFromDBWithTableName(table);
                    if (table == "tblBooks")
                    {
                        dt = LibModule.GetDataTableFromDBWithQuery("SELECT bookID,isbn,dewey,title,author,publisher,publishYear,pages,other,qty,cateID,dateAdded FROM tblBooks;");//LibModule.GetDataTableFromDBWithTableName("tblBooks");
                    }
                    else if (table == "tblStudents")
                    {
                        dt = LibModule.GetDataTableFromDBWithQuery("SELECT studentID,firstName,lastName,gender,year,major,tel,dateAdded,isWUStudent,otherStudent FROM tblStudents;");//LibModule.GetDataTableFromDBWithTableName("tblBooks");
                    }

                    workbook.Worksheets.Add(dt, table);
                    workbook.SaveAs(sfd.FileName);
                }
                Cursor.Current = Cursors.Default;
                if (File.Exists(Path.GetFullPath(sfd.FileName)))
                {
                    //MessageBox.Show("Successfully exported table!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Do you want to open the exported file?", "Open File", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
                else MessageBox.Show("Cannot export table!", "Export Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Import old Database in Excel into current Database.
        /// </summary>
        // How to read(import) excel files
        // https://www.aspsnippets.com/Articles/Read-Import-Excel-file-without-OLEDB-Microsoft-Office-or-Interop-Library-in-C-and-VBNet.aspx
        public static void ImportExcelDataIntoDatabase()
        {
            MessageBox.Show("Import only work with books data in Excel!",
                        "Import Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel (*.xlsx)|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int rowCount = 0;
                Cursor.Current = Cursors.WaitCursor;
                string importFilePath = Path.GetFullPath(ofd.FileName);

                if (File.Exists(importFilePath))
                {
                    // tbBook columns
                    List<string> colName = new List<string>
                        {
                            "bookID", "isbn", "dewey", "title", "author", "publisher", "publishYear", "pages", "other",
                            "qty", "cateID", "dateAdded"
                        };

                    //Create a new DataTable.
                    DataTable dt = new DataTable();
                    using (XLWorkbook workBook = new XLWorkbook(importFilePath))
                    {
                        //Read the first Sheet from Excel file.
                        IXLWorksheet workSheet = workBook.Worksheet(1);

                        //Loop through the Worksheet rows.
                        bool firstRow = true;
                        foreach (IXLRow row in workSheet.Rows())
                        {
                            if (row.IsEmpty())
                                break;
                            //Use the first row to add columns to DataTable.
                            if (firstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                {
                                    dt.Columns.Add(cell.Value.ToString());
                                }

                                // Get columns name in excel
                                List<string> dtColName = new List<string>();
                                foreach (DataColumn col in dt.Columns)
                                {
                                    dtColName.Add(col.ColumnName);
                                }

                                // Compare excel columns and tbkBook columns
                                if (!dtColName.SequenceEqual(colName))
                                {
                                    MessageBox.Show("Excel file has wrong format! Cannot import data! \nPlease make sure excel has the following columns in order: bookID,isbn,dewey,title,author,publisher,publishYear,pages,other,qty,cateID,dateAdded", "Import Cancelled",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                firstRow = false;
                            }
                            else
                            {
                                //Add rows to DataTable.
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells(1, dt.Columns.Count))
                                {
                                    //// L is date cell
                                    //if (cell.Address.ColumnLetter == "L")
                                    //{
                                    //    string strDate = cell.Value.ToString();
                                    //    DateTime date = DateTime.ParseExact(strDate, "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture);
                                    //    dt.Rows[dt.Rows.Count - 1][i] = date.ToString("yyyy-MM-dd");
                                    //}
                                    //else dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                    dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                    i++;
                                }
                                rowCount++;
                            }
                        }
                    }

                    // Insert rows into database
                    if (LibModule.BulkInsertBookRecord(dt))
                    {
                        MessageBox.Show($"Import Finished! {rowCount} records has been added into database!", "Import Completed",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot import data into database!", "Import Incomplete",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        public static void ImportStudentExcelDataIntoDatabase()
        {
            MessageBox.Show("Import only work with students data in Excel!",
                        "Import Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel (*.xlsx)|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int rowCount = 0;
                Cursor.Current = Cursors.WaitCursor;
                string importFilePath = Path.GetFullPath(ofd.FileName);

                if (File.Exists(importFilePath))
                {
                    // tbBook columns
                    List<string> colName = new List<string>
                        {
                            "studentID", "firstName", "lastName", "gender", "year", "major", "tel", "dateAdded",
                            "isWUStudent", "otherStudent"
,                        };

                    //Create a new DataTable.
                    DataTable dt = new DataTable();
                    using (XLWorkbook workBook = new XLWorkbook(importFilePath))
                    {
                        //Read the first Sheet from Excel file.
                        IXLWorksheet workSheet = workBook.Worksheet(1);

                        //Loop through the Worksheet rows.
                        bool firstRow = true;
                        foreach (IXLRow row in workSheet.Rows())
                        {
                            if (row.IsEmpty())
                                break;
                            //Use the first row to add columns to DataTable.
                            if (firstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                {
                                    dt.Columns.Add(cell.Value.ToString());
                                }


                                // Get columns name in excel
                                List<string> dtColName = new List<string>();
                                foreach (DataColumn col in dt.Columns)
                                {
                                    dtColName.Add(col.ColumnName);
                                }

                                // Compare excel columns and tblStudents columns
                                if (!dtColName.SequenceEqual(colName))
                                {
                                    MessageBox.Show("Excel file has wrong format! Cannot import data! \nPlease make sure excel has the following columns in order: studentID,firstName,lastName,gender,year,major,tel,dateAdded,isWUStudent,otherStudent", "Import Cancelled",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                firstRow = false;
                            }
                            else
                            {
                                //Add rows to DataTable.
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells(1, dt.Columns.Count))
                                {
                                    //// L is date cell
                                    //if (cell.Address.ColumnLetter == "L")
                                    //{
                                    //    string strDate = cell.Value.ToString();
                                    //    DateTime date = DateTime.ParseExact(strDate, "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture);
                                    //    dt.Rows[dt.Rows.Count - 1][i] = date.ToString("yyyy-MM-dd");
                                    //}
                                    //else dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                    dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                    i++;
                                }
                                rowCount++;
                            }
                        }
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            if (i == 3)
                                continue;
                            else if (row[i].ToString() == "")
                            {
                                row[i] = "Empty";
                            }
                        }
                        if (row[3].ToString() == "Male" || row[3].ToString() == "male"
                            || row[3].ToString() == "MALE" || row[3].ToString() == "")
                        {
                            row[3] = "M";
                        }
                        else if (row[3].ToString() == "Female" || row[3].ToString() == "female"
                            || row[3].ToString() == "FEMALE")
                        {
                            row[3] = "F";
                        }
                        //row[8] = 1;
                        //row[9] = string.Empty;
                    }

                    // Insert rows into database
                    if (LibModule.BulkInsertStudentRecord(dt))
                    {
                        MessageBox.Show($"Import Finished! {rowCount} records has been added into database!", "Import Completed",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cannot import data into database!", "Import Incomplete",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        /// <summary>
        /// Copy current Database to C:\Users\[curentUser]\AppData\Roaming
        /// </summary>
        public static void CopyDatabaseToLocalUserAppDataFolder()
        {
            // C:\Users\[curentUser]\AppData\Roaming
            string userAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // C:\Users\[curentUser]\AppData\Roaming\WULibraryManagementSystem\Database
            string databaseFolder = Path.Combine(userAppDataPath, @"WULibraryManagementSystem\Database\");
            // C:\Users\[currentUser]\AppData\Romaing\WULibraryManagementSystem\Database\library.db
            string databaseFile = Path.Combine(databaseFolder, "library.db");
            // projectPath\Resources\library.db
            string defaultDatabase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\library.db");

            // check if the destination folder is already exist if not, create directory
            if (!Directory.Exists(databaseFolder))
                Directory.CreateDirectory(databaseFolder);

            // check if database file already exist 
            if (!File.Exists(databaseFile))
            {
                File.Copy(defaultDatabase, databaseFile);
            }
            //else
            //{
            //    // check if default database newer than current database
            //    if (File.GetLastWriteTime(defaultDatabase) > File.GetLastWriteTime(databaseFile))
            //    {
            //        // backup current database before copy latest default database
            //        File.Move(databaseFile, Path.Combine(databaseFolder, "library.bak"));

            //        // copy latest default database
            //        File.Copy(defaultDatabase, databaseFile, true);
            //    }
            //}
        }

        /// <summary>
        /// Fill Report Viewer with DataGridView's DataSource.
        /// </summary>
        /// <param name="rpPath">Path to rdlc file</param>
        /// <param name="rpDataSet">Name of DataSet in rdlc file</param>
        /// <param name="parameters">Parameter in rdlc file</param>
        public static void FillReportViewerWithDGVDataSource(DataGridView dgv, ReportViewer rpv, string rpPath,
            string rpDataSet, Dictionary<string, string> parameters = null)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = ((DataTable)dgv.DataSource).Copy();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            rpv.LocalReport.ReportEmbeddedResource = rpPath;
            if (parameters != null)
            {
                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                foreach (var p in parameters)
                    listReportParameter.Add(new ReportParameter(p.Key, p.Value));
                rpv.LocalReport.SetParameters(listReportParameter);
            }
            ReportDataSource rds = new ReportDataSource(rpDataSet, ds.Tables[0]);
            rpv.LocalReport.DataSources.Clear();
            rpv.ResetPageSettings();
            rpv.LocalReport.DataSources.Add(rds);
            Cursor.Current = Cursors.Default;
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);

        /// <summary>
        /// Check if there is internet connection using simple API function InternetGetConnectedState.
        /// </summary>
        public static bool IsInternetAvailable()
        {
            try
            {
                int description;
                return InternetGetConnectedState(out description, 0);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Check if there is internet connection by pinging to specific URL.
        /// </summary>
        public static bool IsInternetAvailable(string url)
        {
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(url, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return false;
        }

        /// <summary>
        /// Enable right click to show copy context menu in DataGridView Cell
        /// </summary>
        public static void EnableRightClickInCells(params DataGridView[] dgvs)
        {
            foreach (var dgv in dgvs)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                ToolStripMenuItem menuCopy = new ToolStripMenuItem("Copy");
                menuCopy.Click += MenuCopy_Click;
                menu.Items.Add(menuCopy);
                dgv.ContextMenuStrip = menu;
                void MenuCopy_Click(object sender, EventArgs e)
                {
                    if (dgv.SelectedCells.Count > 0)
                        Clipboard.SetText(dgv.CurrentCell.Value.ToString());
                }
                dgv.CellMouseDown += dgv_CellMouseDown;
                void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
                {
                    // check if mouse click is right click
                    if (e.Button == MouseButtons.Right)
                    {
                        if (dgv.SelectedCells.Count > 0)
                        {
                            if (menu.Items.Count == 0)
                                menu.Items.Add(menuCopy);
                        }
                        else menu.Items.Clear();
                    }
                }
                dgv.MouseDown += dgv_MouseDown;
                // clear right click context menu if click on grey area in datagridview
                void dgv_MouseDown(object sender, MouseEventArgs e)
                {
                    menu.Items.Clear();
                }
            }
        }

        public static int GetAmountOfActiveAdminUser()
        {
            int amount = int.Parse(LibModule.ExecuteScalarQuery("SELECT COUNT(*) " +
                "FROM tblUserRole a INNER JOIN tblUser b ON b.userID = a.userID " +
                "INNER JOIN tblRole c on c.roleID = a.roleID " +
                "WHERE b.isActive = 'Yes' AND c.roleName = 'Admin'"));
            return amount;
        }
        #endregion

        #region Form Related
        public static void SetFormIcon(Form frm)
        {
            frm.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        public static void DragFormWithControlMouseDown(Form frm, Control ctrl)
        {
            ctrl.MouseDown += Panel_MouseDown;
            void Panel_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(frm.Handle, 0x112, 0xf012, 0);
            }
        }

        public static void FixControlFlickering(Control ctrl)
        {
            int style = NativeWinAPI.GetWindowLong(ctrl.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(ctrl.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr Wnd, int wMsg, int wParam, int lParam);

        // fix flickering
        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        #endregion

        #region Application
        // Add/Remove Startup Folder Shortcut to Your App
        // https://www.codeproject.com/Articles/146757/Add-Remove-Startup-Folder-Shortcut-to-Your-App
        public static void SetApplicationAutorunAtWindowStartup(bool enabled)
        {
            // references: IWshRuntimeLibrary, Shell32
            if (enabled) CreateStartupFolderShortcut();
            else DeleteStartupFolderShortcut("LibraryDBMS.exe");
        }

        private static void CreateStartupFolderShortcut()
        {
            // shortcut folder path: C:\Users\[username]\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\
            WshShellClass wshShell = new WshShellClass();
            IWshShortcut shortcut;
            string startUpFolderPath =
              Environment.GetFolderPath(Environment.SpecialFolder.Startup);

            // Create the shortcut
            shortcut =
              (IWshShortcut)wshShell.CreateShortcut(
                startUpFolderPath + "\\" +
                Application.ProductName + ".lnk");

            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.Description = "Launch Library Management System";
            // shortcut.IconLocation = Application.StartupPath + @"\App.ico";
            shortcut.Save();
        }

        private static string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = Path.GetFileName(shortcutFilename);

            Shell32.Shell shell = new Shell32.ShellClass();
            Shell32.Folder folder = shell.NameSpace(pathOnly);
            Shell32.FolderItem folderItem = folder.ParseName(filenameOnly);
            if (folderItem != null)
            {
                Shell32.ShellLinkObject link =
                  (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return string.Empty; // Not found
        }

        private static void DeleteStartupFolderShortcut(string targetExeName)
        {
            string startUpFolderPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Startup);

            DirectoryInfo di = new DirectoryInfo(startUpFolderPath);
            FileInfo[] files = di.GetFiles("*.lnk");

            foreach (FileInfo fi in files)
            {
                string shortcutTargetFile = GetShortcutTargetFile(fi.FullName);

                if (shortcutTargetFile.EndsWith(targetExeName,
                      StringComparison.InvariantCultureIgnoreCase))
                {
                    System.IO.File.Delete(fi.FullName);
                }
            }
        }
        #endregion
    }
}