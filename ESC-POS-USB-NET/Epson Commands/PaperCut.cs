﻿using Deli_POS_USB_NET.Extensions;
using Deli_POS_USB_NET.Interfaces.Command;


namespace Deli_POS_USB_NET.EpsonCommands
{
    public class PaperCut : IPaperCut
    {
        public byte[] Full()
        {
            return new byte[] { 29, 'V'.ToByte(), 65, 0 };
        }

        public byte[] Partial()
        {
            return new byte[] { 29, 'V'.ToByte(), 65, 1 };
        }
    }
}

