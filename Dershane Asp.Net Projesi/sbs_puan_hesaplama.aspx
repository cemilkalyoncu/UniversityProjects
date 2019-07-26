<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sbs_puan_hesaplama.aspx.cs" Inherits="sbs_icerik_sbs_puan_hesaplama" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

    <div style="padding:20px;width:780px;background:#fff; height:auto; overflow:hidden;float:left; margin:auto; ">
<div id="sbs_ygs_left">

	<ul id="ygs_sbs_detay">
	<li><a href="sbs_puan_hesaplama.aspx"> SBS PUAN HESAPLAMA </a></li>
	</ul>
	
	
	<ul id="Ul1">
	<li><a href="sbs_sistemi.aspx"> SBS SİSTEMİ </a></li>
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
                <strong>SBS PUAN HESAPLAMA</strong>
		</span> <br />
		
		 <img src="../../KResimler/slicer_border.jpg" width=755 height=1 style="padding:0px 0px 10px 0px ">
		 <!--8.sınıf i&ccedil;in-->
<p>8. SINIF SBS PUAN HESAPLAMA</p>
<table class="ygslys" border="2" cellspacing="0" cellpadding="0" width="100%" bordercolor="#ffffff">
<tbody>
<tr align="center" bgcolor="#013682">
<td>SBS</td>
<td>T&Uuml;R<br />(23)</td>
<td>MAT<br />(20)</td>
<td>FEN<br />(20)</td>
<td>SOS<br />(20)</td>
<td>DİL<br />(17)</td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>DOĞRU SAYISI</td>
<td><input id="txt8D0" onkeyup="getSBSNet('txt8D0', 'txt8Y0', 'td8Net0', 23, this);" maxlength="2" name="txt8D0" size="1" type="text" value="0" /></td>
<td><input id="txt8D1" onkeyup="getSBSNet('txt8D1', 'txt8Y1', 'td8Net1', 20, this);" maxlength="2" name="txt8D1" size="1" type="text" value="0" /></td>
<td><input id="txt8D2" onkeyup="getSBSNet('txt8D2', 'txt8Y2', 'td8Net2', 20, this);" maxlength="2" name="txt8D2" size="1" type="text" value="0" /></td>
<td><input id="txt8D3" onkeyup="getSBSNet('txt8D3', 'txt8Y3', 'td8Net3', 20, this);" maxlength="2" name="txt8D3" size="1" type="text" value="0" /></td>
<td><input id="txt8D4" onkeyup="getSBSNet('txt8D4', 'txt8Y4', 'td8Net4', 17, this);" maxlength="2" name="txt8D4" size="1" type="text" value="0" /></td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>YANLIŞ SAYISI</td>
<td><input id="txt8Y0" onkeyup="getSBSNet('txt8D0', 'txt8Y0', 'td8Net0', 23, this);" maxlength="2" name="txt8Y0" size="1" type="text" value="0" /></td>
<td><input id="txt8Y1" onkeyup="getSBSNet('txt8D1', 'txt8Y1', 'td8Net1', 20, this);" maxlength="2" name="txt8Y1" size="1" type="text" value="0" /></td>
<td><input id="txt8Y2" onkeyup="getSBSNet('txt8D2', 'txt8Y2', 'td8Net2', 20, this);" maxlength="2" name="txt8Y2" size="1" type="text" value="0" /></td>
<td><input id="txt8Y3" onkeyup="getSBSNet('txt8D3', 'txt8Y3', 'td8Net3', 20, this);" maxlength="2" name="txt8Y3" size="1" type="text" value="0" /></td>
<td><input id="txt8Y4" onkeyup="getSBSNet('txt8D4', 'txt8Y4', 'td8Net4', 17, this);" maxlength="2" name="txt8Y4" size="1" type="text" value="0" /></td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>NETLER</td>
<td id="td8Net0" align="center">&nbsp;</td>
<td id="td8Net1" align="center">&nbsp;</td>
<td id="td8Net2" align="center">&nbsp;</td>
<td id="td8Net3" align="center">&nbsp;</td>
<td id="td8Net4" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
<table border="0">
<tbody>
<tr height="40">
<td id="td8Sonuc" class="sbsSonuc" style="display:none;" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
<p><input onclick="getSBS8Hes();" name="button2" type="button" value="Hesapla" /> <input onclick="    setSBSFormTemizle(8);" name="button1" type="reset" value="Temizle" /></p>
<!--8. bitti-->
<p>&nbsp;</p>
<!--7.sınıf i&ccedil;in-->
<p>7. SINIF SBS PUAN HESAPLAMA</p>
<table class="ygslys" border="2" cellspacing="0" cellpadding="0" width="100%" bordercolor="#ffffff">
<tbody>
<tr align="center" bgcolor="#013682">
<td>SBS</td>
<td>T&Uuml;R<br />(21)</td>
<td>MAT<br />(18)</td>
<td>FEN<br />(18)</td>
<td>SOS<br />(18)</td>
<td>DİL<br />(15)</td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>DOĞRU SAYISI</td>
<td><input id="txt7D0" class="tx" onkeyup="getSBSNet('txt7D0', 'txt7Y0', 'td7Net0', 21, this);" maxlength="2" name="txt7D0" size="1" type="text" value="0" /></td>
<td><input id="txt7D1" class="tx" onkeyup="getSBSNet('txt7D1', 'txt7Y1', 'td7Net1', 18, this);" maxlength="2" name="txt7D1" size="1" type="text" value="0" /></td>
<td><input id="txt7D2" class="tx" onkeyup="getSBSNet('txt7D2', 'txt7Y2', 'td7Net2', 18, this);" maxlength="2" name="txt7D2" size="1" type="text" value="0" /></td>
<td><input id="txt7D3" class="tx" onkeyup="getSBSNet('txt7D3', 'txt7Y3', 'td7Net3', 18, this);" maxlength="2" name="txt7D3" size="1" type="text" value="0" /></td>
<td><input id="txt7D4" class="tx" onkeyup="getSBSNet('txt7D4', 'txt7Y4', 'td7Net4', 15, this);" maxlength="2" name="txt7D4" size="1" type="text" value="0" /></td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>YANLIŞ SAYISI</td>
<td><input id="txt7Y0" class="tx" onkeyup="getSBSNet('txt7D0', 'txt7Y0', 'td7Net0', 21, this);" maxlength="2" name="txt7Y0" size="1" type="text" value="0" /></td>
<td><input id="txt7Y1" class="tx" onkeyup="getSBSNet('txt7D1', 'txt7Y1', 'td7Net1', 18, this);" maxlength="2" name="txt7Y1" size="1" type="text" value="0" /></td>
<td><input id="txt7Y2" class="tx" onkeyup="getSBSNet('txt7D2', 'txt7Y2', 'td7Net2', 18, this);" maxlength="2" name="txt7Y2" size="1" type="text" value="0" /></td>
<td><input id="txt7Y3" class="tx" onkeyup="getSBSNet('txt7D3', 'txt7Y3', 'td7Net3', 18, this);" maxlength="2" name="txt7Y3" size="1" type="text" value="0" /></td>
<td><input id="txt7Y4" class="tx" onkeyup="getSBSNet('txt7D4', 'txt7Y4', 'td7Net4', 15, this);" maxlength="2" name="txt7Y4" size="1" type="text" value="0" /></td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>NETLER</td>
<td id="td7Net0">&nbsp;</td>
<td id="td7Net1">&nbsp;</td>
<td id="td7Net2">&nbsp;</td>
<td id="td7Net3">&nbsp;</td>
<td id="td7Net4">&nbsp;</td>
</tr>
</tbody>
</table>
<table border="0">
<tbody>
<tr height="40">
<td id="td7Sonuc" class="sbsSonuc" style="display:none;" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
<p><input onclick="getSBS7Hes();" name="button2" type="button" value="HESAPLA" /> <input onclick="    setSBSFormTemizle(7);" name="button1" type="reset" value="TEMİZLE" /></p>
<!--7. bitti-->
<p>&nbsp;</p>
<!--6.sınıf i&ccedil;in-->
<p>6. SINIF SBS PUAN HESAPLAMA</p>
<table class="ygslys" border="2" cellspacing="0" cellpadding="0" width="100%" bordercolor="#ffffff">
<tbody>
<tr align="center" bgcolor="#013682">
<td>SBS</td>
<td>T&Uuml;R<br />(19)</td>
<td>MAT<br />(16)</td>
<td>FEN<br />(16)</td>
<td>SOS<br />(16)</td>
<td>DİL<br />(13)</td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>DOĞRU SAYISI</td>
<td><input id="txt6D0" class="tx" onkeyup="getSBSNet('txt6D0', 'txt6Y0', 'td6Net0', 19, this);" maxlength="2" name="txt6D0" size="1" type="text" value="0" /></td>
<td><input id="txt6D1" class="tx" onkeyup="getSBSNet('txt6D1', 'txt6Y1', 'td6Net1', 16, this);" maxlength="2" name="txt6D1" size="1" type="text" value="0" /></td>
<td><input id="txt6D2" class="tx" onkeyup="getSBSNet('txt6D2', 'txt6Y2', 'td6Net2', 16, this);" maxlength="2" name="txt6D2" size="1" type="text" value="0" /></td>
<td><input id="txt6D3" class="tx" onkeyup="getSBSNet('txt6D3', 'txt6Y3', 'td6Net3', 16, this);" maxlength="2" name="txt6D3" size="1" type="text" value="0" /></td>
<td><input id="txt6D4" class="tx" onkeyup="getSBSNet('txt6D4', 'txt6Y4', 'td6Net4', 13, this);" maxlength="2" name="txt6D4" size="1" type="text" value="0" /></td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>YANLIŞ SAYISI</td>
<td><input id="txt6Y0" class="tx" onkeyup="getSBSNet('txt6D0', 'txt6Y0', 'td6Net0', 19, this);" maxlength="2" name="txt6Y0" size="1" type="text" value="0" /></td>
<td><input id="txt6Y1" class="tx" onkeyup="getSBSNet('txt6D1', 'txt6Y1', 'td6Net1', 16, this);" maxlength="2" name="txt6Y1" size="1" type="text" value="0" /></td>
<td><input id="txt6Y2" class="tx" onkeyup="getSBSNet('txt6D2', 'txt6Y2', 'td6Net2', 16, this);" maxlength="2" name="txt6Y2" size="1" type="text" value="0" /></td>
<td><input id="txt6Y3" class="tx" onkeyup="getSBSNet('txt6D3', 'txt6Y3', 'td6Net3', 16, this);" maxlength="2" name="txt6Y3" size="1" type="text" value="0" /></td>
<td><input id="txt6Y4" class="tx" onkeyup="getSBSNet('txt6D4', 'txt6Y4', 'td6Net4', 13, this);" maxlength="2" name="txt6Y4" size="1" type="text" value="0" /></td>
</tr>
<tr class="ygslysalt" height="40" align="center" bgcolor="#F6F6F6">
<td>NETLER</td>
<td id="td6Net0">&nbsp;</td>
<td id="td6Net1">&nbsp;</td>
<td id="td6Net2">&nbsp;</td>
<td id="td6Net3">&nbsp;</td>
<td id="td6Net4">&nbsp;</td>
</tr>
</tbody>
</table>
<table border="0">
<tbody>
<tr height="40">
<td id="td6Sonuc" class="sbsSonuc" style="display:none;" height="50" align="center">&nbsp;</td>
</tr>
</tbody>
</table>
<p><input onclick="getSBS6Hes();" name="button2" type="button" value="HESAPLA" /> <input onclick="    setSBSFormTemizle(6);" name="button1" type="reset" value="TEMİZLE" /></p>
<!--6. bitti-->
		 
		<div style="clear:both"></div>
  
       </div>
	  
	</div>		
	      
    </div>

	</div>
</asp:Content>

