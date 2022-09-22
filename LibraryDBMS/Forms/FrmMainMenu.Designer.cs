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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnRecentActivity = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBookLoanReturn = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.btnManageBook = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelSidebar.Controls.Add(this.panel3);
            this.panelSidebar.Controls.Add(this.panelSelected);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnManageBook);
            this.panelSidebar.Controls.Add(this.btnManageStudent);
            this.panelSidebar.Controls.Add(this.btnBookLoanReturn);
            this.panelSidebar.Controls.Add(this.btnReport);
            this.panelSidebar.Controls.Add(this.btnRecentActivity);
            this.panelSidebar.Controls.Add(this.btnManageUser);
            this.panelSidebar.Controls.Add(this.btnNotification);
            this.panelSidebar.Controls.Add(this.btnAccount);
            this.panelSidebar.Controls.Add(this.btnSetting);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 761);
            this.panelSidebar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 100);
            this.panel3.TabIndex = 0;
            // 
            // panelSelected
            // 
            this.panelSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSelected.Location = new System.Drawing.Point(3, 117);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(8, 50);
            this.panelSelected.TabIndex = 0;
            this.panelSelected.Visible = false;
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
            this.btnSetting.Location = new System.Drawing.Point(12, 699);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(188, 50);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "   Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.Button_Click);
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
            this.btnAccount.Location = new System.Drawing.Point(12, 643);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(188, 50);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "   Account";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.Button_Click);
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
            this.btnNotification.Location = new System.Drawing.Point(12, 587);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(188, 50);
            this.btnNotification.TabIndex = 0;
            this.btnNotification.Text = "   Notification";
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.Button_Click);
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
            this.btnRecentActivity.Location = new System.Drawing.Point(12, 407);
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
            this.btnManageUser.Location = new System.Drawing.Point(12, 465);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(188, 50);
            this.btnManageUser.TabIndex = 0;
            this.btnManageUser.Text = "   Manage User";
            this.btnManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.Button_Click);
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
            this.btnReport.Location = new System.Drawing.Point(12, 349);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(188, 50);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "   Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.Button_Click);
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
            this.btnBookLoanReturn.Location = new System.Drawing.Point(12, 291);
            this.btnBookLoanReturn.Name = "btnBookLoanReturn";
            this.btnBookLoanReturn.Size = new System.Drawing.Size(188, 50);
            this.btnBookLoanReturn.TabIndex = 0;
            this.btnBookLoanReturn.Text = "   Book Loan/Return";
            this.btnBookLoanReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookLoanReturn.UseVisualStyleBackColor = true;
            this.btnBookLoanReturn.Click += new System.EventHandler(this.Button_Click);
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
            this.btnManageStudent.Location = new System.Drawing.Point(12, 233);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(188, 50);
            this.btnManageStudent.TabIndex = 0;
            this.btnManageStudent.Text = "   Manage Student";
            this.btnManageStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageStudent.UseVisualStyleBackColor = true;
            this.btnManageStudent.Click += new System.EventHandler(this.Button_Click);
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
            this.btnManageBook.Location = new System.Drawing.Point(12, 175);
            this.btnManageBook.Name = "btnManageBook";
            this.btnManageBook.Size = new System.Drawing.Size(188, 50);
            this.btnManageBook.TabIndex = 0;
            this.btnManageBook.Text = "   Manage Book";
            this.btnManageBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBook.UseVisualStyleBackColor = true;
            this.btnManageBook.Click += new System.EventHandler(this.Button_Click);
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
            this.btnDashboard.Location = new System.Drawing.Point(12, 117);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(188, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.Button_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1034, 711);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1034, 50);
            this.panelHeader.TabIndex = 2;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1250, 800);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelSelected;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBookLoanReturn;
        private System.Windows.Forms.Button btnManageBook;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Button btnRecentActivity;
    }
}