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
    public partial class Form_danismanKayit : Form
    {
        public Form_danismanKayit()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        private void Form_danismanEkle_Load(object sender, EventArgs e)
        {
            toolTip_Danisman_Kayit.SetToolTip(button_Danisman_Kaydet, "Danışman Kaydet");
            toolTip_Danisman_Kayit.SetToolTip(button_Danisman_Sil, "Danışman Sil");
            toolTip_Danisman_Kayit.SetToolTip(button_Danisman_Kayit_Listele, "Tum Kayıtlar");
            toolTip_Danisman_Kayit.SetToolTip(button_Danisman_Yeni_Kayit, "Yeni Danışman Kayıt");
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
        private void KayitlariGetir()
        {
            string sorgu2 = "SELECT * FROM Danisman_Bilgi ORDER BY Danisman_id desc";
            OleDbDataAdapter da2 = new OleDbDataAdapter(sorgu2, A_Genel.baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Danisman_Bilgi");
            dataGridView_Danisman_Kayit.DataSource = ds2.Tables[0];
            dataGridView_Danisman_Kayit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                string sorgu = "Select * from Ders_Bilgi order by Ders_id asc";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "Ders_Bilgi");
                comboBox_Danisman_Girdigi_Ders.DataSource = ds.Tables[0];
                comboBox_Danisman_Girdigi_Ders.DisplayMember = "Ders_Adi";
                comboBox_Danisman_Girdigi_Ders.ValueMember = "Ders_id";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }

        private void button_Danisman_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            A_Genel.anahtar = true;
            textBox_Danisman_Adi_Soyadi.Text = null;
            comboBox_Danisman_Girdigi_Ders.Text = null;
        }

        private void textBox_Danisman_Adi_Soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            
        }

        private void textBox_Danisman_Adi_Soyadi_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Danisman_Adi_Soyadi)
            {
                textBox_Danisman_Adi_Soyadi.BackColor = Color.LightSteelBlue;
                textBox_Danisman_Adi_Soyadi.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Danisman_Girdigi_Ders)
            {
                comboBox_Danisman_Girdigi_Ders.BackColor = Color.LightSteelBlue;
                comboBox_Danisman_Girdigi_Ders.ForeColor = Color.Crimson;
            }
        }

        private void textBox_Danisman_Adi_Soyadi_Leave(object sender, EventArgs e)
        {
            if (textBox_Danisman_Adi_Soyadi.Text.Length == 0)
            {
                errorProvider_Danisman_Kayit.SetError(textBox_Danisman_Adi_Soyadi, "Bölüm Adı Boş Geçilemez...");
                textBox_Danisman_Adi_Soyadi.Focus();
            }
            else
            {
                errorProvider_Danisman_Kayit.SetError(textBox_Danisman_Adi_Soyadi, null);
            }
            textBox_Danisman_Adi_Soyadi.BackColor = Color.SteelBlue;
            textBox_Danisman_Adi_Soyadi.ForeColor = Color.White;
        }

        private void comboBox_Danisman_Girdigi_Ders_Leave(object sender, EventArgs e)
        {
            comboBox_Danisman_Girdigi_Ders.BackColor = Color.SteelBlue;
            comboBox_Danisman_Girdigi_Ders.ForeColor = Color.White;
        }
        
        private void button_Danisman_Kaydet_Click(object sender, EventArgs e)
        {
            if (A_Genel.anahtar)
            {
                try
                {
                    string sorgu = "INSERT INTO Danisman_Bilgi(Adi_Soyadi,Girdigi_Ders)values(@1,@2)";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Danisman_Adi_Soyadi.Text);
                    komut.Parameters.Add("@2", comboBox_Danisman_Girdigi_Ders.Text);

                    komut.ExecuteNonQuery();

                    KayitlariGetir();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
                }
            }
            else
            {
                try
                {
                    string guncel_satir = dataGridView_Danisman_Kayit.CurrentRow.Cells["Danisman_id"].Value.ToString();
                    string sorgu = "UPDATE Danisman_Bilgi SET Adi_Soyadi=@1,Girdigi_Ders=@2 WHERE Danisman_id=" + guncel_satir + "";

                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Danisman_Adi_Soyadi.Text);
                    komut.Parameters.Add("@2", comboBox_Danisman_Girdigi_Ders.Text);

                    komut.ExecuteNonQuery();

                    KayitlariGetir();

                    MessageBox.Show("Kayıt Güncelleme İşlemi Tamamlandı...");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
                }
            }

        }

        private void button_Danisman_Kayit_Listele_Click(object sender, EventArgs e)
        {
            KayitlariGetir(); 
        }

        private void button_Danisman_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Danisman_Kayit.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Danisman_Kayit.CurrentRow.Cells["Danisman_id"].Value.ToString();
                string sorgu = "DELETE From Danisman_Bilgi WHERE Danisman_id=" + satir + "";
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

        private void dataGridView_Danisman_Kayit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Form_danismanKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            A_Genel.baglanti.Close();
        }

        private void dataGridView_Bolum_Kayit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Danisman_Adi_Soyadi.Text = dataGridView_Danisman_Kayit.CurrentRow.Cells["Adi_Soyadi"].Value.ToString();
            comboBox_Danisman_Girdigi_Ders.Text = dataGridView_Danisman_Kayit.CurrentRow.Cells["Girdigi_Ders"].Value.ToString();
            A_Genel.anahtar = false;
        }
    }
}
