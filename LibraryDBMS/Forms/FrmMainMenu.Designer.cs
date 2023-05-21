namespace LibraryDBMS.Forms
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
            this.lblNotificationBadge = new System.Windows.Forms.Label();
            this.btnHomeCollapsed = new System.Windows.Forms.Button();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.pHomeBorder = new System.Windows.Forms.Panel();
            this.pHome = new System.Windows.Forms.Panel();
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pDashboard = new System.Windows.Forms.Panel();
            this.pManageBook = new System.Windows.Forms.Panel();
            this.pManageStudent = new System.Windows.Forms.Panel();
            this.pBookLoanReturn = new System.Windows.Forms.Panel();
            this.pReport = new System.Windows.Forms.Panel();
            this.pNotification = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pRecentActivity = new System.Windows.Forms.Panel();
            this.pManageUser = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMenuTitle = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pSidebar.SuspendLayout();
            this.pHomeBorder.SuspendLayout();
            this.pTitleBar.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSidebar
            // 
            this.pSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pSidebar.Controls.Add(this.btnLogout);
            this.pSidebar.Controls.Add(this.lblNotificationBadge);
            this.pSidebar.Controls.Add(this.btnHomeCollapsed);
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
            this.pSidebar.Controls.Add(this.pHomeBorder);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidebar.Location = new System.Drawing.Point(0, 25);
            this.pSidebar.MaximumSize = new System.Drawing.Size(214, 0);
            this.pSidebar.MinimumSize = new System.Drawing.Size(55, 0);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(214, 656);
            this.pSidebar.TabIndex = 0;
            // 
            // lblNotificationBadge
            // 
            this.lblNotificationBadge.AutoSize = true;
            this.lblNotificationBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(19)))), ((int)(((byte)(5)))));
            this.lblNotificationBadge.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationBadge.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNotificationBadge.Location = new System.Drawing.Point(29, 413);
            this.lblNotificationBadge.Name = "lblNotificationBadge";
            this.lblNotificationBadge.Size = new System.Drawing.Size(16, 18);
            this.lblNotificationBadge.TabIndex = 2;
            this.lblNotificationBadge.Text = "0";
            this.lblNotificationBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHomeCollapsed
            // 
            this.btnHomeCollapsed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHomeCollapsed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeCollapsed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnHomeCollapsed.FlatAppearance.BorderSize = 0;
            this.btnHomeCollapsed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnHomeCollapsed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnHomeCollapsed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeCollapsed.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeCollapsed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHomeCollapsed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeCollapsed.Location = new System.Drawing.Point(12, 18);
            this.btnHomeCollapsed.Name = "btnHomeCollapsed";
            this.btnHomeCollapsed.Size = new System.Drawing.Size(33, 100);
            this.btnHomeCollapsed.TabIndex = 0;
            this.btnHomeCollapsed.Text = "H\r\nO\r\nM\r\nE";
            this.btnHomeCollapsed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomeCollapsed.UseVisualStyleBackColor = true;
            this.btnHomeCollapsed.Visible = false;
            this.btnHomeCollapsed.Click += new System.EventHandler(this.Button_Click);
            // 
            // panelSelected
            // 
            this.panelSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSelected.Location = new System.Drawing.Point(3, 137);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(8, 40);
            this.panelSelected.TabIndex = 0;
            this.panelSelected.Visible = false;
            // 
            // pHomeBorder
            // 
            this.pHomeBorder.BackColor = System.Drawing.Color.White;
            this.pHomeBorder.Controls.Add(this.btnHome);
            this.pHomeBorder.Location = new System.Drawing.Point(42, 12);
            this.pHomeBorder.Name = "pHomeBorder";
            this.pHomeBorder.Size = new System.Drawing.Size(131, 105);
            this.pHomeBorder.TabIndex = 1;
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.SystemColors.Control;
            this.pHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHome.Location = new System.Drawing.Point(214, 75);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(1050, 606);
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
            this.pTitleBar.Size = new System.Drawing.Size(1264, 25);
            this.pTitleBar.TabIndex = 2;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAppTitle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAppTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(209, 20);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Library Management System";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.pHeader.Controls.Add(this.panel1);
            this.pHeader.Controls.Add(this.btnMenu);
            this.pHeader.Controls.Add(this.btnMenuTitle);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(214, 25);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1050, 50);
            this.pHeader.TabIndex = 3;
            // 
            // pDashboard
            // 
            this.pDashboard.BackColor = System.Drawing.Color.White;
            this.pDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDashboard.Location = new System.Drawing.Point(214, 75);
            this.pDashboard.Name = "pDashboard";
            this.pDashboard.Size = new System.Drawing.Size(1050, 606);
            this.pDashboard.TabIndex = 4;
            // 
            // pManageBook
            // 
            this.pManageBook.BackColor = System.Drawing.Color.White;
            this.pManageBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pManageBook.Location = new System.Drawing.Point(214, 75);
            this.pManageBook.Name = "pManageBook";
            this.pManageBook.Size = new System.Drawing.Size(1050, 606);
            this.pManageBook.TabIndex = 5;
            // 
            // pManageStudent
            // 
            this.pManageStudent.BackColor = System.Drawing.Color.White;
            this.pManageStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pManageStudent.Location = new System.Drawing.Point(214, 75);
            this.pManageStudent.Name = "pManageStudent";
            this.pManageStudent.Size = new System.Drawing.Size(1050, 606);
            this.pManageStudent.TabIndex = 6;
            // 
            // pBookLoanReturn
            // 
            this.pBookLoanReturn.BackColor = System.Drawing.Color.White;
            this.pBookLoanReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBookLoanReturn.Location = new System.Drawing.Point(214, 75);
            this.pBookLoanReturn.Name = "pBookLoanReturn";
            this.pBookLoanReturn.Size = new System.Drawing.Size(1050, 606);
            this.pBookLoanReturn.TabIndex = 7;
            // 
            // pReport
            // 
            this.pReport.BackColor = System.Drawing.Color.White;
            this.pReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReport.Location = new System.Drawing.Point(214, 75);
            this.pReport.Name = "pReport";
            this.pReport.Size = new System.Drawing.Size(1050, 606);
            this.pReport.TabIndex = 8;
            // 
            // pNotification
            // 
            this.pNotification.BackColor = System.Drawing.Color.White;
            this.pNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNotification.Location = new System.Drawing.Point(214, 75);
            this.pNotification.Name = "pNotification";
            this.pNotification.Size = new System.Drawing.Size(1050, 606);
            this.pNotification.TabIndex = 10;
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.pHome);
            this.pContainer.Controls.Add(this.pDashboard);
            this.pContainer.Controls.Add(this.pManageBook);
            this.pContainer.Controls.Add(this.pManageStudent);
            this.pContainer.Controls.Add(this.pBookLoanReturn);
            this.pContainer.Controls.Add(this.pReport);
            this.pContainer.Controls.Add(this.pRecentActivity);
            this.pContainer.Controls.Add(this.pNotification);
            this.pContainer.Controls.Add(this.pManageUser);
            this.pContainer.Controls.Add(this.pHeader);
            this.pContainer.Controls.Add(this.pSidebar);
            this.pContainer.Controls.Add(this.pTitleBar);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1264, 681);
            this.pContainer.TabIndex = 0;
            // 
            // pRecentActivity
            // 
            this.pRecentActivity.BackColor = System.Drawing.Color.White;
            this.pRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRecentActivity.Location = new System.Drawing.Point(214, 75);
            this.pRecentActivity.Name = "pRecentActivity";
            this.pRecentActivity.Size = new System.Drawing.Size(1050, 606);
            this.pRecentActivity.TabIndex = 11;
            // 
            // pManageUser
            // 
            this.pManageUser.BackColor = System.Drawing.Color.White;
            this.pManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pManageUser.Location = new System.Drawing.Point(214, 75);
            this.pManageUser.Name = "pManageUser";
            this.pManageUser.Size = new System.Drawing.Size(1050, 606);
            this.pManageUser.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(850, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangePassword.Image = global::LibraryDBMS.Properties.Resources.password_key_26px;
            this.btnChangePassword.Location = new System.Drawing.Point(117, -3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(36, 50);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.TabStop = false;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.Image = global::LibraryDBMS.Properties.Resources.info_26px;
            this.btnAbout.Location = new System.Drawing.Point(154, -3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnAbout.Size = new System.Drawing.Size(36, 50);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.TabStop = false;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.Image = global::LibraryDBMS.Properties.Resources.menu_26px;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(36, 50);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMenuTitle
            // 
            this.btnMenuTitle.AutoSize = true;
            this.btnMenuTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMenuTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuTitle.FlatAppearance.BorderSize = 0;
            this.btnMenuTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnMenuTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnMenuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuTitle.Image = global::LibraryDBMS.Properties.Resources.user_shield_26px;
            this.btnMenuTitle.Location = new System.Drawing.Point(0, 0);
            this.btnMenuTitle.Name = "btnMenuTitle";
            this.btnMenuTitle.Size = new System.Drawing.Size(1050, 50);
            this.btnMenuTitle.TabIndex = 0;
            this.btnMenuTitle.TabStop = false;
            this.btnMenuTitle.Text = "  Menu Title";
            this.btnMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuTitle.UseVisualStyleBackColor = true;
            this.btnMenuTitle.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = global::LibraryDBMS.Properties.Resources.logout_26px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(12, 521);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(202, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Button_Click);
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
            this.btnDashboard.Size = new System.Drawing.Size(202, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Text = "  Dashboard";
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
            this.btnManageBook.Image = global::LibraryDBMS.Properties.Resources.books_26px;
            this.btnManageBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBook.Location = new System.Drawing.Point(12, 183);
            this.btnManageBook.Name = "btnManageBook";
            this.btnManageBook.Size = new System.Drawing.Size(202, 40);
            this.btnManageBook.TabIndex = 0;
            this.btnManageBook.TabStop = false;
            this.btnManageBook.Text = "  Manage Books";
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
            this.btnManageStudent.Image = global::LibraryDBMS.Properties.Resources.student_male_26px;
            this.btnManageStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudent.Location = new System.Drawing.Point(12, 229);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(202, 40);
            this.btnManageStudent.TabIndex = 0;
            this.btnManageStudent.TabStop = false;
            this.btnManageStudent.Text = "  Manage Students";
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
            this.btnBookLoanReturn.Image = global::LibraryDBMS.Properties.Resources.bookmark_26px;
            this.btnBookLoanReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookLoanReturn.Location = new System.Drawing.Point(12, 275);
            this.btnBookLoanReturn.Name = "btnBookLoanReturn";
            this.btnBookLoanReturn.Size = new System.Drawing.Size(202, 40);
            this.btnBookLoanReturn.TabIndex = 0;
            this.btnBookLoanReturn.TabStop = false;
            this.btnBookLoanReturn.Text = "  Borrow/Return Books";
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
            this.btnReport.Image = global::LibraryDBMS.Properties.Resources.document_26px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(12, 321);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(202, 40);
            this.btnReport.TabIndex = 0;
            this.btnReport.TabStop = false;
            this.btnReport.Text = "  Reports";
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
            this.btnRecentActivity.Image = global::LibraryDBMS.Properties.Resources.time_machine_26px;
            this.btnRecentActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecentActivity.Location = new System.Drawing.Point(12, 367);
            this.btnRecentActivity.Name = "btnRecentActivity";
            this.btnRecentActivity.Size = new System.Drawing.Size(202, 40);
            this.btnRecentActivity.TabIndex = 0;
            this.btnRecentActivity.TabStop = false;
            this.btnRecentActivity.Text = "  Recent Activity";
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
            this.btnManageUser.Image = global::LibraryDBMS.Properties.Resources.user_shield_26px;
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.Location = new System.Drawing.Point(12, 459);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(202, 40);
            this.btnManageUser.TabIndex = 0;
            this.btnManageUser.TabStop = false;
            this.btnManageUser.Text = "  Manage User";
            this.btnManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotification.Image = global::LibraryDBMS.Properties.Resources.notification_26px;
            this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.Location = new System.Drawing.Point(12, 413);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(202, 40);
            this.btnNotification.TabIndex = 0;
            this.btnNotification.TabStop = false;
            this.btnNotification.Text = "  Notification";
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.Image = global::LibraryDBMS.Properties.Resources.male_user_26px;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(12, 567);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(202, 40);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.TabStop = false;
            this.btnAccount.Text = "  Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.Image = global::LibraryDBMS.Properties.Resources.settings_26px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(12, 613);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(202, 40);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "  Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::LibraryDBMS.Properties.Resources.lib_logo;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(125, 100);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LibraryDBMS.Properties.Resources.subtract_16px;
            this.btnMinimize.Location = new System.Drawing.Point(1116, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LibraryDBMS.Properties.Resources.maximize_button_16px;
            this.btnMaximize.Location = new System.Drawing.Point(1167, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 25);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::LibraryDBMS.Properties.Resources.close_16px;
            this.btnExit.Location = new System.Drawing.Point(1218, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Button_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.Resize += new System.EventHandler(this.FrmMainMenu_Resize);
            this.pSidebar.ResumeLayout(false);
            this.pSidebar.PerformLayout();
            this.pHomeBorder.ResumeLayout(false);
            this.pTitleBar.ResumeLayout(false);
            this.pTitleBar.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Panel panelSelected;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pDashboard;
        private System.Windows.Forms.Panel pReport;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnMenuTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHomeCollapsed;
        internal System.Windows.Forms.Panel pManageBook;
        internal System.Windows.Forms.Button btnManageBook;
        internal System.Windows.Forms.Button btnBookLoanReturn;
        internal System.Windows.Forms.Button btnNotification;
        internal System.Windows.Forms.Button btnManageStudent;
        internal System.Windows.Forms.Button btnRecentActivity;
        internal System.Windows.Forms.Panel pManageStudent;
        internal System.Windows.Forms.Panel pBookLoanReturn;
        internal System.Windows.Forms.Panel pNotification;
        internal System.Windows.Forms.Panel pRecentActivity;
        private System.Windows.Forms.Panel pHomeBorder;
        internal System.Windows.Forms.Label lblNotificationBadge;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAbout;
        internal System.Windows.Forms.Button btnManageUser;
        internal System.Windows.Forms.Panel pManageUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassword;
    }
}