namespace LibraryDBMS.Forms
{
    partial class DialogLoginHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.dgvLoginList = new System.Windows.Forms.DataGridView();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.userLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 593);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 4);
            this.panel3.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(644, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 590);
            this.panel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 590);
            this.panel1.TabIndex = 42;
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pTitleBar.Controls.Add(this.label10);
            this.pTitleBar.Controls.Add(this.btnClose);
            this.pTitleBar.Controls.Add(this.lblHeader);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(6, 3);
            this.pTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(638, 45);
            this.pTitleBar.TabIndex = 43;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(638, 45);
            this.lblHeader.TabIndex = 33;
            this.lblHeader.Text = "  Login History";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Image = global::LibraryDBMS.Properties.Resources.time_machine_26px;
            this.label10.Location = new System.Drawing.Point(204, 1);
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
            this.btnClose.Location = new System.Drawing.Point(593, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.lblRowsCount.Location = new System.Drawing.Point(8, 559);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(109, 20);
            this.lblRowsCount.TabIndex = 67;
            this.lblRowsCount.Text = "Display Result: ";
            this.lblRowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvLoginList
            // 
            this.dgvLoginList.AllowUserToAddRows = false;
            this.dgvLoginList.AllowUserToDeleteRows = false;
            this.dgvLoginList.AllowUserToResizeColumns = false;
            this.dgvLoginList.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLoginList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLoginList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoginList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoginList.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoginList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLoginList.ColumnHeadersHeight = 30;
            this.dgvLoginList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoginList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userLogID,
            this.username,
            this.info,
            this.dateTime});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoginList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLoginList.EnableHeadersVisualStyles = false;
            this.dgvLoginList.Location = new System.Drawing.Point(12, 118);
            this.dgvLoginList.MultiSelect = false;
            this.dgvLoginList.Name = "dgvLoginList";
            this.dgvLoginList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLoginList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoginList.Size = new System.Drawing.Size(626, 438);
            this.dgvLoginList.TabIndex = 66;
            this.dgvLoginList.TabStop = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(116, 82);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(98, 26);
            this.dtpToDate.TabIndex = 69;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(12, 82);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(98, 26);
            this.dtpFromDate.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "To Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 72;
            this.label2.Text = "From Date:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFilter.Image = global::LibraryDBMS.Properties.Resources.filter_20px;
            this.btnFilter.Location = new System.Drawing.Point(222, 78);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(71, 34);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // userLogID
            // 
            this.userLogID.DataPropertyName = "userLogID";
            this.userLogID.HeaderText = "User Log ID";
            this.userLogID.Name = "userLogID";
            this.userLogID.ReadOnly = true;
            this.userLogID.Width = 135;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 122;
            // 
            // info
            // 
            this.info.DataPropertyName = "info";
            this.info.HeaderText = "Info";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Width = 68;
            // 
            // dateTime
            // 
            this.dateTime.DataPropertyName = "dateTime";
            this.dateTime.HeaderText = "Date Time";
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 125;
            // 
            // DialogLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.dgvLoginList);
            this.Controls.Add(this.pTitleBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogLoginHistory";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogLoginHistory";
            this.pTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblRowsCount;
        private System.Windows.Forms.DataGridView dgvLoginList;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
    }
}