namespace LibraryDBMS.Forms
{
    partial class DialogAddEditStudent
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
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.pTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.cbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.ForeColor = System.Drawing.SystemColors.Control;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(132, 197);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(266, 28);
            this.cbYear.TabIndex = 6;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(198, 165);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(79, 26);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(132, 165);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 26);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(19)))), ((int)(((byte)(5)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Image = global::LibraryDBMS.Properties.Resources.cancel_26px;
            this.btnCancel.Location = new System.Drawing.Point(33, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(365, 56);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "  Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveChanges.Image = global::LibraryDBMS.Properties.Resources.save_26px;
            this.btnSaveChanges.Location = new System.Drawing.Point(33, 345);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(160, 56);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "  Save Changes";
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.Button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Student ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Telephone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Major:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(132, 66);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(266, 26);
            this.txtStudentID.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(132, 263);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(266, 26);
            this.txtTel.TabIndex = 8;
            // 
            // txtMajor
            // 
            this.txtMajor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajor.Location = new System.Drawing.Point(132, 231);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(266, 26);
            this.txtMajor.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(132, 132);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(266, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(132, 99);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(266, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(414, 45);
            this.lblHeader.TabIndex = 33;
            this.lblHeader.Text = "  New Student";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(156)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Image = global::LibraryDBMS.Properties.Resources.clear_symbol_26px;
            this.btnClear.Location = new System.Drawing.Point(238, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 56);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "  Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pTitleBar.Controls.Add(this.btnClose);
            this.pTitleBar.Controls.Add(this.lblHeader);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(6, 3);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(414, 45);
            this.pTitleBar.TabIndex = 34;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LibraryDBMS.Properties.Resources.close_16px;
            this.btnClose.Location = new System.Drawing.Point(369, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 34;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 478);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(420, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 478);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 3);
            this.panel3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date Added:";
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.CustomFormat = "yyyy-MM-dd";
            this.dtpDateAdded.Enabled = false;
            this.dtpDateAdded.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateAdded.Location = new System.Drawing.Point(132, 295);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(266, 25);
            this.dtpDateAdded.TabIndex = 48;
            // 
            // DialogAddEditStudent
            // 
            this.AcceptButton = this.btnSaveChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(426, 487);
            this.Controls.Add(this.dtpDateAdded);
            this.Controls.Add(this.pTitleBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogAddEditStudent";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIalog Add/Edit Borrower";
            this.pTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
    }
}