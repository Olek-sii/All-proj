using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;

namespace PaintWF
{
	[Serializable()]
    public class Figure : ISerializable
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public Color color;
        public int lineW;
        public XData.FigureDrawing type;

        public Figure(XData.FigureDrawing type, Color color, int lineW, int x1, int y1)
        {
            this.x1 = x1;
			this.x2 = 0;
            this.y1 = y1;
			this.y2 = 0;
            this.type = type;
            this.color = color;
            this.lineW = lineW;
        }

		public Figure(SerializationInfo info, StreamingContext context)
		{
			x1 = info.GetInt32("x1");
			x2 = info.GetInt32("x2");
			y1 = info.GetInt32("y1");
			y2 = info.GetInt32("y2");

			type = (XData.FigureDrawing)info.GetValue("type", typeof(XData.FigureDrawing));
			color = (Color)info.GetValue("color", typeof(Color));
			lineW = info.GetInt32("lineW");
		}

		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("x1", x1);
			info.AddValue("x2", x2);
			info.AddValue("y1", y1);
			info.AddValue("y2", y2);
			info.AddValue("type", type);
			info.AddValue("color", color);
			info.AddValue("lineW", lineW);
		}
    }

	[Serializable()]
	class FreeFigure : Figure
	{
		public List<Point> points = new List<Point>();

		public FreeFigure(Color color, int lineW, int x1, int y1)
			: base(XData.FigureDrawing.Free, color, lineW, x1, y1)
		{
			points.Add(new Point(x1, y1));
		}

		public FreeFigure(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			points = new List<Point>((Point[])info.GetValue("points", typeof(Point[])));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);

			info.AddValue("points", points.ToArray());
		}
	}
}
