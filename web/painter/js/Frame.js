class Frame {
	constructor() {
		this.nTabs = 0;
		this.tabs = new Array();

		this.xCommand = new XCommand(this.tabs);

		$('.color-picker').click($.proxy(function() {
			this.xCommand.setColor('#F00');
		}, this));

		$('.rect-type-picker').click($.proxy(function() {
			this.xCommand.setType('rect');
		}, this));

		$('.circle-type-picker').click($.proxy(function() {
			this.xCommand.setType('circle');
		}, this));

		$('#btn-add-tab').click($.proxy(function() {
			var pDraw = new PDraw(this.nTabs++);
			$('#tab-list').append(pDraw.ToggleButton);
			$('#tab-content').append(pDraw.SvgContainer);

			this.tabs.push(pDraw);
		}, this));

		$('.nav-tabs').click('.tab', $.proxy(function(e){
			var id = $(e.target).attr('id');
			this.xCommand.setActivePDraw(this.tabs[id]);
		}, this));
	}
}