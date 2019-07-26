<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admin_panel.aspx.cs" Inherits="admin_panel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="fetched_content">
    <script>
        $(document).ready(function () {
            $(".telno").mask("999-999-99-99");
            $(".tabloogretmenguncel").hide();
        })
        function ogrekle() {
            $(".tabloogretmenguncel").fadeOut();
            $(".tabloogretmen").fadeIn();
        }
        function ogrguncel() {
            $(".tabloogretmenguncel").fadeIn();
            $(".tabloogretmen").fadeOut();
        }
    </script>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <span style="color:#013682; font-size:14px;">
                <strong>Admin Panel</strong>
		</span> 
		<ul class="duzsayfa_altbaslik"></ul><div style="clear:both"></div> 
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <div id="uyeol">
        <table>
            <tr>
                <td><asp:Button ID="ogretmenekle" CssClass="buton" runat="server" Text="Öğretmen Ekle / Sil / Güncelle" CausesValidation="False" OnClick="ogretmenekle_Click" Width="181px" /></td>
                <td><asp:Button ID="haberekle" CssClass="buton" runat="server" Text="Haber Ekle / Sil" CausesValidation="False" OnClick="haberekle_Click" Width="150px" /></td>
                <td><asp:Button ID="subeekle" CssClass="buton" runat="server" Text="Şube Ekle / Sil / Güncelle" CausesValidation="False" OnClick="subeekle_Click" /></td>
                <td><asp:Button ID="Mesajlar" CssClass="buton" runat="server" Text="İletişim Mesajları" CausesValidation="False" OnClick="Mesajlar_Click" /></td>
            </tr>
        </table>
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <div id="ogrekle" onclick="ogrekle()" style="width:110px;background-color:rgba(200, 35, 35, 0.68)" class="buton">Öğretmen Ekle</div> <div id="ogrguncel" onclick="ogrguncel()" style="width:110px; margin-left:20px; margin-top:-20px; background-color:rgba(200, 35, 35, 0.68)" class="buton">Öğretmen Güncelle</div>
                <table>
                    <tr>
                        <td><table class="tabloogretmen">
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="130px" Width="150px" />
                        </td>
                    </tr>
                            <tr>
                                <td>Öğretmen Vesikalık Resim</td>
                                <td>:</td>
                                <td>
                                    <asp:FileUpload ID="profilresim" runat="server" Width="200px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="profilresim" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                                    &nbsp;<asp:Button ID="profilresimguncelle" runat="server" CssClass="buton" Text="Resmi Güncelle" ValidationGroup="resim" Visible="False" Width="123px" OnClick="profilresimguncelle_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>Öğretmen Kullanıcı Adı</td>
                                <td>:</td>
                                <td>
                                    <asp:TextBox ID="ogretmenkullaniciadi" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ogretmenkullaniciadi" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>Öğretmen Adı ve Soyadı</td>
                                <td>:</td>
                                <td>
                                    <asp:TextBox ID="ogretmenadi" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ogretmenadi" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                    <tr>
                        <td>Bulunduğu Şube</td>
                        <td>:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Subeler" DataValueField="Subeler">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT DISTINCT [Subeler] FROM [Subeler]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>Şifre</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmensifre" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ogretmensifre" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Şifre Tekrarı</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmensifretekrar" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="ogretmensifre" ControlToValidate="ogretmensifretekrar" ErrorMessage="Şifreler Uyuşmuyor" Font-Bold="True" ForeColor="Red" ValidationGroup="ogretmenuyelik"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>E-Posta</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmeneposta" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ogretmeneposta" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Geçersiz E-Posta" Font-Bold="True" ForeColor="Red" ValidationGroup="ogretmenuyelik" ControlToValidate="ogretmeneposta" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Tel No</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmentelno" class="telno" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ogretmentelno" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Adres</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmenadres" runat="server" Height="55px" TextMode="MultiLine" Width="215px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="ogretmenekleguncelle" CssClass="buton" runat="server" Text="Öğretmen Ekle" ValidationGroup="ogretmenuyelik" OnClick="ogretmenekleguncelle_Click" />
                            &nbsp;<asp:Button ID="temizle" CssClass="buton" OnClick="temizle_Click" runat="server" Text="Temizle" CausesValidation="False" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                </table>
                        </td>
                                            </tr>
                </table>
                            <asp:Repeater ID="ListeOgretmenler" runat="server" OnItemCommand="ListeOgretmenler_ItemCommand">
                                <HeaderTemplate>
                            <table class="tabloogretmenguncel">
                                <tr style="background-color: white; padding:5px;font-size:12px; font-weight:bold;color:#013682; text-align:center">
                                    <td style="border-bottom:1px solid #224f90">Öğretmen Kullanıcı Adı</td>
                                    <td style="border-bottom:1px solid #224f90">Öğretmen Adı Soyadı</td>
                                    <td style="border-bottom:1px solid #224f90">Şube</td>
                                    <td style="border-bottom:1px solid #224f90">E-Posta</td>
                                    <td style="border-bottom:1px solid #224f90">Şifre</td>
                                    <td style="border-bottom:1px solid #224f90">Tel No</td>
                                    <td style="border-bottom:1px solid #224f90">Sil</td>
                                    <td style="border-bottom:1px solid #224f90" >Güncelle</td>
                                </tr>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr style="background-color:white; color:black; font-size:10px;">
                                        <td>
                                            <asp:Label ID="ogrkullaniciad" runat="server" Text='<%#Eval("ogretmenkullaniciadi") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogradsoyad" runat="server" Text='<%#Eval("ogretmenadsoyad") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogrsube" runat="server" Text='<%#Eval("bulundugusube") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogremail" runat="server" Text='<%#Eval("eposta") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogrsifre" runat="server" Text='<%#Eval("sifre") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogrtelno" runat="server" Text='<%#Eval("telno") %>' ></asp:Label></td>
                                        <td style=" text-align:center; padding:5px" ><asp:Linkbutton ID="ogrsil" runat="server"  CommandArgument='<%#Eval("ogretmen_id") %>' CommandName="Delete" CssClass="b1ck" Text="Sil" Width="15px" CausesValidation="False" OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')"></asp:Linkbutton></td>
                                        <td style="padding:5px; text-align:center">  <asp:Linkbutton ID="ogrguncelle" CommandArgument='<%#Eval("ogretmen_id") %>' CommandName="Update" CssClass="b1ck" runat="server" Width="50px" Text="Güncelle" CausesValidation="False"></asp:Linkbutton></td>
                                    </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                            </table>
                                    </FooterTemplate>
                            </asp:Repeater>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <table style="width:60%">
                    <tr>
                        <td class="auto-style1">Haber Metni</td>
                        <td>:</td>
                        <td colspan="2">
                            <asp:TextBox ID="habermetin" runat="server" Height="30px" TextMode="MultiLine" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                       <tr>
                        <td class="auto-style1">Haber Durum</td>
                        <td>:</td>
                        <td colspan="2">
                            <asp:TextBox ID="haberdurum" runat="server"   Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>              
                        <td></td>
                        <td>&nbsp;</td>
                        
                        <td>
                            <asp:Button ID="habertemizle" runat="server" CssClass="buton" OnClick="habertemizle_Click" Text="Temizle" Visible="False" />
                        </td>
                        
                        <td>
                            <asp:Button ID="haberekleme" runat="server" CssClass="buton" OnClick="haberekleme_Click" Text="Haber Ekle" />
                        </td>
                        
                    </tr>
                    <tr> 
                        <td colspan="3">
                            <asp:Label ID="haberbilgilendirme" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    
                </table>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" EnableViewState="false">
                    <ContentTemplate>
                        <asp:DataList ID="ListeHaberler" runat="server" OnItemCommand="ListeHaberler_ItemCommand">
                            <HeaderTemplate>
                                <table cellpadding="5" cellspacing="0" style="width:120%;">
                                    <tr style="background-color: white; padding:5px;font-size:12px; font-weight:bold;color:#013682; text-align:center">
                                        <td style="width:80%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px; ">Haber</td>
                                        <td style="width:10%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px; text-align:center;">Durum</td>
                                        <td style="width:10%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px;  text-align:center;">Sil</td>
                                        <td style="width:10%; border-bottom:1px solid #224f90; padding:8px; text-align:center;">Güncelle</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr style="background-color:white; color:black; font-size:10px;">
                                    <td style="border-bottom:1px solid #224f90; padding:5px;border-right:1px solid #224f90;">
                                        <asp:Label ID="haberaciklama" runat="server" Text='<%#Eval("haberler")%>'></asp:Label>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;text-align:center; border-right:1px solid #224f90;">
                                        <asp:Label ID="haberdurum" runat="server" Text='<%#Eval("haber_durum")%>'></asp:Label>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;border-right:1px solid #224f90;">
                                        <asp:LinkButton ID="habersil" runat="server" CommandArgument='<%#Eval("haber_id") %>' CommandName="Delete" CssClass="b1ck" OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')">Sil</asp:LinkButton>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;">
                                        <asp:LinkButton ID="haberguncel" runat="server" CommandArgument='<%#Eval("haber_id") %>' CommandName="Update" CssClass="b1ck">Güncelle</asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:DataList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:View>
            <asp:View ID="View3" runat="server">
                 <table style="width:60%">
                    <tr>
                        <td class="auto-style1">Şube Merkezi</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="subemerkezi" runat="server"></asp:TextBox>
                        </td>
                          <td>
                            <asp:Button ID="subemerkeziEkle" CssClass="buton" runat="server" Text="Şube Ekle" OnClick="subemerkeziEkle_Click" />
                         </td>
                    </tr>
                </table>
                <asp:Repeater ID="Liste_Subeler" runat="server" OnItemCommand="Liste_Subeler_ItemCommand">
                    <HeaderTemplate>
                <table>
                    <tr style="background-color: white; padding:5px;font-size:12px; font-weight:bold;color:#013682; text-align:center">
                        <td style="border-bottom:1px solid #224f90">Şubeler</td>
                        <td style="border-bottom:1px solid #224f90">Sil</td>
                    </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                    <tr style="background-color:white; color:black; font-size:10px;">
                        <td><asp:Label runat="server" Text='<%#Eval("Subeler")%>' ></asp:Label></td>
                        <td style=" text-align:center; padding:5px"><asp:LinkButton runat="server" CommandArgument='<%#Eval("Sube_id") %>' OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')" CommandName="Delete" CssClass="b1ck" ID="listesubesil">Sil</asp:LinkButton></td>
                    </tr>
                        </ItemTemplate>
                    <FooterTemplate>
                </table>
                        </FooterTemplate>
                    </asp:Repeater>
            </asp:View>
            <asp:View ID="View4" runat="server">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:DataList ID="ListeMesajlar" runat="server" OnItemCommand="ListeMesajlar_ItemCommand">
                            <HeaderTemplate>
                                <table cellpadding="5" cellspacing="0" style="width:100%;">
                                    <tr style="background-color: white; padding:5px;font-size:12px; font-weight:bold;color:#013682; text-align:center">
                                        <td style="width:15%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px; ">Ad Soyad</td>
                                        <td style="width:5%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px; text-align:center;">E-Posta</td>
                                        <td style="width:50%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px; text-align:center;">Mesaj</td>
                                        <td style="width:10%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px; text-align:center;">Gönderildiği Zaman</td>
                                        <td style="width:5%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px; text-align:center;">Telefon</td>
                                        <td style="width:5%; border-bottom:1px solid #224f90; border-right:1px solid #224f90; padding:8px;  text-align:center;">Sil</td>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr style="background-color:white; color:black; font-size:10px;">
                                    <td style="border-bottom:1px solid #224f90; padding:5px;border-right:1px solid #224f90;">
                                        <asp:Label ID="adsoyadmesaj" runat="server" Text='<%#Eval("Ad_Soyad")%>'></asp:Label>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;text-align:center; border-right:1px solid #224f90;">
                                        <asp:Label ID="iletisimE_Posta" runat="server" Text='<%#Eval("E_Posta")%>'></asp:Label>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;text-align:center; border-right:1px solid #224f90;">
                                        <asp:Label ID="iletisimmesaj" runat="server" Text='<%#Eval("mesaj")%>'></asp:Label>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;text-align:center; border-right:1px solid #224f90;">
                                        <asp:Label ID="iletisimtel" runat="server" Text='<%#Eval("Telefon")%>'></asp:Label>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;text-align:center; border-right:1px solid #224f90;">
                                        <asp:Label ID="iletisimzaman" runat="server" Text='<%#Eval("Zaman")%>'></asp:Label>
                                    </td>
                                    <td style="border-bottom:1px solid #224f90; padding:5px;border-right:1px solid #224f90;">
                                        <asp:LinkButton ID="iletisimsil" runat="server" CommandArgument='<%#Eval("iletisim_id") %>' CommandName="Delete" CssClass="b1ck" OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')">Sil</asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:DataList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </asp:View>
        </asp:MultiView>
        <asp:Label ID="bilgilendirme" runat="server"></asp:Label>
    </div>
        </div>
    
</asp:Content>

