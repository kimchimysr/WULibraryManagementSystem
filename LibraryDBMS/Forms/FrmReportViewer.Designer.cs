namespace LibraryDBMS
{
    partial class FrmReportViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbReportsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbFilterBy = new System.Windows.Forms.GroupBox();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbYearly = new System.Windows.Forms.RadioButton();
            this.rbDateRange = new System.Windows.Forms.RadioButton();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpYearInMonthly = new System.Windows.Forms.DateTimePicker();
            this.pMonthlyFilter = new System.Windows.Forms.Panel();
            this.pYearlyFilter = new System.Windows.Forms.Panel();
            this.dtpYearInYearly = new System.Windows.Forms.DateTimePicker();
            this.pDateRangeFilter = new System.Windows.Forms.Panel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFilterBy.SuspendLayout();
            this.pMonthlyFilter.SuspendLayout();
            this.pYearlyFilter.SuspendLayout();
            this.pDateRangeFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource5.Name = "Borrower";
            reportDataSource5.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(12, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1160, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbReportsList
            // 
            this.cbReportsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.cbReportsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReportsList.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbReportsList.ForeColor = System.Drawing.SystemColors.Control;
            this.cbReportsList.FormattingEnabled = true;
            this.cbReportsList.Location = new System.Drawing.Point(130, 73);
            this.cbReportsList.Name = "cbReportsList";
            this.cbReportsList.Size = new System.Drawing.Size(225, 28);
            this.cbReportsList.TabIndex = 1;
            this.cbReportsList.SelectedIndexChanged += new System.EventHandler(this.cbReportsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Report:";
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
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(361, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 38);
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.Text = "  Reset";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbFilterBy
            // 
            this.gbFilterBy.Controls.Add(this.pMonthlyFilter);
            this.gbFilterBy.Controls.Add(this.pYearlyFilter);
            this.gbFilterBy.Controls.Add(this.btnFilter);
            this.gbFilterBy.Controls.Add(this.rbDateRange);
            this.gbFilterBy.Controls.Add(this.rbYearly);
            this.gbFilterBy.Controls.Add(this.rbMonthly);
            this.gbFilterBy.Controls.Add(this.pDateRangeFilter);
            this.gbFilterBy.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilterBy.Location = new System.Drawing.Point(553, 16);
            this.gbFilterBy.Name = "gbFilterBy";
            this.gbFilterBy.Size = new System.Drawing.Size(386, 96);
            this.gbFilterBy.TabIndex = 56;
            this.gbFilterBy.TabStop = false;
            this.gbFilterBy.Text = "Advance Filter";
            this.gbFilterBy.Visible = false;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Checked = true;
            this.rbMonthly.Location = new System.Drawing.Point(6, 22);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(71, 22);
            this.rbMonthly.TabIndex = 0;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // rbYearly
            // 
            this.rbYearly.AutoSize = true;
            this.rbYearly.Location = new System.Drawing.Point(83, 22);
            this.rbYearly.Name = "rbYearly";
            this.rbYearly.Size = new System.Drawing.Size(60, 22);
            this.rbYearly.TabIndex = 0;
            this.rbYearly.Text = "Yearly";
            this.rbYearly.UseVisualStyleBackColor = true;
            this.rbYearly.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // rbDateRange
            // 
            this.rbDateRange.AutoSize = true;
            this.rbDateRange.Location = new System.Drawing.Point(149, 22);
            this.rbDateRange.Name = "rbDateRange";
            this.rbDateRange.Size = new System.Drawing.Size(93, 22);
            this.rbDateRange.TabIndex = 0;
            this.rbDateRange.Text = "Date Range";
            this.rbDateRange.UseVisualStyleBackColor = true;
            this.rbDateRange.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonth.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbMonth.ForeColor = System.Drawing.SystemColors.Control;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(3, 3);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(175, 28);
            this.cbMonth.TabIndex = 1;
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
            this.btnFilter.Location = new System.Drawing.Point(289, 55);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 34);
            this.btnFilter.TabIndex = 57;
            this.btnFilter.Text = "  Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpYearInMonthly
            // 
            this.dtpYearInMonthly.CustomFormat = "yyyy";
            this.dtpYearInMonthly.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYearInMonthly.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearInMonthly.Location = new System.Drawing.Point(197, 4);
            this.dtpYearInMonthly.Name = "dtpYearInMonthly";
            this.dtpYearInMonthly.Size = new System.Drawing.Size(74, 26);
            this.dtpYearInMonthly.TabIndex = 58;
            this.dtpYearInMonthly.Value = new System.DateTime(2022, 11, 27, 18, 31, 42, 0);
            // 
            // pMonthlyFilter
            // 
            this.pMonthlyFilter.Controls.Add(this.dtpYearInMonthly);
            this.pMonthlyFilter.Controls.Add(this.cbMonth);
            this.pMonthlyFilter.Location = new System.Drawing.Point(6, 53);
            this.pMonthlyFilter.Name = "pMonthlyFilter";
            this.pMonthlyFilter.Size = new System.Drawing.Size(277, 37);
            this.pMonthlyFilter.TabIndex = 57;
            // 
            // pYearlyFilter
            // 
            this.pYearlyFilter.Controls.Add(this.dtpYearInYearly);
            this.pYearlyFilter.Location = new System.Drawing.Point(6, 53);
            this.pYearlyFilter.Name = "pYearlyFilter";
            this.pYearlyFilter.Size = new System.Drawing.Size(277, 37);
            this.pYearlyFilter.TabIndex = 57;
            // 
            // dtpYearInYearly
            // 
            this.dtpYearInYearly.CustomFormat = "yyyy";
            this.dtpYearInYearly.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYearInYearly.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearInYearly.Location = new System.Drawing.Point(3, 3);
            this.dtpYearInYearly.Name = "dtpYearInYearly";
            this.dtpYearInYearly.Size = new System.Drawing.Size(74, 26);
            this.dtpYearInYearly.TabIndex = 58;
            this.dtpYearInYearly.Value = new System.DateTime(2022, 11, 27, 18, 31, 42, 0);
            // 
            // pDateRangeFilter
            // 
            this.pDateRangeFilter.Controls.Add(this.label2);
            this.pDateRangeFilter.Controls.Add(this.dtpToDate);
            this.pDateRangeFilter.Controls.Add(this.dtpFromDate);
            this.pDateRangeFilter.Location = new System.Drawing.Point(6, 53);
            this.pDateRangeFilter.Name = "pDateRangeFilter";
            this.pDateRangeFilter.Size = new System.Drawing.Size(277, 37);
            this.pDateRangeFilter.TabIndex = 57;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(131, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(98, 26);
            this.dtpToDate.TabIndex = 8;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(3, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(98, 26);
            this.dtpFromDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "_";
            // 
            // FrmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 707);
            this.Controls.Add(this.gbFilterBy);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbReportsList);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportViewer";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FrmReportViewer_Load);
            this.gbFilterBy.ResumeLayout(false);
            this.gbFilterBy.PerformLayout();
            this.pMonthlyFilter.ResumeLayout(false);
            this.pYearlyFilter.ResumeLayout(false);
            this.pDateRangeFilter.ResumeLayout(false);
            this.pDateRangeFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbReportsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbFilterBy;
        private System.Windows.Forms.RadioButton rbDateRange;
        private System.Windows.Forms.RadioButton rbYearly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpYearInMonthly;
        private System.Windows.Forms.Panel pMonthlyFilter;
        private System.Windows.Forms.Panel pYearlyFilter;
        private System.Windows.Forms.DateTimePicker dtpYearInYearly;
        private System.Windows.Forms.Panel pDateRangeFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
    }
}