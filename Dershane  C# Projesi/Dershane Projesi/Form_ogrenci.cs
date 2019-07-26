using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane_Projesi
{
    public partial class Form_Ogrenci_Bilgi : Form
    {
        public Form_Ogrenci_Bilgi()
        {
            InitializeComponent();
        }
        Form_Ogrenci_Kayit frmOgrenciKayit = new Form_Ogrenci_Kayit();
        Form_Ogrenci_Arama frmOgrenciArama = new Form_Ogrenci_Arama();
        Form_Ogrenci_Devamsizlik frmOgrenciDevamsizlikisle = new Form_Ogrenci_Devamsizlik();
        Form_Ogrenci_Sinav frmOgrenciSinav = new Form_Ogrenci_Sinav();
        Form_Ogrenci_Listeler frmListeler = new Form_Ogrenci_Listeler();

        private void button_Ogrenci_Yeni_Kayit_Ekle_Click(object sender, EventArgs e)
        {
            if (frmOgrenciKayit.Created)
            {
                frmOgrenciKayit.Activate();
                frmOgrenciKayit.Show();
            }
            else
            {
                frmOgrenciKayit = new Form_Ogrenci_Kayit();
                frmOgrenciKayit.MdiParent = this.MdiParent;
                frmOgrenciKayit.Show();
            }
            
        }

        private void button_Ogrenci_Arama_Click(object sender, EventArgs e)
        {
            if (frmOgrenciArama.Created)
            {
                frmOgrenciArama.Activate();
                frmOgrenciArama.Show();
            }
            else
            {
                frmOgrenciArama = new Form_Ogrenci_Arama();
                frmOgrenciArama.MdiParent = this.MdiParent;
                frmOgrenciArama.Show();
            }
        }

        private void button_Ogrenci_Devamsizlik_isle_Click(object sender, EventArgs e)
        {
            if (frmOgrenciDevamsizlikisle.Created)
            {
                frmOgrenciDevamsizlikisle.Activate();
                frmOgrenciDevamsizlikisle.Show();
            }
            else
            {
                frmOgrenciDevamsizlikisle = new Form_Ogrenci_Devamsizlik();
                frmOgrenciDevamsizlikisle.MdiParent = this.MdiParent;
                frmOgrenciDevamsizlikisle.Show();
            }
        }

        private void button_Ogrenci_Sinav_isle_Click(object sender, EventArgs e)
        {
            if (frmOgrenciSinav.Created)
            {
                frmOgrenciSinav.Activate();
                frmOgrenciSinav.Show();
            }
            else
            {
                frmOgrenciSinav = new Form_Ogrenci_Sinav();
                frmOgrenciSinav.MdiParent = this.MdiParent;
                frmOgrenciSinav.Show();
            }
        }

        private void button_Ogrenci_Listesi_Click(object sender, EventArgs e)
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
                frmListeler.MdiParent = this.MdiParent;
                frmListeler.tabControl_Listeler.SelectedIndex = 0;
                frmListeler.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.tabControl_Listeler.SelectedIndex = 1;
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmListeler.MdiParent = this.MdiParent;
                frmListeler.tabControl_Listeler.SelectedIndex = 1;
                frmListeler.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.tabControl_Listeler.SelectedIndex = 2;
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmListeler.MdiParent = this.MdiParent;
                frmListeler.tabControl_Listeler.SelectedIndex = 2;
                frmListeler.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (frmListeler.Created)
            {
                frmListeler.Activate();
                frmListeler.tabControl_Listeler.SelectedIndex = 3;
                frmListeler.Show();
            }
            else
            {
                frmListeler = new Form_Ogrenci_Listeler();
                frmListeler.MdiParent = this.MdiParent;
                frmListeler.tabControl_Listeler.SelectedIndex = 3;
                frmListeler.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                frmListeler.MdiParent = this.MdiParent;
                frmListeler.tabControl_Listeler.SelectedIndex = 4;
                frmListeler.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                frmListeler.MdiParent = this.MdiParent;
                frmListeler.tabControl_Listeler.SelectedIndex = 5;
                frmListeler.Show();
            }
        }

        private void Form_Ogrenci_Bilgi_Load(object sender, EventArgs e)
        {

        }
    }
}
