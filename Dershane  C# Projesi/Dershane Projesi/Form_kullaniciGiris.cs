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
    public partial class Form_Kullanici_Giris : Form
    {
        public Form_Kullanici_Giris()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\VeriTabanı\\vtb.accdb");

        

        Form_anaSayfa frmanaSayfa = new Form_anaSayfa();

        //DialogResult kapat;
        private void button_Vazgec_Click(object sender, EventArgs e)
        {
            //kapat = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //if (kapat == DialogResult.Yes)
            //{
                
            //}
            Application.Exit();
        }
        //DialogResult cevap1;
        private void Form_Kullanici_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            //kapat = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //if (kapat == DialogResult.Yes)
            //{
            //   Application.Exit();         
            //}
            //cevap1 = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?",
            //   "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //   MessageBoxDefaultButton.Button2);
            //if (cevap1 == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            
        }

        private void textbox_Kullanici_Adi_Leave(object sender, EventArgs e)
        {
            if (textBox_Kullanici_Adi.Text.Length == 0)
            {
                errorProvider_Kullanici_Giris.SetError(textBox_Kullanici_Adi, "Boş Geçemezsiniz...");
                textBox_Kullanici_Adi.Focus();
            }
            else
            {
                errorProvider_Kullanici_Giris.SetError(textBox_Kullanici_Adi, null);
            }
            textBox_Kullanici_Adi.BackColor = Color.SteelBlue;
            textBox_Kullanici_Adi.ForeColor = Color.White;
        }

        private void textbox_Kullanici_Sifre_Leave(object sender, EventArgs e)
        {
            if (textBox_Kullanici_Sifre.Text.Length == 0)
            {
                errorProvider_Kullanici_Giris.SetError(textBox_Kullanici_Sifre, "Boş Geçemezsiniz...");
                textBox_Kullanici_Sifre.Focus();
            }
            else
            {
                errorProvider_Kullanici_Giris.SetError(textBox_Kullanici_Sifre, null);
            }
            textBox_Kullanici_Sifre.BackColor = Color.SteelBlue;
            textBox_Kullanici_Sifre.ForeColor = Color.White;
        }

        private void Form_kullaniciGiris_Load(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < 10; i++)
            //{
            //    this.Opacity += 0.1;
            //}

            this.AcceptButton = button_Giris;
            this.CancelButton = button_Vazgec;
            
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            //if (textBox_Kullanici_Adi.Text == "ck" && textBox_Kullanici_Sifre.Text == "1461")
            //{
            //    frmanaSayfa.Show();
            //    this.Visible = false;
            //}
            string sorgu = "SELECT * FROM Kullanici_Bilgi";

            OleDbCommand veri = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader oku;


            baglanti.Open();


            oku = veri.ExecuteReader();

            while (oku.Read())
            {
                if (oku["Kullanici_Adi"].ToString() == textBox_Kullanici_Adi.Text && oku["Sifre"].ToString() == textBox_Kullanici_Sifre.Text)
                {
                    this.Visible = false;
                    frmanaSayfa.Show();
                }
            }
            baglanti.Close();

        }

        private void textBox_Kullanici_Adi_Enter(object sender, EventArgs e)
        {
            textBox_Kullanici_Adi.BackColor = Color.LightSteelBlue;
            textBox_Kullanici_Adi.ForeColor = Color.Crimson;
        }

        private void textBox_Kullanici_Sifre_Enter(object sender, EventArgs e)
        {
            textBox_Kullanici_Sifre.BackColor = Color.LightSteelBlue;
            textBox_Kullanici_Sifre.ForeColor = Color.Crimson;
        }

        private void textBox_Kullanici_Adi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {

                if (e.KeyCode == Keys.F4)
                {
                    e.Handled = true;
                    MessageBox.Show("Kullanılan tuş kombinasyonu geçersizdir!..");
                }
            }
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
