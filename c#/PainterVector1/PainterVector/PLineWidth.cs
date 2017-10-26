using System;
using System.Windows.Forms;

namespace PainterVector
{
	public partial class PLineWidth : UserControl
	{
		public XCommand xCommand = null;

		public PLineWidth()
		{
			InitializeComponent();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			xCommand.SetLineWidth((int)numericUpDown1.Value);
		}
	}
}
