using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Dershane_Projesi
{
    class A_Genel
    {
        public static string gec;
        public static bool anahtar = true;
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\VeriTabanı\\vtb.accdb");
        public static string cari_isim;
        public static int id;
        public static string Sahis_AdiSoyadi;
        public static int ogrnci_sinav_isle_id;


        public static void combodoldur(string tabloadi, ComboBox adi, string alan)
        {
            string sorgu = "SELECT " + alan + " FROM " + tabloadi + "";

            OleDbCommand veri = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader oku;

            if (A_Genel.baglanti.State == ConnectionState.Closed)
            {
                A_Genel.baglanti.Open();
            }
            oku = veri.ExecuteReader();

            while (oku.Read())
            {
                adi.Items.Add(oku[alan].ToString());
            }
            oku.Close();
            baglanti.Close();
        }

    }
}
