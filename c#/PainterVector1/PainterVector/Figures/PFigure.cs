using PainterVector.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PainterVector
{
	[TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<PFigure, UserControl>))]
	public abstract partial class PFigure : UserControl
	{
		private bool isMoving = false;
		private bool isResizing = false;
		private Point startPoint;
		private FigureResizePivot figureResizePivot;

		public PFigure(int x, int y)
		{
			InitializeComponent();
			Location = new Point(x, y);
		}

		public abstract void ProcessCreating(int x, int y);
		protected abstract void PFigure_Paint(object sender, PaintEventArgs e);
		protected abstract FigureResizePivot GetResizePoint(int x, int y);
		protected abstract new void Move(int dx, int dy);
		protected abstract new void Resize(Model.FigureResizePivot resizePivot, int dx, int dy);
		protected abstract XData GetData();

		private void PFigure_Enter(object sender, EventArgs e)
		{
			BorderStyle = BorderStyle.FixedSingle;
			(Parent as PDraw).xCommand.xData = GetData();
		}

		private void PFigure_Leave(object sender, EventArgs e)
		{
			BorderStyle = BorderStyle.None;
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

		private void PFigure_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Focus();
				figureResizePivot = GetResizePoint(e.X, e.Y);
				isMoving = (figureResizePivot == FigureResizePivot.none);
				isResizing = (figureResizePivot != FigureResizePivot.none);
				startPoint = new Point(e.X, e.Y);
			}
		}

		private void PFigure_MouseMove(object sender, MouseEventArgs e)
		{
			Cursor[] cursors = { Cursors.Default,
				Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE,
				Cursors.SizeNWSE, Cursors.SizeNS, Cursors.SizeNESW, Cursors.SizeWE
			};

			if (figureResizePivot == FigureResizePivot.none)
				Cursor.Current = cursors[(int)GetResizePoint(e.X, e.Y)];
			else
				Cursor.Current = cursors[(int)figureResizePivot];

			if (e.Button == MouseButtons.Left)
			{
				if (isMoving == true)
					Move(e.X - startPoint.X, e.Y - startPoint.Y);
				else if (isResizing == true)
					Resize(figureResizePivot, e.X, e.Y);
			}
		}

		private void PFigure_MouseUp(object sender, MouseEventArgs e)
		{
			isMoving = false;
			isResizing = false;
			figureResizePivot = FigureResizePivot.none;
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
}
