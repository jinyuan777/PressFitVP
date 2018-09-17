using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;
using System.Data.Odbc;
using USBLab;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Threading;
namespace VP
{
    public enum CassetSate
    {
        Busy,
        Idle,
        Error
    }
    public partial class Form1 : Form
    {
        
        // 包藥機 DB
        private DataSetPrinter dsP = new DataSetPrinter();

        private bool IsConnect = true;

        public Form1()
        {
            InitializeComponent();
        }
        TUSB USB = new TUSB();
        TCpu1 CPU1 = new TCpu1();
        public SerialPort CassetPort;
        delegate void ReceiveCallback(SerialPort comport);
        public CassetSate CAState = new CassetSate();
        public List<byte> Hex = new List<byte>();
        int IMGSEQ = 0;
        byte[] Data = new byte[56];
        string CasNmEr;
        private String GetAttributes(XmlNode xmlNode, String XPath, string Name)
        {
            XmlNode SubXmlNode = xmlNode.SelectSingleNode(XPath);
            if (SubXmlNode != null)
            {
                return SubXmlNode.Attributes.GetNamedItem(Name).Value.ToString();
            }
            else
            {
                return "";
            }
        }
        [DllImport("gdi32.dll")]
        static extern int SetBitmapBits(IntPtr hbmp, uint cBytes, byte[] lpBits);
        [DllImport("gdi32", CharSet = CharSet.Auto)]
        static extern bool GetBitmapBits(IntPtr imgFile, int cbBuf, out byte[] ImgByte);
        static object lockMe = new object();

        DataRowView drvPrescription;
        DataView dvPrescriptionItem;
        int PackNumber;

        List<string> TTPList = new List<string>();
        List<string> Druglist = new List<string>();
        public List<Dictionary<string, int>> CassetteInfos = new List<Dictionary<string, int>>();
        string TTPString = "select x.*,y.PRT_TEXT from ( " +
            "select C.PRT_TEXT,D.PRT_TEXT,C.TAKE_TIME_CD,D.SORT_KEY from Direction_Info C left join " +
            "( select a.DRTS_CD,b.PRT_TEXT,b.SORT_KEY from Direction_Time_Info a left join TAKE_TIME_PERIOD b  on a.TAKE_TP_CD  = b.TAKE_TP_CD ) D " +
            "on C.DRTS_CD = D.DRTS_CD where C.DRTS_CD = ? ) x left join  TAKE_TIME_INFO y on x.TAKE_TIME_CD = y.TAKE_TIME_CD  ORDER BY D.SORT_KEY ";
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dsPrinter.Drug' 資料表。您可以視需要進行移動或移除。
            this.drugTableAdapter.Fill(this.dsPrinter.Drug);
            // TODO: 這行程式碼會將資料載入 'dsPrinter.Direction_Info' 資料表。您可以視需要進行移動或移除。
            this.direction_InfoTableAdapter.Fill(this.dsPrinter.Direction_Info);
            // TODO: 這行程式碼會將資料載入 'dsPrinter.Direction_Time_Info' 資料表。您可以視需要進行移動或移除。
            this.direction_Time_InfoTableAdapter.Fill(this.dsPrinter.Direction_Time_Info);
            // TODO: 這行程式碼會將資料載入 'dsPrinter.TAKE_TIME_PERIOD' 資料表。您可以視需要進行移動或移除。
            this.tAKE_TIME_PERIODTableAdapter.Fill(this.dsPrinter.TAKE_TIME_PERIOD);
            // TODO: 這行程式碼會將資料載入 'dsPrinter.Prescription' 資料表。您可以視需要進行移動或移除。
            this.taPrescription.Fill(this.dsPrinter.Prescription);
            // TODO: 這行程式碼會將資料載入 'dsPrinter.Prescription1' 資料表。您可以視需要進行移動或移除。
            this.prescription1TableAdapter.Fill(this.dsPrinter.Prescription1);

            //Packer.Connect();
            this.taPrescription.Fill(this.dsPrinter.Prescription);
            this.taPrescriptionItem.Fill(this.dsPrinter.PrescriptionItem);



            this.taPrescription.Update(this.dsPrinter.Prescription);
            this.taPrescription.Fill(this.dsPrinter.Prescription);
            prescription1TableAdapter.Fill(dsPrinter.Prescription1);
            this.taPrescriptionItem.Fill(this.dsPrinter.PrescriptionItem);
            this.taLayout.Fill(dsPrinter.Layout);
            this.taLayoutItem.Fill(dsPrinter.LayoutItem,3);
            this.taTTP.Fill(dsPrinter.TTP);
            //DataBackupAuto();
            this.taUDPOWPAT.Fill(dsPrinter.UDPOWPAT);
            this.taUDPOWMED.Fill(dsPrinter.UDPOWMED);

           

            CPU1.Connect();
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_Idel);
            try
            {
                CassetPort = new SerialPort("COM13", 230400, Parity.None, 8, StopBits.One);
                CassetPort.ReadTimeout = 1000;
                CassetPort.ReadBufferSize = 64;
                CassetPort.WriteBufferSize = 64;
                CassetPort.DataReceived += new SerialDataReceivedEventHandler(CassetPort_DataReceived);

                CassetPort.Open();
                CassetPort.DiscardInBuffer();
                CassetPort.DiscardOutBuffer();
                CAState = CassetSate.Idle;
            }
            catch
            {
                MessageBox.Show("Cassete OPen Fail ;");
            }

        }
        private void DataBackupAuto()
        {
            bool b = timer_DataWatcher.Enabled;
            timer_DataWatcher.Enabled = false;

            dsP.cn.Open();
            OleDbCommand cmd;
            DataTable DT = new DataTable();

            OleDbDataAdapter KeysAdapter = new OleDbDataAdapter("select  PrescriptionKey FROM Prescription where PrescriptionDate <> '" + DateTime.Now.AddYears(-1911).ToString("yyy/MM/dd").                   ToString() + "'", dsP.cn);
            KeysAdapter.Fill(DT);

            foreach (DataRow row in DT.AsEnumerable())
            {
                cmd = new OleDbCommand("INSERT INTO his_PrescriptionItem SELECT * FROM PrescriptionItem where PrescriptionKey = ? ", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("?PrescriptionKey", OleDbType.VarChar, 50)).Value = row[0].ToString();
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("DELETE * FROM PrescriptionItem where PrescriptionKey = ?", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("?PrescriptionKey", OleDbType.VarChar, 50)).Value = row[0].ToString();
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("INSERT INTO his_Prescription SELECT * FROM Prescription where PrescriptionKey = ?", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("?PrescriptionKey", OleDbType.VarChar, 50)).Value = row[0].ToString();
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("DELETE * FROM Prescription where PrescriptionKey = ?", dsP.cn);
                cmd.Parameters.Add(new OleDbParameter("?PrescriptionKey", OleDbType.VarChar, 50)).Value = row[0].ToString();
                cmd.ExecuteNonQuery();
            }
            dsP.cn.Close();
            this.taPrescription.Fill(this.dsPrinter.Prescription);
            this.taPrescriptionItem.Fill(this.dsPrinter.PrescriptionItem);

            timer_DataWatcher.Enabled = b;
            prescription1TableAdapter.Fill(dsPrinter.Prescription1);

        }
        private void CassetPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Application.DoEvents();
            ReceiveCallback rc = new ReceiveCallback(ParseReceiveCassetData);
            object[] param = { CassetPort };

            BeginInvoke(rc, param);
        }
        string CAsseteCmd = string.Empty;
        char[] CommandAck = new char[] { 'D' };//start
        private void ParseReceiveCassetData(SerialPort port)
        {
            try
            {
                int byteNums = port.BytesToRead;
                if (byteNums >15)
                {
                    
                    byte[] read_buffer = new byte[byteNums];
                    List<byte> Cmds = new List<byte>();
                    
                    port.Read(read_buffer, 0, byteNums);
                    {
                        int num = 0;
                        bool readsign = false;
                        foreach (byte b in read_buffer)
                        {
                            if (b == STX)
                            {
                                readsign = true;
                                continue;
                            }
                            else if (b == ETX && readsign)
                                break;
                            if (readsign)
                            {
                                Cmds.Add(b);
                                num++;
                            }
                        }
                        port.DiscardInBuffer();
                        CAsseteCmd = string.Empty;
                        byte[] DATAS = new byte[Cmds.Count()];
                        for (int i = 0; i < Cmds.Count();i++)
                            DATAS[i] = Cmds[i];

                        CAsseteCmd = Encoding.Default.GetString(DATAS).Trim();
                        if (CAsseteCmd.Contains("Z"))
                        {
                            CAState = CassetSate.Idle;
                            CPU1.IsDrugReady = true;
                            byte[] CmdAck = BOX(Encoding.Default.GetBytes(CommandAck));
                             CassetPort.Write(CmdAck, 0, CmdAck.Count());
                        }
                        else if (CAsseteCmd.Contains("E"))
                        {
                            CasNmEr = CAsseteCmd;                                
                            CAState = CassetSate.Error;
                            byte[] CmdAck = BOX(Encoding.Default.GetBytes(CommandAck));
                            CassetPort.Write(CmdAck, 0, CmdAck.Count());
                        }
                        port.DiscardOutBuffer();
                    }
                }
                
            }
            catch { }


        }
 
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton) sender;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        void F6_Shown(object sender, EventArgs e)
        {
        }

        private void printerLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            int nowRow = prescription1BindingSource.Position;
            if (nowRow == -1) return;


            DataView dvPrescription1 = new DataView(dsPrinter.Prescription1);
            DataView dvPrescription = dvPrescription1[nowRow].CreateChildView("Prescription1_Prescription");

            foreach (DataRowView drvPrescription in dvPrescription)
            {
                drvPrescription.BeginEdit();
                //MessageBox.Show(drvPrescription["TTPText"].ToString());
                drvPrescription["IsPacked"] = false;
                drvPrescription["IsCancel"] = false;
                drvPrescription.EndEdit();

            }

            taPrescription.Update(dsPrinter);
            taPrescriptionItem.Update(dsPrinter);

        }

        private Label SetLabel(DataRow dataRow)
        {
            Label label = new Label();

            String X = dataRow["X"].ToString();
            String Y = dataRow["Y"].ToString();
            String W = dataRow["W"].ToString();
            String H = dataRow["H"].ToString();

            label.Location = new Point(int.Parse(X), int.Parse(Y));
            label.Size = new Size(int.Parse(W), int.Parse(H));
            label.BackColor = Color.White;

            #region // 設定 Align
            if (dataRow["Align"].ToString() == "TopLeft") label.TextAlign = ContentAlignment.TopLeft;
            if (dataRow["Align"].ToString() == "TopRight") label.TextAlign = ContentAlignment.TopRight;
            if (dataRow["Align"].ToString() == "TopCenter") label.TextAlign = ContentAlignment.TopCenter;
            if (dataRow["Align"].ToString() == "MiddleLeft") label.TextAlign = ContentAlignment.MiddleLeft;
            if (dataRow["Align"].ToString() == "MiddleRight") label.TextAlign = ContentAlignment.MiddleRight;
            if (dataRow["Align"].ToString() == "MiddleCenter") label.TextAlign = ContentAlignment.MiddleCenter;
            if (dataRow["Align"].ToString() == "BottomLeft") label.TextAlign = ContentAlignment.BottomLeft;
            if (dataRow["Align"].ToString() == "BottomRight") label.TextAlign = ContentAlignment.BottomRight;
            if (dataRow["Align"].ToString() == "BottomCenter") label.TextAlign = ContentAlignment.BottomCenter;
            #endregion
            #region // 設定 Font
            FontStyle FS = new FontStyle();
            if (bool.Parse(dataRow["FontBold"].ToString())) FS |= FontStyle.Bold;
            if (bool.Parse(dataRow["FontItalic"].ToString())) FS |= FontStyle.Italic;
            if (bool.Parse(dataRow["FontUnderline"].ToString())) FS |= FontStyle.Underline;
            if (bool.Parse(dataRow["FontStrikeout"].ToString())) FS |= FontStyle.Strikeout;
            label.Font = new System.Drawing.Font(dataRow["FontName"].ToString(), float.Parse(dataRow["FontSize"].ToString()), FS);
            #endregion

            label.Visible = bool.Parse(dataRow["Visible"].ToString());
            if (bool.Parse(dataRow["ShowImage"].ToString()))
            {
                Image image = Image.FromFile(dataRow["ImagePath"].ToString());
                label.Image = image;

            }
            return label;
        }   

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void vISToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
//            timer_DataWatcher.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (USB.Cpu1State == ECpu1State.Cpu1State_Idel)
            {

                CopyXmltoPrescription();
                DataState.Text = "載入資料時間：" + DateTime.Now;
                DataState.Visible = true;
                DataState.Width = 100;
            }
        }

        private DateTime StringToDateTime(string s)
        {
            int year  = int.Parse(s.Substring(0,4) );
            int month = int.Parse(s.Substring(4, 2));
            int day   = int.Parse(s.Substring(6, 2));
            int hour =0;
            int minute =0;
            int second =0;

            if (s.Length > 8)
            {
                hour = int.Parse(s.Substring(8, 2));
                minute = int.Parse(s.Substring(10, 2));
                second = int.Parse(s.Substring(12, 2));
            }
            DateTime d = new DateTime(year, month, day, hour, minute, second);
            return d;
        }

        private void packetItemDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void packetItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            //packer.PackerNo = ComboBox_Device.SelectedIndex;
            //MessageLable.Text = packer.message;

        }
        Bitmap Bmp;

        public void Preview(int PackNumber)
        {
            if (PackNumber > 10)
                return;
            int num = 0;
            taLayoutItem.Fill(dsPrinter.LayoutItem, 3);
            DataView dvLayoutItem = new DataView(dsPrinter.LayoutItem);
            Bitmap imgOutput = new Bitmap(520, 440);
            Graphics gic = Graphics.FromImage(imgOutput);
            drvPrescription["StartNumber"] = (PackNumber + 1).ToString();
            PillSelect = string.Empty;
            int ii = PackNumber % 3;
            drvPrescription["TTPText"] = TTPList[ii].ToString();
            foreach (DataRowView row in dvLayoutItem)
            {
                if (row["LabelType"].ToString().Equals("Prescription"))
                {
                    gic.Clip = new Region(new Rectangle(int.Parse(row["X"].ToString()), int.Parse(row["Y"].ToString()), int.Parse(row["W"].ToString()), int.Parse(row["H"].ToString()) + 4));
                    gic.DrawString(drvPrescription[row["LabelText"].ToString()].ToString(), new Font(row["FontName"].ToString(), float.Parse(row["FontSize"].ToString()), FontStyle.Bold), 
                        new SolidBrush(Color.Black), float.Parse(row["X"].ToString()), float.Parse(row["Y"].ToString()));
                }
                else if (row["LabelType"].ToString().Equals("Label"))
                {
                    gic.Clip = new Region(new Rectangle(int.Parse(row["X"].ToString()), int.Parse(row["Y"].ToString()), int.Parse(row["W"].ToString()), int.Parse(row["H"].ToString())));
                    gic.DrawString(row["LabelText"].ToString(), new Font(row["FontName"].ToString(), float.Parse(row["FontSize"].ToString()), FontStyle.Bold), new SolidBrush(Color.Black), 
                        float.Parse(row["X"].ToString()), float.Parse(row["Y"].ToString()));
                }
                else if (row["LabelType"].ToString().Equals("Drugs"))
                {

                    num = 0;
                    foreach (DataRowView RowView in dvPrescriptionItem)
                    {
                        if (Druglist[ii].Contains(RowView["DrugNo"].ToString()))
                        {
                            gic.Clip = new Region(new Rectangle(int.Parse(row["X"].ToString()), (num * int.Parse(row["H"].ToString())) + int.Parse(row["Y"].ToString()),
                                int.Parse(row["W"].ToString()), int.Parse(row["H"].ToString())));
                            gic.DrawString(RowView[row["LabelText"].ToString()].ToString(), new Font(row["FontName"].ToString(), float.Parse(row["FontSize"].ToString()), 
                                FontStyle.Bold), new SolidBrush(Color.Black), float.Parse(row["X"].ToString()), (num * 32) + float.Parse(row["Y"].ToString()));
                            num++;
                        }
                    }
                }
            }
            
            gic.Clip = new Region(new Rectangle(10, 250, 100, 30));
            Rectangle expansionRectangle = new Rectangle(0, 0, imgOutput.Width * 2, imgOutput.Height);
            gic.DrawImage(imgOutput, expansionRectangle);

            pictureBox1.Image = imgOutput;

            MemoryStream ms = new MemoryStream();
            byte[] imagedata = null;
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            imagedata = ms.GetBuffer();

            Bmp = new Bitmap(pictureBox1.Image);
            Hex.Clear();
            #region
            for (int i = 0; i < Bmp.Width; i++)
            {
                for (int j = Bmp.Height - 1; j >= 0; j -= 8)
                {
                    byte temp = new byte();
                    for (int x = 0; x < 8; x++)
                    {
                        var dot = Bmp.GetPixel(i, j - x);
                        if (dot.A != 0x00)
                        {
                            switch (x)
                            {
                                case 0:
                                    temp += 0x80;
                                    break;
                                case 1:
                                    temp += 0x40;
                                    break;
                                case 2:
                                    temp += 0x20;
                                    break;
                                case 3:
                                    temp += 0x10;
                                    break;
                                case 4:
                                    temp += 0x08;
                                    break;
                                case 5:
                                    temp += 0x04;
                                    break;
                                case 6:
                                    temp += 0x02;
                                    break;
                                case 7:
                                    temp += 0x01;
                                    break;

                            }
                        }
                    }
                    Hex.Add(temp);
                }
            }
            #endregion
            CPU1.HexData = Hex;
        }
        public int CassetDropCount = 0;
        string PillTemp, PillSelect;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer_USBPacker.Enabled = false;
            try
            {
                USB.Parameter(CPU1.AccessCpu1());
            }
            catch
            { }
            LabelPackerState.Text = USB.Cpu1State.ToString();
            LableMessage.Text = USB.Cpu1Message.ToString();
            ProgressBar1.Value = USB.sign % 16;
            tsslTemp.Text = "封口溫度：" + USB.Thermometer.ToString();
            if (CPU1.NonUse1 == 0x01)
            {
                PackNumber++;
                //Preview(PackNumber);

                CPU1.NonUse1 = 0x00;
            }
            if (CAState == CassetSate.Error)
            {

                Warning warn = new Warning();
                timer_USBPacker.Enabled = false; ;
                warn.CasNm = CasNmEr;
                warn.ShowDialog();
                warn.Dispose();
                int ErrorCAsNum = CasNmEr.Length / 3;
                StringBuilder Cmd_RePack = new StringBuilder();
                Cmd_RePack.Append("G");
                Cmd_RePack.Append(ErrorCAsNum.ToString().PadLeft(2, '0'));
                Cmd_RePack.Append(":");
                //for (int i = 0; i < ErrorCAsNum; i++)
                //{
                //    Cmd_RePack.Append(CasNmEr.Substring(1 + (3 * i), 3));
                //    foreach (DataRowView RowView in dvPrescriptionItem)
                //    {
                //        if (RowView["TimesQty"].ToString().PadLeft(3, '0') == CasNmEr.Substring(1 + (3 * i), 3))
                //            Cmd_RePack.Append(RowView["DOSAGE"].ToString().PadLeft(2, '0'));
                //    }

                //}
                //char[] CasseteSendTest = new char[4 + (ErrorCAsNum * 5)];// { 'G', '0', '2', ':', '0', '2', '1', '0', '1', '0', '2', '2', '0', '1' };//藥盒號碼+掉藥顆數
                char[] CasseteSendTest = new char[] { 'G', '0', '1', ':', '0', '1', '0', '0', '1',  };//藥盒號碼+掉藥顆數
                int oo = 0;
                foreach (char c in Cmd_RePack.ToString())
                {
                    CasseteSendTest[oo] = c;
                    oo++;
                }

                byte[] ByteInfo = Encoding.Default.GetBytes(CasseteSendTest);
                CPU1.TXBuffer[14] = 0x00;
                byte[] test = BOX(ByteInfo);
                CassetPort.Write(test, 0, test.Count());
                System.Threading.Thread.Sleep(100);
                CPU1.IsDrugReady = false;
                CAState = CassetSate.Idle;
                timer_USBPacker.Enabled = true;

            }
            if (USB.USBCommand == EUSBCommand.USBCommand_DrugsReady && CAState == CassetSate.Idle)
            {
                byte[] test ;//= BOX(Encoding.Default.GetBytes(TEST));
                char[] CasseteSendTest;
                PillTemp = string.Empty;
                PillSelect = string.Empty;
                
                foreach (var c in CassetteInfos[CassetDropCount % CassetteInfos.Count]) 
                {
                    PillTemp += c.Key.PadLeft(3, '0') + c.Value.ToString().PadLeft(2, '0');
                }
                PillSelect += "A" + CassetteInfos[CassetDropCount % CassetteInfos.Count].Count.ToString().PadLeft(2, '0') + ":" + PillTemp;
                CasseteSendTest = PillSelect.ToCharArray();
                //CasseteSendTest = new char[] { 'A', '0', '1', ':', '0', '0', '6', '0', '1' };//藥盒號碼+掉藥顆數

                byte[] ByteInfo = Encoding.Default.GetBytes(CasseteSendTest);
                lock (lockMe)
                {
                    using (StreamWriter sw = new StreamWriter(@"D:\VPrinter\LOG\CassetDrop" + DateTime.Now.ToString("yyyyMMdd") + ".log", true))
                    {
                        sw.WriteLine("Serial : " + CassetDropCount.ToString() + "  OUT Command :  " + PillSelect + "     Date Time :"
                            + DateTime.Now.ToShortTimeString() + "  CPU1.NowNumber :" + USB.NowNumber.ToString());
                        sw.Close();
                    }
                }
                
                CPU1.TXBuffer[14] = 0x00;
                //test = BOX(ByteInfo);
                //CassetPort.Write(test, 0, test.Count());
                CassetPort.Write(BOX(ByteInfo), 0, BOX(ByteInfo).Count());
                CassetDropCount++;
                CAState = CassetSate.Busy;
                System.Threading.Thread.Sleep(50);
                CPU1.IsDrugReady = false;
            }

            if (CPU1.IsDrugReady && USB.Cpu1State == ECpu1State.Cpu1State_Waiting)
            {
                CPU1.TXBuffer[14] = 0x01;
            }
    
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出系統?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsPrinter.Clear();
                Packer.StopConnect();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e)
        {
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_StopHeating);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_Reset);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {




        }

        private void button_Forward_Click(object sender, EventArgs e)
        {
            //Packer.SendCommand(ECpu1Command.PaperMotorForward);
        }

        private string DateTimeToString(DateTime dt)
        {
            string year = dt.Year.ToString();
            string month = dt.Month.ToString();
            string day = dt.Day.ToString();
            string hour = dt.Hour.ToString();
            string minute = dt.Minute.ToString();
            string second = dt.Second.ToString();


            if (month.Length == 1) month = "0" + month;
            if (day.Length == 1) day = "0" + day;
            if (hour.Length == 1) hour = "0" + hour;
            if (month.Length == 1) minute = "0" + minute;
            if (month.Length == 1) second = "0" + second;

            return year + month + day + hour + minute + second;
        }

        private void button_Reverse_Click(object sender, EventArgs e)
        {

        }

        private void button_Locate_Click(object sender, EventArgs e)
        {

        }


        private void 設定包藥機時間ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_SetDateTime);
        }

        private void bindingSource_Prescription_PositionChanged(object sender, EventArgs e)
        {
            tsslDataCount.Text = (bsPrescription.Position + 1).ToString() + "/" + bsPrescription.Count.ToString();
        }
        private void button_Tablet_Click(object sender, EventArgs e)
        {

            DataView dvPrescription1 = new DataView(dsPrinter.Prescription1);
            DataRowView drvPrescription1 = dvPrescription1[prescription1BindingSource.Position];

            DataView dvPrescription = drvPrescription1.CreateChildView("Prescription1_Prescription");


            if (dvPrescription.Count > 0)
            {
                drvPrescription = dvPrescription[prescriptionBindingSource.Position];
                dvPrescriptionItem = drvPrescription.CreateChildView("Prescription_PrescriptionItem");

                int day = int.Parse(dvPrescriptionItem[0]["Days"].ToString());
                string DrugNm = string.Empty;

                for (int d = 1; d <= int.Parse(day.ToString()); d++)
                {
                    foreach (DataRow TTP_Row in this.dsPrinter.TAKE_TIME_PERIOD)
                    {
                        foreach (DataRowView Mix_Row in dvPrescriptionItem)
                        {
                            if (int.Parse(Mix_Row["Days"].ToString()) < d || Mix_Row["IsPack"].Equals(false))
                                continue;
                            var xx = from i in this.dsPrinter.Direction_Time_Info
                                     where i["TAKE_TP_CD"].Equals(TTP_Row["TAKE_TP_CD"].ToString()) && i["DRTS_CD"].Equals(Mix_Row["TTP"].ToString())
                                     select i;
                            if (xx.Count() > 0)
                                DrugNm += Mix_Row["DrugNo"] + ";";
                        }
                        if (DrugNm != string.Empty)
                        {
                            Druglist.Add(DrugNm);
                            TTPList.Add(TTP_Row["PRT_TEXT"].ToString());
                        }
                        DrugNm = string.Empty;
                    }
                }
             
                CassetDropCount = 0;
                Preview(0);
                PackNumber = 0;
                CPU1.StartNumber = 0x01;
                CPU1.TotalNumber = byte.Parse("100");

                CPU1.PackNumber = byte.Parse("100");
                CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
    
            }
        }

       

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void 服用方式管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vISToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void tsmiDelAll_Click(object sender, EventArgs e)
        {
            bool b = timer_DataWatcher.Enabled;
            timer_DataWatcher.Enabled = false;

            dsP.cn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE * FROM PrescriptionItem", dsP.cn);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand("DELETE * FROM Packet", dsP.cn);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand("DELETE * FROM PacketItem", dsP.cn);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE * FROM Prescription";
            cmd.ExecuteNonQuery();
            dsP.cn.Close();

            prescription1TableAdapter.Fill(dsPrinter.Prescription1);
            this.taPrescription.Fill(this.dsPrinter.Prescription);
            this.taPrescriptionItem.Fill(this.dsPrinter.PrescriptionItem);
            //this.taPacket.Fill(this.dsPrinter.Packet);
            //this.taPacketItem.Fill(this.dsPrinter.PacketItem);

            timer_DataWatcher.Enabled = b;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 載入高雄榮總資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyXmltoPrescription();
        }

        private void 資料備份及清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool b = timer_DataWatcher.Enabled;
            timer_DataWatcher.Enabled = false;

            dsP.cn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO his_Prescription SELECT * FROM Prescription", dsP.cn);
            cmd.ExecuteNonQuery();

            cmd = new OleDbCommand("INSERT INTO his_PrescriptionItem SELECT * FROM PrescriptionItem", dsP.cn);
            cmd.ExecuteNonQuery();

            cmd = new OleDbCommand("DELETE * FROM PrescriptionItem", dsP.cn);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE * FROM Prescription";
            cmd.ExecuteNonQuery();
            dsP.cn.Close();

            dsPrinter.Clear();
            
            this.taPrescription.Fill(this.dsPrinter.Prescription);
            this.taPrescriptionItem.Fill(this.dsPrinter.PrescriptionItem);

            this.taLayout.Fill(dsPrinter.Layout);
            this.taLayoutItem.Fill(dsPrinter.LayoutItem,3);
            this.taTTP.Fill(dsPrinter.TTP);
            //calculate();

            timer_DataWatcher.Enabled = b;
            prescription1TableAdapter.Fill(dsPrinter.Prescription1);
        }





        // UDPOWPAT UDPOWMED 資料轉到 tmp_Prescription tmp_PriscriptionItem
        private void CopyVGHKStoPrescription()
        {
            string Key = "";
            if (bsPrescription.Position != -1) 
                Key = dsPrinter.Prescription.Rows[bsPrescription.Position]["PrescriptionKey"].ToString();

            //try
            {
                dsP.cn.Open();
                #region 刪除 tmp_Prescription tmp_PrescriptionItem
                OleDbCommand cmd = new OleDbCommand("DELETE * FROM tmp_PrescriptionItem", dsP.cn);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand( "DELETE * FROM tmp_Prescription", dsP.cn);
                cmd.ExecuteNonQuery();

                #endregion

                #region UDPOWPAT UDPOWMED 資料轉到 tmp_Prescription tmp_PriscriptionItem

                cmd.CommandText  = "INSERT INTO tmp_Prescription " ;
                cmd.CommandText += "(PrescriptionKey,   PatientID,          PatientNo,          PatientName,        PatientSex,       ";
                cmd.CommandText += " PatientBirthday,   PatientAGE,         PrescriptionNo,     PrescriptionDate,   PrescriptionTime, ";
                cmd.CommandText += " Department,        Physician,          Allergy,            ReceiveNo,          Disease,          ";
                cmd.CommandText += " Hospital,          HistoryNo,          PatientFrom,        PhysicianType,      RegisterName,     ";
                cmd.CommandText += " SecNo,             WardBed,            DTPrescription,     ReceiveDateTime,    GroupKey )        ";
                cmd.CommandText += " SELECT " ;
                cmd.CommandText += " PKey,              HIDNO,              TRIM(HHISNUM),      TRIM(HNAMEC),       HSEX,       ";
                cmd.CommandText += " HBIRTHDT,          HAGE,               TRIM(PREDSEQ),      BGNDT,              BGNTM,      ";
                cmd.CommandText += " DEPTNAME,          DOCTNAME,           ALLERGY,            TRIM(ARPCSNO),      HDIAGTXT,   ";
                cmd.CommandText += " HOSPNAME,          MHISNUM,            PATFROM,            PATTYPE,            REGNAME,    ";
                cmd.CommandText += " SECNO,             WARDBED,            ZUDPOWPA,           now() ,             PKey        ";
                cmd.CommandText += " FROM UDPOWPAT ";
                cmd.ExecuteNonQuery();
                
                cmd.CommandText  = "INSERT INTO tmp_PrescriptionItem ";
                cmd.CommandText += "(DrugNo,        DrugName,   TTP,        TimesQty,   Days,";
                cmd.CommandText += " Total,         TotalUnit,  IsPack,     PatientNo,  PatientFrom,";
                cmd.CommandText += " PrescriptionNo,IsPowder,   MixPowder,  DrugPrice,  DrugType,";
                cmd.CommandText += " DOSUnit,       DOSAGE,     DTPrescriptionItem,     PrescriptionKey)";
                cmd.CommandText += " SELECT ";
                cmd.CommandText += " UDDRGNO,       UDRPNAME,   ADMCODE,    ADMCNT,     ADMDAY,";
                cmd.CommandText += " TOTQTY,        TOTUNIT,    TRUE,       HHISNUM,    PATFROM,";
                cmd.CommandText += " PREDSEQ,       POWDERFG,   MIXPOWD,    DRUGPRIC,   MEDKIND,";
                cmd.CommandText += " DOSUNIT,       DOSAGE,     ZUDPOWME,   PKey";
                cmd.CommandText += " FROM UDPOWMED ";
                cmd.ExecuteNonQuery();

                #endregion

                #region 刪除 UDPOWPAT UDPOWMED
                cmd = new OleDbCommand("DELETE * FROM UDPOWMED", dsP.cn);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("DELETE * FROM UDPOWPAT", dsP.cn);
                cmd.ExecuteNonQuery();
                dsP.cn.Close();
                #endregion

                // 將 tmp_ 拆成正式的包裝處方
                CopyTmptoMainTable();
            }
            //catch (System.Exception ex)
            {
            //    Log log = new Log(ex);
            }
        }

        // 將 tmp_ 拆成正式的包裝處方
        private void CopyTmptoMainTable()
        {

            tatmp_Prescription.Fill(dsPrinter.tmp_Prescription);
            tatmp_PrescriptionItem.Fill(dsPrinter.tmp_PrescriptionItem);

            //try
            {
                // 儲存現在處方的位置
                string CurrentPrescriptionKey = "0";
                if (bsPrescription.Position != -1)
                {
                    CurrentPrescriptionKey = dsPrinter.Prescription.Rows[bsPrescription.Position]["PrescriptionKey"].ToString();
                }

                // 尋找 Prescription 中是否有重覆的 SQL
                OleDbCommand cmd1 = new OleDbCommand("SELECT GroupKey FROM Prescription WHERE GroupKey =?", dsP.cn);
                OleDbParameter dbp = new OleDbParameter("GroupKey", "");
                cmd1.Parameters.Add(dbp);

                dsP.cn.Open();

                DataView dvtmp_Prescription = new DataView(dsPrinter.tmp_Prescription);
                foreach (DataRowView drvtmp_Prescription in dvtmp_Prescription)
                {
                    // 尋找 Prescription 中是否有重覆
                    cmd1.Parameters[0].Value = drvtmp_Prescription["GroupKey"].ToString();
                    OleDbDataReader dReaderPrescription = cmd1.ExecuteReader();

                    if ( dReaderPrescription.HasRows )
                    {
                        Log log = new Log("Prescription Key 重覆:" + drvtmp_Prescription["GroupKey"].ToString() + "-" + drvtmp_Prescription["PatientName"].ToString());
                    }
                    else
                    {
                        DataView dvtmp_PrescriptionItem = drvtmp_Prescription.CreateChildView("tmp_Prescription_tmp_PrescriptionItem");
                        dvtmp_PrescriptionItem.Sort = "TTP";

                        string tmpGroup = "";
                        string tmpKey = "";
                        int LastKeyChar = 1;    // Key值尾碼 
                       
                        #region 處理 PrescriptionItem
                        foreach (DataRowView drvtmp_PrescriptionItem in dvtmp_PrescriptionItem)
                        {                
                            if (drvtmp_PrescriptionItem["TTPGroup"].ToString() != tmpGroup)
                            {
                                #region Copy tmp_Prescription row 到 Prescription row
                                tmpGroup = drvtmp_PrescriptionItem["TTPGroup"].ToString();

                                DataRow drPrescription = dsPrinter.Prescription.NewRow();
                                foreach (DataColumn dcPrescription in drPrescription.Table.Columns)
                                {
                                    drPrescription[dcPrescription.ToString()] = drvtmp_Prescription[dcPrescription.ToString()];
                                }

                                // 服用方式
                                string t ="";
                                int n2 = 0;
                                string grp = drvtmp_PrescriptionItem["TTPGroup"].ToString();
                                
                                foreach (DataRowView tmp_Item in dvtmp_PrescriptionItem)
                                {
                                    if (tmp_Item["TTP"].ToString() != t && grp == tmp_Item["TTPGroup"].ToString())
                                    {
                                        t = tmp_Item["TTP"].ToString();
                                        n2++;
                                    }
                                }

                                if (n2 > 1)
                                {
                                    drPrescription["TTP"] = drvtmp_PrescriptionItem["TTPGroup"].ToString();
                                    drPrescription["TTPText"] = drvtmp_PrescriptionItem["TTPGroupText"].ToString();
                                }
                                else
                                {
                                    drPrescription["TTP"] = drvtmp_PrescriptionItem["TTP"].ToString();
                                    drPrescription["TTPText"] = drvtmp_PrescriptionItem["TTPText"].ToString();
                                }

                                // 每日服用次數
                                int times = int.Parse(drvtmp_PrescriptionItem["Times"].ToString());

                                // 天數
                                int days = int.Parse(drvtmp_PrescriptionItem.Row["Days"].ToString());

                                // 計算總包數
                                drPrescription["PackNum"] = times * days;
                                
                                
                                drPrescription["GroupKey"] = drvtmp_Prescription["PrescriptionKey"];
                                drPrescription["PrescriptionKey"] = drPrescription["PrescriptionKey"].ToString() + LastKeyChar.ToString();
                                drPrescription["Cycle"] = LastKeyChar;

                                tmpKey = drPrescription["PrescriptionKey"].ToString();
                                dsPrinter.Prescription.Rows.Add(drPrescription);
                                LastKeyChar++;
                                #endregion
                            }

                            #region Copy tmp_PrescriptionItem row to PrescriptionItem row
                            DataRow drPrescriptionItem = dsPrinter.PrescriptionItem.NewRow();
                            foreach (DataColumn dcPrescriptionItem in drPrescriptionItem.Table.Columns)
                            {
                                drPrescriptionItem[dcPrescriptionItem.ToString()] = drvtmp_PrescriptionItem[dcPrescriptionItem.ToString()];
                            }
                            drPrescriptionItem["PrescriptionKey"] = tmpKey;

                            dsPrinter.PrescriptionItem.Rows.Add(drPrescriptionItem);
                            #endregion

                        }   
                        #endregion
                    }
                    dReaderPrescription.Close();
                }



                dsP.cn.Close();
                #region 更新Prescription PrescriptionItem

                taPrescription.Update(dsPrinter);
                taPrescriptionItem.Update(dsPrinter);

                if (tabControl.SelectedTab.Name == "tabPage01")
                {
                    taPrescription.Fill(dsPrinter.Prescription);
                    
                }
                else if (tabControl.SelectedTab.Name == "tabPage02")
                {
                    taPrescription.FillByPacked(dsPrinter.Prescription);
                }
                else if (tabControl.SelectedTab.Name == "tabPage03")
                {
                    taPrescription.FillByCancel(dsPrinter.Prescription);
                }
                taPrescriptionItem.Fill(dsPrinter.PrescriptionItem);

                #endregion

                #region 刪除 tmp_Prescription tmp_PrescriptionItem
                dsP.cn.Open();
                OleDbCommand cmd = new OleDbCommand("DELETE * FROM tmp_PrescriptionItem", dsP.cn);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("DELETE * FROM tmp_Prescription", dsP.cn);
                cmd.ExecuteNonQuery();
                dsP.cn.Close();

                tatmp_Prescription.Fill(dsPrinter.tmp_Prescription);
                tatmp_PrescriptionItem.Fill(dsPrinter.tmp_PrescriptionItem);
                #endregion


                int i = bsPrescription.Find("PrescriptionKey", CurrentPrescriptionKey);
                if (i != -1)
                {
                    bsPrescription.Position = i;
                }

            }
            //catch (System.Exception ex)
            {
            //    Log log = new Log(ex);
            }
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {

            int nowRow = prescription1BindingSource.Position;
            if (nowRow == -1) return;


            DataView dvPrescription1 = new DataView(dsPrinter.Prescription1);
            DataView dvPrescription  = dvPrescription1[nowRow].CreateChildView("Prescription1_Prescription");

            foreach (DataRowView drvPrescription in dvPrescription)
            {
                drvPrescription.BeginEdit();
                //MessageBox.Show(drvPrescription["TTPText"].ToString());
                drvPrescription["IsCancel"] = true;
                drvPrescription.EndEdit();

            }

            taPrescription.Update(dsPrinter);
            taPrescriptionItem.Update(dsPrinter);


        }

        private void dgvPrescrption_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            Boolean b = true;

            DataGridView dgvPrescription = (DataGridView)sender;

            string GKey = "";
            foreach (DataGridViewRow dgvr in dgvPrescription.Rows)
            {
                if (dgvr.Cells["dgvReceiveNo1"].Value.ToString() != GKey)
                {
                    GKey = dgvr.Cells["dgvReceiveNo1"].Value.ToString();
                    b = !b;
                }

                if (b)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        private void 秒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_DataWatcher.Interval = 30000;
        }

        private void 秒ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer_DataWatcher.Interval = 60000;
        }

        private void 秒ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer_DataWatcher.Interval = 90000;
        }

        private void 秒ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer_DataWatcher.Interval = 120000;
        }

        private void 秒ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer_DataWatcher.Interval = 180000;
        }

        private void 秒ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            timer_DataWatcher.Interval = 300000;
        }

        private void tsmiTimer_Click(object sender, EventArgs e)
        {
            if (timer_DataWatcher.Enabled == true)
            {
                timer_DataWatcher.Enabled = false;
                tsmiTimer.Text = "開啟TImer";
            }
            else
            {
                timer_DataWatcher.Enabled = true;
                tsmiTimer.Text = "關閉TImer";
            }
        }

        private void 重新整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.taPrescription.Fill(this.dsPrinter.Prescription);
            this.taPrescriptionItem.Fill(this.dsPrinter.PrescriptionItem);
            //this.taPacket.Fill(this.dsPrinter.Packet);
            //this.taPacketItem.Fill(this.dsPrinter.PacketItem);
        }

        private void dgvPrescription2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Boolean b = true;

            DataGridView dgvPrescription = (DataGridView)sender;

            string GKey = "";
            foreach (DataGridViewRow dgvr in dgvPrescription.Rows)
            {
                if (dgvr.Cells["dgvReceiveNo2"].Value.ToString() != GKey)
                {
                    GKey = dgvr.Cells["dgvReceiveNo2"].Value.ToString();
                    b = !b;
                }

                if (b)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        private void dgvPrescription3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Boolean b = true;

            DataGridView dgvPrescription = (DataGridView)sender;

            string GKey = "";
            foreach (DataGridViewRow dgvr in dgvPrescription.Rows)
            {
                if (dgvr.Cells["dgvReceiveNo3"].Value.ToString() != GKey)
                {
                    GKey = dgvr.Cells["dgvReceiveNo3"].Value.ToString();
                    b = !b;
                }

                if (b)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        public void FillPrescription()
        {
            prescription1TableAdapter.Fill(dsPrinter.Prescription1);
            taPrescription.Fill(dsPrinter.Prescription);
            taPrescriptionItem.Fill(dsPrinter.PrescriptionItem);
        }

        private void dgvPrescription3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 預包作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.USB = this.USB;
            f10.CPU1 = this.CPU1;
            f10.ShowDialog();
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void xml載入測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CopyXmltoPrescription() // 複製 xml Data 到 處方
        {
            DataTable dtPrescription = dsPrinter.Prescription;
            DataTable dtPrescriptionItem = dsPrinter.PrescriptionItem;

            XmlDocument xmlDoc = new XmlDocument();
            string[] stringFiles = Directory.GetFiles(@"D:\VPrinter\Xml");
            string CurrentPrescriptionKey = "0";
            if (bsPrescription.Position != -1)
            {
                CurrentPrescriptionKey = dsPrinter.Prescription1.Rows[prescription1BindingSource.Position]["PatientName"].ToString();
            }
            if ( stringFiles.Length >=1)
            {
                foreach (string file in stringFiles)
                {
                    xmlDoc.Load(file);
                    XmlNode xmlNodeBatch = xmlDoc.SelectSingleNode("Batch");
                    //try
                    //{
                        foreach (XmlNode xmlNodeFile in xmlNodeBatch.ChildNodes)
                        {
                            DataRow dr = dtPrescription.Rows.Find(xmlNodeFile.Attributes["name"].Value);
                            int no = 0, tbltCount = 0;
                            if (dr == null)
                            {
                                foreach (XmlNode xmlNodePrescription in xmlNodeFile.ChildNodes)
                                {
                                    int SpecDay = 0;
                                    //foreach (DataRow row in this.dsPrinter.TAKE_TIME_PERIOD.Rows)
                                    {
                                        DataRow drPrescription = dtPrescription.NewRow();
                                        tbltCount = 0;
                                        //this.direction_Time_InfoTableAdapter.FillBy(this.dsPrinter.Direction_Time_Info, xmlNodePrescription.Attributes["TTP"].Value.ToString());
                                        string PrescriptionDateTime = xmlNodePrescription.Attributes["PrescriptionDate"].Value;
                                        if (xmlNodePrescription.Attributes["PatientFrom"].Value.Equals("住院"))
                                        {
                                            var ROWS = from DTI in this.dsPrinter.Direction_Info.AsEnumerable() where DTI["DRTS_CD"].ToString().Trim().Equals(xmlNodePrescription.Attributes["TTP"].Value.ToString().Trim()) select DTI;
                                            string TTPTEXT = string.Empty;
                                            foreach (DataRow row in ROWS)
                                                TTPTEXT = row["PRT_TEXT"].ToString();
                                            int RowNum = (from DTI in this.dsPrinter.Direction_Time_Info where DTI["DRTS_CD"].ToString().Trim().Equals(xmlNodePrescription.Attributes["TTP"].Value.ToString().Trim()) select DTI).Count();// ;
                                            if (RowNum.Equals(0))
                                                continue;
                                            drPrescription["TTPText"] = TTPTEXT;
                                            drPrescription["PackNum"] = int.Parse(xmlNodePrescription.Attributes["Days"].Value.ToString()) * RowNum;
                                        }
                                        else
                                        {
                                            drPrescription["TTPText"] = xmlNodePrescription.Attributes["TTPText"].Value;
                                            drPrescription["PackNum"] = xmlNodePrescription.Attributes["PackNum"].Value;
                                        }
                                        drPrescription["PrescriptionKey"] = xmlNodePrescription.Attributes["PrescriptionKey"].Value + no.ToString();
                                        drPrescription["PatientName"] = xmlNodePrescription.Attributes["PatientName"].Value;
                                        drPrescription["PatientNo"] = xmlNodePrescription.Attributes["PatientKey"].Value;
                                        drPrescription["PatientSex"] = xmlNodePrescription.Attributes["PatientSex"].Value;
                                        drPrescription["PrescriptionDate"] = xmlNodePrescription.Attributes["PrescriptionDate"].Value;
                                        drPrescription["PrescriptionTime"] = xmlNodePrescription.Attributes["PrescriptionTime"].Value;
                                        drPrescription["PatientID"] = xmlNodePrescription.Attributes["PatientID"].Value;
                                        drPrescription["PatientBirthday"] = xmlNodePrescription.Attributes["PatientBirthday"].Value;
                                        drPrescription["TTP"] = xmlNodePrescription.Attributes["TTP"].Value;
                                        drPrescription["WardBed"] = xmlNodePrescription.Attributes["WardBed"].Value;
                                        //drPrescription["PackNum"] = 0;

                                        drPrescription["PatientFrom"] = xmlNodePrescription.Attributes["PatientFrom"].Value;
                                        drPrescription["ReceiveNo"] = xmlNodePrescription.Attributes["ReceiveNo"].Value;
                                        

                                        //drPrescription["PackNum"] = int.Parse(xmlNodePrescription.Attributes["Days"].Value.ToString()) * RowNum;
                                        drPrescription["GroupKey"] = xmlNodePrescription.Attributes["PrescriptionKey"].Value + SpecDay.ToString();
                                        if (xmlNodePrescription.Attributes["ISPRT"].Value == "Y")
                                        {
                                            drPrescription["IsPrintDate"] = true;
                                        }
                                        else
                                        {
                                            drPrescription["IsPrintDate"] = false;
                                        }


                                        string tmp_TTP = "";
                                        int tmp_Days = 0;
                                        foreach (XmlNode xmlNodePrescriptionItem in xmlNodePrescription.ChildNodes)
                                        {
                                            DataRow drPrescriptionItem = dtPrescriptionItem.NewRow();

                                            drPrescriptionItem["PrescriptionKey"] = drPrescription["PrescriptionKey"];
                                            drPrescriptionItem["DrugNo"] = xmlNodePrescriptionItem.Attributes["DrugNo"].Value;
                                            drPrescriptionItem["DrugName"] = xmlNodePrescriptionItem.Attributes["DrugName"].Value.Replace("&quot;", @"'").Trim();
                                            drPrescriptionItem["DOSAGE"] = xmlNodePrescriptionItem.Attributes["Dosage"].Value;

                                            //tmp_TTP = xmlNodePrescriptionItem.Attributes["TTP"].Value;
                                            if (xmlNodePrescriptionItem.Attributes["TTP"].Value != string.Empty)
                                                drPrescriptionItem["TTP"] = xmlNodePrescriptionItem.Attributes["TTP"].Value;
                                            drPrescriptionItem["Days"] = xmlNodePrescriptionItem.Attributes["Days"].Value;
                                            drPrescriptionItem["Total"] = xmlNodePrescriptionItem.Attributes["Total"].Value;
                                            drPrescriptionItem["IsPack"] = true;
                                            dtPrescriptionItem.Rows.Add(drPrescriptionItem);
                                            tbltCount++;
                                        }
                                        //if (tbltCount.Equals(0))
                                        //    continue;
                                        dtPrescription.Rows.Add(drPrescription);
                                        no++;
                                    }
                                    SpecDay++;
                                }
                            }
                            else
                            {
                                //   MessageBox.Show("DDDD");
                            }
                            //}

                        }
                    //}
                    //catch (Exception ex)
                    //{
                    //    lock (lockMe)
                    //    {
                    //        using (StreamWriter sw = new StreamWriter(@"D:\VPrinter\LOG\ErrorFile.log", true))
                    //        {
                    //            sw.WriteLine("VPrinter Error : " + DateTime.Now.ToString() + "  " + "  OUT  " + ex);
                    //            sw.Close();
                    //        }
                    //    }
                    //    continue;
                    //}
                    File.Copy(file, "d:\\VPrinter\\Xml\\History\\" + file.Substring(16), true);
                    File.Delete(file);
                }
                taPrescription.Update(dsPrinter);
                taPrescriptionItem.Update(dsPrinter);

                prescription1TableAdapter.Fill(dsPrinter.Prescription1);
                taPrescription.Fill(dsPrinter.Prescription);
                taPrescriptionItem.Fill(dsPrinter.PrescriptionItem);

                int i = prescription1BindingSource.Find("PatientName", CurrentPrescriptionKey);
                if (i != -1)
                {
                    prescription1BindingSource.Position = i;
                }
            }
        }

        private void 歷史記錄查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void prescriptionItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void prescriptionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FREQ fre = new FREQ();
            fre.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TAKE_TIME_INFO TTI = new TAKE_TIME_INFO();
            TTI.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TTP ttp = new TTP();
            ttp.ShowDialog();
        }

        private void 列印設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRTFORM pRTFORM = new PRTFORM();
            pRTFORM.ShowDialog();
        }

        private void ReportList_Click(object sender, EventArgs e)
        {
            RrportList PRTList = new RrportList();
            PRTList.ShowDialog();
        }

        private void HIS_Prescription_Click(object sender, EventArgs e)
        {
            HIS_FORM his_form = new HIS_FORM();
            his_form.ShowDialog();
        }

        private void prescription1DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgvPrescription = (DataGridView)sender;

            //foreach (DataGridViewRow dgvr in prescription1DataGridView.Rows)
            //{
            //    if (dgvr.Cells["PatientFrom"].Value.ToString() == "出院")
            //    {
                 
            //        dgvr.DefaultCellStyle.BackColor = Color.GreenYellow;
            //    }
            //    else if (dgvr.Cells["PatientFrom"].Value.ToString() == "急診")
            //    {
                   
            //        dgvr.DefaultCellStyle.BackColor = Color.Pink;
            //    }
            //    else if (dgvr.Cells["PatientFrom"].Value.ToString() == "住院")
            //    {
                   
            //        dgvr.DefaultCellStyle.BackColor = Color.SkyBlue;
            //    }

            //}
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgvPrescription = (DataGridView)sender;

            //foreach (DataGridViewRow dgvr in dataGridView3.Rows)
            //{
            //    if (dgvr.Cells["dataGridViewTextBoxColumn39"].Value.ToString() == "出院")
            //    {

            //        dgvr.DefaultCellStyle.BackColor = Color.GreenYellow;
            //    }
            //    else if (dgvr.Cells["dataGridViewTextBoxColumn39"].Value.ToString() == "急診")
            //    {

            //        dgvr.DefaultCellStyle.BackColor = Color.Pink;
            //    }
            //    else if (dgvr.Cells["dataGridViewTextBoxColumn39"].Value.ToString() == "住院")
            //    {

            //        dgvr.DefaultCellStyle.BackColor = Color.SkyBlue;
            //    }

            //}
        }

        private void dataGridView5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgvPrescription = (DataGridView)sender;

            //foreach (DataGridViewRow dgvr in dataGridView5.Rows)
            //{
            //    if (dgvr.Cells["dataGridViewTextBoxColumn1"].Value.ToString() == "出院")
            //    {

            //        dgvr.DefaultCellStyle.BackColor = Color.GreenYellow;
            //    }
            //    else if (dgvr.Cells["dataGridViewTextBoxColumn1"].Value.ToString() == "急診")
            //    {

            //        dgvr.DefaultCellStyle.BackColor = Color.Pink;
            //    }
            //    else if (dgvr.Cells["dataGridViewTextBoxColumn1"].Value.ToString() == "住院")
            //    {

            //        dgvr.DefaultCellStyle.BackColor = Color.SkyBlue;
            //    }

            //}
        }

        private static byte ACK = 13, NAK = 15, STX = 2, ETX = 3;
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




        private void 藥品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dRUGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cassetes caste = new Cassetes();
            caste.ShowDialog();
            caste.Dispose();
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TEST test = new TEST();
            test.CPU1 = this.CPU1;
            test.USB = this.USB;
            test.CassetPort = this.CassetPort;
            test.ShowDialog();
            test.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPERRATION Operation = new OPERRATION();
            Operation.CassetPort = this.CassetPort;
            Operation.CPU1 = this.CPU1;
            Operation.USB = this.USB;
            Operation.f1 = this;
            Operation.ShowDialog();
            Operation.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USB.USBCommand = EUSBCommand.USBCommand_DrugsReady;
        }





    }
    public enum EUSBCommand
    {
        USBCommand_Idel,
        USBCommand_Busy,
        USBCommand_MemroyWrite,
        USBCommand_ShowPaperEntry,
        USBCommand_ShowCarbonEntry,
        USBCommand_ShowCarbonNoEntry,
        USBCommand_ShowPackPause,
        USBCommand_ShowPackContinue,
        USBCommand_ShowPackStop,
        USBCommand_DrugsReady
    }
    public enum ECpu1Command
    {
        Cpu1Command_Idel,
        Cpu1Command_RxPackInfo,

        Cpu1Command_USBPackStart,
        Cpu1Command_PackStart,
        Cpu1Command_PackPause,
        Cpu1Command_PackStop,
        Cpu1Command_PackContinue,
        Cpu1Command_PaperMotorLocate,
        Cpu1Command_PaperMotorForward,
        Cpu1Command_PaperMotorReverse,
        Cpu1Command_MototPressFit,
        Cpu1Command_PowderLocate,
        Cpu1Command_StopHeating,

        Cpu1Command_MemroyWrite,
        Cpu1Command_SetDateTime,
        Cpu1Command_Reset,
        Cpu1Command_Again,
        Cpu1Command_Cut,
        Cpu1Command_PowderLeft
    }
    public enum ECpu1State
    {
        Cpu1State_Idel = 0,
        Cpu1State_Heating = 1,
        Cpu1State_Packing = 2,
        Cpu1State_USBPacking = 3,
        Cpu1State_PackPause = 4,
        Cpu1State_Clearing = 5,
        Cpu1State_PowderLocating = 6,
        Cpu1State_Busy = 7,
        Cpu1State_Error = 8,
        Cpu1State_Waiting = 9
    }
    public enum EMessage
    {
        Message_Heating = 0,
        Message_PowderLocating = 1,
        Message_PackPowder = 2,
        Message_PackDrug = 3,
        Message_PackMix = 4,
        Message_PackSpace = 5,
        Message_Clearing = 6,
        Message_PackFinish = 7,
        Message_PackPause = 8,
        Message_PackCancel = 9,
        Message_SystemReady = 10,
        Message_Space = 11,

        Message_PowderLocationAlerm = 37,
        Message_PaperEntryAlerm = 38,
        Message_CarbonEntryAlerm = 39
    }
    public enum EErrorCode
    {
        ErrorCode_NoError = 0,
        ErrorCode_ControlPanel = 1,
        ErrorCode_USBConnection = 2,
        ErrorCode_PaperMotor = 3,
        ErrorCode_Powder = 4,
        ErrorCode_Drug = 5,
        ErrorCode_PowderCover = 6,
        ErrorCode_DrugCover = 7,
        ErrorCode_PresureDown = 8,
        ErrorCode_PresureUp = 9,
        ErrorCode_Heater = 10,
        ErrorCode_HallSensor = 11,
        ErrorCode_Printer = 12
    }
    public enum EPackType
    {
        PackType_Powder,
        PackType_Drug,
        PackType_Mix,
        PackType_Space,
        PackType_Connection,
        PackType_Drug0,
        PackType_Drug1,
        PackType_Drug2,
        PackType_Drug3
    }
    public enum ECommandType
    {
        READ_MSG = 0X00,
        //       WRITE_MSG,        
        WRITE_DAT = 0X07
    }
    public class TUSB
    {
        public EUSBCommand USBCommand;
        public ECpu1State Cpu1State;
        public EMessage Cpu1Message;
        public EErrorCode ErrorCode;
        public byte NowNumber;
        public byte PowderLocation;
        public byte Thermometer;
        public byte ImageNumber;
        public byte NonUse1;
        public byte NonUse2;
        public int sign;
        //public byte[] RXBuffer = new byte[15];
        public void Parameter(byte[] RXBuffer)
        {
            USBCommand = (EUSBCommand)RXBuffer[1];
            Cpu1State = (ECpu1State)RXBuffer[2];
            NowNumber = RXBuffer[3];
            PowderLocation = RXBuffer[4];
            Thermometer = RXBuffer[5];
            ImageNumber = RXBuffer[6];
            Cpu1Message = (EMessage)RXBuffer[7];
            ErrorCode = (EErrorCode)RXBuffer[8];
            sign = int.Parse(RXBuffer[9].ToString());

        }
    }
    public class TCpu1 
    {
        private int MAX_PACKET_SIZE_WRITE = 16;
        private int MAX_PACKET_SIZE_READ = 15;

        private byte MAX_WRITE_PKTS = 0x01;

        private byte FT_READ_MSG = 0x00;
        private byte CommandACK = 0x01;

        private byte FT_MSG_SIZE = 15;

        private byte WRITE_DAT = 0x07;
        int dwBytesRead = 0;
        int dwBytesWritten = 0;
        bool success = true;

        public bool DeviceWrite(Byte[] buffer, int dwSize, ref int lpdwBytesWritten, long dwTimeout)
        {
            int tmpReadTO = 100000, tmpWriteTO = 100000;

            // Save timeout values.
            SLUSBXpressDLL.SI_GetTimeouts(ref tmpReadTO, ref tmpWriteTO);

            // Set a timeout for the write
            SLUSBXpressDLL.SI_SetTimeouts(0, 1000);

            // Write the data
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Write(SLUSBXpressDLL.hUSBDevice, ref buffer[0], dwSize, ref lpdwBytesWritten, 0);

            // Restore timeouts
            SLUSBXpressDLL.SI_SetTimeouts(1000, 1000);

            return (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS);
        }
        public bool DeviceRead(Byte[] buffer, int dwSize, ref int lpdwBytesRead, long dwTimeout)
        {
            int tmpReadTO = 100000, tmpWriteTO = 100000; ;

            // Save timeout values.
            SLUSBXpressDLL.SI_GetTimeouts(ref tmpReadTO, ref tmpWriteTO);

            // Set a timeout for the read
            SLUSBXpressDLL.SI_SetTimeouts(1000, 0);

            // Read the data
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Read(SLUSBXpressDLL.hUSBDevice, ref buffer[0], dwSize, ref lpdwBytesRead, 0);

            // Restore timeouts
            SLUSBXpressDLL.SI_SetTimeouts(tmpReadTO, tmpWriteTO);

            return (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS);
        }
        public ECommandType CommandType;
        public ECpu1Command Cpu1Command;
        public EPackType PackType;
        public byte SpaceNumber;
        public byte PackNumber;
        public byte StartNumber;
        public byte TotalNumber;
        public bool IsAutoFill;
        public bool IsAutoShake;
        public bool IsAutoCut;
        public bool IsDrugReady;
        public byte Year;
        public byte Month;
        public byte Day;
        public bool IsPrintDate;
        public bool IsPrintNumber;
        public byte NonUse1;
        public byte NonUse2;
        public byte NonUse3;
        public byte[] TXBuffer = new byte[15];
        private byte[] Rxbuffers;
        private int IMGSEQ = 0;
        private byte[] Data = new byte[56];
        public List<byte> HexData;
        public void Connect()
        {
            int DevNum = 0, i;
            List<string> Devise = new List<string>();
            StringBuilder DevStr = new StringBuilder(SLUSBXpressDLL.SI_MAX_DEVICE_STRLEN);
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_GetNumDevices(ref DevNum);//返回裝置連線是否成功
            //List<StringBuilder> Device_List = new List<StringBuilder>();
            //Turn = new char[FT_MSG_SIZE];
            //Turn[1] = 'A';
            if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
            {
                for (i = 0; i < DevNum; i++)
                {
                    SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_GetProductString(i, DevStr, SLUSBXpressDLL.SI_RETURN_SERIAL_NUMBER);
                    //comboBox_Device.Items.Insert(i, DevStr);
                    //Device_List.Add(DevStr);
                }
                //comboBox_Device.SelectedIndex = 0;  // then set combo list to first item
            }
            else
            {
                //MessageBox.Show("Error finding USB device.  Aborting application.");
                //Application.Exit();
            }
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_SetTimeouts(10000, 10000);
            SLUSBXpressDLL.Status = SLUSBXpressDLL.SI_Open(0, ref SLUSBXpressDLL.hUSBDevice);
        }
        EUSBCommand USBCommand = EUSBCommand.USBCommand_Idel;
        int PreViewPoint = 2;

        private void AccessMemory()
        {
            string Command = string.Empty;
            TXBuffer[14] = 0x00;
            Byte[] buf = new Byte[56];
            DeviceWrite(Data, 56, ref dwBytesWritten, 1000);
            while (USBCommand == EUSBCommand.USBCommand_MemroyWrite)
            {
                success = DeviceRead(Rxbuffers, 15, ref dwBytesRead, 3000);
                USBCommand = (EUSBCommand)Rxbuffers[1];

                if (Rxbuffers[1] == 0x02)
                {
                    DeviceWrite(Data, 56, ref dwBytesWritten, 1000);

                    for (int j = 1; j < 56 && IMGSEQ < 520; j++)
                    {
                        Data[j] = HexData[j - 1 + (IMGSEQ * 55)];
                    }
                    Data[0] = WRITE_DAT;
                    IMGSEQ++;
                }
            }
            IMGSEQ = 0;
            NonUse1 = 0x01;
        }
        public byte[] AccessCpu1()
        {
            if (SLUSBXpressDLL.Status == SLUSBXpressDLL.SI_SUCCESS)
            {
                if (USBCommand == EUSBCommand.USBCommand_MemroyWrite)
                    AccessMemory();
                else if (USBCommand == EUSBCommand.USBCommand_DrugsReady)
                {
                    TXBuffer[0] = CommandACK;
                    IsDrugReady = false;
                    success = DeviceWrite(TXBuffer, FT_MSG_SIZE, ref dwBytesWritten, 1000);

                    while (USBCommand == EUSBCommand.USBCommand_DrugsReady)
                    {
                        success = DeviceRead(Rxbuffers, 15, ref dwBytesRead, 3000);
                        USBCommand = (EUSBCommand)Rxbuffers[1];
                    }
                    TXBuffer[0] = FT_READ_MSG;
                    TXBuffer[14] = 0x00;
                }
                else
                {
                    Rxbuffers = new byte[15];//15
                    Year = (byte)DateTime.Now.AddYears(-2000).Year;
                    Month = (byte)DateTime.Now.Month;
                    Day = (byte)DateTime.Now.Day;

                    success = DeviceWrite(TXBuffer, FT_MSG_SIZE, ref dwBytesWritten, 1000);

                    if (success)
                    {
                        while ((Rxbuffers[0] != 0xFF) && success)
                        {
                            success = DeviceRead(Rxbuffers, FT_MSG_SIZE, ref dwBytesRead, 3000);
                        }
                        if (!success)
                        {
                            //MessageBox.Show("Target device failure while sending file size information." + DateTime.Now.ToString());
                        }
                    }
                }
            }
            else
                Connect();
            USBCommand = (EUSBCommand)Rxbuffers[1];
            if (Rxbuffers[2] != (byte)ECpu1State.Cpu1State_Idel)
                TXBuffer[1] = (byte)ECpu1Command.Cpu1Command_Idel;
            return Rxbuffers;
        }
        public void TXParameterSetting(ECpu1Command Command)
        {
            TXBuffer[0] = (byte)ECommandType.READ_MSG.GetHashCode();
            TXBuffer[1] = (byte)Command;
            TXBuffer[2] = (byte)PackType;
            TXBuffer[3] = SpaceNumber;
            TXBuffer[4] = PackNumber;
            TXBuffer[5] = StartNumber;
            TXBuffer[6] = TotalNumber;
            if (IsAutoShake)
                TXBuffer[8] = 0x01;
            else
                TXBuffer[8] = 0x00;
            TXBuffer[9] = Year;
            TXBuffer[10] = Month;
            TXBuffer[11] = Day;
            if (IsAutoCut)
                TXBuffer[12] = 0x01;
            else
                TXBuffer[12] = 0x00;
            if (IsPrintNumber)
                TXBuffer[13] = 0x01;
            else
                TXBuffer[13] = 0x00;
            //if (IsDrugReady)
            //    TXBuffer[14] = 0x01;
            //else
            //    TXBuffer[14] = 0x00;
            
        }

    }
}