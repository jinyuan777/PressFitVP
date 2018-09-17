using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.Threading;
namespace VP
{
    public partial class FREQ : Form
    {
        public FREQ()
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
        DataView DvDireciton;
        DataRowView DrvDirection;
        private void FREQ_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.TAKE_TIME_INFO' 資料表。您可以視需要進行移動或移除。
            this.tAKE_TIME_INFOTableAdapter.Fill(this.pRINTERDataSet.TAKE_TIME_INFO);
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.TAKE_TIME_PERIOD' 資料表。您可以視需要進行移動或移除。
            this.tAKE_TIME_PERIODTableAdapter.Fill(this.pRINTERDataSet.TAKE_TIME_PERIOD);
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.Direction_Info' 資料表。您可以視需要進行移動或移除。
            this.direction_InfoTableAdapter.Fill(this.pRINTERDataSet.Direction_Info);
            this.direction_Time_InfoTableAdapter.Fill(this.pRINTERDataSet.Direction_Time_Info);

            comboBox1.DataSource = this.pRINTERDataSet.TAKE_TIME_INFO;
            comboBox1.ValueMember = this.pRINTERDataSet.TAKE_TIME_INFO.Columns["TAKE_TIME_CD"].ColumnName;
            comboBox1.DisplayMember = this.pRINTERDataSet.TAKE_TIME_INFO.Columns["TAKE_TIME_NM"].ColumnName;
            ButtonA.Add(Button_ADD);
            ButtonA.Add(Button_MODY);
            ButtonA.Add(Button_DEL);
            ButtonB.Add(Button_OK);
            ButtonB.Add(Button_Cancel);

            Texts.Add(dRTS_CDTextBox);
            Texts.Add(dRTS_NMTextBox);
            Texts.Add(pRT_TEXTTextBox);
            Texts.Add(sORT_KEYTextBox);

            splitContainer2.Panel2.Enabled = false;
            foreach (Button s in ButtonB)
                s.Enabled = false;
            DirectionGV_Chose();
            DvDireciton = new DataView(pRINTERDataSet.Direction_Info);
            //DvDireciton.Sort = "SORT_KEY";
            DrvDirection = DvDireciton[0];
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(2))
            {
                if (TTPGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "服用")
                    TTPGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "服用";
                else
                    TTPGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = string.Empty;
            }
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
            foreach (DataGridViewRow row in TTPGV.Rows)
                row.Cells["CHOSE"].Value = string.Empty;
            comboBox1.Text = string.Empty;
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
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            direction_Time_InfoTableAdapter.Fill(pRINTERDataSet.Direction_Time_Info);
            direction_InfoTableAdapter.Fill(pRINTERDataSet.Direction_Info);
            splitContainer2.Panel2.Enabled = false;
            splitContainer2.Panel1.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = true;
            foreach (Button s in ButtonB)
                s.Enabled = false; ;
        }
        private void Button_OK_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder aa = new OleDbCommandBuilder(direction_InfoTableAdapter.Adapter);
            OleDbCommandBuilder bb = new OleDbCommandBuilder(direction_Time_InfoTableAdapter.Adapter);
            OleDbCommand cmd;
            switch (CommunicationMode)
            { 
                case State.ADD:
                    DataRow row = pRINTERDataSet.Direction_Info.NewRow();
                    row["DRTS_CD"] = dRTS_CDTextBox.Text;
                    row["DRTS_NM"] = dRTS_NMTextBox.Text;
                    row["SORT_KEY"] = sORT_KEYTextBox.Text;
                    row["PRT_TEXT"] = pRT_TEXTTextBox.Text;
                    row["TAKE_TIME_CD"] = comboBox1.SelectedValue.ToString();

                    pRINTERDataSet.Direction_Info.Rows.Add(row);


                    direction_InfoTableAdapter.Update(pRINTERDataSet.Direction_Info);

                    
                    foreach (DataGridViewRow TTProw in TTPGV.Rows)
                    {
                        DataRow DTIRow = pRINTERDataSet.Direction_Time_Info.NewRow();
                        if (TTProw.Cells["CHOSE"].Value.ToString().Equals("服用"))
                        {
                            DTIRow["DRTS_CD"] = dRTS_CDTextBox.Text;
                            DTIRow["TAKE_TP_CD"] = TTProw.Cells["tAKETPCDDataGridViewTextBoxColumn"].Value.ToString();
                            pRINTERDataSet.Direction_Time_Info.Rows.Add(DTIRow);
                            //OleDbCommandBuilder bb = new OleDbCommandBuilder(direction_Time_InfoTableAdapter.Adapter);
                            direction_Time_InfoTableAdapter.Update(pRINTERDataSet.Direction_Time_Info);
                        }
                    }                  

                    break;
                case State.MODY:
                    DrvDirection.BeginEdit();
                    DrvDirection["DRTS_NM"] = dRTS_NMTextBox.Text;
                    DrvDirection["TAKE_TIME_CD"] = comboBox1.SelectedValue;
                    DrvDirection["SORT_KEY"] = sORT_KEYTextBox.Text;                   
                    DrvDirection["PRT_TEXT"] = pRT_TEXTTextBox.Text;
                    DrvDirection.EndEdit();
                    direction_InfoTableAdapter.Update(pRINTERDataSet.Direction_Info);

                    dsP.cn.Open();
                    cmd = new OleDbCommand("DELETE * FROM Direction_Time_Info where DRTS_CD = ? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?DRTS_CD", OleDbType.VarChar, 50)).Value = dRTS_CDTextBox.Text;
                    cmd.ExecuteNonQuery();
                    dsP.cn.Close();
                    direction_Time_InfoTableAdapter.Fill(pRINTERDataSet.Direction_Time_Info);
                    foreach (DataGridViewRow TTProw in TTPGV.Rows)
                    {
                        DataRow DTIRow = pRINTERDataSet.Direction_Time_Info.NewRow();
                        if (TTProw.Cells["CHOSE"].Value.ToString().Equals("服用"))
                        {
                            DTIRow["DRTS_CD"] = dRTS_CDTextBox.Text;
                            DTIRow["TAKE_TP_CD"] = TTProw.Cells["tAKETPCDDataGridViewTextBoxColumn"].Value.ToString();
                            pRINTERDataSet.Direction_Time_Info.Rows.Add(DTIRow);
                           
                            direction_Time_InfoTableAdapter.Update(pRINTERDataSet.Direction_Time_Info);
                        }
                    }
                    direction_Time_InfoTableAdapter.Fill(pRINTERDataSet.Direction_Time_Info);
     
                    break;
                case State.DEL:
                    dsP.cn.Open();
                    cmd = new OleDbCommand("DELETE * FROM Direction_Time_Info where DRTS_CD = ? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?DRTS_CD", OleDbType.VarChar, 50)).Value = dRTS_CDTextBox.Text;
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand("DELETE * FROM Direction_Info where DRTS_CD =? ", dsP.cn);
                    cmd.Parameters.Add(new OleDbParameter("?DRTS_CD", OleDbType.VarChar, 50)).Value = dRTS_CDTextBox.Text;
                    cmd.ExecuteNonQuery();
                    dsP.cn.Close();
                    break;
            }
            direction_Time_InfoTableAdapter.Fill(pRINTERDataSet.Direction_Time_Info);
            direction_InfoTableAdapter.Fill(pRINTERDataSet.Direction_Info);
            splitContainer2.Panel2.Enabled = false;
            splitContainer2.Panel1.Enabled = true;
            foreach (Button s in ButtonA)
                s.Enabled = true;
            foreach (Button s in ButtonB)
                s.Enabled = false; ;
        }

        private void DirectionGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DirectionGV_Chose();
            DrvDirection = DvDireciton[e.RowIndex];
            comboBox1.SelectedValue = DrvDirection["TAKE_TIME_CD"];
        }
        private void DirectionGV_Chose()
        {
            foreach (DataGridViewRow row in TTPGV.Rows)
            {
                var v = from i in pRINTERDataSet.Direction_Time_Info where i["DRTS_CD"].Equals(dRTS_CDTextBox.Text) && i["TAKE_TP_CD"].Equals(row.Cells["tAKETPCDDataGridViewTextBoxColumn"].Value.ToString()) select i;
                if (v.Count() > 0)
                    row.Cells["CHOSE"].Value = "服用";
                else
                    row.Cells["CHOSE"].Value = string.Empty;
            }             
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }







    }
}
