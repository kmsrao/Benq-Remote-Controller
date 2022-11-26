using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BenQ_Remote_Control
{
    public partial class Form1 : Form
    {

        Commands _commands;

        SerialPortCommander serialPortCommander;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Commands commands = new Commands();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ReadCommandConfiguration();
            serialPortCommander = new SerialPortCommander(_commands.PortName,
                _commands.BaudRate,
                _commands.parity,
                _commands.DataBits,
                _commands.stopBits,
                _commands.handshake);
        }

        private void ReadCommandConfiguration()
        {
            try
            {

                XmlSerializer x = new XmlSerializer(typeof(Commands));
                StreamReader sr = new StreamReader(Commands.CommandConfigFilePath);
                _commands = (Commands)x.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to Read Command Configuration \n" + ex.Message,
                    "Ephrathah Remote Controller",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }

        }

        private void btn_Computer_Click(object sender, EventArgs e)
        {
            serialPortCommander.SendCommand(_commands.GetCommand(Constants.SetSourceToPC));
        }

        private void btn_hdmi1_Click(object sender, EventArgs e)
        {
            serialPortCommander.SendCommand(_commands.GetCommand(Constants.SetSourceToHDMI));
        }

        private void btn_HDMI2_Click(object sender, EventArgs e)
        {
            serialPortCommander.SendCommand(_commands.GetCommand(Constants.SetSourceToHDMI2));
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            serialPortCommander.SendCommand(textBox1.Text);
        }

        private void btn_SendwithEnter_Click(object sender, EventArgs e)
        {
            serialPortCommander.SendLineCommand(textBox1.Text);
        }
    }
}
