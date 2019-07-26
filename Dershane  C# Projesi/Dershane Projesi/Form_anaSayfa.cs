using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Dershane_Projesi
{
    public partial class Form_anaSayfa : Form
    {
        public Form_anaSayfa()
        {
            InitializeComponent();
        }
        //progressbar
        int i;

        //Başka Formlar Close icin tanımlandı...
        Form_bolumKayit frmBolumKayit = new Form_bolumKayit();
        Form_dersKayit frmDersKayit = new Form_dersKayit();
        Form_sinifKayit frmSinifKayit = new Form_sinifKayit();
        Form_notKayitEkle frmNotKayitEkle = new Form_notKayitEkle();
        Form_notKayitGoster frmNotKayitGoster = new Form_notKayitGoster();
        Form_Ogrenci_Taksit_Ode frmOgrenciTaksitOde = new Form_Ogrenci_Taksit_Ode();
        Form_Ogrenci_Taksit_Plan frmOgrenciTaksitPlan = new Form_Ogrenci_Taksit_Plan();


        //Form Tanımlar---------------------------------------------------------------------------

        Form_Ogrenci_Bilgi frmOgrenci = new Form_Ogrenci_Bilgi();
        Form_Personel frmPersonel = new Form_Personel();
        Form_Ogrenci_Listeler frmListeler = new Form_Ogrenci_Listeler();
        Form_ders_grup_sinif_bolumKayit frmdersgrupsinifbolum = new Form_ders_grup_sinif_bolumKayit();
        Form_notKayit frmNotKayit = new Form_notKayit();
        Form_hakkında frmHakkinda = new Form_hakkında();
        Form_puanHesaplama frmPuanHesapla = new Form_puanHesaplama();
        

        Form_Ogrenci_Kayit frmOgrenciKayit = new Form_Ogrenci_Kayit();
        Form_Ogrenci_Arama frmOgrenciArama = new Form_Ogrenci_Arama();
        Form_Ogrenci_Devamsizlik frmOgrenciDevamsizlik = new Form_Ogrenci_Devamsizlik();
        Form_Ogrenci_Sinav frmOgrenciSinav = new Form_Ogrenci_Sinav();
        Form_Kullanici_Duzen frmKullaniciDuzen = new Form_Kullanici_Duzen();
        Form_ogrenciEtut frmOgrenciEtut = new Form_ogrenciEtut();

        //FormLoad -----------------------------------------------------------------------------

        private void Form_anaSayfa_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            toolTip_Ana_Sayfa.SetToolTip(button_Ogrenci, "Öğrenci Kayıt, Listeleme, Arama İşlem");
            toolTip_Ana_Sayfa.SetToolTip(button_Personel, "Personel Kayıt, Listeleme İşlem");
            toolTip_Ana_Sayfa.SetToolTip(button_Listeler, "Tüm Listeler");
            toolTip_Ana_Sayfa.SetToolTip(button_Ders_Grup_Sinif_Bolum, "Dershane Ders,Grup,Sınıf,Bölüm Kayıt İşlem");
            toolTip_Ana_Sayfa.SetToolTip(button_Etut, "Dershane Fotoğraflar");
            toolTip_Ana_Sayfa.SetToolTip(button_Anasayfa_Yeni_Kayit, "Yeni Öğrenci Kayıt");
            toolTip_Ana_Sayfa.SetToolTip(button_Anasayfa_Ogrenci_Arama, "Öğrenci Arama");
            toolTip_Ana_Sayfa.SetToolTip(button_Anasayfa_Devamsizlik_Listesi, "Öğrenci Devamsızlık İşle");
            toolTip_Ana_Sayfa.SetToolTip(button_Kapat, "Uygulamadan Çıkış");
            toolTip_Ana_Sayfa.SetToolTip(button_Yenile, "Tüm Formları Kapatır, Yeni Bir Başlangıç İçin, Zorunlu Kalmadıkça Kullanmayınız!..");
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "http://www.facebook/sql21");
        }

        //Hesap_Makinesi için---------------------------------------------------------------------

        bool durum = false;

        //Form MenuStrip--------------------------------------------------------------------------

        private void yeniKayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOgrenciKayit.Created)
	        {
		        frmOgrenciKayit.Activate();
                frmOgrenciKayit.Show();
	        }
            else
            {
                frmOgrenciKayit = new Form_Ogrenci_Kayit();
                frmOgrenciKayit.MdiParent = this;
                frmOgrenciKayit.Show();
            }
        }

        private void öğrenciAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOgrenciArama.Created)
            {
                frmOgrenciArama.Activate();
                frmOgrenciArama.Show();
            }
            else
            {
                frmOgrenciArama = new Form_Ogrenci_Arama();
                frmOgrenciArama.MdiParent = this;
                frmOgrenciArama.Show();
            }
        }

        private void devamsızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOgrenciDevamsizlik.Created)
            {
                frmOgrenciDevamsizlik.Activate();
                frmOgrenciDevamsizlik.Show();
            }
            else
            {
                frmOgrenciDevamsizlik = new Form_Ogrenci_Devamsizlik();
                frmOgrenciDevamsizlik.MdiParent = this;
                frmOgrenciDevamsizlik.Show();
            }
        }

        private void sınavİşleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOgrenciSinav.Created)
            {
                frmOgrenciSinav.Activate();
                frmOgrenciSinav.Show();
            }
            else
            {
                frmOgrenciSinav = new Form_Ogrenci_Sinav();
                frmOgrenciSinav.MdiParent = this;
                frmOgrenciSinav.Show();
            }
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonel.Created)
            {
                frmPersonel.Activate();
                frmPersonel.Show();
            }
            else
            {
                frmPersonel = new Form_Personel();
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
        }

        private void kullanıcıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKullaniciDuzen.Created)
            {
                frmKullaniciDuzen.Activate();
                frmKullaniciDuzen.Show();
            }
            else
            {
                frmKullaniciDuzen = new Form_Kullanici_Duzen();
                frmKullaniciDuzen.MdiParent = this;
                frmKullaniciDuzen.Show();
            }
        }
        private void etütEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOgrenciEtut.Created)
            {
                frmOgrenciEtut.Activate();
                frmOgrenciEtut.Show();
            }
            else
            {
                frmOgrenciEtut = new Form_ogrenciEtut();
                frmOgrenciEtut.MdiParent = this;
                frmOgrenciEtut.Show();
            }
        }

        DialogResult kapat;
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kapat = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //MenuStrip Listeler---------------------------------------------------------------------
        private void devamsızlıkListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.tabControl_Listeler.SelectedIndex = 4;
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmOgrenciKayit.MdiParent = this;
                frmListeler.tabControl_Listeler.SelectedIndex = 4;
                frmListeler.Show();
            }
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.tabControl_Listeler.SelectedIndex = 0;
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmOgrenciKayit.MdiParent = this;
                frmListeler.tabControl_Listeler.SelectedIndex = 0;
                frmListeler.Show();
            }
        }

        private void sınavSonuçListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.tabControl_Listeler.SelectedIndex = 5;
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmOgrenciKayit.MdiParent = this;
                frmListeler.tabControl_Listeler.SelectedIndex = 5;
                frmListeler.Show();
            }
        }

        private void veliBilgileriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.tabControl_Listeler.SelectedIndex = 6;
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmOgrenciKayit.MdiParent = this;
                frmListeler.tabControl_Listeler.SelectedIndex = 6;
                frmListeler.Show();
            }
        }
        //Hesap_Makinesi-------------------------------------------------------------------------

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!durum)
            {
                process1.StartInfo.FileName = "c:\\Windows\\System32\\calc.exe";
                process1.Start();
                this.process1.EnableRaisingEvents = true;
                this.process1.SynchronizingObject = this;
                this.process1.Exited += new System.EventHandler(this.process1_Exited);
                durum = true;
            }

        }


        //Form Sol Panel--------------------------------------------------------------------------
        
        private void button_Ogrenci_Click(object sender, EventArgs e)
        {
            if (frmOgrenci.Created)
            {
                frmOgrenci.Activate();
                frmOgrenci.Show();
            }
            else
            {
                frmOgrenci = new Form_Ogrenci_Bilgi();
                frmOgrenci.MdiParent = this;
                frmOgrenci.Show();
            }
            progressbar();
        }

        private void button_Personel_Click(object sender, EventArgs e)
        {
            if (frmPersonel.Created)
            {
                frmPersonel.Activate();
                frmPersonel.Show();
            }
            else
            {
                frmPersonel = new Form_Personel();
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
            progressbar();
        }

        private void button_Listeler_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmListeler.MdiParent = this;
                frmListeler.Show();
            }
            progressbar();
        }
        private void button_Ders_Grup_Sinif_Bolum_Click(object sender, EventArgs e)
        {
            if (frmdersgrupsinifbolum.Created)
            {
                frmdersgrupsinifbolum.Activate();
                frmdersgrupsinifbolum.Show();
            }
            else
            {
                frmdersgrupsinifbolum = new Form_ders_grup_sinif_bolumKayit();
                frmdersgrupsinifbolum.MdiParent = this;
                frmdersgrupsinifbolum.Show();
            }
            progressbar();
        }
        private void button_Notlar_Click(object sender, EventArgs e)
        {
            if (frmNotKayit.Created)
            {
                frmNotKayit.Activate();
                frmNotKayit.Show();
            }
            else
            {
                frmNotKayit = new Form_notKayit();
                frmNotKayit.MdiParent = this;
                frmNotKayit.Show();
            }
            progressbar();
        }
        private void button_Etut_Click(object sender, EventArgs e)
        {
            if (frmOgrenciEtut.Created)
            {
                frmOgrenciEtut.Activate();
                frmOgrenciEtut.Show();
            }
            else
            {
                frmOgrenciEtut = new Form_ogrenciEtut();
                frmOgrenciEtut.MdiParent = this;
                frmOgrenciEtut.Show();
            }
            progressbar();
        }
        private void button_Yenile_Click(object sender, EventArgs e)
        {
            this.Refresh();
            progressbar();
        }


        //Form Alt Panel--------------------------------------------------------------------------

        private void button_Anasayfa_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            if (frmOgrenciKayit.Created)
            {
                frmOgrenciKayit.Activate();
                frmOgrenciKayit.Show();
            }
            else
            {
                frmOgrenciKayit = new Form_Ogrenci_Kayit();
                frmOgrenciKayit.MdiParent = this;
                frmOgrenciKayit.WindowState = FormWindowState.Maximized;                
                frmOgrenciKayit.Show();
            }
            progressbar();
        }

        private void button_Anasayfa_Ogrenci_Arama_Click(object sender, EventArgs e)
        {
            if (frmOgrenciArama.Created)
            {
                frmOgrenciArama.Activate();
                frmOgrenciArama.Show();
            }
            else
            {
                frmOgrenciArama = new Form_Ogrenci_Arama();
                frmOgrenciArama.MdiParent = this;
                frmOgrenciArama.WindowState = FormWindowState.Maximized;
                frmOgrenciArama.Show();
            }
            progressbar();
        }

        private void button_Anasayfa_Devamsizlik_Listesi_Click(object sender, EventArgs e)
        {
            if (frmOgrenciDevamsizlik.Created)
            {
                frmOgrenciDevamsizlik.Activate();
                frmOgrenciDevamsizlik.Show();
            }
            else
            {
                frmOgrenciDevamsizlik = new Form_Ogrenci_Devamsizlik();
                frmOgrenciDevamsizlik.MdiParent = this;
                frmOgrenciDevamsizlik.WindowState = FormWindowState.Maximized;
                frmOgrenciDevamsizlik.Show();
            }
            progressbar();
        }

        private void button_Hesap_Makinesi_Click(object sender, EventArgs e)
        {
            if (!durum)
            {
                process1.StartInfo.FileName = "c:\\Windows\\System32\\calc.exe";
                process1.Start();
                this.process1.EnableRaisingEvents = true;
                this.process1.SynchronizingObject = this;
                this.process1.Exited += new System.EventHandler(this.process1_Exited);
                durum = true;
            }
            progressbar();
        }

        private void button_Kapat_Click(object sender, EventArgs e)
        {
            kapat = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (kapat == DialogResult.Yes)
            {
                Application.Exit();
            }
            progressbar();
        }

        //Form------------------------------
        //DialogResult cevap;
        private void Form_anaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cevap = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?",
            //   "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //   MessageBoxDefaultButton.Button2);
            //if (cevap == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    Application.OpenForms["Form_kullaniciGiris"].Close();
            //}
        }


        private void process1_Exited(object sender, EventArgs e)
        {
            durum = false;
        }

        private void Form_anaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void puanHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPuanHesapla.Created)
            {
                frmPuanHesapla.Activate();
                frmPuanHesapla.Show();
            }
            else
            {
                frmPuanHesapla = new Form_puanHesaplama();
                frmPuanHesapla.MdiParent = this;
                frmPuanHesapla.Show();
            }
        }
        private void progressbar()
        {
            if (progressBar1.Value <= 0)
            {
                progressBar1.Value = progressBar1.Value + 100;
            }
            else
            {
                progressBar1.Value = 0;
                progressBar1.Value = progressBar1.Value + 100;
            }
            label_Yuzde.Text = "%" + (progressBar1.Value * 100 / progressBar1.Maximum).ToString();
        }

        private void lazioDershanesiAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void minimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void hesapMakinesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!durum)
            {
                process1.StartInfo.FileName = "c:\\Windows\\System32\\calc.exe";
                process1.Start();
                this.process1.EnableRaisingEvents = true;
                this.process1.SynchronizingObject = this;
                this.process1.Exited += new System.EventHandler(this.process1_Exited);
                durum = true;
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkinda.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Uygulama Tamamen Kapanmıştır...");
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHakkinda.ShowDialog();
        }

        private void button_Puan_Hesapla_Click(object sender, EventArgs e)
        {
            if (frmPuanHesapla.Created)
            {
                frmPuanHesapla.Activate();
                frmPuanHesapla.Show();
            }
            else
            {
                frmPuanHesapla = new Form_puanHesaplama();
                frmPuanHesapla.MdiParent = this;
                frmPuanHesapla.WindowState = FormWindowState.Maximized;
                frmPuanHesapla.Show();
            }
            progressbar();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sitemiz Yapım Aşamasındadır..! Yakında Sizlere Hizmet Verecektir...","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
