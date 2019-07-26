<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="haberler.aspx.cs" Inherits="admin_haberler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
        <span style="color:#013682; font-size:14px;">
                <strong>Haberler</strong>
		</span>
    <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <asp:Panel ID="haberekpanel" runat="server">
    <div>
    <table style="width:60%">
                    <tr>
                        <td class="auto-style1">Haber Metni</td>
                        <td>:</td>
                        <td colspan="2">
                            <asp:TextBox ID="habermetin" runat="server" Height="30px" TextMode="MultiLine" Width="350px" CssClass="nesne"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="habermetin" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="haberekle"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                       <tr>
                        <td class="auto-style1">Haber Durum</td>
                        <td>:</td>
                        <td colspan="2">
                            <asp:TextBox ID="haberdurum" runat="server"   Width="50px" CssClass="nesne"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="haberdurum" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="haberekle"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>              
                        <td></td>
                        <td>&nbsp;</td>
                        
                        <td>
                            <asp:Button ID="haberekleme" runat="server" CssClass="btn btn-blue" OnClick="haberekleme_Click" Text="Haber Ekle" ValidationGroup="haberekle" />
                        </td>
                        
                    </tr>
                    <tr> 
                        <td colspan="3">
                            <asp:Label ID="haberbilgilendirme" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    
                </table>
                        <div class="datagrid">
                        <asp:DataList ID="ListeHaberler" runat="server" OnItemCommand="ListeHaberler_ItemCommand">
                            <HeaderTemplate>
                                <table>
                                    <thead>
                                    <tr>
                                        <th>Haber</th>
                                        <th>Durum</th>
                                        <th style="text-align:center;">Sil</th>
                                        <th style="text-align:center;">Güncelle</th>
                                    </tr>
                                        </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                <tr class="alt">
                                    <td style="text-align:left;">
                                        <asp:Label ID="haberaciklama" runat="server" Text='<%#Eval("haberler")%>'></asp:Label>
                                    </td>
                                    <td style="text-align:left;">
                                        <asp:Label ID="haberdurum" runat="server" Text='<%#Eval("haber_durum")%>'></asp:Label>
                                    </td>
                                    <td style="text-align:center;">
                                        <asp:LinkButton ID="habersil" runat="server" CommandArgument='<%#Eval("haber_id") %>' CommandName="Delete" CssClass="b1ck" OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')">Sil</asp:LinkButton>
                                    </td>
                                    <td style="text-align:center;">
                                        <asp:LinkButton ID="haberguncel" runat="server" CommandArgument='<%#Eval("haber_id") %>' CommandName="Update" CssClass="b1ck">Güncelle</asp:LinkButton>
                                    </td>
                                </tr>
                                    </tbody>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:DataList>
                            </div>
        </div>
        </asp:Panel>
    <div style="margin-left:300px; width:500px;">
        <asp:Image ID="yukleniyor" Visible="false" ImageUrl="~/admin/images/yukleniyor.gif" runat="server" /> <asp:Label ID="bilgilendirme" runat="server" style="font-weight: 700; font-size: medium;"></asp:Label>
    </div>
</asp:Content>

