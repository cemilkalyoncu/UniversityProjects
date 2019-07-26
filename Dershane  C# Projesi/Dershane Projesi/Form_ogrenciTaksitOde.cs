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
    public partial class Form_Ogrenci_Taksit_Ode : Form
    {
        public Form_Ogrenci_Taksit_Ode()
        {
            InitializeComponent();
        }
        double toplamtutar, cikilacaktutar,top;
        OleDbCommand komut,komut1;
        


        private void button_Ogrenci_Taksit_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Ogrenci_Taksit_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci_Taksit_Odenen_Tutar.Text = null;
            dateTimePicker_Ogrenci_Odeme_Tarihi.Value = DateTime.Now;
            comboBox_Ogrenci_Taksit_islem_Turu.Text = null;
        }



        void KayitlariGetir()
        {
            string sorgu = "SELECT * FROM Ogrenci_Taksitlendirme_Bilgi ";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Ogrenci_Taksitlendirme_Bilgi");
            dataGridView_Taksit_Ode.DataSource = ds.Tables[0];
            dataGridView_Taksit_Ode.Columns["Personel_id"].Visible = false;
            dataGridView_Taksit_Ode.Columns["Pesinat"].Visible = false;
            dataGridView_Taksit_Ode.Columns["Taksit_Baslangıc_Tarih"].Visible = false;
            dataGridView_Taksit_Ode.Columns["Taksitlendirilecek_Miktar"].Visible = false;
            dataGridView_Taksit_Ode.Columns["Taksit_Adet"].Visible = false;
            dataGridView_Taksit_Ode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button_Ogrenci_Taksit_Tamam_Click(object sender, EventArgs e)
        {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                try
                {
                    cikilacaktutar = Convert.ToDouble(textBox_Ogrenci_Taksit_Odenen_Tutar.Text);
                    toplamtutar = Convert.ToDouble(label_Geri_Kalan_Tutar.Text);
                    top = toplamtutar - cikilacaktutar;
                    string guncel_satir = dataGridView_Taksit_Ode.CurrentRow.Cells["Taksitlendirme_id"].Value.ToString();
                    string sorgu = "UPDATE Ogrenci_Taksitlendirme_Bilgi SET Odenen_Tutar=@1,Odeme_Tarihi=@2,islem_Turu=@3,Kalan_tutar=@4 where Taksitlendirme_id=@5";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.Add("@1", textBox_Ogrenci_Taksit_Odenen_Tutar.Text);
                    komut.Parameters.Add("@2", dateTimePicker_Ogrenci_Odeme_Tarihi.Text);
                    komut.Parameters.Add("@3", comboBox_Ogrenci_Taksit_islem_Turu.Text);
                    komut.Parameters.Add("@4", top);
                    komut.Parameters.Add("@5", guncel_satir);

                    komut.ExecuteNonQuery();
                    KayitlariGetir();
                    MessageBox.Show("Taksit Ödeme Tamamlandı...");

                    A_Genel.baglanti.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
                }   


        }

        private void textBox_Ogrenci_Taksit_Odenen_Tutar_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox_Ogrenci_Taksit_Odenen_Tutar.Text))
            //{
            //}
            //else
            //{
            //    float para = 0;
            //    para = Convert.ToSingle(textBox_Ogrenci_Taksit_Odenen_Tutar.Text);
            //    textBox_Ogrenci_Taksit_Odenen_Tutar.Text = para.ToString("C");
            //}
        }

        private void textBox_Ogrenci_Taksit_Odenen_Tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_Ogrenci_Taksit_Ode_Load(object sender, EventArgs e)
        {
            

            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                    
                }
                komut1 = new OleDbCommand("Select * from ogrenci_taksitlendirme_bilgi", A_Genel.baglanti);
                OleDbDataReader oku = komut1.ExecuteReader();
                while (oku.Read())
                {
                   
                    
                    label_Geri_Kalan_Tutar.Text = oku["Kalan_Tutar"].ToString();

                }

                KayitlariGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu..." + ex.Message);
            }

        }


        private void dataGridView_Taksit_Ode_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_Ogrenci_Taksit_Odenen_Tutar.Text = dataGridView_Taksit_Ode.CurrentRow.Cells["Odenen_Tutar"].Value.ToString();
            dateTimePicker_Ogrenci_Odeme_Tarihi.Text = dataGridView_Taksit_Ode.CurrentRow.Cells["Odeme_Tarihi"].Value.ToString();
            comboBox_Ogrenci_Taksit_islem_Turu.Text = dataGridView_Taksit_Ode.CurrentRow.Cells["islem_Turu"].Value.ToString();
            A_Genel.anahtar = false;
        }

        private void label_Geri_Kalan_Tutar_TextChanged(object sender, EventArgs e)
        {
            //float para = 0;
            //para = Convert.ToSingle(label_Geri_Kalan_Tutar.Text);
            //label_Geri_Kalan_Tutar.Text = para.ToString("C");
        }
    }
}

