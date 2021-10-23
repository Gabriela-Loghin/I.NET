using SOLID.OCP;
using System;
using System.Collections.Generic;

namespace INET.Lab4
{
    public class DeviceFactory
    {
        private IDictionary<DeviceModel, Type> _deviceMapping;
        public Device CreateDevice(DeviceModel model)
        {
            return (Device)Activator.CreateInstance(_deviceMapping[model]);
        }

        public DeviceFactory()
        {
            _deviceMapping = new Dictionary<DeviceModel, Type>();
            _deviceMapping.Add(DeviceModel.CoinDispenserCube4, typeof(CoinDispenserCube4Device));
            _deviceMapping.Add(DeviceModel.CoinDispenserSch2, typeof(CoinDispenserSch2Device));
            _deviceMapping.Add(DeviceModel.CoinAccepterNri, typeof(CoinAccepterNriDevice));
            _deviceMapping.Add(DeviceModel.BillAccepterCashCode, typeof(BillAccepterCashCodeDevice));
            _deviceMapping.Add(DeviceModel.BillDispenserEcdm, typeof(BillDispenserEcdmDevice));
        }

    }
}
