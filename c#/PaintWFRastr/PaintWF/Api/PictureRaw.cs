using ImageMagick;
using PaintWF.Api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintWF
{
    class PictureRaw : IPictureFormat
    {
        string name = "";
        public PictureRaw(string name)
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
            image.Format = MagickFormat.Raw;
            image.Write(name);
        }
    }
}
