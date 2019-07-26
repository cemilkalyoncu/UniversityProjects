<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="uye_ol.aspx.cs" Inherits="uye_ol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
        }
        .auto-style2 {
            height: 33px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="fetched_content">
    <script>
        $(document).ready(function () {
            $(".tel").mask("999-999-99-99");
        });
    </script>

        <span style="color:#013682; font-size:14px;">
                <strong>Üye Kayıt</strong>
		</span> 
		<ul class="duzsayfa_altbaslik"></ul><div style="clear:both"></div> 
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">

    <div id="uyeol">
        <table>
             <tr>
               <td>Öğrenci Vesikalık Resim</td>
                <td>:</td>
                <td>
                    <asp:FileUpload ID="profilresim" runat="server" Width="200px" />
                    &nbsp;</td>
            </tr>
           <tr>
               <td>Bulunduğunuz Şube</td>
               <td>:</td>
               <td>
                   <asp:DropDownList ID="sube_ddl" runat="server" DataSourceID="SqlDataSource1" DataTextField="Subeler" DataValueField="Subeler"></asp:DropDownList>
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT DISTINCT [Subeler] FROM [Subeler]"></asp:SqlDataSource>
               </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>Kullanıcı Adı</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="ogrencikadi"  runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ogrencikadi" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>Şifre</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="ogrencisifre" runat="server" TextMode="Password"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ogrencisifre" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>Şifre Tekrarı</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="ogrencisifretekrar" runat="server" TextMode="Password"></asp:TextBox>
                   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="ogrencisifre" ControlToValidate="ogrencisifretekrar" CssClass="auto-style1" ErrorMessage="Şifreler Aynı Olması Gerekir" style="color: #FF0000" ValidationGroup="uyeolislemleri"></asp:CompareValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>E-Posta</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="eposta" CssClass="eposta" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="eposta" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="eposta" ErrorMessage="Geçersiz E-Posta" style="font-weight: 700; color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="uyeolislemleri"></asp:RegularExpressionValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>Öğrencinin Adı Soyadı</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="ogrenciadi" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ogrenciadi" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>Okuduğunuz Okul</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="okunanokul" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="okunanokul" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td class="auto-style2">Öğrencinin Okuduğu Sınıf</td>
               <td class="auto-style2">:</td>
               <td class="auto-style2">
                   <asp:DropDownList ID="sinif_ddl" runat="server" Height="28px" Width="62px">
                       <asp:ListItem>5</asp:ListItem>
                       <asp:ListItem>6</asp:ListItem>
                       <asp:ListItem>7</asp:ListItem>
                       <asp:ListItem>8</asp:ListItem>
                       <asp:ListItem>9</asp:ListItem>
                       <asp:ListItem>10</asp:ListItem>
                       <asp:ListItem>11</asp:ListItem>
                       <asp:ListItem>12</asp:ListItem>
                   </asp:DropDownList></td>
               <td class="auto-style2">
                   </td>
           </tr>
           <tr>
               <td>Velinin Adı Soyadı</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="veliadi" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="veliadi" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>Velinin Tel Numarası</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="telno" class="tel" MaxLength="11" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="telno" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
             <tr>
               <td>Velinin Cep Tel Numarası</td>
               <td>:</td>
               <td>
                   <asp:TextBox ID="ceptelno" class="tel" runat="server" MaxLength="11"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ceptelno" ErrorMessage="*" style="color: #FF0000; font-weight: 700" ValidationGroup="uyeolislemleri"></asp:RequiredFieldValidator>
                 </td>
               <td>
                   &nbsp;</td>
           </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <asp:Button ID="uyeol_islem" CssClass="buton" runat="server" Text="Üye Ol" OnClick="uyeol_islem_Click" ValidationGroup="uyeolislemleri"  style="padding-left:5px;margin-left:20px;margin-top:5px" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="bilgilendirme" runat="server" ></asp:Label></td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
        </div>
</asp:Content>

