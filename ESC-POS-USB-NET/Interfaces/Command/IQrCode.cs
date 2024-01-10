using Deli_POS_USB_NET.Enums;

namespace Deli_POS_USB_NET.Interfaces.Command
{
    internal interface IQrCode
    {
        byte[] Print(string qrData);
        byte[] Print(string qrData, QrCodeSize qrCodeSize);
    }
}

