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
    public partial class Form_Ogrenci_Taksit_Plan : Form
    {
        public Form_Ogrenci_Taksit_Plan()
        {
            InitializeComponent();
        }
        //Form_Ogrenci_Kayit frmOgrenciKayit = new Form_Ogrenci_Kayit();
        OleDbCommand komut;
        
        private void button_Ogrenci_Taksit_Temizle_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci_Taksit_Plan_Pesinat.Text = null;
            textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Text = null;
            comboBox_Ogrenci_Taksit_Adeti.Text = null;
            dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi.Value = DateTime.Now;
        }

        private void textBox_Ogrenci_Taksit_Plan_Pesinat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void KayitlariGetir()
        {
            string sorgu = "SELECT * FROM Ogrenci_Taksitlendirme_Bilgi order by Taksitlendirme_id desc";
            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, A_Genel.baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "Ogrenci_Taksitlendirme_Bilgi");
            dataGridView_Taksit_Plan.DataSource = ds.Tables[0];
            dataGridView_Taksit_Plan.Columns["Personel_id"].Visible = false;
            dataGridView_Taksit_Plan.Columns["Odenen_Tutar"].Visible = false;
            dataGridView_Taksit_Plan.Columns["Odeme_Tarihi"].Visible = false;
            dataGridView_Taksit_Plan.Columns["Kalan_Tutar"].Visible = false;
            dataGridView_Taksit_Plan.Columns["islem_Turu"].Visible = false;
            dataGridView_Taksit_Plan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button_Ogrenci_Taksiklendir_Click(object sender, EventArgs e)
        {

              try
                {
                    string guncel_satir = dataGridView_Taksit_Plan.CurrentRow.Cells["Taksitlendirme_id"].Value.ToString();
                    string sorgu = "UPDATE Ogrenci_Taksitlendirme_Bilgi SET Pesinat=@1,Taksit_Baslangıc_Tarih=@2,Taksitlendirilecek_Miktar=@3,Taksit_Adet=@4,Kalan_Tutar=@5 where Taksitlendirme_id=@6";
                    komut = new OleDbCommand(sorgu, A_Genel.baglanti);

                    komut.Parameters.AddWithValue("@1", textBox_Ogrenci_Taksit_Plan_Pesinat.Text);
                    komut.Parameters.AddWithValue("@2", dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi.Text);
                    komut.Parameters.AddWithValue("@3", textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Text);
                    komut.Parameters.AddWithValue("@4", comboBox_Ogrenci_Taksit_Adeti.Text);
                    komut.Parameters.AddWithValue("@5", textBox_Ogrenci_Taksit_Plan_Pesinat.Text);
                    komut.Parameters.AddWithValue("@6", guncel_satir);

                    komut.ExecuteNonQuery();
                    KayitlariGetir();
                    MessageBox.Show("Taksit Plan Tamamlandı...");
                    A_Genel.baglanti.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Beklenmeyen Bir Hata Oluştu" + exc.Message);
                }
    

            }

        private void Form_Ogrenci_Taksit_Plan_Load(object sender, EventArgs e)
        {
             try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                KayitlariGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu..." + ex.Message);
            }
        }

        private void textBox_Ogrenci_Taksit_Plan_Pesinat_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox_Ogrenci_Taksit_Plan_Pesinat.Text))
            //{
            //}
            //else
            //{
            //    float para = 0;
            //    para = Convert.ToSingle(textBox_Ogrenci_Taksit_Plan_Pesinat.Text);
            //    textBox_Ogrenci_Taksit_Plan_Pesinat.Text = para.ToString("C");
            //}
        }

        private void textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Text))
            //{
            //}
            //else
            //{
            //    float para = 0;
            //    para = Convert.ToSingle(textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Text);
            //    textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Text = para.ToString("C");
            //}
        }

        private void button_Ogrenci_Taksit_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
