using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void girisyap_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmdyonetici = new OleDbCommand("Select * from yoneticiler where yoneticikadi='" + kullaniciadi.Text + "' and yoneticisifre='" + sifre.Text + "'", conn);
            OleDbDataReader okuyonetici = cmdyonetici.ExecuteReader();
            if (okuyonetici.Read())
            {
                Session["yoneticigiris"] = "1";
                Session["yonetici"] = okuyonetici["yoneticikadi"].ToString();
                Response.Redirect("default.aspx");
            }
            else
            {
                bilgi.Text = "Kullanıcı adı veya şifre yanlış..";
                bilgi.ForeColor = System.Drawing.Color.Red;
            }
            conn.Close();
        }
    }
}