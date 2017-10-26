using System.Drawing;

namespace PaintWF
{
    public class XData
    {
        public enum FigureDrawing { Free, Rectangle, Round, RoundRectangle, Line};

        public Color color = Color.Black;
        public int width = 1;
        public FigureDrawing type = FigureDrawing.Free;
    }
}
