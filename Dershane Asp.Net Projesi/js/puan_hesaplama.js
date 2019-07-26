function getNet(obj1N,obj2N,obj3N,soruAdet,objT){
	var objD = document.getElementById(obj1N);
	var objY = document.getElementById(obj2N);
	var objN = document.getElementById(obj3N);

	if(objD && objY && objN){
		if( (Math.round(objD.value)>soruAdet) || (Math.round(objY.value)>soruAdet) || ( (Math.round(objD.value) + Math.round(objY.value)) >soruAdet)){
			alert("En fazla toplam soru adedi aşılmıştır.");
			objT.value = Math.round(objT.value) - ((Math.round(objD.value) + Math.round(objY.value)) - Math.round(soruAdet));
			return false;
		}
		objN.innerHTML = setNumberFormat( objD.value - (objY.value/4), 2);
	}
}

function getYGSGenel(){
	var arrYGSKatsayi = new Array();
	/*arrYGSKatsayi[0] = new Array(2.05, 1.025, 4.1, 3.075, 90);
	arrYGSKatsayi[1] = new Array(2.05, 1.025, 3.075, 4.1, 90);
	arrYGSKatsayi[2] = new Array(4.1, 3.075, 2.05, 1.025, 90);
	arrYGSKatsayi[3] = new Array(3.075, 4.1, 2.05, 1.025, 90);
	arrYGSKatsayi[4] = new Array(3.792, 2.05, 3.382, 1.025, 90.04);
	arrYGSKatsayi[5] = new Array(3.382, 1.025, 3.792, 2.05, 90.04);*/
	/*						     TÜRKÇE  SOSYAL  MAT.    FEN     TABAN   */
	arrYGSKatsayi[0] = new Array(2.0274, 1.0274, 4.0276, 3.0276, 95.5361);
	arrYGSKatsayi[1] = new Array(2.0274, 1.0274, 3.0276, 4.0276, 95.6);
	arrYGSKatsayi[2] = new Array(4.0276, 3.0276, 2.0274, 1.0274, 95.6);
	arrYGSKatsayi[3] = new Array(3.0276, 4.0276, 2.0274, 1.0274, 95.6);
	arrYGSKatsayi[4] = new Array(3.7276, 2.0274, 3.3276, 1.0274, 95.6);
	arrYGSKatsayi[5] = new Array(3.3276, 1.0274, 3.7276, 2.0274, 95.6);

	var objTDG = document.getElementById("tdYGSHes");
	objTDG.style.display = "block";

	var obj0 = document.getElementById("tdYGSN0");
	var obj1 = document.getElementById("tdYGSN1");
	var obj2 = document.getElementById("tdYGSN2");
	var obj3 = document.getElementById("tdYGSN3");

	var objG1 = document.getElementById("tdYGSG1");
	var objG2 = document.getElementById("tdYGSG2");
	var objG3 = document.getElementById("tdYGSG3");
	var objG4 = document.getElementById("tdYGSG4");
	var objG5 = document.getElementById("tdYGSG5");
	var objG6 = document.getElementById("tdYGSG6");



	if(obj0 && obj1 && obj2 && obj3){
		var int0,int1,int2,int3
		int0 = Math.round(obj0.innerHTML*100)/100;
		int1 = Math.round(obj2.innerHTML*100)/100;
		int2 = Math.round(obj1.innerHTML*100)/100;
		int3 = Math.round(obj3.innerHTML*100)/100;
			
		if (isNaN(int0)){var int0=parseFloat(0.0);}
		if (isNaN(int1)){var int1=parseFloat(0.0);}
		if (isNaN(int2)){var int2=parseFloat(0.0);}
		if (isNaN(int3)){var int3=parseFloat(0.0);}
		
		for(var k=1;k<7;k++){
			eval("objG" + k).innerHTML = setNumberFormat( (int0 * arrYGSKatsayi[(k-1)][0]) + (int1 * arrYGSKatsayi[(k-1)][1]) + (int2 * arrYGSKatsayi[(k-1)][2]) + (int3 * arrYGSKatsayi[(k-1)][3]) + arrYGSKatsayi[(k-1)][4], 3);
		}
	}

	var objTDGLGS = document.getElementById("tdLGSHes");
	objTDGLGS.style.display = "block";

	getLGSMFGenel();
	getLGSTMGenel();
	getLGSTSGenel();
	getLGSYDGenel();
}

function getLGSMFGenel(){
	var arrMFKatsayi = new Array();
	arrMFKatsayi[0] = new Array(1.1, 1.6, 0.5, 0.8, 2.080, 1.733, 1.333, 0.8, 0.666, 100.000);
	arrMFKatsayi[1] = new Array(1.1, 1.1, 0.5, 1.3, 1.28, 0.933, 1.733, 1.6, 1.6, 100.000);
	arrMFKatsayi[2] = new Array(1.1, 1.1, 0.7, 1.1, 1.04, 0.666, 1.733, 1.866, 2.0, 100.000);
	arrMFKatsayi[3] = new Array(1.1, 1.4, 0.6, 0.9, 1.76, 1.466, 1.733, 1.2, 0.666, 100.000);

	var obj1 = document.getElementById("tdLGSMF1");
	var obj2 = document.getElementById("tdLGSMF2");
	var obj3 = document.getElementById("tdLGSMF3");
	var obj4 = document.getElementById("tdLGSMF4");
	
	var intObj0 = Math.round(document.getElementById("tdYGSN0").innerHTML*100)/100;
	var intObj1 = Math.round(document.getElementById("tdYGSN1").innerHTML*100)/100;
	var intObj2 = Math.round(document.getElementById("tdYGSN2").innerHTML*100)/100;
	var intObj3 = Math.round(document.getElementById("tdYGSN3").innerHTML*100)/100;

	var intObj4 = Math.round(document.getElementById("tdLYSN0").innerHTML*100)/100;
	var intObj5 = Math.round(document.getElementById("tdLYSN1").innerHTML*100)/100;
	var intObj6 = Math.round(document.getElementById("tdLYSN2").innerHTML*100)/100;
	var intObj7 = Math.round(document.getElementById("tdLYSN3").innerHTML*100)/100;
	var intObj8 = Math.round(document.getElementById("tdLYSN4").innerHTML*100)/100;
	
	if (isNaN(intObj0)){var intObj0=parseFloat(0.0);}
	if (isNaN(intObj1)){var intObj1=parseFloat(0.0);}
	if (isNaN(intObj2)){var intObj2=parseFloat(0.0);}
	if (isNaN(intObj3)){var intObj3=parseFloat(0.0);}
	if (isNaN(intObj4)){var intObj4=parseFloat(0.0);}
	if (isNaN(intObj5)){var intObj5=parseFloat(0.0);}
	if (isNaN(intObj6)){var intObj6=parseFloat(0.0);}
	if (isNaN(intObj7)){var intObj7=parseFloat(0.0);}
	if (isNaN(intObj8)){var intObj8=parseFloat(0.0);}
	

	for(var k=1;k<5;k++){
		eval("obj" + k).innerHTML = setNumberFormat( (intObj0 * arrMFKatsayi[(k-1)][0]) + (intObj1 * arrMFKatsayi[(k-1)][1]) + (intObj2 * arrMFKatsayi[(k-1)][2]) + (intObj3 * arrMFKatsayi[(k-1)][3]) + (intObj4 * arrMFKatsayi[(k-1)][4]) + (intObj5 * arrMFKatsayi[(k-1)][5]) + (intObj6 * arrMFKatsayi[(k-1)][6]) + (intObj7 * arrMFKatsayi[(k-1)][7]) + (intObj8 * arrMFKatsayi[(k-1)][8]) + arrMFKatsayi[(k-1)][9], 3);
	}
}

function getLGSTMGenel(){
	var arrTMKatsayi = new Array();
	arrTMKatsayi[0] = new Array(1.4, 1.6, 0.5, 0.5, 2.0, 1.333, 1.285, 1.166, 100.000);
	arrTMKatsayi[1] = new Array(1.4, 1.4, 0.7, 0.5, 1.76, 1.066, 1.571, 1.333,100.000);
	arrTMKatsayi[2] = new Array(1.5, 1.0, 1.0, 0.5, 1.44, 0.933, 1.785, 1.666,100.000);

	var obj1 = document.getElementById("tdLGSTM1");
	var obj2 = document.getElementById("tdLGSTM2");
	var obj3 = document.getElementById("tdLGSTM3");

	var intObj0 = Math.round(document.getElementById("tdYGSN0").innerHTML*100)/100;
	var intObj1 = Math.round(document.getElementById("tdYGSN1").innerHTML*100)/100;
	var intObj2 = Math.round(document.getElementById("tdYGSN2").innerHTML*100)/100;
	var intObj3 = Math.round(document.getElementById("tdYGSN3").innerHTML*100)/100;

	var intObj4 = Math.round(document.getElementById("tdLYSN0").innerHTML*100)/100;
	var intObj5 = Math.round(document.getElementById("tdLYSN1").innerHTML*100)/100;
	var intObj6 = Math.round(document.getElementById("tdLYSN5").innerHTML*100)/100;
	var intObj7 = Math.round(document.getElementById("tdLYSN6").innerHTML*100)/100;

	if (isNaN(intObj0)){var intObj0=parseFloat(0.0);}
	if (isNaN(intObj1)){var intObj1=parseFloat(0.0);}
	if (isNaN(intObj2)){var intObj2=parseFloat(0.0);}
	if (isNaN(intObj3)){var intObj3=parseFloat(0.0);}
	if (isNaN(intObj4)){var intObj4=parseFloat(0.0);}
	if (isNaN(intObj5)){var intObj5=parseFloat(0.0);}
	if (isNaN(intObj6)){var intObj6=parseFloat(0.0);}
	if (isNaN(intObj7)){var intObj7=parseFloat(0.0);}
	for(var k=1;k<4;k++){
		eval("obj" + k).innerHTML = setNumberFormat( (intObj0 * arrTMKatsayi[(k-1)][0]) + (intObj1 * arrTMKatsayi[(k-1)][1]) + (intObj2 * arrTMKatsayi[(k-1)][2]) + (intObj3 * arrTMKatsayi[(k-1)][3]) + (intObj4 * arrTMKatsayi[(k-1)][4]) + (intObj5 * arrTMKatsayi[(k-1)][5]) + (intObj6 * arrTMKatsayi[(k-1)][6]) + (intObj7 * arrTMKatsayi[(k-1)][7]) + arrTMKatsayi[(k-1)][8], 3);
	}
}

function getLGSTSGenel(){
	var arrTSKatsayi = new Array();
	arrTSKatsayi[0] = new Array(1.4, 1.6, 0.5, 0.5, 1.071, 1.333, 1.063, 1.342, 1.645, 1.063, 100.000);
	arrTSKatsayi[1] = new Array(1.4, 1.4, 0.7, 0.5, 1.785, 0.833, 1.063, 0.906, 0.987, 0.990, 100.000);

	var obj1 = document.getElementById("tdLGSTS1");
	var obj2 = document.getElementById("tdLGSTS2");

	var intObj0 = Math.round(document.getElementById("tdYGSN0").innerHTML*100)/100;
	var intObj1 = Math.round(document.getElementById("tdYGSN1").innerHTML*100)/100;
	var intObj2 = Math.round(document.getElementById("tdYGSN2").innerHTML*100)/100;
	var intObj3 = Math.round(document.getElementById("tdYGSN3").innerHTML*100)/100;

	var intObj4 = Math.round(document.getElementById("tdLYSN5").innerHTML*100)/100;
	var intObj5 = Math.round(document.getElementById("tdLYSN6").innerHTML*100)/100;
	var intObj6 = Math.round(document.getElementById("tdLYSN7").innerHTML*100)/100;
	var intObj7 = Math.round(document.getElementById("tdLYSN8").innerHTML*100)/100;
	var intObj8 = Math.round(document.getElementById("tdLYSN9").innerHTML*100)/100;
	var intObj9 = Math.round(document.getElementById("tdLYSN11").innerHTML*100)/100;

	if (isNaN(intObj0)){var intObj0=parseFloat(0.0);}
	if (isNaN(intObj1)){var intObj1=parseFloat(0.0);}
	if (isNaN(intObj2)){var intObj2=parseFloat(0.0);}
	if (isNaN(intObj3)){var intObj3=parseFloat(0.0);}
	if (isNaN(intObj4)){var intObj4=parseFloat(0.0);}
	if (isNaN(intObj5)){var intObj5=parseFloat(0.0);}
	if (isNaN(intObj6)){var intObj6=parseFloat(0.0);}
	if (isNaN(intObj7)){var intObj7=parseFloat(0.0);}
	if (isNaN(intObj8)){var intObj8=parseFloat(0.0);}
	if (isNaN(intObj9)){var intObj9=parseFloat(0.0);}
	for(var k=1;k<3;k++){
		eval("obj" + k).innerHTML = setNumberFormat( (intObj0 * arrTSKatsayi[(k-1)][0]) + (intObj1 * arrTSKatsayi[(k-1)][1]) + (intObj2 * arrTSKatsayi[(k-1)][2]) + (intObj3 * arrTSKatsayi[(k-1)][3]) + (intObj4 * arrTSKatsayi[(k-1)][4]) + (intObj5 * arrTSKatsayi[(k-1)][5]) + (intObj6 * arrTSKatsayi[(k-1)][6]) + (intObj7 * arrTSKatsayi[(k-1)][7]) +(intObj9 * arrTSKatsayi[(k-1)][9])+ (intObj8 * arrTSKatsayi[(k-1)][8]) + arrTSKatsayi[(k-1)][10], 3);
	}
}

function getLGSYDGenel(){
	var arrYDKatsayi = new Array();
	arrYDKatsayi[0] = new Array(1.5, 0.6, 0.9, 0.5, 3.250, 100.0);
	arrYDKatsayi[1] = new Array(2.5, 0.7, 1.3, 0.5, 2.5, 100.00);
	arrYDKatsayi[2] = new Array(4.80, 0.7, 2.0, 0.5, 1.0, 100.00);

	var obj1 = document.getElementById("tdLGSYD1");
	var obj2 = document.getElementById("tdLGSYD2");
	var obj3 = document.getElementById("tdLGSYD3");

	var intObj0 = Math.round(document.getElementById("tdYGSN0").innerHTML*100)/100;
	var intObj1 = Math.round(document.getElementById("tdYGSN1").innerHTML*100)/100;
	var intObj2 = Math.round(document.getElementById("tdYGSN2").innerHTML*100)/100;
	var intObj3 = Math.round(document.getElementById("tdYGSN3").innerHTML*100)/100;

	var intObj4 = Math.round(document.getElementById("tdLYSN10").innerHTML*100)/100;

	if (isNaN(intObj0)){var intObj0=parseFloat(0.0);}
	if (isNaN(intObj1)){var intObj1=parseFloat(0.0);}
	if (isNaN(intObj2)){var intObj2=parseFloat(0.0);}
	if (isNaN(intObj3)){var intObj3=parseFloat(0.0);}
	if (isNaN(intObj4)){var intObj4=parseFloat(0.0);}
	
	for(var k=1;k<4;k++){
		eval("obj" + k).innerHTML = setNumberFormat( (intObj0 * arrYDKatsayi[(k-1)][0]) + (intObj1 * arrYDKatsayi[(k-1)][1]) + (intObj2 * arrYDKatsayi[(k-1)][2]) + (intObj3 * arrYDKatsayi[(k-1)][3]) + (intObj4 * arrYDKatsayi[(k-1)][4]) + arrYDKatsayi[(k-1)][5], 3);
	}
}

function setNumberFormat(deger,basamak){
	var nf = new NumberFormat(deger);
	nf.setPlaces(basamak);
	nf.setSeparators(false);
	var num = nf.toFormatted();
	return num;
}

function setYGSFormTemizle(){
	for(var k=0;k<4;k++){
		document.getElementById("ygsy_" + k).value = "";
		document.getElementById("ygsd_" + k).value = "";
		document.getElementById("tdYGSN" + k).innerHTML = "";
	}

	for(var k=0;k<11;k++){
		document.getElementById("lysd_" + k).value = "";
		document.getElementById("lysy_" + k).value = "";
		document.getElementById("tdLYSN" + k).innerHTML = "";
	}
}

/*SBS HESAPLAMALARI*/
function getSBSNet(obj1N,obj2N,obj3N,soruAdet,objT){
	var objD = document.getElementById(obj1N);
	var objY = document.getElementById(obj2N);
	var objN = document.getElementById(obj3N);
	if(objD==''){ objD = 0; }
	if(objY==''){ objY = 0; }
	if(objN==''){ objN = 0; }
	if(objD && objY && objN){
		if( (Math.round(objD.value)>soruAdet) || (Math.round(objY.value)>soruAdet) || ( (Math.round(objD.value) + Math.round(objY.value)) >soruAdet)){
			alert("En fazla toplam soru adedi a��lm��t�r.");
			objT.value = Math.round(objT.value) - ((Math.round(objD.value) + Math.round(objY.value)) - Math.round(soruAdet));
			return false;
		}
		objN.innerHTML = setNumberFormat( objD.value - (objY.value/3), 2);
	}
}

function getSBS8Hes(){
	var intObj0 = Math.round(document.getElementById("td8Net0").innerHTML*100)/100;
	var intObj1 = Math.round(document.getElementById("td8Net1").innerHTML*100)/100;
	var intObj2 = Math.round(document.getElementById("td8Net2").innerHTML*100)/100;
	var intObj3 = Math.round(document.getElementById("td8Net3").innerHTML*100)/100;
	var intObj4 = Math.round(document.getElementById("td8Net4").innerHTML*100)/100;
	if (isNaN(intObj0)){var intObj0=parseFloat(0.0);}
	if (isNaN(intObj1)){var intObj1=parseFloat(0.0);}
	if (isNaN(intObj2)){var intObj2=parseFloat(0.0);}
	if (isNaN(intObj3)){var intObj3=parseFloat(0.0);}
	if (isNaN(intObj4)){var intObj4=parseFloat(0.0);}
	var objS = document.getElementById("td8Sonuc");
	objS.style.display = "block";

	var intSonuc = (intObj0 * 3.907855) + (intObj1 * 2.656184) + (intObj2 * 4.012689) + (intObj3 * 3.505472) + (intObj4 * 0.966911) + 190.195072

	if(intSonuc==123.379312){
		objS.innerHTML = 0;
	}else{
		objS.innerHTML = "SBS PUANI : <span>" + setNumberFormat(intSonuc, 3) + "</span>";
	}
}

function getSBS7Hes(){
	var intObj0 = Math.round(document.getElementById("td7Net0").innerHTML*100)/100;
	var intObj1 = Math.round(document.getElementById("td7Net1").innerHTML*100)/100;
	var intObj2 = Math.round(document.getElementById("td7Net2").innerHTML*100)/100;
	var intObj3 = Math.round(document.getElementById("td7Net3").innerHTML*100)/100;
	var intObj4 = Math.round(document.getElementById("td7Net4").innerHTML*100)/100;
	if (isNaN(intObj0)){var intObj0=parseFloat(0.0);}
	if (isNaN(intObj1)){var intObj1=parseFloat(0.0);}
	if (isNaN(intObj2)){var intObj2=parseFloat(0.0);}
	if (isNaN(intObj3)){var intObj3=parseFloat(0.0);}
	if (isNaN(intObj4)){var intObj4=parseFloat(0.0);}
	var objS = document.getElementById("td7Sonuc");
	objS.style.display = "block";

	var intSonuc = ((intObj0 * 3.908338) + (intObj1 * 3.045047) + (intObj2 * 5.076272) + (intObj3 * 3.829707) + (intObj4 * 1.137078) + 185.750126)
	if(intSonuc==123.379312){
		objS.innerHTML = 0;
	}else{
		objS.innerHTML = "SBS PUANI : <span>" + setNumberFormat(intSonuc, 3) + "</span>";
	}
}

function getSBS6Hes(){
	var intObj0 = Math.round(document.getElementById("td6Net0").innerHTML*100)/100;
	var intObj1 = Math.round(document.getElementById("td6Net1").innerHTML*100)/100;
	var intObj2 = Math.round(document.getElementById("td6Net2").innerHTML*100)/100;
	var intObj3 = Math.round(document.getElementById("td6Net3").innerHTML*100)/100;
	var intObj4 = Math.round(document.getElementById("td6Net4").innerHTML*100)/100;
	if (isNaN(intObj0)){var intObj0=parseFloat(0.0);}
	if (isNaN(intObj1)){var intObj1=parseFloat(0.0);}
	if (isNaN(intObj2)){var intObj2=parseFloat(0.0);}
	if (isNaN(intObj3)){var intObj3=parseFloat(0.0);}
	if (isNaN(intObj4)){var intObj4=parseFloat(0.0);}
	var objS = document.getElementById("td6Sonuc");
	objS.style.display = "block";

	var intSonuc = ((intObj0 * 4.427645) + (intObj1 * 3.592635) + (intObj2 * 5.886394) + (intObj3 * 4.211150) + (intObj4 * 1.493070) + 177.421662)
	if(intSonuc==123.379312){
		objS.innerHTML = 0;
	}else{
		objS.innerHTML = "SBS PUANI : <span>" + setNumberFormat(intSonuc, 3) + "</span>";
	}
}

function setSBSFormTemizle(kac){
	for(var k=0;k<5;k++){
		document.getElementById("td" + kac + "Net" + k).innerHTML = "";
		document.getElementById("txt" + kac + "Y" + k).value = "";
		document.getElementById("txt" + kac + "D" + k).value = "";
	}
}