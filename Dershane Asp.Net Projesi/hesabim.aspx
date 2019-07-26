<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="hesabim.aspx.cs" Inherits="hesabim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 153px;
        }
        .auto-style3 {
            width: 166px;
        }
        .auto-style5 {
            width: 14px;
        }
        .auto-style6 {
            font-weight: bold;
            color: red;
        }
        .style1
        {
            width: 100%;
        }
    </style>
     <script>
         $(document).ready(function () {
             $("#<%=txtTelNo.ClientID%>").mask("999-999-99-99");
             $("#<%=txtCepTelNo.ClientID%>").mask("999-999-99-99");
         });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="fetched_content">
	
		<span style="color:#013682; font-size:14px;">
                <strong>HESABIM</strong>
		</span> 
		<ul class="duzsayfa_altbaslik"></ul><div style="clear:both"></div> 
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
        <br />

    <table cellspacing="10" cellpadding="10">
        <tr>
            <td>
                <asp:Button ID="btnBilgilerim" runat="server" Text="Bilgilerim" OnClick="btnBilgilerim_Click" />
            </td>
            <td>
                <asp:Button ID="btnSifreDegistir" runat="server" Text="Şifre Değiştir" OnClick="btnSifreDegistir_Click" />
            </td>
            <td>
                <asp:Button ID="btnOgrenciler" runat="server" Text="Öğrenciler" OnClick="btnOgrenciler_Click" Visible="False"  />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <br />
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:Panel ID="ogrencipanel" runat="server" Visible="False">
           <table cellpadding="10" cellspacing="10">
               <tr>
                   <td><asp:Image ID="ogrenciResim" runat="server" Width="140" Height="140" /></td>
               </tr>
               <tr>
                   <td>Öğrenci Vesikalık Resim</td>
                   <td class="auto-style5">:</td>
                   <td>
                       <asp:FileUpload ID="fuOgrenciResim" runat="server" Width="180px" />
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fuOgrenciResim" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="resimguncelle"></asp:RequiredFieldValidator>
                   </td>
                   <td>
                       <asp:Button ID="btnResimGuncelle" runat="server" Text="Resmi Güncelle" ValidationGroup="resimguncelle" Width="105px" OnClick="btnResimGuncelle_Click" />
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="fuOgrenciResim" ErrorMessage="Dosya uzantınız uyumsuz !" ValidationExpression="^((i?)[a-z]|[^&amp;])*\.(i?)jpg|\.png|\.jpeg|\.gif" ValidationGroup="resimguncelle" CssClass="auto-style6"></asp:RegularExpressionValidator>
                   </td>
               </tr>
                <tr>
                   <td>Bulunduğunuz Şube</td>
                   <td class="auto-style5">:</td>
                    <td>
                   <asp:DropDownList ID="ddlSube" runat="server" DataSourceID="SqlDataSource1" DataTextField="Subeler" DataValueField="Subeler"></asp:DropDownList>
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT DISTINCT [Subeler] FROM [Subeler]"></asp:SqlDataSource>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlSube" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
               </td>
               </tr>
                <tr>
                   <td>Kullanıcı Adı</td>
                   <td class="auto-style5">:</td>
                   <td><asp:Label ID="lblKulAdi" runat="server"></asp:Label></td>
               </tr>
                <tr>
                   <td>E-Posta</td>
                   <td class="auto-style5">:</td>
                   <td><asp:Label ID="lblE_Posta" runat="server"></asp:Label></td>
               </tr>
               <tr>
                   <td>Öğrencinin Adı Soyadı</td>
                   <td class="auto-style5">:</td>
                   <td><asp:Label ID="lblOgrenciAdSoyad" runat="server"></asp:Label></td>
               </tr>
               <tr>
                   <td>Okuduğunuz Okul</td>
                   <td class="auto-style5">:</td>
                   <td><asp:Label ID="lblOkudugunuzOkul" runat="server"></asp:Label></td>
               </tr>
               <tr>
               <td class="auto-style2">Öğrencinin Okuduğu Sınıf</td>
               <td class="auto-style5">:</td>
               <td class="auto-style2">
                   <asp:DropDownList ID="ddlSinif" runat="server" Height="28px" Width="62px">
                       <asp:ListItem>5</asp:ListItem>
                       <asp:ListItem>6</asp:ListItem>
                       <asp:ListItem>7</asp:ListItem>
                       <asp:ListItem>8</asp:ListItem>
                       <asp:ListItem>9</asp:ListItem>
                       <asp:ListItem>10</asp:ListItem>
                       <asp:ListItem>11</asp:ListItem>
                       <asp:ListItem>12</asp:ListItem>
                   </asp:DropDownList>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlSinif" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td>Velinin Adı Soyadı</td>
                   <td class="auto-style5">:</td>
                   <td>
                       <asp:TextBox ID="txtVeliAdi" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtVeliAdi" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
               <td>Velinin Tel Numarası</td>
               <td class="auto-style5">:</td>
               <td>
                   <asp:TextBox ID="txtTelNo" class="tel" MaxLength="11" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtTelNo" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
               </td>
           </tr>
             <tr>
               <td>Velinin Cep Tel Numarası</td>
               <td class="auto-style5">:</td>
               <td>
                   <asp:TextBox ID="txtCepTelNo" class="tel" runat="server" MaxLength="11"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCepTelNo" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
                </td>
           </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnOgrenciBilgiGuncelle" runat="server" OnClick="btnOgrenciBilgiGuncelle_Click" Text="Güncelle" ValidationGroup="bilgiguncelle" />
                </td>
                    </tr>
           </table>
                </asp:Panel>
            <asp:Panel ID="ogretmenpanelguncel" runat="server" Visible="False">
           <table cellpadding="10" cellspacing="10">
               <tr>
                   <td><asp:Image ID="ogretmenresim" runat="server" Width="140" Height="140" /></td>
               </tr>
               <tr>
                   <td>Öğrenci Vesikalık Resim</td>
                   <td class="auto-style5">:</td>
                   <td>
                       <asp:FileUpload ID="ogrresim" runat="server" Width="180px" />
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ogrresim" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="resimguncelle"></asp:RequiredFieldValidator>
                   </td>
                   <td>
                       <asp:Button ID="ogrtmenresimguncelle" runat="server" Text="Resmi Güncelle" ValidationGroup="resimguncelle" Width="105px" OnClick="ogrtmenresimguncelle_Click" />
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ogrresim" ErrorMessage="Dosya uzantınız uyumsuz !" ValidationExpression="^((i?)[a-z]|[^&amp;])*\.(i?)jpg|\.png|\.jpeg|\.gif" ValidationGroup="resimguncelle" CssClass="auto-style6"></asp:RegularExpressionValidator>
                   </td>
               </tr>
                <tr>
                   <td>Bulunduğunuz Şube</td>
                   <td class="auto-style5">:</td>
                    <td>
                   <asp:DropDownList ID="ddlogretmensube" runat="server" DataSourceID="SqlDataSource1" DataTextField="Subeler" DataValueField="Subeler"></asp:DropDownList>
                   <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT DISTINCT [Subeler] FROM [Subeler]"></asp:SqlDataSource>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlSube" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
               </td>
               </tr>
                <tr>
                   <td>Kullanıcı Adı</td>
                   <td class="auto-style5">:</td>
                   <td><asp:Label ID="ogretmenkullanadi" runat="server"></asp:Label></td>
               </tr>
                <tr>
                   <td>E-Posta</td>
                   <td class="auto-style5">:</td>
                   <td><asp:Label ID="ogrteposta" runat="server"></asp:Label></td>
               </tr>
               <tr>
                   <td>Öğretmen Adı Soyadı</td>
                   <td class="auto-style5">:</td>
                   <td><asp:Label ID="ogrtadsyd" runat="server"></asp:Label></td>
               </tr>
               <tr>
               <td>Tel Numarası</td>
               <td class="auto-style5">:</td>
               <td>
                   <asp:TextBox ID="ogrtmentel" class="tel" MaxLength="11" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ogrtmentel" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
               </td>
           </tr>
               <tr>
                   <td>Adres</td>
                   <td class="auto-style5">:</td>
                   <td>
                       <asp:TextBox ID="adres" runat="server" class="tel" Height="60px" MaxLength="11" TextMode="MultiLine" Width="250px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="adres" CssClass="auto-style6" ErrorMessage="*" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
                   </td>
               </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="bilgiogretmenguncelle" runat="server" OnClick="bilgiogretmenguncelle_Click" Text="Güncelle" ValidationGroup="bilgiguncelle" />
                </td>
                    </tr>
           </table>
                </asp:Panel>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:Panel ID="sifrepanel" runat="server">
            <table cellpadding="10" cellspacing="10">
                    <tr>
                        <td class="auto-style3">Eski Şifre</td>
                        <td class="auto-style5">:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtEskiSifre" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblEskiSifreBilgi" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Yeni Şifre</td>
                        <td class="auto-style5">:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtYeniSifre" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblYeniSifreBilgi" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Şifre Tekrar</td>
                        <td class="auto-style5">:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtSifreTekrar" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblYeniSifreTekrarBilgi" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style2">
                            <asp:Button ID="btnSifreGuncelle" runat="server" OnClick="btnSifreGuncelle_Click" Text="Güncelle" />
                        </td>
                        <td class="auto-style2">
                   &nbsp;</td>
                    </tr>
                </table>
           </asp:Panel>
        </asp:View>
        <asp:View ID="View3" runat="server">
            <asp:Panel ID="ogrencilerlistelepanel" runat="server">
       <div class="datagrid">
       <asp:DataList ID="Liste_Ogrenciler" runat="server" OnItemCommand="Liste_Ogrenciler_ItemCommand">
           <HeaderTemplate>
       <table>
<thead>
    <tr>
        <th>Adı Soyadı</th>
        <th>Şubesi</th>
        <th>Sınıfı</th>
        <th>Sil</th>
        
    </tr>
</thead>
           </HeaderTemplate>
           <ItemTemplate>
<tbody>
<tr class="alt">
    <td style="text-align:center"><%#Eval("ogrenciadsoyad") %></td>
    <td style="text-align:center"><%#Eval("sube") %></td>
    <td style="text-align:center"><%#Eval("sinif") %></td>
    <td style="text-align:center">
        <asp:LinkButton ID="ogrencisil" CssClass="b1ck" CommandArgument='<%#Eval("ogrenciid") %>' CommandName="Sil" OnClientClick="return confirm ('Silme işlemini onaylıyormusunuz ?')" runat="server">Sil</asp:LinkButton></td>
</tr>
</tbody>
               </ItemTemplate>
           <FooterTemplate>
</table>
               </FooterTemplate>
           </asp:DataList>
   </div>
                </asp:Panel>
        </asp:View>
    </asp:MultiView>
</div>
       <div style="margin-left:300px; width:500px;margin-top:-150px; position:absolute;">
        <asp:Image ID="yukleniyor" Visible="false" ImageUrl="~/admin/images/yukleniyor.gif" runat="server" /> <asp:Label ID="bilgilendirme" runat="server" style="font-weight: 700; font-size: medium" ></asp:Label>
    </div>
</asp:Content>

