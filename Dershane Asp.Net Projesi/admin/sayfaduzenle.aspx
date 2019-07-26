<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="sayfaduzenle.aspx.cs" Inherits="admin_sayfaduzenle" %>

<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
        <span style="color:#013682; font-size:14px;">
                <strong>Sayfalar</strong>
		</span>
    <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <asp:Panel ID="genelsayfaduzenle" runat="server">
    <asp:Panel ID="listesayfapanelguncel" runat="server" Visible="false">
        <div >
            <table cellpadding="10" cellspacing="10" style="width:100%">
                <tr>
                    <td>Sayfa Adı</td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="sayfadi" runat="server"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>Açıklama</td>
                    <td>:</td>
                    <td>
                        <CKEditor:CKEditorControl ID="aciklama" runat="server">
                        </CKEditor:CKEditorControl>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="aciklama" ErrorMessage="*" style="font-weight: 700; color: #FF0000"></asp:RequiredFieldValidator>
                     </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:LinkButton ID="islemyap" runat="server" CssClass="btn btn-blue" OnClick="islemyap_Click">Güncelle</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
        <div class="datagrid" style="width:800px">
        <asp:DataList ID="Listesayfalar" runat="server" OnItemCommand="Listesayfalar_ItemCommand">
           <HeaderTemplate>
       <table>
<thead>
    <tr>
        <th>Sayfa Adı</th>
        <th>İçerik</th>
        <th style="text-align:center;">Güncelle</th>
    </tr>
</thead>
           </HeaderTemplate>
           <ItemTemplate>
<tbody>
<tr class="alt">
    <td style="text-align:left"><%#(Eval("uzun_Metin").ToString().Length>250)?Eval("uzun_Metin").ToString().Substring(0,150):Eval("uzun_Metin").ToString()%></td>
    <td style="text-align:left"><%#Eval("sayfaadi")%></td>
    <td style="text-align:center">
        <asp:LinkButton ID="guncelleilet" runat="server" CommandArgument='<%#Eval("metin_id") %>' CommandName="Guncelle" CssClass="b1ck">Güncelle</asp:LinkButton></td>
</tr>
</tbody>
               </ItemTemplate>
           <FooterTemplate>
</table>
               </FooterTemplate>
           </asp:DataList>
            </div>
    </asp:Panel>
    <div style="margin-left:300px; width:500px;">
        <asp:Image ID="yukleniyor" Visible="false" ImageUrl="~/admin/images/yukleniyor.gif" runat="server" /> <asp:Label ID="bilgilendirme" runat="server" style="font-weight: 700; font-size: medium" ></asp:Label>
    </div>
</asp:Content>

