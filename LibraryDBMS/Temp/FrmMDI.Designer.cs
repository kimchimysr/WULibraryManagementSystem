namespace LibraryDBMS.Temp
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManageBook = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBookLoanReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageBook,
            this.ManageStudent,
            this.ManageBookLoanReturn,
            this.ManageUser,
            this.Report});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ManageBook
            // 
            this.ManageBook.Name = "ManageBook";
            this.ManageBook.Size = new System.Drawing.Size(92, 20);
            this.ManageBook.Text = "Manage Book";
            this.ManageBook.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ManageStudent
            // 
            this.ManageStudent.Name = "ManageStudent";
            this.ManageStudent.Size = new System.Drawing.Size(106, 20);
            this.ManageStudent.Text = "Manage Student";
            this.ManageStudent.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ManageBookLoanReturn
            // 
            this.ManageBookLoanReturn.Name = "ManageBookLoanReturn";
            this.ManageBookLoanReturn.Size = new System.Drawing.Size(161, 20);
            this.ManageBookLoanReturn.Text = "Manage Book Loan/Return";
            this.ManageBookLoanReturn.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ManageUser
            // 
            this.ManageUser.Name = "ManageUser";
            this.ManageUser.Size = new System.Drawing.Size(88, 20);
            this.ManageUser.Text = "Manage User";
            this.ManageUser.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(54, 20);
            this.Report.Text = "Report";
            this.Report.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "FrmMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManageBook;
        private System.Windows.Forms.ToolStripMenuItem ManageStudent;
        private System.Windows.Forms.ToolStripMenuItem ManageBookLoanReturn;
        private System.Windows.Forms.ToolStripMenuItem ManageUser;
        private System.Windows.Forms.ToolStripMenuItem Report;
    }
}