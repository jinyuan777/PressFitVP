namespace VP
{
    partial class RrportList
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_OUT = new System.Windows.Forms.Button();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.List_GV = new System.Windows.Forms.DataGridView();
            this.ReportListBS = new System.Windows.Forms.BindingSource(this.components);
            this.pRINTERDataSet = new VP.PRINTERDataSet();
            this.reportListTableAdapter = new VP.PRINTERDataSetTableAdapters.ReportListTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportListBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 39);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button_OUT
            // 
            this.button_OUT.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OUT.Location = new System.Drawing.Point(667, 3);
            this.button_OUT.Name = "button_OUT";
            this.button_OUT.Size = new System.Drawing.Size(76, 47);
            this.button_OUT.TabIndex = 1;
            this.button_OUT.Text = "輸出";
            this.button_OUT.UseVisualStyleBackColor = true;
            this.button_OUT.Click += new System.EventHandler(this.button_OUT_Click);
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_CLOSE.Location = new System.Drawing.Point(749, 3);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(76, 47);
            this.button_CLOSE.TabIndex = 2;
            this.button_CLOSE.Text = "關閉";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.button_CLOSE);
            this.splitContainer1.Panel1.Controls.Add(this.button_OUT);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.List_GV);
            this.splitContainer1.Size = new System.Drawing.Size(828, 591);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 3;
            // 
            // List_GV
            // 
            this.List_GV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.List_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_GV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_GV.Location = new System.Drawing.Point(0, 0);
            this.List_GV.Name = "List_GV";
            this.List_GV.RowTemplate.Height = 24;
            this.List_GV.Size = new System.Drawing.Size(828, 529);
            this.List_GV.TabIndex = 0;
            // 
            // ReportListBS
            // 
            this.ReportListBS.DataMember = "ReportList";
            this.ReportListBS.DataSource = this.pRINTERDataSet;
            // 
            // pRINTERDataSet
            // 
            this.pRINTERDataSet.DataSetName = "PRINTERDataSet";
            this.pRINTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportListTableAdapter
            // 
            this.reportListTableAdapter.ClearBeforeFill = true;
            // 
            // RrportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 591);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RrportList";
            this.Text = "RrportList";
            this.Load += new System.EventHandler(this.RrportList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportListBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_OUT;
        private System.Windows.Forms.Button button_CLOSE;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView List_GV;
        private System.Windows.Forms.BindingSource ReportListBS;
        private PRINTERDataSet pRINTERDataSet;
        private VP.PRINTERDataSetTableAdapters.ReportListTableAdapter reportListTableAdapter;
    }
}