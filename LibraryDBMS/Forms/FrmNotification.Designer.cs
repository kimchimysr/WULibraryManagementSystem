namespace LibraryDBMS.Forms
{
    partial class FrmNotification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pBookDue = new System.Windows.Forms.Panel();
            this.dgvBookDue = new System.Windows.Forms.DataGridView();
            this.borrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBookDue = new System.Windows.Forms.Button();
            this.pBookDueTmr = new System.Windows.Forms.Panel();
            this.dgvBookDueTmr = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBookDueTmr = new System.Windows.Forms.Button();
            this.pBookOverdue = new System.Windows.Forms.Panel();
            this.dgvBookOverdue = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBookOverdue = new System.Windows.Forms.Button();
            this.flpContainer.SuspendLayout();
            this.pBookDue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDue)).BeginInit();
            this.pBookDueTmr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDueTmr)).BeginInit();
            this.pBookOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookOverdue)).BeginInit();
            this.SuspendLayout();
            // 
            // flpContainer
            // 
            this.flpContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpContainer.BackColor = System.Drawing.Color.White;
            this.flpContainer.Controls.Add(this.pBookDue);
            this.flpContainer.Controls.Add(this.pBookDueTmr);
            this.flpContainer.Controls.Add(this.pBookOverdue);
            this.flpContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContainer.Location = new System.Drawing.Point(9, 45);
            this.flpContainer.Name = "flpContainer";
            this.flpContainer.Size = new System.Drawing.Size(1151, 630);
            this.flpContainer.TabIndex = 0;
            this.flpContainer.WrapContents = false;
            // 
            // pBookDue
            // 
            this.pBookDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookDue.Controls.Add(this.dgvBookDue);
            this.pBookDue.Controls.Add(this.btnBookDue);
            this.pBookDue.Location = new System.Drawing.Point(3, 3);
            this.pBookDue.MaximumSize = new System.Drawing.Size(0, 300);
            this.pBookDue.MinimumSize = new System.Drawing.Size(1145, 35);
            this.pBookDue.Name = "pBookDue";
            this.pBookDue.Size = new System.Drawing.Size(1145, 35);
            this.pBookDue.TabIndex = 1;
            // 
            // dgvBookDue
            // 
            this.dgvBookDue.AllowUserToAddRows = false;
            this.dgvBookDue.AllowUserToDeleteRows = false;
            this.dgvBookDue.AllowUserToResizeColumns = false;
            this.dgvBookDue.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBookDue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookDue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookDue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookDue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBookDue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookDue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookDue.ColumnHeadersHeight = 30;
            this.dgvBookDue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookDue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowID,
            this.bookID,
            this.title,
            this.studentID,
            this.fullName,
            this.loanStatusName,
            this.dateLoan,
            this.dateDue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookDue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookDue.EnableHeadersVisualStyles = false;
            this.dgvBookDue.Location = new System.Drawing.Point(3, 35);
            this.dgvBookDue.MultiSelect = false;
            this.dgvBookDue.Name = "dgvBookDue";
            this.dgvBookDue.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookDue.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookDue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBookDue.Size = new System.Drawing.Size(1139, 262);
            this.dgvBookDue.TabIndex = 39;
            this.dgvBookDue.TabStop = false;
            // 
            // borrowID
            // 
            this.borrowID.DataPropertyName = "borrowID";
            this.borrowID.HeaderText = "Borrow ID";
            this.borrowID.Name = "borrowID";
            this.borrowID.ReadOnly = true;
            this.borrowID.Width = 92;
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "bookID";
            this.bookID.HeaderText = "Book ID";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            this.bookID.Width = 77;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // studentID
            // 
            this.studentID.DataPropertyName = "studentID";
            this.studentID.HeaderText = "Student ID";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            this.studentID.Width = 96;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 93;
            // 
            // loanStatusName
            // 
            this.loanStatusName.DataPropertyName = "loanStatusName";
            this.loanStatusName.HeaderText = "Status";
            this.loanStatusName.Name = "loanStatusName";
            this.loanStatusName.ReadOnly = true;
            this.loanStatusName.Width = 70;
            // 
            // dateLoan
            // 
            this.dateLoan.DataPropertyName = "dateLoan";
            this.dateLoan.HeaderText = "Date Loan";
            this.dateLoan.Name = "dateLoan";
            this.dateLoan.ReadOnly = true;
            this.dateLoan.Width = 92;
            // 
            // dateDue
            // 
            this.dateDue.DataPropertyName = "dateDue";
            this.dateDue.HeaderText = "Date Due";
            this.dateDue.Name = "dateDue";
            this.dateDue.ReadOnly = true;
            this.dateDue.Width = 86;
            // 
            // btnBookDue
            // 
            this.btnBookDue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnBookDue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookDue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookDue.Image = global::LibraryDBMS.Properties.Resources.expand_arrow_26px;
            this.btnBookDue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookDue.Location = new System.Drawing.Point(0, 0);
            this.btnBookDue.Name = "btnBookDue";
            this.btnBookDue.Size = new System.Drawing.Size(1145, 35);
            this.btnBookDue.TabIndex = 0;
            this.btnBookDue.Text = "Book Due Today (0)";
            this.btnBookDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookDue.UseVisualStyleBackColor = false;
            this.btnBookDue.Click += new System.EventHandler(this.Button_Click);
            // 
            // pBookDueTmr
            // 
            this.pBookDueTmr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookDueTmr.Controls.Add(this.dgvBookDueTmr);
            this.pBookDueTmr.Controls.Add(this.btnBookDueTmr);
            this.pBookDueTmr.Location = new System.Drawing.Point(3, 44);
            this.pBookDueTmr.MaximumSize = new System.Drawing.Size(0, 300);
            this.pBookDueTmr.MinimumSize = new System.Drawing.Size(1145, 35);
            this.pBookDueTmr.Name = "pBookDueTmr";
            this.pBookDueTmr.Size = new System.Drawing.Size(1145, 35);
            this.pBookDueTmr.TabIndex = 41;
            // 
            // dgvBookDueTmr
            // 
            this.dgvBookDueTmr.AllowUserToAddRows = false;
            this.dgvBookDueTmr.AllowUserToDeleteRows = false;
            this.dgvBookDueTmr.AllowUserToResizeColumns = false;
            this.dgvBookDueTmr.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBookDueTmr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBookDueTmr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookDueTmr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookDueTmr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBookDueTmr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookDueTmr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBookDueTmr.ColumnHeadersHeight = 30;
            this.dgvBookDueTmr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookDueTmr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookDueTmr.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBookDueTmr.EnableHeadersVisualStyles = false;
            this.dgvBookDueTmr.Location = new System.Drawing.Point(3, 35);
            this.dgvBookDueTmr.MultiSelect = false;
            this.dgvBookDueTmr.Name = "dgvBookDueTmr";
            this.dgvBookDueTmr.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookDueTmr.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBookDueTmr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBookDueTmr.Size = new System.Drawing.Size(1139, 262);
            this.dgvBookDueTmr.TabIndex = 39;
            this.dgvBookDueTmr.TabStop = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "borrowID";
            this.dataGridViewTextBoxColumn11.HeaderText = "Borrow ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 92;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "bookID";
            this.dataGridViewTextBoxColumn12.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 77;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn13.HeaderText = "Title";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "studentID";
            this.dataGridViewTextBoxColumn14.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 96;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "fullName";
            this.dataGridViewTextBoxColumn15.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 93;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "loanStatusName";
            this.dataGridViewTextBoxColumn16.HeaderText = "Status";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 70;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "dateLoan";
            this.dataGridViewTextBoxColumn17.HeaderText = "Date Loan";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 92;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "dateDue";
            this.dataGridViewTextBoxColumn18.HeaderText = "Date Due";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 86;
            // 
            // btnBookDueTmr
            // 
            this.btnBookDueTmr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookDueTmr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnBookDueTmr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookDueTmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDueTmr.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDueTmr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookDueTmr.Image = global::LibraryDBMS.Properties.Resources.expand_arrow_26px;
            this.btnBookDueTmr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookDueTmr.Location = new System.Drawing.Point(0, 0);
            this.btnBookDueTmr.Name = "btnBookDueTmr";
            this.btnBookDueTmr.Size = new System.Drawing.Size(1145, 35);
            this.btnBookDueTmr.TabIndex = 0;
            this.btnBookDueTmr.Text = "Book Due Tomorrow (0)";
            this.btnBookDueTmr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookDueTmr.UseVisualStyleBackColor = false;
            this.btnBookDueTmr.Click += new System.EventHandler(this.Button_Click);
            // 
            // pBookOverdue
            // 
            this.pBookOverdue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pBookOverdue.Controls.Add(this.dgvBookOverdue);
            this.pBookOverdue.Controls.Add(this.btnBookOverdue);
            this.pBookOverdue.Location = new System.Drawing.Point(3, 85);
            this.pBookOverdue.MaximumSize = new System.Drawing.Size(0, 300);
            this.pBookOverdue.MinimumSize = new System.Drawing.Size(1145, 35);
            this.pBookOverdue.Name = "pBookOverdue";
            this.pBookOverdue.Size = new System.Drawing.Size(1145, 35);
            this.pBookOverdue.TabIndex = 40;
            // 
            // dgvBookOverdue
            // 
            this.dgvBookOverdue.AllowUserToAddRows = false;
            this.dgvBookOverdue.AllowUserToDeleteRows = false;
            this.dgvBookOverdue.AllowUserToResizeColumns = false;
            this.dgvBookOverdue.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBookOverdue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBookOverdue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookOverdue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookOverdue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBookOverdue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookOverdue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBookOverdue.ColumnHeadersHeight = 30;
            this.dgvBookOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookOverdue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookOverdue.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBookOverdue.EnableHeadersVisualStyles = false;
            this.dgvBookOverdue.Location = new System.Drawing.Point(3, 35);
            this.dgvBookOverdue.MultiSelect = false;
            this.dgvBookOverdue.Name = "dgvBookOverdue";
            this.dgvBookOverdue.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookOverdue.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBookOverdue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBookOverdue.Size = new System.Drawing.Size(1139, 262);
            this.dgvBookOverdue.TabIndex = 39;
            this.dgvBookOverdue.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "borrowID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Borrow ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 92;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bookID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "studentID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fullName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 93;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "loanStatusName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "dateLoan";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date Loan";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 92;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dateDue";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date Due";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 86;
            // 
            // btnBookOverdue
            // 
            this.btnBookOverdue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookOverdue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnBookOverdue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookOverdue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookOverdue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBookOverdue.Image = global::LibraryDBMS.Properties.Resources.expand_arrow_26px;
            this.btnBookOverdue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookOverdue.Location = new System.Drawing.Point(0, 0);
            this.btnBookOverdue.Name = "btnBookOverdue";
            this.btnBookOverdue.Size = new System.Drawing.Size(1145, 35);
            this.btnBookOverdue.TabIndex = 0;
            this.btnBookOverdue.Text = "Book Overdue (0)";
            this.btnBookOverdue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookOverdue.UseVisualStyleBackColor = false;
            this.btnBookOverdue.Click += new System.EventHandler(this.Button_Click);
            // 
            // FrmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 687);
            this.Controls.Add(this.flpContainer);
            this.Name = "FrmNotification";
            this.Text = "Notification";
            this.flpContainer.ResumeLayout(false);
            this.pBookDue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDue)).EndInit();
            this.pBookDueTmr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDueTmr)).EndInit();
            this.pBookOverdue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookOverdue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContainer;
        private System.Windows.Forms.Button btnBookDue;
        private System.Windows.Forms.Panel pBookDue;
        private System.Windows.Forms.DataGridView dgvBookDue;
        private System.Windows.Forms.Panel pBookOverdue;
        private System.Windows.Forms.DataGridView dgvBookOverdue;
        private System.Windows.Forms.Button btnBookOverdue;
        private System.Windows.Forms.Panel pBookDueTmr;
        private System.Windows.Forms.DataGridView dgvBookDueTmr;
        private System.Windows.Forms.Button btnBookDueTmr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDue;
    }
}