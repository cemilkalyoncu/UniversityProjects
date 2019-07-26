<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="online_sinav_basvurusu.aspx.cs" Inherits="online_sinav_basvurusu_online_sinav_basvurusu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript" src="../static/js/formcontrol.js"></script>
<div id="onlineSinBasvuru" style="width:780px">
  <div style="clear: both; height: 5px;">&nbsp;</div>
  
    <div id="sol" class="column">
      <table cellpadding="5" cellspacing="5">
        <tr>
          <td colspan=2><div id="basvuruTip">
              <asp:RadioButtonList ID="RadioButtonList_Sinav_Turu" runat="server">
                  <asp:ListItem>  Lazio YARIŞMA SINAVI BAŞVURUSU </asp:ListItem>
                  <asp:ListItem>  OLİMPİYAT SINAVI BAŞVURUSU </asp:ListItem>
              </asp:RadioButtonList>

            </td>
        </tr>
        <tr>
          <td width="100">Ad</td>
          <td>:
           <asp:TextBox ID="textbox_Adi" Class="required" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
          <td width="100">Soyad</td>
          <td>:
            <asp:TextBox ID="textbox_Soyadi" Class="required" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
          <td width="100">Doğum Tarihi</td>
          <td>: <asp:TextBox ID="TextBox_Gun" Class="required" runat="server" MaxLength="2" TextMode="Number" Width="38px"></asp:TextBox> &nbsp;<asp:TextBox ID="TextBox_Ay" runat="server" Class="required" MaxLength="2" TextMode="Number" Width="41px"></asp:TextBox> &nbsp;<asp:TextBox ID="TextBox_Yil" runat="server" Class="required" MaxLength="4" TextMode="Number" Width="57px"></asp:TextBox>
           </td>
        </tr>
        <tr>
          <td width="100">Okul</td>
          <td>:
              <asp:TextBox ID="TextBox_Okul" Class="required" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
          <td width="100">Sınıf Bilgileri</td>
          <td> : 
              <asp:DropDownList ID="DropDownList_Sinif_Bilgileri"  Class="tx ae required" runat="server">
                  <asp:ListItem>Sınıf Seçiniz</asp:ListItem>
                  <asp:ListItem>4.Sınıf</asp:ListItem>
                  <asp:ListItem>5.Sınıf</asp:ListItem>
                  <asp:ListItem>6.Sınıf</asp:ListItem>
                  <asp:ListItem>7.Sınıf</asp:ListItem>
                  <asp:ListItem>8.Sınıf</asp:ListItem>
                  <asp:ListItem>9.Sınıf</asp:ListItem>
                  <asp:ListItem>10.Sınıf</asp:ListItem>
                  <asp:ListItem>11.Sınıf</asp:ListItem>
                  <asp:ListItem>12.Sınıf</asp:ListItem>
                  <asp:ListItem>MEZUN</asp:ListItem>
              </asp:DropDownList>
          </td>
        </tr>
        <tr>
          <td width="100"> Bölüm </td>
          <td>:
              <asp:RadioButtonList ID="RadioButtonList_Bolum" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" Width="240px">
                  <asp:ListItem> MF</asp:ListItem>
                  <asp:ListItem> TM</asp:ListItem>
                  <asp:ListItem> TS</asp:ListItem>
                  <asp:ListItem> YD</asp:ListItem>
                  <asp:ListItem> SBS</asp:ListItem>
              </asp:RadioButtonList>


            </td>
        </tr>
        <tr>
          <td width="100">E-Mail Adresi *</td>
          <td>:
              <asp:TextBox ID="TextBox_E_Mail" class="required" runat="server"></asp:TextBox>
          </td>
        </tr>
        
      </table>
    </div>
    <div id="sag" class="column">
      <table cellpadding="5" cellspacing="5">
      <tr>
          <td width="100">Ev Telefonu *</td>
          <td>
              :
              <asp:TextBox ID="TextBox_Ev_Telefonu" class="required" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td width="100">Cep Telefonu</td>
          <td>: 
              <asp:TextBox ID="TextBox_Cep_Telefonu" class="required" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td width="100">Adres</td>
          <td>&nbsp;<asp:TextBox ID="TextBox_Adres" class="required" runat="server" Height="52px" TextMode="MultiLine" Width="233px"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td width="100">Şehir</td>
          <td>: 
              <asp:TextBox ID="TextBox_Sehir" class="required" runat="server"></asp:TextBox>
          </td>
   
        <tr>
          <td width="100">Posta Kodu</td>
          <td>: 
              <asp:TextBox ID="TextBox_Posta_Kodu" class="required" runat="server"></asp:TextBox>
          </td>
     
        <tr>
          <td width="100">Şube</td>
          <td>:
              <asp:DropDownList ID="DropDownList_Subeler" class="tx ae required" runat="server">
                  <asp:ListItem>ANKARA-ÇAYYOLU</asp:ListItem>
                  <asp:ListItem>ANKARA-ERYAMAN</asp:ListItem>
                  <asp:ListItem>ANKARA-KIZILAY</asp:ListItem>
                  <asp:ListItem>ANTALYA-ALANYA</asp:ListItem>
                  <asp:ListItem>AYDIN-AYDIN</asp:ListItem>
                  <asp:ListItem>AYDIN-KUŞADAS</asp:ListItem>
                  <asp:ListItem>AYDIN-SÖKE</asp:ListItem>
                  <asp:ListItem>BALIKESİR-BANDIRMA</asp:ListItem>
                  <asp:ListItem>BATMAN-BATMAN</asp:ListItem>
                  <asp:ListItem>BURSA-NİLÜFER</asp:ListItem>
                  <asp:ListItem>BURSA-OSMANGAZİ</asp:ListItem>
                  <asp:ListItem>DENİZLİ-DENİZLİ</asp:ListItem>
                  <asp:ListItem>DİYARBAKIR-DİYARBAKIR</asp:ListItem>
                  <asp:ListItem>HATAY-ANTAKYA</asp:ListItem>
                  <asp:ListItem>İSTANBUL-BEŞİKTAŞ</asp:ListItem>
                  <asp:ListItem>İSTANBUL-BEYLİKDÜZÜ</asp:ListItem>
                  <asp:ListItem>İSTANBUL-ÇATALCA</asp:ListItem>
                  <asp:ListItem>İSTANBUL-ÇEKMEKÖY</asp:ListItem>
                  <asp:ListItem>İSTANBUL-GAZİOSMANPAŞA</asp:ListItem>
                  <asp:ListItem>İSTANBUL-KADIKÖY</asp:ListItem>
                  <asp:ListItem>İSTANBUL-KARTAL</asp:ListItem>
                  <asp:ListItem>İSTANBUL-KÜÇÜKÇEKMECEL</asp:ListItem>
                  <asp:ListItem>İSTANBUL-MALTEPE</asp:ListItem>
                  <asp:ListItem>İSTANBUL-PENDİK</asp:ListItem>
                  <asp:ListItem>İSTANBUL-ÜMRANİYE</asp:ListItem>
                  <asp:ListItem>İZMİR-ALSANCAK</asp:ListItem>
                  <asp:ListItem>İZMİR-BERGAMA</asp:ListItem>
                  <asp:ListItem>İZMİR-BUCA</asp:ListItem>
                  <asp:ListItem>İZMİR-GAZİEMİR</asp:ListItem>
                  <asp:ListItem>İZMİR-TİRE</asp:ListItem>
                  <asp:ListItem>İZMİR-TORBALI</asp:ListItem>
                  <asp:ListItem>KAYSERİ-KAYSERİ</asp:ListItem>
                  <asp:ListItem>KAYSERİ-VİP</asp:ListItem>
                  <asp:ListItem>KOCAELİ-DERİNCE</asp:ListItem>
                  <asp:ListItem>KOCAELİ-GEBZE</asp:ListItem>
                  <asp:ListItem>KOCAELİ-İZMİT</asp:ListItem>
                  <asp:ListItem>MANİSA-MANİSA</asp:ListItem>
                  <asp:ListItem>MARDİN-KIZILTEPE</asp:ListItem>
                  <asp:ListItem>MERSİN-ANAMUR</asp:ListItem>
                  <asp:ListItem>MERSİN-MERSİN</asp:ListItem>
                  <asp:ListItem>MERSİN-POZCU</asp:ListItem>
                  <asp:ListItem>MUĞLA-BODRUM</asp:ListItem>
                  <asp:ListItem>SİNOP-SİNOP</asp:ListItem>
                  <asp:ListItem>TEKİRDAĞ-ÇORLU</asp:ListItem>
                  <asp:ListItem>TEKİRDAĞ-SARAY</asp:ListItem>
                  <asp:ListItem>VAN-VAN</asp:ListItem>
              </asp:DropDownList>
          </td>
        
        <tr>
          <td width="100">&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr id="gerekliAlanlar" style="display:none">
          <td width="100">&nbsp;</td>
          <td><span style="color:red">Lütfen Gerekli Alanları Doldurunuz <b>!</b> <img src="../static/images/required.png" alt="" /> </span></td>
        </tr>
        <tr>
          <td width="100"></td>
          <td>
              <asp:Button ID="Button_Gonder" class="buton" runat="server" Text="Gönder" style="float:right;" OnClick="Button_Gonder_Click" />
            </td>
        </tr>
        <tr>
          <td width="100">&nbsp;</td>
          <td>
              <asp:Label ID="Label_Bilgilendirme" runat="server" style="float:right;"></asp:Label>
            </td>
        </tr>
      </table>
    </div>
  
  <div style="clear: both; height: 5px;">&nbsp;</div>
</div>

	</div>
</asp:Content>

