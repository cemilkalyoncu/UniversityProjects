using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_sayfaduzenle : System.Web.UI.Page
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
        verilericekiletisim();
    }
    protected void Listesayfalar_ItemCommand(object source, DataListCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Guncelle")
            {
                iletid = Convert.ToString(e.CommandArgument);
                listesayfapanelguncel.Visible = true;
                OleDbCommand cmd = new OleDbCommand("select * from uzunmetin where metin_id=" + e.CommandArgument, conn);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    sayfadi.Text = oku["sayfaadi"].ToString();
                    aciklama.Text = oku["uzun_Metin"].ToString();
                }
            }
            conn.Close();
        }
    }
    protected void verilericekiletisim()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from uzunmetin", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Listesayfalar.DataSource = dt;
            Listesayfalar.DataBind();
            conn.Close();
        }
    }
    protected void islemyap_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand kmt = new OleDbCommand("Update uzunmetin set uzun_Metin=@uzun_Metin where metin_id=" + iletid, conn);
            kmt.Parameters.AddWithValue("@uzun_Metin", aciklama.Text);
            kmt.ExecuteNonQuery();
            bilgilendirme.Text = "Bilgiler Güncellendi";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            yukleniyor.Visible = true;
            genelsayfaduzenle.Visible = false;
            Response.AddHeader("REFRESH", "2;URL=sayfaduzenle.aspx");
        }
    }
}