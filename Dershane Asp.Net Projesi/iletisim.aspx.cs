using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand kmt = new OleDbCommand("select * from iletisimsitebilgi",conn);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                iletisimadres.Text = oku["adres"].ToString();
                pk.Text = oku["pk"].ToString();
                tel.Text = oku["tel"].ToString();
                fax.Text = oku["fax"].ToString();
                eposta.Text = oku["eposta"].ToString();
                sube.Text = oku["sube"].ToString();
                adrestext.Text = oku["adres2"].ToString();
                tel2.Text = oku["tel2"].ToString();
                fax2.Text = oku["fax2"].ToString();
                eposta2.Text = oku["eposta2"].ToString();
                map.Text = oku["googlemap"].ToString();
            }
            conn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert Into iletisim_Bilgi(Ad_Soyad,E_Posta,Telefon,Mesaj,Zaman) values (@1,@2,@3,@4,@5)", conn);

            cmd.Parameters.AddWithValue("@1", textBox_Adi.Text +" "+ textBox_Soyadi.Text);
            cmd.Parameters.AddWithValue("@2", textBox_E_Posta.Text);
            cmd.Parameters.AddWithValue("@3", textBox_Telefon.Text);
            cmd.Parameters.AddWithValue("@4", textBox_Mesaj.Text);
            cmd.Parameters.AddWithValue("@5", DateTime.Now.ToString("dd/MM/yy HH:mm"));

            cmd.ExecuteNonQuery();
            Label_ileti.Text = "Mesajınız Gönderildi..";
            Label_ileti.ForeColor = System.Drawing.Color.LimeGreen;
            conn.Close();
        }
    }
}