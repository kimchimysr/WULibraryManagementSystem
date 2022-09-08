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
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelViewCategory = new System.Windows.Forms.Panel();
            this.dgvBookCategories = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelViewCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panelButton);
            this.panelMain.Controls.Add(this.panelViewCategory);
            this.panelMain.Location = new System.Drawing.Point(-1, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1008, 600);
            this.panelMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Categories";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.button4);
            this.panelButton.Controls.Add(this.button3);
            this.panelButton.Controls.Add(this.button2);
            this.panelButton.Controls.Add(this.button1);
            this.panelButton.Location = new System.Drawing.Point(764, 104);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(170, 373);
            this.panelButton.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(30, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(30, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelViewCategory
            // 
            this.panelViewCategory.Controls.Add(this.dgvBookCategories);
            this.panelViewCategory.Location = new System.Drawing.Point(122, 65);
            this.panelViewCategory.Name = "panelViewCategory";
            this.panelViewCategory.Size = new System.Drawing.Size(557, 508);
            this.panelViewCategory.TabIndex = 0;
            // 
            // dgvBookCategories
            // 
            this.dgvBookCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCategories.Location = new System.Drawing.Point(19, 17);
            this.dgvBookCategories.Name = "dgvBookCategories";
            this.dgvBookCategories.Size = new System.Drawing.Size(513, 480);
            this.dgvBookCategories.TabIndex = 0;
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
            this.panelButton.ResumeLayout(false);
            this.panelViewCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelViewCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBookCategories;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}