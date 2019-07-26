$(document).ready(function(){
	$("select").each(function(){
		var name = $(this).attr("name");
		$(this).after("<ul class='selectBox' selectName = '"+name+"' style='display:none'></ul>");
		$(this).after("<span class='selectBox' selectName = '"+name+"'></span>");
		
		$(this).children("option").each(function(){
			var option = "<li selectValue = ' " + $(this).val() +" ' >"+ $(this).html() +"</li>";
			$("ul[selectName = "+name+"]").append(option);
		});
		$("[selectName = "+name+"] li:first-child").appendTo("span[selectName = "+name+"]");
		
		$(this).remove();
	
	
	});
	
	$(".selectBox").click(function(){
		var selectName = $(this).attr("selectname");
		$("ul[selectname="+selectName+"]").slideToggle();
	});
	$("ul.selectBox li").click(function(){
		
	
	})
	
});