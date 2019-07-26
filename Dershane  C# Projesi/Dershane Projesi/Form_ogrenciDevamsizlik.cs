using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Dershane_Projesi
{
    public partial class Form_Ogrenci_Devamsizlik : Form
    {
        public Form_Ogrenci_Devamsizlik()
        {
            InitializeComponent();
        }

        bool combo_degisim_bolumu, combo_degisim_sinifi, combo_degisim_grubu, combo_anahtar, numara_anahtar = false;

        string ogrenci_devamsizlik_sorgu, devamsizlik_islenicek_ogrenci_id;

        string devamsizlik_sayi = "0.0";

        OleDbCommand komut;

        double devamsiz_gun_sayisi;

        private void button_Ogrenci_Yeni_Devamsizlik_isle_Click(object sender, EventArgs e)
        {
            dataGridView_Ogrenci_Devamsizlik_Sorgula.Visible = true;
            textBox_Ogrenci_Devamsizlik_isle_Adi.Text = null;
            textBox_Ogrenci_Devamsizlik_isle_Soyadi.Text = null;
        }

        private void button_Ogrenci_Devamsizlik_isle_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Ogrenci_Devamsizlik_isle_Adi.Text.Length != 0 || textBox_Ogrenci_Devamsizlik_isle_Soyadi.Text.Length != 0)
            {
                ogrenci_devamsizlik_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Cep_Tel,Kayit_Tarihi,Danisman,Sinif FROM Ogrenci_Genel_Bilgi WHERE Adi like '" + textBox_Ogrenci_Devamsizlik_isle_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Ogrenci_Devamsizlik_isle_Soyadi.Text + "%'";
                KayitGuncelle(ogrenci_devamsizlik_sorgu);

                if (textBox_Ogrenci_Devamsizlik_isle_No.Text.Length != 0 && textBox_Ogrenci_Devamsizlik_isle_No.Text != "")
                {
                    numara_anahtar = true;
                    ogrenci_devamsizlik_sorgu += " AND Ogrenci_No=" + textBox_Ogrenci_Devamsizlik_isle_No.Text;
                    KayitGuncelle(ogrenci_devamsizlik_sorgu);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    ogrenci_devamsizlik_sorgu += " AND Grubu=" + comboBox_Ogrenci_Devamsizlik_isle_Grubu.Text + "";
                    KayitGuncelle(ogrenci_devamsizlik_sorgu);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    ogrenci_devamsizlik_sorgu += " AND Bolum=" + comboBox_Ogrenci_Devamsizlik_isle_Bolum.Text + "";
                    KayitGuncelle(ogrenci_devamsizlik_sorgu);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    ogrenci_devamsizlik_sorgu += " AND Sinif=" + comboBox_Ogrenci_Devamsizlik_isle_Sinif + "";
                    KayitGuncelle(ogrenci_devamsizlik_sorgu);
                }

            }
            else if (textBox_Ogrenci_Devamsizlik_isle_No.Text.Length != 0 && textBox_Ogrenci_Devamsizlik_isle_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Cep_Tel,Kayit_Tarihi,Danisman,Sinif FROM Ogrenci_Genel_Bilgi WHERE Ogrenci_No= " + textBox_Ogrenci_Devamsizlik_isle_No.Text;
                KayitGuncelle(sorgu);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                ogrenci_devamsizlik_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Cep_Tel,Kayit_Tarihi,Danisman,Sinif FROM Ogrenci_Genel_Bilgi WHERE Grubu=" + comboBox_Ogrenci_Devamsizlik_isle_Grubu.Text + "";
                KayitGuncelle(ogrenci_devamsizlik_sorgu);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                ogrenci_devamsizlik_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Cep_Tel,Kayit_Tarihi,Danisman,Sinif FROM Ogrenci_Genel_Bilgi WHERE Bolum=" + comboBox_Ogrenci_Devamsizlik_isle_Bolum.Text + "";
                KayitGuncelle(ogrenci_devamsizlik_sorgu);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                ogrenci_devamsizlik_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Cep_Tel,Kayit_Tarihi,Danisman,Sinif FROM Ogrenci_Genel_Bilgi WHERE Sinif=" + comboBox_Ogrenci_Devamsizlik_isle_Sinif.Text + "";
                KayitGuncelle(ogrenci_devamsizlik_sorgu);
            }
        }
        private void KayitGuncelle(string sorgu)
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Ogrenci_Genel_Bilgi");
            dataGridView_Ogrenci_Devamsizlik_Sorgula.DataSource = ds.Tables["Ogrenci_Genel_Bilgi"];
            dataGridView_Ogrenci_Devamsizlik_Sorgula.Columns["Ogrenci_id"].Visible = false;
            dataGridView_Ogrenci_Devamsizlik_Sorgula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Ogrenci_Devamsizlik_Bilgi WHERE Ogrenci_id=" + devamsizlik_islenicek_ogrenci_id + "", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Ogrenci_Devamsizlik_Bilgi");
            dataGridView_Ogrenci_Devamszilik_Kontrol.DataSource = ds.Tables["Ogrenci_Devamsizlik_Bilgi"];
            dataGridView_Ogrenci_Devamszilik_Kontrol.Columns["Ogrenci_id"].Visible = false;
            dataGridView_Ogrenci_Devamszilik_Kontrol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button_Ogrenci_Devamsizlik_isle_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci_Devamsizlik_isle_Adi.Text = null;
            textBox_Ogrenci_Devamsizlik_isle_No.Text = null;
            textBox_Ogrenci_Devamsizlik_isle_Soyadi.Text = null;

            comboBox_Ogrenci_Devamsizlik_isle_Bolum.Text = null;
            comboBox_Ogrenci_Devamsizlik_isle_Grubu.Text = null;
            comboBox_Ogrenci_Devamsizlik_isle_Sinif.Text = null;

            datePicker_Ogrenci_Devamsizlik_islenecek_Tarih.Text = null;
            comboBox_Ogrenci_Devamsizlik_Turu.Text = null;

            combo_degisim_bolumu = false;
            combo_degisim_grubu = false;
            combo_degisim_sinifi = false;

            dataGridView_Ogrenci_Devamsizlik_Sorgula.DataSource = null;
        }

        private void button_Ogrenci_Devamsizlik_Kaydet_Click(object sender, EventArgs e)
        {
            devamsizlik_sayi = devamsizlik_sayi.Replace('.', ',');

            string sorgu = "SELECT  TOP 1 * FROM Ogrenci_Devamsizlik_Bilgi WHERE Ogrenci_id=" + devamsizlik_islenicek_ogrenci_id + " order by Toplam_Devamsizlik desc ";

            OleDbCommand veri = new OleDbCommand(sorgu, A_Genel.baglanti);
            OleDbDataReader oku;

            oku = veri.ExecuteReader();

            while (oku.Read())
            {
                devamsiz_gun_sayisi = Convert.ToDouble(oku["Toplam_Devamsizlik"].ToString());
                break;
            }

            if (comboBox_Ogrenci_Devamsizlik_Turu.SelectedIndex == 0)
            {
                devamsiz_gun_sayisi += 1;
                devamsizlik_sayi = devamsiz_gun_sayisi.ToString();
                devamsiz_gun_sayisi = Convert.ToDouble(devamsizlik_sayi);
            }
            else if (comboBox_Ogrenci_Devamsizlik_Turu.SelectedIndex == 1)
            {
                devamsiz_gun_sayisi += 0.5;
                devamsizlik_sayi = devamsiz_gun_sayisi.ToString();
                devamsiz_gun_sayisi = Convert.ToDouble(devamsizlik_sayi);
            }
            else if (comboBox_Ogrenci_Devamsizlik_Turu.SelectedIndex == 2)
            {
                devamsiz_gun_sayisi += 0.1;
                devamsizlik_sayi = devamsiz_gun_sayisi.ToString();
                devamsiz_gun_sayisi = Convert.ToDouble(devamsizlik_sayi);
            }
            else if (comboBox_Ogrenci_Devamsizlik_Turu.SelectedIndex == 3)
            {
                devamsiz_gun_sayisi += 0.2;
                devamsizlik_sayi = devamsiz_gun_sayisi.ToString();
                devamsiz_gun_sayisi = Convert.ToDouble(devamsizlik_sayi);
            }

            try
            {
                string sorgu2 = "INSERT INTO Ogrenci_Devamsizlik_Bilgi(Ogrenci_id,Devamsizlik_Yapilan_Tarih,Toplam_Devamsizlik)values(@1,@2,@3)";
                komut = new OleDbCommand(sorgu2, A_Genel.baglanti);

                komut.Parameters.Add("@1", devamsizlik_islenicek_ogrenci_id);
                komut.Parameters.Add("@2", datePicker_Ogrenci_Devamsizlik_islenecek_Tarih.Text);
                komut.Parameters.Add("@3", devamsiz_gun_sayisi.ToString());

                komut.ExecuteNonQuery();

                KayitlariGetir();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
            }
        }

        private void button_Ogrenci_Devamsizlik_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Ogrenci_Devamszilik_Kontrol.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Ogrenci_Devamszilik_Kontrol.CurrentRow.Cells["Devamsizlik_id"].Value.ToString();
                string sorgu = "DELETE From Ogrenci_Devamsizlik_Bilgi WHERE Devamsizlik_id=" + satir + "";
                DialogResult cvp = MessageBox.Show("Kayıt Silinecektir Devam Edilsin mi ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cvp == DialogResult.Yes)
                {
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silme İşlemi Tamamlanmıştır...");
                }

                KayitlariGetir();
            }
        }

        private void button_Ogrenci_Tüm_Devamsizlik_Goster_Click(object sender, EventArgs e)
        {
            try
            {
                KayitlariGetir();
            }
            catch
            {
                MessageBox.Show("Lütfen Devamsızlığı Listelenecek Öğrenci Seçiniz...");
            }
        }

        private void textBox_Ogrenci_Devamsizlik_isle_No_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ogrenci_Devamsizlik_isle_No.Text.Length == 0)
                dataGridView_Ogrenci_Devamsizlik_Sorgula.DataSource = null;
        }

        private void dataGridView_Ogrenci_Devamsizlik_Sorgula_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Ogrenci_Devamsizlik_isle_Adi.Text = dataGridView_Ogrenci_Devamsizlik_Sorgula.CurrentRow.Cells["Adi"].Value.ToString().ToUpper();
            textBox_Ogrenci_Devamsizlik_isle_Soyadi.Text = dataGridView_Ogrenci_Devamsizlik_Sorgula.CurrentRow.Cells["Soyadi"].Value.ToString().ToUpper();
            dataGridView_Ogrenci_Devamsizlik_Sorgula.Visible = false;
            devamsizlik_islenicek_ogrenci_id = dataGridView_Ogrenci_Devamsizlik_Sorgula.CurrentRow.Cells["Ogrenci_id"].Value.ToString();
     
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

        private void Form_Ogrenci_Devamsizlik_Load(object sender, EventArgs e)
        {
            toolTip_Devamsizlik_isle.SetToolTip(button_Ogrenci_Devamsizlik_Kaydet, "Devamsızlık Kaydet");
            toolTip_Devamsizlik_isle.SetToolTip(button_Ogrenci_Devamsizlik_Sil, "Devamsızlık Sil");
            toolTip_Devamsizlik_isle.SetToolTip(button_Ogrenci_Yeni_Devamsizlik_isle, "Yeni Devamsızlık Ekranı");
            dataGridView_Ogrenci_Devamsizlik_Sorgula.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                comboBox_Ogrenci_Devamsizlik_isle_Bolum.DataSource = ds.Tables[0];
                comboBox_Ogrenci_Devamsizlik_isle_Bolum.DisplayMember = "Bolum_Adi";
                comboBox_Ogrenci_Devamsizlik_isle_Bolum.ValueMember = "Bolum_id";

                //Combobox grup
                string sorgu1 = "Select * from Grup_Bilgi order by Grup_id asc";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sorgu1, A_Genel.baglanti);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Grup_Bilgi");
                comboBox_Ogrenci_Devamsizlik_isle_Grubu.DataSource = ds1.Tables[0];
                comboBox_Ogrenci_Devamsizlik_isle_Grubu.DisplayMember = "Grup_Adi";
                comboBox_Ogrenci_Devamsizlik_isle_Grubu.ValueMember = "Grup_id";

                //Combobox sinif
                string sorgu2 = "Select * from Sinif_Bilgi order by Sinif_id asc";
                OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2, "Sinif_Bilgi");
                comboBox_Ogrenci_Devamsizlik_isle_Sinif.DataSource = ds2.Tables[0];
                comboBox_Ogrenci_Devamsizlik_isle_Sinif.DisplayMember = "Sinif_Adi";
                comboBox_Ogrenci_Devamsizlik_isle_Sinif.ValueMember = "Sinif_id";

                A_Genel.baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }


        private void textBox_Ogrenci_Devamsizlik_isle_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Ogrenci_Devamsizlik_isle_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}
