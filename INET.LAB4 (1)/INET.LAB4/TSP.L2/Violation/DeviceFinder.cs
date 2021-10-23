using INET.Lab4;
using System;
using System.IO.Ports;

namespace SOLID.OCP.Violation
{
    public class DeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            DeviceFactory deviceFactory = new DeviceFactory();
            Device device = deviceFactory.CreateDevice(model);
            Device device2 = deviceFactory.CreateDevice(model);
            return Find(device.Port);
        }

        private string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach(string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0 )
                    return name;
            }
            return null;
        }
    }
}
