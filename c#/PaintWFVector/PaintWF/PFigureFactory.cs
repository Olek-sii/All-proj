namespace PaintWF
{
	public static class PFigureFactory
	{
		public static PFigure GetPFigure(XData xData, int x, int y)
		{
			PFigure result = null;

			switch (xData.type)
			{
				case XData.FigureDrawing.Free:
					result = new PFreeFigure(xData.color, xData.width, x, y);
					break;
				//case XData.FigureDrawing.Line:
				//	break;
				default:
					result = new PShape(xData.type, xData.color, xData.width, x, y);
					break;
			}

			return result;
		}
	}
}
