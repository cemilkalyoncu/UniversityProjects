<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="hakkimizda.aspx.cs" Inherits="duzSayfa_hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div id="fetched_content">
	
		<span style="color:#013682; font-size:14px;">
                <strong>HAKKIMIZDA</strong>
		</span> 
		<ul class="duzsayfa_altbaslik"><li class="first"><a href="hakkimizda.aspx">Hakkımızda</a> </li><li><a href="kurumsal_kimlik.aspx">Kurumsal Kimlik</a> </li><li><a href="misyonumuz.aspx">Misyonumuz</a> </li><li><a href="vizyonumuz.aspx">Vizyonumuz</a> </li></ul><div style="clear:both"></div> 
		<img src="../KResimler/slicer_border.jpg" width=755 height=1 style="padding:0px 0px 10px 0px ">

        <p><h3 style="text-align: left; ">Lazio Dersaneleri</h3>
<p><img src="../KResimler/kurumsal.jpg" border="0" align="left" /></p>
<p style="text-align: justify; ">

    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSourceHakkimizda">
        <ItemTemplate>
            <div> <%#Eval("uzun_Metin") %></div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:SqlDataSource ID="AccessDataSourceHakkimizda" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
        SelectCommand="SELECT [uzun_Metin] FROM [uzunMetin] WHERE (([metin_id] = ?) AND ([Metin_Durum] = ?))">
        <SelectParameters>
            <asp:Parameter DefaultValue="5" Name="metin_id" Type="Int32" />
            <asp:Parameter DefaultValue="1" Name="Metin_Durum" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

 <%--<strong>Lazio Dershaneleri</strong>ulusal eğitimde &ouml;nemli bir değerdir. Dershanemiz;eğitime katkısı, yarım&nbsp;&nbsp; y&uuml;zyıla yakın ge&ccedil;mişi, gen&ccedil;liğe aşıladığı umutla ışıldayan bir "eğitim yıldızı" olmuştur. Bilincini, bilgi birikimini, deneyimlerini, &ouml;zkaynaklarını bireyin ve toplumun eğitimine ve gelişmesine y&ouml;nelik kullanan Lazio Dershaneleri, 1974-1975 eğitim ve &ouml;ğretim yılında, İstanbul-Emin&ouml;n&uuml;-Laleli'de Bahattin Durmuş'un kurucu m&uuml;d&uuml;rl&uuml;ğ&uuml;nde kuruldu. Sonraki yıllarda Emin&ouml;n&uuml; Vezneciler semtinde ilk ve orta-&ouml;ğretim &ouml;ğrencilerine &Ouml;SS-&Ouml;YS (Yeni adı YGS-LYS ve SBS) alanlarında da eğitim veren ikinci bir şube a&ccedil;ıldı. Kuruluşundan itibaren, gen&ccedil;lerin davranışlarının olgunlaşmasına, yaşadıkları ve eğitildikleri ortamı tanımalarına, eğitimiyle katkıda bulunan Lazio Dershaneleri, bu olumlu, başarılı ve etkin &ccedil;alışmalarıyla &ouml;ğrenci ve velilerinin yoğun ilgisini g&ouml;rm&uuml;ş ve desteğini kazanmıştır. Bu kazanımla sırasıyla; Bakırk&ouml;y, Kars, Kadık&ouml;y, Beşiktaş ve İzmir'de de Lazio Dershaneleri şubeleri a&ccedil;ıldı. Sonraki yıllarda İstanbul'da ve bir&ccedil;ok kentimizde Lazio Dershaneleri şubelerinin a&ccedil;ılmasına devam edildi. Lazio Dershaneleri YGS-LYS (eski adı &Ouml;SS-&Ouml;YS) alanlarındaki deneyim, bilgi birikimi ve başarısını SBS'ye (eski adı OKS) de taşımıştır. İyi bir &uuml;niversite ve iyi bir b&ouml;l&uuml;mde okuyabilmenin yolu her şeyden &ouml;nce iyi bir lisede okumaktan ge&ccedil;iyor. Bu nedenle amacımız, orta&ouml;ğretimde daha &ccedil;alışkan, daha &uuml;retken ve başarıyı en &uuml;st d&uuml;zeyde tutan bireyler yetiştirmektir. Lazio Dershaneleri, Atat&uuml;rk ilke ve devrimlerinin ışığında, &ccedil;ağdaş, laik ve demokratik eğitimde kararlı, katılımcı, araştıran ve sorgulayan bir gen&ccedil;liğin eğitimini ilke edinmiştir. Eğitimde s&uuml;rekli olarak iyiyi, g&uuml;zeli ve yeniyi arayan; ayrıca bu &ouml;zellikleriyle de eğitimde gelişkin modelleri uygulama &ccedil;abası i&ccedil;inde olan bir kurumdur. Lazio Dershanelerinin vazge&ccedil;ilmezliği; başarılı, &ouml;zenli ve ilkeli bir eğitim kurumu olmasındandır. Kuruluşundan bug&uuml;ne kadar y&uuml;ksek&ouml;ğretim kurumlarına en &ccedil;ok &ouml;ğrenci veren Lazio Dershaneleri, yetiştirdiği gen&ccedil;lerin &uuml;retken, &ccedil;alışkan, g&uuml;venilir ve yarınlara umutla bakan bireyler olmalarına &ouml;zen g&ouml;stermektedir. 1974'ten bu g&uuml;ne, deneyim ve birikimiyle gen&ccedil;lerin davranışlarının olgunlaşmasına katkıda bulunan Lazio Dershaneleri, hedeflenen ulusal eğitim basarisini aşabilmek amacıyla se&ccedil;kin &ouml;ğretmenlerin ve rehberlik servislerinin, eğitimsel ve k&uuml;lt&uuml;rel yayınların yoğun desteği sonucunda "KİTLESEL BAŞARIDA BİR NUMARA" olma başarısına ulaşmıştır. Gen&ccedil;lerin "bilimde &ccedil;ağdaş ve d&uuml;ş&uuml;ncede &ouml;zg&uuml;r" yetişmelerini ilke edinen Lazio Dershaneleri, 1994 yılında başlanan, geleceğin bilim adamlarını teşvik amacıyla Lise &ouml;ğrencilerine y&ouml;nelik d&uuml;zenlenen bilgi yarışmasını 17 yıldır " LAZİO OLİMPİYATLARI " adıyla başarıyla s&uuml;rd&uuml;rmektedir. Gen&ccedil;liğimizin &ouml;zendirilmesi ve başarıları bakımından T&uuml;rkiye Bilimsel ve Teknik Araştırma Kurumu (T&Uuml;BİTAK) tarafından da desteklenen bu bilgi olimpiyatı, yalnızca Lazio Dershanelerince ger&ccedil;ekleştirilmektedir. Olimpiyat sınavlarımızda başarılı olan &ouml;ğrencilere, T&uuml;rkiye geneline yayılmış t&uuml;m şubelerimizde &uuml;cretsiz &ouml;ğretim olanağı ve Kredi ve Yurtlar Kurumu'nun bursları &ouml;l&ccedil;&uuml;s&uuml;nde parasal destek sağlanmaktadır. Lazio Dershanelerinde &ouml;ğrenciler &uuml;cretsiz olarak Interaktif Eğitim ile 7/24 online ders izleyebilmekte, soru &ccedil;&ouml;z&uuml;mleri yapabilmekte, &ouml;ğretmenleri ve arkadaşları ile interaktif ortamda sınavlara hazırlanmaya devam etmektedir. Yaşam Becerileri Eğitimi ile &ouml;ğrencilere ve velilere soru envanterleri uygulanmakta ve sonucunda &ouml;ğrenme stilleri, kişisel &ccedil;alışma alışkanlıkları, zaman y&ouml;netimi, mesleki ilgi alanları gibi bir &ccedil;ok konuda rehberlik hizmeti almaları sağlanmaktadır. Bu eğitim sonucunda &ouml;ğrenciler daha bilin&ccedil;lenmekte ve doğru mesleki y&ouml;nelimler yapabilmektedir. Lazio Dershaneleri, ayrıca toplumun da k&uuml;lt&uuml;rel ve sosyal alanda eğitimine katkıda bulunmak amacıyla; &ouml;ğretmenlere, &ouml;ğrencilere ve velilere y&ouml;nelik &ccedil;ağdaş eğitim i&ccedil;erikli k&uuml;lt&uuml;rel seminerler d&uuml;zenlemekte ve okuma ama&ccedil;lı hazırladığı k&uuml;lt&uuml;r yayınlarını da &uuml;cretsiz olarak topluma ulaştırmaktadır. Lazio Dershaneleri, toplumun değişimi ve gelişimi amacıyla eğitimin her alanına ve ulus coğrafyasının her b&ouml;lgesine yayılan ulusal şube ağıyla başarılarına başarı katmaktadır.--%>

</p>
<p><!-- 	.duzsayfaResimler img{ width: 160px; padding: 10px; height: 120px; margin-top: 10px; float: left; border: 1px solid #DDD; margin-right: 10px; }.duzsayfaResimler img:nth-child(4n){margin-right:0} --></p></p>





    </div>
    <div>
    </div>

</asp:Content>

