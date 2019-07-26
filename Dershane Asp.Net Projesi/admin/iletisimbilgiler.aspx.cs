using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class admin_iletisimbilgiler : System.Web.UI.Page
{
    public string iletid
    {
        get
        {
            if (ViewState["iletid"] == null)
                ViewState["iletid"]="";
            return ViewState["iletid"].ToString();
        }
        set
        {
            ViewState["iletid"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        verilericekiletisim();
    }
    protected void verilericekiletisim()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from iletisimsitebilgi", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ListeMesajlar.DataSource = dt;
            ListeMesajlar.DataBind();
            conn.Close();
        }
    }
    protected void ListeMesajlar_ItemCommand(object source, DataListCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Guncelle")
            {
                iletid =Convert.ToString(e.CommandArgument);
                iletisimbilgileripanel.Visible = true;
                OleDbCommand cmd = new OleDbCommand("select * from iletisimsitebilgi where id="+e.CommandArgument,conn);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    adres.Text=oku["adres"].ToString();
                    pk.Text=oku["pk"].ToString();
                    tel.Text=oku["tel"].ToString();
                    fax.Text=oku["fax"].ToString();
                    eposta.Text=oku["eposta"].ToString();
                    sube.Text=oku["sube"].ToString();
                    yayinadres.Text=oku["adres2"].ToString();
                    yayintel.Text=oku["tel2"].ToString();
                    yayinfax.Text=oku["fax2"].ToString();
                    yayineposta.Text=oku["eposta2"].ToString();
                    googleMap.Text=oku["googlemap"].ToString();
                }
            }
            conn.Close();
        }
    }
    protected void iletisimguncelle_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand kmt = new OleDbCommand("Update iletisimsitebilgi set adres=@adres,pk=@pk,tel=@tel,fax=@fax,eposta=@eposta,sube=@sube,adres2=@adres2,tel2=@tel2,fax2=@fax2,eposta2=@eposta2,googlemap=@googlemap where id="+iletid, conn);
            kmt.Parameters.AddWithValue("@adres",adres.Text);
            kmt.Parameters.AddWithValue("@pk",pk.Text);
            kmt.Parameters.AddWithValue("@tel",tel.Text);
            kmt.Parameters.AddWithValue("@fax",fax.Text);
            kmt.Parameters.AddWithValue("@eposta",eposta.Text);
            kmt.Parameters.AddWithValue("@sube",sube.Text);
            kmt.Parameters.AddWithValue("@adres2",yayinadres.Text);
            kmt.Parameters.AddWithValue("@tel2",yayintel.Text);
            kmt.Parameters.AddWithValue("@fax2",yayinfax.Text);
            kmt.Parameters.AddWithValue("@eposta2",yayineposta.Text);
            kmt.Parameters.AddWithValue("@googlemap",googleMap.Text);
            kmt.ExecuteNonQuery();
            conn.Close();
            iletisimbilgileripanel.Visible = false;
            iletbilgicekpanel.Visible = false;
            yukleniyor.Visible = true;
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            bilgilendirme.Text = "İletişim bilgileriniz güncellendi...";
            Response.AddHeader("REFRESH", "2;URL=iletisimbilgiler.aspx");
        }
    }
}