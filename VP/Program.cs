using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Data.OleDb;
using System.Data.Odbc;


namespace VP
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class DataSetPrinter
    {
        public DataSet dataSet;
        public OleDbConnection cn;


        public DataSetPrinter()
        {
            dataSet = new DataSet();

            VP.Properties.Settings VPProperties = new VP.Properties.Settings();

            cn = new OleDbConnection(VPProperties.PRINTERConnectionString);
           
        }

    }

}