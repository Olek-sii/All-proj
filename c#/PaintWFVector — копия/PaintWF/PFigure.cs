using System;
using System.Windows.Forms;

namespace PaintWF
{
    public partial class PFigure : UserControl
    {
        public PFigure()
        {
            InitializeComponent();
        }

        public XData data;

        private void ChooseMethod(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text.Equals("Free"))
                data.method = XData.FigureDrawing.Free;
            else if (bt.Text.Equals("Rectangle"))
                data.method = XData.FigureDrawing.Rectangle;
            else if (bt.Text.Equals("Round"))
                data.method = XData.FigureDrawing.Round;
            else if (bt.Text.Equals("R. Rect."))
                data.method = XData.FigureDrawing.RoundRectangle;
            else if (bt.Text.Equals("Line"))
                data.method = XData.FigureDrawing.Line;
        }
    }
}
