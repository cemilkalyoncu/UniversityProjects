<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/stilim.css" rel="stylesheet" />
<title>Yönetim Paneli</title>
<style type="text/css">
@charset "utf-8";body{background:url(images/giris_bg.jpg);font-family:Calibri}
#cerceve{margin:150px auto 0 auto;width:400px;height:300px}
.header{background:url(images/header_bg1.png) no-repeat top;height:63px;border-top-left-radius:1px;border-top-right-radius:1px;line-height:60px;padding-left:20px;text-shadow:1px 1px rgba(53,16,56,0.5);color:#fff;font-weight:bold}
.formbody{width:400px;height:240px;background:url(images/formbody.png) no-repeat top}
#loginForm .text{width:358px;height:52px;margin:20px 0 0 22px;outline:0;font-weight:bold;padding-left:20px;border:0;color:#a9a9bc}
#loginForm .submit{width:100px;height:40px;margin:20px 20px 0 22px;background:url(images/login1.png) no-repeat;font-weight:bold;text-shadow:1px 1px rgba(53,16,56,0.5);color:#fff;cursor:pointer;border:0}
#loginForm a{text-decoration:none;color:#a9a9bc;font-size:14px;font-weight:bold;text-shadow:1px 1px rgba(255,255,255,0.75)}
</style>
<script src="js/jquery-1.3.2.min.js" type="text/javascript"></script>
     <script type="text/javascript">
         function EnterEvent(e) {
             if (e.keyCode == 13) {
                 __doPostBack('<%=girisyap.ClientID%>', "");
              }
          }
    </script>
<script type="text/javascript">
    $(function () {
        $("#cerceve").hide().fadeIn(700);
    });
</script>
</head>
<body>
<form runat="server" id="loginForm">
<div id="cerceve">
<div class="header"><div style="float:left">Yönetici Girişi</div></div>
<div class="formbody">
    <asp:TextBox ID="kullaniciadi" placeholder="Kullanıcı Adı" CssClass="admingiristext text" runat="server"></asp:TextBox>
 <asp:TextBox ID="sifre" placeholder="Şifre" CssClass="adminsifretext text" runat="server" TextMode="Password"></asp:TextBox>
<div style="float:right">
    <asp:Button ID="girisyap" CssClass="admingirisbuton submit" OnClick="girisyap_Click" runat="server" Text="Giriş Yap" />
</div>
<div style="clear:both">
    <asp:Label ID="bilgi" runat="server" ></asp:Label></div>
</div>
<div style="clear:both"></div>
</div>
</form>
</body>
</html>