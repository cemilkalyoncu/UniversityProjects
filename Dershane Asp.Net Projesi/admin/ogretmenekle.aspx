<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="ogretmenekle.aspx.cs" Inherits="admin_ogretmenekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
      <script>
          $(document).ready(function () {
              $(".telno").mask("999-999-99-99");
          })
          </script>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <span style="color:#013682; font-size:14px;">
                <strong>Öğretmenler</strong>
		</span>
    <br />
		<img src="../../KResimler/slicer_border.jpg" width="755px"; height="1px"; style="padding:0px 0px 10px 0px ">
<br /> 
    <asp:Panel ID="ogretmnpanlgoster" runat="server">
    <div>
                       <table cellpadding="10" cellspacing="10" >
                    <tr>
                        <td>
                            <asp:Image ID="Image1" Visible="false" runat="server" Height="130px" Width="150px" />
                        </td>
                    </tr>
                            <tr>
                                <td>Öğretmen Vesikalık Resim</td>
                                <td>:</td>
                                <td>
                                    <asp:FileUpload ID="profilresim" CssClass="nesne" runat="server" Width="200px" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="profilresim" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                                    &nbsp;<asp:Button ID="profilresimguncelle" runat="server" CssClass="btn btn-blue" Text="Resmi Güncelle" ValidationGroup="resim" Visible="False" Width="123px" OnClick="profilresimguncelle_Click" /> <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="profilresim" ErrorMessage="Dosya uzantınız uyumsuz !" style="font-weight: 700; color: #FF0000" ValidationExpression="^((i?)[a-z]|[^&amp;])*\.(i?)jpg|\.png|\.jpeg|\.gif" ValidationGroup="ogretmenuyelik"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>Öğretmen Kullanıcı Adı</td>
                                <td>:</td>
                                <td>
                                    <asp:TextBox ID="ogretmenkullaniciadi"  runat="server" CssClass="nesne"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ogretmenkullaniciadi" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>Öğretmen Adı ve Soyadı</td>
                                <td>:</td>
                                <td>
                                    <asp:TextBox ID="ogretmenadi" runat="server" CssClass="nesne"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ogretmenadi" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                    <tr>
                        <td>Bulunduğu Şube</td>
                        <td>:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="nesne" DataSourceID="SqlDataSource1" DataTextField="Subeler" DataValueField="Subeler">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT DISTINCT [Subeler] FROM [Subeler]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>Şifre</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmensifre" runat="server" TextMode="Password" CssClass="nesne"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ogretmensifre" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Şifre Tekrarı</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmensifretekrar" runat="server" TextMode="Password" CssClass="nesne"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="ogretmensifre" ControlToValidate="ogretmensifretekrar" ErrorMessage="Şifreler Uyuşmuyor" Font-Bold="True" ForeColor="Red" ValidationGroup="ogretmenuyelik"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>E-Posta</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmeneposta" runat="server" CssClass="nesne"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ogretmeneposta" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Geçersiz E-Posta" Font-Bold="True" ForeColor="Red" ValidationGroup="ogretmenuyelik" ControlToValidate="ogretmeneposta" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Tel No</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmentelno" class="telno" runat="server" CssClass="nesne"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ogretmentelno" ErrorMessage="*" style="color: #FF0000" ValidationGroup="ogretmenuyelik"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Adres</td>
                        <td>:</td>
                        <td>
                            <asp:TextBox ID="ogretmenadres" runat="server" Height="55px" TextMode="MultiLine" Width="215px" CssClass="nesne"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="ogretmenekleguncelle" CssClass="btn btn-blue" runat="server" Text="Öğretmen Ekle" ValidationGroup="ogretmenuyelik" OnClick="ogretmenekleguncelle_Click" />
                            &nbsp;</td>
                    </tr>
                </table>
                  
                       <div class="datagrid" style="width:1000px">
                            <asp:Repeater ID="ListeOgretmenler" runat="server" OnItemCommand="ListeOgretmenler_ItemCommand">
                                <HeaderTemplate>
                            <table >
                                <thead>
                                <tr>
                                    <th >Öğretmen Kullanıcı Adı</th>
                                    <th >Öğretmen Adı Soyadı</th>
                                    <th >Şube</th>
                                    <th >E-Posta</th>
                                    <th >Şifre</th>
                                    <th >Tel No</th>
                                    <th style="text-align:center">Sil</th>
                                    <th style="text-align:center">Güncelle</th>
                                </tr>
                                    </thead>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tbody>
                                    <tr class="alt">
                                        <td>
                                            <asp:Label ID="ogrkullaniciad" runat="server" Text='<%#Eval("ogretmenkullaniciadi") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogradsoyad" runat="server" Text='<%#Eval("ogretmenadsoyad") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogrsube" runat="server" Text='<%#Eval("bulundugusube") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogremail" runat="server" Text='<%#Eval("eposta") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogrsifre" runat="server" Text='<%#Eval("sifre") %>' ></asp:Label></td>
                                        <td><asp:Label ID="ogrtelno" runat="server" Text='<%#Eval("telno") %>' ></asp:Label></td>
                                        <td style="text-align:center;"><asp:Linkbutton ID="ogrsil" runat="server"  CommandArgument='<%#Eval("ogretmen_id") %>' CommandName="Delete" CssClass="b1ck" Text="Sil" Width="15px" CausesValidation="False" OnClientClick="return confirm('Silme İşlemini Onaylıyor musunuz ?                                         Not: Bu işlemin geri dönüşü yoktur.')"></asp:Linkbutton></td>
                                        <td style="text-align:center;">  <asp:Linkbutton ID="ogrguncelle" CommandArgument='<%#Eval("ogretmen_id") %>' CommandName="Update" CssClass="b1ck" runat="server" Width="50px" Text="Güncelle" CausesValidation="False"></asp:Linkbutton></td>
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

