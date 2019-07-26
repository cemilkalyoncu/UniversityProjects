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
    public partial class Form_notKayit : Form
    {
        public Form_notKayit()
        {
            InitializeComponent();
        }

        Form_notKayitEkle frmNotKayitEkle = new Form_notKayitEkle();
        Form_notKayitGoster frmNotKayitGoster = new Form_notKayitGoster();

        private void button_Ogrenci_Grup_Kayit_Click(object sender, EventArgs e)
        {
            if (frmNotKayitEkle.Created)
            {
                frmNotKayitEkle.Activate();
                frmNotKayitEkle.Show();
            }
            else
            {
                frmNotKayitEkle = new Form_notKayitEkle();
                frmNotKayitEkle.MdiParent = this.MdiParent;
                frmNotKayitEkle.Show();
            }
        }

        private void button_Not_Kayit_Goster_Click(object sender, EventArgs e)
        {
            if (frmNotKayitGoster.Created)
            {
                frmNotKayitEkle.Activate();
                frmNotKayitGoster.Show();
            }
            else
            {
                frmNotKayitGoster = new Form_notKayitGoster();
                frmNotKayitGoster.MdiParent = this.MdiParent;
                frmNotKayitGoster.Show();
            }
        }
    }
}
