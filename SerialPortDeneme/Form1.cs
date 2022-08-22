using System.IO.Ports;

namespace SerialPortDeneme
{

    public partial class Form1 :  Form
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
                    this._serialPort.DataBits = this.dataBits;

                    //sabit deðerler
                    this._serialPort.Parity = Parity.None;
                    this._serialPort.StopBits = StopBits.One;
                    this._serialPort.DtrEnable = true;
                    this._serialPort.RtsEnable = true;







                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);


                    kontrolleri_kapat_ac(true);
                      


                }
                else
                {
                    kontrolleri_kapat_ac(false);

                }


            }
            catch (Exception ex)
            {
                kontrolleri_kapat_ac(false);
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
               
                    richTextBox1.Text += sp.ReadLine(); }

            }
            catch (Exception ex)
            {

                kontrolleri_kapat_ac(false);


            }

        }


        private void seriPortDataYollaBtn_Click(object sender, EventArgs e)
        {

            String data = seriPortDataTxt.Text.ToString();

            _serialPort.WriteLine(data);

            seriPortDataTxt.Text = "";

        }


        public void kontrolleri_kapat_ac(bool durum)
        {

            if (durum && !_serialPort.IsOpen)
            {
                _serialPort.Open();
                baglantiBtn.Text = "Baðlantýyý Kapat";

                serial_port_acik_mi = true;

                seriPortDataYollaBtn.Enabled = true;
                seriPortDataTxt.Enabled = true;

            }
            else if (durum == false && _serialPort.IsOpen)
            {
                _serialPort.Close();

                baglantiBtn.Text = "Baðlan";

                serial_port_acik_mi = false;

                seriPortDataYollaBtn.Enabled = false;
                seriPortDataTxt.Enabled = false;


            }
             

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}