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
    public partial class Form_fotoGaleri : Form
    {
        public Form_fotoGaleri()
        {
            InitializeComponent();
        }

        OleDbCommand komut;

        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Grup_Bilgi order by Grup_id desc", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Grup_Bilgi");
            dataGridView_Grup_Kayit.DataSource = ds.Tables["Grup_Bilgi"];
            dataGridView_Grup_Kayit.Columns["Grup_id"].Visible = false;
            dataGridView_Grup_Kayit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button_Grup_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            A_Genel.anahtar = true;
            textBox_Grup_Adi.Text = null;
            textBox_Grup_Aciklama.Text = null;
        }

        private void dataGridView_Grup_Kayit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Grup_Adi.Text = dataGridView_Grup_Kayit.CurrentRow.Cells["Grup_Adi"].Value.ToString();
            textBox_Grup_Aciklama.Text = dataGridView_Grup_Kayit.CurrentRow.Cells["Aciklama"].Value.ToString();
            A_Genel.anahtar = false;
        }

        private void textBox_Grup_Adi_Leave(object sender, EventArgs e)
        {
            if (textBox_Grup_Adi.Text.Length == 0)
            {
                errorProvider_Grup_Kayit.SetError(textBox_Grup_Adi, "Grup Adı Boş Geçilemez...");
                textBox_Grup_Adi.Focus();
            }
            else
            {
                errorProvider_Grup_Kayit.SetError(textBox_Grup_Adi, null);
            }
            textBox_Grup_Adi.BackColor = Color.SteelBlue;
            textBox_Grup_Adi.ForeColor = Color.White;
        }

        private void button_Grup_Kaydet_Click(object sender, EventArgs e)
        {
            if (A_Genel.anahtar)
            {
                try
                {
                    string sorgu = "INSERT INTO Grup_Bilgi(Grup_Adi,Aciklama) VALUES (@1,@2)";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.AddWithValue("@1", textBox_Grup_Adi.Text);
                    komut.Parameters.AddWithValue("@2", textBox_Grup_Aciklama.Text);

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
                    string guncel_satir = dataGridView_Grup_Kayit.CurrentRow.Cells["Grup_id"].Value.ToString();
                    string sorgu = "UPDATE Grup_Bilgi SET Grup_Adi=@1,Aciklama=@2 WHERE Grup_id=" + guncel_satir + "";

                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.AddWithValue("@1", textBox_Grup_Adi.Text);
                    komut.Parameters.AddWithValue("@2", textBox_Grup_Aciklama.Text);

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

        private void button_Grup_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Grup_Kayit.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Grup_Kayit.CurrentRow.Cells["Grup_id"].Value.ToString();
                string sorgu = "DELETE From Grup_Bilgi WHERE Grup_id=" + satir + "";
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

        private void button_Kayit_Listele_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void Form_grupKayit_Load(object sender, EventArgs e)
        {
            toolTip_Grup_Kayit.SetToolTip(button_Grup_Yeni_Kayit, "Yeni Kayıt Ekranı");
            toolTip_Grup_Kayit.SetToolTip(button_Grup_Kaydet, "Grup Kaydet");
            toolTip_Grup_Kayit.SetToolTip(button_Grup_Sil, "Kayıt Sil");
            toolTip_Grup_Kayit.SetToolTip(button_Kayit_Listele, "Tüm Kayıtlar");

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

        private void textBox_Grup_Adi_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Grup_Adi)
            {
                textBox_Grup_Adi.BackColor = Color.LightSteelBlue;
                textBox_Grup_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Grup_Aciklama)
            {
                textBox_Grup_Aciklama.BackColor = Color.LightSteelBlue;
                textBox_Grup_Aciklama.ForeColor = Color.Crimson;
            }
        }

        private void textBox_Grup_Aciklama_Leave(object sender, EventArgs e)
        {
            textBox_Grup_Aciklama.BackColor = Color.SteelBlue;
            textBox_Grup_Aciklama.ForeColor = Color.White;
        }

        private void textBox_Grup_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox_Grup_Aciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
