using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XData data = new XData();
            pDraw1.data = data;
            pColor1.data = data;
            pWidth1.data = data;
            pFigure1.data = data;
            pSaving1.data = data;
            pOpening1.data = data;
            pOpening1.OnPictureLoad += pDraw1.LoadPicture;
        }

    }
}
