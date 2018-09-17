using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace VP
{
    public partial class Cassetes : Form
    {
        public Cassetes()
        {
            InitializeComponent();
        }

        List<Button> ButtonA = new List<Button>();
        List<Button> ButtonB = new List<Button>();
        List<TextBox> Texts = new List<TextBox>();

        State CommunicationMode = new State();
        DataView DvCassetteInfo;
        DataRowView DrvCassetteInfo;
        private DataSetPrinter dsP = new DataSetPrinter();
        enum State
        {
            ADD,
            MODY,
            DEL
        }
        private void Cassetes_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.Cassette_Info' 資料表。您可以視需要進行移動或移除。
            this.cassette_InfoTableAdapter.Fill(this.pRINTERDataSet.Cassette_Info);
    
            ButtonA.Add(button_ADD);
            ButtonA.Add(button_MODY);
            ButtonA.Add(button_DEL);
            ButtonA.Add(button_CLOSE);

            ButtonB.Add(button_OK);
            ButtonB.Add(button_CANCLE);

            //Texts.Add(iDTextBox);
            //Texts.Add(priceIDTextBox);
            //Texts.Add(nameTextBox);

            foreach (Button s in ButtonB)
                s.Enabled = false;

            splitContainer1.Panel2.Enabled = false;
            DvCassetteInfo = new DataView(this.pRINTERDataSet.Cassette_Info);
            DrvCassetteInfo = DvCassetteInfo[0];
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Enabled = false;
            splitContainer1.Panel2.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = true;
            foreach (TextBox t in Texts)
                t.Text = string.Empty;
            CommunicationMode = State.ADD;
        }

        private void button_MODY_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Enabled = false;
            splitContainer1.Panel2.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = true;
            CommunicationMode = State.MODY;
        }

        private void button_DEL_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Enabled = false;
            splitContainer1.Panel2.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = true;
            CommunicationMode = State.DEL;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //dsP.cn.Open();
            OleDbCommandBuilder aa = new OleDbCommandBuilder(cassette_InfoTableAdapter.Adapter);
            //OleDbCommand cmd;
            switch (CommunicationMode)
            { 
                case  State.ADD:
                    using (OleDbCommand cmd = new OleDbCommand("insert into Cassette_Info(tblt_cd,cST_CLSF_CD,tRAY_LAYER)values(?,?,?)", dsP.cn))
                    {
                        cmd.Parameters.Add(new OleDbParameter("?tblt_cd", OleDbType.VarChar)).Value = tblt_cdTextBox.Text;
                        cmd.Parameters.Add(new OleDbParameter("?cST_CLSF_CD", OleDbType.VarChar)).Value = cST_CLSF_CDTextBox.Text;
                        cmd.Parameters.Add(new OleDbParameter("?tRAY_LAYER", OleDbType.VarChar)).Value = tRAY_LAYERTextBox.Text;
                        cmd.ExecuteNonQuery();
                    }
                    break;
                case State.MODY:
                    if (tblt_drop_DelayTextBox.Text == string.Empty)
                        tblt_drop_DelayTextBox.Text = "0";
                    if (cst_weightTextBox.Text == string.Empty)
                        cst_weightTextBox.Text = "0";
                    if (tblt_min_qtyTextBox.Text == string.Empty)
                        tblt_min_qtyTextBox.Text = "0";
                    if (tblt_qtyTextBox.Text == string.Empty)
                        tblt_qtyTextBox.Text = "0";
                    DrvCassetteInfo.BeginEdit();
                    DrvCassetteInfo["tblt_cd"] = tblt_cdTextBox.Text;
                    DrvCassetteInfo["cST_CLSF_CD"] = cST_CLSF_CDTextBox.Text;
                    DrvCassetteInfo["USE_YN"] = uSE_YNCheckBox.Checked;
                    DrvCassetteInfo["TRAY_LAYER"] = tRAY_LAYERTextBox.Text;
                    DrvCassetteInfo["TRAY_ROW"] = tRAY_ROWTextBox.Text;
                    DrvCassetteInfo["TRAY_LR"] = tRAY_LRTextBox.Text;
                    DrvCassetteInfo["CLSF_STATE"] = cLSF_STATETextBox.Text;
                    DrvCassetteInfo["tblt_qty"] = int.Parse(tblt_qtyTextBox.Text);
                    DrvCassetteInfo["tblt_qty_dtm"] = tblt_qty_dtmTextBox.Text;
                    DrvCassetteInfo["tblt_min_qty"] = int.Parse(tblt_min_qtyTextBox.Text);
                    DrvCassetteInfo["cst_weight"] = double.Parse(cst_weightTextBox.Text);
                    DrvCassetteInfo["tblt_barcode"] = tblt_barcodeTextBox.Text;      
                    DrvCassetteInfo["tblt_drop_Delay"] = int.Parse(tblt_drop_DelayTextBox.Text);
                    DrvCassetteInfo["tblt_enddate"] = tblt_enddateDateTimePicker.Value.ToString("yyyy/MM/dd");
                    DrvCassetteInfo.EndEdit();
                    cassette_InfoTableAdapter.Adapter.Update(this.pRINTERDataSet.Cassette_Info);             
                    break;
                case State.DEL:
                    break;

            }

            


            System.Threading.Thread.Sleep(2000);
            // TODO: 這行程式碼會將資料載入 'printerDataSet.Layout' 資料表。您可以視需要進行移動或移除。
            //cassette_InfoTableAdapter.Fill(this.pRINTERDataSet.Cassette_Info);

            splitContainer1.Panel1.Enabled = true;
            splitContainer1.Panel2.Enabled = false;
            foreach (Button s in ButtonA)
                s.Enabled = true;
            foreach (Button s in ButtonB)
                s.Enabled = false;
        }

        private void button_CANCLE_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Enabled = true;
            splitContainer1.Panel2.Enabled = false;
            foreach (Button s in ButtonA)
                s.Enabled = true;
            foreach (Button s in ButtonB)
                s.Enabled = false;
        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SEARCH search = new SEARCH();
            search.ShowDialog();
            search.Dispose();
        }
    }
}
