<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sbs.aspx.cs" Inherits="sbs_sbs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div style="padding:10px;width:780px;background:#fff; height:auto; overflow:hidden;float:left; margin:auto; ">
<div id="sbs_ygs_left">
<ul id="ygs_sbs_detay">
	
		<li><a href="sbs_puan_hesaplama.aspx"> SBS PUAN HESAPLAMA </a></li>
	
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
                <strong>SBS </strong>
		</span> <br />
		<img src="../KResimler/slicer_border.jpg" width=755 height=1 style="padding:0px 0px 10px 0px ">
		
		 
	<p>
         <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSourceMetin">
                <ItemTemplate>
        <div> <%#Eval("uzun_Metin") %></div>
                </ItemTemplate>
            </asp:Repeater>
            
            <asp:SqlDataSource ID="AccessDataSourceMetin" runat="server" 
                ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vtb.accdb"
                ProviderName="System.Data.OleDb" 
                SelectCommand="SELECT [uzun_Metin] FROM [uzunMetin] WHERE (([metin_id] = ?) AND ([Metin_Durum] = ?))">
                <SelectParameters>
                    <asp:Parameter DefaultValue="2" Name="metin_id" Type="Int32" />
                    <asp:Parameter DefaultValue="1" Name="Metin_Durum" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        
        
        
        <%--Her ders için yıl boyunca pekiştirme programları,  Her sınavdan sonra konu analizi ve analiz dersleri, Değerlendirme sonuçlarına göre grup dersleri ve bire bir çalışmalar, Sınavlara yönelik zengin döküman, kaynak ve Soru Bankaları, İnteraktif Eğitim, SBS eşdeğerinde Lazio DENEME SINAVLARI, Sınava girecek öğrencilere Lazio DERGİLERİ ve Ödüllü Lazio Yerleştirme Sınavları.

1974'den günümüze bilgi ve birikime dayalı öğretim programları ile deneyimli, bilgili, yetkin öğretim ve yönetim kadrosu ile SBS ye Lazio'da hazırlanın.	<div style="clear:both"></div>
 --%> 
    </p>   </div>
	  
		<div  class="progDesc sinavHaber">
		<h3 style="margin:10px 0px">Haberler</h3>
		
		
		 
		<p> &#9679;  <a href="interaktif_egitim_ayni_anda_sbsde.aspx" >İnteraktif Eğitim Aynı Anda SBS&#39;de! Bilgi almak için buradan ulaşabilrisiniz tıklayın... </a> &nbsp; | &nbsp;
			(2012-07-19 )
		</p>
		
		
		
		
		
		 
		<p> &#9679;  <a href="sbs_rehberlik.aspx" >SBS Rehberlik . Buradan haber detayına ulaşabilirsiniz tıklayın... </a> &nbsp; | &nbsp;
			(2012-07-19 )
		</p>
		
		
		
		
		
		 
		<p> &#9679;  <a href="8_sinif_kurs_programi.aspx" >8. Sınıf Kurs Programı Açıklanmıştır buradan ulaşabilrisiniz </a> &nbsp; | &nbsp;
			(2012-07-19 )
		</p>	
		
		</div>		
      
		 
	</div>	 


    </div>

	</div>
</asp:Content>

