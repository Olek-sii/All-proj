using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintWF
{
    public class XData
    {
        public enum FigureDrawing { Free, Rectangle, Round, RoundRectangle, Line};

        public Color color = Color.Black;
        public int width = 1;
        public FigureDrawing method = FigureDrawing.Free;
        public PictureBox pBox;
        public Image image;
    }
}
