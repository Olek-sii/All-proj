using PaintWF.Api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintWF
{
    class PictureEmf : IPictureFormat
    {
        string name = "";
        public PictureEmf(string name)
        {
            this.name = name;
        }
        public Bitmap Load()
        {
            return new Bitmap(name);
        }

        public void Save(PictureBox pb)
        {
            Bitmap bm = new Bitmap(pb.Size.Width, pb.Size.Height);
            pb.DrawToBitmap(bm, new Rectangle(0, 0, pb.Size.Width, pb.Size.Height));
            bm.Save(name, ImageFormat.Emf);
        }
    }
}
