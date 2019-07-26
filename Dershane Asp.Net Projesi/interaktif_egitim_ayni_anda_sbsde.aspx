<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="interaktif_egitim_ayni_anda_sbsde.aspx.cs" Inherits="sbs_haberler_interaktif_egitim_ayni_anda_sbsde" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div style="padding:20px;width:780px;background:#fff; height:auto; overflow:hidden;float:left; margin:auto; ">

		<div class="haber_">
		<span style="color:#013682; font-size:14px;">
                <strong>İnteraktif Eğitim Aynı Anda SBS&#39;de!</strong>
		</span> <br />
		<img src="../../KResimler/slicer_border.jpg" width=755 height=1 style="padding:0px 0px 10px 0px ">
		
        <p>

<h3> Lazio 7/24 Online ! </h3>
<br />
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
                    <asp:Parameter DefaultValue="1" Name="metin_id" Type="Int32" />
            <asp:Parameter DefaultValue="1" Name="Metin_Durum" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

<%--Lazio artık her zaman, her yerde sizinle olacak. Evinizde,cep telefonunuzda,internet bağlantısı olan her yerde.
 
Lazio öğrencileri dersane dışında da istediği zaman istediği yerden bilgiye ulaşabilir.
 
Konu eksikiğiniz mi var? Çözemediğiniz deneme sınavı soruları mı var? Tek ihtiyacınız olan internet bağlantısı. Girin sayfamıza, konu anlatımlarını dinleyin. Girin sayfamıza, çözemediğiniz deneme sınavı sorularının çözümlerine ulaşın.
 
Çözemediğiniz soru kalmayacak. Lazio Dersaneleri uzman öğretmenlerinin görüntülü ve sesli çözümleriyle daima sizinle olacağız.Her zaman,her yerde dilediğiniz kadar bilgiye ulaşabileceksiniz.
 
Öğrencilerimiz derslerde işlenen tüm konuların anlatımını her zaman,istedikleri her yerden,istedikleri kadar bilgisayar ortamında dinleyip tekrar yapabilirler.
Tüm Deneme Sınavı sorularının öğretmenler tarafından yapılmış çözümlerini izleyebilirler.
Öğrencilerimiz anlayamadıkları bölümü geri alıp yeniden izleyebilir.
Bu programda soru çözümü yapan öğrenci,soru ekrana geldiğinde akışı durdurup kendisi soruyu çözdükten sonra devam ettrerek doğru çözüp çözmediğini kontrol edebilir.
Bu hizmetimiz,sürekli ve kesintisiz hizmet veren ikinci bir dersane özelliği taşır.--%></p>
		</div>
		

	 
    </div>

</asp:Content>

