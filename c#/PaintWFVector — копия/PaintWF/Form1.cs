using System.Collections.Generic;
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

			List<Figure> figures = new List<Figure>();
			pDraw1.Figures = figures;
			pSaving1.figures = figures;
			pOpening1.figures = figures;

			pOpening1.OnFiguresLoad += pDraw1.Repaint;
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			pDraw1.Repaint();
		}
	}
}
