using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PaintWF
{
	[TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<PFigure, UserControl>))]
	public abstract partial class PFigure : UserControl
	{
		protected enum FigureKeyPoint
		{
			none,
			topLeft, top, topRight, right,
			bottomRight, bottom, bottomLeft, left
		};

		public PFigure(Color color, int lineWidth, int x, int y)
		{
			Color = color;
			LineWidth = lineWidth;
			Location = new Point(x, y);
			InitializeComponent();
		}

		private bool isMoving = false;
		private bool isResizing = false;
		private Point startPoint;
		private FigureKeyPoint figureKeyPoint;


		protected Color Color;
		protected int LineWidth;

		protected abstract void PFigure_Paint(object sender, PaintEventArgs e);
		protected abstract FigureKeyPoint GetResizePoint(int x, int y);

		private void PFigure_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Focus();
				figureKeyPoint = GetResizePoint(e.X, e.Y);
				isMoving = (figureKeyPoint == FigureKeyPoint.none);
				isResizing = (figureKeyPoint != FigureKeyPoint.none);
				startPoint = new Point(e.X, e.Y);
			}
			else if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(this, new Point(e.X, e.Y));
			}
		}

		private void PFigure_MouseMove(object sender, MouseEventArgs e)
		{
			

			Cursor[] cursors = { Cursors.Default,
				Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE,
				Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE
			};

			if (figureKeyPoint == FigureKeyPoint.none)
				Cursor.Current = cursors[(int)GetResizePoint(e.X, e.Y)];
			else
				Cursor.Current = cursors[(int)figureKeyPoint];

			if (e.Button == MouseButtons.Left)
			{
				if (isMoving == true)
					Move(e.X - startPoint.X, e.Y - startPoint.Y);
				else if (isResizing == true)
					Resize(figureKeyPoint, e.X, e.Y);
			}
		}

		private void PFigure_MouseUp(object sender, MouseEventArgs e)
		{
			isMoving = false;
			isResizing = false;
			figureKeyPoint = FigureKeyPoint.none;
		}

		private void SetColor_Click(object sender, EventArgs e)
		{
			ColorDialog dlgColor  = new ColorDialog();
			if (dlgColor.ShowDialog() == DialogResult.OK)
			{
				Color = dlgColor.Color;
				Invalidate();
			}
		}

		private void PFigure_MouseEnter(object sender, EventArgs e)
		{
			BorderStyle = BorderStyle.FixedSingle;
		}

		private void PFigure_MouseLeave(object sender, EventArgs e)
		{
			if (Focused == false)
				BorderStyle = BorderStyle.None;
		}

		private void PFigure_Enter(object sender, EventArgs e)
		{
			BorderStyle = BorderStyle.FixedSingle;
		}

		private void PFigure_Leave(object sender, EventArgs e)
		{
			BorderStyle = BorderStyle.None;
		}

		private new void Move(int dx, int dy)
		{
			Left += dx;
			Top += dy;
		}

		private new void Resize(FigureKeyPoint resizePoint, int dx, int dy)
		{
			if (figureKeyPoint == FigureKeyPoint.right)
			{
				Width = dx;
			}
			else if (figureKeyPoint == FigureKeyPoint.left)
			{
				Width -= dx;
				Left += dx;
			}
			else if (figureKeyPoint == FigureKeyPoint.topLeft)
			{
				Width -= dx;
				Left += dx;
				Height -= dy;
				Top += dy;
			}
			Invalidate();
		}

		private void PFigure_KeyDown(object sender, KeyEventArgs e)
		{
			if (Focused == true)
			{
				switch (e.KeyCode)
				{
					case Keys.Left:
						Move(-1, 0);
						break;
					case Keys.Right:
						Move(1, 0);
						break;
					case Keys.Up:
						Move(0, -1);
						break;
					case Keys.Down:
						Move(0, 1);
						break;

					default:
						break;
				}
			}
		}

		protected override bool IsInputKey(Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Right:
				case Keys.Left:
				case Keys.Up:
				case Keys.Down:
				case Keys.Shift | Keys.Right:
				case Keys.Shift | Keys.Left:
				case Keys.Shift | Keys.Up:
				case Keys.Shift | Keys.Down:
				case Keys.Control | Keys.Right:
				case Keys.Control | Keys.Left:
				case Keys.Control | Keys.Up:
				case Keys.Control | Keys.Down:
					return true;
			}
			return base.IsInputKey(keyData);
		}
	}

	public class AbstractControlDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
	{
		public AbstractControlDescriptionProvider()
			: base(TypeDescriptor.GetProvider(typeof(TAbstract)))
		{
		}

		public override Type GetReflectionType(Type objectType, object instance)
		{
			if (objectType == typeof(TAbstract))
				return typeof(TBase);

			return base.GetReflectionType(objectType, instance);
		}

		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			if (objectType == typeof(TAbstract))
				objectType = typeof(TBase);

			return base.CreateInstance(provider, objectType, argTypes, args);
		}
	}

	public partial class PFreeFigure : PFigure
	{
		public PFreeFigure(Color color, int lineWidth, int x, int y)
			: base(color, lineWidth, x, y)
		{

		}

		public List<Point> points = new List<Point>();

		public void AddPoint(int x, int y)
		{
			if (x < Left)
			{
				for(int i = 0; i < points.Count; i++)
				{
					points[i] = new Point(points[i].X + Left - x, points[i].Y);
				}

				Width += Left - x;
				Left = x;
			}

			if (y < Top)
			{
				for (int i = 0; i < points.Count; i++)
				{
					points[i] = new Point(points[i].X, points[i].Y + Top - y);
				}

				Height += Top - y;
				Top = y;
			}

			if (x >= Right)
				Width = x + 1 - Left;
			if (y >= Bottom)
				Height = y + 1 - Top;

			points.Add(new Point(x - Left, y - Top));

			Invalidate();
		}

		protected override FigureKeyPoint GetResizePoint(int x, int y)
		{
			return FigureKeyPoint.none;
		}

		protected override void PFigure_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(Color, LineWidth);
			if (points.Count > 1)
				g.DrawLines(pen, points.ToArray());
		}
	}

	public partial class PShape : PFigure
	{
		private XData.FigureDrawing type;

		public PShape(XData.FigureDrawing type, Color color, int lineWidth, int x, int y)
			: base(color, lineWidth, x, y)
		{
			this.type = type;
		}

		protected override FigureKeyPoint GetResizePoint(int x, int y)
		{
			FigureKeyPoint result = FigureKeyPoint.none;
			int padding = 10;

			if (x > Width - padding)
			{
				if (y < padding)
					result = FigureKeyPoint.topRight;
				else if (y > Height - padding)
					result = FigureKeyPoint.bottomRight;
				else
					result = FigureKeyPoint.right;
			}
			else if (x < padding)
			{
				if (y < padding)
					result = FigureKeyPoint.topLeft;
				else if (y > Height - padding)
					result = FigureKeyPoint.bottomLeft;
				else
					result = FigureKeyPoint.left;
			}
			else
			{
				if (y < padding)
					result = FigureKeyPoint.top;
				else if (y > Height - padding)
					result = FigureKeyPoint.bottom;
			}

			return result;
		}

		protected override void PFigure_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = CreateGraphics();
			g.Clear(Color.White);
			Pen pen = new Pen(Color, LineWidth);
			if (type == XData.FigureDrawing.Rectangle)
				g.DrawRectangle(pen, new Rectangle(0, 0, Width - 1, Height - 1));
			else if (type == XData.FigureDrawing.Round)
				g.DrawEllipse(pen, new Rectangle(0, 0, Width - 2, Height - 2));
			else if (type == XData.FigureDrawing.Line)
				g.DrawLine(pen, 0, 0, Width, Height);
			else if (type == XData.FigureDrawing.RoundRectangle)
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
	}
}
