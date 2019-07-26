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
using System.IO;

namespace Dershane_Projesi
{
    public partial class Form_Kullanici_Duzen : Form
    {
        public Form_Kullanici_Duzen()
        {
            InitializeComponent();
        }

        OleDbCommand komut;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\VeriTabanı\\vtb.accdb");

        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Kullanici_Bilgi", baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Kullanici_Bilgi");
            dataGridView_Kullanici_Adi_Sifre.DataSource = ds.Tables["Kullanici_Bilgi"];
            dataGridView_Kullanici_Adi_Sifre.Columns["Kullanici_id"].Visible = false;
            dataGridView_Kullanici_Adi_Sifre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button_Yeni_Kullanici_Click(object sender, EventArgs e)
        {
            textBox_Kullanici_Adi.Text = null;
            textBox_Sifre.Text = null;
            button_Kullanici_Duzenle.Visible = false;
            button_Kullanici_Kaydet.Visible = true;
        }

        private void button_Kullanici_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                string guncel_satir = dataGridView_Kullanici_Adi_Sifre.CurrentRow.Cells["Kullanici_id"].Value.ToString();
                string sorgu = "UPDATE Kullanici_Bilgi SET Kullanici_Adi=@1,Sifre=@2 WHERE Kullanici_id=" + guncel_satir + "";

                komut = new OleDbCommand(sorgu, baglanti);

                komut.Parameters.Add("@1", textBox_Kullanici_Adi.Text);
                komut.Parameters.Add("@2", textBox_Sifre.Text);

                komut.ExecuteNonQuery();
                komut.Dispose();

                KayitlariGetir();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
            }

            MessageBox.Show("Kayıt Güncelleme İşlemi Tamamlandı...");
        }

        private void button_Kullanici_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO Kullanici_Bilgi(Kullanici_Adi,Sifre)values(@1,@2)";
                komut = new OleDbCommand(sorgu, baglanti);

                komut.Parameters.Add("@1", textBox_Kullanici_Adi.Text);
                komut.Parameters.Add("@2", textBox_Sifre.Text);

                komut.ExecuteNonQuery();

                KayitlariGetir();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
            }
        }

        private void Form_kullaniciDuzen_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    KayitlariGetir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu..." + ex.Message);
            }
        }

        private void button_Kullanici_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView_Kullanici_Adi_Sifre.CurrentRow == null)
            {
                MessageBox.Show("Lütfen Silinecek Bir Kayıt Seçin...");
            }
            else
            {
                string satir = dataGridView_Kullanici_Adi_Sifre.CurrentRow.Cells["Kullanici_id"].Value.ToString();
                string sorgu = "DELETE From Kullanici_Bilgi WHERE Kullanici_id=" + satir + "";
                DialogResult cvp = MessageBox.Show("Kayıt Silinecektir Devam Edilsin mi ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cvp == DialogResult.Yes)
                {
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silme İşlemi Tamamlanmıştır...");
                }
                KayitlariGetir();

            }
        }

        private void dataGridView_Kullanici_Adi_Sifre_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_Kullanici_Adi.Text = dataGridView_Kullanici_Adi_Sifre.CurrentRow.Cells["Kullanici_Adi"].Value.ToString();
            textBox_Sifre.Text = dataGridView_Kullanici_Adi_Sifre.CurrentRow.Cells["Sifre"].Value.ToString();
            button_Kullanici_Duzenle.Visible = true;
            button_Kullanici_Kaydet.Visible = false;
        }

        private void textBox_Kullanici_Adi_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Kullanici_Adi)
            {
                textBox_Kullanici_Adi.BackColor = Color.LightSteelBlue;
                textBox_Kullanici_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Sifre)
            {
                textBox_Sifre.BackColor = Color.LightSteelBlue;
                textBox_Sifre.ForeColor = Color.Crimson;
            }
        }

        private void textBox_Kullanici_Adi_Leave(object sender, EventArgs e)
        {
            textBox_Kullanici_Adi.BackColor = Color.SteelBlue;
            textBox_Kullanici_Adi.ForeColor = Color.White;
        }

        private void textBox_Sifre_Leave(object sender, EventArgs e)
        {
            textBox_Sifre.BackColor = Color.SteelBlue;
            textBox_Sifre.ForeColor = Color.White;
        }

        private void textBox_Kullanici_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
