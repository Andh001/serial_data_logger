using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OpenLog : Form
    {
        public DataLogger P;
        String ROOT = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Weld_Readings\\";
        public OpenLog(DataLogger DL)
        {
            this.P = DL;
            InitializeComponent();
            if (P.btnExport.Enabled == false)
                P.currentFile = String.Empty;
            foreach (String i in System.IO.Directory.GetFiles(ROOT))
            {
                if (i.Contains(P.dateTimePicker1.Value.Date.ToString("d-M-yyyy")) && i.Split('\\').ToList().Last().CompareTo(P.currentFile) != 0)
                    listBox1.Items.Add(i.Split('\\').ToList().Last()); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name = listBox1.Text;
            System.Diagnostics.Process.Start(ROOT+Name);
            this.Close();
        }
    }
}
