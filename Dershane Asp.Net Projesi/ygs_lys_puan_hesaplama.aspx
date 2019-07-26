<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ygs_lys_puan_hesaplama.aspx.cs" Inherits="ygs_icerik_ygs_lys_puan_hesaplama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div style="padding:10px;width:780px;background:#fff; height:auto; overflow:hidden;float:left; margin:auto; ">
<div id="sbs_ygs_left">

	<ul id="ygs_sbs_detay">
	<li><a href="burs_veren_kurumlar.aspx"> BURS VEREN KURUMLAR </a></li>
	</ul>	
	
	<ul id="Ul2">
	<li><a href="lys_puani_ile_4_yillik_programlar.aspx"> LYS PUANI İLE 4 YILLIK PROGRAMLAR </a></li>
	</ul>
	
	
	<ul id="Ul3">
	<li><a href="ygs_lys_puan_hesaplama.aspx"> YGS - LYS Puan Hesaplama </a></li>
	</ul>

	
	<ul id="Ul6">
	<li><a href="ygs_puan_turlerine_gore_ogrenci_alan_myo.aspx"> YGS PUAN TÜRLERİNE GÖRE ÖĞRENCİ ALAN MYO </a></li>
	</ul>
	
	
</div>
		<style type="text/css">
			.progDesc{font-size:12px;color:#666;background:#FFF;margin-bottom:5px}
			.progDesc a{color:#666;}
			.progDesc a:hover{text-decoration:underline}
		</style>
	  
 <div id="sbs_ygs_right">     
      
       <div class="progDesc">
		
		<span style="color:#013682; font-size:14px;">
                <strong>YGS - LYS Puan Hesaplama</strong>
		</span> <br />
		<img src="../../static/images/slicer_border.jpg" width=755 height=1 style="padding:0px 0px 10px 0px ">
		 
		 <!--YGS Tablo--> 
<table class="ygslys" border="1" cellspacing="0" cellpadding="0" width="100%" bordercolor="#ffffff">
<tbody>
<tr bgcolor="#013682">
<td>&nbsp;&nbsp;&nbsp;YGS</td>
<td align="center">T&uuml;rk&ccedil;e<br />(Dil ve Anlatım)<br />(40)</td>
<td align="center">Temel Matematik<br />(40)</td>
<td align="center">Sosyal Bilimler<br />(40)</td>
<td align="center">Fen Bilimleri<br />(40)</td>
</tr>
<tr class="ygslysalt" height="35" bgcolor="#F6F6F6">
<td>&nbsp;&nbsp;&nbsp;DOĞRU</td>
<td align="center"><input id="ygsd_0" class="tx" onkeyup="getNet('ygsd_0','ygsy_0','tdYGSN0',40,this);" maxlength="2" name="ygsd_0" size="2" type="text" /></td>
<td align="center"><input id="ygsd_1" class="tx" onkeyup="getNet('ygsd_1','ygsy_1','tdYGSN1',40,this);" maxlength="2" name="ygsd_1" size="2" type="text" /></td>
<td align="center"><input id="ygsd_2" class="tx" onkeyup="getNet('ygsd_2','ygsy_2','tdYGSN2',40,this);" maxlength="2" name="ygsd_2" size="2" type="text" /></td>
<td align="center"><input id="ygsd_3" class="tx" onkeyup="getNet('ygsd_3','ygsy_3','tdYGSN3',40,this);" maxlength="2" name="ygsd_3" size="2" type="text" /></td>
</tr>
<tr class="ygslysalt" height="35" bgcolor="#F6F6F6">
<td>&nbsp;&nbsp;&nbsp;YANLIŞ</td>
<td align="center"><input id="ygsy_0" class="tx" onkeyup="getNet('ygsd_0','ygsy_0','tdYGSN0',40,this);" maxlength="2" name="ygsy_0" size="2" type="text" /></td>
<td align="center"><input id="ygsy_1" class="tx" onkeyup="getNet('ygsd_1','ygsy_1','tdYGSN1',40,this);" maxlength="2" name="ygsy_1" size="2" type="text" /></td>
<td align="center"><input id="ygsy_2" class="tx" onkeyup="getNet('ygsd_2','ygsy_2','tdYGSN2',40,this);" maxlength="2" name="ygsy_2" size="2" type="text" /></td>
<td align="center"><input id="ygsy_3" class="tx" onkeyup="getNet('ygsd_3','ygsy_3','tdYGSN3',40,this);" maxlength="2" name="ygsy_3" size="2" type="text" /></td>
</tr>
<tr class="ygslysalt" height="35" bgcolor="#F6F6F6">
<td>&nbsp;&nbsp;&nbsp;NETLER</td>
<td id="tdYGSN0" align="center">&nbsp;</td>
<td id="tdYGSN1" align="center">&nbsp;</td>
<td id="tdYGSN2" align="center">&nbsp;</td>
<td id="tdYGSN3" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
<!--YGS Gizli sonu&ccedil; kısmı--> 
<table id="tdYGSHes" class="ygslys" style="display: none;" border="0" cellspacing="1" cellpadding="1" width="100%">
<tbody>
<tr bgcolor="#013682">
<td rowspan="3" width="200px" align="center">YGS</td>
<td colspan="2" width="130px" align="center">SAY-1</td>
<td colspan="2" width="130px" align="center">S&Ouml;Z-1</td>
<td colspan="2" width="130px" align="center">EAĞ-1</td>
</tr>
<tr class="ygslysalt" bgcolor="#F6F6F6">
<td align="center">1</td>
<td align="center">2</td>
<td align="center">3</td>
<td align="center">4</td>
<td align="center">5</td>
<td align="center">6</td>
</tr>
<tr class="ygslysalt" bgcolor="#F1F1F1">
<td id="tdYGSG1" align="center">&nbsp;</td>
<td id="tdYGSG2" align="center">&nbsp;</td>
<td id="tdYGSG3" align="center">&nbsp;</td>
<td id="tdYGSG4" align="center">&nbsp;</td>
<td id="tdYGSG5" align="center">&nbsp;</td>
<td id="tdYGSG6" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
<!--YGS Gizli tablo bitiş--> <!--YGS Tablo bitiş--> <!--LYS Tablo--> 
<table class="ygslys" border="2" cellspacing="0" cellpadding="0" width="100%" bordercolor="#ffffff">
<caption><strong>YGS NETLERİ GEREKLİ</strong></caption> 
<tbody>
<tr bgcolor="#013682">
<td align="center">LYS</td>
<td align="center">MAT<br />(50)</td>
<td align="center">GEO<br />(30)</td>
<td align="center">FİZ<br />(30)</td>
<td align="center">KİM<br />(30)</td>
<td align="center">BİY<br />(30)</td>
<td align="center">EDB<br />(56)</td>
<td align="center">COĞ1<br />(24)</td>
<td align="center">TAR<br />(44)</td>
<td align="center">COĞ2<br />(14)</td>
<td align="center">FEL<br />(24)</td>
<td align="center">DİN<br />(8)</td>
<td align="center">YD<br />(80)</td>
</tr>
<tr class="ygslysalt" height="35" bgcolor="#F6F6F6">
<td>&nbsp;&nbsp;&nbsp;DOĞRU SAYISI</td>
<td align="center"><input id="lysd_0" class="tx" onkeyup="getNet('lysd_0','lysy_0','tdLYSN0',50,this);" maxlength="2" name="lysd_0" size="1" type="text" /></td>
<td align="center"><input id="lysd_1" class="tx" onkeyup="getNet('lysd_1','lysy_1','tdLYSN1',30,this);" maxlength="2" name="lysd_1" size="1" type="text" /></td>
<td align="center"><input id="lysd_2" class="tx" onkeyup="getNet('lysd_2','lysy_2','tdLYSN2',30,this);" maxlength="2" name="lysd_2" size="1" type="text" /></td>
<td align="center"><input id="lysd_3" class="tx" onkeyup="getNet('lysd_3','lysy_3','tdLYSN3',30,this);" maxlength="2" name="lysd_3" size="1" type="text" /></td>
<td align="center"><input id="lysd_4" class="tx" onkeyup="getNet('lysd_4','lysy_4','tdLYSN4',30,this);" maxlength="2" name="lysd_4" size="1" type="text" /></td>
<td align="center"><input id="lysd_5" class="tx" onkeyup="getNet('lysd_5','lysy_5','tdLYSN5',56,this);" maxlength="2" name="lysd_5" size="1" type="text" /></td>
<td align="center"><input id="lysd_6" class="tx" onkeyup="getNet('lysd_6','lysy_6','tdLYSN6',24,this);" maxlength="2" name="lysd_6" size="1" type="text" /></td>
<td align="center"><input id="lysd_7" class="tx" onkeyup="getNet('lysd_7','lysy_7','tdLYSN7',44,this);" maxlength="2" name="lysd_7" size="1" type="text" /></td>
<td align="center"><input id="lysd_8" class="tx" onkeyup="getNet('lysd_8','lysy_8','tdLYSN8',14,this);" maxlength="2" name="lysd_8" size="1" type="text" /></td>
<td align="center"><input id="lysd_9" class="tx" onkeyup="getNet('lysd_9','lysy_9','tdLYSN9',24,this);" maxlength="2" name="lysd_9" size="1" type="text" /></td>
<td align="center"><input id="lysd_11" class="tx" onkeyup="getNet('lysd_11','lysy_11','tdLYSN11',8,this);" maxlength="2" name="lysd_11" size="1" type="text" /></td>
<td align="center"><input id="lysd_10" class="tx" onkeyup="getNet('lysd_10','lysy_10','tdLYSN10',80,this);" maxlength="2" name="lysd_10" size="1" type="text" /></td>
</tr>
<tr class="ygslysalt" height="35" bgcolor="#F6F6F6">
<td>&nbsp;&nbsp;&nbsp;YANLIŞ SAYISI</td>
<td align="center"><input id="lysy_0" class="tx" onkeyup="getNet('lysd_0','lysy_0','tdLYSN0',50,this);" maxlength="2" name="lysy_0" size="1" type="text" /></td>
<td align="center"><input id="lysy_1" class="tx" onkeyup="getNet('lysd_1','lysy_1','tdLYSN1',30,this);" maxlength="2" name="lysy_1" size="1" type="text" /></td>
<td align="center"><input id="lysy_2" class="tx" onkeyup="getNet('lysd_2','lysy_2','tdLYSN2',30,this);" maxlength="2" name="lysy_2" size="1" type="text" /></td>
<td align="center"><input id="lysy_3" class="tx" onkeyup="getNet('lysd_3','lysy_3','tdLYSN3',30,this);" maxlength="2" name="lysy_3" size="1" type="text" /></td>
<td align="center"><input id="lysy_4" class="tx" onkeyup="getNet('lysd_4','lysy_4','tdLYSN4',30,this);" maxlength="2" name="lysy_4" size="1" type="text" /></td>
<td align="center"><input id="lysy_5" class="tx" onkeyup="getNet('lysd_5','lysy_5','tdLYSN5',56,this);" maxlength="2" name="lysy_5" size="1" type="text" /></td>
<td align="center"><input id="lysy_6" class="tx" onkeyup="getNet('lysd_6','lysy_6','tdLYSN6',24,this);" maxlength="2" name="lysy_6" size="1" type="text" /></td>
<td align="center"><input id="lysy_7" class="tx" onkeyup="getNet('lysd_7','lysy_7','tdLYSN7',44,this);" maxlength="2" name="lysy_7" size="1" type="text" /></td>
<td align="center"><input id="lysy_8" class="tx" onkeyup="getNet('lysd_8','lysy_8','tdLYSN8',14,this);" maxlength="2" name="lysy_8" size="1" type="text" /></td>
<td align="center"><input id="lysy_9" class="tx" onkeyup="getNet('lysd_9','lysy_9','tdLYSN9',24,this);" maxlength="2" name="lysy_9" size="1" type="text" /></td>
<td align="center"><input id="lysy_11" class="tx" onkeyup="getNet('lysd_11','lysy_11','tdLYSN11',8,this);" maxlength="2" name="lysy_11" size="1" type="text" /></td>
<td align="center"><input id="lysy_10" class="tx" onkeyup="getNet('lysd_10','lysy_10','tdLYSN10',80,this);" maxlength="2" name="lysy_10" size="1" type="text" /></td>
</tr>
<tr class="ygslysalt" height="35" bgcolor="#F6F6F6">
<td>&nbsp;&nbsp;&nbsp;NETLER</td>
<td id="tdLYSN0" align="center">&nbsp;</td>
<td id="tdLYSN1" align="center">&nbsp;</td>
<td id="tdLYSN2" align="center">&nbsp;</td>
<td id="tdLYSN3" align="center">&nbsp;</td>
<td id="tdLYSN4" align="center">&nbsp;</td>
<td id="tdLYSN5" align="center">&nbsp;</td>
<td id="tdLYSN6" align="center">&nbsp;</td>
<td id="tdLYSN7" align="center">&nbsp;</td>
<td id="tdLYSN8" align="center">&nbsp;</td>
<td id="tdLYSN9" align="center">&nbsp;</td>
<td id="tdLYSN11" align="center">&nbsp;</td>
<td id="tdLYSN10" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
<!--LYS gizli sonuc tablo--> 
<table id="tdLGSHes" class="ygslys" style="display:none;" border="0" cellspacing="0" cellpadding="0" width="100%">
<tbody>
<tr>
<td colspan="4">&nbsp;</td>
</tr>
<tr>
<td>
<table class="tx" border="0" cellspacing="1" cellpadding="1" width="200px">
<tbody>
<tr valign="top">
<td>
<table class="tx" border="0" cellspacing="1" cellpadding="1" width="100%">
<tbody>
<tr bgcolor="#013682">
<td colspan="4" align="center">MF Puanları</td>
</tr>
<tr bgcolor="#013682">
<td colspan="4" align="center">SAYISAL-2</td>
</tr>
<tr bgcolor="#013682">
<td width="25%" align="center">1</td>
<td width="25%" align="center">2</td>
<td width="25%" align="center">3</td>
<td width="25%" align="center">4</td>
</tr>
<tr class="ygslysalt" bgcolor="#F1F1F1">
<td id="tdLGSMF1" align="center">&nbsp;</td>
<td id="tdLGSMF2" align="center">&nbsp;</td>
<td id="tdLGSMF3" align="center">&nbsp;</td>
<td id="tdLGSMF4" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
<td>
<table class="tx" border="0" cellspacing="1" cellpadding="1" width="170px">
<tbody>
<tr bgcolor="#013682">
<td colspan="3" align="center">TM Puanları</td>
</tr>
<tr bgcolor="#013682">
<td colspan="3" align="center">EAĞ-2</td>
</tr>
<tr bgcolor="#013682">
<td width="33%" align="center">1</td>
<td width="33%" align="center">2</td>
<td width="33%" align="center">3</td>
</tr>
<tr class="ygslysalt" bgcolor="#F1F1F1">
<td id="tdLGSTM1" align="center">&nbsp;</td>
<td id="tdLGSTM2" align="center">&nbsp;</td>
<td id="tdLGSTM3" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
</td>
<td>
<table class="tx" border="0" cellspacing="1" cellpadding="1" width="170px">
<tbody>
<tr bgcolor="#013682">
<td colspan="2" align="center">TS Puanları</td>
</tr>
<tr bgcolor="#013682">
<td colspan="2" align="center">S&Ouml;Z-2</td>
</tr>
<tr bgcolor="#013682">
<td align="center">1</td>
<td align="center">2</td>
</tr>
<tr class="ygslysalt" bgcolor="#F1F1F1">
<td id="tdLGSTS1" align="center">&nbsp;</td>
<td id="tdLGSTS2" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
</td>
<td>
<table class="tx" border="0" cellspacing="1" cellpadding="1" width="170px">
<tbody>
<tr bgcolor="#013682">
<td colspan="3" align="center">Y.Dil Puanları</td>
</tr>
<tr bgcolor="#013682">
<td colspan="3" align="center">Y.DİL</td>
</tr>
<tr bgcolor="#013682">
<td align="center">1</td>
<td align="center">2</td>
<td align="center">3</td>
</tr>
<tr class="ygslysalt" bgcolor="#F1F1F1">
<td id="tdLGSYD1" align="center">&nbsp;</td>
<td id="tdLGSYD2" align="center">&nbsp;</td>
<td id="tdLGSYD3" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--LYS Tablo bitiş-->
<p><input onclick="getYGSGenel();" name="button2" type="button" value="HESAPLA" /> <input onclick="    setYGSFormTemizle();" name="button1" type="reset" value="TEMİZLE" /></p>
		 
		<div style="clear:both"></div>
  
       </div>
	  
	</div>		
	      
		 
		 
	  
	  

    <div style="width:962px; height:250px; overflow:hidden; margin:auto; ">
	
	
	
	
	</div>



    </div>

	



	</div>
</asp:Content>

