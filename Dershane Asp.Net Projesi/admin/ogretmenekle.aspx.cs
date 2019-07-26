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

public partial class admin_ogretmenekle : System.Web.UI.Page
{
    string ogrtmnkadi, ogrtmenemail, a, b;
    public string ogretmenid
    {
        get
        {
            if (ViewState["ogretmenid"] == null)
                ViewState["ogretmenid"] = "";
            return ViewState["ogretmenid"].ToString();
        }
        set
        {
            ViewState["ogretmenid"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        verilericek();
    }
    protected void ogretmenekleguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (ogretmenekleguncelle.Text == "Öğretmen Ekle")
            {
                OleDbCommand cmdoku = new OleDbCommand("select * from ogretmenler", conn);
                OleDbDataReader read = cmdoku.ExecuteReader();
                while (read.Read())
                {
                    ogrtmnkadi = read["ogretmenkullaniciadi"].ToString();
                    ogrtmenemail = read["eposta"].ToString();
                }
                if (ogrtmenemail == ogretmeneposta.Text)
                {
                    bilgilendirme.Text = "Bu e-posta kullanılıyor...";
                    bilgilendirme.ForeColor = System.Drawing.Color.Red;
                    ogretmnpanlgoster.Visible = false;
                    Response.AddHeader("REFRESH", "2;URL=ogretmenekle.aspx");  
                    return;
                }
                if (ogrtmnkadi == ogretmenkullaniciadi.Text)
                {
                    bilgilendirme.Text = "Bu kullanıcı adı kullanılıyor...";
                    bilgilendirme.ForeColor = System.Drawing.Color.Red;
                    ogretmnpanlgoster.Visible = false;
                    Response.AddHeader("REFRESH", "2;URL=ogretmenekle.aspx");
                    return;
                }
                if (ogretmensifre.Text.Length < 6)
                {
                    bilgilendirme.Text = "Şifre en az 6 karakter olmalıdır..";
                    bilgilendirme.ForeColor = System.Drawing.Color.Red;
                    ogretmnpanlgoster.Visible = false;
                    Response.AddHeader("REFRESH", "2;URL=ogretmenekle.aspx");
                    return;
                }
                if (profilresim.HasFile)
                {

                    string ResimUzantisi = Path.GetExtension(profilresim.PostedFile.FileName);
                    string ResimAdi = profilresim.PostedFile.FileName;
                    //Geçici olarak FileUpload nesnemizdeki resmi Resimler dizinine kayıt ediyoruz.
                    profilresim.SaveAs(Server.MapPath("../Ogretmen/gecici/") + ResimAdi);
                    //Şimdi ise bu kayıt ettiğimiz resmi Bitmap nesnesi şeklinde alıyoruz.
                    Bitmap Resim = new Bitmap(Server.MapPath("../Ogretmen/gecici/") + ResimAdi);
                    int Genislik = 100;
                    int Yukseklik = 100;
                    //Boyutlarını veriyoruz.
                    Size Boyut = new Size(Genislik, Yukseklik);
                    //Resmi boyutlandırıyoruz.
                    Bitmap BoyutlandirilmisResim = new Bitmap(Resim, Boyut);
                    string BoyutlanmisKayit = "../Ogretmen/" + ResimAdi;
                    //Boyutlanmış resmi Resimler/BoyutluResimler dizinine kayıt ediyoruz.
                    BoyutlandirilmisResim.Save(Server.MapPath(BoyutlanmisKayit), ImageFormat.Jpeg);
                    Resim.Dispose();
                    BoyutlandirilmisResim.Dispose();
                    //Geçici olarak kaydedilen resmi siliyoruz.
                    FileInfo IlkResimDosyasi = new FileInfo(Server.MapPath("../Ogretmen/gecici/") + ResimAdi);
                    IlkResimDosyasi.Delete();
                }
                OleDbCommand cmd = new OleDbCommand("insert into ogretmenler (ogretmenadsoyad,bulundugusube,sifre,eposta,telno,adres,ogretmenkullaniciadi,ogretmenprofilresim) values (@ogretmenadsoyad,@bulundugusube,@sifre,@eposta,@telno,@adres,@ogretmenkullaniciadi,@ogretmenprofilresim)", conn);
                cmd.Parameters.AddWithValue("@ogretmenadsoyad", ogretmenadi.Text);
                cmd.Parameters.AddWithValue("@bulundugusube", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@sifre", ogretmensifre.Text);
                cmd.Parameters.AddWithValue("@eposta", ogretmeneposta.Text);
                cmd.Parameters.AddWithValue("@telno", ogretmentelno.Text);
                cmd.Parameters.AddWithValue("@adres", ogretmenadres.Text);
                cmd.Parameters.AddWithValue("@ogretmenkullaniciadi", ogretmenkullaniciadi.Text);
                cmd.Parameters.AddWithValue("@ogretmenprofilresim", ogretmenkullaniciadi.Text + profilresim.PostedFile.FileName);
                cmd.ExecuteNonQuery();
                bilgilendirme.Text = "Öğretmen kaydı gerçekleştirildi..";
                bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
                ogretmnpanlgoster.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=ogretmenekle.aspx");
            }
            if (ogretmenekleguncelle.Text == "Öğretmen Güncelle")
            {
                OleDbCommand kmtguncel = new OleDbCommand("Update ogretmenler set ogretmenadsoyad=@ogretmenadsoyad, bulundugusube=@bulundugusube, sifre=@sifre, eposta=@eposta, telno=@telno, adres=@adres, ogretmenkullaniciadi=@ogretmenkullaniciadi where ogretmen_id=" + ogretmenid + "", conn);
                kmtguncel.Parameters.AddWithValue("@ogretmenadsoyad", ogretmenadi.Text);
                kmtguncel.Parameters.AddWithValue("@bulundugusube", DropDownList1.SelectedValue);
                kmtguncel.Parameters.AddWithValue("@sifre", ogretmensifre.Text);
                kmtguncel.Parameters.AddWithValue("@eposta", ogretmeneposta.Text);
                kmtguncel.Parameters.AddWithValue("@telno", ogretmentelno.Text);
                kmtguncel.Parameters.AddWithValue("@adres", ogretmenadres.Text);
                kmtguncel.Parameters.AddWithValue("@ogretmenkullaniciadi", ogretmenkullaniciadi.Text);
                kmtguncel.ExecuteNonQuery();
                
                bilgilendirme.Text = "Öğretmen kaydı güncellendi..";
                bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
                ogretmnpanlgoster.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=ogretmenekle.aspx");
            }
            conn.Close();
        }

    }
    protected void profilresimguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            profilresim.SaveAs(Server.MapPath("ProfilUploadResim/Ogretmen/") + profilresim.PostedFile.FileName);
            OleDbCommand cmdguncel = new OleDbCommand("Update ogretmenler set ogretmenprofilresim=@ogretmenprofilresim where ogretmen_id=" + ogretmenid + "", conn);
            cmdguncel.Parameters.AddWithValue("@ogretmenprofilresim", profilresim.PostedFile.FileName);
            cmdguncel.ExecuteNonQuery();
            bilgilendirme.Text = "Profil resmi güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            ogretmnpanlgoster.Visible = false;
            yukleniyor.Visible = true;
            Response.AddHeader("REFRESH", "2;URL=ogretmenekle.aspx");
            conn.Close();
        }
    }
    protected void ListeOgretmenler_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Update")
            {
                ogretmenid = Convert.ToString(e.CommandArgument);
                OleDbCommand cmdguncel = new OleDbCommand("Select * from ogretmenler where ogretmen_id=" + ogretmenid + "", conn);
                OleDbDataReader dr = cmdguncel.ExecuteReader();
                while (dr.Read())
                {
                    ogretmenadi.Text = dr["ogretmenadsoyad"].ToString();
                    ogretmenkullaniciadi.Text = dr["ogretmenkullaniciadi"].ToString();
                    ogretmentelno.Text = dr["telno"].ToString();
                    ogretmeneposta.Text = dr["eposta"].ToString();
                    ogretmenadres.Text = dr["adres"].ToString();
                    DropDownList1.SelectedValue = dr["bulundugusube"].ToString();
                    Image1.ImageUrl = "../ProfilUploadResim/Ogretmen/" + dr["ogretmenprofilresim"].ToString();
                }
                ogretmenekleguncelle.Text = "Öğretmen Güncelle";
                profilresimguncelle.Visible = true;
                Image1.Visible = true;
                RegularExpressionValidator2.ValidationGroup = "resim";
                RequiredFieldValidator6.ValidationGroup = "resim";
            }
            if (e.CommandName == "Delete")
            {
                OleDbCommand cmd = new OleDbCommand("delete from ogretmenler where ogretmen_id=" + e.CommandArgument + "", conn);
                cmd.ExecuteNonQuery();
                bilgilendirme.Text = "Öğretmen kaydı silindi..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                ogretmnpanlgoster.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=ogretmenekle.aspx");
            }
            conn.Close();
        }
    }
    protected void verilericek()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from ogretmenler", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ListeOgretmenler.DataSource = dt;
            ListeOgretmenler.DataBind();
            conn.Close();
        }
    }
}