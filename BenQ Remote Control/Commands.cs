using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BenQ_Remote_Control
{
    public  class Command
    {
        string _displayText = string.Empty;
        string _commandText = string.Empty;

        public Command(string displayText, string commandText)
        {
            _displayText = displayText;
            _commandText = commandText;
        }
        public Command()
        {

        }

        public string DisplayText
        {
            get
            { return _displayText; }
            set
            { _displayText = value; }
        }

        public string CommandText
        {
            get { return _commandText; }
            set { _commandText = value; }
        }
        
    }

    public class Commands
    {

        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public Parity parity { get; set; }
        public int DataBits { get; set; }
        public StopBits stopBits { get; set; }
        public Handshake handshake { get; set; }




        public List<Command> CommandList;

        public static string CommandConfigFilePath = "CommandConfig.xml";

        public Commands()
        {
           
           
        }

       

        private void DefaultValues()
        {
            PortName = "COM1";
            BaudRate = 9600;
            parity = Parity.None;
            DataBits = 8;
            stopBits = StopBits.One;
            handshake = Handshake.None;
            CommandList = new List<Command>();

            for(int i=0;i<10;i++)
            {
                Command command = new Command("DisplayText" + i.ToString(), "CommandText" + i.ToString());
                CommandList.Add(command);
            }
        }

        private void WriteCommandConfiguration()
        {
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(Commands));
                StreamWriter sw = new StreamWriter(CommandConfigFilePath);
                x.Serialize(sw, this);
                sw.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Failed to Write Command Configuration \n" + ex.Message,
                    "Ephrathah Remote Controller",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }

        }


        public string GetCommand(string commandstr)
        {
           
            foreach(Command cmd in CommandList)
            {
                if(cmd.DisplayText.Equals(commandstr, StringComparison.OrdinalIgnoreCase))
                {
                    return cmd.CommandText;
                   
                }
            }

            return null;
        }

    }
}
