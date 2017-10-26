class XCommand {
	constructor(tabs) {
		this.pDraw = null;
	}

	get getArr() {
		return this.tabs;
	}

	setActivePDraw(pDraw) {
		this.pDraw = pDraw;
		console.log(pDraw);
	}

	setColor(color) {
		console.log(color);
	}

	setType(type) {
		this.pDraw.xData.setType(type);
		console.log(type);
	}
}