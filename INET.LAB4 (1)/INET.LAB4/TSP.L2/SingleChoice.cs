using System;
using System.Collections.Generic;

namespace SOLID.OCP
{
    public enum BankTerminalModel
    {
        Brp,
        Dcp
    }

    public interface IBankTerminal
    {
    }

    public class BankTerminalFactory
    {
        private static IDictionary<BankTerminalModel, Type> _terminalMapping = new Dictionary<BankTerminalModel, Type>()
        {
            {BankTerminalModel.Brp, typeof(BrpTerminal) },
            {BankTerminalModel.Dcp, typeof(DcpTerminal) }
        };
        public static IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            return (IBankTerminal)Activator.CreateInstance(_terminalMapping[model]);
        }
    }

    public class BrpTerminal : IBankTerminal
    {
    }

    public class DcpTerminal : IBankTerminal
    {
    }
}