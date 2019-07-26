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
    public partial class Form_Ogrenci_Sinav : Form
    {
        public Form_Ogrenci_Sinav()
        {
            InitializeComponent();
        }

        bool sorgu_anahtar = false;
        int secili_grup;
        int sorusayi1, sorusayi2, top_soru, bolumsorusayisi1, bolumsorusayisi2;
        int sinav_id, sinav_ogrenci_id;

        OleDbCommand komut;
        OleDbCommand komut1;
        private void Form_Ogrenci_Sinav_Load(object sender, EventArgs e)
        {
            toolTip_Sinav_isle.SetToolTip(button_Ogrenci_Yeni_Sinav_Giris, "Yeni Sınav Kayıt");
            toolTip_Sinav_isle.SetToolTip(button_Ogrenci_Sinav_Kaydet, "Sınav Bilgilerini Kaydet");
            toolTip_Sinav_isle.SetToolTip(button_Ogrenci_Sinav_Sil, "Sınav Sil");

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
        }
        private void aramayap(string sorgu)
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Ogrenci_Genel_Bilgi");
            dataGridView_Ogrenci_Sinav_isle_Listele.DataSource = ds.Tables["Ogrenci_Genel_Bilgi"];
            dataGridView_Ogrenci_Sinav_isle_Listele.Columns["Ogrenci_id"].Visible = false;
            dataGridView_Ogrenci_Sinav_isle_Listele.Visible = true;
            dataGridView_Ogrenci_Sinav_isle_Listele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            groupBox_Sinav_Kaydi.Visible = false;
        }
        private void button_Ogrenci_Yeni_Sinav_Giris_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci_Sinav_isle_Adi.Text = null;
            textBox_Ogrenci_Sinav_isle_Soyadi.Text = null;
            textBox_Ogrenci_Sinav_isle_No.Text = null;
            comboBox_Ogrenci_Sinav_isle_Grubu.Text = "Seçiniz...";
            dataGridView_Ogrenci_Sinav_isle_Listele.Visible = true;
            groupBox_Sinav_Kaydi.Visible = true;
            dataGridView_Ogrenci_Sinav_isle_Listele.Visible = false;
            textBox_Kaydi_Yapilacak_Adi.Text = null;
            textBox_Kaydi_Yapilacak_No.Text = null;
            textBox_Kaydi_Yapilacak_Soyadi.Text = null;
            textBox_Sinavin_Adi.Text = null;
            dateTimePicker_Sinav_Tarihi.Text = null;
            comboBox_Sinav_Saati.Text = "Seçiniz...";
            textBox_Sinav_Suresi.Text = null;
            numericUpDown_Ogrenci_Sayisi.Value = 0;
            textBox_Turkce_D.Text = null;
            textBox_Turkce_Y.Text = null;
            textBox_Turkce_Net.Text = null;
            textBox_Matematik_D.Text = null;
            textBox_Matematik_Y.Text = null;
            textBox_Matematik_Net.Text = null;
            textBox_Geometri_D.Text = null;
            textBox_Geometri_Y.Text = null;
            textBox_Geometri_Net.Text = null;
            textBox_Tarih_D.Text = null;
            textBox_Tarih_Y.Text = null;
            textBox_Tarih_Net.Text = null;
            textBox_Cografya_D.Text = null;
            textBox_Cografya_Y.Text = null;
            textBox_Cografya_Net.Text = null;
            textBox_Felsefe_D.Text = null;
            textBox_Felsefe_Y.Text = null;
            textBox_Felsefe_Net.Text = null;
            textBox_Fizik_D.Text = null;
            textBox_Fizik_Y.Text = null;
            textBox_Fizik_Net.Text = null;
            textBox_Kimya_D.Text = null;
            textBox_Kimya_Y.Text = null;
            textBox_Kimya_Net.Text = null;
            textBox_Biyoloji_D.Text = null;
            textBox_Biyoloji_Y.Text = null;
            textBox_Biyoloji_Net.Text = null;
            textBox_Toplam_Net.Text = null;
            textBox_Ygs_1.Text = null;
            textBox_Ygs_2.Text = null;
            textBox_Ygs_3.Text = null;
            textBox_Ygs_4.Text = null;
            textBox_Ygs_5.Text = null;
            textBox_Ygs_6.Text = null;
        }

        private void button_Ogrenci_Sinav_isle_Filtrele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Grubu,Sinif,Bolum FROM Ogrenci_Genel_Bilgi WHERE ";

            if (textBox_Ogrenci_Sinav_isle_Adi.Text != "" || textBox_Ogrenci_Sinav_isle_Soyadi.Text != "" || textBox_Ogrenci_Sinav_isle_No.Text != "" || comboBox_Ogrenci_Sinav_isle_Grubu.SelectedIndex > -1)
            {

                if (textBox_Ogrenci_Sinav_isle_Adi.Text != "")
                {
                    sorgu_anahtar = true;
                    sorgu += " Adi " + " Like'" + textBox_Ogrenci_Sinav_isle_Adi.Text + "%'";
                }

                if (textBox_Ogrenci_Sinav_isle_Soyadi.Text != "")
                {
                    if (sorgu_anahtar)
                    {
                        sorgu_anahtar = true;
                        sorgu += " AND " + "Soyadi" + " Like'" + textBox_Ogrenci_Sinav_isle_Soyadi.Text + "%'";
                    }
                    else
                    {
                        sorgu += " Soyadi " + "Like'" + textBox_Ogrenci_Sinav_isle_Soyadi.Text + "%'";
                    }
                }

                if (textBox_Ogrenci_Sinav_isle_No.Text != "")
                {
                    if (sorgu_anahtar)
                    {
                        sorgu_anahtar = true;
                        sorgu += " AND " + "Ogrenci_No=" + textBox_Ogrenci_Sinav_isle_No.Text;
                    }
                    else
                    {
                        sorgu += " Ogrenci_No= " + textBox_Ogrenci_Sinav_isle_No.Text;
                    }
                }

                secili_grup = comboBox_Ogrenci_Sinav_isle_Grubu.SelectedIndex;

                if (secili_grup > -1)
                {
                    if (sorgu_anahtar)
                    {
                        sorgu_anahtar = true;
                        sorgu += " AND " + "Grubu=" + comboBox_Ogrenci_Sinav_isle_Grubu.Text;
                    }
                    else
                    {
                        sorgu += "Grubu=" + comboBox_Ogrenci_Sinav_isle_Grubu.Text;
                    }
                }

                aramayap(sorgu);
            }

            else
            {
                MessageBox.Show("Lütfen Herhangi Bir Arama Kriteri Belirtiniz...");
            }
        }

        private void button_Ogrenci_Sinav_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO Ogrenci_Sinav_Sonuc(Ogrenci_id,Turkce_D,Turkce_Y,Turkce_N,Mat_D,Mat_Y,Mat_N,Geo_D,Geo_Y,Geo_N,Tarih_D,Tarih_Y,Tarih_N,Cog_D,Cog_Y,Cog_N,Fels_D,Fels_Y,Fels_N,Fizik_D,Fizik_Y,Fizik_N,Kimya_D,Kimya_Y,Kimya_N,Biyo_D,Biyo_Y,Biyo_N,Toplam_Net,Ygs_1,Ygs_2,Ygs_3,Ygs_4,Ygs_5,Ygs_6)values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28,@29,@30,@31,@32,@33,@34,@35)";
                komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                komut.Parameters.Add("@1", A_Genel.ogrnci_sinav_isle_id);
                komut.Parameters.Add("@2", textBox_Turkce_D.Text);
                komut.Parameters.Add("@3", textBox_Turkce_Y.Text);
                komut.Parameters.Add("@4", textBox_Turkce_Net.Text);
                komut.Parameters.Add("@5", textBox_Matematik_D.Text);
                komut.Parameters.Add("@6", textBox_Matematik_Y.Text);
                komut.Parameters.Add("@7", textBox_Matematik_Net.Text);
                komut.Parameters.Add("@8", textBox_Geometri_D.Text);
                komut.Parameters.Add("@9", textBox_Geometri_Y.Text);
                komut.Parameters.Add("@10", textBox_Geometri_Net.Text);
                komut.Parameters.Add("@11", textBox_Tarih_D.Text);
                komut.Parameters.Add("@12", textBox_Tarih_Y.Text);
                komut.Parameters.Add("@13", textBox_Tarih_Net.Text);
                komut.Parameters.Add("@14", textBox_Cografya_D.Text);
                komut.Parameters.Add("@15", textBox_Cografya_Y.Text);
                komut.Parameters.Add("@16", textBox_Cografya_Net.Text);
                komut.Parameters.Add("@17", textBox_Felsefe_D.Text);
                komut.Parameters.Add("@18", textBox_Felsefe_Y.Text);
                komut.Parameters.Add("@19", textBox_Felsefe_Net.Text);
                komut.Parameters.Add("@20", textBox_Fizik_D.Text);
                komut.Parameters.Add("@21", textBox_Fizik_Y.Text);
                komut.Parameters.Add("@22", textBox_Fizik_Net.Text);
                komut.Parameters.Add("@23", textBox_Kimya_D.Text);
                komut.Parameters.Add("@24", textBox_Kimya_Y.Text);
                komut.Parameters.Add("@25", textBox_Kimya_Net.Text);
                komut.Parameters.Add("@26", textBox_Biyoloji_D.Text);
                komut.Parameters.Add("@27", textBox_Biyoloji_Y.Text);
                komut.Parameters.Add("@28", textBox_Biyoloji_Net.Text);
                komut.Parameters.Add("@29", textBox_Toplam_Net.Text);
                komut.Parameters.Add("@30", textBox_Ygs_1.Text);
                komut.Parameters.Add("@31", textBox_Ygs_2.Text);
                komut.Parameters.Add("@32", textBox_Ygs_3.Text);
                komut.Parameters.Add("@33", textBox_Ygs_4.Text);
                komut.Parameters.Add("@34", textBox_Ygs_5.Text);
                komut.Parameters.Add("@35", textBox_Ygs_6.Text);

                string sorgu1 = "INSERT INTO Ogrenci_Sinav_Bilgi(Ogrenci_id,Sinavin_Adi,Sinav_Tarihi,Sinav_Saati,Sinav_Süresi,Ogrenci_Sayisi)values(@1,@2,@3,@4,@5,@6)";
                komut1 = new OleDbCommand(sorgu1, A_Genel.baglanti);

                komut1.Parameters.Add("@1", A_Genel.ogrnci_sinav_isle_id);
                komut1.Parameters.Add("@2", textBox_Sinavin_Adi.Text);
                komut1.Parameters.Add("@3", dateTimePicker_Sinav_Tarihi.Text);
                komut1.Parameters.Add("@4", comboBox_Sinav_Saati.Text);
                komut1.Parameters.Add("@5", textBox_Sinav_Suresi.Text);
                komut1.Parameters.Add("@6", numericUpDown_Ogrenci_Sayisi.Value);
                
                komut1.ExecuteNonQuery();
                komut.ExecuteNonQuery();

                KayitlariGetir();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu... " + exc.Message);
            }

            MessageBox.Show("Sınav Kayıt İşlemi Tamamlanmıştır...");
        }
        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Ogrenci_Sinav_Bilgi", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Ogrenci_Sinav_Bilgi");
            dataGridView_Sinav_Kayit_Kontrol.DataSource = ds.Tables["Ogrenci_Sinav_Bilgi"];
            dataGridView_Sinav_Kayit_Kontrol.Columns["Sinav_id"].Visible = false;
            dataGridView_Sinav_Kayit_Kontrol.Columns["Ogrenci_id"].Visible = false;
            dataGridView_Sinav_Kayit_Kontrol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button_Ogrenci_Sinav_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Sinav_Kayit_Kontrol.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Sinav_Kayit_Kontrol.CurrentRow.Cells["Ogrenci_id"].Value.ToString();
                string sorgu = "DELETE From Ogrenci_Sinav_Bilgi WHERE Ogrenci_id=" + satir + "";
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
        private void sinamayap(TextBox kontrol, string alan)
        {
            try
            {
                sorusayi1 = Convert.ToInt32(kontrol.Text);
                bolumsorusayisi1 = Convert.ToInt32(alan);
            }
            catch (Exception)
            {

            }
            if (sorusayi1 > bolumsorusayisi1)
            {
                errorProvider_Sinav_isle.SetError(kontrol, "Girilen Değer " + alan + " Değerinden Büyük Olamaz...");
                kontrol.Focus();
            }
            else
                errorProvider_Sinav_isle.SetError(kontrol, null);
        }

        private void button_Ygs_Puan_Hesapla_Click(object sender, EventArgs e)
        {

        }

        private void button_Tum_Sinavlar_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void textBox_Ogrenci_Sinav_isle_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_Ogrenci_Sinav_isle_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
