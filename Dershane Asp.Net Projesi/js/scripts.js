


var sliderTimer = 5000; //miliSeconds//
window.sliderIndex = 1;

function goToSlide(){
		
		$("#sliderWrapper a").css({"display":"none"});
		$("#sliderWrapper a:nth-child("+window.sliderIndex+")").fadeIn();
		

		
		$("#thumbnails ul li").removeClass("activet");
		$("#thumbnails ul li:nth-child("+window.sliderIndex+")").addClass("activet");

}

function changeSlide(){
	var sliderCount = $("#sliderWrapper #images a").children().length;
	if(window.sliderIndex <= sliderCount){
		
		goToSlide();
		window.sliderIndex++;
	}else{
		window.sliderIndex = 1;
		goToSlide();
		
	}
}

setInterval("changeSlide()",sliderTimer);

//Adds the thumbnails
$(document).ready(function(){
	$("#sliderWrapper a").css({"display":"none"});
	$("#sliderWrapper a:first").css({"display":""});
	var sliderCount = $("#sliderWrapper #images a").children().length;
	for(i=1;i<=sliderCount;i++){
		$("#thumbnails ul").append("<li></li>");
	}
	
	// Thumbnail controls
	$("#thumbnails ul li").click(function(){
		var index = $(this).index() +1 ;
		window.sliderIndex = index;
		goToSlide();
		
	});
	//Go Forward and backwards functions for slider
	$(".right_arrow").click(function(){
		window.sliderIndex++;
		goToSlide();
	});
	$(".left_arrow").click(function(){
		window.sliderIndex--;
		goToSlide();
	});
	//Go Forward and backwards functions slider ENDS

});




// Insan kaynakları formu için //
window.langCount = 1;
window.experience = 1;
window.reference = 1;



// Insan kaynakları formu için END//