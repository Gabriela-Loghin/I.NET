using System;
using INET.Lab4;

namespace Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviceFactory deviceFactory = new DeviceFactory();
            Device device1 = deviceFactory.CreateDevice(SOLID.OCP.DeviceModel.CoinDispenserCube4);
            Device device2 = deviceFactory.CreateDevice(SOLID.OCP.DeviceModel.CoinDispenserCube4);
            Console.WriteLine(device1.testString);
            Console.WriteLine(device2.testString);
            device1.testString = "not hello";
            Console.WriteLine(device2.testString);
        }
    }
}
