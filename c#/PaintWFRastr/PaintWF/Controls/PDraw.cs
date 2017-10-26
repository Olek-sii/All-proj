using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PaintWF
{
    public partial class PDraw : UserControl
    {
        public PDraw()
        {
            InitializeComponent();
            pBox.Image = new Bitmap(pBox.Width, pBox.Height);
            SelfRef = this;
        }


        public static PDraw SelfRef
        {
            get; set;
        }

        public PictureBox getPictureBox()
        {
            return this.pBox;
        }

        int x = 0;
        int y = 0;
        public XData data = null;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;           
        }

        public void LoadPicture()
        {
            pBox.Image = data.image;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && data.method == XData.FigureDrawing.Free)
            {
                DrawFigure(data.method, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            DrawFigure(data.method, x, y, e.X, e.Y);
        }

        
        private void DrawFigure(XData.FigureDrawing type, int x1, int y1, int x2, int y2)
        {          
            Graphics graphic = Graphics.FromImage(pBox.Image);

            int startX = x1;
            int startY = y1;
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);

            if (x2 < startX)
                startX = x2;
            if (y2 < startY)
                startY = y2;

            Pen pen = new Pen(data.color, data.width);

            if (type == XData.FigureDrawing.Rectangle)
                graphic.DrawRectangle(pen, startX, startY, width, height);
            else if (type == XData.FigureDrawing.Round)
                graphic.DrawEllipse(pen, startX, startY, width, height);
            else if (type == XData.FigureDrawing.Line || type == XData.FigureDrawing.Free)
                graphic.DrawLine(pen, x1, y1, x2, y2);
            else if (type == XData.FigureDrawing.RoundRectangle)
                graphic.DrawPath(pen, RoundRectangle(startX, startY, width, height, 30));

            data.image = pBox.Image;
            pBox.Invalidate();          
        }

        private GraphicsPath RoundRectangle(int x, int y, int width, int height, int diameter)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle bounds = new Rectangle(x, y, width, height);
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = bounds.Top;
            path.CloseFigure();
            return path;
        }
    }
}
