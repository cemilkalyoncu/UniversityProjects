using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_haberler : System.Web.UI.Page
{
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
        verilericekhaberler();
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
    protected void haberekleme_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (haberekleme.Text == "Haber Ekle")
            {
                OleDbCommand cmd = new OleDbCommand("insert into haberler (haberler,haber_durum) values (@1,@2)", conn);
                cmd.Parameters.AddWithValue("@1", habermetin.Text);
                cmd.Parameters.AddWithValue("@2", haberdurum.Text);
                cmd.ExecuteNonQuery();
                bilgilendirme.Text = "Haber kaydı gerçekleştirildi..";
                bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
                haberekpanel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=haberler.aspx");
            }
            if (haberekleme.Text == "Haberi Güncelle")
            {
                OleDbCommand cmdguncelle = new OleDbCommand("Update haberler set haberler=@haberler, haber_durum=@haber_durum where haber_id=" + haberid + "", conn);
                cmdguncelle.Parameters.AddWithValue("@haberler", habermetin.Text);
                cmdguncelle.Parameters.AddWithValue("@haber_durum", haberdurum.Text);
                cmdguncelle.ExecuteNonQuery();
                bilgilendirme.Text = "Haber kaydı güncellendi..";
                bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
                haberekpanel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=haberler.aspx");
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
                OleDbCommand cmdsil = new OleDbCommand("delete from haberler where haber_id=" + e.CommandArgument + "", conn);
                cmdsil.ExecuteNonQuery();
                bilgilendirme.Text = "Haber kaydı silindi..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                haberekpanel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=haberler.aspx");
            }
            if (e.CommandName == "Update")
            {
                haberid = Convert.ToString(e.CommandArgument);
                haberekleme.Text = "Haberi Güncelle";
                OleDbCommand cmdguncel = new OleDbCommand("select * from haberler where haber_id=" + haberid + "", conn);
                OleDbDataReader dr = cmdguncel.ExecuteReader();
                while (dr.Read())
                {
                    habermetin.Text = dr["haberler"].ToString();
                    haberdurum.Text = dr["haber_durum"].ToString();
                }
            }
            conn.Close();
        }

    }
}