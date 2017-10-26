using System;
using System.Windows.Forms;

namespace PaintWF
{
    public partial class PFigureType : UserControl
    {
        public PFigureType()
        {
            InitializeComponent();
        }

        public XData data;

        private void ChooseMethod(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text.Equals("Free"))
                data.type = XData.FigureDrawing.Free;
            else if (bt.Text.Equals("Rectangle"))
                data.type = XData.FigureDrawing.Rectangle;
            else if (bt.Text.Equals("Round"))
                data.type = XData.FigureDrawing.Round;
            else if (bt.Text.Equals("R. Rect."))
                data.type = XData.FigureDrawing.RoundRectangle;
            else if (bt.Text.Equals("Line"))
                data.type = XData.FigureDrawing.Line;
        }
    }
}
