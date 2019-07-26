<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Mesajlar.aspx.cs" Inherits="admin_Mesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <span style="color:#013682; font-size:14px;">
                <strong>Mesajlar</strong>
		</span>
    <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <asp:Panel ID="Mesajpanelgoster" runat="server">
    <div class="datagrid" style="width:900px;">
        <asp:DataList ID="ListeMesajlar" runat="server" OnItemCommand="ListeMesajlar_ItemCommand">
                            <HeaderTemplate>
                                <table>
                                    <thead>
                                    <tr>
                                        <th>Ad Soyad</th>
                                        <th>E-Posta</th>
                                        <th>Mesaj</th>
                                        <th>Gönderildiği Zaman</th>
                                        <th>Telefon</th>
                                        <th>Sil</th>
                                    </tr>
                                        </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                <tr class="alt">
                                    <td>
                                        <asp:Label ID="adsoyadmesaj" runat="server" Text='<%#Eval("Ad_Soyad")%>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="iletisimE_Posta" runat="server" Text='<%#Eval("E_Posta")%>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="iletisimmesaj" runat="server" Text='<%#Eval("mesaj")%>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="iletisimtel" runat="server" Text='<%#Eval("Telefon")%>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="iletisimzaman" runat="server" Text='<%#Eval("Zaman")%>'></asp:Label>
                                    </td>
                                    <td style="text-align:center">
                                        <asp:LinkButton ID="iletisimsil" runat="server" CommandArgument='<%#Eval("iletisim_id") %>' CommandName="Delete" CssClass="b1ck" OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')">Sil</asp:LinkButton>
                                    </td>
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

