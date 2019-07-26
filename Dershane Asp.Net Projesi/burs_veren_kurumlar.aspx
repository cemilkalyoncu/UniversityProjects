<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="burs_veren_kurumlar.aspx.cs" Inherits="ygs_icerik_burs_veren_kurumlar" %>

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
                <strong>BURS VEREN KURUMLAR</strong>
		</span> <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
		 
		 <div><strong>&Ouml;ZEL KURUM VE KURULUŞLAR</strong></div>
<p>&nbsp;</p>
<p>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSourceBursKurumlari">
        <ItemTemplate>
            <div> <%#Eval("uzun_Metin") %></div>
        </ItemTemplate>
    </asp:Repeater>
    
    
    <asp:SqlDataSource ID="AccessDataSourceBursKurumlari" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
        SelectCommand="SELECT [uzun_Metin] FROM [uzunMetin] WHERE (([metin_id] = ?) AND ([Metin_Durum] = ?))">
        <SelectParameters>
            <asp:Parameter DefaultValue="9" Name="metin_id" Type="Int32" />
            <asp:Parameter DefaultValue="1" Name="Metin_Durum" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    
    
    <%--<strong>1) Abant İzzet Baysal &Uuml;niversitesi Araştırma ve Geliştirme Vakfı</strong></p>
<p>Başarılı ve maddi durumu yetersiz &ouml;ğrencilere burs veriliyor.&nbsp;<strong>Başvurular&nbsp;</strong>eğitim d&ouml;neminin başında yapılmaktadır.<br /> <strong>Tel:</strong>&nbsp;(0-374) 253 45 11 / 45 06</p>
<p>&nbsp;</p>
<p><strong>2) Adana Ticaret Odası Sosyal Hizmet Eğitim Vakfı</strong></p>
<p>Y&uuml;ksekokul ve &uuml;niversitelerde okuyan ve maddi desteğe ihtiya&ccedil; duyan, Adana&rsquo;na oturan başarılı &ouml;ğrencilere burs veriliyor. Burs m&uuml;racatları 1-31 Ekim tarihleri arasında yapılmaktadır, Ocak ayından itibaren 8 ay s&uuml;resince burs verilmektedir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.atosev.org.tr/burslar.html" target="_blank">http://www.atosev.org.tr/burslar.html</a><br /> <strong>Tel :&nbsp;</strong>(0-322) 232 59 13</p>
<p>&nbsp;</p>
<p><strong>3) Adıyaman K&uuml;lt&uuml;r Ve Eğitim Vakfı</strong></p>
<p>Bu bursa başvurabilmek i&ccedil;in anne veya babanın Adıyamanlı olması gerekmektedir. &Ouml;ğrencinin maddi durumunun yetersiz, ama aynı zamanda başarılı olması gerekmektedir. Son olarak m&uuml;lakat yapılmaktadır. Başvurular 15 Eyl&uuml;l&rsquo;dedir.&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-416) 213 47 30</p>
<p>&nbsp;</p>
<p><strong>4) Ağrı Eğitim ve K&uuml;lt&uuml;r Vakfı</strong></p>
<p>Maddi durumu yetersiz, anne veya babası Ağrı doğumlu olan &ouml;ğrencilere burs verilmektedir.&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-472) 215 39 58</p>
<p>&nbsp;</p>
<p><strong>5) Alarko Eğitim ve K&uuml;lt&uuml;r Vakfı</strong></p>
<p>Ekim ayında başlayan burslar 8 ay boyunca devam etmektedir. Verilecek burs miktarı her &ouml;ğretim yılı i&ccedil;in yeniden belirlenmektedir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.alarko.com.tr/alevwebformc1.doc" target="_blank">www.alarko.com.tr/alevwebformc1.doc</a>&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-212) 258 61 20</p>
<p>&nbsp;</p>
<p><strong>6) Ali Osman S&ouml;nmez Vakfı</strong></p>
<p>Vakıf sadece işletme alanında &ouml;ğrenim g&ouml;ren &ouml;ğrencilere burs vermektedir. Bursiyer adaylarının Bursalı ya da orta &ouml;ğrenimini Bursa&rsquo;da tamamlamış olması gerekmektedir.&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-224) 261 04 40</p>
<p>&nbsp;</p>
<p><strong>7) Ankara Bitlis Eğitim ve Tanıtma Vakfı</strong></p>
<p>1-31 Eyl&uuml;l tarihleri arasında başvurular yapılır. 4 yıllık fak&uuml;ltede okumak ve &ouml;ğrencinin anne ya da babasının Bitlisli olması şartı aranmaktadır.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 418 69 16</p>
<p>&nbsp;</p>
<p><strong>8) Ankara &Ccedil;ankaya Eğitim ve K&uuml;lt&uuml;r Vakfı</strong></p>
<p>Ankara&rsquo;daki &uuml;niversitelerin 4 yılık İİBF ve Fen Ebebiyat fak&uuml;ltelerinde okuyan &ouml;ğrencilere 8 ay boyunca burs verilmektedir. Başvuru kosulları Eyl&uuml;l ayında a&ccedil;ıklanmaktadır. Ekim ayında başvuruların yapılması gerekmektedir.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 438 05 43</p>
<p>&nbsp;</p>
<p><strong>9) Ankara Durak Eğitim &Ouml;ğrt. Day. ve Yar.Vakfı</strong></p>
<p>Ekim ayında burs başvuruları yapılmaktadır. 4 yıllık bir fak&uuml;ltede &ouml;ğrenci olmak yeterlidir.&nbsp;<br /> Adres: Z&uuml;beyde Hanım Mah.Sulug&ouml;z Sok.No:15/1 İskitler -ANKARA<br /> <strong>Tel:</strong>&nbsp;(0-312) 341 31 36</p>
<p>&nbsp;</p>
<p><strong>10) Ankara T&uuml;rkiye İnsan Kaynakları Vakfı</strong></p>
<p>&Uuml;niversite birinci sınıfı başarı ile tamamladıktan sonra Bireysel Gelişim Programı&rsquo;na kabul edilen &ouml;ğrenciler, fak&uuml;ltelerin ikinci akademik yılından başlayarak &uuml;&ccedil; yıl s&uuml;reyle her yıl Ekim - Haziran ayları arasında toplam sekiz ay aylık burs almaya hak kazanırlar. Burs miktarı her yıl Vakıf Y&ouml;netim Kurulu tarafından tespit edilir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.tikav.org.tr/bgpbasvuruformu.htm" target="_blank">http://www.tikav.org.tr/bgpbasvuruformu.htm</a><br /> <strong>Tel:</strong>&nbsp;(0-312) 442 4822-438 05 43</p>
<p>&nbsp;</p>
<p><strong>11) Asım Kocabıyık Vakfı</strong></p>
<p>Başarılı ve ihtiya&ccedil; sahibi &ouml;ğrencilere burs veren vakfın &ouml;nceliği yetim, &ouml;ks&uuml;z veya anne-babası ayrı olan &ouml;ğrencilere tanımaktadır. Bu burstan mezun oluncaya kadar yararlanmak i&ccedil;in yıllık not ortalamasının 4 &uuml;zerinden 2,5 olması gerekmektedir. Başvuru Ekim ayında yapılmaktadır. Vakıf ge&ccedil;tiğimiz yıllarda İstanbul &Uuml;niversitesi, İstanbul Teknik &Uuml;niversitesi, Boğazi&ccedil;i &Uuml;niversitesi ve Ortadoğu Teknik &Uuml;niversitesi; M&uuml;hendislik, İşletme ve İktisat b&ouml;l&uuml;m&uuml;nde okuyan &ouml;ğrencilere burs vermişti. Bu yıl ise hen&uuml;z bir a&ccedil;ıklama yapılmadı. Burs m&uuml;racaatı, s&ouml;z konusu okullara kayıt yaptırmış &ouml;ğrencilerin kendi okullarının burs ofislerine yapılmaktadır.&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-212) 251 34 10</p>
<p>&nbsp;</p>
<p><strong>12) Aydın Ticaret Odası</strong></p>
<p>Aydın Ticaret Odası, b&uuml;nyesinde kurulu bulunan Aydın Ticaret Odası &Ouml;ğrenci Okutma ve Eğitim Vakfı unvanlı kurumla, sadece Aydın&rsquo;da ikamet eden ve en az 4 yıllık y&uuml;ksek &ouml;ğretim kurumlarında &ouml;ğrenim g&ouml;ren &ouml;ğrencilere kredi verilmektedir.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-256) 213 22 02</p>
<p>&nbsp;</p>
<p><strong>13) &Ccedil;ağdaş Yaşamı Destekleme Derneği</strong></p>
<p>İstanbul i&ccedil;inde okuyan &uuml;niversite &ouml;ğrencilerine karşılıksız burs veriyor. Eyl&uuml;l&rsquo;&uuml;n ilk haftasında başvurulması gerekiyor.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.cydd.org.tr/nasilburs.asp" target="_blank">http://www.cydd.org.tr/nasilburs.asp</a><br /> <strong>Tel:&nbsp;</strong>(0-212) 252 44 33</p>
<p>&nbsp;</p>
<p><strong>14) Eskişehir Sanayi Odası</strong></p>
<p>Eskişehir veya Bilecik doğumlu, Eskişehir veya Bilecik il sınırları i&ccedil;inde yer alan bir liseden mezun olan ve M&uuml;hendislik ve İdari Bilimler Fak&uuml;ltesi&rsquo;ni kazanan 25 yaşını aşmamış başarılı &ouml;ğrencilere burs veriliyor. Başvurular, Eskişehir Sanayi Odası veya Eskişehir Kızılay Şube Başkanlığı&rsquo;ndan alınacak form ile Eskişehir Sanayi Odası&rsquo;na yapılmaktadır.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-222) 236 03 60</p>
<p>&nbsp;</p>
<p><strong>15) Faisal Finans Kurumu Vakfı</strong></p>
<p>Vakfın burs adayında aradığı şartlar; bir &uuml;st sınıfa ge&ccedil;erken bor&ccedil;lu dersi olmaması, başka vakıftan veya kurumdan burs almaması, disiplin su&ccedil;u işlememiş olması, savcılık tarafından hakkında soruşturma a&ccedil;ılmamış olması. Başvurular Ekim ayındadır.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-212) 251 65 20</p>
<p>&nbsp;</p>
<p><strong>16) Hacı &Ouml;mer Sabancı Vakfı</strong></p>
<p>Burs, y&uuml;ksek&ouml;ğrenim s&uuml;resince, Ekim ayında başlamak &uuml;zere, her yıl 9 aylık bir s&uuml;re i&ccedil;in karşılıksız, fakat geri &ouml;demeli olarak verilmektedir. Sabancı Vakfı bursları i&ccedil;in başvuruların ve gerekli belgelerin &ouml;ğrenci tarafından en ge&ccedil; 17 Ekim 2008 akşamına kadar kayıtlı olduğu &uuml;niversitenin &Ouml;ğrenci İşleri / Burs Ofisi&rsquo;ne teslim edilmesi gerekmektedir.&nbsp; Maddi desteğe ihtiyacı olan &ccedil;alışkan ve başarılı &ouml;ğrencilere y&uuml;ksek &ouml;ğrenimleri s&uuml;resince verilen ancak geri &ouml;deme y&uuml;k&uuml;ml&uuml;l&uuml;ğ&uuml; bulunan bursun adı Sosyal Ama&ccedil;lı Burs (SAB). Bu burs i&ccedil;in, &ouml;ğrencilerin &uuml;niversiteye giriş sınavında aldıkları puan ile bir &ouml;nceki okulda veya sonraki sınıflarda g&ouml;sterdikleri başarılar ve mali durumları dikkate alınmaktadır. Her yıl Eyl&uuml;l ayında &uuml;niversitelere g&ouml;nderilen ve gazetelerde yayınlanan duyuruların ardından başvuruda bulunanlara form g&ouml;nderilmekte ve gerekli koşulları taşıyan &ouml;ğrencilerin m&uuml;racaatları değerlendirilmektedir.&nbsp;<br /> Burslar ile ilgili sorularınız i&ccedil;in:&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-212) 385 89 01</p>
<p>&nbsp;</p>
<p><strong>17) İmam Hatip Liseleri Mezunları ve Mensupları Derneği (&Ouml;NDER)</strong></p>
<p>Dernek İmam Hatip Lisesi mezunu &ouml;ğrencilere burs vermektedir. Burs alabilecek &ouml;ğrencilerde belli kriterler arayan &Ouml;NDER&rsquo;in başarılı &ouml;ğrenciler i&ccedil;in yurt dışı bursları da bulunuyor. 2008-2009 yılı i&ccedil;in burs başvuruları başladı. İlgilenen &ouml;ğrenciler &Ouml;NDER&rsquo;in internet sitesinden başvuruda bulunabilir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.onder.org.tr/YaziGoster.asp?ID=80" target="_blank">http://www.onder.org.tr/YaziGoster.asp?ID=80</a>&nbsp;<br /> <strong>Tel:</strong>&nbsp;0 (212) 519 09 53</p>
<p>&nbsp;</p>
<p><strong>18) İstanbul Sanayi Odası Vakfı</strong></p>
<p>&Uuml;niversite ve meslek y&uuml;ksek okullarının teknik b&ouml;l&uuml;mlerinde okuyan &ouml;ğrencilere burs vermektedir. Burs verilecek adayı &ouml;ğrencinin &ouml;ğrenim g&ouml;rd&uuml;ğ&uuml; kurum se&ccedil;er ve vakıfa bildirir.</p>
<p>Web Adresi:&nbsp;<a href="http://www.isov.org.tr/tr/index.asp?page=burslar" target="_blank">http://www.isov.org.tr/tr/index.asp?page=burslar</a><br /> <strong>Tel:</strong>&nbsp;(0-212) 293 54 18-19</p>
<p>&nbsp;</p>
<p><strong>19) İstanbul Ticaret Borsası Vakfı</strong></p>
<p>Her yıl en fazla 23 kişiye karşılıksız burs vermektedir. İktisad b&ouml;l&uuml;mlerinden herhangi birinde okuma şartı aranmaktadır. &Ouml;ğrencilerin Marmara veya İstanbul &Uuml;niversitesi&rsquo;lerinden olmak zorunluluğu vardır. Başvurular Ekim ayındadır. Istanbul Ticaret Borsası Burs başvurusu yapmadan &ouml;nce Istanbul Ticaret Borsası orijinal websitesini ziyaret ediniz veya aşağıda belirtilen iletişim numarasını arayınız.<br /> <strong>Tel:&nbsp;</strong>(0-212) 511 84 40</p>
<p>&nbsp;</p>
<p><strong>20) İstanbul Ticaret Odası Vakfı</strong></p>
<p>Bursun miktarı her Aralık ayında değişmektedir. Aranılan şart; &ouml;ğrencinin maddi imk&acirc;nının yetersiz ve herhangi bir &uuml;niversitede iktisati ile ilgili b&ouml;l&uuml;mlerinden birinde okuyor olması.<br /> Web Adresi:&nbsp;<a href="http://www.ito.org.tr/itoportal/Dokuman/BursBasvuruFormu.doc" target="_blank">www.ito.org.tr/itoportal/Dokuman/BursBasvuruFormu.doc</a><br /> <strong>Tel:</strong>&nbsp;(0-212) 511 41 50</p>
<p>&nbsp;</p>
<p><strong>21) İzmir Ticaret Odası</strong></p>
<p>İzmir doğumlu, İzmir&rsquo;de ikamet eden veya İzmir&rsquo;deki &ouml;ğrenim kurumlarında &ouml;ğrenim g&ouml;ren &ouml;ğrencilere burs verilmektedir. Burs alacak olan &ouml;ğrencinin, başka bir kurum veya kuruluştan burs almaması, iktisadi desteğe ihtiya&ccedil; duyması ve başarılı bir &ouml;ğrenci olması gerekmektedir. Karşılıksız olan bursun ka&ccedil; &ouml;ğrenciye verileceği ve miktarı &ouml;ğrenim yılı başlamadan &ouml;nce y&ouml;netim kurulunca belirlenmektedir.&nbsp;<br /> E-mail:&nbsp;<a href="mailto:info@izto.org.tr" target="_blank">info@izto.org.tr</a>&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-232) 441 77 77</p>
<p>&nbsp;</p>
<p><strong>22) Kızılay Gen&ccedil;lik M&uuml;d&uuml;rl&uuml;ğ&uuml;</strong></p>
<p>Dernek&ccedil;e verilmekte olan karşılıksız burs yardımları, toplumsal yardıma muhta&ccedil;, kendi imkanları ile tahsil hayatlarını devam ettiremeyen &ouml;ğrencilere verilmektedir. &Ouml;ğrencinin başarılı olması ve sınıfta kalmamış olması gerekmektedir.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 430 23 00</p>
<p>&nbsp;</p>
<p><strong>23) Sağlık ve Eğitim Vakfı</strong></p>
<p>&Ouml;nceki yıllarda tıp fak&uuml;ltesinde okuyan ve 3.4.5 ve 6. sınıf &ouml;ğrencilerine burs veren vakıf ge&ccedil;tiğimiz yıl i&ccedil;in burs vermemişti. Bu yıl i&ccedil;in ise hen&uuml;z bir a&ccedil;ıklama yapılmadı. Tel: (0-216) 474 25 35<br /> <strong>E-mail:</strong>&nbsp;<a href="mailto:sevbilgi@sev.org.tr" target="_blank">sevbilgi@sev.org.tr</a></p>
<p>&nbsp;</p>
<p><strong>24) Sema Yazar Gen&ccedil;lik Vakfı</strong></p>
<p>Vakıf, her yıl &uuml;niversite &ouml;ğrencilerine katkıda bulunmak amacıyla burs vermektedir. Bursun devamlılığı her yıl başarılı olma koşuluna bağlıdır. Burs verilen &ouml;ğrencilerin herhangi bir kuruluştan burs ve yardım almıyor olması gerekmektedir. Burs talebinde bulunan başarılı ve maddi y&ouml;nden desteğe muhta&ccedil; &ouml;ğrencilerin vakıftan alacakları formu doldurarak Ekim ayı başına kadar m&uuml;racaat etmeleri gerekmektedir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.semayazar.org.tr/tr/burs.htmlTel" target="_blank">http://www.semayazar.org.tr/tr/burs.html</a>Tel: (0-312) 284 44 00</p>
<p>&nbsp;</p>
<p><strong>25) T&uuml;rk Diyanet Vakfı</strong></p>
<p>Yaklaşık olarak 200 &ouml;ğrenciye burs veriyor. Burs verilecek &ouml;ğrencinin babasının Diyanet İşleri personeli olması, anne ve babasından birisinin ya da ikisinin birden vefat etmiş olması, derslerinde başarılı olması ve kazandığı okulun ilk 5 tercihi arasında olması aranan koşullardır. Burs miktarı, burs adayının bu &ouml;zelliklerine ve puanına g&ouml;re belirlenmektedir. Başvurular Eyl&uuml;l ayındadır.&nbsp;<br /> Web Adresi:&nbsp;<a href="https://burs.diyanetvakfi.org.tr/" target="_blank">https://burs.diyanetvakfi.org.tr</a>&nbsp;<br /> Tel: (0-312) 417 12 35/557-558</p>
<p>&nbsp;</p>
<p><strong>26) T&uuml;rk Eğitim Vakfı</strong></p>
<p>Yaklaşık 5000 lisans ve lisans &uuml;st&uuml; &ouml;ğrenciye burs vermektedir. Yurti&ccedil;i burs i&ccedil;in başvurular Ekim ayı i&ccedil;inde &ouml;ğrenim g&ouml;r&uuml;len kuruma yapılabilir. Yurtdışı burslar i&ccedil;in başvurular ise TEV&rsquo;e yapılabilir. Atat&uuml;rk ilke ve inkılaplarına bağlı olmak, başarılı olmak burs almada &ouml;n plana &ccedil;ıkıyor. Burslara başvuru tarihi 1-31 Ekim&rsquo;dir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.tev.org.tr/" target="_blank">www.tev.org.tr</a>&nbsp;<br /> Tel: (0-212) 217 58 58</p>
<p>&nbsp;</p>
<p><strong>27) Yaşar Eğitim VakfıBaşvurular Ekim ayında yapılmaktadır. Toplam 150 &ouml;ğrenciye burs verilmektedir.</strong>&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.yasar.com.tr/vakif/egitim_burs.htm" target="_blank">http://www.yasar.com.tr/vakif/egitim_burs.htm</a>&nbsp;<br /> Tel: (0-232) 482 22 00</p>
<p>&nbsp;</p>
<p><strong>28) Yirmibirinci Y&uuml;zyıl Eğitim ve K&uuml;lt&uuml;r Vakfı</strong></p>
<p>Başarılı fakat eğitimlerini s&uuml;rd&uuml;r&uuml;rken zorlanan gen&ccedil;lere burs verilmektedir. 15 Eyl&uuml;l-15 Ekim arasında başvuran adaylar sıra numarasına g&ouml;re m&uuml;lakata alınmaktadır. Belli bir puanlamaya tabii tutulan adaylara daha sonra burs verilebilinmektedir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.yekuv.org/" target="_blank">http://www.yekuv.org/</a>&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-212) 288 9072 / 73 - 274 15 02</p>
<p>&nbsp;</p>
<p><strong>29) Yumlu Eğitim K&uuml;lt&uuml;r Ve Bilimsel Araştırma Vakfı</strong></p>
<p>Başarılı ve maddi desteğe gereksinimi olan &uuml;niversite &ouml;ğrencilere burs verilmektedir. &Ouml;SS sonu&ccedil;larına g&ouml;re vakıf&ccedil;a belirlenen fak&uuml;lteleri kazanan &ouml;ğrenciler Eyl&uuml;l sonuna kadar burs i&ccedil;in m&uuml;racat edebilmektedir. Genel olarak vakıf, bursiyerlerini İstanbul dışında yerleşik, &uuml;niversite sınavında ilk sıraları alacak kadar başarılı, yaşama &ccedil;ağdaş bir pencereden bakan, &uuml;lkenin orta ve alt gelir gruplarına mensup ailelerin &ccedil;ocukları arasından se&ccedil;ilmektedir.<br /> <strong>Tel:</strong>&nbsp;(0-216) 489 49 45</p>
<p>&nbsp;</p>
<p><strong>30) Y&uuml;z&uuml;nc&uuml; Yıl &Uuml;niversitesi Vakfı</strong></p>
<p>Burstan sadece Y&uuml;z&uuml;nc&uuml; Yıl &Uuml;niversitesi &ouml;ğrencileri faydalanabilmektedir. Başvurular Ekim ayındadır.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-432) 225 16 90</p>
<p>&nbsp;</p>
<div>&nbsp;</div>
<div><strong>BURS VEREN KAMU KURULUŞLARI</strong></div>
<div>&nbsp;</div>
<div>&nbsp;</div>
<div><strong>1) Ankara B&uuml;y&uuml;kşehir Belediyesi</strong></div>
<p>Ankara&rsquo;da dar gelirlilere, doğal afet mağdurlarına, şehit &ccedil;ocuklarına, &ouml;ks&uuml;z ve yetimlere verilen bursa 1-30 Ekim tarihleri arasında başvuruların yapılması gerekmektedir.<br /> Web Adresi:&nbsp;<a href="http://www.ankara-bel.gov.tr/" target="_blank">http://www.ankara-bel.gov.tr/</a>&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 310 83 87</p>
<p>&nbsp;</p>
<p><strong>2) Başbakanlık Sosyal Yardımlaşma ve Dayanışmayı Teşvik Fonu</strong></p>
<p>Ekim ayının son haftası ile Kasım ayının başında başvurulabilinir. A&ccedil;ık &ouml;ğretim fak&uuml;ltesi &ouml;ğrencileri dahil bu bursa t&uuml;m &uuml;niversite &ouml;ğrencileri başvurabilir. Başvuru formları, Y&uuml;ksek&ouml;ğretim Kredi ve Yurtlar Kurumu&rsquo;na (YKYK) bağlı b&ouml;lge ya da yurt m&uuml;d&uuml;rl&uuml;klerinden alınabilinir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.basbakanlik.gov.tr/" target="_blank">www.basbakanlik.gov.tr</a>&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 419 13 93 - 419 13 94</p>
<p>&nbsp;</p>
<p><strong>3) &Ccedil;alışma ve Sos. G&uuml;venlik Bakanlığı Erğ. K&ouml;m. Hav. Aml. Br. ve Yrd. San.</strong></p>
<p>Yardım i&ccedil;in sandık başkanlığına dilek&ccedil;eyle başvurmak gerekmektedir. Karşılıksız &ouml;ğrenim yardımı yapılmaktadır.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-372) 251 10 06</p>
<p>&nbsp;</p>
<p><strong>4) İstanbul B&uuml;y&uuml;kşehir Belediyesi</strong></p>
<p>1994 yılından bu yana İstanbul&rsquo;da eğitim g&ouml;ren &uuml;niversite &ouml;ğrencilerine burs veren İstanbul B&uuml;y&uuml;kşehir Belediyesi bu yıl hen&uuml;z burslarla ilgili a&ccedil;ıklama yapmadı. Ekim ayında burs başvurularının başlayacağı belirtiliyor. Burs başvurusunda bulunacak &ouml;ğrenciler İBB&rsquo;nin<a href="http://www.ibb.gov.tr/" target="_blank">www.ibb.gov.tr</a>&nbsp;adresinden yapılacak a&ccedil;ıklamayı takip edebilir ve buradan başvuruda bulunabilir.&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-212) 514 08 15</p>
<p>&nbsp;</p>
<p><strong>5) Milli Eğitim Bakanlığı</strong></p>
<p>Bakanlık, y&uuml;ksek&ouml;ğretim kurumlarının &ouml;ğretmen yetiştiren b&ouml;l&uuml;mlerinde okuyan &ouml;ğrencilere burs desteği sağlamaktadır. Hangi b&ouml;l&uuml;mden ka&ccedil; &ouml;ğrenciye ne kadar burs verileceği her &ouml;ğrenim yılı başında belirlenmektedir. MEB&rsquo;in bursları, mecburi hizmet karşılığında verilmekte olunup, burslu &ouml;ğrenci mezun olduğunda &ouml;ğretmen olarak doğrudan g&ouml;reve alınmaktadır. Milli Eğitim Bakanı H&uuml;seyin &Ccedil;elik, ge&ccedil;tiğimiz g&uuml;nlerde yaptığı a&ccedil;ıklamada &uuml;niversitelerin eğitim fak&uuml;ltelerinde okuyan &ouml;ğrenciler i&ccedil;in verilen bursun bu yıl da devam edeceğini bildirmişti. Ancak bakanlığın sitesinde burs başvurularıyla ilgili herhangi bir a&ccedil;ıklama yapılmadı. Bakanlığın &ouml;n&uuml;m&uuml;zdeki g&uuml;nlerde<a href="http://www.meb.gov.tr/" target="_blank">www.meb.gov.tr</a>&nbsp;adresinden burslarla ilgili gerekli a&ccedil;ıklamayı yapması bekleniyor.&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 425 53 30</p>
<p>&nbsp;</p>
<p><strong>6) T&Uuml;BİTAK</strong></p>
<p>Yerleştirildiği b&ouml;l&uuml;m&uuml;n gerektirdiği puan t&uuml;r&uuml; esas olmak &uuml;zere matematik ve fen ağırlıklı puana g&ouml;re yapılan sıralamada ilk 1000 &ouml;ğrenci arasına girenlerden, temel bilimler b&ouml;l&uuml;mlerine (matematik, fizik, kimya, biyoloji, molek&uuml;ler biyoloji ve genetik) kayıt yaptıran T.C. vatandaşı &ouml;ğrencilere karşılıksız ve sınavsız burs verilmektedir. Ancak, Kredi ve Yurtlar Kurumu dışında herhangi bir yerden burs alanlara aylık burs &ouml;demesi yapılmaz. Yalnız, yılda iki kez (Kasım ve Mart aylarında) birer aylık burs tutarında kitap desteği sağlanmaktadır. Başvuru tarihleri &uuml;niversite sınav sonu&ccedil;larının ardından ilan edilmektedir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.tubitak.gov.tr/home.do?ot=1&sid=455&pid=453" target="_blank">http://www.tubitak.gov.tr/home.do?ot=1&amp;sid=455&amp;pid=453</a>&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-312) 468 53 00</p>
<p>&nbsp;</p>
<p><strong>7) T&uuml;rk Dil Kurumu</strong></p>
<p>&Ouml;SS sınavında s&ouml;zel puan sıralamasında ilk 2000&prime;e giren ve T&uuml;rk dili ve edebiyatı veya &ccedil;ağdaş T&uuml;rk leh&ccedil;eleri ve edebiyatları b&ouml;l&uuml;mlerinden birini se&ccedil;en &ouml;ğrencilerin 15&prime;ine verilmektedir. Bu yıl burslarla ilgili bir a&ccedil;ıklama yapılmazken, kurumun &ouml;n&uuml;m&uuml;zdeki g&uuml;nlerde kendi web sitesinden a&ccedil;ıklama yapması bekleniyor.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.tdk.gov.tr/" target="_blank">www.tdk.gov.tr</a>&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 467 73 50</p>
<p>&nbsp;</p>
<p><strong>8) T&uuml;rk Silahlı Kuvvetleri</strong></p>
<p>TSK Personel Kanunu gereklerine g&ouml;re verilen burstan subay olarak yetiştirilmek &uuml;zere fak&uuml;lte ve y&uuml;ksek okulda okuyan &ouml;ğrencilere askeri &ouml;ğrenci stat&uuml;s&uuml;nde yararlandırılmaktadır.<br /> Web Adresi:&nbsp;<a href="http://www.tsk.mil.tr/" target="_blank">www.tsk.mil.tr</a>&nbsp;<br /> <strong>Tel:&nbsp;</strong>(0-312) 417 61 00</p>
<p>&nbsp;</p>
<p><strong>9) Y&uuml;ksek &Ouml;ğrenim Kredi ve Yurtlar Kurumu</strong></p>
<p>Yurti&ccedil;inde t&uuml;m &uuml;niversitelerde ve y&uuml;ksek okullarda okuyan &ouml;ğrencilere &ouml;ğrenim kredisi ve katkı (har&ccedil;) kredisi adı altında bor&ccedil; olarak verilmektedir.&nbsp;<br /> Web Adresi:&nbsp;<a href="http://www.kyk.gov.tr/" target="_blank">www.kyk.gov.tr</a>&nbsp;<br /> <strong>Tel:</strong>&nbsp;(0-312) 431 11 00--%></p>
		 
		<div style="clear:both"></div>
  
       </div>
	  
	</div>		
	      
		 
		 
	  
	  

    <div style="width:962px; height:250px; overflow:hidden; margin:auto; ">
	
	
	
	
	</div>



    </div>

</asp:Content>

