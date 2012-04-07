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
	
	/*Food SELECTION*/
	
	function populateFoods ( foodtype ) { /*letter = foodtype*/
		var html = "";
                var both = foodtype == "both";
		var isGood = foodtype == "good"

		//alert(both);
		$.each(foodsdata, function (key, val)
		{
                    //NOTE: removed regex because json will automatically treat true false like a boolean versus string.
                    doAdd = val.isGood == isGood;
                    if (doAdd || both) html += "<div id='"+key+"' class='foodItem'><div class='foodItemText'>"+val.name+"</div></div>";
		});
		
		$("#foodList").html( html );
		
		$("div.foodItem:first").trigger("click");
	}
	
	/*EVENTS*/
		
	//POPULATE THE Food SELECTION AREA
	$("div.foodtype").bind( "click", function() {
		if (! $(this).hasClass("div.foodtype_selected") ) {
			$("div.foodtype:*").removeClass("div.foodtype_selected");
			$(this).addClass("div.foodtype_selected");
			populateFoods( $(this).html() );
		}
	});
	
	//POPULATE THE FOOD CONTENT AREA
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
	
	$("div#both").trigger("click");

	
});