using System;
using System.Windows.Forms;

namespace PaintWF
{
    public partial class PColor : UserControl
    {
        public PColor()
        {
            InitializeComponent();
        }

        public XData data = null;

        public void SetColor(object sender, EventArgs e)
        {
            if(dlgColor.ShowDialog() == DialogResult.OK)
            {
                data.color = dlgColor.Color;
            }
        }
    }
}
