using System.Drawing;

namespace Deli_POS_USB_NET.Interfaces.Command
{
    internal interface IImage
    {
        byte[] Print(Bitmap image);
    }
}
