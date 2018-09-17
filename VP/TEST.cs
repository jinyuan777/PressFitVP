using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
namespace VP
{
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }
        public TUSB USB;
        public TCpu1 CPU1;
        public SerialPort CassetPort;
        private static byte ACK = 13, NAK = 15, STX = 2, ETX = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_PaperMotorLocate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_MototPressFit);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string PillTemp = string.Empty;
            PillTemp += "H01:" + CstNumTXT.Text.PadLeft(3, '0') + CstQtyTXT.Text.PadLeft(2, '0');
            char[] CasseteSendTest = PillTemp.ToCharArray();
            //char[] CasseteSendTest = new char[] { 'H', '0', '1', ':', '0', '2', '1', '0', '1' };//, '0', '0', '3', '0', '1', '0', '0', '4', '0', '1' };//藥盒號碼+掉藥顆數
            byte[] ByteInfo = Encoding.Default.GetBytes(CasseteSendTest);
            CassetPort.Write(BOX(ByteInfo), 0, BOX(ByteInfo).Count());
            System.Threading.Thread.Sleep(50);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string PillTemp = string.Empty;
            PillTemp += "I01:" + CstNumTXT.Text.PadLeft(3, '0') + CstQtyTXT.Text.PadLeft(2, '0');
            char[] CasseteSendTest = PillTemp.ToCharArray();
            //char[] CasseteSendTest = new char[] { 'I', '0', '1', ':', '0', '2', '1', '0', '1' };//, '0', '0', '3', '0', '1', '0', '0', '4', '0', '1' };//藥盒號碼+掉藥顆數
            byte[] ByteInfo = Encoding.Default.GetBytes(CasseteSendTest);
            CassetPort.Write(BOX(ByteInfo), 0, BOX(ByteInfo).Count());
            System.Threading.Thread.Sleep(50);
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

        private void button8_Click(object sender, EventArgs e)
        {
            string PillTemp = string.Empty;
            PillTemp += "A01:" + CstNumTXT.Text.PadLeft(3, '0') + CstQtyTXT.Text.PadLeft(2, '0');
            char[] CasseteSendTest = PillTemp.ToCharArray();
            //char[] CasseteSendTest = new char[] { 'A', '0', '1', ':', '0', '1', '0', '0', '1' };//藥盒號碼+掉藥顆數
     
            byte[] ByteInfo = Encoding.Default.GetBytes(CasseteSendTest);
            CassetPort.Write(BOX(ByteInfo), 0, BOX(ByteInfo).Count());
            System.Threading.Thread.Sleep(50);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TEST_Load(object sender, EventArgs e)
        {

        }

    }
}
