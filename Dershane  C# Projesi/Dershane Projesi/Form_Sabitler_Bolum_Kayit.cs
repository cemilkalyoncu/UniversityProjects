using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form_Sabitler_Bolum_Kayit : Form
    {
        public Form_Sabitler_Bolum_Kayit()
        {
            InitializeComponent();
        }

        OleDbCommand komut;

        private void Form_Sabitler_Bolum_Kayit_Load(object sender, EventArgs e)
        {
            toolTip_Bolum_Kayit.SetToolTip(button_Bolum_Kaydet, "Bölüm Kaydet");
            toolTip_Bolum_Kayit.SetToolTip(button_Bolum_Sil, "Bölüm Sil");
            toolTip_Bolum_Kayit.SetToolTip(button_Kayit_Listele, "Tum Bölüm Kayıtları");
            toolTip_Bolum_Kayit.SetToolTip(button_Yeni_Kayit, "Yeni Kayıt");
            
            
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

        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Bolum_Bilgileri", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Bolum_Bilgileri");
            dataGridView_Bolum_Kayit.DataSource = ds.Tables["Bolum_Bilgileri"];
            dataGridView_Bolum_Kayit.Columns["Bolum_id"].Visible = false;
        }

        private void button_Bolum_Kaydet_Click(object sender, EventArgs e)
        {
            if (A_Genel.anahtar)
            {
                try
                {
                    string sorgu = "INSERT INTO Bolum_Bilgileri(Bolum_Adi,Aciklama)values(@1,@2)";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Bolum_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Bolum_Aciklama.Text);

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
                    string guncel_satir = dataGridView_Bolum_Kayit.CurrentRow.Cells["Bolum_id"].Value.ToString();
                    string sorgu = "UPDATE Bolum_Bilgileri SET Bolum_Adi=@1,Aciklama=@2 WHERE Bolum_id=" + guncel_satir + "";

                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Bolum_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Bolum_Aciklama.Text);

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

        private void button_Bolum_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Bolum_Kayit.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Bolum_Kayit.CurrentRow.Cells["Bolum_id"].Value.ToString();
                string sorgu = "DELETE From Bolum_Bilgileri WHERE Bolum_id=" + satir + "";
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

        private void button_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            A_Genel.anahtar = true;
            textBox_Bolum_Aciklama.Text = null;
            textBox_Bolum_Adi.Text = null;
        }

        private void button_Kayit_Listele_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void dataGridView_Bolum_Kayit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Bolum_Adi.Text = dataGridView_Bolum_Kayit.CurrentRow.Cells["Bolum_Adi"].Value.ToString();
            textBox_Bolum_Aciklama.Text = dataGridView_Bolum_Kayit.CurrentRow.Cells["Aciklama"].Value.ToString();
            A_Genel.anahtar = false;
        }

        private void textBox_Bolum_Adi_Leave(object sender, EventArgs e)
        {
            if (textBox_Bolum_Adi.Text.Length == 0)
            {
                errorProvider_Bolum_Kayit.SetError(textBox_Bolum_Adi, "Bölüm Adı Boş Geçilemez...");
                textBox_Bolum_Adi.Focus();
            }
            else
            {
                errorProvider_Bolum_Kayit.SetError(textBox_Bolum_Adi, null);
            }
        }
    }
}
