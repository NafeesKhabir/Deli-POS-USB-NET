﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Deli_POS_USB_NET.Interfaces.Command
{
    interface ILineHeight
    {
        byte[] Normal();
        byte[] SetLineHeight(byte height);
    }
}
