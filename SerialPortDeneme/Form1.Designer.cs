namespace SerialPortDeneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baglantiBtn = new System.Windows.Forms.Button();
            this.portList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boundRateList = new System.Windows.Forms.ComboBox();
            this.dataBitText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPortTimer = new System.Windows.Forms.Timer(this.components);
            this.seriPortDataYollaBtn = new System.Windows.Forms.Button();
            this.seriPortDataTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baglantiBtn
            // 
            this.baglantiBtn.Location = new System.Drawing.Point(12, 206);
            this.baglantiBtn.Name = "baglantiBtn";
            this.baglantiBtn.Size = new System.Drawing.Size(159, 23);
            this.baglantiBtn.TabIndex = 0;
            this.baglantiBtn.Text = "Bağlan";
            this.baglantiBtn.UseVisualStyleBackColor = true;
            this.baglantiBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // portList
            // 
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(12, 57);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(159, 23);
            this.portList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bound Rate:";
            // 
            // boundRateList
            // 
            this.boundRateList.FormattingEnabled = true;
            this.boundRateList.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.boundRateList.Location = new System.Drawing.Point(12, 101);
            this.boundRateList.Name = "boundRateList";
            this.boundRateList.Size = new System.Drawing.Size(159, 23);
            this.boundRateList.TabIndex = 5;
            // 
            // dataBitText
            // 
            this.dataBitText.Location = new System.Drawing.Point(12, 153);
            this.dataBitText.Name = "dataBitText";
            this.dataBitText.Size = new System.Drawing.Size(159, 23);
            this.dataBitText.TabIndex = 6;
            this.dataBitText.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bit";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 276);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(159, 251);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resonse:";
            // 
            // serialPortTimer
            // 
            this.serialPortTimer.Tick += new System.EventHandler(this.serialPortTimer_Tick);
            // 
            // seriPortDataYollaBtn
            // 
            this.seriPortDataYollaBtn.Enabled = false;
            this.seriPortDataYollaBtn.Location = new System.Drawing.Point(10, 590);
            this.seriPortDataYollaBtn.Name = "seriPortDataYollaBtn";
            this.seriPortDataYollaBtn.Size = new System.Drawing.Size(159, 23);
            this.seriPortDataYollaBtn.TabIndex = 10;
            this.seriPortDataYollaBtn.Text = "Yolla";
            this.seriPortDataYollaBtn.UseVisualStyleBackColor = true;
            this.seriPortDataYollaBtn.Click += new System.EventHandler(this.seriPortDataYollaBtn_Click);
            // 
            // seriPortDataTxt
            // 
            this.seriPortDataTxt.Enabled = false;
            this.seriPortDataTxt.Location = new System.Drawing.Point(10, 561);
            this.seriPortDataTxt.Name = "seriPortDataTxt";
            this.seriPortDataTxt.Size = new System.Drawing.Size(159, 23);
            this.seriPortDataTxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seri Port Dinle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(39, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seri Port Data Yaz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seriPortDataTxt);
            this.Controls.Add(this.seriPortDataYollaBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataBitText);
            this.Controls.Add(this.boundRateList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portList);
            this.Controls.Add(this.baglantiBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Seri Port ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button baglantiBtn;
        private ComboBox portList;
        private Label label1;
        private Label label2;
        private ComboBox boundRateList;
        private TextBox dataBitText;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label4;
        private System.Windows.Forms.Timer serialPortTimer;
        private Button seriPortDataYollaBtn;
        private TextBox seriPortDataTxt;
        private Label label5;
        private Label label6;
    }
}