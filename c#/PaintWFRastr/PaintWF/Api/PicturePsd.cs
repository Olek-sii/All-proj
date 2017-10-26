
using ImageMagick;
using PaintWF.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintWF
{
    class PicturePsd : IPictureFormat
    {
        string name = "";
        public PicturePsd(string name)
        {
            this.name = name;
        }
        public Bitmap Load()
        {
            using (MagickImage image = new MagickImage(name))
            {
                return image.ToBitmap();
            }
        }

        public void Save(PictureBox pb)
        {
            Bitmap bm = new Bitmap(pb.Size.Width, pb.Size.Height);
            pb.DrawToBitmap(bm, new Rectangle(0, 0, pb.Size.Width, pb.Size.Height));
            MagickImage image = new MagickImage(bm);
            image.Format = MagickFormat.Psd;
            image.Write(name);
        }
    }
}
