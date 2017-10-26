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
        }

		public List<PFigure> pFigures = null;
        public XData data = null;
		private PFigure newFigure = null;
		private Point startPoint;
      
        public void Repaint()
        {
			CreateGraphics().Clear(Color.White);
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
			newFigure = PFigureFactory.GetPFigure(data, e.X, e.Y);
			Controls.Add(newFigure);
			newFigure.BringToFront();
		}

		private void PDraw_MouseMove(object sender, MouseEventArgs e)
		{
			if (newFigure != null)
			{
				if (data.type == XData.FigureDrawing.Free)
					(newFigure as PFreeFigure).AddPoint(e.X, e.Y);
				else
				{
					if (e.X < startPoint.X)
					{
						newFigure.Width = startPoint.X - e.X;
						newFigure.Left = e.X;
					}
					else
						newFigure.Width = e.X - startPoint.X;

					if (e.Y < startPoint.Y)
					{
						newFigure.Height = startPoint.Y - e.Y;
						newFigure.Top = e.Y;
					}
					else
						newFigure.Height = e.Y - startPoint.Y;
				}
			}
		}

		private void PDraw_MouseUp(object sender, MouseEventArgs e)
		{
			pFigures.Add(newFigure);
			newFigure = null;
		}
	}
}
