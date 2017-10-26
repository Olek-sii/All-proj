namespace PainterVector
{
	public class XCommand
	{
		public XData xData = new XData();

		public void SetXData(XData xData)
		{
			this.xData = xData;
		}

		public void SetColor()
		{
			Utilities.SetColor(ref xData.color);
		}

		public void SetLineWidth(int lineWidth)
		{
			xData.lineWidth = lineWidth;
		}

		public void SetFigureType(XData.FigureType figureType)
		{
			xData.type = figureType;
		}
	}
}
