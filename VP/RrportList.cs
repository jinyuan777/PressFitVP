using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
namespace VP
{
    public partial class RrportList : Form
    {
        public RrportList()
        {
            InitializeComponent();
        }

        private void RrportList_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.ReportList' 資料表。您可以視需要進行移動或移除。
            this.reportListTableAdapter.Fill(this.pRINTERDataSet.ReportList);
            DataTable table = new DataTable();
            


            var Wards = (from i in this.pRINTERDataSet.ReportList.AsEnumerable() select i["WardBed"]).Distinct();
            foreach (string ss in Wards)
                table.Columns.Add(ss);

            for (int i = 0; i < 100; i++)
            {
                DataRow row = table.NewRow();
                table.Rows.Add(row);
            }
            foreach (DataColumn col in table.Columns)
            {
                var names = from i in this.pRINTERDataSet.ReportList.AsEnumerable() where i["WardBed"].Equals(col.ColumnName) select i;
                int j = 0;
                foreach (DataRow s in names)
                {
                    table.Rows[j][col] = s["PatientName"].ToString() +"\r\n" +s["PatientNo"].ToString();
                    j++;
                }
            }
            List_GV.DataSource = table;
        }

        private void button_OUT_Click(object sender, EventArgs e)
        {
            Excel._Application excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);

            excel.Cells[1, 1] = "壽德藥局處方記錄擋";
            excel.Cells[1, 2] = DateTime.Now;
            for (int i = 0; i < List_GV.Columns.Count; i++)
            {
                excel.Cells[2, i + 1] = List_GV.Columns[i].HeaderText;
            }
            for (int i = 0; i < List_GV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < List_GV.Columns.Count; j++)
                {
                    excel.Cells[i + 3, j + 1] = List_GV.Rows[i].Cells[j].Value.ToString();
                }
            }
            excel.Quit();
        }

        private void button_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
