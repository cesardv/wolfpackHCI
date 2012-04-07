/**
  *AUTHOR: Cesar Velez
  *7 April 2012
*/

$(document).ready( function() {
	
	//Food: Good - Bad - Both PANEL  -- not needed for foods page
	var char = 0;
	var html = "<div id='both' class='foodtype' style='margin-left:10px'>Both</div> - ";
	
	//for ( var inc='A'.charCodeAt(0); inc <= 'Z'.charCodeAt(0); inc++  ) {
		
		html += "<div class='foodtype'>Good</div> - ";
		html += "<div class='foodtype'>Bad</div>";
	
	
	$("div.goodbadPanel").html( html );
	
	$("div.foodtype").hover( function() {
		$(this).animate( {fontSize:"30px"}, 250 );
	},
	function() {
		$(this).animate( {fontSize:"24px"}, 250 );
	}); 
	
	

	
});