<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kurumsal.aspx.cs" Inherits="duzSayfa_kurumsal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="fetched_content">
	
		<span style="color:#013682; font-size:14px;">
                <strong>KURUMSAL</strong>
		</span> 
		<ul class="duzsayfa_altbaslik"><li class="first"><a href="hakkimizda.aspx">Hakkımızda</a> </li><li><a href="kurumsal_kimlik.aspx">Kurumsal Kimlik</a> </li><li><a href="misyonumuz.aspx">Misyonumuz</a> </li><li><a href="vizyonumuz.aspx">Vizyonumuz</a> </li></ul><div style="clear:both"></div> 
		<img src="../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">

        <p>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSourceKurumsal">
                <ItemTemplate>
                    <div> <%#Eval("uzun_Metin") %></div>
                </ItemTemplate>
            </asp:Repeater>
            

            
            <asp:SqlDataSource ID="AccessDataSourceKurumsal" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                SelectCommand="SELECT [uzun_Metin] FROM [uzunMetin] WHERE (([metin_id] = ?) AND ([Metin_Durum] = ?))">
                <SelectParameters>
                    <asp:Parameter DefaultValue="6" Name="metin_id" Type="Int32" />
                    <asp:Parameter DefaultValue="1" Name="Metin_Durum" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            
            
            
            
            
            
            
<%--            <p>Lazio Dersaneleri 1974-1975 eğitim ve &ouml;ğretim yılında, İstanbul-Emin&ouml;n&uuml;-Laleli&rsquo;de Sayın Bahattin Durmuş tarafından kuruldu. Sonraki yıllarda Emin&ouml;n&uuml; Vezneciler semtinde ilk ve orta-&ouml;ğretim &ouml;ğrencilerine y&ouml;nelik ikinci bir şube a&ccedil;ıldı. Kuruluşundan itibaren, gen&ccedil;lerin davranışlarının olgunlaşmasına, yaşadıkları ve eğitildikleri ortamı tanımalarına, eğitimiyle katkıda bulunan Lazio Dershaneleri, bu olumlu, başarılı ve etkin &ccedil;alışmalarıyla &ouml;ğrenci ve velilerinin yoğun ilgisini g&ouml;rm&uuml;ş ve desteğini kazanmıştır. Bu kazanımla sırasıyla; Bakırk&ouml;y, Kars, Kadık&ouml;y, Beşiktaş ve İzmir&rsquo;de de Lazio Dershaneleri şubeleri a&ccedil;ıldı. Sonraki yıllarda İstanbul&rsquo;da ve bir&ccedil;ok kentimizde Lazio Dershaneleri şubelerinin a&ccedil;ılmasına devam edildi.Kuruluşu izleyen 37 yıl i&ccedil;inde Lazio Dersaneleri T&uuml;rkiye&rsquo;nin en b&uuml;y&uuml;k ve en g&uuml;venilir zincir dersanelerinden biri haline gelmiştir. &ldquo;Kitlesel Başarıda 1 numara&rdquo; olma iddiasını,  mevcudunun b&uuml;y&uuml;k bir b&ouml;l&uuml;m&uuml;n&uuml;, hazırlık hizmeti verdiği sınavları kazandırarak, her yıl kanıtlamaktadır.</p>
<p>Lazio Dersaneleri bu g&uuml;n şubelerine, &Ccedil;eyrek asrı aşan birikimle oluşan Lazio know-how&rsquo;ını sunarken, kurum rutinimiz,  AR-GE &ccedil;alışmaları ile de hizmet kalitesinin s&uuml;rekli geliştirilmesine devam etmektedir.</p>
<p>T&uuml;m SBS, LYS ve YGS yayınlarımız Bloom Taksonomisine g&ouml;re ve sınavlar baz alınarak alanlarında uzman &ouml;ğretmenlerce hazırlanmaktadır.  2008-2009 &ouml;ğretim yılında itibaren uygulamaya koyduğumuz &ldquo;Yaşam Becerileri Eğitimi&rdquo; ile de &ouml;ğrencilerimiz aynı zamanda hayata da hazırlanmaktadır. Diğer taraftan eğitim kalitemizi, &ouml;ğrencilerimizle zaman ve mekandan bağımsız olarak buluşturan eLazio sistemimizle &ouml;ğrencilerimiz 7 g&uuml;n 24 saat d&uuml;nyanın her yerinden senkronize yada asenkronize derslere katılabilmekte, online sınavlara girebilmekte tekrar isteyebilmekte yani dersanede aldığı her hizmeti dersane dışında da sanal olarak alabilmektedir.</p>
<p>Lazio Dersaneleri kurumsal olarak en iyi hizmeti &uuml;retmeye odaklanmakta, sekt&ouml;re s&uuml;rekli yenilikler kazandırmakta ve &ouml;ğrencinin daha etkili eğitilebilmesi adına şubelerinin kullanımına sunmaktadır. T&uuml;m bu arg&uuml;manlar k&ouml;kl&uuml; yayın birikimi ve &Ouml;ğrenci merkezli eğitim ve tanıtım stratejileri Lazio şubelerine &ouml;nemli bir rekabet avantajı sağlamaktadır.</p>
<p>Her bir Lazio Şubesi, bulunduğu b&ouml;lgenin en değerli &ouml;ğretmenleri ve idari kadrosuyla y&uuml;ksek kalitede eğitim hizmeti sunar.</p>--%>
        </p>




    </div>
    <div>          
    </div>


</asp:Content>

