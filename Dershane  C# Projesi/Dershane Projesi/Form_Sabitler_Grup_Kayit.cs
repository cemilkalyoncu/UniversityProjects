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
    public partial class Form_Sabitler_Grup_Kayit : Form
    {
        public Form_Sabitler_Grup_Kayit()
        {
            InitializeComponent();
        }

        OleDbCommand komut;

        private void Form_Sabitler_Grup_Kayit_Load(object sender, EventArgs e)
        {

            toolTip_Grup_Kayit.SetToolTip(button_Grup_Yeni_Kayit, "Yeni Kayıt Ekranı");
            toolTip_Grup_Kayit.SetToolTip(button_Kaydet, "Grup Kaydet");
            toolTip_Grup_Kayit.SetToolTip(button_Sil, "Kayıt Sil");
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

        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Grup_Bilgileri", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Grup_Bilgileri");
            dataGridView_Grup_Kayit.DataSource = ds.Tables["Grup_Bilgileri"];
            dataGridView_Grup_Kayit.Columns["Grup_id"].Visible = false;
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            if (A_Genel.anahtar)
            {
                try
                {
                    string sorgu = "INSERT INTO Grup_Bilgileri(Grup_Adi,Aciklama)values(@1,@2)";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Grup_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Grup_Aciklama.Text);

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
                    string sorgu = "UPDATE Grup_Bilgileri SET Grup_Adi=@1,Aciklama=@2 WHERE Grup_id=" + guncel_satir + "";

                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Grup_Adi.Text);
                    komut.Parameters.Add("@2", textBox_Grup_Aciklama.Text);

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

        private void button_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Grup_Kayit.CurrentRow == null)
            {
                MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
            }
            else
            {
                string satir = dataGridView_Grup_Kayit.CurrentRow.Cells["Grup_id"].Value.ToString();
                string sorgu = "DELETE From Grup_Bilgileri WHERE Grup_id=" + satir + "";
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

        private void button_Grup_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            A_Genel.anahtar = true;
            textBox_Grup_Adi.Text = null;
            textBox_Grup_Aciklama.Text = null;
        }

        private void button_Kayit_Listele_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
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
        }

    }
}
