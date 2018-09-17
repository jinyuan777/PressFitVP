namespace VP
{
    partial class OPERRATION
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CassetteList_DGV = new System.Windows.Forms.DataGridView();
            this.CASList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASAckBG = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CassetteList_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CassetteList_DGV
            // 
            this.CassetteList_DGV.AllowUserToAddRows = false;
            this.CassetteList_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CassetteList_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CassetteList_DGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CassetteList_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CassetteList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CassetteList_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CASList,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.CassetteList_DGV.Location = new System.Drawing.Point(0, 3);
            this.CassetteList_DGV.MultiSelect = false;
            this.CassetteList_DGV.Name = "CassetteList_DGV";
            this.CassetteList_DGV.ReadOnly = true;
            this.CassetteList_DGV.RowHeadersVisible = false;
            this.CassetteList_DGV.RowHeadersWidth = 60;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CassetteList_DGV.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.CassetteList_DGV.RowTemplate.Height = 40;
            this.CassetteList_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CassetteList_DGV.Size = new System.Drawing.Size(593, 506);
            this.CassetteList_DGV.TabIndex = 0;
            this.CassetteList_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CassetteList_DGV_CellClick);
            this.CassetteList_DGV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CassetteList_DGV_ColumnHeaderMouseClick);
            // 
            // CASList
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CASList.DefaultCellStyle = dataGridViewCellStyle9;
            this.CASList.HeaderText = "MDU";
            this.CASList.Name = "CASList";
            this.CASList.ReadOnly = true;
            this.CASList.Width = 83;
            // 
            // Column1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column1.HeaderText = "             ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.HeaderText = "             ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column3.HeaderText = "             ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column4.HeaderText = "             ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // CASAckBG
            // 
            this.CASAckBG.WorkerReportsProgress = true;
            //this.CASAckBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CASAckBG_DoWork);
            //this.CASAckBG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CASAckBG_ProgressChanged);
            //this.CASAckBG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CASAckBG_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(599, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(599, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(625, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 33);
            this.textBox1.TabIndex = 4;
            // 
            // OPERRATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CassetteList_DGV);
            this.Name = "OPERRATION";
            this.Text = "OPERRATION";
            this.Load += new System.EventHandler(this.OPERRATION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CassetteList_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CassetteList_DGV;
        private System.ComponentModel.BackgroundWorker CASAckBG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox1;
    }
}