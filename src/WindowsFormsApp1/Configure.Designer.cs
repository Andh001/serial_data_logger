using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Configure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPorts = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cbobaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cboParityBits = new System.Windows.Forms.ComboBox();
            this.lblParityBits = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPorts
            // 
            this.lblPorts.Location = new System.Drawing.Point(0, 0);
            this.lblPorts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(67, 15);
            this.lblPorts.TabIndex = 12;
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cboPorts.Location = new System.Drawing.Point(137, 9);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(2);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(99, 21);
            this.cboPorts.TabIndex = 1;
            this.cboPorts.Text = "COM1";
            // 
            // cbobaudRate
            // 
            this.cbobaudRate.FormattingEnabled = true;
            this.cbobaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.cbobaudRate.Location = new System.Drawing.Point(137, 57);
            this.cbobaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cbobaudRate.Name = "cbobaudRate";
            this.cbobaudRate.Size = new System.Drawing.Size(99, 21);
            this.cbobaudRate.TabIndex = 3;
            this.cbobaudRate.Text = "9600";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.Location = new System.Drawing.Point(11, 49);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(100, 31);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            this.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(137, 105);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(99, 21);
            this.cboDataBits.TabIndex = 5;
            this.cboDataBits.Text = "8";
            // 
            // lblDataBits
            // 
            this.lblDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBits.Location = new System.Drawing.Point(11, 96);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(100, 31);
            this.lblDataBits.TabIndex = 4;
            this.lblDataBits.Text = "Data Bits:";
            this.lblDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboStopBits.Location = new System.Drawing.Point(137, 154);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(99, 21);
            this.cboStopBits.TabIndex = 7;
            this.cboStopBits.Text = "2";
            // 
            // lblStopBits
            // 
            this.lblStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopBits.Location = new System.Drawing.Point(11, 145);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(100, 31);
            this.lblStopBits.TabIndex = 6;
            this.lblStopBits.Text = "Stop Bits:";
            this.lblStopBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboParityBits
            // 
            this.cboParityBits.FormattingEnabled = true;
            this.cboParityBits.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "None"});
            this.cboParityBits.Location = new System.Drawing.Point(137, 206);
            this.cboParityBits.Margin = new System.Windows.Forms.Padding(2);
            this.cboParityBits.Name = "cboParityBits";
            this.cboParityBits.Size = new System.Drawing.Size(99, 21);
            this.cboParityBits.TabIndex = 9;
            this.cboParityBits.Text = "Even";
            // 
            // lblParityBits
            // 
            this.lblParityBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParityBits.Location = new System.Drawing.Point(11, 197);
            this.lblParityBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParityBits.Name = "lblParityBits";
            this.lblParityBits.Size = new System.Drawing.Size(100, 31);
            this.lblParityBits.TabIndex = 8;
            this.lblParityBits.Text = "Parity Bits:";
            this.lblParityBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPort.Location = new System.Drawing.Point(91, 249);
            this.btnOpenPort.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(82, 41);
            this.btnOpenPort.TabIndex = 10;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ports:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.cboParityBits);
            this.Controls.Add(this.lblParityBits);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.lblStopBits);
            this.Controls.Add(this.cboDataBits);
            this.Controls.Add(this.lblDataBits);
            this.Controls.Add(this.cbobaudRate);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.lblPorts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Configure";
            this.Text = "Configure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ComboBox cbobaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cboParityBits;
        private System.Windows.Forms.Label lblParityBits;
        /*private*/
        public System.Windows.Forms.Button btnOpenPort;
        private Label label1;
    }
}