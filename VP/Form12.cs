using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Odbc;

namespace VP
{
    public partial class Form12 : Form
    {
        public Form10 f10;
        public string FindString = "";
        OdbcConnection cn = new OdbcConnection(@"Driver=Microsoft Access Driver (*.mdb, *.accdb);DBQ=D:\VPrinter\DB\PRINTER.mdb;FIL=MS Access;");
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\VPrinter\DB\PRINTER.mdb");
        private DataSetPrinter dsP = new DataSetPrinter();
        public Form12()
        {
            InitializeComponent();
            
        }

        private void medicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.Medicine' 資料表。您可以視需要進行移動或移除。

            int i = this.taMedicine.FillByMName(dsPrinter.Medicine, FindString, FindString, FindString);
            if (i <= 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f10.sDrugName = dsPrinter.Medicine[bsMedicine.Position]["UDRPNAME"].ToString();
            f10.sDrugAName = dsPrinter.Medicine[bsMedicine.Position]["UDHIMDPN"].ToString();
            f10.sDrugCName  = dsPrinter.Medicine[bsMedicine.Position]["UDCHTNAM"].ToString();
            f10.sSharp= dsPrinter.Medicine[bsMedicine.Position]["COLDESCH"].ToString().Trim() + "～" + dsPrinter.Medicine[bsMedicine.Position]["APRDESCH"].ToString().Trim();
            f10.AddMItem();
            Close();
        }

        private void prePackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "DELETE * FROM Medicine WHERE UDDRGNO = ?";
            cmd.Parameters.Add(new OleDbParameter("?UDDRGNO", OleDbType.Char, 10)).Value = UDDRGNO_TXT.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            this.taMedicine.Fill(dsPrinter.Medicine);
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            DataRow row = dsPrinter.Medicine.NewRow();
            row["UDDRGNO"] = "請輸入代碼";
            this.dsPrinter.Medicine.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder aa = new OleDbCommandBuilder(taMedicine.Adapter);
            taMedicine.Adapter.Update(this.dsPrinter.Medicine);
        }
    }
}
