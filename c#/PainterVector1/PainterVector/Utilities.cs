using System.Drawing;
using System.Windows.Forms;

namespace PainterVector
{
	class Utilities
	{
		public static void SetColor(ref Color color)
		{
			ColorDialog dlgColor = new ColorDialog();
			if (dlgColor.ShowDialog() == DialogResult.OK)
			{
				color = dlgColor.Color;
			}
		}
	}
}
