using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Dershane_Projesi
{
    public partial class Form_Ogrenci_Kayit : Form
    {
        Int32 ogrenciid;
        public Form_Ogrenci_Kayit()
        {
            InitializeComponent();
        }
        //iliskili tablolar icin
        OleDbDataAdapter daVeli, daKimlik,daTaksit;
        DataSet dsKimlik,dsVeli,dsTaksit;

        //datagridview
        int guncel_satir, sil_satir;

        //sql komut
        OleDbCommand komut, komut2, komut3, komut4;
        //OleDbConnection A_Genel.baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\VeriTabanı\\vtb.accdb");

        //-----------------------------------------------------------------------------

        Form_Ogrenci_Taksit_Plan frmOgrenciTaksitPlan = new Form_Ogrenci_Taksit_Plan();
        Form_Ogrenci_Taksit_Ode frmOgrenciTaksitOde = new Form_Ogrenci_Taksit_Ode();

        
        private void Form_ogrenciKayit_Load(object sender, EventArgs e)
        {
            if (A_Genel.baglanti.State == ConnectionState.Closed)
            {
                A_Genel.baglanti.Open();
            }
            OleDbCommand kmtoku = new OleDbCommand("select * from ogrenci_genel_bilgi",A_Genel.baglanti);
            OleDbDataReader okukmt = kmtoku.ExecuteReader();
            while (okukmt.Read())
            {
                ogrenciid =Convert.ToInt32(okukmt["ogrenci_id"].ToString());
            }
            A_Genel.baglanti.Close();
            toolTip_Ogrenci_Kayit.SetToolTip(button_Ogrenci_Kaydet, "Öğrenci Kaydet");
            toolTip_Ogrenci_Kayit.SetToolTip(button_ileri, "Sonraki TabSayfa");
            toolTip_Ogrenci_Kayit.SetToolTip(button_ileri, "Önceki TabSayfa");
            toolTip_Ogrenci_Kayit.SetToolTip(button_Ogrenci_Kayit_Duzenle, "Öğrenci Düzenle");
            toolTip_Ogrenci_Kayit.SetToolTip(button_Ogrenci_Tüm_Kayitlar, "Tüm Kayıtlar");
            toolTip_Ogrenci_Kayit.SetToolTip(button_Yeni_Ogrenci_Kayit, "Yeni Öğrenci Kayıt");
            toolTip_Ogrenci_Kayit.SetToolTip(button_Ogrenci_Resim_Ekle, "Fotoğraf Ekle");
            toolTip_Ogrenci_Kayit.SetToolTip(button_Ogrenci_Resim_Sil, "Fotoğraf İptal");
            toolTip_Ogrenci_Kayit.SetToolTip(button_Ogrenci_Taksit_Plan, "Taksit Plan");
            toolTip_Ogrenci_Kayit.SetToolTip(button_Ogrenci_Taksit_Ode, "Taksit Öde");


            try
            {
                KayitlariGetir();
            }
            catch (Exception liste)
            {
                MessageBox.Show("Listelemede Hata: " + liste.Message);
            }

            comboiLdoldur();
            grup_ders_bolum_sinif_doldur();
        }
        private void KayitlariGetir()
        {
            string sorgu2 = "SELECT * FROM Ogrenci_Genel_Bilgi ORDER BY Ogrenci_id desc";
            OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Ogrenci Liste");
            dataGridView_Ogrenci_Genel_Bilgi.DataSource = ds2.Tables["Ogrenci Liste"];
            dataGridView_Ogrenci_Genel_Bilgi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void grup_ders_bolum_sinif_doldur()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                KayitlariGetir();

                //Combobox bolum
                string sorgu = "Select * from Bolum_Bilgi order by Bolum_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bolum_Bilgi");
                comboBox_Ogrenci_Bolum.DataSource = ds.Tables[0];
                comboBox_Ogrenci_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Ogrenci_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Ogrenci_Grubu.DataSource = ds1.Tables[0];
                comboBox_Ogrenci_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Ogrenci_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Ogrenci_Sinif.DataSource = ds2.Tables[0];
                comboBox_Ogrenci_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Ogrenci_Sinif.ValueMember = "Sinif_id";

                //Combobox danısman
                string sorgu3 = "Select * from Danisman_Bilgi order by Danisman_id asc";
                OleDbDataAdapter da3 = new OleDbDataAdapter(sorgu3, A_Genel.baglanti);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3, "Danisman_Bilgi");
                comboBox_Ogrenci_Danisman.DataSource = ds3.Tables[0];
                comboBox_Ogrenci_Danisman.DisplayMember = "Adi_Soyadi";
                comboBox_Ogrenci_Danisman.ValueMember = "Danisman_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void button_Ogrenci_Taksit_Plan_Click(object sender, EventArgs e)
        {
            if (frmOgrenciTaksitPlan.Created)
            {
                frmOgrenciTaksitPlan.ShowDialog();
            }
            else
            {
                frmOgrenciTaksitPlan = new Form_Ogrenci_Taksit_Plan();
                frmOgrenciTaksitPlan.ShowDialog();
            }
        }

        private void btnOgrenciTaksitOde_Click(object sender, EventArgs e)
        {
            
            if (frmOgrenciTaksitOde.Created)
            {
                frmOgrenciTaksitOde.ShowDialog();
            }
            else
            {
                frmOgrenciTaksitOde = new Form_Ogrenci_Taksit_Ode();
                frmOgrenciTaksitOde.ShowDialog();
            }

        }



        private void button_Ogrenci_Kaydet_Click(object sender, EventArgs e)
        {

            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }


                string sorgu = "INSERT INTO Ogrenci_Genel_Bilgi(Ogrenci_No,Adi,Soyadi,Cinsiyet,Kayit_Tarihi,Danisman_id,Geldigi_Okul,Grup_id,Sinif_id,Bolum_id,Kitap_Seti,Ev_Tel,Cep_Tel,Adres) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14)";

                komut = new OleDbCommand(sorgu, A_Genel.baglanti);


                komut.Parameters.AddWithValue("@1", textBox_Ogrenci_No.Text);
                komut.Parameters.AddWithValue("@2", textBox_Ogrenci_Adi.Text);
                komut.Parameters.AddWithValue("@3", textBox_Ogrenci_Soyadi.Text);
                komut.Parameters.AddWithValue("@4", comboBox_Ogrenci_Cinsiyet.Text);
                komut.Parameters.AddWithValue("@5", dateTimePicker_Ogrenci_Kayit_Tarih.Value.ToShortDateString());
                komut.Parameters.AddWithValue("@6", comboBox_Ogrenci_Danisman.SelectedValue);
                komut.Parameters.AddWithValue("@7", textBox_Ogrenci_Geldigi_Okul.Text);
                komut.Parameters.AddWithValue("@8", comboBox_Ogrenci_Grubu.SelectedValue);
                komut.Parameters.AddWithValue("@9", comboBox_Ogrenci_Sinif.SelectedValue);
                komut.Parameters.AddWithValue("@10", comboBox_Ogrenci_Bolum.SelectedValue);
                komut.Parameters.AddWithValue("@11", comboBox_Kitap_Seti.Text);
                komut.Parameters.AddWithValue("@12", textBox_Ogrenci_Ev_Tel.Text);
                komut.Parameters.AddWithValue("@13", textBox_Ogrenci_Cep_Tel.Text);
                komut.Parameters.AddWithValue("@14", textBox_Ogrenci_Adres.Text);
                komut.ExecuteNonQuery();

                string sorgu2 = "INSERT INTO Ogrenci_Kimlik_Bilgi(TC_Kimlik_No, Seri, Kimlik_No, Baba_Adi, Ana_Adi, Dogum_Tarihi, Dogum_Yeri, Medeni_Hali, Dini, Kan_Grubu, il, ilce, Mahelle_Koy, Cilt_No, Aile_Sira_No, Sira_No, Verildigi_Yer, Verilis_Nedeni, Kayıt_No, Verilis_Tarihi,Ogrenci_id) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21)";

                komut2 = new OleDbCommand(sorgu2, A_Genel.baglanti);

                komut2.Parameters.AddWithValue("@1", textBox_Ogrenci_Tc_Kimlik_No.Text);
                komut2.Parameters.AddWithValue("@2", textBox_Ogrenci_Seri.Text);
                komut2.Parameters.AddWithValue("@3", textBox_Ogrenci_Kimlik_No.Text);
                komut2.Parameters.AddWithValue("@4", textBox_Ogrenci_Baba_Adi.Text);
                komut2.Parameters.AddWithValue("@5", textBox_Ogrenci_Ana_Adi.Text);
                komut2.Parameters.AddWithValue("@6", dateTimePicker_Ogrenci_Dogum_Tarihi.Value);
                komut2.Parameters.AddWithValue("@7", textBox_Ogrenci_Dogum_Yeri.Text);
                komut2.Parameters.AddWithValue("@8", comboBox_Medeni_Hali.Text);
                komut2.Parameters.AddWithValue("@9", textBox_Ogrenci_Dini.Text);
                komut2.Parameters.AddWithValue("@10", textBox_Kan_Grubu.Text);
                komut2.Parameters.AddWithValue("@11", comboBox_Ogrenci_il.Text);
                komut2.Parameters.AddWithValue("@12", comboBox_Ogrenci_ilce.Text);
                komut2.Parameters.AddWithValue("@13", textBox_Ogrenci_MahalleKoy.Text);
                komut2.Parameters.AddWithValue("@14", textBox_Ogrenci_Cilt_No.Text);
                komut2.Parameters.AddWithValue("@15", textBox_Ogrenci_Aile_Sira_No.Text);
                komut2.Parameters.AddWithValue("@16", textBox_Ogrenci_Sira_No.Text);
                komut2.Parameters.AddWithValue("@17", textBox_Ogrenci_Verildigi_Yer.Text);
                komut2.Parameters.AddWithValue("@18", textBox_Ogrenci_Verilis_Nedeni.Text);
                komut2.Parameters.AddWithValue("@19", textBox_Ogrenci_Kayit_No.Text);
                komut2.Parameters.AddWithValue("@20", dateTimePicker_Ogrenci_Verilis_Tarihi.Value);
                komut2.Parameters.AddWithValue("@21", ogrenciid + 1);

                komut2.ExecuteNonQuery();


                string sorgu3 = "INSERT INTO Ogrenci_Veli_Bilgi(TC_Kimlik_No,Adi,Soyadi,Dogum_Tarihi,Egitim_Durumu,Meslegi,Ev_Tel,Cep_Tel,iS_Tel,iS_Adres,Ev_Adres,Ogrenci_id) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)";

                komut3 = new OleDbCommand(sorgu3, A_Genel.baglanti);

                komut3.Parameters.AddWithValue("@1", textBox_Veli_Tc_Kimlik_No.Text);
                komut3.Parameters.AddWithValue("@2", textBox_Veli_Adi.Text);
                komut3.Parameters.AddWithValue("@3", textBox_Veli_Soyadi.Text);
                komut3.Parameters.AddWithValue("@4", dateTimePicker_Veli_Dogum_Tarihi.Value.ToShortDateString());
                komut3.Parameters.AddWithValue("@5", textBox_Veli_Egitim_Durumu.Text);
                komut3.Parameters.AddWithValue("@6", textBox_Veli_Meslegi.Text);
                komut3.Parameters.AddWithValue("@7", textBox_Veli_Ev_Tel.Text);
                komut3.Parameters.AddWithValue("@8", textBox_Veli_Cep_Tel.Text);
                komut3.Parameters.AddWithValue("@9", textBox_Veli_iS_Tel.Text);
                komut3.Parameters.AddWithValue("@10", textBox_Veli_iS_Adres.Text);
                komut3.Parameters.AddWithValue("@11", textBox_Veli_Ev_Adres.Text);
                komut3.Parameters.AddWithValue("@12", ogrenciid+1);


                komut3.ExecuteNonQuery();

                string sorgu4 = "INSERT INTO Ogrenci_Taksitlendirme_Bilgi(Ogrenci_id) values (@1)";

                komut4 = new OleDbCommand(sorgu4, A_Genel.baglanti);
                komut4.Parameters.AddWithValue("@1", ogrenciid + 1);
                komut4.ExecuteNonQuery();

                KayitlariGetir();
                A_Genel.baglanti.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Veri tabanına eklemede Hata: " + ex.Message);
            }
        }

        private void button_Ogrenci_Kayit_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                String guncel_satir = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Ogrenci_id"].Value.ToString();
                string sorgu = "UPDATE Ogrenci_Genel_Bilgi SET Ogrenci_No=@1,  Adi=@2,  Soyadi=@3,  Cinsiyet=@4,  Kayit_Tarihi=@5,  Danisman_id=@6,  Geldigi_Okul=@7,  Grup_id=@8,  Sinif_id=@9,  Bolum_id=@10,  Kitap_Seti=@11,  Ev_Tel=@12,  Cep_Tel=@13,  Adres=@14 WHERE Ogrenci_id=" + guncel_satir + "";
                komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                komut.Parameters.AddWithValue("@1", textBox_Ogrenci_No.Text);
                komut.Parameters.AddWithValue("@2", textBox_Ogrenci_Adi.Text);
                komut.Parameters.AddWithValue("@3", textBox_Ogrenci_Soyadi.Text);
                komut.Parameters.AddWithValue("@4", comboBox_Ogrenci_Cinsiyet.Text);
                komut.Parameters.AddWithValue("@5", dateTimePicker_Ogrenci_Kayit_Tarih.Value.ToShortDateString());
                komut.Parameters.AddWithValue("@6", comboBox_Ogrenci_Danisman.SelectedValue);
                komut.Parameters.AddWithValue("@7", textBox_Ogrenci_Geldigi_Okul.Text);
                komut.Parameters.AddWithValue("@8", comboBox_Ogrenci_Grubu.SelectedValue);
                komut.Parameters.AddWithValue("@9", comboBox_Ogrenci_Sinif.SelectedValue);
                komut.Parameters.AddWithValue("@10", comboBox_Ogrenci_Bolum.SelectedValue);
                komut.Parameters.AddWithValue("@11", comboBox_Kitap_Seti.Text);
                komut.Parameters.AddWithValue("@12", textBox_Ogrenci_Ev_Tel.Text);
                komut.Parameters.AddWithValue("@13", textBox_Ogrenci_Cep_Tel.Text);
                komut.Parameters.AddWithValue("@14", textBox_Ogrenci_Adres.Text);
                komut.ExecuteNonQuery();


                String guncel_satir2 = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Ogrenci_id"].Value.ToString();
                string sorgu2 = " UPDATE Ogreci_Kimlik_Bilgi SET TC_Kimlik_No=@1,  Seri=@2,  Kimlik_No=@3,  Baba_Adi=@4,  Ana_Adi=@5,  Dogum_Tarihi=@6,  Dogum_Yeri=@7,  Medeni_Hali=@8,  Dini=@9,  Kan_Grubu=@10,  il=@11,  ilce=@12,  Mahelle_Koy=@13,  Cilt_No=@14,  Aile_Sira_No=@15,  Sira_No=@16,  Verildigi_Yer=@17,  Verilis_Nedeni=@18,  Kayıt_No=@19,  Verilis_Tarihi=@20 WHERE Ogrenci_id=" + guncel_satir2 + "";
                komut2 = new OleDbCommand(sorgu2, A_Genel.baglanti);

                komut2.Parameters.AddWithValue("@1", textBox_Ogrenci_Tc_Kimlik_No.Text);
                komut2.Parameters.AddWithValue("@2", textBox_Ogrenci_Seri.Text);
                komut2.Parameters.AddWithValue("@3", textBox_Ogrenci_Kimlik_No.Text);
                komut2.Parameters.AddWithValue("@4", textBox_Ogrenci_Baba_Adi.Text);
                komut2.Parameters.AddWithValue("@5", textBox_Ogrenci_Ana_Adi.Text);
                komut2.Parameters.AddWithValue("@6", dateTimePicker_Ogrenci_Dogum_Tarihi.Value.ToShortDateString());
                komut2.Parameters.AddWithValue("@7", textBox_Ogrenci_Dogum_Yeri.Text);
                komut2.Parameters.AddWithValue("@8", comboBox_Medeni_Hali.Text);
                komut2.Parameters.AddWithValue("@9", textBox_Ogrenci_Dini.Text);
                komut2.Parameters.AddWithValue("@10", textBox_Kan_Grubu.Text);
                komut2.Parameters.AddWithValue("@11", comboBox_Ogrenci_il.Text);
                komut2.Parameters.AddWithValue("@12", comboBox_Ogrenci_ilce.Text);
                komut2.Parameters.AddWithValue("@13", textBox_Ogrenci_MahalleKoy.Text);
                komut2.Parameters.AddWithValue("@14", textBox_Ogrenci_Cilt_No.Text);
                komut2.Parameters.AddWithValue("@15", textBox_Ogrenci_Aile_Sira_No.Text);
                komut2.Parameters.AddWithValue("@16", textBox_Ogrenci_Sira_No.Text);
                komut2.Parameters.AddWithValue("@17", textBox_Ogrenci_Verildigi_Yer.Text);
                komut2.Parameters.AddWithValue("@18", textBox_Ogrenci_Verilis_Nedeni.Text);
                komut2.Parameters.AddWithValue("@19", textBox_Ogrenci_Kayit_No.Text);
                komut2.Parameters.AddWithValue("@20", dateTimePicker_Ogrenci_Verilis_Tarihi.Value.ToShortDateString());
                komut2.ExecuteNonQuery();

                String guncel_satir3 = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Ogrenci_id"].Value.ToString();
                string sorgu3 = " UPDATE Ogrenci_Veli_Bilgi SET TC_Kimlik_No=@1,  Adi=@2,  Soyadi=@3,  Dogum_Tarihi=@4,  Egitim_Durumu=@5,  Meslegi=@6,  Ev_Tel=@7,  Cep_Tel=@8,  iS_Tel=@9,  iS_Adres=@10,  Ev_Adres=@11 WHERE Ogrenci_id=" + guncel_satir3 + "";
                komut3 = new OleDbCommand(sorgu3, A_Genel.baglanti);

                komut3.Parameters.AddWithValue("@1", textBox_Veli_Tc_Kimlik_No.Text);
                komut3.Parameters.AddWithValue("@2", textBox_Veli_Adi.Text);
                komut3.Parameters.AddWithValue("@3", textBox_Veli_Soyadi.Text);
                komut3.Parameters.AddWithValue("@4", dateTimePicker_Veli_Dogum_Tarihi.Value.ToShortDateString());
                komut3.Parameters.AddWithValue("@5", textBox_Veli_Egitim_Durumu.Text);
                komut3.Parameters.AddWithValue("@6", textBox_Veli_Meslegi.Text);
                komut3.Parameters.AddWithValue("@7", textBox_Veli_Ev_Tel.Text);
                komut3.Parameters.AddWithValue("@8", textBox_Veli_Cep_Tel.Text);
                komut3.Parameters.AddWithValue("@9", textBox_Veli_iS_Tel.Text);
                komut3.Parameters.AddWithValue("@10", textBox_Veli_iS_Adres.Text);
                komut3.Parameters.AddWithValue("@11", textBox_Veli_Ev_Adres.Text);
                komut3.ExecuteNonQuery();

                KayitlariGetir();

                A_Genel.baglanti.Close();
            }
            catch (Exception Guncel)
            {
                MessageBox.Show("Güncellemede Hata: " + Guncel.Message);
            }

            MessageBox.Show("Kayıt Güncelleme İşlemi Tamamlandı...");
        }

        private void button_Yeni_Ogrenci_Kayit_Click(object sender, EventArgs e)
        {
            //foreach (GroupBox item in this.tabPage_Ogrenci_Kayıt.Controls)
            //{
            //    if (item.Text != null && item.Text != "")
            //    {
            //        foreach (TextBox item2 in this.groupBox_Ogreci_Genel_Bilgi.Controls)
            //        {
            //            item2.Text = null;
            //        }
            //        foreach (ComboBox item3 in this.groupBox_Ogreci_Genel_Bilgi.Controls)
            //        {
            //            item3.Text = "Seçiniz...";
            //        }
            //    }

            //}
            
            //Grupbox Ogrenci Genel Bilgi

            textBox_Ogrenci_No.Text = null;
            textBox_Ogrenci_Adi.Text = null;
            textBox_Ogrenci_Soyadi.Text = null;
            comboBox_Ogrenci_Cinsiyet.Text = null;
            comboBox_Ogrenci_Danisman.Text = null;
            textBox_Ogrenci_Geldigi_Okul.Text = null;
            comboBox_Ogrenci_Grubu.Text = null;
            comboBox_Ogrenci_Bolum.Text = null;
            comboBox_Ogrenci_Sinif.Text = null;
            dateTimePicker_Ogrenci_Kayit_Tarih.Value = DateTime.Now;
            comboBox_Kitap_Seti.Text = null;

            //Grupbox Ogrenci İletişim Bilgi
            textBox_Ogrenci_Ev_Tel.Text = null;
            textBox_Ogrenci_Cep_Tel.Text = null;
            textBox_Ogrenci_Adres.Text = null;

            //Grupbox Ogrenci Kimlik Bilgi

            textBox_Ogrenci_Tc_Kimlik_No.Text = null;
            textBox_Ogrenci_Seri.Text = null;
            textBox_Ogrenci_Kimlik_No.Text = null;
            textBox_Ogrenci_Baba_Adi.Text = null;
            textBox_Ogrenci_Ana_Adi.Text = null;
            dateTimePicker_Ogrenci_Dogum_Tarihi.Value = DateTime.Now;
            textBox_Ogrenci_Dogum_Yeri.Text = null;
            comboBox_Medeni_Hali.Text = null;
            textBox_Ogrenci_Dini.Text = null;
            textBox_Kan_Grubu.Text = null;
            comboBox_Ogrenci_il.Text = null;
            comboBox_Ogrenci_ilce.Text = null;
            textBox_Ogrenci_MahalleKoy.Text = null;
            textBox_Ogrenci_Cilt_No.Text = null;
            textBox_Ogrenci_Aile_Sira_No.Text = null;
            textBox_Ogrenci_Sira_No.Text = null;
            textBox_Ogrenci_Verildigi_Yer.Text = null;
            textBox_Ogrenci_Verilis_Nedeni.Text = null;
            textBox_Ogrenci_Kayit_No.Text = null;
            dateTimePicker_Ogrenci_Verilis_Tarihi.Value = DateTime.Now;

            //Grupbox Veli Bilgi
            textBox_Veli_Adi.Text = null;
            textBox_Veli_Soyadi.Text = null;
            textBox_Veli_Tc_Kimlik_No.Text = null;
            dateTimePicker_Veli_Dogum_Tarihi.Value = DateTime.Now;
            textBox_Veli_Meslegi.Text = null;
            textBox_Veli_Egitim_Durumu.Text = null;

            //Grupbox Veli İletişim Bilgi
            textBox_Veli_Ev_Tel.Text = null;
            textBox_Veli_iS_Tel.Text = null;
            textBox_Veli_Cep_Tel.Text = null;
            textBox_Veli_Ev_Adres.Text = null;
            textBox_Veli_iS_Adres.Text = null;

        }

        private void button_Ogrenci_Kayit_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                if (dataGridView_Ogrenci_Genel_Bilgi.CurrentRow == null)
                {
                    MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
                }
                else
                {
                    string sil_satir = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Ogrenci_id"].Value.ToString();
                    string sorgu = "DELETE From Ogrenci_Genel_Bilgi WHERE Ogrenci_id=" + sil_satir + "";
                    DialogResult cvp = MessageBox.Show("Kayıt Silinecektir Devam Edilsin mi ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cvp == DialogResult.Yes)
                    {
                        komut = new OleDbCommand(sorgu, A_Genel.baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silme İşlemi Tamamlanmıştır...");
                    }
                    KayitlariGetir();
                    A_Genel.baglanti.Close();
                }
            }
            catch (Exception silme1)
            {

                MessageBox.Show("Silme İşlemi Hata: " + silme1.Message);
            }

        }

        OpenFileDialog Ogrenci_Resim_Ekle = new OpenFileDialog();


        string yol = Directory.GetCurrentDirectory() + "\\Resimler\\Ogrenci\\";

        private void button_Ogrenci_Resim_Ekle_Click(object sender, EventArgs e)
        {
            Ogrenci_Resim_Ekle.ShowDialog();
            pictureBox_Ogrenci_Fotograf.Image = Image.FromFile(Ogrenci_Resim_Ekle.FileName);
            pictureBox_Ogrenci_Fotograf.SizeMode = PictureBoxSizeMode.StretchImage;


            if (Directory.Exists(yol))
            {

                label_Foto.Visible = false;

                FileInfo Ogrenci_Resim = new FileInfo(Ogrenci_Resim_Ekle.FileName);
                Ogrenci_Resim.CopyTo(yol + Ogrenci_Resim.Name, true);

            }
            else
            {
                Directory.CreateDirectory("\\Resimler\\Ogrenci\\");

                label_Foto.Visible = false;

                FileInfo Ogrenci_Resim = new FileInfo(Ogrenci_Resim_Ekle.FileName);
                Ogrenci_Resim.CopyTo(yol + Ogrenci_Resim.Name, true);
            }
        }

        private void button_Ogrenci_Resim_Sil_Click(object sender, EventArgs e)
        {
            pictureBox_Ogrenci_Fotograf.Image = null;
            label_Foto.Visible = true;
        }

        private void button_Ogrenci_Tüm_Kayitlar_Click(object sender, EventArgs e)
        {
            tabControl_Ogrenci_Kayit_Bilgi.SelectTab(3);
        }

        private void button_ileri_Click(object sender, EventArgs e)
        {
            if (tabControl_Ogrenci_Kayit_Bilgi.SelectedIndex != 3)
            {
                tabControl_Ogrenci_Kayit_Bilgi.SelectedIndex += 1;
            }

        }

        private void button_Geri_Click(object sender, EventArgs e)
        {
            if (tabControl_Ogrenci_Kayit_Bilgi.SelectedIndex != 0)
            {
                tabControl_Ogrenci_Kayit_Bilgi.SelectedIndex -= 1;
            }

        }
        int gecis = 0;
        private void button_Tüm_Kayit_Gizle_Goster_Sag_Click(object sender, EventArgs e)
        {
            if (gecis == 0)
            {
                label48.Visible = true;
                dataGridView_Ogrenci_Kimlik_Bilgi.Visible = true;
                label47.Visible = false;
                dataGridView_Ogrenci_Genel_Bilgi.Visible = false;
                label45.Visible = false;
                dataGridView_Ogrenci_Veli_Bilgi.Visible = false;

                gecis += 1;
            }
            else if (gecis == 1)
            {
                label48.Visible = false;
                dataGridView_Ogrenci_Kimlik_Bilgi.Visible = false;
                label47.Visible = false;
                dataGridView_Ogrenci_Genel_Bilgi.Visible = false;
                label45.Visible = true;
                dataGridView_Ogrenci_Veli_Bilgi.Visible = true;

                gecis = 1;
            }

  
            
        }

        private void button_Tüm_Kayit_Gizle_Goster_Sol_Click(object sender, EventArgs e)
        {
            if (gecis == 0)
            {
                label48.Visible = false;
                dataGridView_Ogrenci_Kimlik_Bilgi.Visible = false;
                label47.Visible = true;
                dataGridView_Ogrenci_Genel_Bilgi.Visible = true;
                label45.Visible = false;
                dataGridView_Ogrenci_Veli_Bilgi.Visible = false;
            }
            else if (gecis == 1)
            {
                label48.Visible = true;
                dataGridView_Ogrenci_Kimlik_Bilgi.Visible = true;
                label47.Visible = false;
                dataGridView_Ogrenci_Genel_Bilgi.Visible = false;
                label45.Visible = false;
                dataGridView_Ogrenci_Veli_Bilgi.Visible = false;

                gecis -= 1;
            }
            
        }

        public void comboiLdoldur()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                OleDbCommand veri = new OleDbCommand("SELECT distinct il FROM Sehirler", A_Genel.baglanti);
                OleDbDataReader oku;

                oku = veri.ExecuteReader();
                comboBox_Ogrenci_il.Items.Clear();
                comboBox_Ogrenci_ilce.Items.Clear();
                while (oku.Read())
                {
                    comboBox_Ogrenci_il.Items.Add(oku["il"].ToString());
                }
                oku.Close();
                A_Genel.baglanti.Close();
            }
            catch (Exception comboiLcagir)
            {

                MessageBox.Show("ComboBox Çagırma İşlemi Hata: " + comboiLcagir.Message);
            }

        }
        private void comboBox_Ogrenci_il_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                string sorgu = "select ilce from Sehirler where il='" + comboBox_Ogrenci_il.Text + "'";

                OleDbCommand kmt4 = new OleDbCommand("select ilce from Sehirler where il='" + comboBox_Ogrenci_il.Text + "'", A_Genel.baglanti);
                OleDbDataReader oku2;
                oku2 = kmt4.ExecuteReader();

                comboBox_Ogrenci_ilce.Items.Clear();
                while (oku2.Read())
                {
                    comboBox_Ogrenci_ilce.Items.Add(oku2["ilce"].ToString());
                }
                A_Genel.baglanti.Close();

            }
            catch (Exception comboiLdoldur)
            {
                MessageBox.Show("ComboBox Doldur İşlemi Hata: " + comboiLdoldur.Message);

            }

        }

        private void dataGridView_Ogrenci_Genel_Bilgi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            guncel_satir = e.RowIndex;
            sil_satir = e.RowIndex;
        }

        private void dataGridView_Ogrenci_Genel_Bilgi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Grupbox Ogrenci Genel Bilgi

            textBox_Ogrenci_No.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Ogrenci_No"].Value.ToString();
            textBox_Ogrenci_Adi.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Adi"].Value.ToString();
            textBox_Ogrenci_Soyadi.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Soyadi"].Value.ToString();
            comboBox_Ogrenci_Cinsiyet.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            dateTimePicker_Ogrenci_Kayit_Tarih.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Kayit_Tarihi"].Value.ToString();
            comboBox_Ogrenci_Danisman.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Danisman_id"].Value.ToString();
            textBox_Ogrenci_Geldigi_Okul.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Geldigi_Okul"].Value.ToString();
            comboBox_Ogrenci_Grubu.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Grup_id"].Value.ToString();
            comboBox_Ogrenci_Bolum.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Sinif_id"].Value.ToString();
            comboBox_Ogrenci_Sinif.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Bolum_id"].Value.ToString();
            comboBox_Kitap_Seti.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Kitap_Seti"].Value.ToString();

            //Grupbox Ogrenci İletişim Bilgi
            textBox_Ogrenci_Ev_Tel.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Ev_Tel"].Value.ToString();
            textBox_Ogrenci_Cep_Tel.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Cep_Tel"].Value.ToString();
            textBox_Ogrenci_Adres.Text = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Adres"].Value.ToString();
           
        }

        private void dataGridView_Ogrenci_Taksit_Listele_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Ogrenci_Veli_Bilgi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Grupbox Veli Bilgi
            textBox_Veli_Adi.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["TC_Kimlik_No"].Value.ToString();
            textBox_Veli_Soyadi.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Adi"].Value.ToString();
            textBox_Veli_Tc_Kimlik_No.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Soyadi"].Value.ToString();
            dateTimePicker_Veli_Dogum_Tarihi.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Dogum_Tarihi"].Value.ToString();
            textBox_Veli_Meslegi.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Egitim_Durumu"].Value.ToString();
            textBox_Veli_Egitim_Durumu.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Meslegi"].Value.ToString();

            //Grupbox Veli İletişim Bilgi
            textBox_Veli_Ev_Tel.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Ev_Tel"].Value.ToString();
            textBox_Veli_iS_Tel.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["iS_Tel"].Value.ToString();
            textBox_Veli_Cep_Tel.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Cep_Tel"].Value.ToString();
            textBox_Veli_Ev_Adres.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["Ev_Adres"].Value.ToString();
            textBox_Veli_iS_Adres.Text = dataGridView_Ogrenci_Veli_Bilgi.CurrentRow.Cells["iS_Adres"].Value.ToString();
   
        }

        private void dataGridView_Ogrenci_Veli_Bilgi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            guncel_satir = e.RowIndex;
            sil_satir = e.RowIndex;
        }

        private void dataGridView_Ogrenci_Kimlik_Bilgi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Grupbox Ogrenci Kimlik Bilgi

            textBox_Ogrenci_Tc_Kimlik_No.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["TC_Kimlik_No"].Value.ToString();
            textBox_Ogrenci_Seri.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Seri"].Value.ToString();
            textBox_Ogrenci_Kimlik_No.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Kimlik_No"].Value.ToString();
            textBox_Ogrenci_Baba_Adi.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Baba_Adi"].Value.ToString();
            textBox_Ogrenci_Ana_Adi.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Ana_Adi"].Value.ToString();
            dateTimePicker_Ogrenci_Dogum_Tarihi.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Dogum_Tarihi"].Value.ToString();
            textBox_Ogrenci_Dogum_Yeri.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Dogum_Yeri"].Value.ToString();
            comboBox_Medeni_Hali.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Medeni_Hali"].Value.ToString();
            textBox_Ogrenci_Dini.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Dini"].Value.ToString();
            textBox_Kan_Grubu.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Kan_Grubu"].Value.ToString();
            comboBox_Ogrenci_il.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["il"].Value.ToString();
            comboBox_Ogrenci_ilce.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["ilce"].Value.ToString();
            textBox_Ogrenci_MahalleKoy.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Mahelle_Koy"].Value.ToString();
            textBox_Ogrenci_Cilt_No.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Cilt_No"].Value.ToString();
            textBox_Ogrenci_Aile_Sira_No.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Aile_Sira_No"].Value.ToString();
            textBox_Ogrenci_Sira_No.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Sira_No"].Value.ToString();
            textBox_Ogrenci_Verildigi_Yer.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Verildigi_Yer"].Value.ToString();
            textBox_Ogrenci_Verilis_Nedeni.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Verilis_Nedeni"].Value.ToString();
            textBox_Ogrenci_Kayit_No.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Kayıt_No"].Value.ToString();
            dateTimePicker_Ogrenci_Verilis_Tarihi.Text = dataGridView_Ogrenci_Kimlik_Bilgi.CurrentRow.Cells["Verilis_Tarihi"].Value.ToString(); 
        }

        private void dataGridView_Ogrenci_Kimlik_Bilgi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            guncel_satir = e.RowIndex;
            sil_satir = e.RowIndex;
        }

        private void dataGridView_Ogrenci_Genel_Bilgi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                //Kimlik
                String secilendeger = dataGridView_Ogrenci_Genel_Bilgi.CurrentRow.Cells["Ogrenci_id"].Value.ToString();

                daKimlik = new OleDbDataAdapter("SELECT * FROM Ogrenci_Kimlik_Bilgi WHERE Ogrenci_id = " + secilendeger, A_Genel.baglanti);
                dsKimlik = new DataSet();
                daKimlik.Fill(dsKimlik, "Ogrenci_Kimlik_Bilgi");
                dataGridView_Ogrenci_Kimlik_Bilgi.DataSource = dsKimlik.Tables["Ogrenci_Kimlik_Bilgi"];
                dataGridView_Ogrenci_Kimlik_Bilgi.Columns["Kimlik_id"].Visible = false;
                dataGridView_Ogrenci_Kimlik_Bilgi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //Veli

                daVeli = new OleDbDataAdapter("SELECT * FROM Ogrenci_Veli_Bilgi WHERE Ogrenci_id =" + secilendeger, A_Genel.baglanti);
                dsVeli = new DataSet();
                daVeli.Fill(dsVeli, "Ogrenci_Veli_Bilgi");
                dataGridView_Ogrenci_Veli_Bilgi.DataSource = dsVeli.Tables["Ogrenci_Veli_Bilgi"];
                dataGridView_Ogrenci_Veli_Bilgi.Columns["Veli_id"].Visible = false;
                dataGridView_Ogrenci_Veli_Bilgi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
                //Taksit

                daTaksit = new OleDbDataAdapter("SELECT * FROM Ogrenci_Taksitlendirme_Bilgi WHERE Ogrenci_id =" + secilendeger, A_Genel.baglanti);
                dsTaksit = new DataSet();
                daTaksit.Fill(dsTaksit, "Ogrenci_Taksitlendirme_Bilgi");
                dataGridView_Ogrenci_Taksit_Listele.DataSource = dsTaksit.Tables["Ogrenci_Taksitlendirme_Bilgi"];
                dataGridView_Ogrenci_Taksit_Listele.Columns["Taksitlendirme_id"].Visible = false;
                dataGridView_Ogrenci_Taksit_Listele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }

        private void textBox_Ogrenci_No_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Kan_Grubu)
            {
                textBox_Kan_Grubu.BackColor = Color.LightSteelBlue;
                textBox_Kan_Grubu.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Medeni_Hali)
            {
                comboBox_Medeni_Hali.BackColor = Color.LightSteelBlue;
                comboBox_Medeni_Hali.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Bolum)
            {
                comboBox_Ogrenci_Bolum.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Bolum.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Sinif)
            {
                comboBox_Ogrenci_Sinif.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Sinif.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Grubu)
            {
                comboBox_Ogrenci_Grubu.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Grubu.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Danisman)
            {
                comboBox_Ogrenci_Danisman.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Danisman.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_il)
            {
                comboBox_Ogrenci_il.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_il.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_ilce)
            {
                comboBox_Ogrenci_ilce.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_ilce.ForeColor = Color.Crimson;
            }
            else if (renkver == dateTimePicker_Ogrenci_Dogum_Tarihi)
            {
                dateTimePicker_Ogrenci_Dogum_Tarihi.BackColor = Color.LightSteelBlue;
                dateTimePicker_Ogrenci_Dogum_Tarihi.ForeColor = Color.Crimson;
            }
            else if (renkver == dateTimePicker_Ogrenci_Kayit_Tarih)
            {
                dateTimePicker_Ogrenci_Kayit_Tarih.BackColor = Color.LightSteelBlue;
                dateTimePicker_Ogrenci_Kayit_Tarih.ForeColor = Color.Crimson;
            }
            else if (renkver == dateTimePicker_Ogrenci_Verilis_Tarihi)
            {
                dateTimePicker_Ogrenci_Verilis_Tarihi.BackColor = Color.LightSteelBlue;
                dateTimePicker_Ogrenci_Verilis_Tarihi.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Cinsiyet)
            {
                comboBox_Ogrenci_Cinsiyet.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Cinsiyet.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Kitap_Seti)
            {
                comboBox_Kitap_Seti.BackColor = Color.LightSteelBlue;
                comboBox_Kitap_Seti.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Adi)
            {
                textBox_Ogrenci_Adi.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Adres)
            {
                textBox_Ogrenci_Adres.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Adres.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Aile_Sira_No)
            {
                textBox_Ogrenci_Aile_Sira_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Aile_Sira_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Ana_Adi)
            {
                textBox_Ogrenci_Ana_Adi.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Ana_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Baba_Adi)
            {
                textBox_Ogrenci_Baba_Adi.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Baba_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Cep_Tel)
            {
                textBox_Ogrenci_Cep_Tel.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Cep_Tel.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Cilt_No)
            {
                textBox_Ogrenci_Cilt_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Cilt_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Dini)
            {
                textBox_Ogrenci_Dini.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Dini.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Dogum_Yeri)
            {
                textBox_Ogrenci_Dogum_Yeri.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Dogum_Yeri.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Ev_Tel)
            {
                textBox_Ogrenci_Ev_Tel.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Ev_Tel.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Geldigi_Okul)
            {
                textBox_Ogrenci_Geldigi_Okul.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Geldigi_Okul.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Kayit_No)
            {
                textBox_Ogrenci_Kayit_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Kayit_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Kimlik_No)
            {
                textBox_Ogrenci_Kimlik_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Kimlik_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_MahalleKoy)
            {
                textBox_Ogrenci_MahalleKoy.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_MahalleKoy.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_No)
            {
                textBox_Ogrenci_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Seri)
            {
                textBox_Ogrenci_Seri.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Seri.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Sira_No)
            {
                textBox_Ogrenci_Sira_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Sira_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Soyadi)
            {
                textBox_Ogrenci_Soyadi.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Soyadi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Tc_Kimlik_No)
            {
                textBox_Ogrenci_Tc_Kimlik_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Tc_Kimlik_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Verildigi_Yer)
            {
                textBox_Ogrenci_Verildigi_Yer.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Verildigi_Yer.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Verilis_Nedeni)
            {
                textBox_Ogrenci_Verilis_Nedeni.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Verilis_Nedeni.ForeColor = Color.Crimson;
            }


            //veliiii
            else if (renkver == textBox_Veli_Adi)
            {
                textBox_Veli_Adi.BackColor = Color.LightSteelBlue;
                textBox_Veli_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_Cep_Tel)
            {
                textBox_Veli_Cep_Tel.BackColor = Color.LightSteelBlue;
                textBox_Veli_Cep_Tel.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_Egitim_Durumu)
            {
                textBox_Veli_Egitim_Durumu.BackColor = Color.LightSteelBlue;
                textBox_Veli_Egitim_Durumu.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_Ev_Adres)
            {
                textBox_Veli_Ev_Adres.BackColor = Color.LightSteelBlue;
                textBox_Veli_Ev_Adres.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_Ev_Tel)
            {
                textBox_Veli_Ev_Tel.BackColor = Color.LightSteelBlue;
                textBox_Veli_Ev_Tel.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_iS_Adres)
            {
                textBox_Veli_iS_Adres.BackColor = Color.LightSteelBlue;
                textBox_Veli_iS_Adres.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_iS_Tel)
            {
                textBox_Veli_iS_Tel.BackColor = Color.LightSteelBlue;
                textBox_Veli_iS_Tel.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_Meslegi)
            {
                textBox_Veli_Meslegi.BackColor = Color.LightSteelBlue;
                textBox_Veli_Meslegi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_Soyadi)
            {
                textBox_Veli_Soyadi.BackColor = Color.LightSteelBlue;
                textBox_Veli_Soyadi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Veli_Tc_Kimlik_No)
            {
                textBox_Veli_Tc_Kimlik_No.BackColor = Color.LightSteelBlue;
                textBox_Veli_Tc_Kimlik_No.ForeColor = Color.Crimson;
            } 

        }

        private void textBox_Ogrenci_No_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_No.BackColor = Color.SteelBlue;
            textBox_Ogrenci_No.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Adi_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Adi.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Adi.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Soyadi_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Soyadi.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Soyadi.ForeColor = Color.White;
        }

        private void comboBox_Ogrenci_Cinsiyet_Leave(object sender, EventArgs e)
        {
            comboBox_Ogrenci_Cinsiyet.BackColor = Color.SteelBlue;
            comboBox_Ogrenci_Cinsiyet.ForeColor = Color.White;
        }

        private void dateTimePicker_Ogrenci_Kayit_Tarih_Leave(object sender, EventArgs e)
        {
            dateTimePicker_Ogrenci_Kayit_Tarih.BackColor = Color.SteelBlue;
            dateTimePicker_Ogrenci_Kayit_Tarih.ForeColor = Color.White;
        }

        private void comboBox_Ogrenci_Danışman_Leave(object sender, EventArgs e)
        {
            comboBox_Ogrenci_Danisman.BackColor = Color.SteelBlue;
            comboBox_Ogrenci_Danisman.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Geldigi_Okul_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Geldigi_Okul.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Geldigi_Okul.ForeColor = Color.White;
        }

        private void comboBox_Ogrenci_Grubu_Leave(object sender, EventArgs e)
        {
            comboBox_Ogrenci_Grubu.BackColor = Color.SteelBlue;
            comboBox_Ogrenci_Grubu.ForeColor = Color.White;
        }

        private void comboBox_Ogrenci_Sinif_Leave(object sender, EventArgs e)
        {
            comboBox_Ogrenci_Sinif.BackColor = Color.SteelBlue;
            comboBox_Ogrenci_Sinif.ForeColor = Color.White;
        }

        private void comboBox_Ogrenci_Bolum_Leave(object sender, EventArgs e)
        {
            comboBox_Ogrenci_Bolum.BackColor = Color.SteelBlue;
            comboBox_Ogrenci_Bolum.ForeColor = Color.White;
        }

        private void comboBox_Kitap_Seti_Leave(object sender, EventArgs e)
        {
            comboBox_Kitap_Seti.BackColor = Color.SteelBlue;
            comboBox_Kitap_Seti.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Tc_Kimlik_No_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Tc_Kimlik_No.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Tc_Kimlik_No.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Seri_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Seri.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Seri.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Kimlik_No_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Kimlik_No.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Kimlik_No.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Baba_Adi_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Baba_Adi.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Baba_Adi.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Ana_Adi_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Ana_Adi.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Ana_Adi.ForeColor = Color.White;
        }

        private void dateTimePicker_Ogrenci_Dogum_Tarihi_Leave(object sender, EventArgs e)
        {
            dateTimePicker_Ogrenci_Dogum_Tarihi.BackColor = Color.SteelBlue;
            dateTimePicker_Ogrenci_Dogum_Tarihi.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Dogum_Yeri_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Dogum_Yeri.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Dogum_Yeri.ForeColor = Color.White;
        }

        private void comboBox_Medeni_Hali_Leave(object sender, EventArgs e)
        {
            comboBox_Medeni_Hali.BackColor = Color.SteelBlue;
            comboBox_Medeni_Hali.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Dini_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Dini.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Dini.ForeColor = Color.White;
        }

        private void textBox_Kan_Grubu_Leave(object sender, EventArgs e)
        {
            textBox_Kan_Grubu.BackColor = Color.SteelBlue;
            textBox_Kan_Grubu.ForeColor = Color.White;
        }

        private void comboBox_Ogrenci_il_Leave(object sender, EventArgs e)
        {
            comboBox_Ogrenci_il.BackColor = Color.SteelBlue;
            comboBox_Ogrenci_il.ForeColor = Color.White;
        }

        private void comboBox_Ogrenci_ilce_Leave(object sender, EventArgs e)
        {
            comboBox_Ogrenci_ilce.BackColor = Color.SteelBlue;
            comboBox_Ogrenci_ilce.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_MahalleKoy_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_MahalleKoy.BackColor = Color.SteelBlue;
            textBox_Ogrenci_MahalleKoy.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Cilt_No_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Cilt_No.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Cilt_No.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Aile_Sira_No_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Aile_Sira_No.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Aile_Sira_No.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Sira_No_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Sira_No.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Sira_No.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Verildigi_Yer_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Verildigi_Yer.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Verildigi_Yer.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Verilis_Nedeni_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Verilis_Nedeni.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Verilis_Nedeni.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Kayit_No_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Kayit_No.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Kayit_No.ForeColor = Color.White;
        }

        private void dateTimePicker_Ogrenci_Verilis_Tarihi_Leave(object sender, EventArgs e)
        {
            dateTimePicker_Ogrenci_Verilis_Tarihi.BackColor = Color.SteelBlue;
            dateTimePicker_Ogrenci_Verilis_Tarihi.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Ev_Tel_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Ev_Tel.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Ev_Tel.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Cep_Tel_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Cep_Tel.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Cep_Tel.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Adres_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci_Adres.BackColor = Color.SteelBlue;
            textBox_Ogrenci_Adres.ForeColor = Color.White;
        }

        private void textBox_Veli_Adi_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Adi.BackColor = Color.SteelBlue;
            textBox_Veli_Adi.ForeColor = Color.White;
        }

        private void textBox_Veli_Soyadi_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Soyadi.BackColor = Color.SteelBlue;
            textBox_Veli_Soyadi.ForeColor = Color.White;
        }

        private void textBox_Veli_Tc_Kimlik_No_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Tc_Kimlik_No.BackColor = Color.SteelBlue;
            textBox_Veli_Tc_Kimlik_No.ForeColor = Color.White;
        }

        private void dateTimePicker_Veli_Dogum_Tarihi_Leave(object sender, EventArgs e)
        {
            dateTimePicker_Veli_Dogum_Tarihi.BackColor = Color.SteelBlue;
            dateTimePicker_Veli_Dogum_Tarihi.ForeColor = Color.White;
        }

        private void textBox_Veli_Meslegi_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Meslegi.BackColor = Color.SteelBlue;
            textBox_Veli_Meslegi.ForeColor = Color.White;
        }

        private void textBox_Veli_Egitim_Durumu_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Egitim_Durumu.BackColor = Color.SteelBlue;
            textBox_Veli_Egitim_Durumu.ForeColor = Color.White;
        }

        private void textBox_Veli_Ev_Tel_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Ev_Tel.BackColor = Color.SteelBlue;
            textBox_Veli_Ev_Tel.ForeColor = Color.White;
        }

        private void textBox_Veli_Cep_Tel_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Cep_Tel.BackColor = Color.SteelBlue;
            textBox_Veli_Cep_Tel.ForeColor = Color.White;
        }

        private void textBox_Veli_iS_Tel_Leave(object sender, EventArgs e)
        {
            textBox_Veli_iS_Tel.BackColor = Color.SteelBlue;
            textBox_Veli_iS_Tel.ForeColor = Color.White;
        }

        private void textBox_Veli_Ev_Adres_Leave(object sender, EventArgs e)
        {
            textBox_Veli_Ev_Adres.BackColor = Color.SteelBlue;
            textBox_Veli_Ev_Adres.ForeColor = Color.White;
        }

        private void textBox_Veli_iS_Adres_Leave(object sender, EventArgs e)
        {
            textBox_Veli_iS_Adres.BackColor = Color.SteelBlue;
            textBox_Veli_iS_Adres.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_Ogrenci_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_Veli_Egitim_Durumu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_Ogrenci_Taksit_Listele_SelectionChanged(object sender, EventArgs e)
        {

        }

    }
}
