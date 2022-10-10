﻿using IWshRuntimeLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LibraryDBMS.Libs
{
    public static partial class Utils
    {
        #region Security
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

        public static string DefaultHashPassword()
        {
            return HashPassword("Password@123");
        }
        #endregion

        #region Controls Related
        public static bool IsEmptyControl(Form form)
        {
            foreach (Control ctrl in form.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.TabIndex != 0) //Optional TextBox
                        if (string.IsNullOrEmpty(ctrl.Text.Trim()))
                        {
                            MessageBox.Show("Empty TextBox field(s)!", "Empty Field",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return true;
                        }
                }
                if (ctrl is ComboBox)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        MessageBox.Show("Please select items in ComboBox(s)!", "Empty ComboBox",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
                if (ctrl is NumericUpDown)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        MessageBox.Show("Empty NumericUpDown field(s)!", "Empty NumericUpDown",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
            }
            return false;
        }

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
                        foreach (string slabel in controlname)
                            if (lbl.Name.Equals(slabel))
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

        public static void EnableControlDoubleBuffer(Control control)
        {
            control.GetType().InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               control,
               new object[] { true });
        }

        // https://www.anycodings.com/1questions/1647481/how-can-i-get-a-stackpanel-like-layout-in-winforms
        public static void AutoSizeChildrenInFlowLayoutPanel(this FlowLayoutPanel panel, Control fillControl = null)
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
        #endregion

        #region Tool
        public static void FillComboBox(ComboBox cb, bool setSelectedIndex, params string[] items)
        {
            if(items.Length > 0)
                foreach(string str in items)
                    cb.Items.Add(str);
            if(setSelectedIndex)
                cb.SelectedIndex = 0;
        }

        public static string GetDataGridSelectedRowData(DataGridView dgv)
        {
            StringBuilder row = new StringBuilder();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                row.AppendLine($"{dgv.Columns[i].HeaderText}: {dgv.SelectedRows[0].Cells[i].Value}");
            }
            return row.ToString();
        }

        // string extension method
        public static string ToKMString(this string str)
        {
            // 123456 => 123.4K, 1234567 => 1.23M
            int amount = int.Parse(str);
            return amount >= 1_000 && amount < 1_000_000 ? amount.ToString("0,.#K", CultureInfo.InvariantCulture) :
                amount >= 1_000_000 ? amount.ToString("0,,.##M", CultureInfo.InvariantCulture) : str;
        }

        // Printing of DataGridView
        // https://www.codeproject.com/Articles/28046/Printing-of-DataGridView
        public static void PrintPreviewDataGridView(string title, DataGridView dgv)
        {
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
                    int iLeftMargin = e.MarginBounds.Left;
                    //Set the top margin
                    int iTopMargin = e.MarginBounds.Top;
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
                                           ((double)e.MarginBounds.Width / (double)iTotalWidth))));

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
                        iCellHeight = GridRow.Height + 5;
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
                                        Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                        e.Graphics.MeasureString(title, new Font(dgv.Font,
                                        FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                                string strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                                //Draw Date
                                e.Graphics.DrawString(strDate, new Font(dgv.Font, FontStyle.Bold),
                                        Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                        e.Graphics.MeasureString(strDate, new Font(dgv.Font,
                                        FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                        e.Graphics.MeasureString(title, new Font(new Font(dgv.Font,
                                        FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                                //Draw Columns                 
                                iTopMargin = e.MarginBounds.Top;
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

                    //If more lines exist, print another page.
                    if (bMorePagesToPrint)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = pd;
            ((Form)objPPdialog).StartPosition = FormStartPosition.CenterParent;
            //((Form)objPPdialog).WindowState = FormWindowState.Maximized;
            objPPdialog.ShowDialog();
        }


        #endregion

        #region Data Validation
        public static bool IsValidEmail(string str)
        {
            // a valid email format: (randomString)@(randomString2).(2-3 characters)
            Regex regex = new Regex("[a-z0-9]+@[a-z]+\\.[a-z]{2,3}");
            if (!regex.IsMatch(str))
            {
                MessageBox.Show("Please enter a valid email address!", "Invalid Email Address",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region Form Related
        public static bool FormIsOpen(string form)
        {
            // check if window has already open
            var OpenForms = Application.OpenForms.Cast<Form>();

            return OpenForms.Any(x => x.Name == form);
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