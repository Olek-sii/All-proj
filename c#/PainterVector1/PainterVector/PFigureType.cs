using System;
using System.Windows.Forms;

namespace PainterVector
{
	public partial class PFigureType : UserControl
	{
		public XCommand xCommand = null;

		public PFigureType()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBox1.SelectedItem.ToString())
			{
				case "Rect":
					xCommand.SetFigureType(XData.FigureType.Rectangle);
					break;
				case "Free":
					xCommand.SetFigureType(XData.FigureType.Free);
					break;
				case "Round":
					xCommand.SetFigureType(XData.FigureType.Round);
					break;
				case "Round Rect":
					xCommand.SetFigureType(XData.FigureType.RoundRectangle);
					break;
				case "Line":
					xCommand.SetFigureType(XData.FigureType.Line);
					break;
			}
		}
	}
}
