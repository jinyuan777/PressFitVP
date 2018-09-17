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
    public partial class SEARCH : Form
    {
        public SEARCH()
        {
            InitializeComponent();
        }

        private void SEARCH_Load(object sender, EventArgs e)
        {
            //this.drugTableAdapter.FillBy(this.pRINTERDataSet.Drug, DrugCD.Text + '%', Cassete.Text + '%', DRUGNM.Text + '%');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pRINTERDataSet.Drug.Clear();
            if (DrugCD.Text == string.Empty && Cassete.Text == string.Empty && DRUGNM.Text == string.Empty)
                this.drugTableAdapter.FillBy(this.pRINTERDataSet.Drug, DrugCD.Text + '%', Cassete.Text + '%', DRUGNM.Text + '%');
            this.drugTableAdapter.FillBy(this.pRINTERDataSet.Drug, DrugCD.Text  , Cassete.Text , DRUGNM.Text );
        }
    }
}
