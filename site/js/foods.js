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
        var both = foodtype == "Both";
		var isGood = foodtype == "Good";

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
	$("div.foodItem").live( "click", function() {
		var id = $(this).attr("id");
		
		$("div#foodContent").empty().load( "./views/afood.html", function() {
			
			aFood = foodsdata[id];
			var src = "";
			$.each( aFood, function (key, val) {
				$("#"+key).html( val );
				if (key=="isGood" && !(val))
					$("#"+key+".goodbad").html("<img src='./pics/DoNotFeed2.png' height='100' width='100' />");
				
				if (key=="picfile")
				{
					src = "./pics/food/" + val;
					$('#picfile.foodImage').html("<img src='"+src+ "' height='150' width='150' />");
				}
			});
			/*
				
				if (key=="picfile")
				{
					src = "./pics/food/" + val;
					$('#picfile.foodImage').html("<img "+src+ " height='100' width='100' />");
				}
			*/
		});
		
		$("div.foodItem:*").removeClass("foodItem_selected");
		$(this).addClass("foodItem_selected");
		
	});
	
	//The pages default selections.
	
	$("div#both").trigger("click");

	$("#disclaimer").click(function(e) {
      e.preventDefault(); // if desired...
      alert("DISCLAIMER:\nThe website and all of the materials on or referenced by the website are provided on an \"as is\" basis for informational purposes only. In no event shall woofpack.info, its owners, or creators be liable for any direct, indirect, incidental, punitive, or consequential damages of any kind whatsoever with respect to the use of the website or any information contained or linked to in this website. You agree that you are using the website solely at your own risk, for research or educational purposes. In case of medical/veterinary emergencies please contact a licensed veterinary doctor or call Animal Poison Control Center at 1-888-426-4435.");
    });
	
});