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
    public partial class Form_Personel : Form
    {
        public Form_Personel()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\VeriTabanı\\vtb.accdb");
        OleDbCommand komut;

        void KayitlariGetir()
        { 
            string sorgu = "SELECT * FROM Personel_Bilgi";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Personel Liste");
            dataGridView_Personel_Bilgi_Liste.DataSource = ds.Tables[0];
            dataGridView_Personel_Bilgi_Liste.Columns["Taksit_id"].Visible = false;
            dataGridView_Personel_Bilgi_Liste.Columns["Personel_id"].Visible = false;
            dataGridView_Personel_Bilgi_Liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
        }

        private void Form_Personel_Load(object sender, EventArgs e)
        {
            KayitlariGetir();

        }

        private void button_Personel_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "INSERT INTO Personel_Bilgi(Adi,Soyadi,Tel,Adres,Personel_Yetki) values (@1,@2,@3,@4,@5)";

                komut = new OleDbCommand(sorgu, baglanti);


                komut.Parameters.AddWithValue("@1", textBox_Personel_Adi.Text);
                komut.Parameters.AddWithValue("@2", textBox_Personel_Soyadi.Text);
                komut.Parameters.AddWithValue("@3", textBox_Personel_Tel.Text);
                komut.Parameters.AddWithValue("@4", textBox_Personel_Adres.Text);
                komut.Parameters.AddWithValue("@5", comboBox_Personel_Yetki.Text);

                komut.ExecuteNonQuery();

                KayitlariGetir();

                baglanti.Close();

            }
            catch (Exception Perso)
            {
                MessageBox.Show("Listelemede Hata: " + Perso.Message);

            }
        }

        private void button_Personel_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                if (dataGridView_Personel_Bilgi_Liste.CurrentRow == null)
                {
                    MessageBox.Show("Silinecek Kayıt Bulunmamaktadır...");
                }
                else
                {
                    string satir = dataGridView_Personel_Bilgi_Liste.CurrentRow.Cells["Personel_id"].Value.ToString();
                    string sorgu = "DELETE From Personel_Bilgi WHERE Personel_id=" + satir + "";
                    DialogResult cvp = MessageBox.Show("Kayıt Silinecektir Devam Edilsin mi ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cvp == DialogResult.Yes)
                    {
                        komut = new OleDbCommand(sorgu, baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silme İşlemi Tamamlanmıştır...");
                    }
                    baglanti.Close();

                    KayitlariGetir();
                }
            }
            catch (Exception silme)
            {

                MessageBox.Show("Silme İşlemi Hata: " + silme.Message);
            }
            
        }

        private void button_Yeni_Personel_Ekle_Click(object sender, EventArgs e)
        {
            textBox_Personel_Adi.Text = null;
            textBox_Personel_Adres.Text = null;
            textBox_Personel_Soyadi.Text = null;
            textBox_Personel_Tel.Text = null;
            comboBox_Personel_Yetki.Text = null;
        }

        private void button_Personel_Duzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open(); 
                }
                string guncel_satir = dataGridView_Personel_Bilgi_Liste.CurrentRow.Cells["Personel_id"].Value.ToString();
                string sorgu = " UPDATE Personel_Bilgi SET Adi=@1,Soyadi=@2,Tel=@3,Adres=@4,Personel_Yetki=@5 WHERE Personel_id=" + guncel_satir + "";

                komut = new OleDbCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@1", textBox_Personel_Adi.Text);
                komut.Parameters.AddWithValue("@2", textBox_Personel_Soyadi.Text);
                komut.Parameters.AddWithValue("@3", textBox_Personel_Tel.Text);
                komut.Parameters.AddWithValue("@4", textBox_Personel_Adres.Text);
                komut.Parameters.AddWithValue("@5", comboBox_Personel_Yetki.Text);

                komut.ExecuteNonQuery();
                
                KayitlariGetir();
                
                baglanti.Close();
                
            }
            catch (Exception guncelleme)
            {
                
               MessageBox.Show("Güncellemede Hata: " + guncelleme.Message);
            }

        }

        private void textBox_Personel_Adi_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Personel_Adi)
            {
                textBox_Personel_Adi.BackColor = Color.LightSteelBlue;
                textBox_Personel_Adi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Personel_Adres)
            {
                textBox_Personel_Adres.BackColor = Color.LightSteelBlue;
                textBox_Personel_Adres.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Personel_Soyadi)
            {
                textBox_Personel_Soyadi.BackColor = Color.LightSteelBlue;
                textBox_Personel_Soyadi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Personel_Tel)
            {
                textBox_Personel_Tel.BackColor = Color.LightSteelBlue;
                textBox_Personel_Tel.ForeColor = Color.Crimson;
            }
            else if (renkver == comboBox_Personel_Yetki)
            {
                comboBox_Personel_Yetki.BackColor = Color.LightSteelBlue;
                comboBox_Personel_Yetki.ForeColor = Color.Crimson;
            }
        }

        private void textBox_Personel_Adi_Leave(object sender, EventArgs e)
        {
            textBox_Personel_Adi.BackColor = Color.SteelBlue;
            textBox_Personel_Adi.ForeColor = Color.White;
        }

        private void textBox_Personel_Soyadi_Leave(object sender, EventArgs e)
        {
            textBox_Personel_Soyadi.BackColor = Color.SteelBlue;
            textBox_Personel_Soyadi.ForeColor = Color.White;
        }

        private void textBox_Personel_Yetki_Leave(object sender, EventArgs e)
        {
            comboBox_Personel_Yetki.BackColor = Color.SteelBlue;
            comboBox_Personel_Yetki.ForeColor = Color.White;
        }

        private void textBox_Personel_Tel_Leave(object sender, EventArgs e)
        {
            textBox_Personel_Tel.BackColor = Color.SteelBlue;
            textBox_Personel_Tel.ForeColor = Color.White;
        }

        private void textBox_Personel_Adres_Leave(object sender, EventArgs e)
        {
            textBox_Personel_Adres.BackColor = Color.SteelBlue;
            textBox_Personel_Adres.ForeColor = Color.White;
        }

        private void textBox_Personel_Adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_Personel_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Personel_Adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_Personel_Bilgi_Liste_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Personel_Adi.Text = dataGridView_Personel_Bilgi_Liste.CurrentRow.Cells["Adi"].Value.ToString();
            textBox_Personel_Soyadi.Text = dataGridView_Personel_Bilgi_Liste.CurrentRow.Cells["Soyadi"].Value.ToString();
            comboBox_Personel_Yetki.Text = dataGridView_Personel_Bilgi_Liste.CurrentRow.Cells["Personel_Yetki"].Value.ToString();
            textBox_Personel_Tel.Text = dataGridView_Personel_Bilgi_Liste.CurrentRow.Cells["Tel"].Value.ToString();
            textBox_Personel_Adres.Text = dataGridView_Personel_Bilgi_Liste.CurrentRow.Cells["Adres"].Value.ToString();
        
        
        }
    }
}
