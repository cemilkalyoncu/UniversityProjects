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
    public partial class Form_dersKayit : Form
    {
        public Form_dersKayit()
        {
            InitializeComponent();
        }
        OleDbCommand komut;

        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Ders_Bilgi order by ders_id desc", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Ders_Bilgi");
            dataGridView_Ders_Kayit.DataSource = ds.Tables["Ders_Bilgi"];
            dataGridView_Ders_Kayit.Columns["Ders_id"].Visible = false;
            dataGridView_Ders_Kayit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button_Bolum_Kaydet_Click(object sender, EventArgs e)
        {
            if (A_Genel.anahtar)
            {
                try
                {
                    string sorgu = "INSERT INTO Ders_Bilgi(Ders_Adi,Aciklama)values(@1,@2)";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Ders_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Ders_Aciklama.Text);

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
                    string guncel_satir = dataGridView_Ders_Kayit.CurrentRow.Cells["Ders_id"].Value.ToString();
                    string sorgu = "UPDATE Ders_Bilgi SET Ders_Adi=@1,Aciklama=@2 WHERE Ders_id=" + guncel_satir + "";

                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Ders_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Ders_Aciklama.Text);

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

        private void Form_dersKayit_Load(object sender, EventArgs e)
        {
            toolTip_Ders_Kayit.SetToolTip(button_Ders_Kaydet, "Ders Kaydet");
            toolTip_Ders_Kayit.SetToolTip(button_Ders_Sil, "Ders Sil");
            toolTip_Ders_Kayit.SetToolTip(button_Ders_Yeni_Kayit, "Yeni Kayıt");
            toolTip_Ders_Kayit.SetToolTip(button_Kayit_Listele, "Tüm Kayıtlar");

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

        private void button_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            A_Genel.anahtar = true;
            textBox_Ders_Aciklama.Text = null;
            textBox_Ders_Adi.Text = null;
        }

        private void button_Kayit_Listele_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void button_Bolum_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Ders_Kayit.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Ders_Kayit.CurrentRow.Cells["Ders_id"].Value.ToString();
                string sorgu = "DELETE From Ders_Bilgi WHERE Ders_id=" + satir + "";
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
        private void dataGridView_Ders_Kayit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Ders_Adi.Text = dataGridView_Ders_Kayit.CurrentRow.Cells["Ders_Adi"].Value.ToString();
            textBox_Ders_Aciklama.Text = dataGridView_Ders_Kayit.CurrentRow.Cells["Aciklama"].Value.ToString();
            A_Genel.anahtar = false;
        }

        private void textBox_Ders_Adi_Leave(object sender, EventArgs e)
        {
            if (textBox_Ders_Adi.Text.Length == 0)
            {
                errorProvider_Ders_Kayit.SetError(textBox_Ders_Adi, "Ders Adı Boş Geçilemez...");
                textBox_Ders_Adi.Focus();
            }
            else
            {
                errorProvider_Ders_Kayit.SetError(textBox_Ders_Adi, null);
            }
            textBox_Ders_Adi.BackColor = Color.SteelBlue;
            textBox_Ders_Adi.ForeColor = Color.White;
        }

        private void textBox_Ders_Adi_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Ders_Adi)
            {
                textBox_Ders_Adi.BackColor = Color.LightSteelBlue;
                textBox_Ders_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ders_Aciklama)
            {
                textBox_Ders_Aciklama.BackColor = Color.LightSteelBlue;
                textBox_Ders_Aciklama.ForeColor = Color.Crimson;
            }
        }

        private void textBox_Ders_Aciklama_Leave(object sender, EventArgs e)
        {
            textBox_Ders_Aciklama.BackColor = Color.SteelBlue;
            textBox_Ders_Aciklama.ForeColor = Color.White;
        }

        private void textBox_Ders_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

    }
}
