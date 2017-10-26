class Figure {
	constructor(x,y,w,h,color,lineWidth,type) {
		this.x = x;
		this.y = y;
		this.w = w;
		this.h = h;

		this.color = color;
		this.lineWidth = lineWidth;
		this.type = type;
	}

	get getFigure() {
		return this;
	}
}