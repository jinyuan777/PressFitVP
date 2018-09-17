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
    public partial class HIS_FORM : Form
    {
        public HIS_FORM()
        {
            InitializeComponent();
        }
        private DataSetPrinter dsP = new DataSetPrinter();
        private void HIS_FORM_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.his_PrescriptionItem' 資料表。您可以視需要進行移動或移除。
            //this.his_PrescriptionItemTableAdapter.FillBy(this.pRINTERDataSet.his_PrescriptionItem,);
            //this.his_PrescriptionTableAdapter.Fill(this.pRINTERDataSet.his_Prescription,"*","*");
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.his_PrescriptionTableAdapter.Fill(this.pRINTERDataSet.his_Prescription, prescriptionKeyToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void HisBCD_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue.Equals(13))
            //{

            //    this.his_PrescriptionTableAdapter.Fill(this.pRINTERDataSet.his_Prescription, Convert.ToInt16(DT1.Value.AddYears(-1911).Year) + DT1.Value.ToString("MMdd")
            //                                                                               , Convert.ToInt16(DT2.Value.AddYears(-1911).Year) + DT2.Value.ToString("MMdd"));
            //    this.his_PrescriptionItemTableAdapter.FillBy(this.pRINTERDataSet.his_PrescriptionItem, HisBCD.Text);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HisBCD.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox_DisDate.Text.Equals("西元"))
            this.his_PrescriptionTableAdapter.Fill(this.pRINTERDataSet.his_Prescription, DT1.Value.ToString("yyyy/MM/dd")
                                                                           , DT2.Value.ToString("yyyy/MM/dd"));
            else if (comboBox_DisDate.Text.Equals("民國"))
                this.his_PrescriptionTableAdapter.Fill(this.pRINTERDataSet.his_Prescription, DT1.Value.AddYears(-1911).ToString("yyy/MM/dd")
                                                               , DT2.Value.AddYears(-1911).ToString("yyy/MM/dd"));
          
            this.his_PrescriptionItemTableAdapter.Fill(this.pRINTERDataSet.his_PrescriptionItem);
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否匯入舊資料?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsP.cn.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Prescription"
                          +"(PrescriptionKey, PatientID, PatientNo, PatientName, PatientSex, "
                          +"PatientBirthday, PatientAGE, PrescriptionNo, PrescriptionType, "
                          +"PrescriptionDate, PrescriptionTime, Department, Physician, TTP, TTPText, "
                          +"Allergy, ReceiveNo, Disease, Hospital, HistoryNo, PatientFrom, PhysicianType, "
                          +"RegisterName, SecNo, WardBed, DTPrescription, Cycle, PackNum, "
                          +"StartNumber, PackTotal, IsPacked, PackDate, PackTime, ReceiveDateTime, "
                          +"IsCancel, GroupKey, SDate, EDate, PackType, Excipient, IsPrintDate, "
                          +"IsPrintNumber) "
                          +"select PrescriptionKey, PatientID, PatientNo, PatientName, PatientSex, "
                          +"PatientBirthday, PatientAGE, PrescriptionNo, PrescriptionType, "
                          +"PrescriptionDate, PrescriptionTime, Department, Physician, TTP, TTPText, "
                          +"Allergy, ReceiveNo, Disease, Hospital, HistoryNo, PatientFrom, PhysicianType, "
                          +"RegisterName, SecNo, WardBed, DTPrescription, Cycle, PackNum, "
                          +"StartNumber, PackTotal, IsPacked, PackDate, PackTime, ReceiveDateTime, "
                          +"IsCancel, GroupKey, SDate, EDate, PackType, Excipient, IsPrintDate, "
                          +"IsPrintNumber "
                          +"from his_Prescription where PrescriptionKey = ?", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("Pam1", OleDbType.Char, 40)).Value = label6.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd = new OleDbCommand("insert into		PrescriptionItem"
			                            +"(PrescriptionItemKey, PrescriptionKey, DrugNo, DrugName, TTP, TimesQty, "
                                        +"Days, Total, TotalUnit, IsPack, PatientNo, PatientFrom, PrescriptionNo, "
                                        +"IsPowder, MixPowder, DrugPrice, DrugType, DOSUnit, DOSAGE, "
                                        +" DTPrescriptionItem, DT) "
                                        +"select 			PrescriptionItemKey, PrescriptionKey, DrugNo, DrugName, TTP, TimesQty, "
                                        +"Days, Total, TotalUnit, IsPack, PatientNo, PatientFrom, PrescriptionNo, "
                                        +"IsPowder, MixPowder, DrugPrice, DrugType, DOSUnit, DOSAGE, "
                                        +"DTPrescriptionItem, DT "
                                        +"from 			his_PrescriptionItem "
                                        +"where			PrescriptionKey = ?", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("Pam1", OleDbType.Char, 40)).Value = label6.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd = new OleDbCommand("delete * from his_Prescription where PrescriptionKey = ? ", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("Pam1", OleDbType.Char, 40)).Value = label6.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd = new OleDbCommand("delete * from his_PrescriptionItem where PrescriptionKey = ? ", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("Pam1", OleDbType.Char, 40)).Value = label6.Text;
                cmd.ExecuteNonQuery();
                dsP.cn.Close();
                this.his_PrescriptionTableAdapter.Fill(this.pRINTERDataSet.his_Prescription, DT1.Value.ToString("yyyy/MM/dd")
                                                               , DT2.Value.ToString("yyyy/MM/dd"));
                this.his_PrescriptionItemTableAdapter.Fill(this.pRINTERDataSet.his_PrescriptionItem);
            }
        }
    }
}
