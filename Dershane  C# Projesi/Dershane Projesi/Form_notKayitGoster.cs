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

namespace Dershane_Projesi
{
    public partial class Form_notKayitGoster : Form
    {
        public Form_notKayitGoster()
        {
            InitializeComponent();
        }

        OleDbCommand komut;
        bool a;
        

        private void button_Duzenle_Click(object sender, EventArgs e)
        {
            A_Genel.gec = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Not_id"].Value.ToString();
            A_Genel.anahtar = false;
            Form_notKayitEkle frmNotYeniKayit = new Form_notKayitEkle();
            if (frmNotYeniKayit.Created)
            {
                frmNotYeniKayit.Show();
            }
            else
            {
                frmNotYeniKayit = new Form_notKayitEkle();
                frmNotYeniKayit.MdiParent = this.MdiParent;
                frmNotYeniKayit.Show();
            }

            frmNotYeniKayit.textBox1.Text = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Tarih"].Value.ToString();
            frmNotYeniKayit.textBox2.Text = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Saat"].Value.ToString();
            frmNotYeniKayit.richTextBox_Not_Kayit_Hatirlatma.Text = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Hatirlatma_mesaji"].Value.ToString();

        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            string sil= dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Not_id"].Value.ToString();
            string sorgu = "DELETE From Not_Bilgi WHERE Not_id=" + sil + "";
            DialogResult cvp= MessageBox.Show("Kayıt Silinecektir Devam Edilsin mi ?", "Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        
         if (cvp == DialogResult.Yes)
         {
             komut = new OleDbCommand(sorgu, A_Genel.baglanti);
             komut.ExecuteNonQuery();
             MessageBox.Show("Kayıt Silme İşlemi Tamamlanmıştır...");
         }
            KayitlariGetir();

        }
        

        private void Form_notKayitGoster_Load(object sender, EventArgs e)
        {
            toolTip_Not_Kayit_Listesi.SetToolTip(button_Duzenle, "Kayıt Düzenle");
            toolTip_Not_Kayit_Listesi.SetToolTip(button_Sil, "Kayıt Sil");

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

            KayitlariGetir();
        }

        private void KayitlariGetir()
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT * FROM Not_Bilgi", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Not_Bilgi");
            dataGridView_Not_Kayit_Listele.DataSource = ds.Tables["Not_Bilgi"];
            dataGridView_Not_Kayit_Listele.Columns["Not_id"].Visible = false;
        }

        private void dataGridView_Not_Kayit_Listele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            A_Genel.gec = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Not_id"].Value.ToString();
            A_Genel.anahtar = false;

            Form_notKayitEkle frmNotYeniKayit = new Form_notKayitEkle();
            frmNotYeniKayit.Show();

            frmNotYeniKayit.textBox1.Text = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Tarih"].Value.ToString();
            frmNotYeniKayit.textBox2.Text = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Saat"].Value.ToString();
            frmNotYeniKayit.richTextBox_Not_Kayit_Hatirlatma.Text = dataGridView_Not_Kayit_Listele.CurrentRow.Cells["Hatirlatma_mesaji"].Value.ToString();
        
        }

    }
}

