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
    public partial class TTP : Form
    {
        public TTP()
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
        DataView DvTTP;
        DataRowView DrvTTP;
        private void TTP_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.TAKE_TIME_PERIOD' 資料表。您可以視需要進行移動或移除。
            this.tAKE_TIME_PERIODTableAdapter.Fill(this.pRINTERDataSet.TAKE_TIME_PERIOD);

            DvTTP = new DataView(this.pRINTERDataSet.TAKE_TIME_PERIOD);
            //DvTTP.Sort = "SORT_KEY";

            ButtonA.Add(Button_ADD);
            ButtonA.Add(Button_MODY);
            ButtonA.Add(Button_DEL);
            ButtonB.Add(Button_OK);
            ButtonB.Add(Button_Cancel);

            Texts.Add(TTPCD_BOX);
            Texts.Add(TTPNM_BOX);
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

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder aa = new OleDbCommandBuilder(this.tAKE_TIME_PERIODTableAdapter.Adapter);
            OleDbCommand cmd;
            switch (CommunicationMode)
            { 
                case State.ADD:
                    DataRow row = this.pRINTERDataSet.TAKE_TIME_PERIOD.NewRow();
                    row["TAKE_TP_CD"] = TTPCD_BOX.Text;
                    row["TAKE_TP_NM"] = TTPNM_BOX.Text;
                    row["PRT_TEXT"] = PRT_BOX.Text;
                    row["SORT_KEY"] = SORT_BOX.Text;
                    this.pRINTERDataSet.TAKE_TIME_PERIOD.Rows.Add(row);
                    this.tAKE_TIME_PERIODTableAdapter.Update(this.pRINTERDataSet.TAKE_TIME_PERIOD);
                    break;
                case State.MODY:
                    DrvTTP.BeginEdit();
                    DrvTTP["TAKE_TP_NM"] = TTPNM_BOX.Text;
                    DrvTTP["PRT_TEXT"] = PRT_BOX.Text.ToString();
                    DrvTTP["SORT_KEY"] = SORT_BOX.Text;
                    DrvTTP.EndEdit();
                    this.tAKE_TIME_PERIODTableAdapter.Update(this.pRINTERDataSet.TAKE_TIME_PERIOD);
                    break;
                case State.DEL:
                    dsP.cn.Open();
                    cmd = new OleDbCommand("DELETE * FROM TAKE_TIME_PERIOD where TAKE_TP_CD = ? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?TAKE_TP_CD", OleDbType.VarChar, 10)).Value = TTPCD_BOX.Text;
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand("DELETE * FROM Direction_Time_Info where TAKE_TP_CD = ? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?TAKE_TP_CD", OleDbType.VarChar, 10)).Value = TTPCD_BOX.Text;
                    cmd.ExecuteNonQuery();
                    dsP.cn.Close();    
                    break;
            }
            this.tAKE_TIME_PERIODTableAdapter.Fill(this.pRINTERDataSet.TAKE_TIME_PERIOD);
            splitContainer2.Panel2.Enabled = false;
            splitContainer2.Panel1.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = true;
            foreach (Button s in ButtonB)
                s.Enabled = false; ;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DrvTTP = DvTTP[e.RowIndex];
        }
    }
}
