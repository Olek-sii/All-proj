using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocalizationTest {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			Localization.OnLocalChange += Localization_OnLocalChange;
			Localization.Locale = "en";

			ToolStripMenuItem p = menuStrip1.Items[0] as ToolStripMenuItem;
			p.Text = "123";
			List<IPlugin> list = PluginManager.GetPlugins();
			foreach (var plugin in list)
			{
				p.DropDownItems.Add(plugin.GetMenuItem());
			}
		}

		private void Localization_OnLocalChange() {
			label1.Text = Localization.GetText("label1");
			button1.Text = Localization.GetText("btnEng");
			button2.Text = Localization.GetText("btnRus");
		}

		private void button1_Click(object sender, EventArgs e) {
			Localization.Locale = "en";
		}

		private void button2_Click(object sender, EventArgs e) {
			Localization.Locale = "ru";
		}
	}
}