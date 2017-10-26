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
    public partial class PWidth : UserControl
    {
        public PWidth()
        {
            InitializeComponent();
            comboWidth.Items.Add(1);
            comboWidth.Items.Add(5);
            comboWidth.Items.Add(10);
            comboWidth.Items.Add(15);
            comboWidth.Items.Add(20);
        }

        public XData data = null;

        private void SetWidth(object sender, EventArgs e)
        {
            data.width = Convert.ToInt32(comboWidth.Items[comboWidth.SelectedIndex]);
             
        }
    }
}
