namespace VP
{
    partial class Form12
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
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ADD = new System.Windows.Forms.ToolStripMenuItem();
            this.DEL = new System.Windows.Forms.ToolStripMenuItem();
            this.bsMedicine = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrinter = new VP.PRINTERDataSet();
            this.button7 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new VP.PRINTERDataSetTableAdapters.TableAdapterManager();
            this.taMedicine = new VP.PRINTERDataSetTableAdapters.MedicineTableAdapter();
            this.UDDRGNO_TXT = new System.Windows.Forms.TextBox();
            this.drvMedicine = new System.Windows.Forms.DataGridView();
            this.uDDRGNODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDRPNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDHIMDPNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDCHTNAMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLDESCHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPRDESCHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDAPRNUMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(16, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "加至處方";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADD,
            this.DEL});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // ADD
            // 
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(94, 22);
            this.ADD.Text = "新增";
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DEL
            // 
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(94, 22);
            this.DEL.Text = "刪除";
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // bsMedicine
            // 
            this.bsMedicine.DataMember = "Medicine";
            this.bsMedicine.DataSource = this.dsPrinter;
            // 
            // dsPrinter
            // 
            this.dsPrinter.DataSetName = "dsPrinter";
            this.dsPrinter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Pink;
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(139, 373);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 19;
            this.button7.Text = "關閉";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.tableAdapterManager.MedicineTableAdapter = this.taMedicine;
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
            // taMedicine
            // 
            this.taMedicine.ClearBeforeFill = true;
            // 
            // UDDRGNO_TXT
            // 
            this.UDDRGNO_TXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMedicine, "UDDRGNO", true));
            this.UDDRGNO_TXT.Location = new System.Drawing.Point(1023, 378);
            this.UDDRGNO_TXT.Name = "UDDRGNO_TXT";
            this.UDDRGNO_TXT.Size = new System.Drawing.Size(157, 35);
            this.UDDRGNO_TXT.TabIndex = 21;
            // 
            // drvMedicine
            // 
            this.drvMedicine.AllowUserToAddRows = false;
            this.drvMedicine.AutoGenerateColumns = false;
            this.drvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.drvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uDDRGNODataGridViewTextBoxColumn1,
            this.uDRPNAMEDataGridViewTextBoxColumn1,
            this.uDHIMDPNDataGridViewTextBoxColumn1,
            this.uDCHTNAMDataGridViewTextBoxColumn1,
            this.cOLDESCHDataGridViewTextBoxColumn1,
            this.aPRDESCHDataGridViewTextBoxColumn1,
            this.uDAPRNUMDataGridViewTextBoxColumn1});
            this.drvMedicine.ContextMenuStrip = this.contextMenuStrip1;
            this.drvMedicine.DataSource = this.bsMedicine;
            this.drvMedicine.Location = new System.Drawing.Point(5, 12);
            this.drvMedicine.Name = "drvMedicine";
            this.drvMedicine.RowTemplate.Height = 24;
            this.drvMedicine.Size = new System.Drawing.Size(1175, 350);
            this.drvMedicine.TabIndex = 22;
            // 
            // uDDRGNODataGridViewTextBoxColumn1
            // 
            this.uDDRGNODataGridViewTextBoxColumn1.DataPropertyName = "UDDRGNO";
            this.uDDRGNODataGridViewTextBoxColumn1.HeaderText = "藥品代碼";
            this.uDDRGNODataGridViewTextBoxColumn1.Name = "uDDRGNODataGridViewTextBoxColumn1";
            this.uDDRGNODataGridViewTextBoxColumn1.Width = 121;
            // 
            // uDRPNAMEDataGridViewTextBoxColumn1
            // 
            this.uDRPNAMEDataGridViewTextBoxColumn1.DataPropertyName = "UDRPNAME";
            this.uDRPNAMEDataGridViewTextBoxColumn1.HeaderText = "藥品名稱";
            this.uDRPNAMEDataGridViewTextBoxColumn1.Name = "uDRPNAMEDataGridViewTextBoxColumn1";
            this.uDRPNAMEDataGridViewTextBoxColumn1.Width = 121;
            // 
            // uDHIMDPNDataGridViewTextBoxColumn1
            // 
            this.uDHIMDPNDataGridViewTextBoxColumn1.DataPropertyName = "UDHIMDPN";
            this.uDHIMDPNDataGridViewTextBoxColumn1.HeaderText = "UDHIMDPN";
            this.uDHIMDPNDataGridViewTextBoxColumn1.Name = "uDHIMDPNDataGridViewTextBoxColumn1";
            this.uDHIMDPNDataGridViewTextBoxColumn1.Width = 159;
            // 
            // uDCHTNAMDataGridViewTextBoxColumn1
            // 
            this.uDCHTNAMDataGridViewTextBoxColumn1.DataPropertyName = "UDCHTNAM";
            this.uDCHTNAMDataGridViewTextBoxColumn1.HeaderText = "產品名稱";
            this.uDCHTNAMDataGridViewTextBoxColumn1.Name = "uDCHTNAMDataGridViewTextBoxColumn1";
            this.uDCHTNAMDataGridViewTextBoxColumn1.Width = 121;
            // 
            // cOLDESCHDataGridViewTextBoxColumn1
            // 
            this.cOLDESCHDataGridViewTextBoxColumn1.DataPropertyName = "COLDESCH";
            this.cOLDESCHDataGridViewTextBoxColumn1.HeaderText = "顏色";
            this.cOLDESCHDataGridViewTextBoxColumn1.Name = "cOLDESCHDataGridViewTextBoxColumn1";
            this.cOLDESCHDataGridViewTextBoxColumn1.Width = 79;
            // 
            // aPRDESCHDataGridViewTextBoxColumn1
            // 
            this.aPRDESCHDataGridViewTextBoxColumn1.DataPropertyName = "APRDESCH";
            this.aPRDESCHDataGridViewTextBoxColumn1.HeaderText = "形狀";
            this.aPRDESCHDataGridViewTextBoxColumn1.Name = "aPRDESCHDataGridViewTextBoxColumn1";
            this.aPRDESCHDataGridViewTextBoxColumn1.Width = 79;
            // 
            // uDAPRNUMDataGridViewTextBoxColumn1
            // 
            this.uDAPRNUMDataGridViewTextBoxColumn1.DataPropertyName = "UDAPRNUM";
            this.uDAPRNUMDataGridViewTextBoxColumn1.HeaderText = "UDAPRNUM";
            this.uDAPRNUMDataGridViewTextBoxColumn1.Name = "uDAPRNUMDataGridViewTextBoxColumn1";
            this.uDAPRNUMDataGridViewTextBoxColumn1.Width = 165;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            this.button2.Location = new System.Drawing.Point(466, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 100);
            this.button2.TabIndex = 23;
            this.button2.Text = "確定";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.drvMedicine);
            this.Controls.Add(this.UDDRGNO_TXT);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "選擇藥品名稱";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drvMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private VP.PRINTERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bsMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public PRINTERDataSet dsPrinter;
        public VP.PRINTERDataSetTableAdapters.MedicineTableAdapter taMedicine;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DEL;
        private System.Windows.Forms.TextBox UDDRGNO_TXT;
        private System.Windows.Forms.ToolStripMenuItem ADD;
        private System.Windows.Forms.DataGridView drvMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDDRGNODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDRPNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDHIMDPNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDCHTNAMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLDESCHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPRDESCHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDAPRNUMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button2;
    }
}