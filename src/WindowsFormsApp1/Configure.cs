using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Configure : Form
    {
        private DataLogger par;
        public Configure(DataLogger par)
        {
            InitializeComponent();
            this.par = par;
        }

        public void btnOpenPort_Click(object sender, EventArgs e)
        {
            par.mP.PortName = cboPorts.Text;
            par.mP.BaudRate = Convert.ToInt32(cbobaudRate.Text);
            par.mP.DataBits = Convert.ToInt16(cboDataBits.Text);
            par.mP.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
            try
            {
                par.mP.Open();
                par.btnConfigure.BackColor = System.Drawing.Color.Lime;
                par.btnConfigure.Enabled = false;
                this.Close();
            }
            catch (Exception SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                par.mP.Close();
            }
            if (par.mP.IsOpen)
            {
                MessageBox.Show("Port is Open");
                this.Close();
            }
        }
    }
}
