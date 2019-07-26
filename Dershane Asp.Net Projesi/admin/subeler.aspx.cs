using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_subeler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Listesubeverilericek();
    }
    protected void Listesubeverilericek()
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from subeler", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Liste_Subeler.DataSource = dt;
            Liste_Subeler.DataBind();
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
            bilgilendirme.Text = "Şube kaydı gerçekleştirildi..";
            bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            subeekpanel.Visible = false;
            yukleniyor.Visible = true;
            Response.AddHeader("REFRESH", "2;URL=subeler.aspx");
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
                OleDbCommand cmd = new OleDbCommand("delete from subeler where Sube_id=" + e.CommandArgument + "", conn);
                cmd.ExecuteNonQuery();
                bilgilendirme.Text = "Şube kaydı silindi..";
                bilgilendirme.ForeColor = System.Drawing.Color.Red;
                subeekpanel.Visible = false;
                yukleniyor.Visible = true;
                Response.AddHeader("REFRESH", "2;URL=subeler.aspx");
            }
            conn.Close();
        }
    }
}