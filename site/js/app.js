$(document).ready(function() {
	createBreedSelectList('#breedList');
});

//==================================================================
// APPLICATION SPECIFIC CODE
//==================================================================

//------------------------------------------------------------------
function createBreedList(container){
//------------------------------------------------------------------
	createUL(container);
	i = 0;
	while(breeds[i]){
		addListItem(container, breeds[i].name);
		i++;
	}
}
//------------------------------------------------------------------
function createBreedSelectList(container){
//------------------------------------------------------------------
	createSelectList(container);
	i = 0;
	while(breeds[i]){
		addSelectListItem(container, breeds[i].name);
		i++;
	}
if(0){ // This method works in Google Chrome, but not in IE9	
	$('#breedList select option').click(function() {
		//alert(this.text);
		breedSelected(this.text);
	});	
}else{ // This works in Chrome and IE9
	$('#breedList select').change(function() {
		//alert(this.value);
		breedSelected(this.value);
	});
}
}
//------------------------------------------------------------------
function breedSelected(breedName){
//------------------------------------------------------------------
	$('#healthInfo').empty();
	createUL('#healthInfo');
	i = 0;
	while(breeds[i]){
		if(breeds[i].name == breedName){
			j = 0;
			while(breeds[i].healthIssues[j]){
				description = ((breeds[i].healthIssues[j].description) ? (': ' + breeds[i].healthIssues[j].description) : (""));
				addListItem('#healthInfo', (breeds[i].healthIssues[j].name + description));
				
				j++;
			}
			break;			
		}
		i++;
	}
}

//==================================================================
// REUSABLE CODE
//==================================================================

//------------------------------------------------------------------
function createUL(container){
//------------------------------------------------------------------
	$(container).append('<ul></ul>');
}
//------------------------------------------------------------------
function addListItem(container, addText){
//------------------------------------------------------------------
	$(container + ' ul').append('<li>' + addText + '</li>');
}
//------------------------------------------------------------------
function createSelectList(container){
//------------------------------------------------------------------
	$(container).append('<div class="breeds"></div>');
}
//------------------------------------------------------------------
function addSelectListItem(container, addText){
//------------------------------------------------------------------
	preTag = '<div class="breedOption" value="';
	postTag = '">';
	$(container + ' select').append(preTag + addText + postTag + addText + '</div>');
}
