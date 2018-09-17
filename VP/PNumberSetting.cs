using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VP
{
    public partial class PNumberSetting : Form
    {
        public PNumberSetting()
        {
            InitializeComponent();
        }
        int PackingNumber;
        public int PNumber
        {
            set 
            {
                this.PackingNumber = value;
            }
            get
            {
                return this.PackingNumber;
            }
        }

        private void PNumberSetting_Load(object sender, EventArgs e)
        {
            //LabNum.Text.daDataBindings = PackingNumber;
            this.TopMost = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NumberSet(int Number)
        {
            PNumber = (PackingNumber * 10 + Number) % 1000;
            LabNum.Text = PackingNumber.ToString().PadLeft(3, '0');
        }
        private void BT0_Click(object sender, EventArgs e)
        {
            NumberSet(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NumberSet(1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NumberSet(2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NumberSet(3);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NumberSet(4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NumberSet(5);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            NumberSet(6);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            NumberSet(7);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            NumberSet(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberSet(9);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PNumber = 0;
            LabNum.Text = "000";
        }
    }
}
