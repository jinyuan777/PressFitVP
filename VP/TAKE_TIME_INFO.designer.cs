namespace VP
{
    partial class TAKE_TIME_INFO
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
            System.Windows.Forms.Label tAKE_TIME_CDLabel;
            System.Windows.Forms.Label tAKE_TIME_NMLabel;
            System.Windows.Forms.Label pRT_TEXTLabel;
            System.Windows.Forms.Label sORT_KEYLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tAKETIMECDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAKETIMENMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRTTEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORTKEYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAKETPCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAKETIMEINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRINTERDataSet = new VP.PRINTERDataSet();
            this.SORT_BOX = new System.Windows.Forms.TextBox();
            this.PRT_BOX = new System.Windows.Forms.TextBox();
            this.TTNM_BOX = new System.Windows.Forms.TextBox();
            this.TTCD_BOX = new System.Windows.Forms.TextBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_DEL = new System.Windows.Forms.Button();
            this.Button_MODY = new System.Windows.Forms.Button();
            this.Button_ADD = new System.Windows.Forms.Button();
            this.tAKE_TIME_INFOTableAdapter = new VP.PRINTERDataSetTableAdapters.TAKE_TIME_INFOTableAdapter();
            this.tableAdapterManager = new VP.PRINTERDataSetTableAdapters.TableAdapterManager();
            tAKE_TIME_CDLabel = new System.Windows.Forms.Label();
            tAKE_TIME_NMLabel = new System.Windows.Forms.Label();
            pRT_TEXTLabel = new System.Windows.Forms.Label();
            sORT_KEYLabel = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKETIMEINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tAKE_TIME_CDLabel
            // 
            tAKE_TIME_CDLabel.AutoSize = true;
            tAKE_TIME_CDLabel.Location = new System.Drawing.Point(68, 81);
            tAKE_TIME_CDLabel.Name = "tAKE_TIME_CDLabel";
            tAKE_TIME_CDLabel.Size = new System.Drawing.Size(80, 12);
            tAKE_TIME_CDLabel.TabIndex = 0;
            tAKE_TIME_CDLabel.Text = "服用時間編碼:";
            // 
            // tAKE_TIME_NMLabel
            // 
            tAKE_TIME_NMLabel.AutoSize = true;
            tAKE_TIME_NMLabel.Location = new System.Drawing.Point(68, 139);
            tAKE_TIME_NMLabel.Name = "tAKE_TIME_NMLabel";
            tAKE_TIME_NMLabel.Size = new System.Drawing.Size(80, 12);
            tAKE_TIME_NMLabel.TabIndex = 2;
            tAKE_TIME_NMLabel.Text = "服用時間名稱:";
            // 
            // pRT_TEXTLabel
            // 
            pRT_TEXTLabel.AutoSize = true;
            pRT_TEXTLabel.Location = new System.Drawing.Point(68, 200);
            pRT_TEXTLabel.Name = "pRT_TEXTLabel";
            pRT_TEXTLabel.Size = new System.Drawing.Size(80, 12);
            pRT_TEXTLabel.TabIndex = 4;
            pRT_TEXTLabel.Text = "包裝列印內容:";
            // 
            // sORT_KEYLabel
            // 
            sORT_KEYLabel.AutoSize = true;
            sORT_KEYLabel.Location = new System.Drawing.Point(68, 256);
            sORT_KEYLabel.Name = "sORT_KEYLabel";
            sORT_KEYLabel.Size = new System.Drawing.Size(32, 12);
            sORT_KEYLabel.TabIndex = 6;
            sORT_KEYLabel.Text = "排序:";
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
            this.splitContainer1.Size = new System.Drawing.Size(742, 636);
            this.splitContainer1.SplitterDistance = 559;
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
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer2.Panel2.Controls.Add(sORT_KEYLabel);
            this.splitContainer2.Panel2.Controls.Add(this.SORT_BOX);
            this.splitContainer2.Panel2.Controls.Add(pRT_TEXTLabel);
            this.splitContainer2.Panel2.Controls.Add(this.PRT_BOX);
            this.splitContainer2.Panel2.Controls.Add(tAKE_TIME_NMLabel);
            this.splitContainer2.Panel2.Controls.Add(this.TTNM_BOX);
            this.splitContainer2.Panel2.Controls.Add(tAKE_TIME_CDLabel);
            this.splitContainer2.Panel2.Controls.Add(this.TTCD_BOX);
            this.splitContainer2.Size = new System.Drawing.Size(742, 559);
            this.splitContainer2.SplitterDistance = 377;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tAKETIMECDDataGridViewTextBoxColumn,
            this.tAKETIMENMDataGridViewTextBoxColumn,
            this.pRTTEXTDataGridViewTextBoxColumn,
            this.sORTKEYDataGridViewTextBoxColumn,
            this.tAKETPCDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tAKETIMEINFOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(377, 559);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tAKETIMECDDataGridViewTextBoxColumn
            // 
            this.tAKETIMECDDataGridViewTextBoxColumn.DataPropertyName = "TAKE_TIME_CD";
            this.tAKETIMECDDataGridViewTextBoxColumn.HeaderText = "服用時間編碼";
            this.tAKETIMECDDataGridViewTextBoxColumn.Name = "tAKETIMECDDataGridViewTextBoxColumn";
            // 
            // tAKETIMENMDataGridViewTextBoxColumn
            // 
            this.tAKETIMENMDataGridViewTextBoxColumn.DataPropertyName = "TAKE_TIME_NM";
            this.tAKETIMENMDataGridViewTextBoxColumn.HeaderText = "服用時間名稱";
            this.tAKETIMENMDataGridViewTextBoxColumn.Name = "tAKETIMENMDataGridViewTextBoxColumn";
            // 
            // pRTTEXTDataGridViewTextBoxColumn
            // 
            this.pRTTEXTDataGridViewTextBoxColumn.DataPropertyName = "PRT_TEXT";
            this.pRTTEXTDataGridViewTextBoxColumn.HeaderText = "PRT_TEXT";
            this.pRTTEXTDataGridViewTextBoxColumn.Name = "pRTTEXTDataGridViewTextBoxColumn";
            this.pRTTEXTDataGridViewTextBoxColumn.Visible = false;
            // 
            // sORTKEYDataGridViewTextBoxColumn
            // 
            this.sORTKEYDataGridViewTextBoxColumn.DataPropertyName = "SORT_KEY";
            this.sORTKEYDataGridViewTextBoxColumn.HeaderText = "排序";
            this.sORTKEYDataGridViewTextBoxColumn.Name = "sORTKEYDataGridViewTextBoxColumn";
            // 
            // tAKETPCDDataGridViewTextBoxColumn
            // 
            this.tAKETPCDDataGridViewTextBoxColumn.DataPropertyName = "TAKE_TP_CD";
            this.tAKETPCDDataGridViewTextBoxColumn.HeaderText = "TAKE_TP_CD";
            this.tAKETPCDDataGridViewTextBoxColumn.Name = "tAKETPCDDataGridViewTextBoxColumn";
            this.tAKETPCDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tAKETIMEINFOBindingSource
            // 
            this.tAKETIMEINFOBindingSource.DataMember = "TAKE_TIME_INFO";
            this.tAKETIMEINFOBindingSource.DataSource = this.pRINTERDataSet;
            // 
            // pRINTERDataSet
            // 
            this.pRINTERDataSet.DataSetName = "PRINTERDataSet";
            this.pRINTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SORT_BOX
            // 
            this.SORT_BOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SORT_BOX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAKETIMEINFOBindingSource, "SORT_KEY", true));
            this.SORT_BOX.Location = new System.Drawing.Point(70, 271);
            this.SORT_BOX.Name = "SORT_BOX";
            this.SORT_BOX.Size = new System.Drawing.Size(89, 22);
            this.SORT_BOX.TabIndex = 7;
            // 
            // PRT_BOX
            // 
            this.PRT_BOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PRT_BOX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAKETIMEINFOBindingSource, "PRT_TEXT", true));
            this.PRT_BOX.Location = new System.Drawing.Point(70, 215);
            this.PRT_BOX.Name = "PRT_BOX";
            this.PRT_BOX.Size = new System.Drawing.Size(141, 22);
            this.PRT_BOX.TabIndex = 5;
            // 
            // TTNM_BOX
            // 
            this.TTNM_BOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TTNM_BOX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAKETIMEINFOBindingSource, "TAKE_TIME_NM", true));
            this.TTNM_BOX.Location = new System.Drawing.Point(70, 154);
            this.TTNM_BOX.Name = "TTNM_BOX";
            this.TTNM_BOX.Size = new System.Drawing.Size(141, 22);
            this.TTNM_BOX.TabIndex = 3;
            // 
            // TTCD_BOX
            // 
            this.TTCD_BOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TTCD_BOX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAKETIMEINFOBindingSource, "TAKE_TIME_CD", true));
            this.TTCD_BOX.Location = new System.Drawing.Point(70, 96);
            this.TTCD_BOX.Name = "TTCD_BOX";
            this.TTCD_BOX.Size = new System.Drawing.Size(141, 22);
            this.TTCD_BOX.TabIndex = 1;
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(649, 13);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(81, 48);
            this.Button_Close.TabIndex = 11;
            this.Button_Close.Text = "關閉";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(494, 19);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(81, 37);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(411, 19);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(81, 37);
            this.Button_OK.TabIndex = 9;
            this.Button_OK.Text = "確定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_DEL
            // 
            this.Button_DEL.Location = new System.Drawing.Point(249, 13);
            this.Button_DEL.Name = "Button_DEL";
            this.Button_DEL.Size = new System.Drawing.Size(81, 48);
            this.Button_DEL.TabIndex = 8;
            this.Button_DEL.Text = "刪除";
            this.Button_DEL.UseVisualStyleBackColor = true;
            this.Button_DEL.Click += new System.EventHandler(this.Button_DEL_Click);
            // 
            // Button_MODY
            // 
            this.Button_MODY.Location = new System.Drawing.Point(162, 13);
            this.Button_MODY.Name = "Button_MODY";
            this.Button_MODY.Size = new System.Drawing.Size(81, 48);
            this.Button_MODY.TabIndex = 7;
            this.Button_MODY.Text = "修改";
            this.Button_MODY.UseVisualStyleBackColor = true;
            this.Button_MODY.Click += new System.EventHandler(this.Button_MODY_Click);
            // 
            // Button_ADD
            // 
            this.Button_ADD.Location = new System.Drawing.Point(75, 13);
            this.Button_ADD.Name = "Button_ADD";
            this.Button_ADD.Size = new System.Drawing.Size(81, 48);
            this.Button_ADD.TabIndex = 6;
            this.Button_ADD.Text = "新增";
            this.Button_ADD.UseVisualStyleBackColor = true;
            this.Button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
            // 
            // tAKE_TIME_INFOTableAdapter
            // 
            this.tAKE_TIME_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.currentPreItemTableAdapter = null;
            this.tableAdapterManager.currentPreTableAdapter = null;
            this.tableAdapterManager.Direction_InfoTableAdapter = null;
            this.tableAdapterManager.Direction_Time_InfoTableAdapter = null;
            this.tableAdapterManager.ExcipientTableAdapter = null;
            this.tableAdapterManager.his_PrescriptionItemTableAdapter = null;
            this.tableAdapterManager.his_PrescriptionTableAdapter = null;
            this.tableAdapterManager.LayoutItem1TableAdapter = null;
            this.tableAdapterManager.MedicineTableAdapter = null;
            this.tableAdapterManager.PrePackItemTableAdapter = null;
            this.tableAdapterManager.PrePackTableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_INFO1TableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_INFOTableAdapter = this.tAKE_TIME_INFOTableAdapter;
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
            // TAKE_TIME_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(742, 636);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TAKE_TIME_INFO";
            this.Text = "TAKE_TIME_INFO";
            this.Load += new System.EventHandler(this.TAKE_TIME_INFO_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKETIMEINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRINTERDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_DEL;
        private System.Windows.Forms.Button Button_MODY;
        private System.Windows.Forms.Button Button_ADD;
        private PRINTERDataSet pRINTERDataSet;
        private System.Windows.Forms.BindingSource tAKETIMEINFOBindingSource;
        private VP.PRINTERDataSetTableAdapters.TAKE_TIME_INFOTableAdapter tAKE_TIME_INFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAKETIMECDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAKETIMENMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRTTEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORTKEYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAKETPCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SORT_BOX;
        private System.Windows.Forms.TextBox PRT_BOX;
        private System.Windows.Forms.TextBox TTNM_BOX;
        private System.Windows.Forms.TextBox TTCD_BOX;
        private VP.PRINTERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}