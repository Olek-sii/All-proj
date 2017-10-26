$(document).ready(function() {
	
});

$('#submit').click(function() {
	console.log("123");
});

function callback(json){
	console.log(json);
	json.forEach(function(message) {
		$('#messages').append(message['name'] + ': ' + message['message'] + '<br>');
	})
}