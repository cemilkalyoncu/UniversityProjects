
function formControl(){
	var error = ''
	var secim = ''
	if($("input[name='gorev_sube']").length)
	{
	var fields = $("input[name='gorev_sube']").serializeArray();
		if (fields.length == 0) 
		  { 
		     secim += 'True';
		  } 
		  else 
		  { 
		    
		  }
	}
	
	$(".required").each(function(){
		 
		if($(this).val() == ""){
			$(this).css({"background":"#FCF9BC","border":"1px solid red"});
			
			if($(this).attr('rel') != 'fail'){
			$(this).after('<img class="req_icon" src="/static/images/required.png" style="margin:0px 0px -2px 5px;width:16px" alt="" />');
			}
			$(this).attr('rel','fail')
			$(".requiredAc").aspx("<b style='color:red'>Those fields are required !</b>");
			error += 'True';
			$("#gerekliAlanlar").fadeIn();
			
			
		}else if($(this).val() != ""){
			$(this).css({"background":"#FFF","border":"1px solid #ddd"});
			$(this).parent().children(".req_icon").remove();
			$("#gerekliAlanlar").fadeOut();
		};
		
	});
	
	if (error != "" || secim != ""){
		if(secim != "")
		{
			alert("Lütfen Görev Almak İstediğiniz Şubeyi Seçiniz!");
			return false;
		}
		else {
		alert("Lütfen Gerekli Alanları Doldurunuz!");
		return false;
		}
		
	}

};

function loginControl(){
	var errorlogin = ''
	
	$(".requiredlogin").each(function(){
		 
		if($(this).val() == ""){
			$(this).css({"background":"#FCF9BC","border":"1px solid red"});
			
			if($(this).attr('rel') != 'fail'){
			$(this).after('<img class="req_icon" src="/static/images/required.png" style="margin:0px 0px -2px 5px;width:16px" alt="" />');
			}
			$(this).attr('rel','fail')
			$(".requiredAc").aspx("<b style='color:red'>Those fields are required !</b>");
			errorlogin += 'True';
			$("#gerekliAlanlar").fadeIn();
			
			
		}else if($(this).val() != ""){
			$(this).css({"background":"#FFF","border":"1px solid #ddd"});
			$(this).parent().children(".req_icon").remove();
			$("#gerekliAlanlar").fadeOut();
		};
		
	});
	
	if (errorlogin == ""){ }
		else {
		alert("Lütfen Gerekli Alanları Doldurunuz!");
		return false;
		}
		
	};

function dersControl(){
	var errorlogin = ''
	
	$(".requiredders").each(function(){
		 
		if($(this).val() == ""){
			$(this).css({"background":"#FCF9BC","border":"1px solid red"});
			
			if($(this).attr('rel') != 'fail'){
			$(this).after('<img class="req_icon" src="/static/images/required.png" style="margin:0px 0px -2px 5px;width:16px" alt="" />');
			}
			$(this).attr('rel','fail')
			$(".requiredAc").html("<b style='color:red'>Those fields are required !</b>");
			errorlogin += 'True';
			$("#gerekliAlanlar").fadeIn();
			
			
		}else if($(this).val() != ""){
			$(this).css({"background":"#FFF","border":"1px solid #ddd"});
			$(this).parent().children(".req_icon").remove();
			$("#gerekliAlanlar").fadeOut();
		};
		
	});
	
	if (errorlogin == ""){ }
		else {
		alert("Lütfen Gerekli Alanları Doldurunuz!");
		return false;
		}
		
	};



