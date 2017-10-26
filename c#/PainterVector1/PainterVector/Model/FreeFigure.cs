using System;
using System.Collections.Generic;
using System.Drawing;

namespace PainterVector.Model
{
	class FreeFigure : IFigure
	{
		public Point p;
		public int lineWidth;
		public Color color;

		public string text;

		public List<Point> points = new List<Point>();

		public FreeFigure(int x, int y, XData xData)
		{
			p = new Point(x, y);
			lineWidth = xData.lineWidth;
			color = xData.color;
		}


		public void ProcessCreating(int x, int y)
		{
			points.Add(new Point(x, y));
		}

		public void Move(int dx, int dy)
		{
			p.X += dx;
			p.Y += dy;
		}

		public void Resize(FigureResizePivot resizePivot, int dx, int dy)
		{
			throw new NotImplementedException();
		}
	}
}
