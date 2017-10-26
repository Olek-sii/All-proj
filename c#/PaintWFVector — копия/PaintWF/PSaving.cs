using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace PaintWF
{
    public partial class PSaving : UserControl
    {
        public PSaving()
        {
            InitializeComponent();
        }

        public List<Figure> figures = null;

        private void bSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
				using (Stream stream = File.Open(dlgSave.FileName, FileMode.Create))
				{
					BinaryFormatter bformatter = new BinaryFormatter();
					bformatter.Serialize(stream, figures);
				}
            }
        }
    }
}
