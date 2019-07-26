<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="adminDuzen.aspx.cs" Inherits="admin_adminDuzen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
   <span style="color:#013682; font-size:14px;">
                <strong>Admin Yönet</strong>
		</span>
    <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <div id="panel" runat="server">
        <div id="tablebilgiler" runat="server" visible="false"> 
            <table>
                <tr>
                    <td>Kullanıcı Adı</td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="kadi" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Yeni Şifre</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="ysifre" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ysifre" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Yeni Şifre Tekrar</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="ysifretkrar" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ysifretkrar" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="bilgiguncelle"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:LinkButton ID="islem" runat="server" CssClass="btn btn-grey" OnClick="islem_Click" ValidationGroup="bilgiguncelle">Kaydet</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
       <div runat="server" id="data" class="datagrid">
       <asp:DataList ID="Liste" runat="server" OnItemCommand="Liste_ItemCommand">
           <HeaderTemplate>
       <table>
<thead>
    <tr>
        <th>Kullanıcı Adı</th>
        <th>Şifre</th>
        <th>Sil</th>
        <th>Güncelle</th>
        
    </tr>
</thead>
           </HeaderTemplate>
           <ItemTemplate>
<tbody>
<tr class="alt">
    <td><%#Eval("yoneticikadi") %></td>
     <td><%#Eval("yoneticisifre") %></td>
    <td><asp:LinkButton runat="server" CommandName="Sil" CssClass="b1ck" OnClientClick="return confirm('Silmek istediğinize eminmisiniz ?')" CommandArgument='<%#Eval("yonetici_id") %>' >Sil</asp:LinkButton></td>
    <td><asp:LinkButton runat="server" CommandName="Guncelle" CssClass="b1ck" CommandArgument='<%#Eval("yonetici_id") %>' >Güncelle</asp:LinkButton></td>

</tr>
</tbody>
               </ItemTemplate>
           <FooterTemplate>
</table>
               </FooterTemplate>
           </asp:DataList>
   </div>
        </div>
     <div style="margin-left:300px; width:500px;">
        <asp:Image ID="yukleniyor" Visible="false" ImageUrl="~/admin/images/yukleniyor.gif" runat="server" /> <asp:Label ID="bilgilendirme" runat="server" style="font-weight: 700; font-size: medium" ></asp:Label>
    </div>
</asp:Content>

