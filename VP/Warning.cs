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
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }
        public string CasNm = string.Empty;
        private void Warning_Load(object sender, EventArgs e)
        {
            label2.Text = CasNm;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
