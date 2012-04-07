/**
  *AUTHOR: Cesar Velez
  *7 April 2012
*/

$(document).ready( function() {
	
	/*LETTER PANEL  -- not needed for foods page
	var char = 0;
	var html = "<div id='any' class='letter' style='margin-left:20px'>Any</div>";
	
	for ( var inc='A'.charCodeAt(0); inc <= 'Z'.charCodeAt(0); inc++  ) {
		html += "<div class='letter'>"+String.fromCharCode(inc)+"</div>";
	}
	
	$("div.letterPanel").html( html );
	
	$("div.letter").hover( function() {
		$(this).animate( {fontSize:"19px"}, 250 );
	},
	function() {
		$(this).animate( {fontSize:"14px"}, 250 );
	}); */ 
	
	
	/*Food SELECTION*/
	
	function populateFoods (  ) {
		var html = "";
		var regex = null;
		/*var any = letter=="Any";*/
		
		$.each(foods, function (key, val) {
			/*regex = new RegExp("^"+letter);
			doAdd = val.name.match(regex);
			if (doAdd || any)*/ 
			html += "<div id='"+key+"' class='foodItem'><div class='foodItemText'>"+val.name+"</div></div>";
		});
		
		$("#foodList").html( html );
		
		$("div.foodItem:first").trigger("click");
	}
	
	/*EVENTS*/
	/*	
	//POPULATE THE BREED SELECTION AREA
	$("div.letter").bind( "click", function() {
		if (! $(this).hasClass("div.letter_selected") ) {
			$("div.letter:*").removeClass("letter_selected");
			$(this).addClass("letter_selected");
			
			populateFoods( $(this).html() );
		}
	});	*/
	
	//POPULATE THE BREED CONTENT AREA
	$("div.breedItem").live( "click", function() {
		var id = $(this).attr("id");
		
		$("div#breedContent").empty().load( "./views/breed.html", function() {
			
			aBreed = breeds[id];
			
			$.each( aBreed, function (key, val) {
				$("#"+key).html( val );
			});
			
		});
		
		$("div.breedItem:*").removeClass("breedItem_selected");
		$(this).addClass("breedItem_selected");
		
	});
	
	//The pages default selections.
	
	$("div#any").trigger("click");
	
});