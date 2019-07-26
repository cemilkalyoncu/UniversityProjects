<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="sliderWrapper">
			<div id="images">

              <%--  <asp:Repeater ID="Repeater4" runat="server" DataSourceID="AccessDataSourceSlider">
                    <ItemTemplate>
                       
                         <img src='<%#Eval("resim_url")%>'alt="" />
                         
 
                        
                        </ItemTemplate>
                </asp:Repeater>
              
                <asp:SqlDataSource ID="AccessDataSourceSlider" runat="server" 
                    ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vtb.accdb" 
                    ProviderName="System.Data.OleDb" 
                    SelectCommand="SELECT [resim_url] FROM [sliderResim]">

                </asp:SqlDataSource>--%>
              
            <a href="https://www.facebook.com/Lazio1461">
		      
		        <img src="../Resimler/3c0862130903c78adc7d47d5c809e1f0.jpg" width="800" height="350" alt="" />
		      
		    </a>

                

                    <a href="#">
		      
		        <img src="../Resimler/687316439c4b8e14283391ecc62f83ee.jpg" width="800" height="350" alt="" />
		      
		    </a>

                

                    <a href="#">
		      
		        <img src="../Resimler/9e80945647ea2e6010d25f42678783a2.jpg" width="800" height="350" alt="" />
		      
		    </a>

                

                    <a href="#">
		      
		        <img src="../Resimler/0f81fa4b71ffc5d0387fc7caec4a508b.jpg" width="800" height="350" alt="" />
		      
		    </a>

                    <a href="#">
		      
		        <img src="../Resimler/e503fdce89795713cd3a6e5a8f813ba9.jpg" width="800" height="350" alt="" />
		      
		    </a>

                    <a href="#">
		      
		        <img src="../Resimler/b59963c0917742dd29a2edea733b4abb.jpg" width="800" height="350" alt="" />
		      
		    </a>

                    <a href="#">
		      
		        <img src="../Resimler/b05d5ec5718a46def8e884e3ce1b2f67.jpg" width="800" height="350" alt="" />
		      
		    </a>

                    <a href="#">
		      
		        <img src="../Resimler/bd05eb6e73b21dd3e3ac1ca02c44af80.jpg" width="800" height="350" alt="" />
		      
		    </a> 
                               
			</div>
        
			<div id="descriptions">
				
				
			</div>
			<div id="thumbnails">
				<!-- yon okları -->
				<ul></ul>
			</div>
			<div class="right_arrow"></div>
			<div class="left_arrow"></div>
		</div>
    <div  id="sinavlar" style="height:280px; background:#d0e3ea;"> 
			
						<div class="news">
							<span style="color:#013682; font-size:14px;">
							<strong>İnteraktif Eğitim</strong></span><br />
							<span style="color:#6c90d4; font-size:12px;">
							Lazio artık her yerde !</span><br />
							<a target="blank" href="#" style="color:#666">
                            
                            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSource">
                            <ItemTemplate>
                                <div>
                                    <img src='<%#Eval("resim_url")%>'alt="" style="width:255px" />
                                </div>
                            </ItemTemplate>
                            </asp:Repeater>
                                  	
							<asp:SqlDataSource ID="AccessDataSource" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:ConnectionString6 %>" 
                                ProviderName="<%$ ConnectionStrings:ConnectionString6.ProviderName %>" 
                                SelectCommand="SELECT [resim_url] FROM [DefaultResim] WHERE (([resim_ad] = ?) AND ([resim_durum] = ?))">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="r1" Name="resim_ad" Type="String" />
                                    <asp:Parameter DefaultValue="1" Name="resim_durum" Type="String" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                                  	
							<%--<img src="../Resimler/student1.jpg" style="width:255px" alt="" />--%>

							<p>Lazio artık her zaman, her yerde sizinle olacak.
							Evinizde,cep telefonunuzda,internet bağlantısı
							olan her yerde. Lazio öğrencileri dersane dışında
							da istediği zaman istediği yerden bilgiye ulaşabilir.</p>
							</a>
							<a target="blank" href="#">
							<div class="continue" style="float:none;width:40px;">
								Devam
							</div>
							</a>
						</div>
						<div class="news">
							<span style="color:#013682; font-size:14px;">
							<strong>SBS</strong></span><br />
							<span style="color:#6c90d4; font-size:12px;">
							SBS'ye deneyimli kadromuzla hazırlanın</span><br />
							<a href="sbs.aspx" style="color:#666">

                            <asp:Repeater ID="Repeater2" runat="server" DataSourceID="AccessDataSource2">
                                <ItemTemplate>
                                <div>
                                    <img src='<%#Eval("resim_url")%>'alt="" style="width:255px" />
                                </div>
                            </ItemTemplate>
                            </asp:Repeater>

							<asp:SqlDataSource ID="AccessDataSource2" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:ConnectionString4 %>" 
                                ProviderName="<%$ ConnectionStrings:ConnectionString4.ProviderName %>" 
                                SelectCommand="SELECT [resim_url] FROM [DefaultResim] WHERE (([resim_ad] = ?) AND ([resim_durum] = ?))">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="r2" Name="resim_ad" Type="String" />
                                    <asp:Parameter DefaultValue="1" Name="resim_durum" Type="String" />
                                </SelectParameters>
                            </asp:SqlDataSource>

							<%--<img src="../Resimler/student2.jpg" style="width:255px" alt="" />--%>
								
                                						<p>Her ders için yıl boyunca pekiştirme programları, 
							Her sınavdan sonra konu analizi ve analiz dersleri,
							Değerlendirme sonuçlarına göre grup dersleri ve
							bire bir çalışmalar ...</p>
							</a>
							<a href="sbs.aspx">
							<div class="continue" style="float:none;width:40px;">
								Devam
							</div>
							</a>
						</div>
						<div class="news">
							<span style="color:#013682; font-size:14px;">
							<strong>YGS - LYS</strong></span><br />
							<span style="color:#6c90d4; font-size:12px;">
							YGS'ye deneyimli kadromuzla hazırlanın</span><br />
							<a href="ygs.aspx" style="color:#666">
    
                            <asp:Repeater ID="Repeater3" runat="server" DataSourceID="AccessDataSource3">
                                <ItemTemplate>
                                <div>
                                    <img src='<%#Eval("resim_url")%>'alt="" style="width:255px" />
                                </div>
                            </ItemTemplate>
                            </asp:Repeater>
                            
							<asp:SqlDataSource ID="AccessDataSource3" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:ConnectionString7 %>" 
                                ProviderName="<%$ ConnectionStrings:ConnectionString7.ProviderName %>" 
                                SelectCommand="SELECT [resim_url] FROM [DefaultResim] WHERE (([resim_ad] = ?) AND ([resim_durum] = ?))">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="r3" Name="resim_ad" Type="String" />
                                    <asp:Parameter DefaultValue="1" Name="resim_durum" Type="String" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            
							<%--<img src="../Resimler/student3.jpg" style="width:255px" alt="" />--%>

							<p>Sınavlara yönelik zengin döküman, kaynak ve Soru Bankaları, 
							İnteraktif Eğitim... 1974'ten günümüze bilgi ve birikime
							dayalı öğretim programları ile deneyimli,...</p>
							</a>
							<a href="ygs.aspx">
							<div class="continue" style="float:none;width:40px;">
								Devam
							</div>
							</a>
						</div>
			
			</div>
			<div id="newsWrapper">
            
				
               
				                
					<table style="float:left; margin-right:2px;" width="260" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="2" align="left"><a href="ygs_ve_lys_de_degisiklik.aspx"><h3 style="color:#6c90d4; font-size:14px; margin-bottom:5px">
						YGS ve LYS de değişiklik</h3></a> <b style="margin-left:0px;color:#6c90d4; font-size:12px; margin-bottom:10px"></b></td>
    </tr>
  <tr>
    <td width="94">
      <a href="ygs_ve_lys_de_degisiklik.aspx">
	      

          <asp:Repeater ID="Repeater4" runat="server" DataSourceID="AccessDataSourceAltR">
              <ItemTemplate>
                                <div>
                                    <img src='<%#Eval("resim_url")%>'width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />
                                </div>
                            </ItemTemplate>
          </asp:Repeater>

          <asp:SqlDataSource ID="AccessDataSourceAltR" runat="server" 
              ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vtb.accdb" 
              ProviderName="System.Data.OleDb" 
              SelectCommand="SELECT [resim_url] FROM [DefaultResim] WHERE (([resim_durum] = ?) AND ([resim_ad] = ?))">
              <SelectParameters>
                  <asp:Parameter DefaultValue="1" Name="resim_durum" Type="String" />
                  <asp:Parameter DefaultValue="r4" Name="resim_ad" Type="String" />
              </SelectParameters>
        </asp:SqlDataSource>

          <%--<img src="../Resimler/bd1f7a91fde609fa495cf251ee5d819f.jpg" width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />  --%>

      </a></td>
    <td width="156"><a href="ygs_ve_lys_de_degisiklik.aspx">
	YGS ve LYS de değişiklik
    </a></td>
  </tr>
  <tr>
    <td colspan="2" align="left">	
							<div class="continue" style="width:40px;margin-top:5px;">
							<a href="ygs_ve_lys_de_degisiklik.aspx">	Devam </a>
							</div>
							</td>
    </tr>
</table>

				                
					<table style="float:left; margin-right:2px;" width="260" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="2" align="left"><a href="ogrenme_stilimi_seviyorum.aspx"><h3 style="color:#6c90d4; font-size:14px; margin-bottom:5px">
						Öğrenme Stilimi Seviyorum</h3></a> <b style="margin-left:0px;color:#6c90d4; font-size:12px; margin-bottom:10px"></b></td>
    </tr>
  <tr>
    <td width="94">
      <a href="ogrenme_stilimi_seviyorum.aspx">

          <asp:Repeater ID="Repeater5" runat="server" DataSourceID="AccessDataSourceAltR1">

           <ItemTemplate>
               <div>
                <img src='<%#Eval("resim_url")%>'width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />
                </div>
           </ItemTemplate>
          </asp:Repeater>

          <asp:SqlDataSource ID="AccessDataSourceAltR1" runat="server" 
              ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vtb.accdb" 
              ProviderName="System.Data.OleDb" 
              SelectCommand="SELECT [resim_url] FROM [DefaultResim] WHERE (([resim_durum] = ?) AND ([resim_ad] = ?))">
              <SelectParameters>
                  <asp:Parameter DefaultValue="1" Name="resim_durum" Type="String" />
                  <asp:Parameter DefaultValue="r5" Name="resim_ad" Type="String" />
              </SelectParameters>
        </asp:SqlDataSource>


            <%--<img src="../Resimler/80fb832fd6f95bea9386fa914a35fef2.jpg" width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />--%>
      </a></td>

    <td width="156"><a href="ogrenme_stilimi_seviyorum.aspx">
	Lazio öğrencileri Öğrenme Stilleri doğrultusunda başarıya odaklanır.
    </a></td>
  </tr>
  <tr>
    <td colspan="2" align="left">	
							<div class="continue" style="width:40px;margin-top:5px;">
							<a href="ogrenme_stilimi_seviyorum.aspx">	Devam </a>
							</div>
							</td>
    </tr>
</table>

				                
					<table style="float:left; margin-right:2px;" width="260" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="2" align="left"><a href="hizli_okuma.aspx"><h3 style="color:#6c90d4; font-size:14px; margin-bottom:5px">
						Hızlı Okuma Eğitimi</h3></a> <b style="margin-left:0px;color:#6c90d4; font-size:12px; margin-bottom:10px"></b></td>
    </tr>
  <tr>
    <td width="94">
      <a href="hizli_okuma.aspx">
	
          <asp:Repeater ID="Repeater6" runat="server" DataSourceID="AccessDataSourceAltR2">

           <ItemTemplate>
               <div>
                <img src='<%#Eval("resim_url")%>'width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />
                </div>
           </ItemTemplate>
          </asp:Repeater>

          <asp:SqlDataSource ID="AccessDataSourceAltR2" runat="server" 
              ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vtb.accdb" 
              ProviderName="System.Data.OleDb" 
              SelectCommand="SELECT [resim_url] FROM [DefaultResim] WHERE (([resim_durum] = ?) AND ([resim_ad] = ?))">
              <SelectParameters>
                  <asp:Parameter DefaultValue="1" Name="resim_durum" Type="String" />
                  <asp:Parameter DefaultValue="r6" Name="resim_ad" Type="String" />
              </SelectParameters>
        </asp:SqlDataSource>


	  <%--<img src="../Resimler/a62e2485455406ab0050dfc0fafc3e39.jpg" width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />--%>
	
      </a></td>
    <td width="156"><a href="hizli_okuma.aspx">
	Lazio Dersaneleri öğrencilerine Hızlı Okuma eğitimi verilmektedir.
    </a></td>
  </tr>
  <tr>
    <td colspan="2" align="left">	
							<div class="continue" style="width:40px;margin-top:5px;">
							<a href="hizli_okuma.aspx">	Devam </a>
							</div>
							</td>
    </tr>
</table>
				                
					<table style="float:left; margin-right:2px;" width="260" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td colspan="2" align="left"><a href="trafigi_ne_kadar_biliyoruz.aspx"><h3 style="color:#6c90d4; font-size:14px; margin-bottom:5px">
						TRAFİĞİ NE KADAR BİLİYORUZ?</h3></a> <b style="margin-left:0px;color:#6c90d4; font-size:12px; margin-bottom:10px"></b></td>
    </tr>
  <tr>
    <td width="94">
      <a href="trafigi_ne_kadar_biliyoruz.aspx">
	
          <asp:Repeater ID="Repeater7" runat="server" DataSourceID="AccessDataSourceAltR3">

           <ItemTemplate>
               <div>
                <img src='<%#Eval("resim_url")%>'width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />
                </div>
           </ItemTemplate>
          </asp:Repeater>

          <asp:SqlDataSource ID="AccessDataSourceAltR3" runat="server" 
              ConnectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vtb.accdb" 
              ProviderName="System.Data.OleDb" 
              SelectCommand="SELECT [resim_url] FROM [DefaultResim] WHERE (([resim_durum] = ?) AND ([resim_ad] = ?))">
              <SelectParameters>
                  <asp:Parameter DefaultValue="1" Name="resim_durum" Type="String" />
                  <asp:Parameter DefaultValue="r7" Name="resim_ad" Type="String" />
              </SelectParameters>
        </asp:SqlDataSource>


	  <%--<img src="../Resimler/d271f812d34ec34b9643afaab147245f.jpg" width="90" height="60" style="float:left;margin:-1px 5px 5px 0px;padding:5px;background:#fff;border:1px solid #ddd" alt="" />--%>
      
      </a></td>
    <td width="156"><a href="trafigi_ne_kadar_biliyoruz.aspx">
	&quot;TRAFİĞİ NE KADAR BİLİYORUZ?&quot; KONULU BİLGİ YARIŞMASI
    </a></td>
  </tr>
  <tr>
    <td colspan="2" align="left">	
							<div class="continue" style="width:40px;margin-top:5px;">
							<a href="trafigi_ne_kadar_biliyoruz.aspx">	Devam </a>
							</div>
							</td>
    </tr>
</table>

				
		
		  </div>

</asp:Content>

