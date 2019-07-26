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
    public partial class Form_Sabitler_Sinif_Kayit : Form
    {
        public Form_Sabitler_Sinif_Kayit()
        {
            InitializeComponent();
        }

        OleDbCommand komut;

        private void Form_Sabitler_Sinif_Kayit_Load(object sender, EventArgs e)
        {
            toolTip_Sinif_Kaydi.SetToolTip(button_Sinif_Sil, "Sınıf Sil");
            toolTip_Sinif_Kaydi.SetToolTip(button_Yeni_Sinif, "Yeni Sınıf Ekle");
            toolTip_Sinif_Kaydi.SetToolTip(button_Sinif_Kaydet, "Sınıf Kaydet & Düzenle");

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
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Sinif_Bilgileri", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Sinif_Bilgileri");
            dataGridView_Sinif_Kayit.DataSource = ds.Tables["Sinif_Bilgileri"];
            dataGridView_Sinif_Kayit.Columns["Sinif_id"].Visible = false;
        }

        private void button_Sinif_Kaydet_Click(object sender, EventArgs e)
        {
            if (A_Genel.anahtar)
            {
                try
                {
                    string sorgu = "INSERT INTO Sinif_Bilgileri(Sinif_Adi,Aciklama)values(@1,@2)";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Sinif_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Sinif_Aciklama.Text);

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
                    string guncel_satir = dataGridView_Sinif_Kayit.CurrentRow.Cells["Sinif_id"].Value.ToString();
                    string sorgu = "UPDATE Sinif_Bilgileri SET Sinif_Adi=@1,Aciklama=@2 WHERE Sinif_id=" + guncel_satir + "";

                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Sinif_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Sinif_Aciklama.Text);

                    komut.ExecuteNonQuery();

                    KayitlariGetir();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
                }

                MessageBox.Show("Kayıt Güncelleme İşlemi Tamamlandı...");
            }
        }

        private void button_Sinif_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Sinif_Kayit.CurrentRow == null)
            {
                MessageBox.Show("Lütfen Silinecek Bir Kayıt Seçin...");
            }
            else
            {
                string satir = dataGridView_Sinif_Kayit.CurrentRow.Cells["Sinif_id"].Value.ToString();
                string sorgu = "DELETE From Sinif_Bilgileri WHERE Sinif_id=" + satir + "";
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

        private void button_Yeni_Sinif_Click(object sender, EventArgs e)
        {
            A_Genel.anahtar = true;
            textBox_Sinif_Aciklama.Text = null;
            textBox_Sinif_Adi.Text = null;
        }

        private void dataGridView_Sinif_Kayit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Sinif_Adi.Text=dataGridView_Sinif_Kayit.CurrentRow.Cells["Sinif_Adi"].Value.ToString();
            textBox_Sinif_Aciklama.Text=dataGridView_Sinif_Kayit.CurrentRow.Cells["Aciklama"].Value.ToString();
            A_Genel.anahtar = false;
        }

        private void button_Kayit_Listele_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void textBox_Sinif_Adi_Leave(object sender, EventArgs e)
        {
            if (textBox_Sinif_Adi.Text.Length == 0) 
            {
               errorProvider_Sinif_Kayit.SetError(textBox_Sinif_Adi, "Sınıf Adı Boş Geçilemez...");
               textBox_Sinif_Adi.Focus(); 
            }
            else
            {
                errorProvider_Sinif_Kayit.SetError(textBox_Sinif_Adi, null);
            }
        }


    }
}
