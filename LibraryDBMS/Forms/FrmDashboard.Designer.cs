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
            this.pStudents = new System.Windows.Forms.Panel();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.btnStudentsIcon = new System.Windows.Forms.Button();
            this.pActivities = new System.Windows.Forms.Panel();
            this.lblActivityCount = new System.Windows.Forms.Label();
            this.lblTodayActivities = new System.Windows.Forms.Label();
            this.btnTodayActivitiesIcon = new System.Windows.Forms.Button();
            this.pCurrentUser = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnCurrentUserIcon = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pBooks = new System.Windows.Forms.Panel();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.btnBooksIcon = new System.Windows.Forms.Button();
            this.chartBookBySubject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pUptime = new System.Windows.Forms.Panel();
            this.lblUpTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.pTitles = new System.Windows.Forms.Panel();
            this.btnTitlesIcon = new System.Windows.Forms.Button();
            this.lblBookTitleCount = new System.Windows.Forms.Label();
            this.lblTitles = new System.Windows.Forms.Label();
            this.pDueTodayBooks = new System.Windows.Forms.Panel();
            this.lblBookDue = new System.Windows.Forms.Label();
            this.lblBooksDueToday = new System.Windows.Forms.Label();
            this.btnBooksDueTodayIcon = new System.Windows.Forms.Button();
            this.pOverdueBooks = new System.Windows.Forms.Panel();
            this.lblBookOverdueCount = new System.Windows.Forms.Label();
            this.lblOverdueBooks = new System.Windows.Forms.Label();
            this.btnOverdueBooksIcon = new System.Windows.Forms.Button();
            this.pReturnedBooks = new System.Windows.Forms.Panel();
            this.lblBookReturnCount = new System.Windows.Forms.Label();
            this.lblReturnedBooks = new System.Windows.Forms.Label();
            this.btnReturnedBooksIcon = new System.Windows.Forms.Button();
            this.pBorrowedBooks = new System.Windows.Forms.Panel();
            this.lblBookLoanCount = new System.Windows.Forms.Label();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.btnBorrowedBooksIcon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pStudents.SuspendLayout();
            this.pActivities.SuspendLayout();
            this.pCurrentUser.SuspendLayout();
            this.pBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookBySubject)).BeginInit();
            this.pUptime.SuspendLayout();
            this.pTitles.SuspendLayout();
            this.pDueTodayBooks.SuspendLayout();
            this.pOverdueBooks.SuspendLayout();
            this.pReturnedBooks.SuspendLayout();
            this.pBorrowedBooks.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.pStudents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pActivities, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pCurrentUser, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pBooks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartBookBySubject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pUptime, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pTitles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pDueTodayBooks, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pOverdueBooks, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pReturnedBooks, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pBorrowedBooks, 0, 2);
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
            // pStudents
            // 
            this.pStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pStudents.Controls.Add(this.lblStudentCount);
            this.pStudents.Controls.Add(this.lblStudents);
            this.pStudents.Controls.Add(this.btnStudentsIcon);
            this.pStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStudents.Location = new System.Drawing.Point(10, 179);
            this.pStudents.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.pStudents.Name = "pStudents";
            this.pStudents.Size = new System.Drawing.Size(259, 150);
            this.pStudents.TabIndex = 7;
            this.pStudents.Click += new System.EventHandler(this.Control_Click);
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
            this.lblStudentCount.Click += new System.EventHandler(this.Control_Click);
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
            this.lblStudents.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnStudentsIcon
            // 
            this.btnStudentsIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStudentsIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnStudentsIcon.FlatAppearance.BorderSize = 0;
            this.btnStudentsIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnStudentsIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnStudentsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentsIcon.Image = global::LibraryDBMS.Properties.Resources.student_male_78px;
            this.btnStudentsIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStudentsIcon.Location = new System.Drawing.Point(169, 0);
            this.btnStudentsIcon.Name = "btnStudentsIcon";
            this.btnStudentsIcon.Size = new System.Drawing.Size(90, 150);
            this.btnStudentsIcon.TabIndex = 5;
            this.btnStudentsIcon.UseVisualStyleBackColor = true;
            this.btnStudentsIcon.Click += new System.EventHandler(this.Control_Click);
            // 
            // pActivities
            // 
            this.pActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pActivities.Controls.Add(this.lblActivityCount);
            this.pActivities.Controls.Add(this.lblTodayActivities);
            this.pActivities.Controls.Add(this.btnTodayActivitiesIcon);
            this.pActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pActivities.Location = new System.Drawing.Point(880, 179);
            this.pActivities.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.pActivities.Name = "pActivities";
            this.pActivities.Size = new System.Drawing.Size(262, 150);
            this.pActivities.TabIndex = 6;
            this.pActivities.Click += new System.EventHandler(this.Control_Click);
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
            this.lblActivityCount.Click += new System.EventHandler(this.Control_Click);
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
            this.lblTodayActivities.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnTodayActivitiesIcon
            // 
            this.btnTodayActivitiesIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTodayActivitiesIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnTodayActivitiesIcon.FlatAppearance.BorderSize = 0;
            this.btnTodayActivitiesIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnTodayActivitiesIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnTodayActivitiesIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodayActivitiesIcon.Image = global::LibraryDBMS.Properties.Resources.todo_list_78px;
            this.btnTodayActivitiesIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTodayActivitiesIcon.Location = new System.Drawing.Point(172, 0);
            this.btnTodayActivitiesIcon.Name = "btnTodayActivitiesIcon";
            this.btnTodayActivitiesIcon.Size = new System.Drawing.Size(90, 150);
            this.btnTodayActivitiesIcon.TabIndex = 4;
            this.btnTodayActivitiesIcon.UseVisualStyleBackColor = true;
            this.btnTodayActivitiesIcon.Click += new System.EventHandler(this.Control_Click);
            // 
            // pCurrentUser
            // 
            this.pCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pCurrentUser.Controls.Add(this.lblRole);
            this.pCurrentUser.Controls.Add(this.lblCurrentUser);
            this.pCurrentUser.Controls.Add(this.btnCurrentUserIcon);
            this.pCurrentUser.Controls.Add(this.lblUsername);
            this.pCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCurrentUser.Location = new System.Drawing.Point(880, 348);
            this.pCurrentUser.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.pCurrentUser.Name = "pCurrentUser";
            this.pCurrentUser.Size = new System.Drawing.Size(262, 150);
            this.pCurrentUser.TabIndex = 5;
            this.pCurrentUser.Click += new System.EventHandler(this.Control_Click);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(12, 74);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(154, 60);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Anything";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRole.Click += new System.EventHandler(this.Control_Click);
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
            this.lblCurrentUser.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnCurrentUserIcon
            // 
            this.btnCurrentUserIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCurrentUserIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnCurrentUserIcon.FlatAppearance.BorderSize = 0;
            this.btnCurrentUserIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnCurrentUserIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnCurrentUserIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentUserIcon.Image = global::LibraryDBMS.Properties.Resources.male_user_78px;
            this.btnCurrentUserIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCurrentUserIcon.Location = new System.Drawing.Point(172, 0);
            this.btnCurrentUserIcon.Name = "btnCurrentUserIcon";
            this.btnCurrentUserIcon.Size = new System.Drawing.Size(90, 150);
            this.btnCurrentUserIcon.TabIndex = 5;
            this.btnCurrentUserIcon.UseVisualStyleBackColor = true;
            this.btnCurrentUserIcon.Click += new System.EventHandler(this.Control_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(247, 60);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "You";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Click += new System.EventHandler(this.Control_Click);
            // 
            // pBooks
            // 
            this.pBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pBooks.Controls.Add(this.lblBooks);
            this.pBooks.Controls.Add(this.lblBookCount);
            this.pBooks.Controls.Add(this.btnBooksIcon);
            this.pBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBooks.Location = new System.Drawing.Point(10, 10);
            this.pBooks.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.pBooks.Name = "pBooks";
            this.pBooks.Size = new System.Drawing.Size(259, 150);
            this.pBooks.TabIndex = 0;
            this.pBooks.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBooks.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBookCount.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnBooksIcon
            // 
            this.btnBooksIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBooksIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBooksIcon.FlatAppearance.BorderSize = 0;
            this.btnBooksIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBooksIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBooksIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooksIcon.Image = global::LibraryDBMS.Properties.Resources.book_78px;
            this.btnBooksIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBooksIcon.Location = new System.Drawing.Point(169, 0);
            this.btnBooksIcon.Name = "btnBooksIcon";
            this.btnBooksIcon.Size = new System.Drawing.Size(90, 150);
            this.btnBooksIcon.TabIndex = 2;
            this.btnBooksIcon.UseVisualStyleBackColor = true;
            this.btnBooksIcon.Click += new System.EventHandler(this.Control_Click);
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
            title1.Text = "Books Count by Subject";
            this.chartBookBySubject.Titles.Add(title1);
            // 
            // pUptime
            // 
            this.pUptime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pUptime.Controls.Add(this.lblUpTime);
            this.pUptime.Controls.Add(this.label8);
            this.pUptime.Controls.Add(this.button10);
            this.pUptime.Cursor = System.Windows.Forms.Cursors.Default;
            this.pUptime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUptime.Location = new System.Drawing.Point(880, 517);
            this.pUptime.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.pUptime.Name = "pUptime";
            this.pUptime.Size = new System.Drawing.Size(262, 152);
            this.pUptime.TabIndex = 4;
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
            // pTitles
            // 
            this.pTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pTitles.Controls.Add(this.btnTitlesIcon);
            this.pTitles.Controls.Add(this.lblBookTitleCount);
            this.pTitles.Controls.Add(this.lblTitles);
            this.pTitles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTitles.Location = new System.Drawing.Point(300, 10);
            this.pTitles.Margin = new System.Windows.Forms.Padding(13, 10, 12, 9);
            this.pTitles.Name = "pTitles";
            this.pTitles.Size = new System.Drawing.Size(262, 150);
            this.pTitles.TabIndex = 0;
            this.pTitles.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnTitlesIcon
            // 
            this.btnTitlesIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTitlesIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnTitlesIcon.FlatAppearance.BorderSize = 0;
            this.btnTitlesIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnTitlesIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnTitlesIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitlesIcon.Image = global::LibraryDBMS.Properties.Resources.typography_78px;
            this.btnTitlesIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTitlesIcon.Location = new System.Drawing.Point(172, 0);
            this.btnTitlesIcon.Name = "btnTitlesIcon";
            this.btnTitlesIcon.Size = new System.Drawing.Size(90, 150);
            this.btnTitlesIcon.TabIndex = 5;
            this.btnTitlesIcon.UseVisualStyleBackColor = true;
            this.btnTitlesIcon.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBookTitleCount.Click += new System.EventHandler(this.Control_Click);
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
            this.lblTitles.Click += new System.EventHandler(this.Control_Click);
            // 
            // pDueTodayBooks
            // 
            this.pDueTodayBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pDueTodayBooks.Controls.Add(this.lblBookDue);
            this.pDueTodayBooks.Controls.Add(this.lblBooksDueToday);
            this.pDueTodayBooks.Controls.Add(this.btnBooksDueTodayIcon);
            this.pDueTodayBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pDueTodayBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDueTodayBooks.Location = new System.Drawing.Point(587, 10);
            this.pDueTodayBooks.Margin = new System.Windows.Forms.Padding(13, 10, 12, 9);
            this.pDueTodayBooks.Name = "pDueTodayBooks";
            this.pDueTodayBooks.Size = new System.Drawing.Size(262, 150);
            this.pDueTodayBooks.TabIndex = 0;
            this.pDueTodayBooks.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBookDue.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBooksDueToday.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnBooksDueTodayIcon
            // 
            this.btnBooksDueTodayIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBooksDueTodayIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBooksDueTodayIcon.FlatAppearance.BorderSize = 0;
            this.btnBooksDueTodayIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBooksDueTodayIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBooksDueTodayIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooksDueTodayIcon.Image = global::LibraryDBMS.Properties.Resources.Clock_78px;
            this.btnBooksDueTodayIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBooksDueTodayIcon.Location = new System.Drawing.Point(172, 0);
            this.btnBooksDueTodayIcon.Name = "btnBooksDueTodayIcon";
            this.btnBooksDueTodayIcon.Size = new System.Drawing.Size(90, 150);
            this.btnBooksDueTodayIcon.TabIndex = 4;
            this.btnBooksDueTodayIcon.UseVisualStyleBackColor = true;
            this.btnBooksDueTodayIcon.Click += new System.EventHandler(this.Control_Click);
            // 
            // pOverdueBooks
            // 
            this.pOverdueBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pOverdueBooks.Controls.Add(this.lblBookOverdueCount);
            this.pOverdueBooks.Controls.Add(this.lblOverdueBooks);
            this.pOverdueBooks.Controls.Add(this.btnOverdueBooksIcon);
            this.pOverdueBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pOverdueBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOverdueBooks.Location = new System.Drawing.Point(880, 10);
            this.pOverdueBooks.Margin = new System.Windows.Forms.Padding(19, 10, 9, 9);
            this.pOverdueBooks.Name = "pOverdueBooks";
            this.pOverdueBooks.Size = new System.Drawing.Size(262, 150);
            this.pOverdueBooks.TabIndex = 0;
            this.pOverdueBooks.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBookOverdueCount.Click += new System.EventHandler(this.Control_Click);
            // 
            // lblOverdueBooks
            // 
            this.lblOverdueBooks.AutoSize = true;
            this.lblOverdueBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOverdueBooks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueBooks.ForeColor = System.Drawing.Color.White;
            this.lblOverdueBooks.Location = new System.Drawing.Point(3, 7);
            this.lblOverdueBooks.Name = "lblOverdueBooks";
            this.lblOverdueBooks.Size = new System.Drawing.Size(151, 27);
            this.lblOverdueBooks.TabIndex = 1;
            this.lblOverdueBooks.Text = "Overdue Books";
            this.lblOverdueBooks.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnOverdueBooksIcon
            // 
            this.btnOverdueBooksIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOverdueBooksIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnOverdueBooksIcon.FlatAppearance.BorderSize = 0;
            this.btnOverdueBooksIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnOverdueBooksIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnOverdueBooksIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverdueBooksIcon.Image = global::LibraryDBMS.Properties.Resources.expired_78px;
            this.btnOverdueBooksIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnOverdueBooksIcon.Location = new System.Drawing.Point(172, 0);
            this.btnOverdueBooksIcon.Name = "btnOverdueBooksIcon";
            this.btnOverdueBooksIcon.Size = new System.Drawing.Size(90, 150);
            this.btnOverdueBooksIcon.TabIndex = 4;
            this.btnOverdueBooksIcon.UseVisualStyleBackColor = true;
            this.btnOverdueBooksIcon.Click += new System.EventHandler(this.Control_Click);
            // 
            // pReturnedBooks
            // 
            this.pReturnedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pReturnedBooks.Controls.Add(this.lblBookReturnCount);
            this.pReturnedBooks.Controls.Add(this.lblReturnedBooks);
            this.pReturnedBooks.Controls.Add(this.btnReturnedBooksIcon);
            this.pReturnedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pReturnedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReturnedBooks.Location = new System.Drawing.Point(10, 517);
            this.pReturnedBooks.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.pReturnedBooks.Name = "pReturnedBooks";
            this.pReturnedBooks.Size = new System.Drawing.Size(259, 152);
            this.pReturnedBooks.TabIndex = 0;
            this.pReturnedBooks.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBookReturnCount.Click += new System.EventHandler(this.Control_Click);
            // 
            // lblReturnedBooks
            // 
            this.lblReturnedBooks.AutoSize = true;
            this.lblReturnedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturnedBooks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturnedBooks.Location = new System.Drawing.Point(2, 5);
            this.lblReturnedBooks.Name = "lblReturnedBooks";
            this.lblReturnedBooks.Size = new System.Drawing.Size(156, 27);
            this.lblReturnedBooks.TabIndex = 3;
            this.lblReturnedBooks.Text = "Returned Books";
            this.lblReturnedBooks.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnReturnedBooksIcon
            // 
            this.btnReturnedBooksIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReturnedBooksIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnReturnedBooksIcon.FlatAppearance.BorderSize = 0;
            this.btnReturnedBooksIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnReturnedBooksIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnReturnedBooksIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnedBooksIcon.Image = global::LibraryDBMS.Properties.Resources.borrow_book_78px;
            this.btnReturnedBooksIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReturnedBooksIcon.Location = new System.Drawing.Point(169, 0);
            this.btnReturnedBooksIcon.Name = "btnReturnedBooksIcon";
            this.btnReturnedBooksIcon.Size = new System.Drawing.Size(90, 152);
            this.btnReturnedBooksIcon.TabIndex = 5;
            this.btnReturnedBooksIcon.UseVisualStyleBackColor = true;
            this.btnReturnedBooksIcon.Click += new System.EventHandler(this.Control_Click);
            // 
            // pBorrowedBooks
            // 
            this.pBorrowedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pBorrowedBooks.Controls.Add(this.lblBookLoanCount);
            this.pBorrowedBooks.Controls.Add(this.lblBorrowedBooks);
            this.pBorrowedBooks.Controls.Add(this.btnBorrowedBooksIcon);
            this.pBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBorrowedBooks.Location = new System.Drawing.Point(10, 348);
            this.pBorrowedBooks.Margin = new System.Windows.Forms.Padding(10, 10, 18, 9);
            this.pBorrowedBooks.Name = "pBorrowedBooks";
            this.pBorrowedBooks.Size = new System.Drawing.Size(259, 150);
            this.pBorrowedBooks.TabIndex = 0;
            this.pBorrowedBooks.Click += new System.EventHandler(this.Control_Click);
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
            this.lblBookLoanCount.Click += new System.EventHandler(this.Control_Click);
            // 
            // lblBorrowedBooks
            // 
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBorrowedBooks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBorrowedBooks.Location = new System.Drawing.Point(2, 5);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(163, 27);
            this.lblBorrowedBooks.TabIndex = 3;
            this.lblBorrowedBooks.Text = "Borrowed Books";
            this.lblBorrowedBooks.Click += new System.EventHandler(this.Control_Click);
            // 
            // btnBorrowedBooksIcon
            // 
            this.btnBorrowedBooksIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBorrowedBooksIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBorrowedBooksIcon.FlatAppearance.BorderSize = 0;
            this.btnBorrowedBooksIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBorrowedBooksIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnBorrowedBooksIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowedBooksIcon.Image = global::LibraryDBMS.Properties.Resources.return_book_78px;
            this.btnBorrowedBooksIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBorrowedBooksIcon.Location = new System.Drawing.Point(169, 0);
            this.btnBorrowedBooksIcon.Name = "btnBorrowedBooksIcon";
            this.btnBorrowedBooksIcon.Size = new System.Drawing.Size(90, 150);
            this.btnBorrowedBooksIcon.TabIndex = 5;
            this.btnBorrowedBooksIcon.UseVisualStyleBackColor = true;
            this.btnBorrowedBooksIcon.Click += new System.EventHandler(this.Control_Click);
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
            this.pStudents.ResumeLayout(false);
            this.pStudents.PerformLayout();
            this.pActivities.ResumeLayout(false);
            this.pActivities.PerformLayout();
            this.pCurrentUser.ResumeLayout(false);
            this.pCurrentUser.PerformLayout();
            this.pBooks.ResumeLayout(false);
            this.pBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookBySubject)).EndInit();
            this.pUptime.ResumeLayout(false);
            this.pUptime.PerformLayout();
            this.pTitles.ResumeLayout(false);
            this.pTitles.PerformLayout();
            this.pDueTodayBooks.ResumeLayout(false);
            this.pDueTodayBooks.PerformLayout();
            this.pOverdueBooks.ResumeLayout(false);
            this.pOverdueBooks.PerformLayout();
            this.pReturnedBooks.ResumeLayout(false);
            this.pReturnedBooks.PerformLayout();
            this.pBorrowedBooks.ResumeLayout(false);
            this.pBorrowedBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pReturnedBooks;
        private System.Windows.Forms.Panel pBorrowedBooks;
        private System.Windows.Forms.Panel pTitles;
        private System.Windows.Forms.Panel pBooks;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblReturnedBooks;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.Label lblTitles;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookBySubject;
        private System.Windows.Forms.Panel pDueTodayBooks;
        private System.Windows.Forms.Label lblBooksDueToday;
        private System.Windows.Forms.Panel pOverdueBooks;
        private System.Windows.Forms.Label lblOverdueBooks;
        private System.Windows.Forms.Panel pUptime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBooksIcon;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblUpTime;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnTitlesIcon;
        private System.Windows.Forms.Label lblBookTitleCount;
        private System.Windows.Forms.Label lblBookDue;
        private System.Windows.Forms.Button btnBooksDueTodayIcon;
        private System.Windows.Forms.Label lblBookOverdueCount;
        private System.Windows.Forms.Button btnOverdueBooksIcon;
        private System.Windows.Forms.Label lblBookLoanCount;
        private System.Windows.Forms.Button btnBorrowedBooksIcon;
        private System.Windows.Forms.Label lblBookReturnCount;
        private System.Windows.Forms.Button btnReturnedBooksIcon;
        private System.Windows.Forms.Panel pActivities;
        private System.Windows.Forms.Label lblActivityCount;
        private System.Windows.Forms.Label lblTodayActivities;
        private System.Windows.Forms.Button btnTodayActivitiesIcon;
        private System.Windows.Forms.Panel pCurrentUser;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnCurrentUserIcon;
        private System.Windows.Forms.Panel pStudents;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnStudentsIcon;
    }
}