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
    public partial class Form_ders_grup_sinif_bolumKayit : Form
    {
        public Form_ders_grup_sinif_bolumKayit()
        {
            InitializeComponent();
        }
        Form_fotoGaleri frm_grupKayit = new Form_fotoGaleri();

        Form_bolumKayit frm_bolumKayit = new Form_bolumKayit();

        Form_sinifKayit frm_sinifKayit = new Form_sinifKayit();

        Form_dersKayit frm_dersKayit = new Form_dersKayit();

        Form_danismanKayit frm_danismanKayit = new Form_danismanKayit();

        private void Form_ders_grup_sinif_bolumKayit_Load(object sender, EventArgs e)
        {
            toolTip_Dershane_iSlemler.SetToolTip(button_Ogrenci_Bolum_Kayit, "Bölüm Kayıt");
            toolTip_Dershane_iSlemler.SetToolTip(button_Ogrenci_Ders_Kayit, "Ders Kayıt");
            toolTip_Dershane_iSlemler.SetToolTip(button_Ogrenci_Sinif_Kayit, "Sınıf Kayıt");
            toolTip_Dershane_iSlemler.SetToolTip(button_Ogrenci_Grup_Kayit, "Grup Kayıt");
        }

        private void button_Ogrenci_Grup_Kayit_Click(object sender, EventArgs e)
        {
            if (frm_grupKayit.Created)
            {
                frm_grupKayit.Activate();
                frm_grupKayit.Show();
            }
            else
            {
                frm_grupKayit = new Form_fotoGaleri();
                frm_grupKayit.MdiParent = this.MdiParent;
                frm_grupKayit.Show();
            }
        }

        private void button_Ogrenci_Sinif_Kayit_Click(object sender, EventArgs e)
        {
            if (frm_sinifKayit.Created)
            {
                frm_sinifKayit.Activate();
                frm_sinifKayit.Show();
            }
            else
            {
                frm_sinifKayit = new Form_sinifKayit();
                frm_sinifKayit.MdiParent = this.MdiParent;
                frm_sinifKayit.Show();
            }
        }

        private void button_Ogrenci_Bolum_Kayit_Click(object sender, EventArgs e)
        {
            if (frm_bolumKayit.Created)
            {
                frm_bolumKayit.Activate();
                frm_bolumKayit.Show();
            }
            else
            {
                frm_bolumKayit = new Form_bolumKayit();
                frm_bolumKayit.MdiParent = this.MdiParent;
                frm_bolumKayit.Show();
            }
        }

        private void button_Ogrenci_Ders_Kayit_Click(object sender, EventArgs e)
        {
            if (frm_dersKayit.Created)
            {
                frm_dersKayit.Activate();
                frm_dersKayit.Show();
            }
            else
            {
                frm_dersKayit = new Form_dersKayit();
                frm_dersKayit.MdiParent = this.MdiParent;
                frm_dersKayit.Show();
            }
        }

        private void button_Danisman_Kayit_Click(object sender, EventArgs e)
        {
            if (frm_danismanKayit.Created)
            {
                frm_danismanKayit.Activate();
                frm_danismanKayit.Show();
            }
            else
            {
                frm_danismanKayit = new Form_danismanKayit();
                frm_danismanKayit.MdiParent = this.MdiParent;
                frm_danismanKayit.Show();
            }
        }
    }
}
