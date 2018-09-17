using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//using USBLab;
using System.IO;



namespace VP
{
    public partial class Form9 : Form
    {
        public string PrescriptionKey;
        public TUSB USB;
        public TCpu1 CPU1;
        public Form1 f1;
        public bool SEQ;
        public int Total_Row;
        public List<string> Keys;
        public bool Area;
        public List<byte> Hex = new List<byte>();
        bool[] Isbutton = { false, false, false, false };
        int PackStep = 0;
        List<string> KeysBC =new List<string>();
        byte[] HexGroup = new byte[28600];
        int Position = 0;
        int[,] num = new int[4, 3];

        // 統計按下包裝的次數
        int[] PackTimes = {0,0,0,0};

        // 一次包裝數量
        int PackNumber = 0;
        int iTotal = 0;

        int yy=1;
        int mm=1;
        int dd=1;
        public int ItemQTY;
        DataView dvPrescription;
        DataRowView drvPrescription;
        DataView dvPrescriptionItem;

        Bitmap bmp;
        DataView dvMedical;

        private DataSetPrinter dsP = new DataSetPrinter();
        public Form9()
        {
            InitializeComponent();
        }



        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dsPrinter.Medicine' 資料表。您可以視需要進行移動或移除。
            this.medicineTableAdapter.Fill(this.dsPrinter.Medicine);
            dvMedical = new DataView(dsPrinter.Medicine);

            taPrescription.Fill(dsPrinter.Prescription);
            taPrescriptionItem.FillByIsPack(dsPrinter.PrescriptionItem);
            //if (USB.PackType == EPackType.Drug)
            //{
            //    foreach (string ss in Keys)
            //        KeysBC.Add(ss);
            //}
            
            dvPrescription = new DataView(dsPrinter.Prescription);
            dvPrescription.Sort = "PrescriptionKey";
            Position = dvPrescription.Find(PrescriptionKey);
            if (Position != -1)
            {
                drvPrescription = dvPrescription[Position];
                dvPrescriptionItem = drvPrescription.CreateChildView("Prescription_PrescriptionItem");
                dataGridView.DataSource = dvPrescriptionItem;


                dataGridView.Columns[0].HeaderText = "藥品名稱";
                dataGridView.Columns[0].DataPropertyName = "DrugName";
                DataGridViewColumn dgvcNew0 = dataGridView.Columns[0] ;


                dataGridView.Columns[1].HeaderText = "配藥量"; ;
                dataGridView.Columns[1].DataPropertyName = "Dosage";
                DataGridViewColumn dgvcNew1 = dataGridView.Columns[1];

                dataGridView.Columns.Clear();

                dataGridView.Columns.Add(dgvcNew0);
                dataGridView.Columns.Add(dgvcNew1);

                label7.Text = drvPrescription["PatientName"].ToString();
                label8.Text = drvPrescription["PatientNo"].ToString();
                label9.Text = drvPrescription["ReceiveNo"].ToString();
                label10.Text = drvPrescription["TTP"].ToString();
                label11.Text = drvPrescription["PrescriptionDate"].ToString();
                label12.Text = drvPrescription["PrescriptionTime"].ToString();
                label13.Text = drvPrescription["TTPText"].ToString();
                textBox1.Text = drvPrescription["PackNum"].ToString();
                

                iTotal = int.Parse(drvPrescription["PackNum"].ToString());
              //  calculate();              
                Preview(0);

            }
            //int x = 0;
            //foreach (byte b in Hex)
            //{
            //    HexGroup[x] = b;
            //    x++;
            //}
        }


        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (PackNumber < 45 && PackNumber < iTotal) 
                PackNumber++;
            label14.Text = PackNumber.ToString();
            CheckButton();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int cyclePackNum = iTotal / 4;
            if (iTotal%4 !=0) cyclePackNum ++;

            if (PackNumber > cyclePackNum ) PackNumber--;
            label14.Text = PackNumber.ToString();

            CheckButton();*/
        }
        Bitmap Bmp;
        private void Preview(int PackNumber)
        {
            taLayoutItem1.Fill(dsPrinter.LayoutItem, 3);
            DataView dvLayoutItem = new DataView(dsPrinter.LayoutItem);
            Bitmap imgOutput = new Bitmap(520, 440);
            Graphics gic = Graphics.FromImage(imgOutput);
            drvPrescription["StartNumber"] = (PackNumber + 1).ToString();
            //drvPrescription["TTPText"] = "未完;//TTPS[(SNumber - 1) % TTPS.Count()];
            foreach (DataRowView row in dvLayoutItem)
            {
                if (row["LabelType"].ToString().Equals("Prescription"))
                {
                    gic.Clip = new Region(new Rectangle(int.Parse(row["X"].ToString()), int.Parse(row["Y"].ToString()), int.Parse(row["W"].ToString()), int.Parse(row["H"].ToString()) + 4));
                    gic.DrawString(drvPrescription[row["LabelText"].ToString()].ToString(), new Font(row["FontName"].ToString(), float.Parse(row["FontSize"].ToString()), FontStyle.Bold), new                          SolidBrush(Color.Black), float.Parse(row["X"].ToString()), float.Parse(row["Y"].ToString()));
                }
                else if (row["LabelType"].ToString().Equals("Label"))
                {
                    gic.Clip = new Region(new Rectangle(int.Parse(row["X"].ToString()), int.Parse(row["Y"].ToString()), int.Parse(row["W"].ToString()), int.Parse(row["H"].ToString())));
                    gic.DrawString(row["LabelText"].ToString(), new Font(row["FontName"].ToString(), float.Parse(row["FontSize"].ToString()), FontStyle.Bold), new SolidBrush(Color.Black), float.                      Parse(row["X"].ToString()), float.Parse(row["Y"].ToString()));
                }
                else if (row["LabelType"].ToString().Equals("Drugs"))
                {
                    int num = 0;
                    foreach (DataRowView RowView in dvPrescriptionItem)
                    {
                        gic.Clip = new Region(new Rectangle(int.Parse(row["X"].ToString()), (num * int.Parse(row["H"].ToString())) + int.Parse(row["Y"].ToString()), int.Parse(row["W"].ToString()),                        int.Parse(row["H"].ToString())));
                        gic.DrawString(RowView[row["LabelText"].ToString()].ToString(), new Font(row["FontName"].ToString(), float.Parse(row["FontSize"].ToString()), FontStyle.Bold), new                                  SolidBrush(Color.Black), float.Parse(row["X"].ToString()), (num * 32) + float.Parse(row["Y"].ToString()));
                        num++;
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
    
        private void button3_Click(object sender, EventArgs e)
        {

            //if (USB.PowderLocation.ToString() != drvPrescription["PackNum"].ToString())
            //{
            //    if (MessageBox.Show("分包數不正確，是否繼續?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        Pack(0, button3);
            //    }
            //}
            //else
                Pack(0, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Isbutton[1])
            {
                Isbutton[1] = false;
                button4.Text = "預約";
            }
            else
            {
                Isbutton[1] = true;
                button4.Text = "已預約";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void Pack(int i,Button button)
        {
            if (CPU1.PackType == EPackType.PackType_Drug)
            {
                #region
                /*
                Position = dvPrescription.Find(KeysBC[0].ToString());
                if (Position != -1)
                {
                    drvPrescription = dvPrescription[Position];
                    dvPrescriptionItem = drvPrescription.CreateChildView("Prescription_PrescriptionItem");
                    dataGridView.DataSource = dvPrescriptionItem;

                    label7.Text = drvPrescription["PatientName"].ToString();
                    label8.Text = drvPrescription["PatientNo"].ToString();
                    label9.Text = drvPrescription["ReceiveNo"].ToString();
                    label10.Text = drvPrescription["TTP"].ToString();
                    label11.Text = drvPrescription["PrescriptionDate"].ToString();
                    label12.Text = drvPrescription["PrescriptionTime"].ToString();
                    label13.Text = drvPrescription["TTPText"].ToString();
                    textBox1.Text = drvPrescription["PackNum"].ToString();
                }
                Preview();
                KeysBC.RemoveAt(0);
                Isbutton[i] = false;
                button.Enabled = false;
 
                CPU1.TotalNumber = (byte)((KeysBC.Count.Equals(0)) ? iTotal + 100 : iTotal);
                CPU1.PackNumber = byte.Parse(drvPrescription["PackNum"].ToString());
                CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
                //USB.TotalNumber = iTotal;
                //USB.TotalNumber = (KeysBC.Count.Equals(0)) ? iTotal + 100 : iTotal;
                //USB.SpaceNumber = USB.Month;
                //USB.IsShake = byte.Parse( USB.Day.ToString());

                //USB.PackNumber = int.Parse(drvPrescription["PackNum"].ToString());
                //Packer.SendCommand(USB);
                PackTimes[i]++;
                PackStep = 1;

                button.Enabled = true;

                drvPrescription["IsPacked"] = true;
                */
                #endregion
                // 陽明教養院版本
                Isbutton[i] = false;
                button.Enabled = false;
                CPU1.StartNumber = 0x01;
                CPU1.TotalNumber = byte.Parse(iTotal.ToString());

                CPU1.PackNumber = byte.Parse(iTotal.ToString());
                CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
                PackTimes[i]++;
                PackStep = 1;

                button.Enabled = true;
            }
            else if (CPU1.PackType == EPackType.PackType_Powder)
            {
                // 陽明教養院版本
                Isbutton[i] = false;
                button.Enabled = false;
                CPU1.StartNumber = 0x01;
                CPU1.TotalNumber = USB.PowderLocation;

                CPU1.PackNumber = USB.PowderLocation;
                CPU1.TXParameterSetting(ECpu1Command.Cpu1Command_USBPackStart);
                PackTimes[i]++;
                PackStep = 1;

                button.Enabled = true;
                System.Threading.Thread.Sleep(2000);
                Close();
            }
            
        }


        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            int a = PackTimes[0] + PackTimes[1] + PackTimes[2] + PackTimes[3];
            if (a != 0)
            {
                drvPrescription["IsPacked"] = true;
                taPrescription.Update(dsPrinter);
                f1.FillPrescription();
                f1.checkBox_IsPackAll.Checked = true;
                //f1.taPrescription.Fill(this.dsPrinter.Prescription);
                //f1.prescription1TableAdapter.Fill(this.dsPrinter.Prescription1);
            }
        }*/
        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            int a = PackTimes[0] + PackTimes[1] + PackTimes[2] + PackTimes[3];
            if (a != 0)
            {
                /*
                DataRow row = dsPrinter.Prescription.NewRow();
                for (int i = 0; i < dsPrinter.Prescription.Columns.Count; i++)
                    row[i] = drvPrescription[i];
                row["PrescriptionKey"] += "X";
                row["IsPacked"] = true;
                DataTable DT = new DataTable();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter("select * from Prescription where PrescriptionKey = ?", dsP.cn))
                {
                    dsP.cn.Open();
                    adapter.SelectCommand.Parameters.Add(new OleDbParameter("?PrescriptionKey", OleDbType.VarChar, 50)).Value = row["PrescriptionKey"];
                    adapter.Fill(DT);
                    dsP.cn.Close();
                }

                if (DT.Rows.Count == 0)
                {
                    if (dvPrescriptionItem.Count < ItemQTY)
                    {
                        dsPrinter.Prescription.Rows.Add(row);
                        ModyItem(row["PrescriptionKey"].ToString());
                    }
                    else
                        drvPrescription["IsPacked"] = true;
                }
                else
                {
                    if (dvPrescriptionItem.Count < ItemQTY)
                    {
                        ModyItem(row["PrescriptionKey"].ToString());
                    }
                    else
                    {
                        ModyItem(row["PrescriptionKey"].ToString());

                        using (OleDbCommand Cmd = new OleDbCommand("delete * from Prescription where PrescriptionKey = ?", dsP.cn))
                        {
                            dsP.cn.Open();
                            Cmd.Parameters.Add(new OleDbParameter("?PrescriptionKey", OleDbType.VarChar, 50)).Value = drvPrescription["PrescriptionKey"].ToString();
                            Cmd.ExecuteNonQuery();
                            dsP.cn.Close();
                        }
                        dsPrinter.Prescription.Rows.RemoveAt(Position);
                    }

                }
                */

                //drvPrescription["IsPacked"] = true;
                //taPrescription.Update(dsPrinter);
                //f1.FillPrescription();
                //f1.checkBox_IsPackAll.Checked = true;

            }
        }
        private void ModyItem(string key)
        {
            OleDbCommand Cmd;
            List<string> PKey = new List<string>();
            for (int i = 0; i < dvPrescriptionItem.Count; i++)
                PKey.Add(dvPrescriptionItem[i]["PrescriptionItemKey"].ToString());
            dsP.cn.Open();
            foreach (string ss in PKey)
            {
                Cmd = new OleDbCommand("update PrescriptionItem set PrescriptionKey = ? where PrescriptionItemKey = ?", dsP.cn);
                Cmd.Parameters.Add(new OleDbParameter("?PrescriptionKey", OleDbType.VarChar, 50)).Value = key;
                Cmd.Parameters.Add(new OleDbParameter("?PrescriptionItemKey", OleDbType.VarChar, 50)).Value = ss;
                Cmd.ExecuteNonQuery();
            }
            dsP.cn.Close();
        }
        private void timer_USBPacker_Tick(object sender, EventArgs e)
        {
            if (USB.Cpu1State == ECpu1State.Cpu1State_Idel)
            {
                button3.Enabled = true;
            }
            else
            {
                if (USB.ImageNumber == (PrintNumber))
                {
                    PrintNumber = USB.ImageNumber;
                    Preview(PrintNumber);
                    PrintNumber++;
                }
                button3.Enabled = false;
            }
            if (PackStep == 1 && USB.Cpu1State == ECpu1State.Cpu1State_Packing)
            {
                PackStep = 2;   // 包裝中

            }

            if (PackStep == 2 && USB.Cpu1State == ECpu1State.Cpu1State_Idel)
            {
                PackStep = 3;   // 包裝完成
                timer1.Enabled = true;

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Size = new Size(520, 470);

            PictureBox pb = new PictureBox();
            pb.BackColor = Color.White;
            pb.Size = new Size(520, 440);
            pb.Parent = f;
            pb.Location = new Point(0, 0);
            pb.Image = Bmp;

            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.StartPosition = FormStartPosition.CenterScreen;

            f.TopLevel = true;



            f.ShowDialog();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Select();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = drvPrescription["PackNum"].ToString();

            iTotal = int.Parse(drvPrescription["PackNum"].ToString());
        //    calculate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    int inputTotal = int.Parse(textBox1.Text) ;
                    if ( inputTotal ==0)
                    {
                        textBox1.Text = "1";
                    }
                    else if (inputTotal > 180)
                    {
                        textBox1.Text = "1";
                        //textBox1.Text = drvPrescription["PackNum"].ToString();
                    }
                    else
                    {
                        iTotal = inputTotal;
                        //iTotal = int.Parse(drvPrescription["PackNum"].ToString());
                    //    calculate();

                    }
                }
                catch(System.Exception ex)
                {
                    textBox1.Text = drvPrescription["PackNum"].ToString();
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        int PrintNumber = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PackStep == 3)
            {
                timer1.Enabled = false;

                //if (KeysBC.Count > 0 && CPU1.PackType == EPackType.PackType_Drug)
                //{
                //    //System.Threading.Thread.Sleep(3000);
                //    Pack(0, button3);
                //}
                //else if (CPU1.PackType == EPackType.PackType_Drug)
                //{
                //    foreach (string ss in Keys)
                //        KeysBC.Add(ss);
                //}

            }
        }

        private void medicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPrinter);

        }


    }
}
