using System;
using System.Windows.Forms;

namespace PainterVector
{
	public partial class PMenu : UserControl
	{
		public XCommand xCommand = null;

		public PMenu()
		{
			InitializeComponent();
		}	

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			xCommand.SetColor();
		}

		private void lineWidthToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			xCommand.SetLineWidth(Int32.Parse(lineWidthToolStripMenuItem.SelectedItem.ToString()));
		}
	}
}
