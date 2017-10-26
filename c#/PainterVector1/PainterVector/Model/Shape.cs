using System;
using System.Drawing;

namespace PainterVector.Model
{
	class Shape : IFigure
	{
		public Point p;
		public Size size;
		public XData.FigureType type;
		public int lineWidth;
		public Color color;

		public string text;

		public Shape(int x, int y, XData xData)
		{
			p = new Point(x, y);
			size = new Size(1, 1);
			type = xData.type;
			lineWidth = xData.lineWidth;
			color = xData.color;
		}

		public void ProcessCreating(int x, int y)
		{
			if (x < p.X)
			{
				size.Width += p.X - x;
				p.X = x;
			}
			else
				size.Width += x - p.X;

			if (y < p.Y)
			{
				size.Height += p.Y - y;
				p.Y = y;
			}
			else
				size.Height += y - p.Y;
		}

		public void Move(int dx, int dy)
		{
			throw new NotImplementedException();
		}

		public void Resize(FigureResizePivot resizePivot, int dx, int dy)
		{
			throw new NotImplementedException();
		}
	}
}
