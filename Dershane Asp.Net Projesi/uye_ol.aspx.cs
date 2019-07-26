using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class uye_ol : System.Web.UI.Page
{
    string ogrncikadi, email;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void uyeol_islem_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmdoku = new OleDbCommand("select * from ogrenciler", conn);
            OleDbDataReader droku = cmdoku.ExecuteReader();
            while (droku.Read())
            {
                ogrncikadi = droku["ogrencikadi"].ToString();
                email = droku["eposta"].ToString();
            }
            if (email == eposta.Text)
            {
                bilgilendirme.Text = "Bu e-posta bulunmaktadır..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (ogrencisifre.Text.Length < 6)
            {
                bilgilendirme.Text = "Şifre Minimum 6, Maximum 15 Karakter olması gerekir";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (ogrencisifre.Text.Length > 15)
            {
                bilgilendirme.Text = "Şifre Minimum 6, Maximum 15 Karakter olması gerekir";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (ogrncikadi == ogrencikadi.Text)
            {
                bilgilendirme.Text = "Bu kullanıcı bulunmaktadır..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                return;
            }
            profilresim.SaveAs(Server.MapPath("ProfilUploadResim/Ogrenci/") + ogrencikadi.Text + profilresim.PostedFile.FileName);
            OleDbCommand cmd = new OleDbCommand("insert into ogrenciler (ogrenciprofilresim,ogrencikadi,ogrencisifre,ogrenciadsoyad,eposta,veliadsoyad,sube,okul,sinif,velitel,veliceptel) values (@ogrenciprofilresim,@ogrencikadi,@ogrencisifre,@ogrenciadsoyad,@eposta,@veliadsoyad,@sube,@okul,@sinif,@velitel,@veliceptel)", conn);
            cmd.Parameters.AddWithValue("@ogrenciprofilresim", ogrencikadi.Text + profilresim.PostedFile.FileName);
            cmd.Parameters.AddWithValue("@ogrencikadi", ogrencikadi.Text);
            cmd.Parameters.AddWithValue("@ogrencisifre", ogrencisifre.Text);
            cmd.Parameters.AddWithValue("@ogrenciadsoyad", ogrenciadi.Text);
            cmd.Parameters.AddWithValue("@eposta", eposta.Text);
            cmd.Parameters.AddWithValue("@veliadsoyad", veliadi.Text);
            cmd.Parameters.AddWithValue("@sube", sube_ddl.SelectedValue);
            cmd.Parameters.AddWithValue("@okul", okunanokul.Text);
            cmd.Parameters.AddWithValue("@sinif", sinif_ddl.SelectedValue);
            cmd.Parameters.AddWithValue("@velitel", telno.Text);
            cmd.Parameters.AddWithValue("@veliceptel", ceptelno.Text);
            cmd.ExecuteNonQuery();
            bilgilendirme.Text = "Kaydınız yapıldı...";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            conn.Close();
        }
    }
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
    protected void profilresimguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            profilresim.SaveAs(Server.MapPath("ProfilUploadResim/Ogrenci/") + profilresim.PostedFile.FileName);
            OleDbCommand cmdguncel = new OleDbCommand("Update ogrenci set ogrenciprofilresim=@ogrenciprofilresim where ogrenciid=" + ogrenciid + "", conn);
            cmdguncel.Parameters.AddWithValue("@ogrenciprofilresim", profilresim.PostedFile.FileName);
            cmdguncel.ExecuteNonQuery();
            bilgilendirme.Text = "Resim güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            conn.Close();
        }
    }
}