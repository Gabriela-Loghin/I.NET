using System.IO.Ports;

namespace INET.Lab4
{
    public abstract class Device
    {
        public string testString = "hello";
        public SerialPort _serialPort;
        public virtual SerialPort Port { get; init; }
       
    }
}
