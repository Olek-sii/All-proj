using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PaintWF
{
	public partial class POpening : UserControl
	{
		public POpening()
		{
			InitializeComponent();
		}

		public List<PFigure> figures = null;

		private void bOpen_Click(object sender, EventArgs e)
		{
			if (dlgOpen.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(dlgOpen.FileName, FileMode.Open))
				{
					BinaryFormatter bformatter = new BinaryFormatter();
					figures.Clear();
					figures.AddRange((List<PFigure>)bformatter.Deserialize(stream));
					OnFiguresLoad();
				}


			}
		}

		public delegate void Delegate();
		public event Delegate OnFiguresLoad;
    }
}
