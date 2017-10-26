using System.Collections.Generic;
using System.Windows.Forms;

namespace PainterVector
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			List<PFigure> pFigures = new List<PFigure>();
			XCommand xCommand = new XCommand();
			pDraw1.xCommand = xCommand;
			pDraw1.pFigures = pFigures;

			menu1.xCommand = xCommand;
			pLineWidth1.xCommand = xCommand;
			pFigureType1.xCommand = xCommand;
		}
	}
}
