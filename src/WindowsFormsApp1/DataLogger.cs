using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;
using System.IO.Ports;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Win32;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class DataLogger : Form
    {
        public SerialPort mP = new SerialPort();
        String emp = String.Empty;
        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        System.Data.DataTable table = new System.Data.DataTable();
        public String currentFile = String.Empty;
        int opt = -1;
        string buff = "\0";
        int j = 1;
        List<String> tp;
        String t1p;
        int temp_msg = 0;
        delegate void SetTextCallback(string text);
        string id = "\0";
        int i = 1;
        String ttp = String.Empty;
        public CSV csv;
        string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public String issxl = "";
        static int Screen_Width = Screen.PrimaryScreen.Bounds.Width;
        Double K = Convert.ToDouble(Screen_Width)/Convert.ToDouble(1024);
        String[] portsNames = SerialPort.GetPortNames();
        System.Collections.Generic.List<SerialPort> ports;
        Configure cf;
        public DataLogger()
        {
            if (!System.IO.Directory.Exists(Desktop + "\\Weld_Readings"))
                System.IO.Directory.CreateDirectory(Desktop + "\\Weld_Readings");
            ports = new System.Collections.Generic.List<SerialPort>(new SerialPort[portsNames.Length]);
            foreach (Process process in Process.GetProcessesByName("Excel"))
                process.Kill();
            InitializeComponent();
            _make_screen();
            mP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(data_rec_1);
            dateTimePicker1.Value = System.DateTime.Now;
            issxl = isofins();
            w1 = columnHeader1.Width;
            w2 = columnHeader2.Width;
            w3 = columnHeader3.Width;
            w4 = columnHeader4.Width;
            w5 = columnHeader5.Width;
            w6 = columnHeader6.Width;
            w7 = columnHeader7.Width;
            w8 = columnHeader8.Width;
            w9 = columnHeader9.Width;
            w10 = columnHeader10.Width;
            w11 = columnHeader11.Width;
            w12 = columnHeader12.Width;
            int MM = w1 + w2 + w3 + w4 + w5 + w6 + w7 + w8 + w9 + w10 + w11 + w12;
            w14 = columnHeader14.Width;
            int L = ltvLogData.Width;
            change();
            cf = new Configure(this);
            btnConfigure.Text = "Disconnected";
            _color();
        }

        void _color()
        {


richTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
richTextBox1.Enabled = true;

richTextBox2.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
richTextBox2.Enabled = true;

richTextBox3.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox3.ForeColor = System.Drawing.SystemColors.Window;
richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
richTextBox3.Enabled = true;

richTextBox4.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox4.ForeColor = System.Drawing.SystemColors.Window;
richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
richTextBox4.Enabled = true;

richTextBox5.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox5.ForeColor = System.Drawing.SystemColors.Window;
richTextBox5.SelectionAlignment = HorizontalAlignment.Center;
richTextBox5.Enabled = true;

richTextBox6.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox6.ForeColor = System.Drawing.SystemColors.Window;
richTextBox6.SelectionAlignment = HorizontalAlignment.Center;
richTextBox6.Enabled = true;

richTextBox7.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox7.ForeColor = System.Drawing.SystemColors.Window;
richTextBox7.SelectionAlignment = HorizontalAlignment.Center;
richTextBox7.Enabled = true;

richTextBox8.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox8.ForeColor = System.Drawing.SystemColors.Window;
richTextBox8.SelectionAlignment = HorizontalAlignment.Center;
richTextBox8.Enabled = true;

richTextBox9.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox9.ForeColor = System.Drawing.SystemColors.Window;
richTextBox9.SelectionAlignment = HorizontalAlignment.Center;
richTextBox9.Enabled = true;

richTextBox10.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox10.ForeColor = System.Drawing.SystemColors.Window;
richTextBox10.SelectionAlignment = HorizontalAlignment.Center;
richTextBox10.Enabled = true;

richTextBox11.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox11.ForeColor = System.Drawing.SystemColors.Window;
richTextBox11.SelectionAlignment = HorizontalAlignment.Center;
richTextBox11.Enabled = true;

richTextBox12.BackColor = System.Drawing.SystemColors.Highlight;
richTextBox12.ForeColor = System.Drawing.SystemColors.Window;
richTextBox12.SelectionAlignment = HorizontalAlignment.Center;
richTextBox12.Enabled = true;

        }

        private static String isofins()
        {
            RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\Winword.exe");
            return k!=null?k.GetValue("Path").ToString():"NOT_INSTALLED";
        }

        private void data_rec_1(object sender, SerialDataReceivedEventArgs e)
        {
            int eee = 0;
            int ii;
            id = mP.ReadExisting();
            MessageBox.Show("HERERER\n" + id);
            if (id != emp){
            for (ii = 0; ii < id.Length; ii++)
            {
                if (id[ii] == '?')
                {
                    eee = 1;
                    break;
                }
            }
            if (eee == 1)
            {
                for (ii = 0; id[ii] != '?'; ii++)
                {
                    buff += id[ii];
                }
                buff = buff.Replace("?",emp);
                if(opt == 0)
                    this.BeginInvoke(new SetTextCallback(SetText_A), new object[] { buff });
                else
                    this.BeginInvoke(new SetTextCallback(SetText_BB), new object[] { buff });
                int l = buff.Length;
                buff = emp;
                for(ii=l;ii<id.Length;ii++)
                {
                    buff += id[ii];
                }
            }
            else
            {
                buff += id;
            }
            }
        }

        private void SetText_A(string text)
        {
            // operation is 0
            List<string> tokens = new List<string>();
            tokens = text.Split(',').ToList();
            t1p = text;
            if (tokens.Count > 3)
            {
                int ii = 0;
                ListViewItem item1 = new ListViewItem(i.ToString());
                ListViewItem item2 = new ListViewItem(tokens[0]);
                for (ii = 0; ii < tokens.Count - 1; ii++)
                {
                    try
                    {
                        if (ii == 11)
                            tokens[11] = tokens[11].Equals("1") ? "Good" : "Bad";
                        item1.SubItems.Add(tokens[ii]);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }

                }
                if (tokens.Count == 12)
                {
                   // ttp = txtoption.Text;
                    MessageBox.Show("Please Select Correct kVA Ratings");
                    btnset.Invoke(new Action(() => btnset.Enabled = true));
                    tp = tokens;
                    // csv.Add_Data(tokens);
                }
               /* if (tp != null && ttp != txtoption.Text)
                {
                    csv.Add_Data(tp);
                    tp = null;
                    ttp = String.Empty;
                }*/
                item1.SubItems.Add(DateTime.Now.ToString("h:mm:ss tt"));
               // richTextBox1.Invoke(new Action(() => richTextBox1.Text = tokens[0]));
                richTextBox1.Invoke(new Action(() => richTextBox1.Text = tokens[0]));
                richTextBox2.Invoke(new Action(() => richTextBox2.Text = tokens[1]));
                richTextBox3.Invoke(new Action(() => richTextBox3.Text = tokens[2]));
                richTextBox4.Invoke(new Action(() => richTextBox4.Text = tokens[3]));
                richTextBox5.Invoke(new Action(() => richTextBox5.Text = tokens[4]));
                richTextBox6.Invoke(new Action(() => richTextBox6.Text = tokens[5]));
                richTextBox7.Invoke(new Action(() => richTextBox7.Text = tokens[6]));
                richTextBox8.Invoke(new Action(() => richTextBox8.Text = tokens[7]));
                richTextBox9.Invoke(new Action(() => richTextBox9.Text = tokens[8]));
                richTextBox10.Invoke(new Action(() => richTextBox10.Text = tokens[9]));
                richTextBox11.Invoke(new Action(() => richTextBox11.Text = tokens[10]));
                richTextBox12.Invoke(new Action(() => richTextBox12.Text = tokens[11]));
                tokens.RemoveAt(12);
                //  richTextBox14.Text = DateTime.Now.ToString("h:mm:ss tt");
                tokens.Add(item1.SubItems[item1.SubItems.Count-1].Text);
                csv.Add_Data(tokens);
                i += 1;
                ltvLogData.Invoke(new Action(() => ltvLogData.Items.Insert(0, item1)));
                btnExport.Enabled = true;
            }
        }

        private void SetText_BB(string text)
        {
            List<string> tokens = new List<string>();
            t1p = text;
            text = text.Replace("?",emp);
            tokens = text.Split(',').ToList();
            if (tokens.Count > 3)
            {
                int ii = 0;
                ListViewItem item1 = new ListViewItem(i.ToString());
                ListViewItem item2 = new ListViewItem(tokens[0]);
                for (ii = 0; ii < tokens.Count - 1; ii++)
                {
                        try
                        {
                            if (ii == 10)
                            {
                                if (tokens[10].Equals("1"))
                                    tokens[10] = "Good";
                                else
                                    tokens[10] = "Bad";
                            }
                            item1.SubItems.Add(tokens[ii]);
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.ToString());
                        }
                }
               // MessageBox.Show(tokens.Count.ToString());
                if (tokens.Count == 13)
                {
                    MessageBox.Show("Please Select Correct kVA Ratings");
                    btnset.Invoke(new Action(() => btnset.Enabled = true));
                    tp = tokens;
                   // csv.Add_Data(tokens);
                }
               /* if (tp != null && ttp != txtoption.Text)
                { 
                    csv.Add_Data(tp);
                    tp = null;
                    ttp = String.Empty;
                }*/
                item1.SubItems.Add(DateTime.Now.ToString("h:mm:ss tt"));

                richTextBox1.Invoke(new Action(() => richTextBox1.Text = tokens[0]));
                richTextBox2.Invoke(new Action(() => richTextBox2.Text = tokens[1]));
                richTextBox3.Invoke(new Action(() => richTextBox3.Text = tokens[2]));
                richTextBox4.Invoke(new Action(() => richTextBox4.Text = tokens[3]));
                richTextBox6.Invoke(new Action(() => richTextBox6.Text = tokens[4]));
                richTextBox7.Invoke(new Action(() => richTextBox7.Text = tokens[5]));
                richTextBox8.Invoke(new Action(() => richTextBox8.Text = tokens[6]));
                richTextBox9.Invoke(new Action(() => richTextBox9.Text = tokens[7]));
                richTextBox10.Invoke(new Action(() => richTextBox10.Text = tokens[8]));
                richTextBox11.Invoke(new Action(() => richTextBox11.Text = tokens[9]));
                richTextBox12.Invoke(new Action(() => richTextBox12.Text = tokens[10]));
               // richTextBox11.Invoke(new Action(() => richTextBox11.Text = tokens[10]));

                /*richTextBox6.Invoke(new Action(() => richTextBox5.Text = tokens[4]));
                richTextBox7.Invoke(new Action(() => richTextBox6.Text = tokens[5]));
                richTextBox8.Invoke(new Action(() => richTextBox7.Text = tokens[6]));
                richTextBox9.Invoke(new Action(() => richTextBox8.Text = tokens[7]));
                richTextBox10.Invoke(new Action(() => richTextBox9.Text = tokens[8]));
                richTextBox11.Invoke(new Action(() => richTextBox10.Text = tokens[9]));
                richTextBox11.Invoke(new Action(() => richTextBox11.Text = tokens[10]));*/
                tokens.RemoveAt(11);
                tokens.Add(item1.SubItems[item1.SubItems.Count - 1].Text);
                csv.Add_Data(tokens);
                i += 1;
                ltvLogData.Invoke(new Action(() => ltvLogData.Items.Insert(0, item1)));
                btnExport.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VIEW_LOG log = new VIEW_LOG();
            log.Show();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ltvLogData.Columns[e.ColumnIndex].Width;
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                using (var headerFont = new Font("Microsoft Sans Serif", 20, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(Brushes.Pink, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Black, e.Bounds, sf);
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            OpenLog f = new OpenLog(this);
            f.Show();
        }

        public void InitPorts()
        {
            portsNames = SerialPort.GetPortNames();
            ports = new System.Collections.Generic.List<SerialPort>();
            for (int i = 0; i < portsNames.Length; i++)
            {
                ports.Add(new SerialPort());
            }
            System.Threading.Tasks.Parallel.For(0, portsNames.Length, i =>
            {
                try
                {
                    ports[i].PortName = portsNames[i];
                    ports[i].BaudRate = 9600;
                    ports[i].DataBits = Convert.ToInt16(8); //
                    ports[i].StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1"); //
                    ports[i].Open();
                }
                catch (Exception Exception)
                {
                    MessageBox.Show(Exception.ToString());
                    ports[i].Close();
                }
            });
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            if (opt != -1)
            {
             /*   if (btnConfigure.BackColor == Color.Lime)
                {
                    btnConfigure.BackColor = Color.Red;
                    btnConfigure.Text = "Disconnected";
                    ports = null;
                    ltvLogData.Clear();
                    richTextBox1.Clear();
                    richTextBox2.Clear();
                    richTextBox3.Clear();
                    richTextBox4.Clear();
                    richTextBox5.Clear();
                    richTextBox6.Clear();
                    richTextBox7.Clear();
                    richTextBox8.Clear();
                    richTextBox9.Clear();
                    richTextBox10.Clear();
                    richTextBox11.Clear();
                    richTextBox12.Clear();
                }*/
                InitPorts();
                System.Threading.Tasks.Parallel.For(0, portsNames.Length, i =>
                {
                    ports[i].DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler((s, eee) => port_DataReceived_2(s, eee, i));
                });
            }
            else
            {
                MessageBox.Show("Please set kVA rating");
            }
        }

        private void port_DataReceived_2(object sender, SerialDataReceivedEventArgs e, int selected)
        {
            int eee = 0;
            int ii;
            if (ports[selected].IsOpen == true)
            {
                try
                {
                    id = ports[selected].ReadExisting();
                }
                catch (Exception ee)
                {
                    id = emp;
                    ports[selected].Close();
                }
                if (id != emp && ports[selected].IsOpen)
                {
                    if (btnConfigure.Enabled == true)
                    {
                        btnConfigure.Invoke(new Action(() => btnConfigure.Enabled = false));
                        btnConfigure.Invoke(new Action(() => btnConfigure.BackColor = System.Drawing.Color.Lime));
                    }
                    for (ii = 0; ii < id.Length; ii++)
                    {
                        if (id[ii] == '?')
                        {
                            eee = 1;
                            break;
                        }
                    }
                    if (eee == 1)
                    {
                        if (temp_msg == 0 && mP.IsOpen == false)
                        {
                           // MessageBox.Show("Selected port is : COM" + (selected + 1).ToString());
                            temp_msg = 1;
                            btnConfigure.Invoke(new Action(() => btnConfigure.BackColor = System.Drawing.Color.Lime));
                            btnConfigure.Invoke(new Action(() => btnConfigure.Text = "Connected"));
                        }
                        for (ii = 0; id[ii] != '?'; ii++)
                        {
                            buff += id[ii];
                        }
                        buff = buff.Replace("?", emp);
                        if (opt == 0)
                            SetText_A(buff);
                        else
                            SetText_BB(buff);
                        int l = buff.Length;
                        buff = emp;
                        for (ii = l + 1; ii < id.Length; ii++)
                        {
                            buff += id[ii];
                        }
                    }
                    else
                    {
                        buff += id;
                    }
                }
                else
                {
                    ports[selected].Close();
                    MessageBox.Show("Closed " + selected.ToString());
                    mP.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.BeginInvoke(new SetTextCallback(SetText_A), new object[] { "123123" });
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (opt != -1)
            { 
                csv.save();
                btnExport.Enabled = false;
            }
            else
                MessageBox.Show("Cannot log Empty data");
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            if (btnExport.Enabled == true && i != 1)
            {
                MessageBox.Show("Please Export the data");
            }
            else
            {
                foreach (Process process in Process.GetProcessesByName("Excel"))
                    process.Kill();
                if (mP.IsOpen)
                {
                    mP.Close();
                }
                this.Close();
            }
        }

        private void btnOpenLogClick(object sender, EventArgs e)
        {
            OpenLog o = new OpenLog(this);
            if(o.listBox1.Items.Count != 0)
                o.Show();
            else
                MessageBox.Show("There is log for " + dateTimePicker1.Text);
        }

        public void change()
        {
            if (opt == 0)
            {
                label6.Text = "L-Bank\r\nVoltage";
                columnHeader4.Text = "LBankVoltage";
                if (ltvLogData.Columns.Contains(columnHeader5))
                {
                    ltvLogData.Columns.Remove(columnHeader5);
                }
                if (label7.Visible == false && richTextBox5.Visible == false)
                {
                    label7.Visible = true;
                    richTextBox5.Visible = true;
                }
                ltvLogData.Columns.Remove(columnHeader6);
                ltvLogData.Columns.Remove(columnHeader7);
                ltvLogData.Columns.Remove(columnHeader8);
                ltvLogData.Columns.Remove(columnHeader9);
                ltvLogData.Columns.Remove(columnHeader10);
                ltvLogData.Columns.Remove(columnHeader11);
                ltvLogData.Columns.Remove(columnHeader12);
                ltvLogData.Columns.Remove(columnHeader14);
                ltvLogData.Columns.Add(columnHeader5);
                ltvLogData.Columns.Add(columnHeader6);
                ltvLogData.Columns.Add(columnHeader7);
                ltvLogData.Columns.Add(columnHeader8);
                ltvLogData.Columns.Add(columnHeader9);
                ltvLogData.Columns.Add(columnHeader10);
                ltvLogData.Columns.Add(columnHeader11);
                ltvLogData.Columns.Add(columnHeader12);
                ltvLogData.Columns.Add(columnHeader14);

                int kk = 1;
                columnHeader1.Width = Calculate(w1) + kk - 2;
                columnHeader2.Width = Calculate(w2) + kk  - 4;
                columnHeader3.Width = Calculate(w3) + kk - 2;
                columnHeader4.Width = Calculate(w4) + kk - 2;
                columnHeader5.Width = Calculate(w5) + kk;
                columnHeader6.Width = Calculate(w6) + kk;
                columnHeader7.Width = Calculate(w7) + kk;
                columnHeader8.Width = Calculate(w8) + kk;
                columnHeader9.Width = Calculate(w9) + kk;
                columnHeader10.Width = Calculate(w10) + kk;
                columnHeader11.Width = Calculate(w11) + kk;
                columnHeader12.Width = Calculate(w12) + kk;
                columnHeader14.Width = Calculate(w14) + kk - 1;

            }
            else
            {
                label6.Text = "Cap Bank\nVoltage";
                columnHeader4.Width = 70;
                columnHeader4.Text = "CapBVoltage";
                if (ltvLogData.Columns.Contains(columnHeader5))
                {
                    ltvLogData.Columns.Remove(columnHeader5);
                    int kk = 6;
                    columnHeader1.Width = Calculate(w1) + kk-2;
                    columnHeader2.Width = Calculate(w2) + kk - 4;
                    columnHeader3.Width = Calculate(w3) + kk;
                    columnHeader4.Width = Calculate(w4) + kk;
                    columnHeader5.Width = Calculate(w5) + kk;
                    columnHeader6.Width = Calculate(w6) + kk;
                    columnHeader7.Width = Calculate(w7) + kk;
                    columnHeader8.Width = Calculate(w8) + kk;
                    columnHeader9.Width = Calculate(w9) + kk;
                    columnHeader10.Width = Calculate(w10) + kk;
                    columnHeader11.Width = Calculate(w11) + kk;
                    columnHeader12.Width = Calculate(w12) + kk;
                    columnHeader14.Width = Calculate(w14) + kk - 2;

                }
                if (label7.Visible == true && richTextBox5.Visible == true)
                {
                    label7.Visible = false;
                    richTextBox5.Visible = false;
                }
            }
        }


        void _sub_change()
        {
            List<string> opts = new List<string>();
            opts = txtoption.Text.Split(' ').ToList();
            int op = Int32.Parse(opts[0]);
            if (op > 16)
                opt = 0;
            else
                opt = 1;
            currentFile = dateTimePicker1.Value.Date.ToString("d-M-yyyy") + "_" + opts[0] + "kVA";
            csv = new CSV(opt, currentFile);
            currentFile = csv.currF;
            if (tp != null)
            {
                csv.Add_Data(tp);
                tp = null;
            }
            change();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            _sub_change();
            if (btnset.Enabled == true)
                btnset.Enabled = false;
        }

        int Calculate(int x)
        {
            return Convert.ToInt32(K*Convert.ToDouble(x));
        }
        public void _make_screen()
        {
            panel1.Location = new Point(Screen_Width - 316 - 10, panel1.Location.Y);
            label1.Location = new Point(Calculate(label1.Location.X), label1.Location.Y);
            label2.Location = new Point(Calculate(label2.Location.X), label2.Location.Y);
            label3.Location = new Point(Calculate(label3.Location.X), label3.Location.Y);
            label4.Location = new Point(Calculate(label4.Location.X), label4.Location.Y);
            label5.Location = new Point(Calculate(label5.Location.X), label5.Location.Y);
            label6.Location = new Point(Calculate(label6.Location.X), label6.Location.Y);
            label7.Location = new Point(Calculate(label7.Location.X), label7.Location.Y);
            label8.Location = new Point(Calculate(label8.Location.X), label8.Location.Y);
            label9.Location = new Point(Calculate(label9.Location.X), label9.Location.Y);
            label10.Location = new Point(Calculate(label10.Location.X), label10.Location.Y);
            label11.Location = new Point(Calculate(label11.Location.X), label11.Location.Y);
            label12.Location = new Point(Calculate(label12.Location.X), label12.Location.Y);
            label13.Location = new Point(Calculate(label13.Location.X), label13.Location.Y);
            label14.Location = new Point(Calculate(label14.Location.X), label14.Location.Y);
            lblName.Location = new Point(Calculate(lblName.Location.X), lblName.Location.Y);

            richTextBox1.Location = new Point(Calculate(richTextBox1.Location.X), richTextBox1.Location.Y);
            richTextBox2.Location = new Point(Calculate(richTextBox2.Location.X), richTextBox2.Location.Y);
            richTextBox3.Location = new Point(Calculate(richTextBox3.Location.X), richTextBox3.Location.Y);
            richTextBox4.Location = new Point(Calculate(richTextBox4.Location.X), richTextBox4.Location.Y);
            richTextBox5.Location = new Point(Calculate(richTextBox5.Location.X), richTextBox5.Location.Y);
            richTextBox6.Location = new Point(Calculate(richTextBox6.Location.X), richTextBox6.Location.Y);
            richTextBox7.Location = new Point(Calculate(richTextBox7.Location.X), richTextBox7.Location.Y);
            richTextBox8.Location = new Point(Calculate(richTextBox8.Location.X), richTextBox8.Location.Y);
            richTextBox9.Location = new Point(Calculate(richTextBox9.Location.X), richTextBox9.Location.Y);
            richTextBox10.Location = new Point(Calculate(richTextBox10.Location.X), richTextBox10.Location.Y);
            richTextBox11.Location = new Point(Calculate(richTextBox11.Location.X), richTextBox11.Location.Y);
            richTextBox12.Location = new Point(Calculate(richTextBox12.Location.X), richTextBox12.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(Screen_Width - 316 - 10, panel1.Location.Y);
            label1.Location = new Point(Calculate(label1.Location.X), label1.Location.Y);
            label2.Location = new Point(Calculate(label2.Location.X), label2.Location.Y);
            label3.Location = new Point(Calculate(label3.Location.X), label3.Location.Y);
            label4.Location = new Point(Calculate(label4.Location.X), label4.Location.Y);
            label5.Location = new Point(Calculate(label5.Location.X), label5.Location.Y);
            label6.Location = new Point(Calculate(label6.Location.X), label6.Location.Y);
            label7.Location = new Point(Calculate(label7.Location.X), label7.Location.Y);
            label8.Location = new Point(Calculate(label8.Location.X), label8.Location.Y);
            label9.Location = new Point(Calculate(label9.Location.X), label9.Location.Y);
            label10.Location = new Point(Calculate(label10.Location.X), label10.Location.Y);
            label11.Location = new Point(Calculate(label11.Location.X), label11.Location.Y);
            label12.Location = new Point(Calculate(label12.Location.X), label12.Location.Y);
            label13.Location = new Point(Calculate(label13.Location.X), label13.Location.Y);
            label14.Location = new Point(Calculate(label14.Location.X), label14.Location.Y);
            lblName.Location = new Point(Calculate(lblName.Location.X), lblName.Location.Y);

            richTextBox1.Location = new Point(Calculate(richTextBox1.Location.X), richTextBox1.Location.Y);
            richTextBox2.Location = new Point(Calculate(richTextBox2.Location.X), richTextBox2.Location.Y);
            richTextBox3.Location = new Point(Calculate(richTextBox3.Location.X), richTextBox3.Location.Y);
            richTextBox4.Location = new Point(Calculate(richTextBox4.Location.X), richTextBox4.Location.Y);
            richTextBox5.Location = new Point(Calculate(richTextBox5.Location.X), richTextBox5.Location.Y);
            richTextBox6.Location = new Point(Calculate(richTextBox6.Location.X), richTextBox6.Location.Y);
            richTextBox7.Location = new Point(Calculate(richTextBox7.Location.X), richTextBox7.Location.Y);
            richTextBox8.Location = new Point(Calculate(richTextBox8.Location.X), richTextBox8.Location.Y);
            richTextBox9.Location = new Point(Calculate(richTextBox9.Location.X), richTextBox9.Location.Y);
            richTextBox10.Location = new Point(Calculate(richTextBox10.Location.X), richTextBox10.Location.Y);
            richTextBox11.Location = new Point(Calculate(richTextBox11.Location.X), richTextBox11.Location.Y);
            richTextBox12.Location = new Point(Calculate(richTextBox12.Location.X), richTextBox12.Location.Y);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cf.Show();
        }
    }
}
