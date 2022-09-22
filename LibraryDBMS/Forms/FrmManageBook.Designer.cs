namespace LibraryDBMS.Forms
{
    partial class FrmManageBook
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelButtonOne = new System.Windows.Forms.Panel();
            this.panelBookManagement = new System.Windows.Forms.Panel();
            this.panelFormName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelButton2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dewey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMeanOfSearch = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelButtonOne.SuspendLayout();
            this.panelBookManagement.SuspendLayout();
            this.panelFormName.SuspendLayout();
            this.panelButton2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelButton2);
            this.panelMain.Controls.Add(this.panelButtonOne);
            this.panelMain.Controls.Add(this.panelBookManagement);
            this.panelMain.Controls.Add(this.panelFormName);
            this.panelMain.Location = new System.Drawing.Point(3, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1264, 645);
            this.panelMain.TabIndex = 0;
            // 
            // panelButtonOne
            // 
            this.panelButtonOne.Controls.Add(this.btnRefresh);
            this.panelButtonOne.Controls.Add(this.cbbMeanOfSearch);
            this.panelButtonOne.Controls.Add(this.label2);
            this.panelButtonOne.Controls.Add(this.txtSearch);
            this.panelButtonOne.Controls.Add(this.btnSearch);
            this.panelButtonOne.Location = new System.Drawing.Point(56, 82);
            this.panelButtonOne.Name = "panelButtonOne";
            this.panelButtonOne.Size = new System.Drawing.Size(967, 61);
            this.panelButtonOne.TabIndex = 2;
            // 
            // panelBookManagement
            // 
            this.panelBookManagement.Controls.Add(this.dgvBooks);
            this.panelBookManagement.Location = new System.Drawing.Point(9, 177);
            this.panelBookManagement.Name = "panelBookManagement";
            this.panelBookManagement.Size = new System.Drawing.Size(1242, 361);
            this.panelBookManagement.TabIndex = 1;
            // 
            // panelFormName
            // 
            this.panelFormName.Controls.Add(this.label1);
            this.panelFormName.Location = new System.Drawing.Point(499, 12);
            this.panelFormName.Name = "panelFormName";
            this.panelFormName.Size = new System.Drawing.Size(260, 47);
            this.panelFormName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Management";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(669, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 38);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panelButton2
            // 
            this.panelButton2.Controls.Add(this.button6);
            this.panelButton2.Controls.Add(this.btnDelete);
            this.panelButton2.Controls.Add(this.btnEdit);
            this.panelButton2.Controls.Add(this.btnAdd);
            this.panelButton2.Location = new System.Drawing.Point(12, 556);
            this.panelButton2.Name = "panelButton2";
            this.panelButton2.Size = new System.Drawing.Size(1239, 56);
            this.panelButton2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(7, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(429, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.isbn,
            this.dewey,
            this.title,
            this.author,
            this.publisher,
            this.publishYear,
            this.pages,
            this.other,
            this.qty,
            this.cateID,
            this.dayAdded});
            this.dgvBooks.Location = new System.Drawing.Point(3, 4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(1236, 354);
            this.dgvBooks.TabIndex = 0;
            // 
            // bookID
            // 
            this.bookID.HeaderText = "Book ID";
            this.bookID.Name = "bookID";
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            // 
            // dewey
            // 
            this.dewey.HeaderText = "DEWEY";
            this.dewey.Name = "dewey";
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Publisher";
            this.publisher.Name = "publisher";
            // 
            // publishYear
            // 
            this.publishYear.HeaderText = "Publish Year";
            this.publishYear.Name = "publishYear";
            // 
            // pages
            // 
            this.pages.HeaderText = "Pages";
            this.pages.Name = "pages";
            // 
            // other
            // 
            this.other.HeaderText = "Other";
            this.other.Name = "other";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // cateID
            // 
            this.cateID.HeaderText = "Category ID";
            this.cateID.Name = "cateID";
            // 
            // dayAdded
            // 
            this.dayAdded.HeaderText = "Date Added";
            this.dayAdded.Name = "dayAdded";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbbMeanOfSearch
            // 
            this.cbbMeanOfSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMeanOfSearch.FormattingEnabled = true;
            this.cbbMeanOfSearch.Location = new System.Drawing.Point(228, 31);
            this.cbbMeanOfSearch.Name = "cbbMeanOfSearch";
            this.cbbMeanOfSearch.Size = new System.Drawing.Size(184, 30);
            this.cbbMeanOfSearch.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(838, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 38);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(376, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(713, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1073, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 50);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 645);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmBook";
            this.Text = "FrmBookRecord";
            this.panelMain.ResumeLayout(false);
            this.panelButtonOne.ResumeLayout(false);
            this.panelButtonOne.PerformLayout();
            this.panelBookManagement.ResumeLayout(false);
            this.panelFormName.ResumeLayout(false);
            this.panelButton2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBookManagement;
        private System.Windows.Forms.Panel panelFormName;
        private System.Windows.Forms.Panel panelButtonOne;
        private System.Windows.Forms.Panel panelButton2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dewey;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn other;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayAdded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMeanOfSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnDelete;
    }
}