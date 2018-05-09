using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CSV
    {
        public String currF = String.Empty;
        List<String> names = new List<string>(new string[] { "Weld Counter", "Program Number", "Set Voltage", "L-Bank Voltage", "R-Bank Voltage", "Weld current low limit", "Peak current", "weld current high limit", "peak time", "rms current", "half peak time", "weld status", "Time stamp" });
        string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public System.IO.StreamWriter file;
        void w(String D)
        {
            this.file.Write(D);
        }
        void w(List<String> tokens)
        {
            foreach (String u in tokens)
            {
                if (u != String.Empty)
                    w(u + ",");
            }
            w("\n");
        }
        public CSV(int o, String f)
        {
            int i = 0;
            
            String hh = String.Empty;
            while (File.Exists(Desktop + "\\Weld_Readings\\" + f + hh + ".CSV"))
            {
                hh = '_' + i.ToString();
                i++;
            }
            file = new System.IO.StreamWriter(Desktop + "\\Weld_Readings\\" + f + hh + ".CSV", true);
            currF = f + hh + ".CSV";
            if (o == 1)
                names.RemoveAt(4);
            w(names);
        }

        public void Add_Data(List<String> tokens)
        {
            w(tokens);
        }
        public void save()
        {
            this.file.Close();
        }
    }
}
