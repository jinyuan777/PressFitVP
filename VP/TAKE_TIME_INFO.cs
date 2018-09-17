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
    public partial class TAKE_TIME_INFO : Form
    {
        public TAKE_TIME_INFO()
        {
            InitializeComponent();
        }
        List<Button> ButtonA = new List<Button>();
        List<Button> ButtonB = new List<Button>();
        List<TextBox> Texts = new List<TextBox>();
        enum State
        {
            ADD,
            MODY,
            DEL
        }
        private DataSetPrinter dsP = new DataSetPrinter();
        State CommunicationMode = new State();
        DataView DvTTInfo;
        DataRowView DrvTTInfo;
        private void TAKE_TIME_INFO_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.TAKE_TIME_INFO' 資料表。您可以視需要進行移動或移除。
            this.tAKE_TIME_INFOTableAdapter.Fill(this.pRINTERDataSet.TAKE_TIME_INFO);

            DvTTInfo = new DataView(this.pRINTERDataSet.TAKE_TIME_INFO);
            //DvTTInfo.Sort = "SORT_KEY";

            ButtonA.Add(Button_ADD);
            ButtonA.Add(Button_MODY);
            ButtonA.Add(Button_DEL);
            ButtonB.Add(Button_OK);
            ButtonB.Add(Button_Cancel);

            Texts.Add(TTCD_BOX);
            Texts.Add(TTNM_BOX);
            Texts.Add(PRT_BOX);
            Texts.Add(SORT_BOX);

            splitContainer2.Panel2.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = false;
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = true;
            splitContainer2.Panel1.Enabled = false;
            foreach (Button s in ButtonA)
                s.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = true; ;
            foreach (TextBox t in Texts)
                t.Text = string.Empty;
            CommunicationMode = State.ADD;
        }

        private void Button_MODY_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = true;
            splitContainer2.Panel1.Enabled = false;
            foreach (Button s in ButtonA)
                s.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = true; ;
            CommunicationMode = State.MODY;
        }

        private void Button_DEL_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = true;
            splitContainer2.Panel1.Enabled = false;
            foreach (Button s in ButtonA)
                s.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = true; ;
            CommunicationMode = State.DEL;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder aa = new OleDbCommandBuilder(tAKE_TIME_INFOTableAdapter.Adapter);
            OleDbCommand cmd;
            switch (CommunicationMode)
            { 
                case State.ADD:
                    DataRow row = this.pRINTERDataSet.TAKE_TIME_INFO.NewRow();
                    row["TAKE_TIME_CD"] = TTCD_BOX.Text;
                    row["TAKE_TIME_NM"] = TTNM_BOX.Text;
                    row["PRT_TEXT"] = PRT_BOX.Text;
                    row["SORT_KEY"] = SORT_BOX.Text;

                    pRINTERDataSet.TAKE_TIME_INFO.Rows.Add(row);
                    tAKE_TIME_INFOTableAdapter.Update(this.pRINTERDataSet.TAKE_TIME_INFO);
                    break;
                case State.MODY:
                    DrvTTInfo.BeginEdit();
                    DrvTTInfo["TAKE_TIME_NM"] = TTNM_BOX.Text;
                    DrvTTInfo["PRT_TEXT"] = PRT_BOX.Text;
                    DrvTTInfo["SORT_KEY"] = SORT_BOX.Text;
                    DrvTTInfo.EndEdit();
                    tAKE_TIME_INFOTableAdapter.Update(this.pRINTERDataSet.TAKE_TIME_INFO);
                    break;
                case State.DEL:
                    dsP.cn.Open();
                    cmd = new OleDbCommand("DELETE * FROM TAKE_TIME_INFO where TAKE_TIME_CD = ? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?TAKE_TIME_CD", OleDbType.VarChar, 10)).Value = TTCD_BOX.Text;
                    cmd.ExecuteNonQuery();
                    dsP.cn.Close();
                    break;
            }
            this.tAKE_TIME_INFOTableAdapter.Fill(this.pRINTERDataSet.TAKE_TIME_INFO);
            splitContainer2.Panel2.Enabled = false;
            splitContainer2.Panel1.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = true;
            foreach (Button s in ButtonB)
                s.Enabled = false; ;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DrvTTInfo = DvTTInfo[e.RowIndex];
            }
            catch { }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.tAKE_TIME_INFOTableAdapter.Fill(this.pRINTERDataSet.TAKE_TIME_INFO);
            splitContainer2.Panel2.Enabled = false;
            splitContainer2.Panel1.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = true;
            foreach (Button s in ButtonB)
                s.Enabled = false; ;
        }

    }
}
