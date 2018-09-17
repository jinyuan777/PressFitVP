namespace VP
{
    partial class FREQ
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
            System.Windows.Forms.Label dRTS_CDLabel;
            System.Windows.Forms.Label dRTS_NMLabel;
            System.Windows.Forms.Label sORT_KEYLabel;
            System.Windows.Forms.Label pRT_TEXTLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DirectionGV = new System.Windows.Forms.DataGridView();
            this.dRTSCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRTSNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORTKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRINTERDataSet = new VP.PRINTERDataSet();
            this.tAKETIMEINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TTPGV = new System.Windows.Forms.DataGridView();
            this.tAKETPCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAKETPNMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHOSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAKETIMEPERIODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRT_TEXTTextBox = new System.Windows.Forms.TextBox();
            this.sORT_KEYTextBox = new System.Windows.Forms.TextBox();
            this.dRTS_NMTextBox = new System.Windows.Forms.TextBox();
            this.dRTS_CDTextBox = new System.Windows.Forms.TextBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_MODY = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.direction_InfoTableAdapter = new VP.PRINTERDataSetTableAdapters.Direction_InfoTableAdapter();
            this.tableAdapterManager = new VP.PRINTERDataSetTableAdapters.TableAdapterManager();
            this.direction_Time_InfoTableAdapter = new VP.PRINTERDataSetTableAdapters.Direction_Time_InfoTableAdapter();
            this.tAKE_TIME_INFOTableAdapter = new VP.PRINTERDataSetTableAdapters.TAKE_TIME_INFOTableAdapter();
            this.tAKE_TIME_PERIODTableAdapter = new VP.PRINTERDataSetTableAdapters.TAKE_TIME_PERIODTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            dRTS_CDLabel = new System.Windows.Forms.Label();
            dRTS_NMLabel = new System.Windows.Forms.Label();
            sORT_KEYLabel = new System.Windows.Forms.Label();
            pRT_TEXTLabel = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKETIMEINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTPGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKETIMEPERIODBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dRTS_CDLabel
            // 
            dRTS_CDLabel.AutoSize = true;
            dRTS_CDLabel.Location = new System.Drawing.Point(24, 9);
            dRTS_CDLabel.Name = "dRTS_CDLabel";
            dRTS_CDLabel.Size = new System.Drawing.Size(80, 12);
            dRTS_CDLabel.TabIndex = 0;
            dRTS_CDLabel.Text = "服藥指示編碼:";
            // 
            // dRTS_NMLabel
            // 
            dRTS_NMLabel.AutoSize = true;
            dRTS_NMLabel.Location = new System.Drawing.Point(24, 59);
            dRTS_NMLabel.Name = "dRTS_NMLabel";
            dRTS_NMLabel.Size = new System.Drawing.Size(56, 12);
            dRTS_NMLabel.TabIndex = 2;
            dRTS_NMLabel.Text = "服用方式:";
            // 
            // sORT_KEYLabel
            // 
            sORT_KEYLabel.AutoSize = true;
            sORT_KEYLabel.Location = new System.Drawing.Point(28, 161);
            sORT_KEYLabel.Name = "sORT_KEYLabel";
            sORT_KEYLabel.Size = new System.Drawing.Size(32, 12);
            sORT_KEYLabel.TabIndex = 6;
            sORT_KEYLabel.Text = "排序:";
            // 
            // pRT_TEXTLabel
            // 
            pRT_TEXTLabel.AutoSize = true;
            pRT_TEXTLabel.Location = new System.Drawing.Point(27, 110);
            pRT_TEXTLabel.Name = "pRT_TEXTLabel";
            pRT_TEXTLabel.Size = new System.Drawing.Size(56, 12);
            pRT_TEXTLabel.TabIndex = 8;
            pRT_TEXTLabel.Text = "列印內容:";
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Button_Close);
            this.splitContainer1.Panel2.Controls.Add(this.Button_Cancel);
            this.splitContainer1.Panel2.Controls.Add(this.Button_OK);
            this.splitContainer1.Panel2.Controls.Add(this.Button_DEL);
            this.splitContainer1.Panel2.Controls.Add(this.Button_MODY);
            this.splitContainer1.Panel2.Controls.Add(this.Button_ADD);
            this.splitContainer1.Size = new System.Drawing.Size(741, 634);
            this.splitContainer1.SplitterDistance = 556;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DirectionGV);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel2.Controls.Add(this.TTPGV);
            this.splitContainer2.Panel2.Controls.Add(pRT_TEXTLabel);
            this.splitContainer2.Panel2.Controls.Add(this.pRT_TEXTTextBox);
            this.splitContainer2.Panel2.Controls.Add(sORT_KEYLabel);
            this.splitContainer2.Panel2.Controls.Add(this.sORT_KEYTextBox);
            this.splitContainer2.Panel2.Controls.Add(dRTS_NMLabel);
            this.splitContainer2.Panel2.Controls.Add(this.dRTS_NMTextBox);
            this.splitContainer2.Panel2.Controls.Add(dRTS_CDLabel);
            this.splitContainer2.Panel2.Controls.Add(this.dRTS_CDTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(741, 556);
            this.splitContainer2.SplitterDistance = 383;
            this.splitContainer2.TabIndex = 0;
            // 
            // DirectionGV
            // 
            this.DirectionGV.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DirectionGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DirectionGV.AutoGenerateColumns = false;
            this.DirectionGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DirectionGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DirectionGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dRTSCDDataGridViewTextBoxColumn,
            this.dRTSNMDataGridViewTextBoxColumn,
            this.sORTKEYDataGridViewTextBoxColumn});
            this.DirectionGV.DataSource = this.directionInfoBindingSource;
            this.DirectionGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectionGV.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.DirectionGV.Location = new System.Drawing.Point(0, 0);
            this.DirectionGV.MultiSelect = false;
            this.DirectionGV.Name = "DirectionGV";
            this.DirectionGV.RowTemplate.Height = 24;
            this.DirectionGV.Size = new System.Drawing.Size(383, 556);
            this.DirectionGV.TabIndex = 0;
            this.DirectionGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DirectionGV_CellClick);
            // 
            // dRTSCDDataGridViewTextBoxColumn
            // 
            this.dRTSCDDataGridViewTextBoxColumn.DataPropertyName = "DRTS_CD";
            this.dRTSCDDataGridViewTextBoxColumn.HeaderText = "服藥指示編碼";
            this.dRTSCDDataGridViewTextBoxColumn.Name = "dRTSCDDataGridViewTextBoxColumn";
            // 
            // dRTSNMDataGridViewTextBoxColumn
            // 
            this.dRTSNMDataGridViewTextBoxColumn.DataPropertyName = "DRTS_NM";
            this.dRTSNMDataGridViewTextBoxColumn.HeaderText = "服用方式";
            this.dRTSNMDataGridViewTextBoxColumn.Name = "dRTSNMDataGridViewTextBoxColumn";
            // 
            // sORTKEYDataGridViewTextBoxColumn
            // 
            this.sORTKEYDataGridViewTextBoxColumn.DataPropertyName = "SORT_KEY";
            this.sORTKEYDataGridViewTextBoxColumn.HeaderText = "排序";
            this.sORTKEYDataGridViewTextBoxColumn.Name = "sORTKEYDataGridViewTextBoxColumn";
            // 
            // directionInfoBindingSource
            // 
            this.directionInfoBindingSource.DataMember = "Direction_Info";
            this.directionInfoBindingSource.DataSource = this.pRINTERDataSet;
            // 
            // pRINTERDataSet
            // 
            this.pRINTERDataSet.DataSetName = "PRINTERDataSet";
            this.pRINTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAKETIMEINFOBindingSource
            // 
            this.tAKETIMEINFOBindingSource.DataMember = "TAKE_TIME_INFO";
            this.tAKETIMEINFOBindingSource.DataSource = this.pRINTERDataSet;
            // 
            // TTPGV
            // 
            this.TTPGV.AllowUserToAddRows = false;
            this.TTPGV.AllowUserToDeleteRows = false;
            this.TTPGV.AllowUserToResizeColumns = false;
            this.TTPGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TTPGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TTPGV.AutoGenerateColumns = false;
            this.TTPGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TTPGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTPGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tAKETPCDDataGridViewTextBoxColumn,
            this.tAKETPNMDataGridViewTextBoxColumn,
            this.CHOSE});
            this.TTPGV.DataSource = this.tAKETIMEPERIODBindingSource;
            this.TTPGV.Location = new System.Drawing.Point(26, 285);
            this.TTPGV.MultiSelect = false;
            this.TTPGV.Name = "TTPGV";
            this.TTPGV.RowTemplate.Height = 24;
            this.TTPGV.Size = new System.Drawing.Size(243, 263);
            this.TTPGV.TabIndex = 10;
            this.TTPGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tAKETPCDDataGridViewTextBoxColumn
            // 
            this.tAKETPCDDataGridViewTextBoxColumn.DataPropertyName = "TAKE_TP_CD";
            this.tAKETPCDDataGridViewTextBoxColumn.HeaderText = "TAKE_TP_CD";
            this.tAKETPCDDataGridViewTextBoxColumn.Name = "tAKETPCDDataGridViewTextBoxColumn";
            this.tAKETPCDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tAKETPNMDataGridViewTextBoxColumn
            // 
            this.tAKETPNMDataGridViewTextBoxColumn.DataPropertyName = "TAKE_TP_NM";
            this.tAKETPNMDataGridViewTextBoxColumn.HeaderText = "TAKE_TP_NM";
            this.tAKETPNMDataGridViewTextBoxColumn.Name = "tAKETPNMDataGridViewTextBoxColumn";
            // 
            // CHOSE
            // 
            this.CHOSE.HeaderText = "服用";
            this.CHOSE.Name = "CHOSE";
            // 
            // tAKETIMEPERIODBindingSource
            // 
            this.tAKETIMEPERIODBindingSource.DataMember = "TAKE_TIME_PERIOD";
            this.tAKETIMEPERIODBindingSource.DataSource = this.pRINTERDataSet;
            // 
            // pRT_TEXTTextBox
            // 
            this.pRT_TEXTTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pRT_TEXTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directionInfoBindingSource, "PRT_TEXT", true));
            this.pRT_TEXTTextBox.Location = new System.Drawing.Point(26, 125);
            this.pRT_TEXTTextBox.Name = "pRT_TEXTTextBox";
            this.pRT_TEXTTextBox.Size = new System.Drawing.Size(100, 22);
            this.pRT_TEXTTextBox.TabIndex = 9;
            // 
            // sORT_KEYTextBox
            // 
            this.sORT_KEYTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.sORT_KEYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directionInfoBindingSource, "SORT_KEY", true));
            this.sORT_KEYTextBox.Location = new System.Drawing.Point(26, 176);
            this.sORT_KEYTextBox.Name = "sORT_KEYTextBox";
            this.sORT_KEYTextBox.Size = new System.Drawing.Size(100, 22);
            this.sORT_KEYTextBox.TabIndex = 7;
            // 
            // dRTS_NMTextBox
            // 
            this.dRTS_NMTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.dRTS_NMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directionInfoBindingSource, "DRTS_NM", true));
            this.dRTS_NMTextBox.Location = new System.Drawing.Point(26, 74);
            this.dRTS_NMTextBox.Name = "dRTS_NMTextBox";
            this.dRTS_NMTextBox.Size = new System.Drawing.Size(145, 22);
            this.dRTS_NMTextBox.TabIndex = 3;
            // 
            // dRTS_CDTextBox
            // 
            this.dRTS_CDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.dRTS_CDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directionInfoBindingSource, "DRTS_CD", true));
            this.dRTS_CDTextBox.Location = new System.Drawing.Point(26, 24);
            this.dRTS_CDTextBox.Name = "dRTS_CDTextBox";
            this.dRTS_CDTextBox.Size = new System.Drawing.Size(145, 22);
            this.dRTS_CDTextBox.TabIndex = 1;
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(648, 19);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(81, 48);
            this.Button_Close.TabIndex = 5;
            this.Button_Close.Text = "關閉";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(493, 25);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(81, 37);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(410, 25);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(81, 37);
            this.Button_OK.TabIndex = 3;
            this.Button_OK.Text = "確定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(248, 19);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(81, 48);
            this.Button_DEL.TabIndex = 2;
            this.Button_DEL.Text = "刪除";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_MODY
            // 
            this.Button_MODY.Location = new System.Drawing.Point(161, 19);
            this.Button_MODY.Name = "Button_MODY";
            this.Button_MODY.Size = new System.Drawing.Size(81, 48);
            this.Button_MODY.TabIndex = 1;
            this.Button_MODY.Text = "修改";
            this.Button_MODY.UseVisualStyleBackColor = true;
            this.Button_MODY.Click += new System.EventHandler(this.Button_MODY_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(74, 19);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(81, 48);
            this.Button_ADD.TabIndex = 0;
            this.Button_ADD.Text = "新增";
            this.Button_ADD.UseVisualStyleBackColor = true;
            this.Button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
            // 
            // direction_InfoTableAdapter
            // 
            this.direction_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.currentPreItemTableAdapter = null;
            this.tableAdapterManager.currentPreTableAdapter = null;
            this.tableAdapterManager.Direction_InfoTableAdapter = this.direction_InfoTableAdapter;
            this.tableAdapterManager.Direction_Time_InfoTableAdapter = this.direction_Time_InfoTableAdapter;
            this.tableAdapterManager.ExcipientTableAdapter = null;
            this.tableAdapterManager.his_PrescriptionItemTableAdapter = null;
            this.tableAdapterManager.his_PrescriptionTableAdapter = null;
            this.tableAdapterManager.MedicineTableAdapter = null;
            this.tableAdapterManager.PrePackItemTableAdapter = null;
            this.tableAdapterManager.PrePackTableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_INFOTableAdapter = this.tAKE_TIME_INFOTableAdapter;
            this.tableAdapterManager.TAKE_TIME_PERIODTableAdapter = this.tAKE_TIME_PERIODTableAdapter;
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
            // direction_Time_InfoTableAdapter
            // 
            this.direction_Time_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tAKE_TIME_INFOTableAdapter
            // 
            this.tAKE_TIME_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // tAKE_TIME_PERIODTableAdapter
            // 
            this.tAKE_TIME_PERIODTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAKETIMEINFOBindingSource, "TAKE_TIME_CD", true));
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "服用時間";
            // 
            // FREQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 634);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FREQ";
            this.Text = "FREQ";
            this.Load += new System.EventHandler(this.FREQ_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DirectionGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKETIMEINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTPGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKETIMEPERIODBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView DirectionGV;
        private PRINTERDataSet pRINTERDataSet;
        private System.Windows.Forms.BindingSource directionInfoBindingSource;
        private VP.PRINTERDataSetTableAdapters.Direction_InfoTableAdapter direction_InfoTableAdapter;
        private System.Windows.Forms.TextBox pRT_TEXTTextBox;
        private System.Windows.Forms.TextBox sORT_KEYTextBox;
        private System.Windows.Forms.TextBox dRTS_NMTextBox;
        private System.Windows.Forms.TextBox dRTS_CDTextBox;
        private VP.PRINTERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView TTPGV;
        private VP.PRINTERDataSetTableAdapters.TAKE_TIME_PERIODTableAdapter tAKE_TIME_PERIODTableAdapter;
        private System.Windows.Forms.BindingSource tAKETIMEPERIODBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAKETPCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAKETPNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHOSE;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_MODY;
        private System.Windows.Forms.Button Button_ADD;
        private VP.PRINTERDataSetTableAdapters.TAKE_TIME_INFOTableAdapter tAKE_TIME_INFOTableAdapter;
        private System.Windows.Forms.BindingSource tAKETIMEINFOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRTSCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRTSNMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORTKEYDataGridViewTextBoxColumn;
        private VP.PRINTERDataSetTableAdapters.Direction_Time_InfoTableAdapter direction_Time_InfoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}