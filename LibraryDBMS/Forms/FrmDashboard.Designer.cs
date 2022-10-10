namespace LibraryDBMS.Forms
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblActivityCount = new System.Windows.Forms.Label();
            this.lblTodayActivities = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.chartBookBySubject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblUpTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBookTitleCount = new System.Windows.Forms.Label();
            this.lblTitles = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblBookDue = new System.Windows.Forms.Label();
            this.lblBooksDueToday = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblBookOverdueCount = new System.Windows.Forms.Label();
            this.lblBooksOverdue = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBookReturnCount = new System.Windows.Forms.Label();
            this.lblBooksReturn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBookLoanCount = new System.Windows.Forms.Label();
            this.lblBooksLoan = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookBySubject)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 678);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel18, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartBookBySubject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 678);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel18.Controls.Add(this.lblStudentCount);
            this.panel18.Controls.Add(this.lblStudents);
            this.panel18.Controls.Add(this.button4);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(10, 179);
            this.panel18.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(259, 150);
            this.panel18.TabIndex = 7;
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentCount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCount.ForeColor = System.Drawing.Color.White;
            this.lblStudentCount.Location = new System.Drawing.Point(12, 44);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(150, 60);
            this.lblStudentCount.TabIndex = 4;
            this.lblStudentCount.Text = "00";
            this.lblStudentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStudents.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStudents.Location = new System.Drawing.Point(2, 5);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(92, 27);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "Students";
            this.lblStudents.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel7.Controls.Add(this.lblActivityCount);
            this.panel7.Controls.Add(this.lblTodayActivities);
            this.panel7.Controls.Add(this.button8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(880, 179);
            this.panel7.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 150);
            this.panel7.TabIndex = 6;
            // 
            // lblActivityCount
            // 
            this.lblActivityCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActivityCount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityCount.ForeColor = System.Drawing.Color.White;
            this.lblActivityCount.Location = new System.Drawing.Point(12, 45);
            this.lblActivityCount.Name = "lblActivityCount";
            this.lblActivityCount.Size = new System.Drawing.Size(150, 60);
            this.lblActivityCount.TabIndex = 3;
            this.lblActivityCount.Text = "00";
            this.lblActivityCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayActivities
            // 
            this.lblTodayActivities.AutoSize = true;
            this.lblTodayActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTodayActivities.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayActivities.ForeColor = System.Drawing.Color.White;
            this.lblTodayActivities.Location = new System.Drawing.Point(3, 7);
            this.lblTodayActivities.Name = "lblTodayActivities";
            this.lblTodayActivities.Size = new System.Drawing.Size(157, 27);
            this.lblTodayActivities.TabIndex = 1;
            this.lblTodayActivities.Text = "Today Activities";
            this.lblTodayActivities.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel6.Controls.Add(this.lblRole);
            this.panel6.Controls.Add(this.lblUsername);
            this.panel6.Controls.Add(this.lblCurrentUser);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(880, 348);
            this.panel6.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 150);
            this.panel6.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(12, 74);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(150, 60);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 60);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Name";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurrentUser.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentUser.Location = new System.Drawing.Point(2, 5);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(133, 27);
            this.lblCurrentUser.TabIndex = 3;
            this.lblCurrentUser.Text = "Current User";
            this.lblCurrentUser.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblBooks);
            this.panel2.Controls.Add(this.lblBookCount);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 150);
            this.panel2.TabIndex = 0;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBooks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.ForeColor = System.Drawing.Color.White;
            this.lblBooks.Location = new System.Drawing.Point(3, 7);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(66, 27);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Books";
            this.lblBooks.Click += new System.EventHandler(this.Label_Click);
            // 
            // lblBookCount
            // 
            this.lblBookCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookCount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCount.ForeColor = System.Drawing.Color.White;
            this.lblBookCount.Location = new System.Drawing.Point(19, 45);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(150, 60);
            this.lblBookCount.TabIndex = 1;
            this.lblBookCount.Text = "00";
            this.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartBookBySubject
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBookBySubject.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chartBookBySubject, 2);
            this.chartBookBySubject.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBookBySubject.Legends.Add(legend1);
            this.chartBookBySubject.Location = new System.Drawing.Point(302, 179);
            this.chartBookBySubject.Margin = new System.Windows.Forms.Padding(15, 10, 14, 11);
            this.chartBookBySubject.Name = "chartBookBySubject";
            this.tableLayoutPanel1.SetRowSpan(this.chartBookBySubject, 3);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBookBySubject.Series.Add(series1);
            this.chartBookBySubject.Size = new System.Drawing.Size(545, 488);
            this.chartBookBySubject.TabIndex = 1;
            this.chartBookBySubject.Text = "chart1";
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Book Counts by Subjects";
            this.chartBookBySubject.Titles.Add(title1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel10.Controls.Add(this.lblUpTime);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.button10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(880, 517);
            this.panel10.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(262, 152);
            this.panel10.TabIndex = 4;
            // 
            // lblUpTime
            // 
            this.lblUpTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpTime.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpTime.ForeColor = System.Drawing.Color.White;
            this.lblUpTime.Location = new System.Drawing.Point(12, 45);
            this.lblUpTime.Name = "lblUpTime";
            this.lblUpTime.Size = new System.Drawing.Size(150, 60);
            this.lblUpTime.TabIndex = 4;
            this.lblUpTime.Text = "00:00:00";
            this.lblUpTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(2, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Up Time";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.lblBookTitleCount);
            this.panel3.Controls.Add(this.lblTitles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(13, 10, 12, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 150);
            this.panel3.TabIndex = 0;
            // 
            // lblBookTitleCount
            // 
            this.lblBookTitleCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookTitleCount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitleCount.ForeColor = System.Drawing.Color.White;
            this.lblBookTitleCount.Location = new System.Drawing.Point(14, 45);
            this.lblBookTitleCount.Name = "lblBookTitleCount";
            this.lblBookTitleCount.Size = new System.Drawing.Size(150, 60);
            this.lblBookTitleCount.TabIndex = 4;
            this.lblBookTitleCount.Text = "00";
            this.lblBookTitleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitles
            // 
            this.lblTitles.AutoSize = true;
            this.lblTitles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitles.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitles.Location = new System.Drawing.Point(2, 5);
            this.lblTitles.Name = "lblTitles";
            this.lblTitles.Size = new System.Drawing.Size(63, 27);
            this.lblTitles.TabIndex = 3;
            this.lblTitles.Text = "Titles";
            this.lblTitles.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel14.Controls.Add(this.lblBookDue);
            this.panel14.Controls.Add(this.lblBooksDueToday);
            this.panel14.Controls.Add(this.button6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(587, 10);
            this.panel14.Margin = new System.Windows.Forms.Padding(13, 10, 12, 9);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(262, 150);
            this.panel14.TabIndex = 0;
            // 
            // lblBookDue
            // 
            this.lblBookDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookDue.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookDue.ForeColor = System.Drawing.Color.White;
            this.lblBookDue.Location = new System.Drawing.Point(14, 45);
            this.lblBookDue.Name = "lblBookDue";
            this.lblBookDue.Size = new System.Drawing.Size(150, 60);
            this.lblBookDue.TabIndex = 3;
            this.lblBookDue.Text = "00";
            this.lblBookDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBooksDueToday
            // 
            this.lblBooksDueToday.AutoSize = true;
            this.lblBooksDueToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBooksDueToday.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksDueToday.ForeColor = System.Drawing.Color.White;
            this.lblBooksDueToday.Location = new System.Drawing.Point(3, 7);
            this.lblBooksDueToday.Name = "lblBooksDueToday";
            this.lblBooksDueToday.Size = new System.Drawing.Size(166, 27);
            this.lblBooksDueToday.TabIndex = 1;
            this.lblBooksDueToday.Text = "Books Due Today";
            this.lblBooksDueToday.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel16.Controls.Add(this.lblBookOverdueCount);
            this.panel16.Controls.Add(this.lblBooksOverdue);
            this.panel16.Controls.Add(this.button7);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(880, 10);
            this.panel16.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(262, 150);
            this.panel16.TabIndex = 0;
            // 
            // lblBookOverdueCount
            // 
            this.lblBookOverdueCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookOverdueCount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookOverdueCount.ForeColor = System.Drawing.Color.White;
            this.lblBookOverdueCount.Location = new System.Drawing.Point(12, 45);
            this.lblBookOverdueCount.Name = "lblBookOverdueCount";
            this.lblBookOverdueCount.Size = new System.Drawing.Size(150, 60);
            this.lblBookOverdueCount.TabIndex = 3;
            this.lblBookOverdueCount.Text = "00";
            this.lblBookOverdueCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBooksOverdue
            // 
            this.lblBooksOverdue.AutoSize = true;
            this.lblBooksOverdue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBooksOverdue.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksOverdue.ForeColor = System.Drawing.Color.White;
            this.lblBooksOverdue.Location = new System.Drawing.Point(3, 7);
            this.lblBooksOverdue.Name = "lblBooksOverdue";
            this.lblBooksOverdue.Size = new System.Drawing.Size(151, 27);
            this.lblBooksOverdue.TabIndex = 1;
            this.lblBooksOverdue.Text = "Books Overdue";
            this.lblBooksOverdue.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel5.Controls.Add(this.lblBookReturnCount);
            this.panel5.Controls.Add(this.lblBooksReturn);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 517);
            this.panel5.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 152);
            this.panel5.TabIndex = 0;
            // 
            // lblBookReturnCount
            // 
            this.lblBookReturnCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookReturnCount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookReturnCount.ForeColor = System.Drawing.Color.White;
            this.lblBookReturnCount.Location = new System.Drawing.Point(12, 46);
            this.lblBookReturnCount.Name = "lblBookReturnCount";
            this.lblBookReturnCount.Size = new System.Drawing.Size(150, 60);
            this.lblBookReturnCount.TabIndex = 4;
            this.lblBookReturnCount.Text = "00";
            this.lblBookReturnCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBooksReturn
            // 
            this.lblBooksReturn.AutoSize = true;
            this.lblBooksReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBooksReturn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBooksReturn.Location = new System.Drawing.Point(2, 5);
            this.lblBooksReturn.Name = "lblBooksReturn";
            this.lblBooksReturn.Size = new System.Drawing.Size(133, 27);
            this.lblBooksReturn.TabIndex = 3;
            this.lblBooksReturn.Text = "Books Return";
            this.lblBooksReturn.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.lblBookLoanCount);
            this.panel4.Controls.Add(this.lblBooksLoan);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 348);
            this.panel4.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 150);
            this.panel4.TabIndex = 0;
            // 
            // lblBookLoanCount
            // 
            this.lblBookLoanCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookLoanCount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookLoanCount.ForeColor = System.Drawing.Color.White;
            this.lblBookLoanCount.Location = new System.Drawing.Point(12, 45);
            this.lblBookLoanCount.Name = "lblBookLoanCount";
            this.lblBookLoanCount.Size = new System.Drawing.Size(150, 60);
            this.lblBookLoanCount.TabIndex = 4;
            this.lblBookLoanCount.Text = "00";
            this.lblBookLoanCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBooksLoan
            // 
            this.lblBooksLoan.AutoSize = true;
            this.lblBooksLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBooksLoan.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksLoan.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBooksLoan.Location = new System.Drawing.Point(2, 5);
            this.lblBooksLoan.Name = "lblBooksLoan";
            this.lblBooksLoan.Size = new System.Drawing.Size(116, 27);
            this.lblBooksLoan.TabIndex = 3;
            this.lblBooksLoan.Text = "Books Loan";
            this.lblBooksLoan.Click += new System.EventHandler(this.Label_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::LibraryDBMS.Properties.Resources.student_male_78px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.Location = new System.Drawing.Point(169, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 150);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::LibraryDBMS.Properties.Resources.todo_list_78px;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button8.Location = new System.Drawing.Point(172, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 150);
            this.button8.TabIndex = 4;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::LibraryDBMS.Properties.Resources.male_user_78px;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button9.Location = new System.Drawing.Point(172, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 150);
            this.button9.TabIndex = 5;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LibraryDBMS.Properties.Resources.book_78px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(169, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 150);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Right;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::LibraryDBMS.Properties.Resources.stopwatch_78px;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button10.Location = new System.Drawing.Point(172, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 152);
            this.button10.TabIndex = 5;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::LibraryDBMS.Properties.Resources.typography_78px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button5.Location = new System.Drawing.Point(172, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 150);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::LibraryDBMS.Properties.Resources.Clock_78px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button6.Location = new System.Drawing.Point(172, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 150);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::LibraryDBMS.Properties.Resources.expired_78px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button7.Location = new System.Drawing.Point(172, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 150);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::LibraryDBMS.Properties.Resources.return_book_78px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.Location = new System.Drawing.Point(169, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 152);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::LibraryDBMS.Properties.Resources.borrow_book_78px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.Location = new System.Drawing.Point(169, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 150);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 678);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookBySubject)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblBooksReturn;
        private System.Windows.Forms.Label lblBooksLoan;
        private System.Windows.Forms.Label lblTitles;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookBySubject;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblBooksDueToday;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblBooksOverdue;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblUpTime;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblBookTitleCount;
        private System.Windows.Forms.Label lblBookDue;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblBookOverdueCount;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblBookLoanCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBookReturnCount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblActivityCount;
        private System.Windows.Forms.Label lblTodayActivities;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button button4;
    }
}