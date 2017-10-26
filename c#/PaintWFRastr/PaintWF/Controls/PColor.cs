using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void SetColor(object sender, EventArgs e)
        {
            if(dlgColor.ShowDialog() == DialogResult.OK)
            {
                data.color = dlgColor.Color;
            }
        }
    }
}
