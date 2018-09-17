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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void tTPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tTPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRINTERDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'pRINTERDataSet.TTP' 資料表。您可以視需要進行移動或移除。
            this.tTPTableAdapter.Fill(this.pRINTERDataSet.TTP);

        }

        private void tTPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
