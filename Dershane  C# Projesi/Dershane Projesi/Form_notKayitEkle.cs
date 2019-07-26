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
using System.Media;

namespace Dershane_Projesi
{
    public partial class Form_notKayitEkle : Form
    {
        public Form_notKayitEkle()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        Form_notKayitGoster frmNotKayitGoster = new Form_notKayitGoster();

        private void button_Yeni_Not_Click(object sender, EventArgs e)
        {
            A_Genel.anahtar = true;
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = null;
            richTextBox_Not_Kayit_Hatirlatma.Text = null;
        }

        private void Form_notKayit_Load(object sender, EventArgs e)
        {
            toolTip_Not_Kayit.SetToolTip(button_Yeni_Not, "Yeni Not");
            toolTip_Not_Kayit.SetToolTip(button_Kaydet, "Not Kaydet");
            toolTip_Not_Kayit.SetToolTip(button_Sil, "Not Sil");

            this.Height = 500;

            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                    KayitlariGetir();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Hata Oluştu" + exc.Message);
            }
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToShortTimeString();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (A_Genel.anahtar)
                {
                    string sorgu = "INSERT INTO Not_Bilgi(Tarih,Saat,Hatirlatma_mesaji) values (@1,@2,@3)";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);
                }
                else
                {
                    string a = A_Genel.gec;
                    string sorgu = "UPDATE Not_Bilgi SET Tarih=@1,Saat=@2,Hatirlatma_mesaji=@3 WHERE Not_id=" + a + "";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);
                }
                komut.Parameters.Add("@1", textBox1.Text);
                komut.Parameters.Add("@2", textBox2.Text);
                komut.Parameters.Add("@3", richTextBox_Not_Kayit_Hatirlatma.Text);

                komut.ExecuteNonQuery();

                KayitlariGetir();

                this.Height = 500;
                dataGridView_Not_Kayit_Ekle.Visible = true;
                if (dataGridView_Not_Kayit_Ekle.Visible)
                {
                    button_Yeni_Not.Location = new System.Drawing.Point(180, 276);
                    button_Kaydet.Location = new System.Drawing.Point(248, 276);
                    button_Sil.Location = new System.Drawing.Point(316, 276);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("Hata Oluştu..." + exc.Message);
            }

            
            
        }
        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Not_Bilgi", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Not_Bilgi");
            dataGridView_Not_Kayit_Ekle.DataSource = ds.Tables["Not_Bilgi"];
            dataGridView_Not_Kayit_Ekle.Columns["Not_id"].Visible = false;
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            string sil = dataGridView_Not_Kayit_Ekle.CurrentRow.Cells["Not_id"].Value.ToString();

            string sorgu = "DELETE From Not_Bilgi WHERE Not_id=" + sil + "";

            komut = new OleDbCommand(sorgu, A_Genel.baglanti);

            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt Silme İşlemi Tamamlanmıştır...");
            KayitlariGetir();
        }

        private void comboBox_Not_Kayit_Saat_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                errorProvider_Not_Kayit.SetError(textBox2, "Saat Alanı Boş Geçilemez...");
                textBox2.Focus();
            }
            else
            {
                errorProvider_Not_Kayit.SetError(textBox2, null);
            }
            textBox2.BackColor = Color.SteelBlue;
            textBox2.ForeColor = Color.White;
        }


        private void comboBox_Not_Kayit_Saat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Karakteri Girmelisiniz!");
            } 
        }

        private void comboBox_Not_Kayit_Ekle_Dakika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Karakteri Girmelisiniz!");
            } 
        }

        private void richTextBox_Not_Kayit_Hatirlatma_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == richTextBox_Not_Kayit_Hatirlatma)
            {
                richTextBox_Not_Kayit_Hatirlatma.BackColor = Color.LightSteelBlue;
                richTextBox_Not_Kayit_Hatirlatma.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox1)
            {
                textBox1.BackColor = Color.LightSteelBlue;
                textBox1.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox2)
            {
                textBox2.BackColor = Color.LightSteelBlue;
                textBox2.ForeColor = Color.Crimson;
            }
        }

        private void richTextBox_Not_Kayit_Hatirlatma_Leave(object sender, EventArgs e)
        {
            richTextBox_Not_Kayit_Hatirlatma.BackColor = Color.SteelBlue;
            richTextBox_Not_Kayit_Hatirlatma.ForeColor = Color.White;
        }


        private void dateTimePicker_Not_Kayit_Ekle_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.SteelBlue;
            textBox1.ForeColor = Color.White;
        }

        private void richTextBox_Not_Kayit_Hatirlatma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar !=32)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToShortTimeString())
            {
                timer1.Stop();
                SoundPlayer ses = new SoundPlayer();
                string yol = Application.StartupPath + "//Alarm//ses.wav";
                ses.SoundLocation = yol;
                ses.Play();
                MessageBox.Show(richTextBox_Not_Kayit_Hatirlatma.Text);
                ses.Stop();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
