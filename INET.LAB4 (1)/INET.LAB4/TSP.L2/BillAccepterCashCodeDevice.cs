using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INET.Lab4
{
    class BillAccepterCashCodeDevice : Device 
    {
        public override SerialPort Port
        {
            get { return _serialPort; }
            init
            {
                _serialPort = new SerialPort();
                _serialPort.BaudRate = 9600;
                _serialPort.Parity = Parity.Even;
                _serialPort.Handshake = Handshake.RequestToSend;
            }
        }
    }
}
