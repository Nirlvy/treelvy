using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Barcode;

namespace treelvy
{
    class getcode
    {
        public static void code(int id, string healthcolor, string gocolor)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            Image img = qrcode.Draw(id.ToString(), qrcode.GetDefaultMetrics(40));
            img.Save(@".\Picture\code\health.png");

            if (healthcolor == "绿")
            {
                Bitmap map = new Bitmap(@".\Picture\code\health.png");
                Bitmap newMap = ReplaceColor(map, map.Width, map.Height, 0, 0, 0, 4, 191, 100);
                newMap.Save(@".\Picture\code\hea1th1.png");   
                Bitmap newMap1 = ReplaceColor(map, map.Width, map.Height, 255, 255, 255, 64, 64, 64);
                newMap1.Save(@".\Picture\\code\\health2.png");
                newMap.Dispose();
                map.Dispose();
                newMap1.Dispose();
            }
            else if (healthcolor == "黄")
            {
                Bitmap map = new Bitmap(@".\Picture\code\health.png");
                Bitmap newMap = ReplaceColor(map, map.Width, map.Height, 0, 0, 0, 255, 255, 0);
                newMap.Save(@".\Picture\code\hea1th1.png");
                Bitmap newMap1 = ReplaceColor(map, map.Width, map.Height, 255, 255, 255, 64, 64, 64);
                newMap1.Save(@".\Picture\code\health2.png");
                newMap.Dispose();
                map.Dispose();
                newMap1.Dispose();
            }
            else
            {
                Bitmap map = new Bitmap(@".\Picture\code\health.png");
                Bitmap newMap = ReplaceColor(map, map.Width, map.Height, 0, 0, 0, 255, 0, 0);
                newMap.Save(@".\Picture\code\health1.png");   
                Bitmap newMap1 = ReplaceColor(map, map.Width, map.Height, 255, 255, 255, 64, 64, 64);
                newMap1.Save(@".\Picture\code\health2.png");
                newMap.Dispose();
                map.Dispose();
                newMap1.Dispose();
            }

            if (gocolor == "黄")
            {
                Bitmap map = new Bitmap(@".\Picture\code\go.png");
                Bitmap newMap = ReplaceColor(map, map.Width, map.Height, 43, 166, 103, 255, 255, 0);
                newMap.Save(@".\Picture\code\go1.png");
                map.Dispose();
                newMap.Dispose();
            }
            else if (gocolor == "红")
            {
                Bitmap map = new Bitmap(@".\Picture\code\go.png");
                Bitmap newMap = ReplaceColor(map, map.Width, map.Height, 43, 166, 103, 255, 0, 0);
                newMap.Save(@".\Picture\code\go1.png");
                map.Dispose();
                newMap.Dispose();
            }
            else
            {
                Bitmap map = new Bitmap(@".\Picture\code\go.png");
                Bitmap newMap = ReplaceColor(map, map.Width, map.Height, 255, 255, 255, 64, 64, 64);
                newMap.Save(@".\Picture\code\go1.png");
                map.Dispose();
                newMap.Dispose();
            }
        }

        public static Bitmap ReplaceColor(Bitmap bt, int w, int h, int R, int G, int B, int r, int g, int b)
        {
            Rectangle rect = new Rectangle(0, 0, w, h);
            BitmapData bmpdata = bt.LockBits(rect, ImageLockMode.ReadWrite, bt.PixelFormat);
            IntPtr ptr = bmpdata.Scan0;
            int bytes = Math.Abs(bmpdata.Stride) * bt.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            int len = rgbValues.Length;
            byte a = 10;
            byte R1 = (byte)R;
            byte G1 = (byte)G;
            byte B1 = (byte)B;
            byte r1 = (byte)r;
            byte g1 = (byte)g;
            byte b1 = (byte)b;
            for (int i = 0; i < len; i += 4)
            {
                if (Math.Abs(rgbValues[i] - B1) < a && Math.Abs(rgbValues[i + 1] - G1) < a && Math.Abs(rgbValues[i + 2] - R1) < a)
                {
                    rgbValues[i] = b1;
                    rgbValues[i + 1] = g1;
                    rgbValues[i + 2] = r1;
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bt.UnlockBits(bmpdata);
            return bt;
        }
    }
}
