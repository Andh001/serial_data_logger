using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class DataLogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataLogger));
            this.lblName = new System.Windows.Forms.Label();
            this.pboArtech = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.ltvLogData = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.txtoption = new System.Windows.Forms.ComboBox();
            this.btnset = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pboArtech)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(360, 11);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(300, 51);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "PROJECTION WELDING\r\nMACHINE DATA LOGGER";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboArtech
            // 
            this.pboArtech.Image = ((System.Drawing.Image)(resources.GetObject("pboArtech.Image")));
            this.pboArtech.Location = new System.Drawing.Point(11, 11);
            this.pboArtech.Margin = new System.Windows.Forms.Padding(2);
            this.pboArtech.Name = "pboArtech";
            this.pboArtech.Size = new System.Drawing.Size(307, 85);
            this.pboArtech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboArtech.TabIndex = 1;
            this.pboArtech.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.OldLace;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnExport.FlatAppearance.BorderSize = 2;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnExport.Location = new System.Drawing.Point(161, 45);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 35);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ltvLogData
            // 
            this.ltvLogData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvLogData.AutoArrange = false;
            this.ltvLogData.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ltvLogData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltvLogData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14});
            this.ltvLogData.Cursor = System.Windows.Forms.Cursors.Default;
            this.ltvLogData.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvLogData.GridLines = true;
            this.ltvLogData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ltvLogData.Location = new System.Drawing.Point(11, 249);
            this.ltvLogData.Margin = new System.Windows.Forms.Padding(2);
            this.ltvLogData.Name = "ltvLogData";
            this.ltvLogData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ltvLogData.Size = new System.Drawing.Size(1333, 208);
            this.ltvLogData.TabIndex = 19;
            this.ltvLogData.UseCompatibleStateImageBehavior = false;
            this.ltvLogData.View = System.Windows.Forms.View.Details;
            this.ltvLogData.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.ltvLogData.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            // 
            // Index
            // 
            this.Index.Text = "No.";
            this.Index.Width = 32;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Weld\r\nCntr";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Program";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SetVolt";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 51;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "LBankVolt";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "RBankVolt";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "WeldCurLoLim";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PeakCurrent";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 85;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "WeldCurHiLim";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 92;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PeakTime";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 62;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "RMSCurrent";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 81;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "HalfPeakTime";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 82;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "WeldStatus";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 76;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Timestamp";
            this.columnHeader14.Width = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "Program\r\nNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Weld\r\nCounter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "Set\r\nVoltage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 36);
            this.label6.TabIndex = 32;
            this.label6.Text = "L-Bank\r\nVoltage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 36);
            this.label7.TabIndex = 32;
            this.label7.Text = "R-Bank\r\nVoltage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 36);
            this.label8.TabIndex = 32;
            this.label8.Text = "Weld Current\r\nLow Limit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 36);
            this.label9.TabIndex = 32;
            this.label9.Text = "Peak\r\nCurrent";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(562, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 36);
            this.label10.TabIndex = 32;
            this.label10.Text = "Weld Current\r\nHigh Limit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(666, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 36);
            this.label11.TabIndex = 32;
            this.label11.Text = "Peak\r\nTime";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(740, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 36);
            this.label12.TabIndex = 32;
            this.label12.Text = "RMS\r\nCurrent";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(819, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 36);
            this.label13.TabIndex = 32;
            this.label13.Text = "Half Peak\r\nTime";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(906, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 36);
            this.label14.TabIndex = 32;
            this.label14.Text = "Weld\r\nStatus";
            // 
            // btnConfigure
            // 
            this.btnConfigure.BackColor = System.Drawing.Color.Red;
            this.btnConfigure.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnConfigure.FlatAppearance.BorderSize = 2;
            this.btnConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConfigure.ForeColor = System.Drawing.Color.Black;
            this.btnConfigure.Location = new System.Drawing.Point(161, 5);
            this.btnConfigure.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(152, 39);
            this.btnConfigure.TabIndex = 34;
            this.btnConfigure.Text = "Connect";
            this.btnConfigure.UseVisualStyleBackColor = false;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(19, 184);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(65, 35);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Cyan;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(93, 184);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(65, 35);
            this.richTextBox2.TabIndex = 36;
            this.richTextBox2.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox4.Enabled = false;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox4.Location = new System.Drawing.Point(233, 184);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(65, 35);
            this.richTextBox4.TabIndex = 38;
            this.richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.Location = new System.Drawing.Point(163, 184);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(65, 35);
            this.richTextBox3.TabIndex = 37;
            this.richTextBox3.Text = "";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox8.Enabled = false;
            this.richTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox8.Location = new System.Drawing.Point(565, 184);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(65, 35);
            this.richTextBox8.TabIndex = 42;
            this.richTextBox8.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox7.Enabled = false;
            this.richTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox7.Location = new System.Drawing.Point(486, 184);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(65, 35);
            this.richTextBox7.TabIndex = 41;
            this.richTextBox7.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox6.Enabled = false;
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox6.Location = new System.Drawing.Point(395, 184);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(65, 35);
            this.richTextBox6.TabIndex = 40;
            this.richTextBox6.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox5.Enabled = false;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox5.Location = new System.Drawing.Point(311, 184);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(65, 35);
            this.richTextBox5.TabIndex = 39;
            this.richTextBox5.Text = "";
            // 
            // richTextBox12
            // 
            this.richTextBox12.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox12.Enabled = false;
            this.richTextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox12.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox12.Location = new System.Drawing.Point(897, 184);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(65, 35);
            this.richTextBox12.TabIndex = 46;
            this.richTextBox12.Text = "";
            // 
            // richTextBox11
            // 
            this.richTextBox11.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox11.Enabled = false;
            this.richTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox11.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox11.Location = new System.Drawing.Point(819, 184);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(65, 35);
            this.richTextBox11.TabIndex = 45;
            this.richTextBox11.Text = "";
            // 
            // richTextBox10
            // 
            this.richTextBox10.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox10.Enabled = false;
            this.richTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox10.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox10.Location = new System.Drawing.Point(739, 184);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(65, 35);
            this.richTextBox10.TabIndex = 44;
            this.richTextBox10.Text = "";
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox9.Enabled = false;
            this.richTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox9.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox9.Location = new System.Drawing.Point(659, 184);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(65, 35);
            this.richTextBox9.TabIndex = 43;
            this.richTextBox9.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 29);
            this.dateTimePicker1.TabIndex = 47;
            this.dateTimePicker1.Value = new System.DateTime(2018, 2, 24, 17, 9, 1, 728);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 47);
            this.label1.TabIndex = 48;
            this.label1.Text = "Artech Welders Private Limited";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(438, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 47);
            this.label2.TabIndex = 49;
            this.label2.Text = "Weld Parameters";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShutDown
            // 
            this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutDown.BackColor = System.Drawing.Color.OldLace;
            this.btnShutDown.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnShutDown.FlatAppearance.BorderSize = 2;
            this.btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnShutDown.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnShutDown.Location = new System.Drawing.Point(1192, 461);
            this.btnShutDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(152, 38);
            this.btnShutDown.TabIndex = 50;
            this.btnShutDown.Text = "Shutdown";
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.BackColor = System.Drawing.Color.OldLace;
            this.btnOpenLog.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnOpenLog.FlatAppearance.BorderSize = 2;
            this.btnOpenLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenLog.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnOpenLog.Location = new System.Drawing.Point(8, 45);
            this.btnOpenLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(148, 35);
            this.btnOpenLog.TabIndex = 51;
            this.btnOpenLog.Text = "Open Log";
            this.btnOpenLog.UseVisualStyleBackColor = false;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLogClick);
            // 
            // txtoption
            // 
            this.txtoption.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoption.FormattingEnabled = true;
            this.txtoption.Items.AddRange(new object[] {
            "1 kVA",
            "5 kVA",
            "7 kVA",
            "10 kVA",
            "15 kVA",
            "20 kVA",
            "30 kVA",
            "35 kVA"});
            this.txtoption.Location = new System.Drawing.Point(161, 94);
            this.txtoption.Name = "txtoption";
            this.txtoption.Size = new System.Drawing.Size(73, 26);
            this.txtoption.TabIndex = 52;
            this.txtoption.Text = "1 kVA";
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.OldLace;
            this.btnset.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnset.FlatAppearance.BorderSize = 2;
            this.btnset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnset.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnset.Location = new System.Drawing.Point(239, 87);
            this.btnset.Margin = new System.Windows.Forms.Padding(2);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(74, 37);
            this.btnset.TabIndex = 53;
            this.btnset.Text = "Set";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(17, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 18);
            this.label15.TabIndex = 57;
            this.label15.Text = "Machine Rating";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtoption);
            this.panel1.Controls.Add(this.btnset);
            this.panel1.Controls.Add(this.btnOpenLog);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnConfigure);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Location = new System.Drawing.Point(696, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 126);
            this.panel1.TabIndex = 60;
            // 
            // DataLogger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1355, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox12);
            this.Controls.Add(this.richTextBox11);
            this.Controls.Add(this.richTextBox10);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ltvLogData);
            this.Controls.Add(this.pboArtech);
            this.Controls.Add(this.lblName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DataLogger";
            this.Text = "DataLogger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pboArtech)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pboArtech;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader Index;
        public System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.RichTextBox richTextBox9;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        public System.Windows.Forms.Button btnShutDown;
        public System.Windows.Forms.Button btnOpenLog;
        public System.Windows.Forms.ListView ltvLogData;
        private System.Windows.Forms.ComboBox txtoption;
        public System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        int w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, w11, w12, w13, w14;
        public Button btnExport;
    }
}

