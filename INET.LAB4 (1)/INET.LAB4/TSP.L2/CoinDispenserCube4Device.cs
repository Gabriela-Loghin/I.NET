using System.IO.Ports;

namespace INET.Lab4
{
    class CoinDispenserCube4Device : Device
    {
        public override SerialPort Port { 
            get { return _serialPort; }
            init {
                _serialPort = new SerialPort();
                _serialPort.BaudRate = 9600;
                _serialPort.Parity = Parity.Space;
                _serialPort.Handshake = Handshake.None;
            }
        }
    }
}
