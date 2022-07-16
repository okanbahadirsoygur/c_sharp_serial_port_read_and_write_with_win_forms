using System.IO.Ports;

namespace SerialPortDeneme
{

    public partial class Form1 : Form
    {
        public int boundRate;
        public String portName;
        public int dataBits;
        public SerialPort _serialPort;

        bool serial_port_acik_mi = false;


        public Form1()
        {
            InitializeComponent();
        }
         
       

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            foreach(var i in SerialPort.GetPortNames())
            {
                labelTxt.Text += i+"\n";
            }
          */

            // form elementlerindeki ayarlarýn deðiþkenlere aktarýmý
     
            this.boundRate = Convert.ToInt32(boundRateList.GetItemText(boundRateList.SelectedItem));
            this.portName = portList.GetItemText(portList.SelectedItem);
            this.dataBits = Convert.ToInt32(dataBitText.Text);
         



            try
            {
                if (serial_port_acik_mi == false)
                {
                    _serialPort = new SerialPort("" + this.portName);
                  

                    // serial port ayarlarý
                    //port ayarlarý port açýk iken deðiþtirilemez!
                    this._serialPort.PortName = this.portName;
                    this._serialPort.BaudRate = this.boundRate;
                    this._serialPort.Parity = Parity.Even;
                    this._serialPort.StopBits = StopBits.One;
                    this._serialPort.DataBits = this.dataBits;
                    this._serialPort.Handshake = Handshake.None;
                    this._serialPort.RtsEnable = true;
                    this._serialPort.ReadTimeout = 500;
                    this._serialPort.WriteTimeout = 500;
                    this._serialPort.DtrEnable = true;
                    this._serialPort.RtsEnable = true;


                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
                    _serialPort.Open();
                   

                
                    baglantiBtn.Text = "Baðlantýyý Kapat";
                    serialPortTimer.Enabled = true;
                    serial_port_acik_mi = true;

                    seriPortDataYollaBtn.Enabled = true;
                    seriPortDataTxt.Enabled = true;
                    label6.Enabled = true;

                }
                else
                {
                    _serialPort.Close();
                    baglantiBtn.Text = "Baðlan";
                    serialPortTimer.Enabled = false;
                    serial_port_acik_mi = false;

                    seriPortDataYollaBtn.Enabled = false;
                    seriPortDataTxt.Enabled = false;
                    label6.Enabled = false;
                }
                 

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
    
            //baþlangýçta default kapalý olsun
            serial_port_acik_mi = false;

            //form yüklenince bilgisayara baðlý portlarý listeleyelim
            foreach (var i in SerialPort.GetPortNames())
            {
                portList.Items.Add(i);
            }
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

    
            try
            {

                if (serial_port_acik_mi == true)
                {
                    SerialPort sp = (SerialPort)sender;
                    richTextBox1.Text += sp.ReadExisting();
                }

            }
            catch (Exception ex)
            {
                richTextBox1.Text += "\n" + ex;
            }

        }
 
 

        private void seriPortDataYollaBtn_Click(object sender, EventArgs e)
        {
          
                String data = seriPortDataTxt.ToString();

                _serialPort.WriteLine(data);

                seriPortDataTxt.Text = "";
           
        }

        public void serialPortDataRecivedEvent(object sender, EventArgs e)
        {

        }

        private void serialPortTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                if (serial_port_acik_mi == true)
                {

                    richTextBox1.Text += _serialPort.ReadExisting().ToString();
          
                }

            }
            catch (Exception ex)
            {

                richTextBox1.Text += "\n" + ex;
                serialPortTimer.Enabled = false;
            }

        }
    }
}