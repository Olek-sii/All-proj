using System.Windows.Forms;

namespace LocalizationTest
{
	interface IPlugin
	{
		ToolStripMenuItem GetMenuItem();
	}

	class FirstPlugin : IPlugin
	{
		private string _text;

		public FirstPlugin(string s)
		{
			_text = s;
		}

		public ToolStripMenuItem GetMenuItem()
		{
			return new ToolStripMenuItem(_text);
		}
	}
}