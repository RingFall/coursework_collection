using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Puzzle
{
    class CutPicture
    {
        public static string PicturePath = "";
        public static List<Bitmap> BitMapList = null;
        public static Image Resize(string path, int iWidth, int iHeight)
        {
            Image thumbnail = null;
            try
            {
                var img = Image.FromFile(path);
                thumbnail = img.GetThumbnailImage(iWidth, iHeight, null, IntPtr.Zero);
                thumbnail.Save(Application.StartupPath.ToString() + "\\Picture\\img.jpeg");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return thumbnail;
        }
        public static Bitmap Cut(Image b, int StartX, int StartY, int iWidth, int iHeight)
        {
            if (b == null)
            {
                return null;
            }
            int w = b.Width;
            int h = b.Height;
            if (StartX >= w || StartY >= h)
            {
                return null;
            }
            if (StartX + iWidth > w)
            {
                iWidth = w - StartX;
            }
            if (StartY + iHeight > h)
            {
                iHeight = h - StartY;
            }
            try
            {
                Bitmap bmpOut = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(b, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight), GraphicsUnit.Pixel);
                g.Dispose();
                return bmpOut;
            }
            catch
            {
                return null;
            }
        }
    }
}
