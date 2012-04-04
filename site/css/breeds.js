// JavaScript Document

var char, inc = 0;
var html = "";

while (  char = String.fromCharCode('A'.charCodeAt() + inc) != '[' ) {
	html += "<div class='letter'>"+char+"</div>";
}

$(document).ready( function() {
	$("div.letterPanel").html( html );
	
});