using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PaintWF
{
    public partial class PDraw : UserControl
    {
        public PDraw()
        {
            InitializeComponent();
            pBox.Image = new Bitmap(pBox.Width, pBox.Height);
        }

		public List<Figure> Figures { get; set; }
        public XData data = null;
		private Figure currentFigure = null;

		private void OnMouseDown(object sender, MouseEventArgs e)
		{
			if (data.method == XData.FigureDrawing.Free)
			{
				currentFigure = new FreeFigure(data.color, data.width, e.X, e.Y);
			}
			else
			{
				currentFigure = new Figure(data.method, data.color, data.width, e.X, e.Y);
			}
		}

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left && data.method == XData.FigureDrawing.Free)
			{
				FreeFigure ff = currentFigure as FreeFigure;
				ff.points.Add(new Point(e.X, e.Y));
				DrawFigure(ff);
			}
		}


        private void OnMouseUp(object sender, MouseEventArgs e)
        {
			currentFigure.x2 = e.X;
			currentFigure.y2 = e.Y;
            DrawFigure(currentFigure);
			Figures.Add(currentFigure);
			currentFigure = null;
        }
      
        public void Repaint()
        {
            Graphics graph = Graphics.FromImage(pBox.Image);
			graph.Clear(Color.White);
			foreach (Figure figure in Figures)
			{
				DrawFigure(figure);
			}
        }

		private void DrawFigure(Figure figure)
		{
			if (figure.x2 < figure.x1 && 
				(figure.type != XData.FigureDrawing.Line && figure.type != XData.FigureDrawing.Free))
			{
				int temp = figure.x1;
				figure.x1 = figure.x2;
				figure.x2 = temp;
			}
			if (figure.y2 < figure.y1 &&
				(figure.type != XData.FigureDrawing.Line && figure.type != XData.FigureDrawing.Free))
			{
				int temp = figure.y1;
				figure.y1 = figure.y2;
				figure.y2 = temp;
			}

			Graphics graph = Graphics.FromImage(pBox.Image);
			Pen pen = new Pen(figure.color, figure.lineW);
			int width = Math.Abs(figure.x1 - figure.x2);
			int height = Math.Abs(figure.y1 - figure.y2);
			if (figure.type == XData.FigureDrawing.Rectangle)
				graph.DrawRectangle(pen, new Rectangle(figure.x1, figure.y1, width, height));
			else if (figure.type == XData.FigureDrawing.Round)
				graph.DrawEllipse(pen, new Rectangle(figure.x1, figure.y1, width, height));
			else if (figure.type == XData.FigureDrawing.Line)
				graph.DrawLine(pen, figure.x1, figure.y1, figure.x2, figure.y2);
			else if (figure.type == XData.FigureDrawing.Free)
				graph.DrawLines(pen, (figure as FreeFigure).points.ToArray());
			else if (figure.type == XData.FigureDrawing.RoundRectangle)
			{
				GraphicsPath path = new GraphicsPath();
				Rectangle bounds = new Rectangle(figure.x1, figure.y1, width, height);
				Size size = new Size(20, 20);
				Rectangle arc = new Rectangle(bounds.Location, size);
				path.AddArc(arc, 180, 90);
				arc.X = bounds.Right - 20;
				path.AddArc(arc, 270, 90);
				arc.Y = bounds.Bottom - 20;
				path.AddArc(arc, 0, 90);
				arc.X = bounds.Left;
				path.AddArc(arc, 90, 90);
				arc.Y = bounds.Top;
				path.CloseFigure();
				graph.DrawPath(pen, path);
			}
			
			pBox.Invalidate();
		}
	}
}
