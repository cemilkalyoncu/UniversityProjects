using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class online_sinav_basvurusu_online_sinav_basvurusu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_Gonder_Click(object sender, EventArgs e)
    {
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data\\vtb.accdb")))
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into online_sinav_basvuru (ad_soyad,dogum_tarihi,okul,sinif_bilgileri,bolum,e_mail,ev_tel,cep_tel,adres,sehir,posta_kodu,sube,sinav_turu) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)",conn);
            cmd.Parameters.AddWithValue("@1",textbox_Adi.Text+" "+textbox_Soyadi.Text);
            cmd.Parameters.AddWithValue("@2",TextBox_Gun.Text+"/"+TextBox_Ay.Text+"/"+TextBox_Yil.Text);
            cmd.Parameters.AddWithValue("@3",TextBox_Okul.Text);
            cmd.Parameters.AddWithValue("@4",DropDownList_Sinif_Bilgileri.SelectedValue);
            cmd.Parameters.AddWithValue("@5", RadioButtonList_Bolum.SelectedValue);
            cmd.Parameters.AddWithValue("@6",TextBox_E_Mail.Text);
            cmd.Parameters.AddWithValue("@7",TextBox_Ev_Telefonu.Text);
            cmd.Parameters.AddWithValue("@8",TextBox_Cep_Telefonu.Text);
            cmd.Parameters.AddWithValue("@9",TextBox_Adres.Text);
            cmd.Parameters.AddWithValue("@10",TextBox_Sehir.Text);
            cmd.Parameters.AddWithValue("@11", TextBox_Posta_Kodu.Text);
            cmd.Parameters.AddWithValue("@12", DropDownList_Subeler.SelectedValue);
            cmd.Parameters.AddWithValue("@13", RadioButtonList_Sinav_Turu.SelectedValue);
            cmd.ExecuteNonQuery();
            Label_Bilgilendirme.Text = "Başarıyla Kaydedildi..";
            Label_Bilgilendirme.ForeColor = System.Drawing.Color.LimeGreen;
            conn.Close();
        }
    }
}