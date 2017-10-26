using PainterVector.Model;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PainterVector.Figures
{
	public partial class PShape : PFigure
	{
		private Shape shape;
		private Point startPoint;

		public PShape(int x, int y, XData xData)
			: base(x, y)
		{
			startPoint = new Point(x, y);
			shape = new Shape(x, y, xData);
		}

		public override void ProcessCreating(int x, int y)
		{
			shape.ProcessCreating(x, y);
			if (x < startPoint.X)
			{
				Width = startPoint.X - x;
				Left = x;
			}
			else
				Width = x - startPoint.X;

			if (y < startPoint.Y)
			{
				Height = startPoint.Y - y;
				Top = y;
			}
			else
				Height = y - startPoint.Y;
		}

		protected override XData GetData()
		{
			XData xData = new XData();
			xData.color = shape.color;
			xData.lineWidth = shape.lineWidth;
			xData.type = shape.type;
			return xData;
		}

		protected override FigureResizePivot GetResizePoint(int x, int y)
		{
			FigureResizePivot result = FigureResizePivot.none;
			int padding = 10;

			if (x > Width - padding)
			{
				if (y < padding)
					result = FigureResizePivot.topRight;
				else if (y > Height - padding)
					result = FigureResizePivot.bottomRight;
				else
					result = FigureResizePivot.right;
			}
			else if (x < padding)
			{
				if (y < padding)
					result = FigureResizePivot.topLeft;
				else if (y > Height - padding)
					result = FigureResizePivot.bottomLeft;
				else
					result = FigureResizePivot.left;
			}
			else
			{
				if (y < padding)
					result = FigureResizePivot.top;
				else if (y > Height - padding)
					result = FigureResizePivot.bottom;
			}

			return result;
		}

		protected override void Move(int dx, int dy)
		{
			Left += dx;
			Top += dy;
		}

		protected override void PFigure_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(shape.color, shape.lineWidth);
			if (shape.type == XData.FigureType.Rectangle)
				g.DrawRectangle(pen, new Rectangle(0, 0, Width - 3, Height - 3));
			else if (shape.type == XData.FigureType.Round)
				g.DrawEllipse(pen, new Rectangle(0, 0, Width - 3, Height - 3));
			else if (shape.type == XData.FigureType.Line)
				g.DrawLine(pen, 0, 0, Width, Height);
			else if (shape.type == XData.FigureType.RoundRectangle)
			{
				GraphicsPath path = new GraphicsPath();
				Rectangle bounds = new Rectangle(0, 0, Width - 1, Height - 1);
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
				g.DrawPath(pen, path);
			}
		}

		protected override void Resize(FigureResizePivot resizePivot, int dx, int dy)
		{
			throw new System.NotImplementedException();
		}
	}
}
