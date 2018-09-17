namespace VP
{
    partial class Cassetes
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
            System.Windows.Forms.Label cST_NUMLabel;
            System.Windows.Forms.Label tblt_cdLabel;
            System.Windows.Forms.Label uSE_YNLabel;
            System.Windows.Forms.Label tRAY_LAYERLabel;
            System.Windows.Forms.Label tRAY_ROWLabel;
            System.Windows.Forms.Label tRAY_LRLabel;
            System.Windows.Forms.Label cST_CLSF_CDLabel;
            System.Windows.Forms.Label cLSF_STATELabel;
            System.Windows.Forms.Label tblt_qtyLabel;
            System.Windows.Forms.Label tblt_qty_dtmLabel;
            System.Windows.Forms.Label tblt_min_qtyLabel;
            System.Windows.Forms.Label cst_weightLabel;
            System.Windows.Forms.Label tblt_barcodeLabel;
            System.Windows.Forms.Label tblt_drop_DelayLabel;
            System.Windows.Forms.Label tblt_enddateLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.USE_YN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblt_enddateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tblt_drop_DelayTextBox = new System.Windows.Forms.TextBox();
            this.tblt_barcodeTextBox = new System.Windows.Forms.TextBox();
            this.cst_weightTextBox = new System.Windows.Forms.TextBox();
            this.tblt_min_qtyTextBox = new System.Windows.Forms.TextBox();
            this.tblt_qty_dtmTextBox = new System.Windows.Forms.TextBox();
            this.tblt_qtyTextBox = new System.Windows.Forms.TextBox();
            this.cLSF_STATETextBox = new System.Windows.Forms.TextBox();
            this.cST_CLSF_CDTextBox = new System.Windows.Forms.TextBox();
            this.tRAY_LRTextBox = new System.Windows.Forms.TextBox();
            this.tRAY_ROWTextBox = new System.Windows.Forms.TextBox();
            this.tRAY_LAYERTextBox = new System.Windows.Forms.TextBox();
            this.uSE_YNCheckBox = new System.Windows.Forms.CheckBox();
            this.tblt_cdTextBox = new System.Windows.Forms.TextBox();
            this.cST_NUMTextBox = new System.Windows.Forms.TextBox();
            this.button_ADD = new System.Windows.Forms.Button();
            this.button_MODY = new System.Windows.Forms.Button();
            this.button_DEL = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_CANCLE = new System.Windows.Forms.Button();
            this.button_CLOSE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cSTNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbltqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRINTERDataSet = new VP.PRINTERDataSet();
            this.layoutItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taLayoutItem = new VP.PRINTERDataSetTableAdapters.taLayoutItem();
            this.drugTableAdapter = new VP.PRINTERDataSetTableAdapters.DrugTableAdapter();
            this.tableAdapterManager = new VP.PRINTERDataSetTableAdapters.TableAdapterManager();
            this.cassette_InfoTableAdapter = new VP.PRINTERDataSetTableAdapters.Cassette_InfoTableAdapter();
            cST_NUMLabel = new System.Windows.Forms.Label();
            tblt_cdLabel = new System.Windows.Forms.Label();
            uSE_YNLabel = new System.Windows.Forms.Label();
            tRAY_LAYERLabel = new System.Windows.Forms.Label();
            tRAY_ROWLabel = new System.Windows.Forms.Label();
            tRAY_LRLabel = new System.Windows.Forms.Label();
            cST_CLSF_CDLabel = new System.Windows.Forms.Label();
            cLSF_STATELabel = new System.Windows.Forms.Label();
            tblt_qtyLabel = new System.Windows.Forms.Label();
            tblt_qty_dtmLabel = new System.Windows.Forms.Label();
            tblt_min_qtyLabel = new System.Windows.Forms.Label();
            cst_weightLabel = new System.Windows.Forms.Label();
            tblt_barcodeLabel = new System.Windows.Forms.Label();
            tblt_drop_DelayLabel = new System.Windows.Forms.Label();
            tblt_enddateLabel = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cST_NUMLabel
            // 
            cST_NUMLabel.AutoSize = true;
            cST_NUMLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cST_NUMLabel.Location = new System.Drawing.Point(24, 29);
            cST_NUMLabel.Name = "cST_NUMLabel";
            cST_NUMLabel.Size = new System.Drawing.Size(73, 17);
            cST_NUMLabel.TabIndex = 0;
            cST_NUMLabel.Text = "CST NUM:";
            // 
            // tblt_cdLabel
            // 
            tblt_cdLabel.AutoSize = true;
            tblt_cdLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tblt_cdLabel.Location = new System.Drawing.Point(45, 197);
            tblt_cdLabel.Name = "tblt_cdLabel";
            tblt_cdLabel.Size = new System.Drawing.Size(51, 17);
            tblt_cdLabel.TabIndex = 2;
            tblt_cdLabel.Text = "tblt cd:";
            // 
            // uSE_YNLabel
            // 
            uSE_YNLabel.AutoSize = true;
            uSE_YNLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uSE_YNLabel.Location = new System.Drawing.Point(230, 29);
            uSE_YNLabel.Name = "uSE_YNLabel";
            uSE_YNLabel.Size = new System.Drawing.Size(58, 17);
            uSE_YNLabel.TabIndex = 4;
            uSE_YNLabel.Text = "USE YN:";
            // 
            // tRAY_LAYERLabel
            // 
            tRAY_LAYERLabel.AutoSize = true;
            tRAY_LAYERLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRAY_LAYERLabel.Location = new System.Drawing.Point(6, 67);
            tRAY_LAYERLabel.Name = "tRAY_LAYERLabel";
            tRAY_LAYERLabel.Size = new System.Drawing.Size(88, 17);
            tRAY_LAYERLabel.TabIndex = 6;
            tRAY_LAYERLabel.Text = "TRAY LAYER:";
            // 
            // tRAY_ROWLabel
            // 
            tRAY_ROWLabel.AutoSize = true;
            tRAY_ROWLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRAY_ROWLabel.Location = new System.Drawing.Point(14, 102);
            tRAY_ROWLabel.Name = "tRAY_ROWLabel";
            tRAY_ROWLabel.Size = new System.Drawing.Size(81, 17);
            tRAY_ROWLabel.TabIndex = 8;
            tRAY_ROWLabel.Text = "TRAY ROW:";
            // 
            // tRAY_LRLabel
            // 
            tRAY_LRLabel.AutoSize = true;
            tRAY_LRLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRAY_LRLabel.Location = new System.Drawing.Point(31, 136);
            tRAY_LRLabel.Name = "tRAY_LRLabel";
            tRAY_LRLabel.Size = new System.Drawing.Size(64, 17);
            tRAY_LRLabel.TabIndex = 10;
            tRAY_LRLabel.Text = "TRAY LR:";
            // 
            // cST_CLSF_CDLabel
            // 
            cST_CLSF_CDLabel.AutoSize = true;
            cST_CLSF_CDLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cST_CLSF_CDLabel.Location = new System.Drawing.Point(206, 70);
            cST_CLSF_CDLabel.Name = "cST_CLSF_CDLabel";
            cST_CLSF_CDLabel.Size = new System.Drawing.Size(92, 17);
            cST_CLSF_CDLabel.TabIndex = 12;
            cST_CLSF_CDLabel.Text = "CST CLSF CD:";
            // 
            // cLSF_STATELabel
            // 
            cLSF_STATELabel.AutoSize = true;
            cLSF_STATELabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLSF_STATELabel.Location = new System.Drawing.Point(9, 325);
            cLSF_STATELabel.Name = "cLSF_STATELabel";
            cLSF_STATELabel.Size = new System.Drawing.Size(85, 17);
            cLSF_STATELabel.TabIndex = 14;
            cLSF_STATELabel.Text = "CLSF STATE:";
            // 
            // tblt_qtyLabel
            // 
            tblt_qtyLabel.AutoSize = true;
            tblt_qtyLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tblt_qtyLabel.Location = new System.Drawing.Point(39, 368);
            tblt_qtyLabel.Name = "tblt_qtyLabel";
            tblt_qtyLabel.Size = new System.Drawing.Size(56, 17);
            tblt_qtyLabel.TabIndex = 16;
            tblt_qtyLabel.Text = "tblt qty:";
            // 
            // tblt_qty_dtmLabel
            // 
            tblt_qty_dtmLabel.AutoSize = true;
            tblt_qty_dtmLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tblt_qty_dtmLabel.Location = new System.Drawing.Point(207, 325);
            tblt_qty_dtmLabel.Name = "tblt_qty_dtmLabel";
            tblt_qty_dtmLabel.Size = new System.Drawing.Size(84, 17);
            tblt_qty_dtmLabel.TabIndex = 18;
            tblt_qty_dtmLabel.Text = "tblt qty dtm:";
            // 
            // tblt_min_qtyLabel
            // 
            tblt_min_qtyLabel.AutoSize = true;
            tblt_min_qtyLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tblt_min_qtyLabel.Location = new System.Drawing.Point(208, 364);
            tblt_min_qtyLabel.Name = "tblt_min_qtyLabel";
            tblt_min_qtyLabel.Size = new System.Drawing.Size(83, 17);
            tblt_min_qtyLabel.TabIndex = 20;
            tblt_min_qtyLabel.Text = "tblt min qty:";
            // 
            // cst_weightLabel
            // 
            cst_weightLabel.AutoSize = true;
            cst_weightLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cst_weightLabel.Location = new System.Drawing.Point(14, 497);
            cst_weightLabel.Name = "cst_weightLabel";
            cst_weightLabel.Size = new System.Drawing.Size(75, 17);
            cst_weightLabel.TabIndex = 22;
            cst_weightLabel.Text = "cst weight:";
            // 
            // tblt_barcodeLabel
            // 
            tblt_barcodeLabel.AutoSize = true;
            tblt_barcodeLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tblt_barcodeLabel.Location = new System.Drawing.Point(11, 410);
            tblt_barcodeLabel.Name = "tblt_barcodeLabel";
            tblt_barcodeLabel.Size = new System.Drawing.Size(86, 17);
            tblt_barcodeLabel.TabIndex = 24;
            tblt_barcodeLabel.Text = "tblt barcode:";
            // 
            // tblt_drop_DelayLabel
            // 
            tblt_drop_DelayLabel.AutoSize = true;
            tblt_drop_DelayLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tblt_drop_DelayLabel.Location = new System.Drawing.Point(201, 105);
            tblt_drop_DelayLabel.Name = "tblt_drop_DelayLabel";
            tblt_drop_DelayLabel.Size = new System.Drawing.Size(103, 17);
            tblt_drop_DelayLabel.TabIndex = 26;
            tblt_drop_DelayLabel.Text = "tblt drop Delay:";
            // 
            // tblt_enddateLabel
            // 
            tblt_enddateLabel.AutoSize = true;
            tblt_enddateLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tblt_enddateLabel.Location = new System.Drawing.Point(7, 456);
            tblt_enddateLabel.Name = "tblt_enddateLabel";
            tblt_enddateLabel.Size = new System.Drawing.Size(86, 17);
            tblt_enddateLabel.TabIndex = 28;
            tblt_enddateLabel.Text = "tblt enddate:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Location = new System.Drawing.Point(12, 13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(tblt_enddateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tblt_enddateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(tblt_drop_DelayLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tblt_drop_DelayTextBox);
            this.splitContainer1.Panel2.Controls.Add(tblt_barcodeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tblt_barcodeTextBox);
            this.splitContainer1.Panel2.Controls.Add(cst_weightLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cst_weightTextBox);
            this.splitContainer1.Panel2.Controls.Add(tblt_min_qtyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tblt_min_qtyTextBox);
            this.splitContainer1.Panel2.Controls.Add(tblt_qty_dtmLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tblt_qty_dtmTextBox);
            this.splitContainer1.Panel2.Controls.Add(tblt_qtyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tblt_qtyTextBox);
            this.splitContainer1.Panel2.Controls.Add(cLSF_STATELabel);
            this.splitContainer1.Panel2.Controls.Add(this.cLSF_STATETextBox);
            this.splitContainer1.Panel2.Controls.Add(cST_CLSF_CDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cST_CLSF_CDTextBox);
            this.splitContainer1.Panel2.Controls.Add(tRAY_LRLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tRAY_LRTextBox);
            this.splitContainer1.Panel2.Controls.Add(tRAY_ROWLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tRAY_ROWTextBox);
            this.splitContainer1.Panel2.Controls.Add(tRAY_LAYERLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tRAY_LAYERTextBox);
            this.splitContainer1.Panel2.Controls.Add(uSE_YNLabel);
            this.splitContainer1.Panel2.Controls.Add(this.uSE_YNCheckBox);
            this.splitContainer1.Panel2.Controls.Add(tblt_cdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.tblt_cdTextBox);
            this.splitContainer1.Panel2.Controls.Add(cST_NUMLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cST_NUMTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(803, 596);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTNUMDataGridViewTextBoxColumn,
            this.tbltqtyDataGridViewTextBoxColumn,
            this.USE_YN});
            this.dataGridView1.DataSource = this.drugBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(387, 596);
            this.dataGridView1.TabIndex = 0;
            // 
            // USE_YN
            // 
            this.USE_YN.DataPropertyName = "USE_YN";
            this.USE_YN.HeaderText = "USE_YN";
            this.USE_YN.Name = "USE_YN";
            // 
            // tblt_enddateDateTimePicker
            // 
            this.tblt_enddateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.drugBindingSource, "tblt_enddate", true));
            this.tblt_enddateDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblt_enddateDateTimePicker.Location = new System.Drawing.Point(99, 450);
            this.tblt_enddateDateTimePicker.Name = "tblt_enddateDateTimePicker";
            this.tblt_enddateDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.tblt_enddateDateTimePicker.TabIndex = 29;
            // 
            // tblt_drop_DelayTextBox
            // 
            this.tblt_drop_DelayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "tblt_drop_Delay", true));
            this.tblt_drop_DelayTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblt_drop_DelayTextBox.Location = new System.Drawing.Point(304, 102);
            this.tblt_drop_DelayTextBox.Name = "tblt_drop_DelayTextBox";
            this.tblt_drop_DelayTextBox.Size = new System.Drawing.Size(100, 25);
            this.tblt_drop_DelayTextBox.TabIndex = 27;
            // 
            // tblt_barcodeTextBox
            // 
            this.tblt_barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "tblt_barcode", true));
            this.tblt_barcodeTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblt_barcodeTextBox.Location = new System.Drawing.Point(99, 407);
            this.tblt_barcodeTextBox.Name = "tblt_barcodeTextBox";
            this.tblt_barcodeTextBox.Size = new System.Drawing.Size(135, 25);
            this.tblt_barcodeTextBox.TabIndex = 25;
            // 
            // cst_weightTextBox
            // 
            this.cst_weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "cst_weight", true));
            this.cst_weightTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_weightTextBox.Location = new System.Drawing.Point(99, 494);
            this.cst_weightTextBox.Name = "cst_weightTextBox";
            this.cst_weightTextBox.Size = new System.Drawing.Size(100, 25);
            this.cst_weightTextBox.TabIndex = 23;
            // 
            // tblt_min_qtyTextBox
            // 
            this.tblt_min_qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "tblt_min_qty", true));
            this.tblt_min_qtyTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblt_min_qtyTextBox.Location = new System.Drawing.Point(297, 360);
            this.tblt_min_qtyTextBox.Name = "tblt_min_qtyTextBox";
            this.tblt_min_qtyTextBox.Size = new System.Drawing.Size(100, 25);
            this.tblt_min_qtyTextBox.TabIndex = 21;
            // 
            // tblt_qty_dtmTextBox
            // 
            this.tblt_qty_dtmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "tblt_qty_dtm", true));
            this.tblt_qty_dtmTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblt_qty_dtmTextBox.Location = new System.Drawing.Point(297, 322);
            this.tblt_qty_dtmTextBox.Name = "tblt_qty_dtmTextBox";
            this.tblt_qty_dtmTextBox.Size = new System.Drawing.Size(100, 25);
            this.tblt_qty_dtmTextBox.TabIndex = 19;
            // 
            // tblt_qtyTextBox
            // 
            this.tblt_qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "tblt_qty", true));
            this.tblt_qtyTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblt_qtyTextBox.Location = new System.Drawing.Point(99, 365);
            this.tblt_qtyTextBox.Name = "tblt_qtyTextBox";
            this.tblt_qtyTextBox.Size = new System.Drawing.Size(100, 25);
            this.tblt_qtyTextBox.TabIndex = 17;
            // 
            // cLSF_STATETextBox
            // 
            this.cLSF_STATETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "CLSF_STATE", true));
            this.cLSF_STATETextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLSF_STATETextBox.Location = new System.Drawing.Point(99, 322);
            this.cLSF_STATETextBox.Name = "cLSF_STATETextBox";
            this.cLSF_STATETextBox.Size = new System.Drawing.Size(100, 25);
            this.cLSF_STATETextBox.TabIndex = 15;
            // 
            // cST_CLSF_CDTextBox
            // 
            this.cST_CLSF_CDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "CST_CLSF_CD", true));
            this.cST_CLSF_CDTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cST_CLSF_CDTextBox.Location = new System.Drawing.Point(304, 67);
            this.cST_CLSF_CDTextBox.Name = "cST_CLSF_CDTextBox";
            this.cST_CLSF_CDTextBox.Size = new System.Drawing.Size(100, 25);
            this.cST_CLSF_CDTextBox.TabIndex = 13;
            // 
            // tRAY_LRTextBox
            // 
            this.tRAY_LRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "TRAY_LR", true));
            this.tRAY_LRTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRAY_LRTextBox.Location = new System.Drawing.Point(99, 133);
            this.tRAY_LRTextBox.Name = "tRAY_LRTextBox";
            this.tRAY_LRTextBox.Size = new System.Drawing.Size(100, 25);
            this.tRAY_LRTextBox.TabIndex = 11;
            // 
            // tRAY_ROWTextBox
            // 
            this.tRAY_ROWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "TRAY_ROW", true));
            this.tRAY_ROWTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRAY_ROWTextBox.Location = new System.Drawing.Point(99, 99);
            this.tRAY_ROWTextBox.Name = "tRAY_ROWTextBox";
            this.tRAY_ROWTextBox.Size = new System.Drawing.Size(100, 25);
            this.tRAY_ROWTextBox.TabIndex = 9;
            // 
            // tRAY_LAYERTextBox
            // 
            this.tRAY_LAYERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "TRAY_LAYER", true));
            this.tRAY_LAYERTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRAY_LAYERTextBox.Location = new System.Drawing.Point(99, 64);
            this.tRAY_LAYERTextBox.Name = "tRAY_LAYERTextBox";
            this.tRAY_LAYERTextBox.Size = new System.Drawing.Size(100, 25);
            this.tRAY_LAYERTextBox.TabIndex = 7;
            // 
            // uSE_YNCheckBox
            // 
            this.uSE_YNCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.drugBindingSource, "USE_YN", true));
            this.uSE_YNCheckBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSE_YNCheckBox.Location = new System.Drawing.Point(300, 26);
            this.uSE_YNCheckBox.Name = "uSE_YNCheckBox";
            this.uSE_YNCheckBox.Size = new System.Drawing.Size(104, 24);
            this.uSE_YNCheckBox.TabIndex = 5;
            this.uSE_YNCheckBox.Text = "checkBox1";
            this.uSE_YNCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblt_cdTextBox
            // 
            this.tblt_cdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "tblt_cd", true));
            this.tblt_cdTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblt_cdTextBox.Location = new System.Drawing.Point(99, 194);
            this.tblt_cdTextBox.Name = "tblt_cdTextBox";
            this.tblt_cdTextBox.Size = new System.Drawing.Size(100, 25);
            this.tblt_cdTextBox.TabIndex = 3;
            // 
            // cST_NUMTextBox
            // 
            this.cST_NUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugBindingSource, "CST_NUM", true));
            this.cST_NUMTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cST_NUMTextBox.Location = new System.Drawing.Point(99, 26);
            this.cST_NUMTextBox.Name = "cST_NUMTextBox";
            this.cST_NUMTextBox.Size = new System.Drawing.Size(100, 25);
            this.cST_NUMTextBox.TabIndex = 1;
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(89, 625);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(75, 43);
            this.button_ADD.TabIndex = 1;
            this.button_ADD.Text = "新增";
            this.button_ADD.UseVisualStyleBackColor = true;
            this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // button_MODY
            // 
            this.button_MODY.Location = new System.Drawing.Point(181, 625);
            this.button_MODY.Name = "button_MODY";
            this.button_MODY.Size = new System.Drawing.Size(75, 43);
            this.button_MODY.TabIndex = 2;
            this.button_MODY.Text = "修改";
            this.button_MODY.UseVisualStyleBackColor = true;
            this.button_MODY.Click += new System.EventHandler(this.button_MODY_Click);
            // 
            // button_DEL
            // 
            this.button_DEL.Location = new System.Drawing.Point(278, 625);
            this.button_DEL.Name = "button_DEL";
            this.button_DEL.Size = new System.Drawing.Size(75, 43);
            this.button_DEL.TabIndex = 3;
            this.button_DEL.Text = "刪除";
            this.button_DEL.UseVisualStyleBackColor = true;
            this.button_DEL.Click += new System.EventHandler(this.button_DEL_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(486, 625);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 43);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "確定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_CANCLE
            // 
            this.button_CANCLE.Location = new System.Drawing.Point(578, 625);
            this.button_CANCLE.Name = "button_CANCLE";
            this.button_CANCLE.Size = new System.Drawing.Size(75, 43);
            this.button_CANCLE.TabIndex = 5;
            this.button_CANCLE.Text = "取消";
            this.button_CANCLE.UseVisualStyleBackColor = true;
            this.button_CANCLE.Click += new System.EventHandler(this.button_CANCLE_Click);
            // 
            // button_CLOSE
            // 
            this.button_CLOSE.Location = new System.Drawing.Point(740, 625);
            this.button_CLOSE.Name = "button_CLOSE";
            this.button_CLOSE.Size = new System.Drawing.Size(75, 43);
            this.button_CLOSE.TabIndex = 6;
            this.button_CLOSE.Text = "關閉";
            this.button_CLOSE.UseVisualStyleBackColor = true;
            this.button_CLOSE.Click += new System.EventHandler(this.button_CLOSE_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 30;
            this.button1.Text = "搜尋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(48, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 25);
            this.textBox1.TabIndex = 31;
            // 
            // cSTNUMDataGridViewTextBoxColumn
            // 
            this.cSTNUMDataGridViewTextBoxColumn.DataPropertyName = "CST_NUM";
            this.cSTNUMDataGridViewTextBoxColumn.HeaderText = "CST_NUM";
            this.cSTNUMDataGridViewTextBoxColumn.Name = "cSTNUMDataGridViewTextBoxColumn";
            // 
            // tbltqtyDataGridViewTextBoxColumn
            // 
            this.tbltqtyDataGridViewTextBoxColumn.DataPropertyName = "tblt_qty";
            this.tbltqtyDataGridViewTextBoxColumn.HeaderText = "tblt_qty";
            this.tbltqtyDataGridViewTextBoxColumn.Name = "tbltqtyDataGridViewTextBoxColumn";
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataMember = "Cassette_Info";
            this.drugBindingSource.DataSource = this.pRINTERDataSet;
            // 
            // pRINTERDataSet
            // 
            this.pRINTERDataSet.DataSetName = "PRINTERDataSet";
            this.pRINTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutItemBindingSource
            // 
            this.layoutItemBindingSource.DataMember = "LayoutItem";
            this.layoutItemBindingSource.DataSource = this.pRINTERDataSet;
            // 
            // taLayoutItem
            // 
            this.taLayoutItem.ClearBeforeFill = true;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cassette_InfoTableAdapter = this.cassette_InfoTableAdapter;
            this.tableAdapterManager.currentPreItemTableAdapter = null;
            this.tableAdapterManager.currentPreTableAdapter = null;
            this.tableAdapterManager.Direction_InfoTableAdapter = null;
            this.tableAdapterManager.Direction_Time_InfoTableAdapter = null;
            this.tableAdapterManager.DrugTableAdapter = null;
            this.tableAdapterManager.ExcipientTableAdapter = null;
            this.tableAdapterManager.his_PrescriptionItemTableAdapter = null;
            this.tableAdapterManager.his_PrescriptionTableAdapter = null;
            this.tableAdapterManager.LayoutItem1TableAdapter = null;
            this.tableAdapterManager.MedicineTableAdapter = null;
            this.tableAdapterManager.PrePackItemTableAdapter = null;
            this.tableAdapterManager.PrePackTableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_INFO1TableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_INFOTableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_PERIODTableAdapter = null;
            this.tableAdapterManager.taLayout = null;
            this.tableAdapterManager.taLayoutItem = null;
            this.tableAdapterManager.taPacket = null;
            this.tableAdapterManager.taPacketItem = null;
            this.tableAdapterManager.taPrescription = null;
            this.tableAdapterManager.taPrescriptionItem = null;
            this.tableAdapterManager.tatmp_Prescription = null;
            this.tableAdapterManager.taTTP = null;
            this.tableAdapterManager.taUDPOWMED = null;
            this.tableAdapterManager.taUDPOWPAT = null;
            this.tableAdapterManager.UpdateOrder = VP.PRINTERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cassette_InfoTableAdapter
            // 
            this.cassette_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Cassetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 681);
            this.Controls.Add(this.button_CLOSE);
            this.Controls.Add(this.button_CANCLE);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_DEL);
            this.Controls.Add(this.button_MODY);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cassetes";
            this.Text = "Cassetes";
            this.Load += new System.EventHandler(this.Cassetes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource layoutItemBindingSource;
        private PRINTERDataSet pRINTERDataSet;
        private VP.PRINTERDataSetTableAdapters.taLayoutItem taLayoutItem;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private VP.PRINTERDataSetTableAdapters.DrugTableAdapter drugTableAdapter;
        private VP.PRINTERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.Button button_MODY;
        private System.Windows.Forms.Button button_DEL;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_CANCLE;
        private System.Windows.Forms.Button button_CLOSE;
        private PRINTERDataSetTableAdapters.Cassette_InfoTableAdapter cassette_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbltqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn USE_YN;
        private System.Windows.Forms.DateTimePicker tblt_enddateDateTimePicker;
        private System.Windows.Forms.TextBox tblt_drop_DelayTextBox;
        private System.Windows.Forms.TextBox tblt_barcodeTextBox;
        private System.Windows.Forms.TextBox cst_weightTextBox;
        private System.Windows.Forms.TextBox tblt_min_qtyTextBox;
        private System.Windows.Forms.TextBox tblt_qty_dtmTextBox;
        private System.Windows.Forms.TextBox tblt_qtyTextBox;
        private System.Windows.Forms.TextBox cLSF_STATETextBox;
        private System.Windows.Forms.TextBox cST_CLSF_CDTextBox;
        private System.Windows.Forms.TextBox tRAY_LRTextBox;
        private System.Windows.Forms.TextBox tRAY_ROWTextBox;
        private System.Windows.Forms.TextBox tRAY_LAYERTextBox;
        private System.Windows.Forms.CheckBox uSE_YNCheckBox;
        private System.Windows.Forms.TextBox tblt_cdTextBox;
        private System.Windows.Forms.TextBox cST_NUMTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}