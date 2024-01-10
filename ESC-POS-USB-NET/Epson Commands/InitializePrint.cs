using Deli_POS_USB_NET.Extensions;
using Deli_POS_USB_NET.Interfaces.Command;

namespace Deli_POS_USB_NET.EpsonCommands
{
    public class InitializePrint : IInitializePrint
    {
        public byte[] Initialize()
        {
            return new byte[] { 27, '@'.ToByte() };
        }
    }
}

