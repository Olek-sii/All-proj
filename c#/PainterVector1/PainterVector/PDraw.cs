using PainterVector.Figures;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PainterVector
{
	public partial class PDraw : UserControl
	{
		public PDraw()
		{
			InitializeComponent();
		}

		public List<PFigure> pFigures = null;
		public XCommand xCommand = null;
		public XData currentContext = null;
		private PFigure newFigure = null;
		private Point startPoint;

		public void Repaint()
		{
			CreateGraphics().Clear(Color.White);
			Controls.Clear();
			foreach (PFigure figure in pFigures)
			{
				Controls.Add(figure);
				figure.BringToFront();
			}
		}

		private void PDraw_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(Color.White);
		}

		private void PDraw_MouseDown(object sender, MouseEventArgs e)
		{
			startPoint = new Point(e.X, e.Y);
			newFigure = PFigureFactory.GetPFigure(xCommand.xData, e.X, e.Y);
			Controls.Add(newFigure);
			newFigure.BringToFront();
		}

		private void PDraw_MouseMove(object sender, MouseEventArgs e)
		{
			if (newFigure != null)
			{
				newFigure.ProcessCreating(e.X, e.Y);
			}
		}

		private void PDraw_MouseUp(object sender, MouseEventArgs e)
		{
			pFigures.Add(newFigure);
			newFigure = null;
		}
	}
}
