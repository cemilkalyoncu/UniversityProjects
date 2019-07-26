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
    public partial class Form_Ogrenci_Arama : Form
    {
        public Form_Ogrenci_Arama()
        {
            InitializeComponent();
        }


        string toplu_sms_ogrenci_listele_sorgu;

        bool combo_degisim_bolumu, combo_degisim_sinifi, combo_degisim_grubu, combo_anahtar, takvim_1_degisim, takvim_2_degisim, takvim_anahtar, numara_anahtar = false;

        bool siralama_anahtar = false;

        OleDbCommand komut;

        private void button_Ogrenci_Filtrele_Click(object sender, EventArgs e)
        {
            if (textBox_Ogrenci_Adi.Text.Length != 0 || textBox_Ogrenci_Soyadi.Text.Length != 0)
            {
                toplu_sms_ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Cep_Tel, Ogrenci_Genel_Bilgi.Kayit_Tarihi, Danisman_Bilgi.Adi_Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN (Danisman_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Danisman_Bilgi.Danisman_id = Ogrenci_Genel_Bilgi.Danisman_id) ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id WHERE Adi like '" + textBox_Ogrenci_Adi.Text + "%'" + " AND Soyadi like '" + textBox_Ogrenci_Soyadi.Text + "%'";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);

                if (textBox_Ogrenci_No.Text.Length != 0 && textBox_Ogrenci_No.Text != "")
                {
                    numara_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " AND Ogrenci_No=" + textBox_Ogrenci_No.Text;
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }
                if (combo_degisim_grubu == true)
                {
                    combo_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " AND Grup_id=" + comboBox_Ogrenci_Grubu.Text + "";
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }

                if (combo_degisim_bolumu == true)
                {
                    combo_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " AND Bolum_id=" + comboBox_Ogrenci_Bolum.Text + "";
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }

                if (combo_degisim_sinifi == true)
                {
                    combo_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " AND Sinif_id=" + comboBox_Ogrenci_Sinif.Text + "";
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }

                if (takvim_1_degisim == true && takvim_2_degisim == true)
                {
                    string dt1 = dateTimePicker_Kayıt_Tarihi_Araliklari_1.Value.ToString("dd.MM.yyyy");
                    string dt2 = dateTimePicker_Kayıt_Tarihi_Araliklari_2.Value.ToString("dd.MM.yyyy");
                    dt1 = dt1.Replace('.', '/');
                    dt2 = dt2.Replace('.', '/');
                    dt1 = "#" + dt1 + "#";
                    dt2 = "#" + dt2 + "#";
                    takvim_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " AND Kayit_Tarihi between " + dt1 + " and " + dt2 + "";
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }
                if (radioButton_Ogrenci_Sirala_Ad_Gore.Checked)
                {
                    siralama_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " order by Adi ";
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }
                else if (radioButton_Ogrenci_Sirala_Sinifa_Gore.Checked)
                {
                    siralama_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " order by Sinif_id ";
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }
                else if (radioButton_Ogrenci_Sirala_Kayit_Tarihine_Gore.Checked)
                {
                    siralama_anahtar = true;
                    toplu_sms_ogrenci_listele_sorgu += " order by Kayit_Tarihi desc";
                    KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
                }
            }
            else if (textBox_Ogrenci_No.Text.Length != 0 && textBox_Ogrenci_No.Text != "" && numara_anahtar == false)
            {
                string sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Cep_Tel, Ogrenci_Genel_Bilgi.Kayit_Tarihi, Danisman_Bilgi.Adi_Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN (Danisman_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Danisman_Bilgi.Danisman_id = Ogrenci_Genel_Bilgi.Danisman_id) ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id WHERE Ogrenci_No= " + textBox_Ogrenci_No.Text;
                KayitGuncelle(sorgu);
            }

            if (combo_degisim_grubu == true && combo_anahtar == false)
            {
                toplu_sms_ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Cep_Tel, Ogrenci_Genel_Bilgi.Kayit_Tarihi, Danisman_Bilgi.Adi_Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN (Danisman_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Danisman_Bilgi.Danisman_id = Ogrenci_Genel_Bilgi.Danisman_id) ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id WHERE Grup_Adi=" + comboBox_Ogrenci_Grubu.Text + "";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
            }

            if (combo_degisim_bolumu == true && combo_anahtar == false)
            {
                toplu_sms_ogrenci_listele_sorgu = "SELECT Ogrenci_id,Ogrenci_No,Adi,Soyadi,Cep_Tel,Kayit_Tarihi,Danisman,Sinif FROM Ogrenci_Genel_Bilgi WHERE Bolum=" + comboBox_Ogrenci_Bolum.Text + "";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
            }

            if (combo_degisim_sinifi == true && combo_anahtar == false)
            {
                toplu_sms_ogrenci_listele_sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Cep_Tel, Ogrenci_Genel_Bilgi.Kayit_Tarihi, Danisman_Bilgi.Adi_Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN (Danisman_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Danisman_Bilgi.Danisman_id = Ogrenci_Genel_Bilgi.Danisman_id) ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id WHERE Sinif_Adi=" + comboBox_Ogrenci_Sinif.Text + "";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
            }

            if (!takvim_anahtar && takvim_1_degisim == true && takvim_2_degisim == true)
            {
                string dt1 = dateTimePicker_Kayıt_Tarihi_Araliklari_1.Value.ToString("dd.MM.yyyy");
                string dt2 = dateTimePicker_Kayıt_Tarihi_Araliklari_2.Value.ToString("dd.MM.yyyy");
                dt1 = dt1.Replace('.', '/');
                dt2 = dt2.Replace('.', '/');
                dt1 = "#" + dt1 + "#";
                dt2 = "#" + dt2 + "#";
                toplu_sms_ogrenci_listele_sorgu += "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Cep_Tel, Ogrenci_Genel_Bilgi.Kayit_Tarihi, Danisman_Bilgi.Adi_Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN (Danisman_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Danisman_Bilgi.Danisman_id = Ogrenci_Genel_Bilgi.Danisman_id) ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id WHERE Kayit_Tarihi between " + dt1 + " and " + dt2 + "";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
            }

            if (radioButton_Ogrenci_Sirala_Ad_Gore.Checked && siralama_anahtar == false)
            {
                toplu_sms_ogrenci_listele_sorgu += " order by Adi ";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
            }
            else if (radioButton_Ogrenci_Sirala_Sinifa_Gore.Checked && siralama_anahtar == false)
            {
                toplu_sms_ogrenci_listele_sorgu += " order by Sinif_id ";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
            }
            else if (radioButton_Ogrenci_Sirala_Kayit_Tarihine_Gore.Checked && siralama_anahtar == false)
            {
                toplu_sms_ogrenci_listele_sorgu += " order by Kayit_Tarihi desc";
                KayitGuncelle(toplu_sms_ogrenci_listele_sorgu);
            }
        }

        private void KayitGuncelle(string sorgu)
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Ogrenci_Genel_Bilgi");
            dataGridView_Ogrenci_Arama_Listele.DataSource = ds.Tables["Ogrenci_Genel_Bilgi"];
            dataGridView_Ogrenci_Arama_Listele.Columns["Ogrenci_id"].Visible = false;
            dataGridView_Ogrenci_Arama_Listele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Form_Ogrenci_Arama_Load(object sender, EventArgs e)
        {
            toolTip_Ogrenci_Arama.SetToolTip(button_Ogrenci_Sil, "Kayıt Sil");
            dataGridView_Ogrenci_Arama_Listele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

        private void textBox_Ogrenci_No_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ogrenci_No.Text.Length == 0)
                dataGridView_Ogrenci_Arama_Listele.DataSource = null;
        }

        private void button_Tum_Kayitlar_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Cep_Tel, Ogrenci_Genel_Bilgi.Kayit_Tarihi, Danisman_Bilgi.Adi_Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN (Danisman_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Danisman_Bilgi.Danisman_id = Ogrenci_Genel_Bilgi.Danisman_id) ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id";
            KayitGuncelle(sorgu);
        }

        private void dateTimePicker_Kayıt_Tarihi_Araliklari_1_ValueChanged(object sender, EventArgs e)
        {
            takvim_1_degisim = true;
            takvim_anahtar = true;
        }

        private void dateTimePicker_Kayıt_Tarihi_Araliklari_2_ValueChanged(object sender, EventArgs e)
        {
            takvim_2_degisim = true;
        }

        private void button_Ogrenci_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci_Adi.Text = null;
            textBox_Ogrenci_No.Text = null;
            textBox_Ogrenci_Soyadi.Text = null;
            comboBox_Ogrenci_Bolum.Text = null;
            comboBox_Ogrenci_Grubu.Text = null;
            comboBox_Ogrenci_Sinif.Text = null;
            radioButton_Ogrenci_Sirala_Ad_Gore.Checked = false;
            radioButton_Ogrenci_Sirala_Kayit_Tarihine_Gore.Checked = false;
            radioButton_Ogrenci_Sirala_Sinifa_Gore.Checked = false;
            dateTimePicker_Kayıt_Tarihi_Araliklari_1.Text = null;
            dateTimePicker_Kayıt_Tarihi_Araliklari_2.Text = null;
        }

        private void button_Ogrenci_Sil_Click(object sender, EventArgs e)
        {
            if (A_Genel.baglanti.State == ConnectionState.Closed)
            {
                A_Genel.baglanti.Open();
            }

            if (dataGridView_Ogrenci_Arama_Listele.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Ogrenci_Arama_Listele.CurrentRow.Cells["Ogrenci_id"].Value.ToString();
                string sorgu = "DELETE From Ogrenci_Genel_Bilgi WHERE Ogrenci_id=" + satir + "";
                DialogResult cvp = MessageBox.Show("Kayıt Silinecektir Devam Edilsin mi ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cvp == DialogResult.Yes)
                {
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silme İşlemi Tamamlanmıştır...");
                }

                string sorgu2 = "SELECT Ogrenci_Genel_Bilgi.Ogrenci_id, Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Ogrenci_Genel_Bilgi.Cep_Tel, Ogrenci_Genel_Bilgi.Kayit_Tarihi, Danisman_Bilgi.Adi_Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN (Danisman_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Danisman_Bilgi.Danisman_id = Ogrenci_Genel_Bilgi.Danisman_id) ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id";
                KayitGuncelle(sorgu2);

            }
            A_Genel.baglanti.Close();
        }

        private void textBox_Ogrenci_No_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Ogrenci_No)
            {
                textBox_Ogrenci_No.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_No.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Adi)
            {
                textBox_Ogrenci_Adi.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci_Soyadi)
            {
                textBox_Ogrenci_Soyadi.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci_Soyadi.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Bolum)
            {
                comboBox_Ogrenci_Bolum.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Bolum.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Grubu)
            {
                comboBox_Ogrenci_Grubu.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Grubu.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Ogrenci_Sinif)
            {
                comboBox_Ogrenci_Sinif.BackColor = Color.LightSteelBlue;
                comboBox_Ogrenci_Sinif.ForeColor = Color.Crimson;
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
    }
}
