<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="misyonumuz.aspx.cs" Inherits="duzSayfa_problemli_misyonumuz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="fetched_content">
	
		<span style="color:#013682; font-size:14px;">
                <strong>MİSYONUMUZ</strong>
		</span> 
		<ul class="duzsayfa_altbaslik"><li class="first"><a href="hakkimizda.aspx">Hakkımızda</a> </li><li><a href="kurumsal_kimlik.aspx">Kurumsal Kimlik</a> </li><li><a href="misyonumuz.aspx">Misyonumuz</a> </li><li><a href="vizyonumuz.aspx">Vizyonumuz</a> </li></ul><div style="clear:both"></div> 
		<img src="../KResimler/slicer_border.jpg" width=755 height=1 style="padding:0px 0px 10px 0px ">

        <p style="text-align: justify; ">

    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSourceMisyonumuz">
        <ItemTemplate>
            <div> <%#Eval("uzun_Metin") %></div>
        </ItemTemplate>
    </asp:Repeater>

            <asp:SqlDataSource ID="AccessDataSourceMisyonumuz" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                SelectCommand="SELECT [uzun_Metin] FROM [uzunMetin] WHERE (([metin_id] = ?) AND ([Metin_Durum] = ?))">
        <SelectParameters>
            <asp:Parameter DefaultValue="3" Name="metin_id" Type="Int32" />
            <asp:Parameter DefaultValue="1" Name="Metin_Durum" Type="String" />
        </SelectParameters></asp:SqlDataSource>


        <%--<div style="text-align: justify; ">
<p>Eğitim ve &ouml;ğretim alanında benimsenen değerler ve uluslararası standartlar doğrultusunda, &ccedil;alışanlarına ve &ccedil;evreye karşı sorumluluk bilinciyle; y&uuml;k&uuml;ml&uuml;l&uuml;ğ&uuml;m&uuml;z gereği toplumun beklentilerini ger&ccedil;ekleştiren</p>
<p><strong>Lazio Dersaneleri&rsquo;nin</strong></p>
<p><br /> <strong>Misyonu;</strong></p>
<p><strong><br /></strong></p>
<ul>
<li>Eğitimde de daha iyiyi,  daha g&uuml;zeli ve daha doğruyu arayışı s&uuml;rd&uuml;rmek</li>
<li>Okuma alışkanlığı edinmiş, sorgulayarak &ouml;ğrenen &ouml;ğrendiklerini yaşama aktarabilen, &uuml;retken, &ouml;zg&uuml;r d&uuml;ş&uuml;nceli araştırıcı bir gen&ccedil;lik yetiştirmek</li>
<li>&Ccedil;ağdaş kuşaklar yetiştirerek T&uuml;rkiye&rsquo;nin gelişmesinde etkin olmanın onurunu yaşamak</li>
<li>Takım &ccedil;alışmasıyla katılımcı ve paylaşımcı bir y&ouml;ntemde olmak</li>
<li>Evrensel değerlere saygılı, toplam kalite y&ouml;netimi ilkelerini benimsemiş, s&uuml;rekli gelişen bir kurum olmak</li>
<li>Bireyi bir b&uuml;t&uuml;n olarak algılayıp eğitim-&ouml;ğretim kalitesini y&uuml;kselterek yaşamına katkıda bulunmak</li>
<li>&Ouml;ğrencisinin sahip olduğu yetenekleri ortaya &ccedil;ıkaran, geliştiren; akademik başarısını y&uuml;kselten, &ccedil;alışmalarıyla etkin &ouml;nc&uuml; bir kurum olmak</li>
<li>Araştırmacı, uygulayıcı, geliştirici ve yaratıcı d&uuml;ş&uuml;nebilen bireyler yetiştirmek</li>
</ul>
</div>--%>
         
        </p>

    </div>
    <div>     
    </div>



</asp:Content>

