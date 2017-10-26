using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PaintWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XData data = new XData();
            pDraw1.data = data;
            pColor1.data = data;
            pWidth1.data = data;
            pFigure1.data = data;

			List<PFigure> pFigures = new List<PFigure>();

			pSaving1.figures = pFigures;
			pOpening1.figures = pFigures;
			pDraw1.pFigures = pFigures;

			pOpening1.OnFiguresLoad += pDraw1.Repaint;
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			pDraw1.Repaint();
		}

		private void pDraw1_MouseMove(object sender, MouseEventArgs e)
		{
			toolStripStatusLabel1.Text = e.X + ";" + e.Y;
			statusStrip1.Refresh();
		}

		private void toolStripButton1_Click(object sender, System.EventArgs e)
		{
			pColor1.SetColor(sender, e);
		}
	}
}
