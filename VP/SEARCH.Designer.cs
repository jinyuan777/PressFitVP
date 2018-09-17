namespace VP
{
    partial class SEARCH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safeStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxQyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prepareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.drugTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRINTERDataSet = new VP.PRINTERDataSet();
            this.DrugCD = new System.Windows.Forms.TextBox();
            this.Cassete = new System.Windows.Forms.TextBox();
            this.DRUGNM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.drugTableAdapter = new VP.PRINTERDataSetTableAdapters.DrugTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.priceIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.safeStockDataGridViewTextBoxColumn,
            this.box1DataGridViewTextBoxColumn,
            this.box2DataGridViewTextBoxColumn,
            this.box3DataGridViewTextBoxColumn,
            this.box4DataGridViewTextBoxColumn,
            this.box5DataGridViewTextBoxColumn,
            this.maxQyDataGridViewTextBoxColumn,
            this.packageDataGridViewCheckBoxColumn,
            this.prepareDataGridViewTextBoxColumn,
            this.expensiveDataGridViewCheckBoxColumn,
            this.drugTypeDataGridViewTextBoxColumn,
            this.limitedDataGridViewTextBoxColumn,
            this.ingredientDataGridViewTextBoxColumn,
            this.affectDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drugBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(620, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // priceIDDataGridViewTextBoxColumn
            // 
            this.priceIDDataGridViewTextBoxColumn.DataPropertyName = "PriceID";
            this.priceIDDataGridViewTextBoxColumn.HeaderText = "PriceID";
            this.priceIDDataGridViewTextBoxColumn.Name = "priceIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // safeStockDataGridViewTextBoxColumn
            // 
            this.safeStockDataGridViewTextBoxColumn.DataPropertyName = "SafeStock";
            this.safeStockDataGridViewTextBoxColumn.HeaderText = "SafeStock";
            this.safeStockDataGridViewTextBoxColumn.Name = "safeStockDataGridViewTextBoxColumn";
            // 
            // box1DataGridViewTextBoxColumn
            // 
            this.box1DataGridViewTextBoxColumn.DataPropertyName = "Box1";
            this.box1DataGridViewTextBoxColumn.HeaderText = "Box1";
            this.box1DataGridViewTextBoxColumn.Name = "box1DataGridViewTextBoxColumn";
            // 
            // box2DataGridViewTextBoxColumn
            // 
            this.box2DataGridViewTextBoxColumn.DataPropertyName = "Box2";
            this.box2DataGridViewTextBoxColumn.HeaderText = "Box2";
            this.box2DataGridViewTextBoxColumn.Name = "box2DataGridViewTextBoxColumn";
            // 
            // box3DataGridViewTextBoxColumn
            // 
            this.box3DataGridViewTextBoxColumn.DataPropertyName = "Box3";
            this.box3DataGridViewTextBoxColumn.HeaderText = "Box3";
            this.box3DataGridViewTextBoxColumn.Name = "box3DataGridViewTextBoxColumn";
            // 
            // box4DataGridViewTextBoxColumn
            // 
            this.box4DataGridViewTextBoxColumn.DataPropertyName = "Box4";
            this.box4DataGridViewTextBoxColumn.HeaderText = "Box4";
            this.box4DataGridViewTextBoxColumn.Name = "box4DataGridViewTextBoxColumn";
            // 
            // box5DataGridViewTextBoxColumn
            // 
            this.box5DataGridViewTextBoxColumn.DataPropertyName = "Box5";
            this.box5DataGridViewTextBoxColumn.HeaderText = "Box5";
            this.box5DataGridViewTextBoxColumn.Name = "box5DataGridViewTextBoxColumn";
            // 
            // maxQyDataGridViewTextBoxColumn
            // 
            this.maxQyDataGridViewTextBoxColumn.DataPropertyName = "MaxQy";
            this.maxQyDataGridViewTextBoxColumn.HeaderText = "MaxQy";
            this.maxQyDataGridViewTextBoxColumn.Name = "maxQyDataGridViewTextBoxColumn";
            // 
            // packageDataGridViewCheckBoxColumn
            // 
            this.packageDataGridViewCheckBoxColumn.DataPropertyName = "Package";
            this.packageDataGridViewCheckBoxColumn.HeaderText = "Package";
            this.packageDataGridViewCheckBoxColumn.Name = "packageDataGridViewCheckBoxColumn";
            // 
            // prepareDataGridViewTextBoxColumn
            // 
            this.prepareDataGridViewTextBoxColumn.DataPropertyName = "Prepare";
            this.prepareDataGridViewTextBoxColumn.HeaderText = "Prepare";
            this.prepareDataGridViewTextBoxColumn.Name = "prepareDataGridViewTextBoxColumn";
            // 
            // expensiveDataGridViewCheckBoxColumn
            // 
            this.expensiveDataGridViewCheckBoxColumn.DataPropertyName = "Expensive";
            this.expensiveDataGridViewCheckBoxColumn.HeaderText = "Expensive";
            this.expensiveDataGridViewCheckBoxColumn.Name = "expensiveDataGridViewCheckBoxColumn";
            // 
            // drugTypeDataGridViewTextBoxColumn
            // 
            this.drugTypeDataGridViewTextBoxColumn.DataPropertyName = "DrugType";
            this.drugTypeDataGridViewTextBoxColumn.HeaderText = "DrugType";
            this.drugTypeDataGridViewTextBoxColumn.Name = "drugTypeDataGridViewTextBoxColumn";
            // 
            // limitedDataGridViewTextBoxColumn
            // 
            this.limitedDataGridViewTextBoxColumn.DataPropertyName = "Limited";
            this.limitedDataGridViewTextBoxColumn.HeaderText = "Limited";
            this.limitedDataGridViewTextBoxColumn.Name = "limitedDataGridViewTextBoxColumn";
            // 
            // ingredientDataGridViewTextBoxColumn
            // 
            this.ingredientDataGridViewTextBoxColumn.DataPropertyName = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.HeaderText = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.Name = "ingredientDataGridViewTextBoxColumn";
            // 
            // affectDataGridViewTextBoxColumn
            // 
            this.affectDataGridViewTextBoxColumn.DataPropertyName = "Affect";
            this.affectDataGridViewTextBoxColumn.HeaderText = "Affect";
            this.affectDataGridViewTextBoxColumn.Name = "affectDataGridViewTextBoxColumn";
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataMember = "Drug";
            this.drugBindingSource.DataSource = this.pRINTERDataSet;
            // 
            // pRINTERDataSet
            // 
            this.pRINTERDataSet.DataSetName = "PRINTERDataSet";
            this.pRINTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DrugCD
            // 
            this.DrugCD.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugCD.Location = new System.Drawing.Point(28, 36);
            this.DrugCD.Name = "DrugCD";
            this.DrugCD.Size = new System.Drawing.Size(161, 25);
            this.DrugCD.TabIndex = 1;
            // 
            // Cassete
            // 
            this.Cassete.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cassete.Location = new System.Drawing.Point(28, 96);
            this.Cassete.Name = "Cassete";
            this.Cassete.Size = new System.Drawing.Size(100, 25);
            this.Cassete.TabIndex = 2;
            // 
            // DRUGNM
            // 
            this.DRUGNM.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRUGNM.Location = new System.Drawing.Point(255, 36);
            this.DRUGNM.Name = "DRUGNM";
            this.DRUGNM.Size = new System.Drawing.Size(270, 25);
            this.DRUGNM.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "藥品代碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "藥盒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "藥品名稱";
            // 
            // SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DRUGNM);
            this.Controls.Add(this.Cassete);
            this.Controls.Add(this.DrugCD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SEARCH";
            this.Text = "SEARCH";
            this.Load += new System.EventHandler(this.SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DrugCD;
        private System.Windows.Forms.TextBox Cassete;
        private System.Windows.Forms.TextBox DRUGNM;
        private System.Windows.Forms.Button button1;
        private PRINTERDataSet pRINTERDataSet;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private PRINTERDataSetTableAdapters.DrugTableAdapter drugTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn safeStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn box1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn box2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn box3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn box4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn box5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxQyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn packageDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expensiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}