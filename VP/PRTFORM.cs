using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using USBLab;
using System.Data.OleDb;
namespace VP
{
    public partial class PRTFORM : Form
    {
        public PRTFORM()
        {
            InitializeComponent();
        }
        enum State
        {
            ADD,
            MODY,
            DEL
        }
        DataView dvPrescription;
        DataRowView drvPrescription;
        DataView dvPrescriptionItem;
        private DataSetPrinter dsP = new DataSetPrinter();
        Bitmap bmp;
        DataView dvMedical;
        int Position = 0;
        List<Button> Button_A = new List<Button>();
        List<Button> Button_B = new List<Button>();
        State Mode = new State();
        List<string> DelKey = new List<string>();
        private void PRTFORM_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'printerDataSet.Layout' 資料表。您可以視需要進行移動或移除。
            this.layoutTableAdapter.Fill(this.printerDataSet.Layout);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.LayoutItem1' 資料表。您可以視需要進行移動或移除。
            this.taLayoutItem1.FillALL(this.printerDataSet.LayoutItem1);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.Prescription' 資料表。您可以視需要進行移動或移除。
            this.taPrescription.Fill(this.printerDataSet.Prescription);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.PrescriptionItem' 資料表。您可以視需要進行移動或移除。
            this.taPrescriptionItem.Fill(this.printerDataSet.PrescriptionItem);
            for(int i =0;i<this.printerDataSet.Prescription.Rows.Count;i++){
                this.printerDataSet.Prescription.Rows.RemoveAt(i);
            }
            Button_A.Add(PRTFOR_BUTON_ADD);
            Button_A.Add(PRTFOR_BUTON_MODY);
            Button_A.Add(PRTFOR_BUTON_DEL);
            Button_A.Add(PRTFOR_BUTON_CLOSE);
            Button_B.Add(PRTFOR_BUTON_OK);
            Button_B.Add(BUTON_CANCLE);
            foreach (Button s in Button_A)
                s.Enabled = true;
            foreach (Button s in Button_B)
                s.Enabled = false;
            layoutItemDataGridView.Enabled = false;
            this.printerDataSet.Prescription.Rows.Add("1234567890", "1234567890", "男", "1985/01/01", "28", "住院門診", "1985/01/01", "00:00:00", "藥劑科", "和謙實業", 1, true, DateTime.Now, "", "疾病名", "和謙實業醫院",
            "", "PatientFrom", "", "", "ABCD", "WardBed", DateTime.Now, 1, 1, 1, "", false, "一日四次飯後服用", "1985/01/01", "00:00:00", "和謙實業", 
            "1234567890", "服法代碼", "1234567890", "1234567890", "1985/01/01", "1985/01/01", "PackType", "Excipient", true, true );

            this.printerDataSet.PrescriptionItem.Rows.Add("00001", "1234567890", "藥品代碼", "藥品名稱", "服法代碼", "01", "001", "藥品總量", "藥品單位", true, "1234567890", string.Empty, "1234567890",
             "否", string.Empty, string.Empty, string.Empty, "Unit", "DOSAGE", DateTime.Now, DateTime.Now);
            this.printerDataSet.PrescriptionItem.Rows.Add("00002", "1234567890", "藥品代碼", "藥品名稱", "服法代碼", "01", "001", "藥品總量", "藥品單位", true, "1234567890", string.Empty, "1234567890",
             "否", string.Empty, string.Empty, string.Empty, "Unit", "DOSAGE", DateTime.Now, DateTime.Now);
            this.printerDataSet.PrescriptionItem.Rows.Add("00004", "1234567890", "藥品代碼", "藥品名稱", "服法代碼", "01", "001", "藥品總量", "藥品單位", true, "1234567890", string.Empty, "1234567890",
             "否", string.Empty, string.Empty, string.Empty, "Unit", "DOSAGE", DateTime.Now, DateTime.Now);
            this.printerDataSet.PrescriptionItem.Rows.Add("00005", "1234567890", "藥品代碼", "藥品名稱", "服法代碼", "01", "001", "藥品總量", "藥品單位", true, "1234567890", string.Empty, "1234567890",
             "否", string.Empty, string.Empty, string.Empty, "Unit", "DOSAGE", DateTime.Now, DateTime.Now);
            this.printerDataSet.PrescriptionItem.Rows.Add("00006", "1234567890", "藥品代碼", "藥品名稱", "服法代碼", "01", "001", "藥品總量", "藥品單位", true, "1234567890", string.Empty, "1234567890",
             "否", string.Empty, string.Empty, string.Empty, "Unit", "DOSAGE", DateTime.Now, DateTime.Now);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.Layout' 資料表。您可以視需要進行移動或移除。
            this.taLayout.Fill(this.printerDataSet.Layout);



            dvPrescription = new DataView(this.printerDataSet.Prescription);
            dvPrescription.Sort = "PrescriptionKey";
            //Position = dvPrescription.Find("T991091821108031542421");
            //if (Position != -1)
            //{
            drvPrescription = dvPrescription[0];
            dvPrescriptionItem = drvPrescription.CreateChildView("Prescription_PrescriptionItem");
            //}

            taLayoutItem.Fill(printerDataSet.LayoutItem,3);
            taLayoutItem1.FillALL(printerDataSet.LayoutItem1);
            DataView dvlayoutitem = new DataView(printerDataSet.LayoutItem);
            IMG img = new IMG();

            Bitmap bmp = img.PrescriptionLayout(dvlayoutitem, drvPrescription, dvPrescriptionItem, panel1);

            Packer.HexData = new List<byte[]>();
            Packer.HexData.Add(img.GetHex(bmp));
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taLayoutItem.Update(this.printerDataSet.LayoutItem);
            taLayoutItem.Fill(printerDataSet.LayoutItem, int.Parse(layoutKeyTextBox.Text));
            var Temp = from DataRow i in printerDataSet.LayoutItem1.Rows where i["LayoutKey"].ToString().Equals(layoutKeyTextBox.Text) select i;
            DataTable TempDT = printerDataSet.LayoutItem.Copy();
            TempDT.Rows.Clear();
            foreach (DataRow row in Temp)
            {
                TempDT.ImportRow(row);
            }
            DataView dvlayoutitem = new DataView(TempDT);
            IMG img = new IMG();

            Bitmap bmp = img.PrescriptionLayout(dvlayoutitem, drvPrescription, dvPrescriptionItem, panel1);

            Packer.HexData = new List<byte[]>();
            Packer.HexData.Add(img.GetHex(bmp));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            taLayoutItem.Update(this.printerDataSet.LayoutItem);
            taLayoutItem.Fill(printerDataSet.LayoutItem, int.Parse(layoutKeyTextBox.Text));
            DataView dvlayoutitem = new DataView(printerDataSet.LayoutItem);
            IMG img = new IMG();

            Bitmap bmp = img.PrescriptionLayout(dvlayoutitem, drvPrescription, dvPrescriptionItem, panel1);

            Packer.HexData = new List<byte[]>();
            Packer.HexData.Add(img.GetHex(bmp));
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataRow row = printerDataSet.LayoutItem1.NewRow();
            row["LayoutItemKey"] = DateTime.Now.ToString("yyyyMMddHHmmss");
            row["LayoutKey"] = layoutKeyTextBox.Text;
            row["FontName"] = "微軟正黑體";
            row["Align"] = "TopLeft";
            row["AutoSize"] = true;
            row["Visible"] = true;
            this.printerDataSet.LayoutItem1.Rows.Add(row);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //DataView DV = new DataView(this.printerDataSet.LayoutItem1);           
            //DV.Sort = "LayoutItemKey";
            //int Position = DV.Find(layoutItemKeyTextBox.Text);

            DataRow[] rows = this.printerDataSet.LayoutItem1.Select("LayoutItemKey = \'" + layoutItemKeyTextBox.Text + "\'");
            DelKey.Add(layoutItemKeyTextBox.Text);
            this.printerDataSet.LayoutItem1.Rows.Remove(rows[0]);
            this.printerDataSet.LayoutItem1.AcceptChanges();

        }

        private void BUTON_OK_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            switch (Mode)
            { 
                case State.ADD:
                    DataRow row = printerDataSet.Layout.NewRow();
                    row["LayoutKey"] = int.Parse(layoutKeyTextBox.Text);
                    row["IsPrint"] = true;
                    row["LabelDisplay"] = labelDisplayTextBox.Text;
                    this.printerDataSet.Layout.Rows.Add(row);
                    foreach (DataRow x in this.printerDataSet.LayoutItem1.Rows)
                        x["LayoutKey"] = layoutKeyTextBox.Text; 
                    break;
                case State.MODY:
                    this.printerDataSet.Layout.AcceptChanges();
                    dsP.cn.Open();
                    foreach (string s in DelKey)
                    {
                        cmd = new OleDbCommand("DELETE * FROM LayoutItem where LayoutItemKey = ? ", dsP.cn);
                        cmd.Parameters.Add(new OleDbParameter("?LayoutItemKey", OleDbType.Char, 20)).Value = s;
                        cmd.ExecuteNonQuery();
                    }
                    dsP.cn.Close();
                    break;
                case State.DEL:
                    dsP.cn.Open();
                    cmd = new OleDbCommand("DELETE * FROM Layout where LayoutKey = ? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?TAKE_TP_CD", OleDbType.Integer, 10)).Value = int.Parse(layoutKeyTextBox.Text);
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand("DELETE * FROM LayoutItem where LayoutKey = ? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?TAKE_TP_CD", OleDbType.Integer, 10)).Value = int.Parse(layoutKeyTextBox.Text);
                    cmd.ExecuteNonQuery();
                    dsP.cn.Close();    
                    break;
            }
            OleDbCommandBuilder aa = new OleDbCommandBuilder(taLayout.Adapter);
            taLayout.Adapter.Update(this.printerDataSet.Layout);
            OleDbCommandBuilder bb = new OleDbCommandBuilder(taLayoutItem1.Adapter);
            taLayoutItem1.Adapter.Update(printerDataSet.LayoutItem1);

            System.Threading.Thread.Sleep(2000);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.Layout' 資料表。您可以視需要進行移動或移除。
            this.layoutTableAdapter.Fill(this.printerDataSet.Layout);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.LayoutItem1' 資料表。您可以視需要進行移動或移除。
            this.taLayoutItem1.FillALL(this.printerDataSet.LayoutItem1);
            foreach (Button s in Button_A)
                s.Enabled = true; ;
            foreach (Button s in Button_B)
                s.Enabled = false;
            layoutItemDataGridView.Enabled = false;
            LayoutDv.Enabled = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BOX1.Visible = true;
        }

        private void BOXSURE_Click(object sender, EventArgs e)
        {
            int Position = layoutItemDataGridView.CurrentRow.Index;
            layoutItemDataGridView.Rows[Position].Cells["dataGridViewTextBoxColumn3"].Value = BOX_Combobox_1.Text;
            layoutItemDataGridView.Rows[Position].Cells["dataGridViewTextBoxColumn4"].Value = Box_Combobox_2.Text;
            BOX1.Visible = false;
        }

        private void BOXCANCLE_Click(object sender, EventArgs e)
        {
            BOX1.Visible = false;
        }

        private void BUTON_DEL_Click(object sender, EventArgs e)
        {
            foreach (Button s in Button_A)
                s.Enabled = false;
            foreach (Button s in Button_B)
                s.Enabled = true;

            Mode = State.DEL;
            layoutItemDataGridView.Enabled = true;
            LayoutDv.Enabled = false;
        }

        private void BOX_Combobox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Box_Combobox_2.Items.Clear();
            if (BOX_Combobox_1.Text == "Prescription")
            {
                foreach (DataColumn column in this.printerDataSet.Prescription.Columns)
                {
                    Box_Combobox_2.Items.Add(column.ColumnName);
                }
            }
            else if (BOX_Combobox_1.Text == "Drugs") 
            {
                foreach (DataColumn column in this.printerDataSet.PrescriptionItem.Columns)
                {
                    Box_Combobox_2.Items.Add(column.ColumnName);
                }              
            }
        }

        private void PRTFOR_BUTON_ADD_Click(object sender, EventArgs e)
        {
            foreach (Button s in Button_A)
                s.Enabled = false;
            foreach (Button s in Button_B)
                s.Enabled = true;
            this.printerDataSet.LayoutItem1.Rows.Clear();
            layoutKeyTextBox.Text = string.Empty;
            labelDisplayTextBox.Text = string.Empty;
            Mode = State.ADD;
            layoutItemDataGridView.Enabled = true;
            LayoutDv.Enabled = false;
        }

        private void PRTFOR_BUTON_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int ItemRowNumber = 0;
        private void layoutItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(4))
            {
                ItemRowNumber = e.RowIndex;
                fontDialog.ShowDialog();
            }
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {
            layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewTextBoxColumn10"].Value = fontDialog.Font.Name;
            //layoutItemDataGridView.Rows[ItemRowNumber].Cells["\dataGridViewTextBoxColumn7"].Value = fontDialog.Font.
            layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewTextBoxColumn8"].Value = fontDialog.Font.GetHeight();
            //layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewTextBoxColumn9 "].Value = fontDialog.Font
            layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewTextBoxColumn11"].Value = fontDialog.Font.Size;
            layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewCheckBoxColumn1"].Value = fontDialog.Font.Bold;
            layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewCheckBoxColumn2"].Value = fontDialog.Font.Italic;
            layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewCheckBoxColumn3"].Value = fontDialog.Font.Strikeout;
            layoutItemDataGridView.Rows[ItemRowNumber].Cells["dataGridViewCheckBoxColumn4"].Value = fontDialog.Font.Underline;

        }

        private void PRTFOR_BUTON_MODY_Click(object sender, EventArgs e)
        {
            foreach (Button s in Button_A)
                s.Enabled = false;
            foreach (Button s in Button_B)
                s.Enabled = true;
            Mode = State.MODY;
            layoutItemDataGridView.Enabled = true;
            LayoutDv.Enabled = false;
        }

        private void BUTON_CANCLE_Click(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'printerDataSet.Layout' 資料表。您可以視需要進行移動或移除。
            this.layoutTableAdapter.Fill(this.printerDataSet.Layout);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.LayoutItem1' 資料表。您可以視需要進行移動或移除。
            this.taLayoutItem1.FillALL(this.printerDataSet.LayoutItem1);
            foreach (Button s in Button_A)
                s.Enabled = true; ;
            foreach (Button s in Button_B)
                s.Enabled = false;
            layoutItemDataGridView.Enabled = false;
            LayoutDv.Enabled = true;
        }




    }
}
