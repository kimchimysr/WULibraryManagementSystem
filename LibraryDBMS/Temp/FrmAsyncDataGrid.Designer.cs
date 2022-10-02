namespace LibraryDBMS.Temp
{
    partial class FrmAsyncDataGrid
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
            this.dgvSingleThread = new System.Windows.Forms.DataGridView();
            this.dgvMultipleThreads = new System.Windows.Forms.DataGridView();
            this.btnRunSingleThread = new System.Windows.Forms.Button();
            this.btnRunMultipleThreads = new System.Windows.Forms.Button();
            this.lblTimeS = new System.Windows.Forms.Label();
            this.lblTimeM = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSingleThread
            // 
            this.dgvSingleThread.AllowUserToAddRows = false;
            this.dgvSingleThread.AllowUserToDeleteRows = false;
            this.dgvSingleThread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingleThread.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sec,
            this.action});
            this.dgvSingleThread.Location = new System.Drawing.Point(12, 148);
            this.dgvSingleThread.Name = "dgvSingleThread";
            this.dgvSingleThread.ReadOnly = true;
            this.dgvSingleThread.Size = new System.Drawing.Size(289, 562);
            this.dgvSingleThread.TabIndex = 0;
            // 
            // dgvMultipleThreads
            // 
            this.dgvMultipleThreads.AllowUserToAddRows = false;
            this.dgvMultipleThreads.AllowUserToDeleteRows = false;
            this.dgvMultipleThreads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultipleThreads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvMultipleThreads.Location = new System.Drawing.Point(349, 148);
            this.dgvMultipleThreads.Name = "dgvMultipleThreads";
            this.dgvMultipleThreads.ReadOnly = true;
            this.dgvMultipleThreads.Size = new System.Drawing.Size(289, 562);
            this.dgvMultipleThreads.TabIndex = 0;
            // 
            // btnRunSingleThread
            // 
            this.btnRunSingleThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunSingleThread.Location = new System.Drawing.Point(12, 79);
            this.btnRunSingleThread.Name = "btnRunSingleThread";
            this.btnRunSingleThread.Size = new System.Drawing.Size(289, 54);
            this.btnRunSingleThread.TabIndex = 1;
            this.btnRunSingleThread.Text = "Run on Single Thread\r\n(Locks everything)";
            this.btnRunSingleThread.UseVisualStyleBackColor = true;
            this.btnRunSingleThread.Click += new System.EventHandler(this.btnRunSingleThread_Click);
            // 
            // btnRunMultipleThreads
            // 
            this.btnRunMultipleThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunMultipleThreads.Location = new System.Drawing.Point(349, 79);
            this.btnRunMultipleThreads.Name = "btnRunMultipleThreads";
            this.btnRunMultipleThreads.Size = new System.Drawing.Size(289, 54);
            this.btnRunMultipleThreads.TabIndex = 1;
            this.btnRunMultipleThreads.Text = "Run on Multiple Threads\r\n(Load faster and responsive)";
            this.btnRunMultipleThreads.UseVisualStyleBackColor = true;
            this.btnRunMultipleThreads.Click += new System.EventHandler(this.btnRunMultipleThreads_Click);
            // 
            // lblTimeS
            // 
            this.lblTimeS.Location = new System.Drawing.Point(12, 722);
            this.lblTimeS.Name = "lblTimeS";
            this.lblTimeS.Size = new System.Drawing.Size(289, 23);
            this.lblTimeS.TabIndex = 2;
            this.lblTimeS.Text = "Time Elapsed:";
            this.lblTimeS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeM
            // 
            this.lblTimeM.Location = new System.Drawing.Point(346, 722);
            this.lblTimeM.Name = "lblTimeM";
            this.lblTimeM.Size = new System.Drawing.Size(292, 23);
            this.lblTimeM.TabIndex = 2;
            this.lblTimeM.Text = "Time Elapsed:";
            this.lblTimeM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sec
            // 
            this.sec.HeaderText = "order";
            this.sec.Name = "sec";
            this.sec.ReadOnly = true;
            this.sec.Width = 80;
            // 
            // action
            // 
            this.action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.action.HeaderText = "action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "order";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "action";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmAsyncDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 778);
            this.Controls.Add(this.lblTimeM);
            this.Controls.Add(this.lblTimeS);
            this.Controls.Add(this.btnRunMultipleThreads);
            this.Controls.Add(this.btnRunSingleThread);
            this.Controls.Add(this.dgvMultipleThreads);
            this.Controls.Add(this.dgvSingleThread);
            this.Name = "FrmAsyncDataGrid";
            this.Text = "FrmAsyncDataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultipleThreads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSingleThread;
        private System.Windows.Forms.DataGridView dgvMultipleThreads;
        private System.Windows.Forms.Button btnRunSingleThread;
        private System.Windows.Forms.Button btnRunMultipleThreads;
        private System.Windows.Forms.Label lblTimeS;
        private System.Windows.Forms.Label lblTimeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}