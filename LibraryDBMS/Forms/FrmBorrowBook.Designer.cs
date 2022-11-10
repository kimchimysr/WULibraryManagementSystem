namespace LibraryDBMS.Forms
{
    partial class FrmBorrowBook
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
            this.dgvBorrowList = new System.Windows.Forms.DataGridView();
            this.borrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdueFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblBookDueCount = new System.Windows.Forms.Label();
            this.lblBookOverdueCount = new System.Windows.Forms.Label();
            this.lblBookLoanCount = new System.Windows.Forms.Label();
            this.lblBookLostCount = new System.Windows.Forms.Label();
            this.tlpButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblRowsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).BeginInit();
            this.tlpButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBorrowList
            // 
            this.dgvBorrowList.AllowUserToAddRows = false;
            this.dgvBorrowList.AllowUserToDeleteRows = false;
            this.dgvBorrowList.AllowUserToResizeColumns = false;
            this.dgvBorrowList.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBorrowList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBorrowList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBorrowList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBorrowList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBorrowList.ColumnHeadersHeight = 30;
            this.dgvBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBorrowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowID,
            this.bookID,
            this.title,
            this.studentID,
            this.fullName,
            this.loanStatusName,
            this.dateLoan,
            this.dateDue,
            this.dateReturned,
            this.overdueFine});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBorrowList.EnableHeadersVisualStyles = false;
            this.dgvBorrowList.Location = new System.Drawing.Point(15, 92);
            this.dgvBorrowList.MultiSelect = false;
            this.dgvBorrowList.Name = "dgvBorrowList";
            this.dgvBorrowList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBorrowList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBorrowList.Size = new System.Drawing.Size(1159, 383);
            this.dgvBorrowList.TabIndex = 38;
            this.dgvBorrowList.TabStop = false;
            this.dgvBorrowList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowList_CellClick);
            // 
            // borrowID
            // 
            this.borrowID.DataPropertyName = "borrowID";
            this.borrowID.FillWeight = 89.60574F;
            this.borrowID.HeaderText = "Borrow ID";
            this.borrowID.Name = "borrowID";
            this.borrowID.ReadOnly = true;
            this.borrowID.Width = 92;
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "bookID";
            this.bookID.FillWeight = 90.50163F;
            this.bookID.HeaderText = "Book ID";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            this.bookID.Width = 77;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.FillWeight = 125.4476F;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // studentID
            // 
            this.studentID.DataPropertyName = "studentID";
            this.studentID.FillWeight = 89.60835F;
            this.studentID.HeaderText = "Student ID";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            this.studentID.Width = 96;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.FillWeight = 136.2011F;
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 93;
            // 
            // loanStatusName
            // 
            this.loanStatusName.DataPropertyName = "loanStatusName";
            this.loanStatusName.FillWeight = 87.81313F;
            this.loanStatusName.HeaderText = "Status";
            this.loanStatusName.Name = "loanStatusName";
            this.loanStatusName.ReadOnly = true;
            this.loanStatusName.Width = 70;
            // 
            // dateLoan
            // 
            this.dateLoan.DataPropertyName = "dateLoan";
            this.dateLoan.FillWeight = 105.7344F;
            this.dateLoan.HeaderText = "Date Loan";
            this.dateLoan.Name = "dateLoan";
            this.dateLoan.ReadOnly = true;
            this.dateLoan.Width = 92;
            // 
            // dateDue
            // 
            this.dateDue.DataPropertyName = "dateDue";
            this.dateDue.FillWeight = 87.81048F;
            this.dateDue.HeaderText = "Date Due";
            this.dateDue.Name = "dateDue";
            this.dateDue.ReadOnly = true;
            this.dateDue.Width = 86;
            // 
            // dateReturned
            // 
            this.dateReturned.DataPropertyName = "dateReturned";
            this.dateReturned.FillWeight = 98.56568F;
            this.dateReturned.HeaderText = "Date Returned";
            this.dateReturned.Name = "dateReturned";
            this.dateReturned.ReadOnly = true;
            this.dateReturned.Width = 120;
            // 
            // overdueFine
            // 
            this.overdueFine.DataPropertyName = "overdueFine";
            this.overdueFine.FillWeight = 88.71188F;
            this.overdueFine.HeaderText = "Overdue Fine";
            this.overdueFine.Name = "overdueFine";
            this.overdueFine.ReadOnly = true;
            this.overdueFine.Width = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fitler Status By:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(11, 478);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(102, 20);
            this.lblRecordCount.TabIndex = 50;
            this.lblRecordCount.Text = "Total Record: ";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(780, 59);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(98, 26);
            this.dtpToDate.TabIndex = 59;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(676, 59);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(98, 26);
            this.dtpFromDate.TabIndex = 60;
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.cbSearchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchBy.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchBy.ForeColor = System.Drawing.SystemColors.Control;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Location = new System.Drawing.Point(142, 58);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(121, 28);
            this.cbSearchBy.TabIndex = 58;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::LibraryDBMS.Properties.Resources.search_26px;
            this.btnSearch.Location = new System.Drawing.Point(430, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 34);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search Record";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(776, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "To Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "From Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(138, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 57;
            this.label10.Text = "Search By:";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.Location = new System.Drawing.Point(269, 59);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(155, 26);
            this.txtSearchValue.TabIndex = 51;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
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
            this.btnFilter.Location = new System.Drawing.Point(884, 55);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(71, 34);
            this.btnFilter.TabIndex = 53;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::LibraryDBMS.Properties.Resources.refresh_26px;
            this.btnRefresh.Location = new System.Drawing.Point(588, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 34);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.Button_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(15, 58);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 28);
            this.cbStatus.TabIndex = 61;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lblBookDueCount
            // 
            this.lblBookDueCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBookDueCount.AutoSize = true;
            this.lblBookDueCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookDueCount.Location = new System.Drawing.Point(434, 478);
            this.lblBookDueCount.Name = "lblBookDueCount";
            this.lblBookDueCount.Size = new System.Drawing.Size(82, 20);
            this.lblBookDueCount.TabIndex = 50;
            this.lblBookDueCount.Text = "Book Due: ";
            this.lblBookDueCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookOverdueCount
            // 
            this.lblBookOverdueCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBookOverdueCount.AutoSize = true;
            this.lblBookOverdueCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookOverdueCount.Location = new System.Drawing.Point(632, 478);
            this.lblBookOverdueCount.Name = "lblBookOverdueCount";
            this.lblBookOverdueCount.Size = new System.Drawing.Size(112, 20);
            this.lblBookOverdueCount.TabIndex = 50;
            this.lblBookOverdueCount.Text = "Book Overdue: ";
            this.lblBookOverdueCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookLoanCount
            // 
            this.lblBookLoanCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBookLoanCount.AutoSize = true;
            this.lblBookLoanCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookLoanCount.Location = new System.Drawing.Point(229, 478);
            this.lblBookLoanCount.Name = "lblBookLoanCount";
            this.lblBookLoanCount.Size = new System.Drawing.Size(89, 20);
            this.lblBookLoanCount.TabIndex = 50;
            this.lblBookLoanCount.Text = "Book Loan: ";
            this.lblBookLoanCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookLostCount
            // 
            this.lblBookLostCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBookLostCount.AutoSize = true;
            this.lblBookLostCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookLostCount.Location = new System.Drawing.Point(860, 478);
            this.lblBookLostCount.Name = "lblBookLostCount";
            this.lblBookLostCount.Size = new System.Drawing.Size(85, 20);
            this.lblBookLostCount.TabIndex = 50;
            this.lblBookLostCount.Text = "Book Lost: ";
            this.lblBookLostCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpButtonContainer
            // 
            this.tlpButtonContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtonContainer.ColumnCount = 4;
            this.tlpButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpButtonContainer.Controls.Add(this.btnAdd, 0, 0);
            this.tlpButtonContainer.Controls.Add(this.btnDelete, 2, 0);
            this.tlpButtonContainer.Controls.Add(this.btnView, 3, 0);
            this.tlpButtonContainer.Controls.Add(this.btnEdit, 1, 0);
            this.tlpButtonContainer.Location = new System.Drawing.Point(15, 553);
            this.tlpButtonContainer.Name = "tlpButtonContainer";
            this.tlpButtonContainer.RowCount = 1;
            this.tlpButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonContainer.Size = new System.Drawing.Size(1159, 60);
            this.tlpButtonContainer.TabIndex = 62;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::LibraryDBMS.Properties.Resources.add_32px;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0, 0, 39, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 60);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "  Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(19)))), ((int)(((byte)(5)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Image = global::LibraryDBMS.Properties.Resources.trash_32px;
            this.btnDelete.Location = new System.Drawing.Point(606, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(28, 0, 11, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(250, 60);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(156)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Control;
            this.btnView.Image = global::LibraryDBMS.Properties.Resources.view_32px;
            this.btnView.Location = new System.Drawing.Point(909, 0);
            this.btnView.Margin = new System.Windows.Forms.Padding(42, 0, 0, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(250, 60);
            this.btnView.TabIndex = 18;
            this.btnView.Text = "  View Information";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Image = global::LibraryDBMS.Properties.Resources.edit_32px;
            this.btnEdit.Location = new System.Drawing.Point(303, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 0, 25, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(250, 60);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "  Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Image = global::LibraryDBMS.Properties.Resources.print_26px;
            this.btnPrint.Location = new System.Drawing.Point(961, 55);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(152, 34);
            this.btnPrint.TabIndex = 63;
            this.btnPrint.Text = " Print Preview";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRowsCount.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.lblRowsCount.Location = new System.Drawing.Point(992, 478);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(180, 20);
            this.lblRowsCount.TabIndex = 64;
            this.lblRowsCount.Text = "Display Result: ";
            this.lblRowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tlpButtonContainer);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblBookOverdueCount);
            this.Controls.Add(this.lblBookLoanCount);
            this.Controls.Add(this.lblBookDueCount);
            this.Controls.Add(this.lblBookLostCount);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvBorrowList);
            this.Controls.Add(this.label4);
            this.Name = "FrmBorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Book Loan/Return";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowList)).EndInit();
            this.tlpButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBorrowList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblBookDueCount;
        private System.Windows.Forms.Label lblBookOverdueCount;
        private System.Windows.Forms.Label lblBookLoanCount;
        private System.Windows.Forms.Label lblBookLostCount;
        private System.Windows.Forms.TableLayoutPanel tlpButtonContainer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblRowsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdueFine;
    }
}