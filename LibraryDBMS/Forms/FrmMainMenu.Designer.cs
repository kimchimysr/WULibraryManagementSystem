﻿namespace LibraryDBMS.Forms
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.pSidebar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnManageBook = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.btnBookLoanReturn = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRecentActivity = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pHome = new System.Windows.Forms.Panel();
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.pDashboard = new System.Windows.Forms.Panel();
            this.pManageBook = new System.Windows.Forms.Panel();
            this.pManageStudent = new System.Windows.Forms.Panel();
            this.pBookLoanReturn = new System.Windows.Forms.Panel();
            this.pReport = new System.Windows.Forms.Panel();
            this.pManageUser = new System.Windows.Forms.Panel();
            this.pNotification = new System.Windows.Forms.Panel();
            this.pAccount = new System.Windows.Forms.Panel();
            this.pSetting = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pTitleBar.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSidebar
            // 
            this.pSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pSidebar.Controls.Add(this.btnHome);
            this.pSidebar.Controls.Add(this.panelSelected);
            this.pSidebar.Controls.Add(this.btnDashboard);
            this.pSidebar.Controls.Add(this.btnManageBook);
            this.pSidebar.Controls.Add(this.btnManageStudent);
            this.pSidebar.Controls.Add(this.btnBookLoanReturn);
            this.pSidebar.Controls.Add(this.btnReport);
            this.pSidebar.Controls.Add(this.btnRecentActivity);
            this.pSidebar.Controls.Add(this.btnManageUser);
            this.pSidebar.Controls.Add(this.btnNotification);
            this.pSidebar.Controls.Add(this.btnAccount);
            this.pSidebar.Controls.Add(this.btnSetting);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidebar.Location = new System.Drawing.Point(0, 25);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(200, 776);
            this.pSidebar.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(36, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(128, 99);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelSelected
            // 
            this.panelSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSelected.Location = new System.Drawing.Point(3, 137);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(8, 50);
            this.panelSelected.TabIndex = 0;
            this.panelSelected.Visible = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 137);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(188, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnManageBook
            // 
            this.btnManageBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageBook.FlatAppearance.BorderSize = 0;
            this.btnManageBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBook.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageBook.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnManageBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBook.Location = new System.Drawing.Point(12, 195);
            this.btnManageBook.Name = "btnManageBook";
            this.btnManageBook.Size = new System.Drawing.Size(188, 50);
            this.btnManageBook.TabIndex = 0;
            this.btnManageBook.Text = "   Manage Book";
            this.btnManageBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBook.UseVisualStyleBackColor = true;
            this.btnManageBook.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageStudent.FlatAppearance.BorderSize = 0;
            this.btnManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudent.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageStudent.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnManageStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudent.Location = new System.Drawing.Point(12, 253);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(188, 50);
            this.btnManageStudent.TabIndex = 0;
            this.btnManageStudent.Text = "   Manage Student";
            this.btnManageStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageStudent.UseVisualStyleBackColor = true;
            this.btnManageStudent.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBookLoanReturn
            // 
            this.btnBookLoanReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookLoanReturn.FlatAppearance.BorderSize = 0;
            this.btnBookLoanReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookLoanReturn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookLoanReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookLoanReturn.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnBookLoanReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookLoanReturn.Location = new System.Drawing.Point(12, 311);
            this.btnBookLoanReturn.Name = "btnBookLoanReturn";
            this.btnBookLoanReturn.Size = new System.Drawing.Size(188, 50);
            this.btnBookLoanReturn.TabIndex = 0;
            this.btnBookLoanReturn.Text = "   Book Loan/Return";
            this.btnBookLoanReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookLoanReturn.UseVisualStyleBackColor = true;
            this.btnBookLoanReturn.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(12, 369);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(188, 50);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "   Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRecentActivity
            // 
            this.btnRecentActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecentActivity.FlatAppearance.BorderSize = 0;
            this.btnRecentActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecentActivity.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentActivity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecentActivity.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnRecentActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecentActivity.Location = new System.Drawing.Point(12, 427);
            this.btnRecentActivity.Name = "btnRecentActivity";
            this.btnRecentActivity.Size = new System.Drawing.Size(188, 50);
            this.btnRecentActivity.TabIndex = 0;
            this.btnRecentActivity.Text = "   Recent Activity";
            this.btnRecentActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecentActivity.UseVisualStyleBackColor = true;
            this.btnRecentActivity.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.FlatAppearance.BorderSize = 0;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageUser.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.Location = new System.Drawing.Point(12, 485);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(188, 50);
            this.btnManageUser.TabIndex = 0;
            this.btnManageUser.Text = "   Manage User";
            this.btnManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotification.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.Location = new System.Drawing.Point(12, 602);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(188, 50);
            this.btnNotification.TabIndex = 0;
            this.btnNotification.Text = "   Notification";
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(12, 658);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(188, 50);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "   Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.Image = global::LibraryDBMS.Properties.Resources.pie_26px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(12, 714);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(188, 50);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "   Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.Button_Click);
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.Color.White;
            this.pHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHome.Location = new System.Drawing.Point(200, 75);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1188, 726);
            this.pHome.TabIndex = 1;
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.pTitleBar.Controls.Add(this.lblAppTitle);
            this.pTitleBar.Controls.Add(this.btnMinimize);
            this.pTitleBar.Controls.Add(this.btnMaximize);
            this.pTitleBar.Controls.Add(this.btnExit);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(1388, 25);
            this.pTitleBar.TabIndex = 2;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAppTitle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAppTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(210, 25);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Library Management System";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LibraryDBMS.Properties.Resources.subtract_16px;
            this.btnMinimize.Location = new System.Drawing.Point(1240, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LibraryDBMS.Properties.Resources.maximize_button_16px;
            this.btnMaximize.Location = new System.Drawing.Point(1291, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 25);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::LibraryDBMS.Properties.Resources.close_16px;
            this.btnExit.Location = new System.Drawing.Point(1342, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Button_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.pHeader.Controls.Add(this.lblMenuTitle);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(200, 25);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1188, 50);
            this.pHeader.TabIndex = 3;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMenuTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMenuTitle.Location = new System.Drawing.Point(385, 3);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(418, 44);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pDashboard
            // 
            this.pDashboard.BackColor = System.Drawing.Color.White;
            this.pDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDashboard.Location = new System.Drawing.Point(200, 75);
            this.pDashboard.Name = "pDashboard";
            this.pDashboard.Size = new System.Drawing.Size(1188, 726);
            this.pDashboard.TabIndex = 4;
            // 
            // pManageBook
            // 
            this.pManageBook.BackColor = System.Drawing.Color.White;
            this.pManageBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pManageBook.Location = new System.Drawing.Point(200, 75);
            this.pManageBook.Name = "pManageBook";
            this.pManageBook.Size = new System.Drawing.Size(1188, 726);
            this.pManageBook.TabIndex = 5;
            // 
            // pManageStudent
            // 
            this.pManageStudent.BackColor = System.Drawing.Color.White;
            this.pManageStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pManageStudent.Location = new System.Drawing.Point(200, 75);
            this.pManageStudent.Name = "pManageStudent";
            this.pManageStudent.Size = new System.Drawing.Size(1188, 726);
            this.pManageStudent.TabIndex = 6;
            // 
            // pBookLoanReturn
            // 
            this.pBookLoanReturn.BackColor = System.Drawing.Color.White;
            this.pBookLoanReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBookLoanReturn.Location = new System.Drawing.Point(200, 75);
            this.pBookLoanReturn.Name = "pBookLoanReturn";
            this.pBookLoanReturn.Size = new System.Drawing.Size(1188, 726);
            this.pBookLoanReturn.TabIndex = 7;
            // 
            // pReport
            // 
            this.pReport.BackColor = System.Drawing.Color.White;
            this.pReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReport.Location = new System.Drawing.Point(200, 75);
            this.pReport.Name = "pReport";
            this.pReport.Size = new System.Drawing.Size(1188, 726);
            this.pReport.TabIndex = 8;
            // 
            // pManageUser
            // 
            this.pManageUser.BackColor = System.Drawing.Color.White;
            this.pManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pManageUser.Location = new System.Drawing.Point(200, 75);
            this.pManageUser.Name = "pManageUser";
            this.pManageUser.Size = new System.Drawing.Size(1188, 726);
            this.pManageUser.TabIndex = 9;
            // 
            // pNotification
            // 
            this.pNotification.BackColor = System.Drawing.Color.White;
            this.pNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNotification.Location = new System.Drawing.Point(200, 75);
            this.pNotification.Name = "pNotification";
            this.pNotification.Size = new System.Drawing.Size(1188, 726);
            this.pNotification.TabIndex = 10;
            // 
            // pAccount
            // 
            this.pAccount.BackColor = System.Drawing.Color.White;
            this.pAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAccount.Location = new System.Drawing.Point(200, 75);
            this.pAccount.Name = "pAccount";
            this.pAccount.Size = new System.Drawing.Size(1188, 726);
            this.pAccount.TabIndex = 11;
            // 
            // pSetting
            // 
            this.pSetting.BackColor = System.Drawing.Color.White;
            this.pSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSetting.Location = new System.Drawing.Point(200, 75);
            this.pSetting.Name = "pSetting";
            this.pSetting.Size = new System.Drawing.Size(1188, 726);
            this.pSetting.TabIndex = 12;
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.pHome);
            this.pContainer.Controls.Add(this.pDashboard);
            this.pContainer.Controls.Add(this.pSetting);
            this.pContainer.Controls.Add(this.pAccount);
            this.pContainer.Controls.Add(this.pManageBook);
            this.pContainer.Controls.Add(this.pManageStudent);
            this.pContainer.Controls.Add(this.pBookLoanReturn);
            this.pContainer.Controls.Add(this.pReport);
            this.pContainer.Controls.Add(this.pManageUser);
            this.pContainer.Controls.Add(this.pNotification);
            this.pContainer.Controls.Add(this.pHeader);
            this.pContainer.Controls.Add(this.pSidebar);
            this.pContainer.Controls.Add(this.pTitleBar);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1388, 801);
            this.pContainer.TabIndex = 0;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1388, 801);
            this.Controls.Add(this.pContainer);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1404, 840);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.Resize += new System.EventHandler(this.FrmMainMenu_Resize);
            this.pSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pTitleBar.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Panel panelSelected;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBookLoanReturn;
        private System.Windows.Forms.Button btnManageBook;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Button btnRecentActivity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pDashboard;
        private System.Windows.Forms.Panel pManageBook;
        private System.Windows.Forms.Panel pManageStudent;
        private System.Windows.Forms.Panel pBookLoanReturn;
        private System.Windows.Forms.Panel pReport;
        private System.Windows.Forms.Panel pManageUser;
        private System.Windows.Forms.Panel pNotification;
        private System.Windows.Forms.Panel pAccount;
        private System.Windows.Forms.Panel pSetting;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Panel pContainer;
    }
}