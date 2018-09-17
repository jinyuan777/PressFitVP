using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
namespace VP
{
    public partial class OPERRATION : Form
    {
        public OPERRATION()
        {
            InitializeComponent();
        }
        public TUSB USB;
        public TCpu1 CPU1;
        public SerialPort CassetPort;
        public int CassetteNumber = 0;
        //public CassetSate CAState = new CassetSate();
        public Form1 f1;

        private static byte ACK = 13, NAK = 15, STX = 2, ETX = 3;
        //public List<Dictionary<string, int>> CassetteInfos = new List<Dictionary<string, int>>();
        
        string DGVHeaderTEXT = string.Empty;
        private void OPERRATION_Load(object sender, EventArgs e)
        {
            f1.CassetteInfos.Clear();
            CassetteList_DGV.Rows.Add(4);
            foreach (DataGridViewRow row in CassetteList_DGV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = string.Empty;
                }
            }

     
        }
        private byte[] BOX(byte[] box)
        {
            int BCC, i, temp = box[0], num = box.Count();
            byte[] Date = new byte[num + 3];
            for (i = 1; i < box.Count(); i++)
            {
                temp = temp ^ box[i];
                Date[i] = box[i - 1];
            }
            BCC = temp ^ ETX;
            Date[0] = STX;
            i = 0;
            foreach (byte b in box)
            {
                Date[i + 1] = b;
                i++;
            }
            Date[num + 1] = ETX;
            Date[num + 2] = byte.Parse(BCC.ToString());
            return Date;
        }
        private void CassetteList_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CassetteList_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || CassetteList_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == string.Empty)
                {
                    CassetteList_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "1";
                    //CassetteInfo.Add(CassetteList_DGV.Columns[e.ColumnIndex].HeaderText, 1);
                }
                else
                {
                    int QTY = int.Parse(CassetteList_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    QTY += 1;
                    CassetteList_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = QTY.ToString();
                    //CassetteInfo[CassetteList_DGV.Columns[e.ColumnIndex].HeaderText] = QTY;
                }
                DGVHeaderTEXT = CassetteList_DGV.Columns[e.ColumnIndex].HeaderText;
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CassetteList_DGV.SelectedCells[0].Value = string.Empty;
      
        }
        public Dictionary<string, int> CassetteInfo;
        private void button1_Click(object sender, EventArgs e)
        {
            f1.CassetteInfos.Clear();
            for (int i = 0; i < 28600; i++)
            {
                f1.Hex.Add(0x00);
            }
            foreach (DataGridViewRow row in CassetteList_DGV.Rows)
            {
                Dictionary<string, int> CassetteInfo = new Dictionary<string, int>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() != "")
                    {
                        CassetteInfo.Add(CassetteList_DGV.Columns[cell.ColumnIndex].HeaderText.ToString(), int.Parse(cell.Value.ToString()));
                    }
                }
                if(CassetteInfo.Count >0)
                    f1.CassetteInfos.Add(CassetteInfo);
            }
            int totalpkg = int.Parse(textBox1.Text) * f1.CassetteInfos.Count;
            f1.CassetDropCount = 0;
            CPU1.HexData = f1.Hex;
            CPU1.StartNumber = 0x01;
            CPU1.TotalNumber = byte.Parse(totalpkg.ToString());

            CPU1.PackNumber = byte.Parse(totalpkg.ToString());
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
        }

        private void CassetteList_DGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
                return;

            PNumberSetting pNumber = new PNumberSetting();
            pNumber.ShowDialog();
            this.CassetteNumber = pNumber.PNumber;
            pNumber.Dispose();
            CassetteList_DGV.Columns[e.ColumnIndex].HeaderText = CassetteNumber.ToString();
            CassetteList_DGV.Columns[e.ColumnIndex].Width = 100;
        }
    }
}
