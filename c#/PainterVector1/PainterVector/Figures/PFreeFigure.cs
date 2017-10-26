using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PainterVector.Model;

namespace PainterVector.Figures
{
	public partial class PFreeFigure : PFigure
	{
		private FreeFigure figure;
		private List<Point> points = new List<Point>();

		public PFreeFigure(int x, int y, XData xData)
			: base(x, y)
		{
			figure = new FreeFigure(x, y, xData);
		}


		protected override FigureResizePivot GetResizePoint(int x, int y)
		{
			return FigureResizePivot.none;
		}

		protected override void PFigure_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(figure.color, figure.lineWidth);
			if (points.Count > 1)
				g.DrawLines(pen, figure.points.ToArray());
		}

		public override void ProcessCreating(int x, int y)
		{
			figure.ProcessCreating(x, y);
			points.Add(new Point(x - Left, y - Top));

			if (x < Left)
			{
				Width += Left - x;
				Left = x;
			}

			if (y < Top)
			{
				Height += Top - y;
				Top = y;
			}

			if (x >= Right)
				Width = x + 1 - Left;
			if (y >= Bottom)
				Height = y + 1 - Top;

			Invalidate();
		}

		protected override void Move(int dx, int dy)
		{
			figure.Move(dx, dy);
			Left += dx;
			Top += dy;
		}

		protected override void Resize(Model.FigureResizePivot resizePivot, int dx, int dy)
		{
			figure.Resize(resizePivot, dx, dy);
		}

		protected override XData GetData()
		{
			throw new System.NotImplementedException();
		}
	}
}
