using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenQ_Remote_Control
{
    internal class SerialPortCommander
    {
         SerialPort _serialPort;


        public SerialPortCommander(string PortName, int BaudRate, Parity parity, int DataBits, StopBits stopBits, Handshake handshake)
        {
            _serialPort = new SerialPort();

            _serialPort.PortName = PortName;
            _serialPort.BaudRate = BaudRate;
            _serialPort.Parity = parity;
            _serialPort.DataBits = DataBits;
            _serialPort.StopBits = stopBits;
            _serialPort.Handshake = handshake;
            _serialPort.NewLine = "\r";
            _serialPort.Encoding = Encoding.UTF8;
            _serialPort.DtrEnable = true;
            _serialPort.ReceivedBytesThreshold = 1; 

            _serialPort.ReadTimeout = 2000;
            _serialPort.WriteTimeout = 2000;

            _serialPort.DataReceived += _serialPort_DataReceived;

        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(((SerialPort)sender).ReadExisting());
        }

        public void SendCommand(string Command)
        {
            try
            {
                _serialPort.Open();
                if (_serialPort.IsOpen)
                {
                    _serialPort.Write(Command);
                    _serialPort.Close();

                }
            }
            catch (Exception ex)
            {
               System.Windows.Forms.MessageBox.Show("Error in Running Command "+ Command+ "\n"+ex.Message);
               
            }
        }
        public void SendLineCommand(string Command)
        {
            try
            {
                _serialPort.Open();
                if (_serialPort.IsOpen)
                {
                    
                    _serialPort.WriteLine(Command);
                    _serialPort.Close();

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error in Running Command " + Command + "\n" + ex.Message);

            }
        }
    }
}
