using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_adminDuzen : System.Web.UI.Page
{
    public string iletid
    {
        get
        {
            if (ViewState["iletid"] == null)
                ViewState["iletid"] = "";
            return ViewState["iletid"].ToString();
        }
        set
        {
            ViewState["iletid"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        vericek();
    }
    void vericek()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
        conn.Open();
        OleDbCommand cmd = new OleDbCommand("select * from yoneticiler",conn);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Liste.DataSource = dt;
        Liste.DataBind();
        conn.Close();
        }
    }
    protected void Liste_ItemCommand(object source, DataListCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Sil")
            {
                OleDbCommand cmd = new OleDbCommand("delete from yoneticiler where yonetici_id=" + e.CommandArgument, conn);
                cmd.ExecuteNonQuery();
                bilgilendirme.Text = "Admin kaydı silindi..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                panel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=adminduzen.aspx");
            }
            if (e.CommandName == "Guncelle")
            {
                    data.Visible = false;
                    tablebilgiler.Visible = true;
                     iletid=Convert.ToString(e.CommandArgument);
                    OleDbCommand cmd = new OleDbCommand("select * from yoneticiler where yonetici_id=" + iletid, conn);
                    OleDbDataReader oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        kadi.Text = oku["yoneticikadi"].ToString();
                    }
            }
            conn.Close();
        }
    }
    protected void islem_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            if (ysifre.Text.Length < 6)
            {
            bilgilendirme.Text = "Şifreniz en az 6 karakter olmalıdır";
            bilgilendirme.ForeColor = System.Drawing.Color.Red;
            return;
            }
            if (ysifre.Text != ysifretkrar.Text)
            {
               bilgilendirme.Text = "Yeni şifreler uyuşmuyor..";
            bilgilendirme.ForeColor = System.Drawing.Color.Red;
            return; 
            }
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("update yoneticiler set yoneticisifre=@yoneticisifre where yonetici_id="+iletid, conn);
            cmd.Parameters.AddWithValue("@yoneticisifre",ysifre.Text);
            cmd.ExecuteNonQuery();
            bilgilendirme.Text = "Admin şifre kaydı güncellendi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            panel.Visible = false;
            yukleniyor.Visible = true;
            Response.AddHeader("REFRESH", "2;URL=adminduzen.aspx");
        }
    }
}