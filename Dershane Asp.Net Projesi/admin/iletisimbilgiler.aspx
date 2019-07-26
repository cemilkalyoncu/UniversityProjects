<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="iletisimbilgiler.aspx.cs" Inherits="admin_iletisimbilgiler" %>

<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <script>
        $(document).ready(function () {
            $("#<%=tel.ClientID%>").mask("999 999 99 99");
            $("#<%=fax.ClientID%>").mask("999 999 99 99");
            $("#<%=yayintel.ClientID%>").mask("999 999 99 99");
            $("#<%=yayinfax.ClientID%>").mask("999 999 99 99");
        })
          </script>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <span style="color:#013682; font-size:14px;">
                <strong>İletişim Bilgileri</strong>
		</span>
    <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <asp:Panel ID="iletisimbilgileripanel" Visible="false" runat="server">
    <div>
        <table cellpadding="10" cellspacing="10">
            <tr>
                <td>Adres</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="adres" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="adres" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                </td>
            </tr>
              <tr>
                <td>Posta Kodu</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="pk" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pk" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                  </td>
            </tr>
              <tr>
                <td>Telefon</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="tel" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tel" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                  </td>
            </tr>
              <tr>
                <td>Fax</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="fax" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="fax" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                  </td>
            </tr>
              <tr>
                <td>E-Posta</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="eposta" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="eposta" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="yayineposta" CssClass="ui-priority-primary" ErrorMessage="Geçersiz Eposta" style="color: #FF0000" ValidationGroup="iletupdate" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                  </td>
            </tr>
            <tr>
                <td>Yeni Şube Başvurusu</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="sube" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="sube" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Yayın Adres</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="yayinadres" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="yayinadres" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Yayın Telefon</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="yayintel" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="yayintel" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Yayın Fax</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="yayinfax" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="yayinfax" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Yayın E-Posta</td>
                <td>:</td>
                <td>
                    <asp:TextBox ID="yayineposta" runat="server" CssClass="nesne"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="yayineposta" CssClass="ui-priority-primary" ErrorMessage="*" style="color: #FF0000" ValidationGroup="iletupdate"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="yayineposta" CssClass="ui-priority-primary" ErrorMessage="Geçersiz Eposta" style="color: #FF0000" ValidationGroup="iletupdate" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Google Map</td>
                <td>:</td>
                <td>
                    <CKEditor:CKEditorControl ID="googleMap" runat="server"></CKEditor:CKEditorControl>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:LinkButton ID="iletisimguncelle" runat="server" CssClass="btn btn-blue" ValidationGroup="iletupdate" OnClick="iletisimguncelle_Click">Güncelle</asp:LinkButton>
                </td>
            </tr>
        </table>
    </div>
        </asp:Panel>
    <asp:Panel ID="iletbilgicekpanel" runat="server">
        <div class="datagrid" style="width:980px">
            <asp:DataList ID="ListeMesajlar" runat="server" OnItemCommand="ListeMesajlar_ItemCommand">
                            <HeaderTemplate>
                                <table>
                                    <thead>
                                    <tr>
                                        <th>Adres</th>
                                        <th>Posta Kodu</th>
                                        <th>Telefon</th>
                                        <th>Fax</th>
                                        <th>E-posta</th>
                                        <th>Sube</th>
                                        <th>Yayın Adresi</th>
                                        <th>Yayın Telefon</th>
                                        <th>Yayın Fax</th>
                                        <th>Yayın E-Posta</th>
                                        <th>Güncelle</th>
                                    </tr>
                                        </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                <tr class="alt">
                                    <td style="text-align:center"><%#Eval("adres") %></td>
                                    <td style="text-align:center"><%#Eval("pk") %></td>
                                    <td style="text-align:center"><%#Eval("tel") %></td>
                                    <td style="text-align:center"><%#Eval("fax") %></td>
                                    <td style="text-align:center"><%#Eval("eposta") %></td>
                                    <td style="text-align:center"><%#Eval("sube") %></td>
                                    <td style="text-align:center"><%#Eval("adres2") %></td>
                                    <td style="text-align:center"><%#Eval("tel2") %></td>
                                    <td style="text-align:center"><%#Eval("fax2") %></td>
                                    <td style="text-align:center"><%#Eval("eposta2") %></td>
                                    <td style="text-align:center"><asp:LinkButton ID="guncelleilet" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="Guncelle" CssClass="b1ck">Güncelle</asp:LinkButton></td>
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

