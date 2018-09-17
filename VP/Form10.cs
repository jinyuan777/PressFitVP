using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using USBLab;

namespace VP
{
    public partial class Form10 : Form
    {
        public int PackNumber = 12;
        Bitmap bmp;
        public TUSB USB;
        public TCpu1 CPU1;
        //public TUSB USB = new TUSB();
        public string sDrugName;
        public string sDrugAName;
        public string sDrugCName;
        public string sSharp;

        public Form10()
        {
            InitializeComponent();
        }

        private void prePackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsPrePack.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPrinter);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
                      
            
            this.taTTP.Fill(this.dsPrinter.TTP);
            
            this.taPrePack.Fill(this.dsPrinter.PrePack);
            this.taPrePackItem.Fill(this.dsPrinter.PrePackItem);
            this.taMedicine.Fill(dsPrinter.Medicine);
            textBox2.Text = PackNumber.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PackNumber <45)
            {
                PackNumber ++ ;
            }
            textBox2.Text = PackNumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PackNumber > 1)
            {
                PackNumber--;
            }
            textBox2.Text = PackNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bsPrePack.EndEdit();
            Close();
        }

        private void Preview()
        {

            UpdateAll();

            //USB.TotalNumber = 0;
            //USB.StartNumber = 0;
            //USB.SpaceNumber = 2;
            CPU1.PackNumber = byte.Parse(textBox2.Text);
            CPU1.TotalNumber = byte.Parse(textBox2.Text);//int.Parse(textBox2.Text) + 100;
            DataView dvPrePack = new DataView(dsPrinter.PrePack);

            DataRowView drvPrePack = dvPrePack[bsPrePack.Position];

            IMG img = new IMG();



            DataView dvLayoutItem = new DataView(dsPrinter.LayoutItem);
            dvPrePack = new DataView(dsPrinter.PrePack);

            if (drvPrePack["Layout"].ToString() == "錠劑")
            {
                taLayoutItem.Fill(dsPrinter.LayoutItem, 2);
                bmp = img.PrescriptionLayout(dvLayoutItem, dvPrePack, bsPrePack.Position, panel);
            }
            else
            {
                taLayoutItem.Fill(dsPrinter.LayoutItem, 2);
                bmp = img.PrescriptionLayout(dvLayoutItem, dvPrePack, bsPrePack.Position, panel);
            }
            Packer.HexData = new List<byte[]>();
            Packer.HexData.Add(img.GetHex(bmp));
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            taPrePack.Update(dsPrinter);
            taPrePackItem.Update(dsPrinter);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Preview();
            Form f = new Form();
            f.Size = new Size(520, 470);

            PictureBox pb = new PictureBox();
            pb.Size = new Size(520, 440);
            pb.Parent = f;
            pb.Location = new Point(0, 0);
            pb.Image = bmp;

            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.StartPosition = FormStartPosition.CenterScreen;

            f.TopLevel = true;
            f.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CPU1.PackType = EPackType.PackType_Powder;
            Preview();
            if (CPU1.PackNumber != USB.PowderLocation)
            {
                MessageBox.Show("藥粉槽未在第" + CPU1.PackNumber.ToString() + "包");
            }
            else
            {
                CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CPU1.PackType = EPackType.PackType_Mix;
            Preview();
            if (CPU1.PackNumber != USB.PowderLocation)
            {
                MessageBox.Show("藥粉槽未在第" + CPU1.PackNumber.ToString() + "包");
            }
            else
            {
                CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CPU1.PackType = EPackType.PackType_Drug;
            Preview();
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
        }

        private void timer_USBPacker_Tick(object sender, EventArgs e)
        {
            if (USB.Cpu1State == ECpu1State.Cpu1State_Idel)
            {
                button1.Enabled = (USB.Cpu1State == ECpu1State.Cpu1State_Idel);
            }
            else
            {
                button1.Enabled = false;
            }
            button2.Enabled = button1.Enabled;
            button5.Enabled = button1.Enabled;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void bsPrePackItem_PositionChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void drugNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void drugNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void bsPrePack_AddingNew(object sender, AddingNewEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow drPrePack = dsPrinter.PrePack.NewRow();

            DateTime dt = DateTime.Now;

            string yy = dt.Year.ToString().Trim();
            string mm = dt.Month.ToString().Trim();
            if (mm.Trim().Length == 1) mm = "0" + mm;
            string dd = dt.Day.ToString().Trim();
            if (dd.Trim().Length == 1) dd = "0" + dd;


            drPrePack["BUD"] = "BUD：" + yy + mm + dd;
            drPrePack["LOT"] = "LOT：";
            drPrePack["Layout"] = "錠劑";
            dsPrinter.PrePack.Rows.Add(drPrePack);
            UpdateAll();

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            DataView dvPrePack = new DataView(dsPrinter.PrePack);
            DataRowView drvPrePack = dvPrePack[bsPrePack.Position];
            DateTime dt = DateTime.Now;

            string yy, mm, dd;
            yy = dt.Year.ToString();
            mm = dt.Month.ToString();
            dd = dt.Day.ToString();

            if (mm.Length <= 1)
                mm = "0" + mm;
            if (dd.Length <= 1)
                dd = "0" + dd;


            drvPrePack["EDate"] = "PKD：" + yy + mm + dd;
            dt = dt.AddDays(30);

            yy = dt.Year.ToString();
            mm = dt.Month.ToString();
            dd = dt.Day.ToString();

            if (mm.Length <= 1)
                mm = "0" + mm;
            if (dd.Length <= 1)
                dd = "0" + dd;


            drvPrePack["BUD"] = "BUD：" + yy + mm + dd;

            UpdateAll();
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            Preview();
            Form f = new Form();
            f.Size = new Size(520, 470);

            PictureBox pb = new PictureBox();
            pb.Size = new Size(520, 440);
            pb.Parent = f;
            pb.Location = new Point(0, 0);
            pb.Image = bmp;

            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.StartPosition = FormStartPosition.CenterScreen;

            f.TopLevel = true;
            f.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            UpdateAll();

        }

        private void drugNameComboBox_SelectedValueChanged_1(object sender, EventArgs e)
        {

        }

        private void drugNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void drugNameComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (bsPrePack_PrePackItem.Position != -1)
            {
                dgvPrePackItem.CurrentRow.Cells["DrugName"].Value = dsPrinter.Medicine[bsMedicine.Position]["UDRPNAME"].ToString();
                dgvPrePackItem.CurrentRow.Cells["DrugAName"].Value = dsPrinter.Medicine[bsMedicine.Position]["UDHIMDPN"].ToString();
                dgvPrePackItem.CurrentRow.Cells["DrugCName"].Value = dsPrinter.Medicine[bsMedicine.Position]["UDCHTNAM"].ToString();
                dgvPrePackItem.CurrentRow.Cells["Sharp"].Value = dsPrinter.Medicine[bsMedicine.Position]["COLDESCH"].ToString().Trim() + "～" + dsPrinter.Medicine[bsMedicine.Position]["APRDESCH"].ToString().Trim();
                //            dgvPrePackItem.CurrentRow.Cells["DOSAGE"].Value = dsPrinter.Medicine[bsMedicine.Position]["UDAPRNUM"].ToString();
                UpdateAll();
            }
            else
            {
                MessageBox.Show("無藥品資料!");
            }
        }


        public void AddMItem()
        {
            bsPrePack_PrePackItem.AddNew();
            dgvPrePackItem.CurrentRow.Cells["DrugName"].Value = sDrugName;
            dgvPrePackItem.CurrentRow.Cells["DrugAName"].Value = sDrugAName;
            dgvPrePackItem.CurrentRow.Cells["DrugCName"].Value = sDrugCName;
            dgvPrePackItem.CurrentRow.Cells["Sharp"].Value = sSharp;
            UpdateAll();
        }

        private void bsMedicine_PositionChanged(object sender, EventArgs e)
        {
        }

        private void UpdateAll()
        {
            string CurrentKey = "0";
            if (bsPrePack.Position != -1)
            {
                try
                {
                    CurrentKey = dsPrinter.PrePack.Rows[bsPrePack.Position]["PrePackKey"].ToString();
                }
                catch (System.Exception ex)
                {
                }

            }


            try
            {
                this.Validate();
                this.bsPrePack.EndEdit();
                this.bsPrePack_PrePackItem.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsPrinter);
                this.taPrePack.Fill(this.dsPrinter.PrePack);
                this.taPrePackItem.Fill(this.dsPrinter.PrePackItem);
                //dgvPrePack.Refresh();
                //dgvPrePackItem.Refresh();

                int i = bsPrePack.Find("PrePackKey", CurrentKey);
                if (i != -1)
                {
                    bsPrePack.Position = i;
                }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            bsPrePack_PrePackItem.AddNew();
            dgvPrePackItem.CurrentRow.Cells["DrugName"].Value = dsPrinter.Medicine[bsMedicine.Position]["UDRPNAME"].ToString();
            dgvPrePackItem.CurrentRow.Cells["DrugAName"].Value = dsPrinter.Medicine[bsMedicine.Position]["UDHIMDPN"].ToString();
            dgvPrePackItem.CurrentRow.Cells["DrugCName"].Value = dsPrinter.Medicine[bsMedicine.Position]["UDCHTNAM"].ToString();
            dgvPrePackItem.CurrentRow.Cells["Sharp"].Value = dsPrinter.Medicine[bsMedicine.Position]["COLDESCH"].ToString().Trim() + "～" + dsPrinter.Medicine[bsMedicine.Position]["APRDESCH"].ToString().Trim();
            dgvPrePackItem.Refresh();
            UpdateAll();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DataView dvPrePackItem = new DataView(dsPrinter.PrePackItem);
            dvPrePackItem[bsPrePack_PrePackItem.Position].Delete();            
        }

        private void dgvPrePackItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bsPrePack_PrePackItem_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvPrePackItem_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("是否刪除?", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvPrePackItem_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateAll();
        }

        private void dgvPrePack_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateAll();
        }

        private void dgvPrePack_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("是否刪除?", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bsPrePack_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            DataView dvPrePack = new DataView(dsPrinter.PrePack);
            DataRowView drvPrePack = dvPrePack[bsPrePack.Position];
            DateTime dt = DateTime.Now;

            string yy, mm, dd;
            yy = dt.Year.ToString();
            mm = dt.Month.ToString();
            dd = dt.Day.ToString();

            if (mm.Length <= 1)
                mm = "0" + mm;
            if (dd.Length <= 1)
                dd = "0" + dd;


            drvPrePack["EDate"] = "PKD：" + yy + mm + dd;
            dt = dt.AddDays(365);

            yy = dt.Year.ToString();
            mm = dt.Month.ToString();
            dd = dt.Day.ToString();

            if (mm.Length <= 1)
                mm = "0" + mm;
            if (dd.Length <= 1)
                dd = "0" + dd;


            drvPrePack["BUD"] = "BUD：" + yy + mm + dd;

            UpdateAll();


        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();

            f12.f10 = this;

            f12.FindString = "%" + textBox1.Text.Trim() + "%";

            f12.ShowDialog();
        }

    }
}
