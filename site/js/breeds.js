/**
  *AUTHOR: Eric Hunter
  *4 April 2012
*/

$(document).ready( function() {
	
	/*LETTER PANEL*/
	
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
	});
	
	
	/*BREED SELECTION*/
	
	function populateBreeds ( letter ) {
		var html = "";
		var doAdd = true;
		var regex = null;
		$.each(breeds, function (key, val) {
			regex = new RegExp("^"+letter);
			doAdd = !null || val.name.match(regex);
			if (doAdd) html += "<div id='"+key+"' class='breedItem'><span class='breedItemText'>"+val.name+"</span></div>";
		});
		
		$("#breedList").html( html );
	}
	
	/*EVENTS*/
		
	//POPULATE THE BREED SELECTION AREA
	$("div.letter").bind( "click", function() {
		if (! $(this).hasClass("div.letter_selected") ) {
			$("div.letter:*").removeClass("letter_selected");
			$(this).addClass("letter_selected");
			
			populateBreeds( $(this).html()=="Any" ? null : $(this).html() );
		}
	});
	
	//POPULATE THE BREED CONTENT AREA
	$("div.breedItem").live( "click", function() {
		var id = $(this).attr("id");
		
		$("div#breedContent").empty().load( "./views/breed.html", function() {
			
			aBreed = breeds[id];
			
			$.each( aBreed, function (key, val) {
				$("#"+key).html( val );
			});
			
		});
		
	});

	
	//The pages default selections.
	
	$("div#any").trigger("click");
	$("div.breedItem:first").trigger("click");
	
});