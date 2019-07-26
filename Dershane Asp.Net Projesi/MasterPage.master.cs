using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelTarih.Text ="Tarih: " + DateTime.Now.ToString();
        
      
        if (Session["ogretmengiris"] != null)
        {
            oturum.Text = Session["ogretmen"].ToString();
            girisyapmapaneli.Visible = false;
            girisyapilanpanel.Visible = true;
            hesap.Text = "HESABIM";
            
         
        }
        if (Session["ogrencigiris"] != null)
        {
            oturum.Text = Session["ogrenci"].ToString();
            girisyapmapaneli.Visible = false;
            girisyapilanpanel.Visible = true;
            hesap.Text = "HESABIM";
        }
    }
        protected void giris_yap_Click(object sender, EventArgs e)
        {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (tur_ddl.SelectedValue == "Öğretmen")
            {
                OleDbCommand cmdogretmen = new OleDbCommand("Select * from ogretmenler where ogretmenkullaniciadi='" + giriskadi.Text + "' and sifre='" + girissifre.Text + "'", conn);
                OleDbDataReader okuogretmen = cmdogretmen.ExecuteReader();
                if (okuogretmen.Read())
                {
                    Session["ogretmengiris"] = "1";
                    Session["ogretmen"] = okuogretmen["ogretmenkullaniciadi"].ToString();
                    Response.Redirect("default.aspx");
                }
                else
                {
                    girisbilgilendirme.Text = "Kullanıcı adı veya şifre yanlış!!";
                    girisbilgilendirme.ForeColor = System.Drawing.Color.Red;
                }

            }
            if (tur_ddl.SelectedValue == "Öğrenci")
            {
                OleDbCommand cmdogrenci = new OleDbCommand("Select * from ogrenciler where ogrencikadi='" + giriskadi.Text + "' and ogrencisifre='" + girissifre.Text + "'", conn);
                OleDbDataReader okuogrenci = cmdogrenci.ExecuteReader();
                if (okuogrenci.Read())
                {
                    Session["ogrencigiris"] = "1";
                    Session["ogrenci"] = okuogrenci["ogrencikadi"].ToString();
                    Response.Redirect("default.aspx");
                }
                else
                {
                    girisbilgilendirme.Text = "Kullanıcı adı veya şifre yanlış!!";
                    girisbilgilendirme.ForeColor = System.Drawing.Color.Red;
                }
            }

        }
    }

             protected void cikisyap_Click(object sender, EventArgs e)
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("default.aspx");
            }
             protected void hesap_Click(object sender, EventArgs e)
             {
                 if (hesap.Text == "HESABIM")
                 {
                     Response.Redirect("hesabim.aspx");
                 }
                 if (hesap.Text == "UYE OL")
                 {
                     Response.Redirect("uye_ol.aspx");
                 }
             }
             protected void hesabim_Click(object sender, EventArgs e)
             {
                 Response.Redirect("hesabim.aspx");
             }
}
