<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 439px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           
    <div id="fetched_content">
	
		<span style="color:#013682; font-size:14px;">
                <strong>İLETİŞİM</strong>
		</span> 
		<ul class="duzsayfa_altbaslik"></ul><div style="clear:both"></div> 
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">

        <p><div id="iletisim">
<h3>LAZİO DERSANELERİ GENEL MERKEZ</h3>
<br /> 
<table border="0">
<tbody>
<tr>
<td valign="top" class="auto-style3">
<ul>
<li><strong>Adres :</strong><asp:Label ID="iletisimadres" runat="server"></asp:Label>
    </li>
<li><strong>PK:</strong>
    <asp:Label ID="pk" runat="server"></asp:Label>
    </li>
<li><strong>Tel: </strong>
    <asp:Label ID="tel" runat="server"></asp:Label>
    </li>
<li><strong>Fax:</strong>&nbsp;<asp:Label ID="fax" runat="server"></asp:Label>
    </li>
<li><strong>E-posta:</strong> 
    <asp:Label ID="eposta" runat="server"></asp:Label>
    </li>
<li><strong>Yeni Şube Başvurusu:</strong> 
    <asp:Label ID="sube" runat="server"></asp:Label>
    </li>
</ul>
</td>
<td rowspan="7">
    <asp:Label ID="map" runat="server" ></asp:Label></td>
</tr>
</tbody>
</table>
<br /><br />
<h3>LAZİO YAYINLARI İLETİŞİM</h3>
<br /> 
<table border="0">
<tbody>
<tr>
<td width="435" valign="top">
<ul>
<li><strong>Adres:</strong>&nbsp;<asp:Label ID="adrestext" runat="server"></asp:Label>
    </li>
<li><strong>Telefon:</strong>
    <asp:Label ID="tel2" runat="server"></asp:Label>
    </li>
<li><strong>Faks:</strong>
    <asp:Label ID="fax2" runat="server"></asp:Label>
    </li>
<li><strong>E-posta:</strong>
    <asp:Label ID="eposta2" runat="server"></asp:Label>
    </li>
</ul>
</td>
<td><small><br /><br /></small></td>
</tr>
</tbody>
</table>
</div>
<div><br />
<h3>DİLEK İSTEK FORMU</h3>

<div class="dilek_form">
<div><label for="dilek_adi">Adınız:</label><asp:TextBox ID="textBox_Adi" runat="server"></asp:TextBox></div>
<div><label for="dilek_soyadi">Soyadınız:</label><asp:TextBox ID="textBox_Soyadi" runat="server"></asp:TextBox></div>
<div><label for="dilek_email">E-Mail Adresi:</label><asp:TextBox ID="textBox_E_Posta" runat="server"></asp:TextBox></div>
<div><label for="dilek_telefon">Telefon Numarası:</label><asp:TextBox ID="textBox_Telefon" runat="server"></asp:TextBox></div>
<div><label for="dilek_mesaj">Mesajınız:</label><asp:TextBox ID="textBox_Mesaj" TextMode="MultiLine" Height="40px" Width="220px" runat="server"></asp:TextBox></div>
<div><label for="dilek_gonder"></label><asp:Button ID="Button_Gonder" runat="server" Text="Gönder" OnClick="Button1_Click" /></div>
<div><label for="dilek_ileti"></label><asp:Label ID="Label_ileti" runat="server"></asp:Label></div>
</div>

</div></p>





    </div>
               
</asp:Content>

