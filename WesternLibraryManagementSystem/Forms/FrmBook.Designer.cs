namespace WesternLibraryManagementSystem.Forms
{
    partial class FrmBook
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
            this.panelFormName = new System.Windows.Forms.Panel();
            this.panelBookManagement = new System.Windows.Forms.Panel();
            this.panelButtonOne = new System.Windows.Forms.Panel();
            this.panelButton2 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
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
            this.panelMain.Size = new System.Drawing.Size(1106, 645);
            this.panelMain.TabIndex = 0;
            // 
            // panelFormName
            // 
            this.panelFormName.Location = new System.Drawing.Point(290, 29);
            this.panelFormName.Name = "panelFormName";
            this.panelFormName.Size = new System.Drawing.Size(259, 37);
            this.panelFormName.TabIndex = 0;
            // 
            // panelBookManagement
            // 
            this.panelBookManagement.Location = new System.Drawing.Point(56, 149);
            this.panelBookManagement.Name = "panelBookManagement";
            this.panelBookManagement.Size = new System.Drawing.Size(634, 478);
            this.panelBookManagement.TabIndex = 1;
            // 
            // panelButtonOne
            // 
            this.panelButtonOne.Location = new System.Drawing.Point(120, 87);
            this.panelButtonOne.Name = "panelButtonOne";
            this.panelButtonOne.Size = new System.Drawing.Size(487, 56);
            this.panelButtonOne.TabIndex = 2;
            // 
            // panelButton2
            // 
            this.panelButton2.Location = new System.Drawing.Point(762, 174);
            this.panelButton2.Name = "panelButton2";
            this.panelButton2.Size = new System.Drawing.Size(143, 453);
            this.panelButton2.TabIndex = 3;
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 645);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmBook";
            this.Text = "FrmBookRecord";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBookManagement;
        private System.Windows.Forms.Panel panelFormName;
        private System.Windows.Forms.Panel panelButton2;
        private System.Windows.Forms.Panel panelButtonOne;
    }
}