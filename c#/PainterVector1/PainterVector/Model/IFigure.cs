using System.Drawing;

namespace PainterVector.Model
{
	public enum FigureResizePivot
	{
		none,
		topLeft, top, topRight, right,
		bottomRight, bottom, bottomLeft, left
	};

	interface IFigure
	{
		void ProcessCreating(int x, int y);
		void Move(int dx, int dy);
		void Resize(FigureResizePivot resizePivot, int dx, int dy);
	}
}
