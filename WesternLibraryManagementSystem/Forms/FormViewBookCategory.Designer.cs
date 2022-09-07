namespace WesternLibraryManagement.Forms
{
    partial class FormViewBookCategory
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
            this.panelViewCategory = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelButton);
            this.panelMain.Controls.Add(this.panelViewCategory);
            this.panelMain.Location = new System.Drawing.Point(-1, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1008, 600);
            this.panelMain.TabIndex = 0;
            // 
            // panelViewCategory
            // 
            this.panelViewCategory.Location = new System.Drawing.Point(122, 54);
            this.panelViewCategory.Name = "panelViewCategory";
            this.panelViewCategory.Size = new System.Drawing.Size(557, 508);
            this.panelViewCategory.TabIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.Location = new System.Drawing.Point(764, 104);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(170, 412);
            this.panelButton.TabIndex = 1;
            // 
            // FormViewBookCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 600);
            this.Controls.Add(this.panelMain);
            this.Name = "FormViewBookCategory";
            this.Text = "FormViewBookCategory";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelViewCategory;
    }
}