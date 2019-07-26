using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_panel : System.Web.UI.Page
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
    public string haberid
    {
        get
        {
            if (ViewState["haberid"] == null)
                ViewState["haberid"] = "";
            return ViewState["haberid"].ToString();
        }
        set
        {
            ViewState["haberid"] = value;
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["yoneticigiris"] != "1")
        //{
        //    Response.Redirect("default.aspx");
        //}
        verilericek();
        verilericekhaberler();
        verilericekiletisim();
    }
    protected void ogretmenekle_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void haberekle_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        if (habermetin.Text != null || haberdurum.Text != null)
        {
            habertemizle.Visible = true;
        }
    }
    protected void subeekle_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        Listesubeverilericek();
    }
    protected void Mesajlar_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 3;
    }
    protected void ogretmenekleguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
        if (ogretmenekleguncelle.Text=="Öğretmen Ekle")
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
                return;
            }
            if (ogrtmnkadi == ogretmenkullaniciadi.Text)
            {
                bilgilendirme.Text = "Bu kullanıcı adı kullanılıyor...";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (ogretmensifre.Text.Length < 6)
            {
                bilgilendirme.Text = "Şifre en az 6 karakter olmalıdır..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                return;
            }
            profilresim.SaveAs(Server.MapPath("ProfilUploadResim/Ogretmen/") + ogretmenkullaniciadi.Text + profilresim.PostedFile.FileName);
            OleDbCommand cmd = new OleDbCommand("insert into ogretmenler (ogretmenadsoyad,bulundugusube,sifre,eposta,telno,adres,ogretmenkullaniciadi,ogretmenprofilresim) values (@ogretmenadsoyad,@bulundugusube,@sifre,@eposta,@telno,@adres,@ogretmenkullaniciadi,@ogretmenprofilresim)", conn);
            cmd.Parameters.AddWithValue("@ogretmenadsoyad", ogretmenadi.Text );
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
        }
        if (ogretmenekleguncelle.Text == "Öğretmen Güncelle")
        {
            OleDbCommand kmtguncel = new OleDbCommand("Update ogretmenler set ogretmenadsoyad=@ogretmenadsoyad, bulundugusube=@bulundugusube, sifre=@sifre, eposta=@eposta, telno=@telno, adres=@adres, ogretmenkullaniciadi=@ogretmenkullaniciadi where ogretmen_id="+ogretmenid+"", conn);
            kmtguncel.Parameters.AddWithValue("@ogretmenadsoyad", ogretmenadi.Text);
            kmtguncel.Parameters.AddWithValue("@bulundugusube", DropDownList1.SelectedValue);
            kmtguncel.Parameters.AddWithValue("@sifre", ogretmensifre.Text);
            kmtguncel.Parameters.AddWithValue("@eposta", ogretmeneposta.Text);
            kmtguncel.Parameters.AddWithValue("@telno", ogretmentelno.Text);
            kmtguncel.Parameters.AddWithValue("@adres", ogretmenadres.Text);
            kmtguncel.Parameters.AddWithValue("@ogretmenkullaniciadi", ogretmenkullaniciadi.Text);
            kmtguncel.ExecuteNonQuery();
            bilgilendirme.Text = "Öğretmen kaydı güncellendi...";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
        }
        conn.Close();
        }
    }
    protected void verilericek()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from ogretmenler",conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ListeOgretmenler.DataSource = dt;
            ListeOgretmenler.DataBind();
            conn.Close();
        }
    }
    protected void verilericekhaberler()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from haberler", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ListeHaberler.DataSource = dt;
            ListeHaberler.DataBind();
            conn.Close();
        }
    }
    protected void verilericekiletisim()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from iletisim_bilgi", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ListeMesajlar.DataSource = dt;
            ListeMesajlar.DataBind();
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
            ogretmenid =Convert.ToString(e.CommandArgument);
            OleDbCommand cmdguncel = new OleDbCommand("Select * from ogretmenler where ogretmen_id=" + ogretmenid + "", conn);
            OleDbDataReader dr = cmdguncel.ExecuteReader();
            while (dr.Read())
            {
                ogretmenadi.Text = dr["ogretmenadsoyad"].ToString();
                ogretmenkullaniciadi.Text = dr["ogretmenkullaniciadi"].ToString();
                ogretmentelno.Text = dr["telno"].ToString();
                ogretmeneposta.Text = dr["eposta"].ToString();
                ogretmenadres.Text=dr["adres"].ToString();
                DropDownList1.SelectedValue = dr["bulundugusube"].ToString();
                Image1.ImageUrl = "ProfilUploadResim/Ogretmen/" + dr["ogretmenprofilresim"].ToString();
            }
            ogretmenekleguncelle.Text = "Öğretmen Güncelle";
            profilresimguncelle.Visible = true;
            RequiredFieldValidator6.ValidationGroup = "resim";
        }
        if (e.CommandName == "Delete")
        {
            OleDbCommand cmd = new OleDbCommand("delete from ogretmenler where ogretmen_id="+e.CommandArgument+"",conn);
            cmd.ExecuteNonQuery();
            bilgilendirme.Text = "Öğretmen silindi...";
            bilgilendirme.ForeColor = System.Drawing.Color.Red;
        }
        conn.Close();
        }
    }
    protected void temizle_Click(object sender, EventArgs e)
    {
            profilresimguncelle.Visible = false;
            ogretmenekleguncelle.Text = "Öğretmen Ekle";
            RequiredFieldValidator6.ValidationGroup = "ogretmenuyelik";
            ogretmenkullaniciadi.Text = "";
            ogretmenadi.Text = "";
            ogretmeneposta.Text = "";
            ogretmenadres.Text = "";
            ogretmentelno.Text = "";
            Image1.ImageUrl = null;
            bilgilendirme.Text = "";
    }
    protected void profilresimguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            profilresim.SaveAs(Server.MapPath("ProfilUploadResim/Ogretmen/") + profilresim.PostedFile.FileName);
            OleDbCommand cmdguncel = new OleDbCommand("Update ogretmenler set ogretmenprofilresim=@ogretmenprofilresim where ogretmen_id=" + ogretmenid + "", conn);
            cmdguncel.Parameters.AddWithValue("@ogretmenprofilresim",profilresim.PostedFile.FileName);
            cmdguncel.ExecuteNonQuery();
            bilgilendirme.Text = "Resim güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            conn.Close();
        }
    }
    protected void haberekleme_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
        if (haberekleme.Text=="Haber Ekle")
        {
        OleDbCommand cmd = new OleDbCommand("insert into haberler (haberler,haber_durum) values (@1,@2)", conn);
        cmd.Parameters.AddWithValue("@1", habermetin.Text);
        cmd.Parameters.AddWithValue("@2", haberdurum.Text);
        cmd.ExecuteNonQuery();
        bilgilendirme.Text = "Başarıyla Kaydedildi..";
        bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
        }
        if (haberekleme.Text == "Haberi Güncelle")
        {
            OleDbCommand cmdguncelle = new OleDbCommand("Update haberler set haberler=@haberler, haber_durum=@haber_durum where haber_id="+haberid+"",conn);
            cmdguncelle.Parameters.AddWithValue("@haberler",habermetin.Text);
            cmdguncelle.Parameters.AddWithValue("@haber_durum",haberdurum.Text);
            cmdguncelle.ExecuteNonQuery();
            bilgilendirme.Text = "Haber Güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
        }
        conn.Close();
        }
    }
    protected void subemerkeziEkle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into subeler (Subeler) values (@1)", conn);
            cmd.Parameters.AddWithValue("@1", subemerkezi.Text);
            cmd.ExecuteNonQuery();
            bilgilendirme.Text = "Başarıyla Kaydedildi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            conn.Close();
        }
    }
    protected void Listesubeverilericek()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from subeler",conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Liste_Subeler.DataSource = dt;
            Liste_Subeler.DataBind();
            conn.Close();
        }
    }
    protected void Liste_Subeler_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Delete")
            {
                OleDbCommand cmd = new OleDbCommand("delete from subeler where Sube_id=" + e.CommandArgument +"", conn);
                cmd.ExecuteNonQuery();
                bilgilendirme.Text = "Şube silindi...";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
            }
            conn.Close();
        }
    }

    protected void ListeHaberler_ItemCommand(object source, DataListCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Delete")
            {
                OleDbCommand cmdsil = new OleDbCommand("delete from haberler where haber_id="+e.CommandArgument+"",conn);
                cmdsil.ExecuteNonQuery();
                haberbilgilendirme.Text = "Haber silindi...";
                haberbilgilendirme.ForeColor = System.Drawing.Color.Red;
            }
            if (e.CommandName == "Update")
            {
                haberid = Convert.ToString(e.CommandArgument);
                haberekleme.Text = "Haberi Güncelle";
                habertemizle.Visible = true;
                OleDbCommand cmdguncel = new OleDbCommand("select * from haberler where haber_id="+haberid+"", conn);
                OleDbDataReader dr = cmdguncel.ExecuteReader();
                while (dr.Read())
                {
                    habermetin.Text=dr["haberler"].ToString();
                    haberdurum.Text = dr["haber_durum"].ToString();
                }
            }
            conn.Close();
        }
           
    }
    protected void habertemizle_Click(object sender, EventArgs e)
    {
            habermetin.Text = "";
            haberdurum.Text = "";
            haberid = null;
            habertemizle.Visible = false;
            haberekleme.Text = "Haber Ekle";
            haberbilgilendirme.Text = "";
            bilgilendirme.Text = "";
    }
    protected void ListeMesajlar_ItemCommand(object source, DataListCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Delete")
            {
                OleDbCommand cmdsil = new OleDbCommand("delete from iletisim_bilgi where iletisim_id=" + e.CommandArgument + "", conn);
                cmdsil.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}