using PainterVector.Figures;

namespace PainterVector
{
	public static class PFigureFactory
	{
		public static PFigure GetPFigure(XData xData, int x, int y)
		{
			PFigure result = null;

			switch (xData.type)
			{
				case XData.FigureType.Free:
					result = new PFreeFigure(x, y, xData);
					break;
				//case XData.FigureType.Line:
				//	break;
				default:
					result = new PShape(x, y, xData);
					break;
			}

			return result;
		}
	}
}
