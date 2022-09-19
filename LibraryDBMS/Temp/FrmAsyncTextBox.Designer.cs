namespace WesternLibraryManagementSystem.Temp
{
    partial class FrmAsyncTextBox
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRunAsync = new System.Windows.Forms.Button();
            this.txtMainThread = new System.Windows.Forms.TextBox();
            this.txtMultipleThreadHeavy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(13, 49);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(250, 53);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run on Main Thread\r\n(Locks everything)";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRunAsync
            // 
            this.btnRunAsync.Location = new System.Drawing.Point(307, 49);
            this.btnRunAsync.Name = "btnRunAsync";
            this.btnRunAsync.Size = new System.Drawing.Size(250, 53);
            this.btnRunAsync.TabIndex = 1;
            this.btnRunAsync.Text = "Run on Multiple Threads\r\n(Run much faster)";
            this.btnRunAsync.UseVisualStyleBackColor = true;
            this.btnRunAsync.Click += new System.EventHandler(this.btnRunAsync_Click);
            // 
            // txtMainThread
            // 
            this.txtMainThread.Location = new System.Drawing.Point(13, 125);
            this.txtMainThread.Multiline = true;
            this.txtMainThread.Name = "txtMainThread";
            this.txtMainThread.Size = new System.Drawing.Size(250, 478);
            this.txtMainThread.TabIndex = 2;
            // 
            // txtMultipleThreadHeavy
            // 
            this.txtMultipleThreadHeavy.Location = new System.Drawing.Point(307, 125);
            this.txtMultipleThreadHeavy.Multiline = true;
            this.txtMultipleThreadHeavy.Name = "txtMultipleThreadHeavy";
            this.txtMultipleThreadHeavy.Size = new System.Drawing.Size(250, 478);
            this.txtMultipleThreadHeavy.TabIndex = 2;
            // 
            // FrmAsyncDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 613);
            this.Controls.Add(this.txtMultipleThreadHeavy);
            this.Controls.Add(this.txtMainThread);
            this.Controls.Add(this.btnRunAsync);
            this.Controls.Add(this.btnRun);
            this.Name = "FrmAsyncDataGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsyncDataGrid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRunAsync;
        private System.Windows.Forms.TextBox txtMainThread;
        private System.Windows.Forms.TextBox txtMultipleThreadHeavy;
    }
}