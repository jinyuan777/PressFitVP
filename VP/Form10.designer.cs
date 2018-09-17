namespace VP
{
    partial class Form10
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
            System.Windows.Forms.Label drugNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bsPrePack = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrinter = new VP.PRINTERDataSet();
            this.taPrePack = new VP.PRINTERDataSetTableAdapters.PrePackTableAdapter();
            this.tableAdapterManager = new VP.PRINTERDataSetTableAdapters.TableAdapterManager();
            this.taMedicine = new VP.PRINTERDataSetTableAdapters.MedicineTableAdapter();
            this.taPrePackItem = new VP.PRINTERDataSetTableAdapters.PrePackItemTableAdapter();
            this.taLayoutItem = new VP.PRINTERDataSetTableAdapters.taLayoutItem();
            this.taTTP = new VP.PRINTERDataSetTableAdapters.taTTP();
            this.bsLayoutItem = new System.Windows.Forms.BindingSource(this.components);
            this.bsTTP = new System.Windows.Forms.BindingSource(this.components);
            this.timer_USBPacker = new System.Windows.Forms.Timer(this.components);
            this.dgvPrePack = new System.Windows.Forms.DataGridView();
            this.dgvPrePackItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsMedicine = new System.Windows.Forms.BindingSource(this.components);
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugAName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPrePack_PrePackItem = new System.Windows.Forms.BindingSource(this.components);
            this.drugNameComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Layout = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTPText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drugNameLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrePack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLayoutItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrePack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrePackItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrePack_PrePackItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drugNameLabel
            // 
            drugNameLabel.AutoSize = true;
            drugNameLabel.Location = new System.Drawing.Point(8, 276);
            drugNameLabel.Name = "drugNameLabel";
            drugNameLabel.Size = new System.Drawing.Size(117, 26);
            drugNameLabel.TabIndex = 26;
            drugNameLabel.Text = "尋找藥品：";
            drugNameLabel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(78, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(100, 108);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "總包數";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(4, 32);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(92, 71);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "1";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(186, 45);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(4, 47);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 66);
            this.button4.TabIndex = 1;
            this.button4.Text = "-";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Pink;
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(584, 13);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 18;
            this.button7.Text = "關閉";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.GreenYellow;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ImageIndex = 0;
            this.button5.Location = new System.Drawing.Point(260, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 17;
            this.button5.Text = "藥粉包裝";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(-520, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(520, 440);
            this.panel.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(368, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 25;
            this.button1.Text = "錠劑包裝";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ImageIndex = 0;
            this.button2.Location = new System.Drawing.Point(476, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 26;
            this.button2.Text = "混合包裝";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bsPrePack
            // 
            this.bsPrePack.DataMember = "PrePack";
            this.bsPrePack.DataSource = this.dsPrinter;
            this.bsPrePack.CurrentChanged += new System.EventHandler(this.bsPrePack_CurrentChanged);
            this.bsPrePack.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bsPrePack_AddingNew);
            // 
            // dsPrinter
            // 
            this.dsPrinter.DataSetName = "dsPrinter";
            this.dsPrinter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taPrePack
            // 
            this.taPrePack.ClearBeforeFill = true;
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
            this.tableAdapterManager.PrePackItemTableAdapter = this.taPrePackItem;
            this.tableAdapterManager.PrePackTableAdapter = this.taPrePack;
            this.tableAdapterManager.TAKE_TIME_INFO1TableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_INFOTableAdapter = null;
            this.tableAdapterManager.TAKE_TIME_PERIODTableAdapter = null;
            this.tableAdapterManager.taLayout = null;
            this.tableAdapterManager.taLayoutItem = this.taLayoutItem;
            this.tableAdapterManager.taPacket = null;
            this.tableAdapterManager.taPacketItem = null;
            this.tableAdapterManager.taPrescription = null;
            this.tableAdapterManager.taPrescriptionItem = null;
            this.tableAdapterManager.tatmp_Prescription = null;
            this.tableAdapterManager.taTTP = this.taTTP;
            this.tableAdapterManager.taUDPOWMED = null;
            this.tableAdapterManager.taUDPOWPAT = null;
            this.tableAdapterManager.UpdateOrder = VP.PRINTERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taMedicine
            // 
            this.taMedicine.ClearBeforeFill = true;
            // 
            // taPrePackItem
            // 
            this.taPrePackItem.ClearBeforeFill = true;
            // 
            // taLayoutItem
            // 
            this.taLayoutItem.ClearBeforeFill = true;
            // 
            // taTTP
            // 
            this.taTTP.ClearBeforeFill = true;
            // 
            // bsLayoutItem
            // 
            this.bsLayoutItem.DataMember = "LayoutItem";
            this.bsLayoutItem.DataSource = this.dsPrinter;
            // 
            // bsTTP
            // 
            this.bsTTP.DataMember = "TTP";
            this.bsTTP.DataSource = this.dsPrinter;
            // 
            // timer_USBPacker
            // 
            this.timer_USBPacker.Enabled = true;
            this.timer_USBPacker.Interval = 200;
            this.timer_USBPacker.Tick += new System.EventHandler(this.timer_USBPacker_Tick);
            // 
            // dgvPrePack
            // 
            this.dgvPrePack.AllowUserToAddRows = false;
            this.dgvPrePack.AutoGenerateColumns = false;
            this.dgvPrePack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrePack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Layout,
            this.dataGridViewTextBoxColumn2,
            this.TTPText,
            this.dataGridViewTextBoxColumn6,
            this.PackDate,
            this.dataGridViewTextBoxColumn5});
            this.dgvPrePack.DataSource = this.bsPrePack;
            this.dgvPrePack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrePack.Location = new System.Drawing.Point(0, 0);
            this.dgvPrePack.Name = "dgvPrePack";
            this.dgvPrePack.RowTemplate.Height = 24;
            this.dgvPrePack.Size = new System.Drawing.Size(1184, 179);
            this.dgvPrePack.TabIndex = 26;
            this.dgvPrePack.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPrePack_UserDeletingRow);
            this.dgvPrePack.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPrePack_UserDeletedRow);
            // 
            // dgvPrePackItem
            // 
            this.dgvPrePackItem.AllowUserToAddRows = false;
            this.dgvPrePackItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrePackItem.AutoGenerateColumns = false;
            this.dgvPrePackItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrePackItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.DrugName,
            this.DrugAName,
            this.DrugCName,
            this.Dosage,
            this.Sharp,
            this.dataGridViewTextBoxColumn12});
            this.dgvPrePackItem.DataSource = this.bsPrePack_PrePackItem;
            this.dgvPrePackItem.Location = new System.Drawing.Point(3, 48);
            this.dgvPrePackItem.Name = "dgvPrePackItem";
            this.dgvPrePackItem.RowTemplate.Height = 24;
            this.dgvPrePackItem.Size = new System.Drawing.Size(1178, 223);
            this.dgvPrePackItem.TabIndex = 26;
            this.dgvPrePackItem.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPrePackItem_UserDeletingRow);
            this.dgvPrePackItem.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvPrePackItem_UserDeletedRow);
            this.dgvPrePackItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrePackItem_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PrePackItemKey";
            this.dataGridViewTextBoxColumn7.DataSource = this.bsMedicine;
            this.dataGridViewTextBoxColumn7.DisplayMember = "UDRPNAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "PrePackItemKey";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "UDRPNAME";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // bsMedicine
            // 
            this.bsMedicine.DataMember = "Medicine";
            this.bsMedicine.DataSource = this.dsPrinter;
            this.bsMedicine.PositionChanged += new System.EventHandler(this.bsMedicine_PositionChanged);
            // 
            // DrugName
            // 
            this.DrugName.DataPropertyName = "DrugName";
            this.DrugName.HeaderText = "藥品名稱";
            this.DrugName.Name = "DrugName";
            this.DrugName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DrugName.Width = 460;
            // 
            // DrugAName
            // 
            this.DrugAName.DataPropertyName = "DrugAName";
            this.DrugAName.HeaderText = "學名";
            this.DrugAName.Name = "DrugAName";
            this.DrugAName.Width = 300;
            // 
            // DrugCName
            // 
            this.DrugCName.DataPropertyName = "DrugCName";
            this.DrugCName.HeaderText = "中文名稱";
            this.DrugCName.Name = "DrugCName";
            this.DrugCName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DrugCName.Width = 300;
            // 
            // Dosage
            // 
            this.Dosage.DataPropertyName = "Dosage";
            this.Dosage.HeaderText = "配藥量";
            this.Dosage.Name = "Dosage";
            // 
            // Sharp
            // 
            this.Sharp.DataPropertyName = "Sharp";
            this.Sharp.HeaderText = "外觀";
            this.Sharp.Name = "Sharp";
            this.Sharp.Width = 300;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PrePackKey";
            this.dataGridViewTextBoxColumn12.HeaderText = "PrePackKey";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // bsPrePack_PrePackItem
            // 
            this.bsPrePack_PrePackItem.DataMember = "PrePack_PrePackItem";
            this.bsPrePack_PrePackItem.DataSource = this.bsPrePack;
            this.bsPrePack_PrePackItem.CurrentChanged += new System.EventHandler(this.bsPrePack_PrePackItem_CurrentChanged);
            // 
            // drugNameComboBox
            // 
            this.drugNameComboBox.DataSource = this.bsMedicine;
            this.drugNameComboBox.DisplayMember = "UDRPNAME";
            this.drugNameComboBox.DropDownHeight = 400;
            this.drugNameComboBox.DropDownWidth = 500;
            this.drugNameComboBox.FormattingEnabled = true;
            this.drugNameComboBox.IntegralHeight = false;
            this.drugNameComboBox.Location = new System.Drawing.Point(131, 273);
            this.drugNameComboBox.Name = "drugNameComboBox";
            this.drugNameComboBox.Size = new System.Drawing.Size(783, 34);
            this.drugNameComboBox.TabIndex = 27;
            this.drugNameComboBox.ValueMember = "UDRPNAME";
            this.drugNameComboBox.Visible = false;
            this.drugNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.drugNameComboBox_SelectionChangeCommitted);
            this.drugNameComboBox.SelectedIndexChanged += new System.EventHandler(this.drugNameComboBox_SelectedIndexChanged);
            this.drugNameComboBox.SelectedValueChanged += new System.EventHandler(this.drugNameComboBox_SelectedValueChanged_1);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsPrePack;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator4,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripSeparator6});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1175, 35);
            this.bindingNavigator1.TabIndex = 32;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 32);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(116, 32);
            this.bindingNavigatorDeleteItem.Text = "刪除格式";
            this.bindingNavigatorDeleteItem.Visible = false;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(142, 32);
            this.bindingNavigatorAddNewItem.Text = "新的印表格式";
            this.bindingNavigatorAddNewItem.ToolTipText = "新的印表格式";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            this.toolStripSeparator1.Visible = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(58, 32);
            this.toolStripButton2.Text = "儲存";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 32);
            this.toolStripLabel1.Text = "預覽";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(229, 32);
            this.toolStripButton1.Text = "更新PKD及BUD(30天)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(224, 32);
            this.toolStripButton3.Text = "更新PKD及BUD(一年)";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(920, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 34);
            this.button6.TabIndex = 33;
            this.button6.Text = "更新藥品";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1037, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 34);
            this.button8.TabIndex = 34;
            this.button8.Text = "加入藥品";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 35);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "查詢藥品：";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(567, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 36);
            this.button9.TabIndex = 37;
            this.button9.Text = "查詢";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_2);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPrePack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPrePackItem);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 459);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(0, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 133);
            this.panel1.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PrePackKey";
            this.dataGridViewTextBoxColumn1.HeaderText = "PrePackKey";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Layout
            // 
            this.Layout.DataPropertyName = "Layout";
            this.Layout.HeaderText = "列印格式";
            this.Layout.Items.AddRange(new object[] {
            "粉劑",
            "錠劑"});
            this.Layout.Name = "Layout";
            this.Layout.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Layout.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Layout.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PackName";
            this.dataGridViewTextBoxColumn2.HeaderText = "檔名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // TTPText
            // 
            this.TTPText.DataPropertyName = "TTPText";
            this.TTPText.HeaderText = "服法";
            this.TTPText.Name = "TTPText";
            this.TTPText.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LOT";
            this.dataGridViewTextBoxColumn6.HeaderText = "LOT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 260;
            // 
            // PackDate
            // 
            this.PackDate.DataPropertyName = "EDate";
            this.PackDate.HeaderText = "包裝日期";
            this.PackDate.Name = "PackDate";
            this.PackDate.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BUD";
            this.dataGridViewTextBoxColumn5.FillWeight = 200F;
            this.dataGridViewTextBoxColumn5.HeaderText = "BUD";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1175, 621);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(drugNameLabel);
            this.Controls.Add(this.drugNameComboBox);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form10";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "預包作業";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrePack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLayoutItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrePack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrePackItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrePack_PrePackItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsPrePack;
        private VP.PRINTERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public PRINTERDataSet dsPrinter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        public VP.PRINTERDataSetTableAdapters.PrePackTableAdapter taPrePack;
        private VP.PRINTERDataSetTableAdapters.taLayoutItem taLayoutItem;
        private System.Windows.Forms.BindingSource bsLayoutItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VP.PRINTERDataSetTableAdapters.PrePackItemTableAdapter taPrePackItem;
        private VP.PRINTERDataSetTableAdapters.taTTP taTTP;
        private System.Windows.Forms.BindingSource bsTTP;
        private System.Windows.Forms.Timer timer_USBPacker;
        private System.Windows.Forms.DataGridView dgvPrePack;
        private System.Windows.Forms.DataGridView dgvPrePackItem;
        private System.Windows.Forms.ComboBox drugNameComboBox;
        private VP.PRINTERDataSetTableAdapters.MedicineTableAdapter taMedicine;
        private System.Windows.Forms.BindingSource bsMedicine;
        private System.Windows.Forms.BindingSource bsPrePack_PrePackItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugAName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Layout;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTPText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}