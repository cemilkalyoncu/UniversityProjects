<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="subeler.aspx.cs" Inherits="admin_subeler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
        <span style="color:#013682; font-size:14px;">
                <strong>Şubeler</strong>
		</span>
    <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <asp:Panel ID="subeekpanel" runat="server">
    <div>
    <table style="width:60%">
                    <tr>
                        <td class="auto-style1">Şube Merkezi</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="subemerkezi" class="nesne" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" style="font-weight: 700; color: #FF0000" ValidationGroup="subeek" ControlToValidate="subemerkezi"></asp:RequiredFieldValidator>
                        </td>
                          <td>
                            <asp:Button ID="subemerkeziEkle" CssClass="btn btn-blue" runat="server" Text="Şube Ekle" OnClick="subemerkeziEkle_Click" ValidationGroup="subeek" />
                         </td>
                    </tr>
                </table>
        <br />
        <div class="datagrid">
                <asp:Repeater ID="Liste_Subeler" runat="server" OnItemCommand="Liste_Subeler_ItemCommand">
                    <HeaderTemplate>
                <table style="width:250px">
                    <thead>
                    <tr>
                        <th style="width:200px">Şubeler</th>
                        <th>Sil</th>
                    </tr>
                        </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                    <tr class="alt">
                        <td><asp:Label ID="Label1" runat="server" Text='<%#Eval("Subeler")%>' ></asp:Label></td>
                        <td style="text-align:center"><asp:LinkButton runat="server" CommandArgument='<%#Eval("Sube_id") %>' OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')" CommandName="Delete" CssClass="b1ck" ID="listesubesil">Sil</asp:LinkButton></td>
                    </tr>
                            </tbody>
                        </ItemTemplate>
                    <FooterTemplate>
                </table>
                        </FooterTemplate>
                    </asp:Repeater>
            </div>
        </div>
        </asp:Panel>
     <div style="margin-left:300px; width:500px;">
        <asp:Image ID="yukleniyor" Visible="false" ImageUrl="~/admin/images/yukleniyor.gif" runat="server" /> <asp:Label ID="bilgilendirme" runat="server" style="font-weight: 700; font-size: medium" ></asp:Label>
    </div>
</asp:Content>

