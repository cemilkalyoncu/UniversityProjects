using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_Mesajlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        verilericekiletisim();
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
    protected void ListeMesajlar_ItemCommand(object source, DataListCommandEventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            if (e.CommandName == "Delete")
            {
                OleDbCommand cmdsil = new OleDbCommand("delete from iletisim_bilgi where iletisim_id=" + e.CommandArgument + "", conn);
                cmdsil.ExecuteNonQuery();
                bilgilendirme.Text = "Mesaj kaydı silindi..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                Mesajpanelgoster.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=mesajlar.aspx");
            }
            conn.Close();
        }
    }
}