class XData {
	constructor() {
		this.type = 'circle';
	}

	setType(type) {
		this.type = type;
	}
}

class PDraw {
	constructor(id) {
		this.id = id;
		this.xData = new XData();
		this.figuresArray = new Array();
		this.ns = 'http://www.w3.org/2000/svg';
		this.svg = document.createElementNS(this.ns, 'svg');
		this.svg.addEventListener("click", this.onClick(this));
		//this.svg.addEventListener("mousemove", Move);
		//this.svg.addEventListener("mouseup", Up);
		this.svg.setAttributeNS(null, 'width', '100%');
		this.svg.setAttributeNS(null, 'height', '100%');
	}

	draw() {
		while (this.svg.lastChild) {
			this.svg.removeChild(this.svg.lastChild);
		}
		this.figuresArray.forEach(function(figure) {
			var f;
			if (figure.type == 'rect') {
				f = document.createElementNS(this.ns, figure.type);
				f.setAttributeNS(null, 'x', figure.x);
				f.setAttributeNS(null, 'y', figure.y);
				f.setAttributeNS(null, 'height', figure.w);
				f.setAttributeNS(null, 'width', figure.h);
				f.setAttributeNS(null, 'fill', figure.color);
			} else {
				f = document.createElementNS(this.ns, figure.type);
				f.setAttributeNS(null, 'cx', figure.x);
				f.setAttributeNS(null, 'cy', figure.y);
				f.setAttributeNS(null, 'r', figure.w/2);
				f.setAttributeNS(null, 'fill', figure.color);
			}
			this.svg.appendChild(f);			
		}.bind(this));
	}

	onClick(context) {
		return function(e) {
			var figure = new Figure(
				e.pageX - context.svg.getBoundingClientRect().x,
				e.pageY - context.svg.getBoundingClientRect().y,
				50,
				50,
				'#'+Math.round(0xffffff * Math.random()).toString(16),
				1,
				context.xData.type
			);

			context.figuresArray.push(figure);
			context.draw();
		}
	}

	get figures() {
		return this.figuresArray;
	}

	get ToggleButton() {
		return '<li> \
					<a href="#tab'+this.id+'" role="tab" data-toggle="tab" class="btn tab" id="'+this.id+'">Tab ' + this.id + '</a> \
					<button type="button" class="close" title="Remove this page">×</button> \
				</li>';		
	}

	get SvgContainer() {
		var div = document.createElement('div');
		div.setAttribute("class", 'tab-pane fade fill-height');
		div.setAttribute("id", 'tab' + this.id);
		div.append(this.svg);
		return div;
	}
}