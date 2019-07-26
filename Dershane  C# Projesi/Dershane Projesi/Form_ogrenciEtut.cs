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
    public partial class Form_ogrenciEtut : Form
    {
        public Form_ogrenciEtut()
        {
            InitializeComponent();
        }
        string ogrid;
        ListBox liste = new ListBox();
        private void Form_ogrenciEtüt_Load(object sender, EventArgs e)
        {
            textBox_Ders_Tarihi.Text = dateTimePicker1.Text;
            ogrenci_oku();
            ogretmen_oku();
        }
        private void ogrenci_oku()
        {

            OleDbCommand veri = new OleDbCommand("SELECT  Ogrenci_Genel_Bilgi.Ogrenci_id,Ogrenci_Genel_Bilgi.Ogrenci_No, Ogrenci_Genel_Bilgi.Adi, Ogrenci_Genel_Bilgi.Soyadi, Sinif_Bilgi.Sinif_Adi FROM Sinif_Bilgi INNER JOIN Ogrenci_Genel_Bilgi ON Sinif_Bilgi.Sinif_id = Ogrenci_Genel_Bilgi.Sinif_id ", A_Genel.baglanti);
            OleDbDataReader oku = null;
            if (A_Genel.baglanti.State == ConnectionState.Closed)
            {
                A_Genel.baglanti.Open();
            }
            oku = veri.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem(oku["Ogrenci_id"].ToString());
                kayit.SubItems.Add(oku["Ogrenci_No"].ToString());
                kayit.SubItems.Add(oku["Adi"].ToString());
                kayit.SubItems.Add(oku["Soyadi"].ToString());
                kayit.SubItems.Add(oku["Sinif_Adi"].ToString());
                listView1.Items.Add(kayit);
            }
            oku.Close();
            A_Genel.baglanti.Close();
        }



        private void ogretmen_oku()
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("select * from Danisman_Bilgi",A_Genel.baglanti);
                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                listView3.Items.Clear();
                while (oku.Read())
                {
                    ListViewItem kayit = new ListViewItem(oku["Danisman_id"].ToString());
                    kayit.SubItems.Add(oku["Adi_Soyadi"].ToString());
                    kayit.SubItems.Add(oku["Girdigi_Ders"].ToString());
                    listView3.Items.Add(kayit);
                }
                oku.Close();
                A_Genel.baglanti.Close();
            }
            catch
            {

            }
        }
        private void bossaat_oku()
        {
            try
            {
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                OleDbCommand veri = new OleDbCommand("SELECT saat FROM bos_saatler where Danisman_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "'", A_Genel.baglanti);
                OleDbDataReader oku = null;
                oku = veri.ExecuteReader();
                liste.Items.Clear();
                while (oku.Read())
                {
                    liste.Items.Add(oku.GetString(0).ToString());
                }
                oku.Close();
                A_Genel.baglanti.Close();
            }
            catch
            {

            }
        }

        public void listele()
        {
            try
            {
                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent;
                button6.BackColor = Color.Transparent;
                button7.BackColor = Color.Transparent;
                button8.BackColor = Color.Transparent;
                button9.BackColor = Color.Transparent;
                button10.BackColor = Color.Transparent;
                button11.BackColor = Color.Transparent;
                button12.BackColor = Color.Transparent;

                liste.Items.Clear();
                bossaat_oku();
                int sayac = liste.Items.Count;
                string deger = null;
                for (int i = 0; i < sayac; i++)
                {

                    if (liste.Items[i].ToString() == button1.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button1.BackColor = Color.DimGray;

                    }

                    else if (liste.Items[i].ToString() == button2.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button2.BackColor = Color.DimGray;

                    }

                    else if (liste.Items[i].ToString() == button3.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button3.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button4.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button4.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button5.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button5.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button6.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button6.BackColor = Color.DimGray;
                    }
                    else if (liste.Items[i].ToString() == button7.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button7.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button8.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button8.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button9.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button9.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button10.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button10.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button11.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button11.BackColor = Color.DimGray;

                    }
                    else if (liste.Items[i].ToString() == button12.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button12.BackColor = Color.DimGray;

                    }
                }
                textBox_Ogretmen.Text = listView3.SelectedItems[0].SubItems[1].Text;
                bossaat_oku();
            }
            catch
            {


            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = button12.Text;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox_Ders_Tarihi.Text == "") || (textBox_Ders_Saati.Text == "") || (textBox_Ogrenci.Text == "") || (textBox_Ogretmen.Text == ""))
                {
                    MessageBox.Show("Lütfen Boş Metin Kutusu Bırakmayınız...");
                }
                else
                {
                    if (A_Genel.baglanti.State == ConnectionState.Closed) A_Genel.baglanti.Open();
                    string sorgu = "SELECT * FROM bos_saatler where Danisman_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + textBox_Ders_Saati.Text + "'";
                    OleDbCommand komut = new OleDbCommand(sorgu, A_Genel.baglanti);
                    OleDbDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        MessageBox.Show("Lütfen Farklı Bir Ders Saati Seçiniz...", "Açıklama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        A_Genel.baglanti.Close();
                    }

                    else
                    {
                        if (A_Genel.baglanti.State == ConnectionState.Closed) A_Genel.baglanti.Open();
                        OleDbCommand kaydet = new OleDbCommand("insert into bos_saatler (Danisman_id,saat,Ogrenci_id,tarih) values('" + listView3.SelectedItems[0].SubItems[0].Text + "','" + textBox_Ders_Saati.Text + "','" + listView1.SelectedItems[0].SubItems[0].Text + "','" + textBox_Ders_Tarihi.Text + "')", A_Genel.baglanti);
                        kaydet.ExecuteNonQuery();
                        A_Genel.baglanti.Close();
                        bossaat_oku();
                        listele();
                        MessageBox.Show("Yeni Etüt Eklendi...", "Açıklama", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    bossaat_oku();
                }
            }
            catch { }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand sil = new OleDbCommand("delete from bos_saatler where Danisman_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + textBox_Ders_Saati.Text + "'", A_Genel.baglanti);
                A_Genel.baglanti.Open();
                sil.ExecuteNonQuery();
                A_Genel.baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı...", "Açıklama", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();

            }
            catch
            {
                MessageBox.Show("Silme İşlemi Başarısız.Tekrar Deneyiniz...", "Açıklama", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Veritabanında tarihe göre günlük arama kodları

            if (A_Genel.baglanti.State == ConnectionState.Closed) A_Genel.baglanti.Open();
            string sorgu = "select a.Ogrenci_No,  a.Adi,  a.Soyadi,  b.Sinif_Adi from Ogrenci_Genel_Bilgi a, Sinif_Bilgi b where a.Sinif_id=b.Sinif_id and Ogrenci_No like'" + textBox_Ogrenci_Numara_Ara.Text + "%'";
            OleDbCommand komut = new OleDbCommand(sorgu, A_Genel.baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem(oku["Ogrenci_id"].ToString());
                kayit.SubItems.Add(oku["Ogrenci_No"].ToString());
                kayit.SubItems.Add(oku["Adi"].ToString());
                kayit.SubItems.Add(oku["Soyadi"].ToString());
                kayit.SubItems.Add(oku["Sinif_Adi"].ToString());
                listView1.Items.Add(kayit);


            }
            A_Genel.baglanti.Close();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox_Ogrenci_Numara_Ara.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox_Ogretmen_Adi_Ara.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Veritabanında tarihe göre günlük arama kodları

            if (A_Genel.baglanti.State == ConnectionState.Closed) 
            {
                A_Genel.baglanti.Open();
            }

            string sorgu = "select * from Danisman_Bilgi where Adi_Soyadi like'" + textBox_Ogretmen_Adi_Ara.Text + "%'";
            OleDbCommand komut = new OleDbCommand(sorgu, A_Genel.baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            listView3.Items.Clear();
            while (oku.Read())
            {
                ListViewItem kayit = new ListViewItem(oku["Danisman_id"].ToString());
                kayit.SubItems.Add(oku["Adi_Soyadi"].ToString());
                kayit.SubItems.Add(oku["Girdigi_Dersler"].ToString());
                listView3.Items.Add(kayit);


            }
            A_Genel.baglanti.Close();
        }
        
        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT Ogrenci_id FROM bos_saatler where Danisman_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button12.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT Adi,Soyadi FROM Ogrenci_Genel_Bilgi where Ogrenci_id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox_Ders_Tarihi.Text = dateTimePicker1.Text;
            listele();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatlbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button4.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }


        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button2.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button3.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button5.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button6.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button7.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);

                }
                listele();
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }

        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button8.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {

            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button9.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button10.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }

        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button11.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            }
        }

        private void Form_ogrenciEtüt_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "---";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_Ogrenci.Text = listView1.SelectedItems[0].SubItems[2].Text + " " + listView1.SelectedItems[0].SubItems[3].Text;
            }
            catch
            {

            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                OleDbCommand veri = new OleDbCommand("SELECT ogr_id FROM bos_saatler where ogrtmn_id=" + listView3.SelectedItems[0].SubItems[0].Text + " and tarih='" + dateTimePicker1.Text + "' and saat='" + button1.Text + "'", A_Genel.baglanti);

                OleDbDataReader oku = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku = veri.ExecuteReader();
                // liste.Items.Clear();
                while (oku.Read())
                {
                    ogrid = oku.GetString(0);
                }
                oku.Close();
                A_Genel.baglanti.Close();

                OleDbCommand veri2 = new OleDbCommand("SELECT ogr_adi,ogr_sadi FROM ogrenci where id=" + ogrid + "", A_Genel.baglanti);

                OleDbDataReader oku2 = null;
                if (A_Genel.baglanti.State == ConnectionState.Closed)
                {
                    A_Genel.baglanti.Open();
                }
                oku2 = veri2.ExecuteReader();
                // liste.Items.Clear();
                while (oku2.Read())
                {

                    label2.Text = oku2.GetString(0) + " " + oku2.GetString(1);
                }
                oku2.Close();
                A_Genel.baglanti.Close();


            }
            catch
            {


            } 
        }

        private void button_Yeni_Etüt_Click(object sender, EventArgs e)
        {
            textBox_Ders_Saati.Text = null;
            textBox_Ders_Tarihi.Text = null;
            textBox_Ogrenci.Text = null;
            textBox_Ogretmen.Text = null;
        }

        private void textBox_Ders_Tarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_Ders_Tarihi_Enter(object sender, EventArgs e)
        {
            Control renkver = ActiveControl;

            if (renkver == textBox_Ders_Tarihi)
            {
                textBox_Ders_Tarihi.BackColor = Color.LightSteelBlue;
                textBox_Ders_Tarihi.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ders_Saati)
            {
                textBox_Ders_Saati.BackColor = Color.LightSteelBlue;
                textBox_Ders_Saati.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogrenci)
            {
                textBox_Ogrenci.BackColor = Color.LightSteelBlue;
                textBox_Ogrenci.ForeColor = Color.Crimson;
            }
            else if (renkver == textBox_Ogretmen)
            {
                textBox_Ogretmen.BackColor = Color.LightSteelBlue;
                textBox_Ogretmen.ForeColor = Color.Crimson;
            }
        }

        private void textBox_Ders_Tarihi_Leave(object sender, EventArgs e)
        {
            textBox_Ders_Tarihi.BackColor = Color.SteelBlue;
            textBox_Ders_Tarihi.ForeColor = Color.White;
        }

        private void textBox_Ders_Saati_Leave(object sender, EventArgs e)
        {
            textBox_Ders_Saati.BackColor = Color.SteelBlue;
            textBox_Ders_Saati.ForeColor = Color.White;
        }

        private void textBox_Ogrenci_Leave(object sender, EventArgs e)
        {
            textBox_Ogrenci.BackColor = Color.SteelBlue;
            textBox_Ogrenci.ForeColor = Color.White;
        }

        private void textBox_Ogretmen_Leave(object sender, EventArgs e)
        {
            textBox_Ogretmen.BackColor = Color.SteelBlue;
            textBox_Ogretmen.ForeColor = Color.White;
        }

        private void button_Etüt_Listele_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter yukle = new OleDbDataAdapter("SELECT bos_saatler.Danisman_id, bos_saatler.Ogrenci_id, bos_saatler.tarih, bos_saatler.saat FROM bos_saatler order by [tarih] desc", A_Genel.baglanti);
            DataSet ds = new DataSet();
            yukle.Fill(ds, "Etüt Liste");
            dataGridView_Etut_Liste.DataSource = ds.Tables["Etüt Liste"];
            dataGridView_Etut_Liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            panel1.Visible = false;
            panel2.Visible = false;
            listView1.Visible = false;
            listView3.Visible = false;
            textBox_Ogrenci_Numara_Ara.Visible = false;
            textBox_Ogretmen_Adi_Ara.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            dataGridView_Etut_Liste.Visible = true;
            button_Geri_Don.Visible = true;

        }

        private void button_Geri_Don_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            listView1.Visible = true;
            listView3.Visible = true;
            textBox_Ogrenci_Numara_Ara.Visible = true;
            textBox_Ogretmen_Adi_Ara.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            dataGridView_Etut_Liste.Visible = false;
            button_Geri_Don.Visible = false;
        }

    }
}
