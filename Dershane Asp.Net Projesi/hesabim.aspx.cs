using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

public partial class hesabim : System.Web.UI.Page
{
    string sifre;
    public string ogrenciid
    {
        get
        {
            if (ViewState["ogrenciid"] == null)
                ViewState["ogrenciid"] = "";
            return ViewState["ogrenciid"].ToString();
        }
        set
        {
            ViewState["ogrenciid"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ogretmen"] != null)
        {
            btnOgrenciler.Visible = true;
        }
        if (Session["ogrencigiris"] == null && Session["ogretmengiris"] == null)
        {
            Response.Redirect("default.aspx");
        }
     
      
    }
    protected void btnResimGuncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (fuOgrenciResim.HasFile)
            {

                string ResimUzantisi = Path.GetExtension(fuOgrenciResim.PostedFile.FileName);
                string ResimAdi = fuOgrenciResim.PostedFile.FileName;
                //Geçici olarak FileUpload nesnemizdeki resmi Resimler dizinine kayıt ediyoruz.
                fuOgrenciResim.SaveAs(Server.MapPath("/ProfilUploadResim/Ogrenci/gecici/") + ResimAdi);
                //Şimdi ise bu kayıt ettiğimiz resmi Bitmap nesnesi şeklinde alıyoruz.
                Bitmap Resim = new Bitmap(Server.MapPath("/ProfilUploadResim/Ogrenci/gecici/") + ResimAdi);
                int Genislik = 100;
                int Yukseklik = 100;
                //Boyutlarını veriyoruz.
                Size Boyut = new Size(Genislik, Yukseklik);
                //Resmi boyutlandırıyoruz.
                Bitmap BoyutlandirilmisResim = new Bitmap(Resim, Boyut);
                string BoyutlanmisKayit = "/ProfilUploadResim/Ogrenci/" + ResimAdi;
                //Boyutlanmış resmi Resimler/BoyutluResimler dizinine kayıt ediyoruz.
                BoyutlandirilmisResim.Save(Server.MapPath(BoyutlanmisKayit), ImageFormat.Jpeg);
                Resim.Dispose();
                BoyutlandirilmisResim.Dispose();
                //Geçici olarak kaydedilen resmi siliyoruz.
                FileInfo IlkResimDosyasi = new FileInfo(Server.MapPath("/ProfilUploadResim/Ogrenci/gecici/") + ResimAdi);
                IlkResimDosyasi.Delete();
            }
            OleDbCommand cmdguncel = new OleDbCommand("Update ogrenciler set ogrenciprofilresim=@ogrenciprofilresim where ogrenciid=" + ogrenciid + "", conn);
            cmdguncel.Parameters.AddWithValue("@ogrenciprofilresim", fuOgrenciResim.PostedFile.FileName);
            cmdguncel.ExecuteNonQuery();
            bilgilendirme.Text = "Profil resmi güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            yukleniyor.Visible = true;
            ogrencipanel.Visible = false;
            Response.AddHeader("REFRESH", "2;URL=hesabim.aspx");
            conn.Close();
        }
    }
    protected void btnSifreDegistir_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void btnBilgilerim_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        if (Session["ogretmen"] != null)
        {
            ogretmenpanelguncel.Visible = true;
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
            {
                conn.Open();
                OleDbCommand kmt = new OleDbCommand("select * from ogretmenler where ogretmenkullaniciadi='" + Session["ogretmen"].ToString() + "'", conn);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    ogretmenkullanadi.Text = oku["ogretmenkullaniciadi"].ToString();
                    ogrteposta.Text = oku["eposta"].ToString();
                    ddlogretmensube.SelectedValue = oku["bulundugusube"].ToString();
                    ogrtadsyd.Text = oku["ogretmenadsoyad"].ToString();
                    ogretmenresim.ImageUrl = "/ProfilUploadResim/Ogretmen/" + oku["ogretmenprofilresim"].ToString();
                    ogrtmentel.Text = oku["telno"].ToString();
                    adres.Text = oku["adres"].ToString();
                }
                conn.Close();
            }
        }
        if (Session["ogrenci"] != null)
        {
            ogrencipanel.Visible = true;
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
            {
                conn.Open();
                OleDbCommand kmt = new OleDbCommand("select * from ogrenciler where ogrencikadi='" + Session["ogrenci"].ToString() + "'", conn);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lblKulAdi.Text = oku["ogrencikadi"].ToString();
                    lblE_Posta.Text = oku["eposta"].ToString();
                    lblOgrenciAdSoyad.Text = oku["ogrenciadsoyad"].ToString();
                    lblOkudugunuzOkul.Text = oku["okul"].ToString();
                    ogrenciResim.ImageUrl = "/ProfilUploadResim/Ogrenci/" + oku["ogrenciprofilresim"].ToString();
                    txtVeliAdi.Text = oku["veliadsoyad"].ToString();
                    txtTelNo.Text = oku["velitel"].ToString();
                    ddlSube.SelectedValue = oku["sube"].ToString();
                    txtCepTelNo.Text = oku["veliceptel"].ToString();
                    ddlSinif.SelectedValue = oku["sinif"].ToString();
                }
                conn.Close();
            }
        }
       
    }
    protected void btnOgrenciler_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        veriogrenci();
    }

    protected void btnOgrenciBilgiGuncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand kmt = new OleDbCommand("Update ogrenciler set sube=@sube, sinif=@sinif, veliadsoyad=@veliadsoyad,velitel=@velitel, veliceptel=@veliceptel where ogrencikadi='" + Session["ogrenci"].ToString() + "'", conn);
            kmt.Parameters.AddWithValue("@sube", ddlSube.SelectedValue);
            kmt.Parameters.AddWithValue("@sinif", ddlSinif.Text);
            kmt.Parameters.AddWithValue("@veliadsoyad", txtVeliAdi.Text);
            kmt.Parameters.AddWithValue("@velitel", txtTelNo.Text);
            kmt.Parameters.AddWithValue("@veliceptel", txtCepTelNo.Text);
            kmt.ExecuteNonQuery();
            bilgilendirme.Text = "Bilgileriniz başarıyla güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            ogrencipanel.Visible = false;
            yukleniyor.Visible = true;
            Response.AddHeader("REFRESH", "2;URL=hesabim.aspx");
            conn.Close();

        }
    }
    protected void btnSifreGuncelle_Click(object sender, EventArgs e)
    {
        if (Session["ogretmen"] != null)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
            {
                conn.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from ogretmenler where ogretmenkullaniciadi='" + Session["ogretmen"].ToString() + "'", conn);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    sifre = oku["sifre"].ToString();
                }
                if (sifre != txtEskiSifre.Text)
                {
                    lblEskiSifreBilgi.Text = "Eski şifrenizi yanlış girdiniz..";
                    lblEskiSifreBilgi.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (txtYeniSifre.Text != txtSifreTekrar.Text)
                {
                    lblYeniSifreBilgi.Text = "Yeni şifreler uyuşmuyor..";
                    lblYeniSifreBilgi.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (txtYeniSifre.Text.Length < 6)
                {
                    lblYeniSifreTekrarBilgi.Text = "Yeni şifre en az 6 karakter olması gerekir...";
                    lblYeniSifreTekrarBilgi.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                OleDbCommand kmtguncelle = new OleDbCommand("Update ogretmenler set sifre=@sifre where ogretmenkullaniciadi='" + Session["ogretmen"].ToString() + "'", conn);
                kmtguncelle.Parameters.AddWithValue("@sifre", txtYeniSifre.Text);
                kmtguncelle.ExecuteNonQuery();
                bilgilendirme.Text = "Şifreniz güncellendi..";
                bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
                sifrepanel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=hesabim.aspx");
                conn.Close();

            }
        }
        if (Session["ogrenci"] != null)
        {
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
            {
                conn.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from ogrenciler where ogrencikadi='" + Session["ogrenci"].ToString() + "'", conn);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    sifre = oku["ogrencisifre"].ToString();
                }
                if (sifre != txtEskiSifre.Text)
                {
                    lblEskiSifreBilgi.Text = "Eski şifrenizi yanlış girdiniz..";
                    lblEskiSifreBilgi.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (txtYeniSifre.Text != txtSifreTekrar.Text)
                {
                    lblYeniSifreBilgi.Text = "Yeni şifreler uyuşmuyor..";
                    lblYeniSifreBilgi.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (txtYeniSifre.Text.Length < 6)
                {
                    lblYeniSifreTekrarBilgi.Text = "Yeni şifre en az 6 karakter olması gerekir...";
                    lblYeniSifreTekrarBilgi.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                OleDbCommand kmtguncelle = new OleDbCommand("Update ogrenciler set ogrencisifre=@ogrencisifre where ogrencikadi='" + Session["ogrenci"].ToString() + "'", conn);
                kmtguncelle.Parameters.AddWithValue("@ogrencisifre", txtYeniSifre.Text);
                kmtguncelle.ExecuteNonQuery();
                bilgilendirme.Text = "Şifreniz güncellendi..";
                bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
                sifrepanel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=hesabim.aspx");
                conn.Close();

            }
        }
        
    }
    protected void veriogrenci()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from ogrenciler", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Liste_Ogrenciler.DataSource = dt;
            Liste_Ogrenciler.DataBind();
            conn.Close();
        }
    }
    protected void Liste_Ogrenciler_ItemCommand(object source, DataListCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Sil")
            {
                OleDbCommand cmdsil = new OleDbCommand("delete from ogrenciler where ogrenciid=" + e.CommandArgument + "", conn);
                cmdsil.ExecuteNonQuery();
                bilgilendirme.Text = "Öğrenci kaydı silindi..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                ogrencilerlistelepanel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=hesabim.aspx");
            }
            conn.Close();
        }
    }

    protected void ogrtmenresimguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (ogrresim.HasFile)
            {

                string ResimUzantisi = Path.GetExtension(ogrresim.PostedFile.FileName);
                string ResimAdi = ogrresim.PostedFile.FileName;
                //Geçici olarak FileUpload nesnemizdeki resmi Resimler dizinine kayıt ediyoruz.
                ogrresim.SaveAs(Server.MapPath("/ProfilUploadResim/Ogretmen/gecici/") + ResimAdi);
                //Şimdi ise bu kayıt ettiğimiz resmi Bitmap nesnesi şeklinde alıyoruz.
                Bitmap Resim = new Bitmap(Server.MapPath("/ProfilUploadResim/Ogretmen/gecici/") + ResimAdi);
                int Genislik = 100;
                int Yukseklik = 100;
                //Boyutlarını veriyoruz.
                Size Boyut = new Size(Genislik, Yukseklik);
                //Resmi boyutlandırıyoruz.
                Bitmap BoyutlandirilmisResim = new Bitmap(Resim, Boyut);
                string BoyutlanmisKayit = "/ProfilUploadResim/Ogretmen/" + ResimAdi;
                //Boyutlanmış resmi Resimler/BoyutluResimler dizinine kayıt ediyoruz.
                BoyutlandirilmisResim.Save(Server.MapPath(BoyutlanmisKayit), ImageFormat.Jpeg);
                Resim.Dispose();
                BoyutlandirilmisResim.Dispose();
                //Geçici olarak kaydedilen resmi siliyoruz.
                FileInfo IlkResimDosyasi = new FileInfo(Server.MapPath("/ProfilUploadResim/Ogretmen/gecici/") + ResimAdi);
                IlkResimDosyasi.Delete();
            }
            OleDbCommand cmdguncel = new OleDbCommand("Update ogretmenler set ogretmenprofilresim=@ogretmenprofilresim where ogretmen_id=" + ogrenciid + "", conn);
            cmdguncel.Parameters.AddWithValue("@ogretmenprofilresim", ogrresim.PostedFile.FileName);
            cmdguncel.ExecuteNonQuery();
            bilgilendirme.Text = "Profil resmi güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            yukleniyor.Visible = true;
            ogretmenpanelguncel.Visible = false;
            Response.AddHeader("REFRESH", "2;URL=hesabim.aspx");
            conn.Close();
        }
    }
    protected void bilgiogretmenguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand kmt = new OleDbCommand("Update ogretmenler set bulundugusube=@bulundugusube, adres=@adres, telno=@telno where ogretmenkullaniciadi='" + Session["ogretmen"].ToString() + "'", conn);
            kmt.Parameters.AddWithValue("@bulundugusube", ddlogretmensube.SelectedValue);
            kmt.Parameters.AddWithValue("@adres", adres.Text);
            kmt.Parameters.AddWithValue("@telno", ogrtmentel.Text);
            kmt.ExecuteNonQuery();
            bilgilendirme.Text = "Bilgileriniz başarıyla güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            ogretmenpanelguncel.Visible = false;
            yukleniyor.Visible = true;
            Response.AddHeader("REFRESH", "2;URL=hesabim.aspx");
            conn.Close();

        }
    }
}