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

namespace Dershane_Projesi
{
    public partial class Form_Ogrenci_Listeler : Form
    {
        public Form_Ogrenci_Listeler()
        {
            InitializeComponent();
        }
        bool combo_degisim_bolumu, combo_degisim_sinifi, combo_degisim_grubu, combo_anahtar, numara_anahtar, siralama_anahtar = false;

        string ogrenci_listele_sorgu;

        private void Form_Ogrenci_Listeler_Load(object sender, EventArgs e)
        {
            A_Genel.combodoldur("Grup_Bilgi", comboBox_Ogrenci_Grubu, "Grup_Adi");
            A_Genel.combodoldur("Grup_Bilgi", comboBox_Sinif_Ogrenci_Grubu, "Grup_Adi");
            A_Genel.combodoldur("Grup_Bilgi", comboBox_Telefon_Ogrenci_Grubu, "Grup_Adi");
            A_Genel.combodoldur("Grup_Bilgi", comboBox_Adres_Ogrenci_Grubu, "Grup_Adi");
            A_Genel.combodoldur("Grup_Bilgi", comboBox_Devamsizlik_Ogrenci_Grubu, "Grup_Adi");
            A_Genel.combodoldur("Grup_Bilgi", comboBox_Sinav_Sonuc_Ogrenci_Grubu, "Grup_Adi");
            A_Genel.combodoldur("Grup_Bilgi", comboBox_Veli_Ogrenci_Grubu, "Grup_Adi");

            A_Genel.combodoldur("Sinif_Bilgi", comboBox_Ogrenci_Grubu, "Sinif_Adi");
            A_Genel.combodoldur("Sinif_Bilgi", comboBox_Sinif_Ogrenci_Grubu, "Sinif_Adi");
            A_Genel.combodoldur("Sinif_Bilgi", comboBox_Telefon_Ogrenci_Grubu, "Sinif_Adi");
            A_Genel.combodoldur("Sinif_Bilgi", comboBox_Adres_Ogrenci_Grubu, "Sinif_Adi");
            A_Genel.combodoldur("Sinif_Bilgi", comboBox_Devamsizlik_Ogrenci_Grubu, "Sinif_Adi");
            A_Genel.combodoldur("Sinif_Bilgi", comboBox_Sinav_Sonuc_Ogrenci_Grubu, "Sinif_Adi");
            A_Genel.combodoldur("Sinif_Bilgi", comboBox_Veli_Ogrenci_Grubu, "Sinif_Adi");

            A_Genel.combodoldur("Bolum_Bilgi", comboBox_Ogrenci_Grubu, "Bolum_Adi");
            A_Genel.combodoldur("Bolum_Bilgi", comboBox_Sinif_Ogrenci_Grubu, "Bolum_Adi");
            A_Genel.combodoldur("Bolum_Bilgi", comboBox_Telefon_Ogrenci_Grubu, "Bolum_Adi");
            A_Genel.combodoldur("Bolum_Bilgi", comboBox_Adres_Ogrenci_Grubu, "Bolum_Adi");
            A_Genel.combodoldur("Bolum_Bilgi", comboBox_Devamsizlik_Ogrenci_Grubu, "Bolum_Adi");
            A_Genel.combodoldur("Bolum_Bilgi", comboBox_Sinav_Sonuc_Ogrenci_Grubu, "Bolum_Adi");
            A_Genel.combodoldur("Bolum_Bilgi", comboBox_Veli_Ogrenci_Grubu, "Bolum_Adi");

            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu..." + ex.Message);
            }
            grup_ders_bolum_sinif_doldur();
            grup_ders_bolum_sinif_doldur2();
            grup_ders_bolum_sinif_doldur3();
            grup_ders_bolum_sinif_doldur4();
            grup_ders_bolum_sinif_doldur5();
            grup_ders_bolum_sinif_doldur6();
            grup_ders_bolum_sinif_doldur7();
        }
        private void grup_ders_bolum_sinif_doldur()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

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

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void grup_ders_bolum_sinif_doldur2()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                //Combobox bolum
                string sorgu = "Select * from Bolum_Bilgi order by Bolum_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bolum_Bilgi");
                comboBox_Sinif_Ogrenci_Bolum.DataSource = ds.Tables[0];
                comboBox_Sinif_Ogrenci_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Sinif_Ogrenci_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Sinif_Ogrenci_Grubu.DataSource = ds1.Tables[0];
                comboBox_Sinif_Ogrenci_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Sinif_Ogrenci_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Sinif_Ogrenci_Sinif.DataSource = ds2.Tables[0];
                comboBox_Sinif_Ogrenci_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Sinif_Ogrenci_Sinif.ValueMember = "Sinif_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void grup_ders_bolum_sinif_doldur3()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                //Combobox bolum
                string sorgu = "Select * from Bolum_Bilgi order by Bolum_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bolum_Bilgi");
                comboBox_Telefon_Ogrenci_Bolum.DataSource = ds.Tables[0];
                comboBox_Telefon_Ogrenci_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Telefon_Ogrenci_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Telefon_Ogrenci_Grubu.DataSource = ds1.Tables[0];
                comboBox_Telefon_Ogrenci_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Telefon_Ogrenci_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Telefon_Ogrenci_Sinif.DataSource = ds2.Tables[0];
                comboBox_Telefon_Ogrenci_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Telefon_Ogrenci_Sinif.ValueMember = "Sinif_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void grup_ders_bolum_sinif_doldur4()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                //Combobox bolum
                string sorgu = "Select * from Bolum_Bilgi order by Bolum_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bolum_Bilgi");
                comboBox_Adres_Ogrenci_Bolum.DataSource = ds.Tables[0];
                comboBox_Adres_Ogrenci_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Adres_Ogrenci_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Adres_Ogrenci_Grubu.DataSource = ds1.Tables[0];
                comboBox_Adres_Ogrenci_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Adres_Ogrenci_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Adres_Ogrenci_Sinif.DataSource = ds2.Tables[0];
                comboBox_Adres_Ogrenci_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Adres_Ogrenci_Sinif.ValueMember = "Sinif_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void grup_ders_bolum_sinif_doldur5()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                //Combobox bolum
                string sorgu = "Select * from Bolum_Bilgi order by Bolum_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bolum_Bilgi");
                comboBox_Devamsizlik_Ogrenci_Bolum.DataSource = ds.Tables[0];
                comboBox_Devamsizlik_Ogrenci_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Devamsizlik_Ogrenci_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Devamsizlik_Ogrenci_Grubu.DataSource = ds1.Tables[0];
                comboBox_Devamsizlik_Ogrenci_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Devamsizlik_Ogrenci_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Devamsizlik_Ogrenci_Sinif.DataSource = ds2.Tables[0];
                comboBox_Devamsizlik_Ogrenci_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Devamsizlik_Ogrenci_Sinif.ValueMember = "Sinif_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void grup_ders_bolum_sinif_doldur6()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                //Combobox bolum
                string sorgu = "Select * from Bolum_Bilgi order by Bolum_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bolum_Bilgi");
                comboBox_Sinav_Sonuc_Ogrenci_Bolum.DataSource = ds.Tables[0];
                comboBox_Sinav_Sonuc_Ogrenci_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Sinav_Sonuc_Ogrenci_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Sinav_Sonuc_Ogrenci_Grubu.DataSource = ds1.Tables[0];
                comboBox_Sinav_Sonuc_Ogrenci_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Sinav_Sonuc_Ogrenci_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Sinav_Sonuc_Ogrenci_Sinif.DataSource = ds2.Tables[0];
                comboBox_Sinav_Sonuc_Ogrenci_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Sinav_Sonuc_Ogrenci_Sinif.ValueMember = "Sinif_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void grup_ders_bolum_sinif_doldur7()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }

                //Combobox bolum
                string sorgu = "Select * from Bolum_Bilgi order by Bolum_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Bolum_Bilgi");
                comboBox_Veli_Ogrenci_Bolum.DataSource = ds.Tables[0];
                comboBox_Veli_Ogrenci_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Veli_Ogrenci_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Veli_Ogrenci_Grubu.DataSource = ds1.Tables[0];
                comboBox_Veli_Ogrenci_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Veli_Ogrenci_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Veli_Ogrenci_Sinif.DataSource = ds2.Tables[0];
                comboBox_Veli_Ogrenci_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Veli_Ogrenci_Sinif.ValueMember = "Sinif_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
        private void button_Ogrenci_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Ogrenci_Adi.Text.Length != 0 || textBox_Ogrenci_Soyadi.Text.Length != 0)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Kayit_Tarihi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Adi like '" + textBox_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);

                if (textBox_Ogrenci_No.Text.Length != 0 && textBox_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Ogrenci_No.Text;
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Grubu= '" + comboBox_Ogrenci_Grubu.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Bolum= '" + comboBox_Ogrenci_Bolum.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Sinif= '" + comboBox_Ogrenci_Sinif.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
                }
                if (radioButton_Ogrenci_Ada_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
                }
                else if (radioButton_Ogrenci_Grubuna_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Grubu ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
                }
                else if (radioButton_Ogrenci_Kayit_Tarihine_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
                }

            }
            else if (textBox_Ogrenci_No.Text.Length != 0 && textBox_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Kayit_Tarihi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Ogrenci_No= " + textBox_Ogrenci_No.Text;
                KayitGuncelle(sorgu, dataGridView_Ogrenci_Listesi);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Kayit_Tarihi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Grubu= '" + comboBox_Ogrenci_Grubu.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Kayit_Tarihi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Bolum= '" + comboBox_Ogrenci_Bolum.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Kayit_Tarihi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Sinif= '" + comboBox_Ogrenci_Sinif.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
            }
            if (radioButton_Ogrenci_Ada_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
            }
            else if (radioButton_Ogrenci_Grubuna_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Grubu ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
            }
            else if (radioButton_Ogrenci_Kayit_Tarihine_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Ogrenci_Listesi);
            }
        }
        private void KayitGuncelle(string sorgu, DataGridView kontrol)
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Ogrenci_Genel_Bilgi");
            kontrol.DataSource = ds.Tables["Ogrenci_Genel_Bilgi"];
            kontrol.Columns["Ogrenci_id"].Visible = false;
            kontrol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void textBox_Ogrenci_No_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ogrenci_No.Text.Length != 0)
            {
                dataGridView_Ogrenci_Listesi.DataSource = null;
            }
        }

        private void comboBox_Ogrenci_Grubu_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_grubu = true;
        }

        private void comboBox_Ogrenci_Sinif_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_sinifi = true;
        }

        private void comboBox_Ogrenci_Bolum_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_bolumu = true;
        }

        private void button_Ogrenci_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci_Adi.Text = null;
            textBox_Ogrenci_No.Text = null;
            textBox_Ogrenci_Soyadi.Text = null;
            comboBox_Ogrenci_Grubu.Text = "Seçiniz...";
            comboBox_Ogrenci_Sinif.Text = "Seçiniz...";
            comboBox_Ogrenci_Bolum.Text = "Seçiniz...";
            radioButton_Ogrenci_Ada_Gore_Sirala.Checked = false;
            radioButton_Ogrenci_Grubuna_Gore_Sirala.Checked = false;
            radioButton_Ogrenci_Kayit_Tarihine_Gore_Sirala.Checked = false;
            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            siralama_anahtar = false;

            dataGridView_Ogrenci_Listesi.DataSource = null;
        }

        private void tabControl_Listeler_Selected(object sender, TabControlEventArgs e)
        {
            combo_degisim_bolumu = false;
            combo_degisim_sinifi = false;
            combo_degisim_grubu = false;
            combo_anahtar = false;
            numara_anahtar = false;
            siralama_anahtar = false;
        }

        private void button_Sinif_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Sinif_Ogrenci_Adi.Text.Length != 0 || textBox_Sinif_Ogrenci_Soyadi.Text.Length != 0)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Sinif,Grubu FROM Ogrenci_Genel_Bilgi WHERE Adi like '" + textBox_Sinif_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Sinif_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);

                if (textBox_Sinif_Ogrenci_No.Text.Length != 0 && textBox_Sinif_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Sinif_Ogrenci_No.Text;
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Grubu= '" + comboBox_Sinif_Ogrenci_Grubu.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Bolum= '" + comboBox_Sinif_Ogrenci_Bolum.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Sinif= '" + comboBox_Sinif_Ogrenci_Sinif.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
                }
                if (radioButton_Sinif_Ada_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
                }
                else if (radioButton_Sinif_Grubuna_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Grubu ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
                }
                else if (radioButton_Sinif_Kayit_Tarihine_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
                }

            }
            else if (textBox_Sinif_Ogrenci_No.Text.Length != 0 && textBox_Sinif_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Sinif,Grubu FROM Ogrenci_Genel_Bilgi WHERE Ogrenci_No=" + textBox_Sinif_Ogrenci_No.Text;
                KayitGuncelle(sorgu, dataGridView_Sinif_Listesi);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Sinif,Grubu FROM Ogrenci_Genel_Bilgi WHERE Grubu= '" + comboBox_Sinif_Ogrenci_Grubu.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Sinif,Grubu FROM Ogrenci_Genel_Bilgi WHERE Bolum= '" + comboBox_Sinif_Ogrenci_Bolum.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Sinif,Grubu FROM Ogrenci_Genel_Bilgi WHERE Sinif= '" + comboBox_Sinif_Ogrenci_Sinif.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
            }
            if (radioButton_Sinif_Ada_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
            }
            else if (radioButton_Sinif_Grubuna_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Grubu ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
            }
            else if (radioButton_Sinif_Kayit_Tarihine_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinif_Listesi);
            }
        }

        private void button_Sinif_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Sinif_Ogrenci_Adi.Text = null;
            textBox_Sinif_Ogrenci_No.Text = null;
            textBox_Sinif_Ogrenci_Soyadi.Text = null;
            comboBox_Sinif_Ogrenci_Bolum.Text = "Seçiniz...";
            comboBox_Sinif_Ogrenci_Grubu.Text = "Seçiniz...";
            comboBox_Sinif_Ogrenci_Sinif.Text = "Seçiniz...";
            radioButton_Sinif_Ada_Gore_Sirala.Checked = false;
            radioButton_Sinif_Grubuna_Gore_Sirala.Checked = false;
            radioButton_Sinif_Kayit_Tarihine_Gore_Sirala.Checked = false;
            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            siralama_anahtar = false;

            dataGridView_Sinif_Listesi.DataSource = null;
        }

        private void button_Telefon_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Telefon_Ogrenci_Adi.Text.Length != 0 || textBox_Telefon_Ogrenci_Soyadi.Text.Length != 0)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel,Ev_Tel FROM Ogrenci_Genel_Bilgi WHERE Adi like '" + textBox_Telefon_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Telefon_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);

                if (textBox_Telefon_Ogrenci_No.Text.Length != 0 && textBox_Telefon_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Telefon_Ogrenci_No.Text;
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Grubu= '" + comboBox_Telefon_Ogrenci_Grubu.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Bolum= '" + comboBox_Telefon_Ogrenci_Bolum.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Sinif= '" + comboBox_Telefon_Ogrenci_Sinif.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
                }
                if (radioButton_Telefon_Ada_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
                }
                else if (radioButton_Telefon_Grubuna_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Grubu ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
                }
                else if (radioButton_Telefon_Kayit_Tarihine_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
                }

            }
            else if (textBox_Telefon_Ogrenci_No.Text.Length != 0 && textBox_Telefon_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel,Ev_Tel FROM Ogrenci_Genel_Bilgi WHERE Ogrenci_No=" + textBox_Telefon_Ogrenci_No.Text;
                KayitGuncelle(sorgu, dataGridView_Telefon_Listesi);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel,Ev_Tel FROM Ogrenci_Genel_Bilgi WHERE Grubu= '" + comboBox_Telefon_Ogrenci_Grubu.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel,Ev_Tel FROM Ogrenci_Genel_Bilgi WHERE Bolum= '" + comboBox_Telefon_Ogrenci_Bolum.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel,Ev_Tel FROM Ogrenci_Genel_Bilgi WHERE Sinif= '" + comboBox_Telefon_Ogrenci_Sinif.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
            }
            if (radioButton_Telefon_Ada_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
            }
            else if (radioButton_Telefon_Grubuna_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Grubu ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
            }
            else if (radioButton_Telefon_Kayit_Tarihine_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Telefon_Listesi);
            }
        }

        private void button_Telefon_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Telefon_Ogrenci_No.Text = null;
            textBox_Telefon_Ogrenci_Adi.Text = null;
            textBox_Telefon_Ogrenci_Soyadi.Text = null;
            comboBox_Telefon_Ogrenci_Grubu.Text = "Seçiniz...";
            comboBox_Telefon_Ogrenci_Sinif.Text = "Seçiniz...";
            comboBox_Telefon_Ogrenci_Bolum.Text = "Seçiniz...";
            radioButton_Telefon_Ada_Gore_Sirala.Checked = false;
            radioButton_Telefon_Grubuna_Gore_Sirala.Checked = false;
            radioButton_Telefon_Kayit_Tarihine_Gore_Sirala.Checked = false;
            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            siralama_anahtar = false;

            dataGridView_Telefon_Listesi.DataSource = null;
        }

        private void button_Adres_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Adres_Ogrenci_Adi.Text.Length != 0 || textBox_Adres_Ogrenci_Soyadi.Text.Length != 0)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Adi like '" + textBox_Adres_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Adres_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);

                if (textBox_Adres_Ogrenci_No.Text.Length != 0 && textBox_Adres_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Adres_Ogrenci_No.Text;
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Grubu= '" + comboBox_Adres_Ogrenci_Grubu.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Bolum= '" + comboBox_Adres_Ogrenci_Bolum.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Sinif= '" + comboBox_Adres_Ogrenci_Sinif.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
                }
                if (radioButton_Adres_Ada_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
                }
                else if (radioButton_Adres_Grubuna_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Grubu ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
                }
                else if (radioButton_Adres_Kayit_Tarihine_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
                }

            }
            else if (textBox_Adres_Ogrenci_No.Text.Length != 0 && textBox_Adres_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Ogrenci_No=" + textBox_Adres_Ogrenci_No.Text;
                KayitGuncelle(sorgu, dataGridView_Adres_Listesi);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Grubu= '" + comboBox_Adres_Ogrenci_Grubu.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Bolum= '" + comboBox_Adres_Ogrenci_Bolum.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Cep_Tel FROM Ogrenci_Genel_Bilgi WHERE Sinif= '" + comboBox_Adres_Ogrenci_Sinif.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
            }
            if (radioButton_Adres_Ada_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
            }
            else if (radioButton_Adres_Grubuna_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Grubu ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
            }
            else if (radioButton_Adres_Kayit_Tarihine_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Adres_Listesi);
            }
        }

        private void button_Adres_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Adres_Ogrenci_Adi.Text = null;
            textBox_Adres_Ogrenci_No.Text = null;
            textBox_Adres_Ogrenci_Soyadi.Text = null;
            comboBox_Adres_Ogrenci_Bolum.Text = "Seçiniz...";
            comboBox_Adres_Ogrenci_Sinif.Text = "Seçiniz...";
            comboBox_Adres_Ogrenci_Grubu.Text = "Seçiniz...";
            radioButton_Adres_Ada_Gore_Sirala.Checked = false;
            radioButton_Adres_Grubuna_Gore_Sirala.Checked = false;
            radioButton_Adres_Kayit_Tarihine_Gore_Sirala.Checked = false;
            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            siralama_anahtar = false;

            dataGridView_Adres_Listesi.DataSource = null;
        }

        private void button_Veli_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Veli_Ogrenci_Adi.Text.Length != 0 || textBox_Veli_Ogrenci_Soyadi.Text.Length != 0)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id,Ogrenci_Genel_Bilgi.Ogrenci_No,Ogrenci_Genel_Bilgi.Adi,Ogrenci_Genel_Bilgi.Soyadi,Ogrenci_Genel_Bilgi.Sinif,Ogrenci_Veli_Bilgi.Adi,Ogrenci_Veli_Bilgi.Soyadi,Ogrenci_Veli_Bilgi.Cep_Tel FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Veli_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Veli_Bilgi.Ogrenci_id WHERE Adi like '" + textBox_Veli_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Veli_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);

                if (textBox_Veli_Ogrenci_No.Text.Length != 0 && textBox_Veli_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Veli_Ogrenci_No.Text;
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Grubu= '" + comboBox_Veli_Ogrenci_Grubu.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Bolum= '" + comboBox_Veli_Ogrenci_Bolum.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Sinif= '" + comboBox_Veli_Ogrenci_Sinif.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
                }
                if (radioButton_Veli_Ada_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
                }
                else if (radioButton_Veli_Grubuna_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Grubu ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
                }
                else if (radioButton_Veli_Kayit_Tarihine_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
                }

            }
            else if (textBox_Veli_Ogrenci_No.Text.Length != 0 && textBox_Veli_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id,Ogrenci_Genel_Bilgi.Ogrenci_No,Ogrenci_Genel_Bilgi.Adi,Ogrenci_Genel_Bilgi.Soyadi,Ogrenci_Genel_Bilgi.Sinif,Ogrenci_Veli_Bilgi.Adi,Ogrenci_Veli_Bilgi.Soyadi,Ogrenci_Veli_Bilgi.Cep_Tel FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Veli_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Veli_Bilgi.Ogrenci_id WHERE Ogrenci_No=" + textBox_Veli_Ogrenci_No.Text;
                KayitGuncelle(sorgu, dataGridView_Veli_Bilgileri);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id,Ogrenci_Genel_Bilgi.Ogrenci_No,Ogrenci_Genel_Bilgi.Adi,Ogrenci_Genel_Bilgi.Soyadi,Ogrenci_Genel_Bilgi.Sinif,Ogrenci_Veli_Bilgi.Adi,Ogrenci_Veli_Bilgi.Soyadi,Ogrenci_Veli_Bilgi.Cep_Tel FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Veli_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Veli_Bilgi.Ogrenci_id WHERE Grubu= '" + comboBox_Veli_Ogrenci_Grubu.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id,Ogrenci_Genel_Bilgi.Ogrenci_No,Ogrenci_Genel_Bilgi.Adi,Ogrenci_Genel_Bilgi.Soyadi,Ogrenci_Genel_Bilgi.Sinif,Ogrenci_Veli_Bilgi.Adi,Ogrenci_Veli_Bilgi.Soyadi,Ogrenci_Veli_Bilgi.Cep_Tel FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Veli_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Veli_Bilgi.Ogrenci_id WHERE Bolum= '" + comboBox_Veli_Ogrenci_Bolum.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id,Ogrenci_Genel_Bilgi.Ogrenci_No,Ogrenci_Genel_Bilgi.Adi,Ogrenci_Genel_Bilgi.Soyadi,Ogrenci_Genel_Bilgi.Sinif,Ogrenci_Veli_Bilgi.Adi,Ogrenci_Veli_Bilgi.Soyadi,Ogrenci_Veli_Bilgi.Cep_Tel FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Veli_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Veli_Bilgi.Ogrenci_id WHERE Sinif= '" + comboBox_Veli_Ogrenci_Sinif.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
            }
            if (radioButton_Veli_Ada_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
            }
            else if (radioButton_Veli_Grubuna_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Grubu ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
            }
            else if (radioButton_Veli_Kayit_Tarihine_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Veli_Bilgileri);
            }
        }

        private void comboBox_Sinif_Ogrenci_Grubu_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_grubu = true;
        }

        private void comboBox_Sinif_Ogrenci_Sinif_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_sinifi = true;
        }

        private void comboBox_Sinif_Ogrenci_Bolum_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_bolumu = true;
        }

        private void comboBox_Telefon_Ogrenci_Grubu_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_grubu = true;
        }

        private void comboBox_Telefon_Ogrenci_Sinif_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_sinifi = true;
        }

        private void comboBox_Telefon_Ogrenci_Bolum_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_bolumu = true;
        }

        private void comboBox_Adres_Ogrenci_Grubu_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_grubu = true;
        }

        private void comboBox_Adres_Ogrenci_Sinif_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_sinifi = true;
        }

        private void comboBox_Adres_Ogrenci_Bolum_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_bolumu = true;
        }

        private void comboBox_Veli_Ogrenci_Grubu_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_grubu = true;
        }

        private void comboBox_Veli_Ogrenci_Sinif_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_sinifi = true;
        }

        private void comboBox_Veli_Ogrenci_Bolum_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_bolumu = true;
        }

        private void button_Veli_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Veli_Ogrenci_Adi.Text = null;
            textBox_Veli_Ogrenci_No.Text = null;
            textBox_Veli_Ogrenci_Soyadi.Text = null;
            comboBox_Veli_Ogrenci_Grubu.Text = "Seçiniz...";
            comboBox_Veli_Ogrenci_Sinif.Text = "Seçiniz...";
            comboBox_Veli_Ogrenci_Bolum.Text = "Seçiniz...";
            radioButton_Veli_Ada_Gore_Sirala.Checked = false;
            radioButton_Veli_Grubuna_Gore_Sirala.Checked = false;
            radioButton_Veli_Kayit_Tarihine_Gore_Sirala.Checked = false;
            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            siralama_anahtar = false;

            dataGridView_Veli_Bilgileri.DataSource = null;
        }

        private void button_Devamsizlik_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Devamsizlik_Ogrenci_Adi.Text.Length != 0 || textBox_Devamsizlik_Ogrenci_Soyadi.Text.Length != 0)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Sinif, Ogrenci_Devamsizlik_Bilgi.Devamsizlik_Yapilan_Tarih, Ogrenci_Devamsizlik_Bilgi.Toplam_Devamsizlik FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Devamsizlik_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Devamsizlik_Bilgi.Ogrenci_id WHERE Adi like '" + textBox_Devamsizlik_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Devamsizlik_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);

                if (textBox_Devamsizlik_Ogrenci_No.Text.Length != 0 && textBox_Devamsizlik_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Devamsizlik_Ogrenci_No.Text;
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Grubu= '" + comboBox_Devamsizlik_Ogrenci_Grubu.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Bolum= '" + comboBox_Devamsizlik_Ogrenci_Bolum.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Sinif= '" + comboBox_Devamsizlik_Ogrenci_Sinif.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
                }
                if (radioButton_Devamsizlik_Ada_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
                }
                else if (radioButton_Devamsizlik_Grubuna_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Grubu ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
                }
                else if (radioButton_Devamsizlik_Kayit_Tarihine_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
                }

            }
            else if (textBox_Devamsizlik_Ogrenci_No.Text.Length != 0 && textBox_Devamsizlik_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Sinif, Ogrenci_Devamsizlik_Bilgi.Devamsizlik_Yapilan_Tarih, Ogrenci_Devamsizlik_Bilgi.Toplam_Devamsizlik FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Devamsizlik_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Devamsizlik_Bilgi.Ogrenci_id WHERE Ogrenci_No=" + textBox_Devamsizlik_Ogrenci_No.Text;
                KayitGuncelle(sorgu, dataGridView_Devamsizlik_Listesi);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Sinif, Ogrenci_Devamsizlik_Bilgi.Devamsizlik_Yapilan_Tarih, Ogrenci_Devamsizlik_Bilgi.Toplam_Devamsizlik FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Devamsizlik_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Devamsizlik_Bilgi.Ogrenci_id WHERE Grubu= '" + comboBox_Devamsizlik_Ogrenci_Grubu.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Sinif, Ogrenci_Devamsizlik_Bilgi.Devamsizlik_Yapilan_Tarih, Ogrenci_Devamsizlik_Bilgi.Toplam_Devamsizlik FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Devamsizlik_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Devamsizlik_Bilgi.Ogrenci_id WHERE Bolum= '" + comboBox_Devamsizlik_Ogrenci_Bolum.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Sinif, Ogrenci_Devamsizlik_Bilgi.Devamsizlik_Yapilan_Tarih, Ogrenci_Devamsizlik_Bilgi.Toplam_Devamsizlik FROM Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Devamsizlik_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Devamsizlik_Bilgi.Ogrenci_id WHERE Sinif= '" + comboBox_Devamsizlik_Ogrenci_Sinif.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
            }
            if (radioButton_Devamsizlik_Ada_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
            }
            else if (radioButton_Devamsizlik_Grubuna_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Grubu ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
            }
            else if (radioButton_Devamsizlik_Kayit_Tarihine_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Devamsizlik_Listesi);
            }
        }

        private void button_Devamsizlik_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Devamsizlik_Ogrenci_Adi.Text = null;
            textBox_Devamsizlik_Ogrenci_No.Text = null;
            textBox_Devamsizlik_Ogrenci_Soyadi.Text = null;
            comboBox_Devamsizlik_Ogrenci_Bolum.Text = "Seçiniz...";
            comboBox_Devamsizlik_Ogrenci_Grubu.Text = "Seçiniz...";
            comboBox_Devamsizlik_Ogrenci_Sinif.Text = "Seçiniz...";
            radioButton_Devamsizlik_Ada_Gore_Sirala.Checked = false;
            radioButton_Devamsizlik_Grubuna_Gore_Sirala.Checked = false;
            radioButton_Devamsizlik_Kayit_Tarihine_Gore_Sirala.Checked = false;
            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            siralama_anahtar = false;

            dataGridView_Devamsizlik_Listesi.DataSource = null;
        }

        private void comboBox_Devamsizlik_Ogrenci_Grubu_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_grubu = true;
        }

        private void comboBox_Devamsizlik_Ogrenci_Sinif_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_sinifi = true;
        }

        private void comboBox_Devamsizlik_Ogrenci_Bolum_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_bolumu = true;
        }

        private void button_Sinav_Sonuc_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Sinav_Sonuc_Ogrenci_Adi.Text.Length != 0 || textBox_Sinav_Sonuc_Ogrenci_Soyadi.Text.Length != 0)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Sinav_Bilgi.Sinavin_Adi, Ogrenci_Sinav_Sonuc.Ygs_1, Ogrenci_Sinav_Sonuc.Ygs_2, Ogrenci_Sinav_Sonuc.Ygs_3, Ogrenci_Sinav_Sonuc.Ygs_4, Ogrenci_Sinav_Sonuc.Ygs_5, Ogrenci_Sinav_Sonuc.Ygs_6 FROM (Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Sinav_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Bilgi.Ogrenci_id) INNER JOIN Ogrenci_Sinav_Sonuc ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Sonuc.Ogrenci_id WHERE Adi like '" + textBox_Sinav_Sonuc_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Sinav_Sonuc_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);

                if (textBox_Sinav_Sonuc_Ogrenci_No.Text.Length != 0 && textBox_Sinav_Sonuc_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Sinav_Sonuc_Ogrenci_No.Text;
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Grubu= '" + comboBox_Sinav_Sonuc_Ogrenci_Grubu.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Bolum= '" + comboBox_Sinav_Sonuc_Ogrenci_Bolum.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_listele_sorgu += " AND Sinif= '" + comboBox_Sinav_Sonuc_Ogrenci_Sinif.Text + "'";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
                }
                if (radioButton_Sinav_Sonuc_Ada_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
                }
                else if (radioButton_Sinav_Sonuc_Grubuna_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Grubu ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
                }
                else if (radioButton_Sinav_Sonuc_Kayit_Tarihine_Gore_Sirala.Checked)
                {
                    siralama_anahtar = true;
                    ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                    KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
                }

            }
            else if (textBox_Sinav_Sonuc_Ogrenci_No.Text.Length != 0 && textBox_Sinav_Sonuc_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Sinav_Bilgi.Sinavin_Adi, Ogrenci_Sinav_Sonuc.Ygs_1, Ogrenci_Sinav_Sonuc.Ygs_2, Ogrenci_Sinav_Sonuc.Ygs_3, Ogrenci_Sinav_Sonuc.Ygs_4, Ogrenci_Sinav_Sonuc.Ygs_5, Ogrenci_Sinav_Sonuc.Ygs_6 FROM (Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Sinav_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Bilgi.Ogrenci_id) INNER JOIN Ogrenci_Sinav_Sonuc ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Sonuc.Ogrenci_id WHERE Ogrenci_No=" + textBox_Sinav_Sonuc_Ogrenci_No.Text;
                KayitGuncelle(sorgu, dataGridView_Sinav_Sonuc_Listesi);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Sinav_Bilgi.Sinavin_Adi, Ogrenci_Sinav_Sonuc.Ygs_1, Ogrenci_Sinav_Sonuc.Ygs_2, Ogrenci_Sinav_Sonuc.Ygs_3, Ogrenci_Sinav_Sonuc.Ygs_4, Ogrenci_Sinav_Sonuc.Ygs_5, Ogrenci_Sinav_Sonuc.Ygs_6 FROM (Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Sinav_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Bilgi.Ogrenci_id) INNER JOIN Ogrenci_Sinav_Sonuc ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Sonuc.Ogrenci_id WHERE Grubu= '" + comboBox_Sinav_Sonuc_Ogrenci_Grubu.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Sinav_Bilgi.Sinavin_Adi, Ogrenci_Sinav_Sonuc.Ygs_1, Ogrenci_Sinav_Sonuc.Ygs_2, Ogrenci_Sinav_Sonuc.Ygs_3, Ogrenci_Sinav_Sonuc.Ygs_4, Ogrenci_Sinav_Sonuc.Ygs_5, Ogrenci_Sinav_Sonuc.Ygs_6 FROM (Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Sinav_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Bilgi.Ogrenci_id) INNER JOIN Ogrenci_Sinav_Sonuc ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Sonuc.Ogrenci_id WHERE Bolum= '" + comboBox_Sinav_Sonuc_Ogrenci_Bolum.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Sinav_Bilgi.Sinavin_Adi, Ogrenci_Sinav_Sonuc.Ygs_1, Ogrenci_Sinav_Sonuc.Ygs_2, Ogrenci_Sinav_Sonuc.Ygs_3, Ogrenci_Sinav_Sonuc.Ygs_4, Ogrenci_Sinav_Sonuc.Ygs_5, Ogrenci_Sinav_Sonuc.Ygs_6 FROM (Ogrenci_Genel_Bilgi INNER JOIN Ogrenci_Sinav_Bilgi ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Bilgi.Ogrenci_id) INNER JOIN Ogrenci_Sinav_Sonuc ON Ogrenci_Genel_Bilgi.Ogrenci_id = Ogrenci_Sinav_Sonuc.Ogrenci_id WHERE Sinif= '" + comboBox_Sinav_Sonuc_Ogrenci_Sinif.Text + "'";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
            }
            if (radioButton_Sinav_Sonuc_Ada_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
            }
            else if (radioButton_Sinav_Sonuc_Grubuna_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Grubu ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
            }
            else if (radioButton_Sinav_Sonuc_Kayit_Tarihine_Gore_Sirala.Checked && siralama_anahtar == false)
            {
                ogrenci_listele_sorgu += " order by Kayit_Tarihi desc ";
                KayitGuncelle(ogrenci_listele_sorgu, dataGridView_Sinav_Sonuc_Listesi);
            }
        }

        private void button_Sinav_Sonuc_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Sinav_Sonuc_Ogrenci_Adi.Text = null;
            textBox_Sinav_Sonuc_Ogrenci_Soyadi.Text = null;
            textBox_Devamsizlik_Ogrenci_No.Text = null;
            comboBox_Sinav_Sonuc_Ogrenci_Bolum.Text = "Seçiniz...";
            comboBox_Sinav_Sonuc_Ogrenci_Sinif.Text = "Seçiniz...";
            comboBox_Sinav_Sonuc_Ogrenci_Grubu.Text = "Seçiniz...";
            radioButton_Sinav_Sonuc_Ada_Gore_Sirala.Checked = false;
            radioButton_Sinav_Sonuc_Kayit_Tarihine_Gore_Sirala.Checked = false;
            radioButton_Sinav_Sonuc_Grubuna_Gore_Sirala.Checked = false;
            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            siralama_anahtar = false;

            dataGridView_Devamsizlik_Listesi.DataSource = null;
        }

        private void comboBox_Sinav_Sonuc_Ogrenci_Grubu_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_grubu = true;
        }

        private void comboBox_Sinav_Sonuc_Ogrenci_Sinif_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_sinifi = true;
        }

        private void comboBox_Sinav_Sonuc_Ogrenci_Bolum_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_degisim_bolumu = true;
        }

        private void textBox_Ogrenci_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
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

        private void button_Tab_Gecis_Sag_Click(object sender, EventArgs e)
        {
            if (tabControl_Listeler.SelectedIndex != 6)
            {
                tabControl_Listeler.SelectedIndex += 1;
            }
        }

        private void button_Tab_Gecis_Sol_Click(object sender, EventArgs e)
        {
            if (tabControl_Listeler.SelectedIndex != 0)
            {
                tabControl_Listeler.SelectedIndex -= 1;
            }
        } 
    }
}
