namespace LibraryDBMS.Forms
{
    partial class DialogSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAutoUpdate = new LibraryDBMS.CustomControls.RJToggleButton();
            this.tbSidebarCollapse = new LibraryDBMS.CustomControls.RJToggleButton();
            this.tbAutoStartup = new LibraryDBMS.CustomControls.RJToggleButton();
            this.tbStartInFullscreen = new LibraryDBMS.CustomControls.RJToggleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStartupForm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnImportBooks = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnLoginHistory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnImportStudents = new System.Windows.Forms.Button();
            this.pTitleBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxImport.SuspendLayout();
            this.groupBoxExport.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pTitleBar.Controls.Add(this.label10);
            this.pTitleBar.Controls.Add(this.btnClose);
            this.pTitleBar.Controls.Add(this.lblHeader);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(3, 3);
            this.pTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(622, 45);
            this.pTitleBar.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.Image = global::LibraryDBMS.Properties.Resources.settings_26px;
            this.label10.Location = new System.Drawing.Point(151, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 44);
            this.label10.TabIndex = 36;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LibraryDBMS.Properties.Resources.close_16px;
            this.btnClose.Location = new System.Drawing.Point(577, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(622, 45);
            this.lblHeader.TabIndex = 33;
            this.lblHeader.Text = "  Application Setting";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 638);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 638);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(6, 682);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 4);
            this.panel3.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbAutoUpdate);
            this.groupBox1.Controls.Add(this.tbSidebarCollapse);
            this.groupBox1.Controls.Add(this.tbAutoStartup);
            this.groupBox1.Controls.Add(this.tbStartInFullscreen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbStartupForm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(598, 223);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Startup|Update";
            // 
            // tbAutoUpdate
            // 
            this.tbAutoUpdate.AutoSize = true;
            this.tbAutoUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbAutoUpdate.Location = new System.Drawing.Point(343, 172);
            this.tbAutoUpdate.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbAutoUpdate.Name = "tbAutoUpdate";
            this.tbAutoUpdate.OffBackColor = System.Drawing.Color.DarkGray;
            this.tbAutoUpdate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbAutoUpdate.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.tbAutoUpdate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbAutoUpdate.Size = new System.Drawing.Size(45, 22);
            this.tbAutoUpdate.TabIndex = 4;
            this.tbAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // tbSidebarCollapse
            // 
            this.tbSidebarCollapse.AutoSize = true;
            this.tbSidebarCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSidebarCollapse.Location = new System.Drawing.Point(343, 144);
            this.tbSidebarCollapse.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbSidebarCollapse.Name = "tbSidebarCollapse";
            this.tbSidebarCollapse.OffBackColor = System.Drawing.Color.DarkGray;
            this.tbSidebarCollapse.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbSidebarCollapse.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.tbSidebarCollapse.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbSidebarCollapse.Size = new System.Drawing.Size(45, 22);
            this.tbSidebarCollapse.TabIndex = 4;
            this.tbSidebarCollapse.UseVisualStyleBackColor = true;
            // 
            // tbAutoStartup
            // 
            this.tbAutoStartup.AutoSize = true;
            this.tbAutoStartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbAutoStartup.Location = new System.Drawing.Point(343, 111);
            this.tbAutoStartup.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbAutoStartup.Name = "tbAutoStartup";
            this.tbAutoStartup.OffBackColor = System.Drawing.Color.DarkGray;
            this.tbAutoStartup.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbAutoStartup.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.tbAutoStartup.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbAutoStartup.Size = new System.Drawing.Size(45, 22);
            this.tbAutoStartup.TabIndex = 3;
            this.tbAutoStartup.UseVisualStyleBackColor = true;
            // 
            // tbStartInFullscreen
            // 
            this.tbStartInFullscreen.AutoSize = true;
            this.tbStartInFullscreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbStartInFullscreen.Location = new System.Drawing.Point(343, 77);
            this.tbStartInFullscreen.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbStartInFullscreen.Name = "tbStartInFullscreen";
            this.tbStartInFullscreen.OffBackColor = System.Drawing.Color.DarkGray;
            this.tbStartInFullscreen.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbStartInFullscreen.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.tbStartInFullscreen.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbStartInFullscreen.Size = new System.Drawing.Size(45, 22);
            this.tbStartInFullscreen.TabIndex = 2;
            this.tbStartInFullscreen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Auto update application in background:";
            // 
            // cbStartupForm
            // 
            this.cbStartupForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.cbStartupForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStartupForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartupForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStartupForm.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStartupForm.ForeColor = System.Drawing.SystemColors.Control;
            this.cbStartupForm.FormattingEnabled = true;
            this.cbStartupForm.Location = new System.Drawing.Point(343, 40);
            this.cbStartupForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStartupForm.Name = "cbStartupForm";
            this.cbStartupForm.Size = new System.Drawing.Size(204, 28);
            this.cbStartupForm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 22);
            this.label6.TabIndex = 43;
            this.label6.Text = "Start application with collapsed sidebar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Start application when Windows is started:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Start application in fullscreen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Default startup page:";
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxImport.Controls.Add(this.btnBackup);
            this.groupBoxImport.Controls.Add(this.btnImportStudents);
            this.groupBoxImport.Controls.Add(this.btnImportBooks);
            this.groupBoxImport.Controls.Add(this.btnRestore);
            this.groupBoxImport.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxImport.Location = new System.Drawing.Point(15, 408);
            this.groupBoxImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxImport.Size = new System.Drawing.Size(598, 103);
            this.groupBoxImport.TabIndex = 42;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "Import|Backup|Restore";
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackup.Image = global::LibraryDBMS.Properties.Resources.data_backup_26px;
            this.btnBackup.Location = new System.Drawing.Point(343, 37);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(114, 40);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "  Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnImportBooks
            // 
            this.btnImportBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(156)))));
            this.btnImportBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportBooks.FlatAppearance.BorderSize = 0;
            this.btnImportBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportBooks.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnImportBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImportBooks.Image = global::LibraryDBMS.Properties.Resources.import_26px;
            this.btnImportBooks.Location = new System.Drawing.Point(11, 37);
            this.btnImportBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportBooks.Name = "btnImportBooks";
            this.btnImportBooks.Size = new System.Drawing.Size(153, 40);
            this.btnImportBooks.TabIndex = 7;
            this.btnImportBooks.Text = "  Import Books";
            this.btnImportBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportBooks.UseVisualStyleBackColor = false;
            this.btnImportBooks.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestore.Image = global::LibraryDBMS.Properties.Resources.data_recovery_26px;
            this.btnRestore.Location = new System.Drawing.Point(464, 37);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(125, 40);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "  Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExport.Controls.Add(this.cbTable);
            this.groupBoxExport.Controls.Add(this.btnExport);
            this.groupBoxExport.Controls.Add(this.label3);
            this.groupBoxExport.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExport.Location = new System.Drawing.Point(15, 297);
            this.groupBoxExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxExport.Size = new System.Drawing.Size(598, 103);
            this.groupBoxExport.TabIndex = 42;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Export to Excel (.xlsx)";
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.cbTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable.ForeColor = System.Drawing.SystemColors.Control;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(133, 47);
            this.cbTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(204, 28);
            this.cbTable.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(156)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExport.Image = global::LibraryDBMS.Properties.Resources.microsoft_excel_26px;
            this.btnExport.Location = new System.Drawing.Point(426, 41);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(163, 40);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "  Export to Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Select Table:";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogin.Controls.Add(this.btnLoginHistory);
            this.groupBoxLogin.Controls.Add(this.label4);
            this.groupBoxLogin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(15, 519);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLogin.Size = new System.Drawing.Size(598, 78);
            this.groupBoxLogin.TabIndex = 42;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login History";
            // 
            // btnLoginHistory
            // 
            this.btnLoginHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnLoginHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginHistory.FlatAppearance.BorderSize = 0;
            this.btnLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginHistory.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoginHistory.Image = global::LibraryDBMS.Properties.Resources.time_machine_26px;
            this.btnLoginHistory.Location = new System.Drawing.Point(426, 24);
            this.btnLoginHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginHistory.Name = "btnLoginHistory";
            this.btnLoginHistory.Size = new System.Drawing.Size(163, 40);
            this.btnLoginHistory.TabIndex = 9;
            this.btnLoginHistory.Text = "  Login History";
            this.btnLoginHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoginHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoginHistory.UseVisualStyleBackColor = false;
            this.btnLoginHistory.Click += new System.EventHandler(this.Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Check user login history:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(156)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Image = global::LibraryDBMS.Properties.Resources.cancel_26px;
            this.btnCancel.Location = new System.Drawing.Point(441, 609);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 62);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "  &Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(19)))), ((int)(((byte)(5)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestart.Image = global::LibraryDBMS.Properties.Resources.refresh_26px;
            this.btnRestart.Location = new System.Drawing.Point(15, 609);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(172, 62);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "  &Restart";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnImportStudents
            // 
            this.btnImportStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(156)))));
            this.btnImportStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportStudents.FlatAppearance.BorderSize = 0;
            this.btnImportStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportStudents.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnImportStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImportStudents.Image = global::LibraryDBMS.Properties.Resources.import_26px;
            this.btnImportStudents.Location = new System.Drawing.Point(170, 37);
            this.btnImportStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportStudents.Name = "btnImportStudents";
            this.btnImportStudents.Size = new System.Drawing.Size(167, 40);
            this.btnImportStudents.TabIndex = 7;
            this.btnImportStudents.Text = "  Import Students";
            this.btnImportStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportStudents.UseVisualStyleBackColor = false;
            this.btnImportStudents.Click += new System.EventHandler(this.Button_Click);
            // 
            // DialogSetting
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(628, 689);
            this.Controls.Add(this.groupBoxExport);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxImport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pTitleBar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DialogSetting";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog Setting";
            this.pTitleBar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxImport.ResumeLayout(false);
            this.groupBoxExport.ResumeLayout(false);
            this.groupBoxExport.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStartupForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private CustomControls.RJToggleButton tbStartInFullscreen;
        private CustomControls.RJToggleButton tbAutoStartup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private CustomControls.RJToggleButton tbSidebarCollapse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.GroupBox groupBoxExport;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImportBooks;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button btnLoginHistory;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJToggleButton tbAutoUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImportStudents;
    }
}