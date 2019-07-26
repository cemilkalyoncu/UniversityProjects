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
    public partial class Form_puanHesaplama : Form
    {
        public Form_puanHesaplama()
        {
            InitializeComponent();
        }

        double tr1, tr2, tr3, tr4, tr5, tr6;
        double mat1, mat2, mat3, mat4, mat5, mat6;
        double sos1, sos2, sos3, sos4, sos5, sos6;
        double fen1, fen2, fen3, fen4, fen5, fen6;
        double mat_mf1, mat_mf2, mat_mf3, mat_mf4;
        double mf1, mf2, mf3, mf4, ygs_mf1, ygs_mf2, ygs_mf3, ygs_mf4;
        double geo1, geo2, geo3, geo4;
        double tm1, tm2, tm3, lys_tm1, lys_tm2, lys_tm3, ygs_tm1, ygs_tm2, ygs_tm3;
        double sos_mf1, sos_mf2, sos_mf3, sos_mf4;
        double fen_mf1, fen_mf2, fen_mf3, fen_mf4;
        double fiz_mf1, fiz_mf2, fiz_mf3, fiz_mf4;
        double kim_mf1, kim_mf2, kim_mf3, kim_mf4;
        double biyo_mf1, biyo_mf2, biyo_mf3, biyo_mf4;
        double mat_tm1, mat_tm2, mat_tm3;
        double sos_tm1, sos_tm2, sos_tm3;
        double fen_tm1, fen_tm2, fen_tm3;
        double edeb_tm1, edeb_tm2, edeb_tm3;
        double cog_tm1, cog_tm2, cog_tm3;
        double tr_ts1, tr_ts2;
        double sos_ts1, sos_ts2;
        double mat_ts1, mat_ts2;
        double fen_ts1, fen_ts2;
        double edeb_ts1, edeb_ts2;
        double cog_ts1, cog_ts2;
        double tar_ts1, tar_ts2;
        double cog2_ts1, cog2_ts2;
        double fel_ts1, fel_ts2;



        private void button1_Click(object sender, EventArgs e)
        {
            label79.Text = (tr1 + mat1 + sos1 + fen1 + 100).ToString();
            label78.Text = (tr2 + mat2 + sos2 + fen2 + 100).ToString();
            label84.Text = (tr3 + mat3 + sos3 + fen3 + 100).ToString();
            label83.Text = (tr4 + mat4 + sos4 + fen4 + 100).ToString();
            label86.Text = (tr5 + mat5 + sos5 + fen5 + 100).ToString();
            label85.Text = (tr6 + mat6 + sos6 + fen6 + 100).ToString();

            label96.Text = (mf1 + geo1 + ygs_mf1 + mat_mf1 + sos_mf1 + fen_mf1 + fiz_mf1 + kim_mf1 + biyo_mf1 + 100).ToString();
            label95.Text = (mf2 + geo2 + ygs_mf2 + mat_mf2 + sos_mf2 + fen_mf2 + fiz_mf2 + kim_mf2 + biyo_mf2 + 100).ToString();
            label107.Text = (mf3 + geo3 + ygs_mf3 + mat_mf3 + sos_mf3 + fen_mf3 + fiz_mf3 + kim_mf3 + biyo_mf3 + 100).ToString();
            label106.Text = (mf4 + geo4 + ygs_mf4 + mat_mf4 + sos_mf4 + fen_mf4 + fiz_mf4 + kim_mf4 + biyo_mf4 + 100).ToString();

            label145.Text = (tm1 + lys_tm1 + mat_tm1 + ygs_tm1 + sos_tm1 + fen_tm1 + edeb_tm1 + cog_tm1 + 100).ToString();
            label144.Text = (tm2 + lys_tm2 + mat_tm2 + ygs_tm2 + sos_tm2 + fen_tm2 + edeb_tm2 + cog_tm2 + 100).ToString();
            label142.Text = (tm3 + lys_tm3 + mat_tm3 + ygs_tm3 + sos_tm3 + fen_tm3 + edeb_tm3 + cog_tm3 + 100).ToString();


            label167.Text = (tr_ts1 + mat_ts1 + sos_ts1 + fen_ts1 + edeb_ts1 + cog_ts1 + tar_ts1 + cog2_ts1 + fel_ts1 + 100).ToString();
            label166.Text = (tr_ts2 + mat_ts2 + sos_ts2 + fen_ts2 + edeb_ts2 + cog_ts2 + tar_ts2 + cog2_ts2 + fel_ts2 + 100).ToString();


            label62.Text = textBox1.Text;
            label63.Text = textBox2.Text;
            label65.Text = textBox3.Text;
            label64.Text = textBox4.Text;

            label69.Text = textBox5.Text;
            label68.Text = textBox6.Text;
            label67.Text = textBox8.Text;
            label66.Text = textBox7.Text;

            label73.Text = textBox12.Text;
            label72.Text = textBox11.Text;
            label71.Text = textBox10.Text;
            label70.Text = textBox9.Text;

            label100.Text = textBox16.Text;
            label99.Text = textBox15.Text;
            label102.Text = textBox20.Text;
            label101.Text = textBox19.Text;
            label104.Text = textBox24.Text;
            label103.Text = textBox23.Text;

            label127.Text = textBox22.Text;
            label126.Text = textBox21.Text;
            label125.Text = textBox27.Text;

            label124.Text = textBox18.Text;
            label123.Text = textBox17.Text;
            label122.Text = textBox26.Text;

            label141.Text = textBox33.Text;
            label140.Text = textBox32.Text;
            label139.Text = textBox31.Text;
            label138.Text = textBox30.Text;
            label137.Text = textBox29.Text;
            label136.Text = textBox28.Text;

            label121.Text = textBox14.Text;
            label120.Text = textBox13.Text;
            label119.Text = textBox25.Text;


            label165.Text = textBox42.Text;
            label164.Text = textBox41.Text;
            label163.Text = textBox36.Text;
            label162.Text = textBox40.Text;
            label161.Text = textBox39.Text;
            label160.Text = textBox35.Text;
            label159.Text = textBox38.Text;
            label158.Text = textBox37.Text;
            label157.Text = textBox34.Text;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox) this.Controls[i].Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) + int.Parse(textBox5.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0";
                textBox5.Text = "0";
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox1.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox12.Text = (int.Parse(textBox1.Text) - (int.Parse(textBox5.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            tr1 = double.Parse(textBox12.Text) * 2;
            tr2 = double.Parse(textBox12.Text) * 2;
            tr3 = double.Parse(textBox12.Text) * 4;
            tr4 = double.Parse(textBox12.Text) * 3;
            tr5 = double.Parse(textBox12.Text) * 3.7;
            tr6 = double.Parse(textBox12.Text) * 3.3;

            ygs_mf1 = double.Parse(textBox12.Text) * 1.122;
            ygs_mf2 = double.Parse(textBox12.Text) * 1.183;
            ygs_mf3 = double.Parse(textBox12.Text) * 1.202;
            ygs_mf4 = double.Parse(textBox12.Text) * 1.146;

            ygs_tm1 = double.Parse(textBox12.Text) * 1.294;
            ygs_tm2 = double.Parse(textBox12.Text) * 1.283;
            ygs_tm3 = double.Parse(textBox12.Text) * 1.379;

            tr_ts1 = double.Parse(textBox12.Text) * 1.349;
            tr_ts2 = double.Parse(textBox12.Text) * 1.731;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) + int.Parse(textBox5.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0";
                textBox5.Text = "0";
            }
            else
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox5.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox5.Text = "0";
                    }
                    else
                    {
                        textBox12.Text = (int.Parse(textBox1.Text) - (int.Parse(textBox5.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) + int.Parse(textBox6.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "0";
                textBox6.Text = "0";
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox2.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "0";
                    }
                    else
                    {
                        textBox11.Text = (int.Parse(textBox2.Text) - (int.Parse(textBox6.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) + int.Parse(textBox6.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "0";
                textBox6.Text = "0";
            }
            else
            {
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox6.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox6.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox6.Text = "0";
                    }
                    else
                    {
                        textBox11.Text = (int.Parse(textBox2.Text) - (int.Parse(textBox6.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox3.Text) + int.Parse(textBox8.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "0";
                textBox8.Text = "0";
            }
            else
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox3.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Text = "0";
                    }
                    else
                    {
                        textBox10.Text = (int.Parse(textBox3.Text) - (int.Parse(textBox8.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox3.Text) + int.Parse(textBox8.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "0";
                textBox8.Text = "0";
            }
            else
            {
                if (textBox8.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox8.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox8.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox8.Text = "0";
                    }
                    else
                    {
                        textBox10.Text = (int.Parse(textBox3.Text) - (int.Parse(textBox8.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox4.Text) + int.Parse(textBox7.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox4.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox4.Text = "0";
                    }
                    else
                    {
                        textBox9.Text = (int.Parse(textBox4.Text) - (int.Parse(textBox7.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox4.Text) + int.Parse(textBox7.Text) > 40)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "0";
                textBox7.Text = "0";
            }
            else
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox7.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox7.Text) > 40)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox7.Text = "0";
                    }
                    else
                    {
                        textBox9.Text = (int.Parse(textBox4.Text) - (int.Parse(textBox7.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox24.Text) + int.Parse(textBox20.Text) > 50)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 50'yi Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox24.Text = "0";
                textBox20.Text = "0";
            }
            else
            {
                if (textBox24.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox24.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox24.Text) > 50)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 50'yi Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox24.Text = "0";
                    }
                    else
                    {
                        textBox16.Text = (int.Parse(textBox24.Text) - (int.Parse(textBox20.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox24.Text) + int.Parse(textBox20.Text) > 50)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 50'yi Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox24.Text = "0";
                textBox20.Text = "0";
            }
            else
            {
                if (textBox20.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox20.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox20.Text) > 50)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 50'yi Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox20.Text = "0";
                    }
                    else
                    {
                        textBox16.Text = (int.Parse(textBox24.Text) - (int.Parse(textBox20.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox23.Text) + int.Parse(textBox19.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox23.Text = "0";
                textBox19.Text = "0";
            }
            else
            {
                if (textBox23.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox23.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox23.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox23.Text = "0";
                    }
                    else
                    {
                        textBox15.Text = (int.Parse(textBox23.Text) - (int.Parse(textBox19.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox19.Text) + int.Parse(textBox23.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox19.Text = "0";
                textBox23.Text = "0";
            }
            else
            {
                if (textBox19.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox19.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox19.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox19.Text = "0";
                    }
                    else
                    {
                        textBox15.Text = (int.Parse(textBox23.Text) - (int.Parse(textBox19.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox22.Text) + int.Parse(textBox18.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox18.Text = "0";
                textBox22.Text = "0";
            }
            else
            {
                if (textBox22.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox22.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox22.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox22.Text = "0";
                    }
                    else
                    {
                        textBox14.Text = (int.Parse(textBox22.Text) - (int.Parse(textBox18.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox18.Text) + int.Parse(textBox22.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox18.Text = "0";
                textBox22.Text = "0";
            }
            else
            {
                if (textBox18.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox18.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox18.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox18.Text = "0";
                    }
                    else
                    {
                        textBox14.Text = (int.Parse(textBox22.Text) - (int.Parse(textBox18.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox21.Text) + int.Parse(textBox17.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox17.Text = "0";
                textBox21.Text = "0";
            }
            else
            {
                if (textBox21.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox21.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox21.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox21.Text = "0";
                    }
                    else
                    {
                        textBox13.Text = (int.Parse(textBox21.Text) - (int.Parse(textBox17.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox17.Text) + int.Parse(textBox21.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox17.Text = "0";
                textBox21.Text = "0";
            }
            else
            {
                if (textBox17.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox17.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox17.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox17.Text = "0";
                    }
                    else
                    {
                        textBox13.Text = (int.Parse(textBox21.Text) - (int.Parse(textBox17.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox27.Text) + int.Parse(textBox26.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox27.Text = "0";
                textBox26.Text = "0";
            }
            else
            {
                if (textBox27.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox27.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox27.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox27.Text = "0";
                    }
                    else
                    {
                        textBox25.Text = (int.Parse(textBox27.Text) - (int.Parse(textBox26.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox26.Text) + int.Parse(textBox27.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox26.Text = "0";
                textBox27.Text = "0";
            }
            else
            {
                if (textBox26.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox26.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox26.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox26.Text = "0";
                    }
                    else
                    {
                        textBox25.Text = (int.Parse(textBox27.Text) - (int.Parse(textBox26.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox33.Text) + int.Parse(textBox31.Text) > 56)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 56'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox33.Text = "0";
                textBox31.Text = "0";
            }
            else
            {
                if (textBox33.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox33.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox33.Text) > 56)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 56'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox33.Text = "0";
                    }
                    else
                    {
                        textBox29.Text = (int.Parse(textBox33.Text) - (int.Parse(textBox31.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox33.Text) + int.Parse(textBox31.Text) > 56)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 56'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox33.Text = "0";
                textBox31.Text = "0";
            }
            else
            {
                if (textBox31.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox31.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox31.Text) > 56)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 56'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox31.Text = "0";
                    }
                    else
                    {
                        textBox29.Text = (int.Parse(textBox33.Text) - (int.Parse(textBox31.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox32.Text) + int.Parse(textBox30.Text) > 24)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 24'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox32.Text = "0";
                textBox30.Text = "0";
            }
            else
            {
                if (textBox32.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox32.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox32.Text) > 24)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 24'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox32.Text = "0";
                    }
                    else
                    {
                        textBox28.Text = (int.Parse(textBox32.Text) - (int.Parse(textBox30.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox32.Text) + int.Parse(textBox30.Text) > 24)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 24'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox32.Text = "0";
                textBox30.Text = "0";
            }
            else
            {
                if (textBox30.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox30.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox30.Text) > 24)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 24'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox30.Text = "0";
                    }
                    else
                    {
                        textBox28.Text = (int.Parse(textBox32.Text) - (int.Parse(textBox30.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox42.Text) + int.Parse(textBox40.Text) > 44)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 44'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox42.Text = "0";
                textBox40.Text = "0";
            }
            else
            {
                if (textBox42.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox42.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox42.Text) > 44)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 44'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox42.Text = "0";
                    }
                    else
                    {
                        textBox38.Text = (int.Parse(textBox42.Text) - (int.Parse(textBox40.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox42.Text) + int.Parse(textBox40.Text) > 44)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 44'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox40.Text = "0";
                textBox42.Text = "0";
            }
            else
            {
                if (textBox40.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox40.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox40.Text) > 44)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 40'ü Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox40.Text = "0";
                    }
                    else
                    {
                        textBox38.Text = (int.Parse(textBox42.Text) - (int.Parse(textBox40.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox41.Text) + int.Parse(textBox39.Text) > 16)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 16'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox41.Text = "0";
                textBox39.Text = "0";
            }
            else
            {
                if (textBox41.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox41.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox41.Text) > 16)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 16'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox41.Text = "0";
                    }
                    else
                    {
                        textBox37.Text = (int.Parse(textBox41.Text) - (int.Parse(textBox39.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox39.Text) + int.Parse(textBox41.Text) > 16)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 16'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox39.Text = "0";
                textBox41.Text = "0";
            }
            else
            {
                if (textBox39.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox39.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox39.Text) > 16)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 16'yı Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox39.Text = "0";
                    }
                    else
                    {
                        textBox37.Text = (int.Parse(textBox41.Text) - (int.Parse(textBox39.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox36.Text) + int.Parse(textBox35.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox35.Text = "0";
                textBox36.Text = "0";
            }
            else
            {
                if (textBox36.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox36.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox36.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox36.Text = "0";
                    }
                    else
                    {
                        textBox34.Text = (int.Parse(textBox36.Text) - (int.Parse(textBox35.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox36.Text) + int.Parse(textBox35.Text) > 30)
            {
                MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox35.Text = "0";
                textBox36.Text = "0";
            }
            else
            {
                if (textBox35.Text == "")
                {
                    MessageBox.Show("Textlerin İçi Boş Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox35.Text = "0";
                }
                else
                {
                    if (int.Parse(textBox35.Text) > 30)
                    {
                        MessageBox.Show("Doğru-Yanlış Sayısı 30'u Geçemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox35.Text = "0";
                    }
                    else
                    {
                        textBox34.Text = (int.Parse(textBox36.Text) - (int.Parse(textBox35.Text) * 0.25)).ToString();
                    }
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            mat1 = double.Parse(textBox11.Text) * 4;
            mat2 = double.Parse(textBox11.Text) * 3;
            mat3 = double.Parse(textBox11.Text) * 2;
            mat4 = double.Parse(textBox11.Text) * 2;
            mat5 = double.Parse(textBox11.Text) * 3.3;
            mat6 = double.Parse(textBox11.Text) * 3.7;

            mat_mf1 = double.Parse(textBox11.Text) * 1.633;
            mat_mf2 = double.Parse(textBox11.Text) * 1.183;
            mat_mf3 = double.Parse(textBox11.Text) * 1.202;
            mat_mf4 = double.Parse(textBox11.Text) * 1.458;

            mat_tm1 = double.Parse(textBox11.Text) * 1.479;
            mat_tm2 = double.Parse(textBox11.Text) * 1.283;
            mat_tm3 = double.Parse(textBox11.Text) * 0.920;

            mat_ts1 = double.Parse(textBox11.Text) * 1.038;
            mat_ts2 = double.Parse(textBox11.Text) * 0.577;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            sos1 = double.Parse(textBox10.Text) * 1;
            sos2 = double.Parse(textBox10.Text) * 1;
            sos3 = double.Parse(textBox10.Text) * 3;
            sos4 = double.Parse(textBox10.Text) * 4;
            sos5 = double.Parse(textBox10.Text) * 2;
            sos6 = double.Parse(textBox10.Text) * 1;

            sos_mf1 = double.Parse(textBox10.Text) * 0.510;
            sos_mf2 = double.Parse(textBox10.Text) * 0.538;
            sos_mf3 = double.Parse(textBox10.Text) * 0.765;
            sos_mf4 = double.Parse(textBox10.Text) * 0.625;

            sos_tm1 = double.Parse(textBox10.Text) * 0.462;
            sos_tm2 = double.Parse(textBox10.Text) * 0.642;
            sos_tm3 = double.Parse(textBox10.Text) * 0.920;

            sos_ts1 = double.Parse(textBox10.Text) * 1.245;
            sos_ts2 = double.Parse(textBox10.Text) * 1.058;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            fen1 = double.Parse(textBox9.Text) * 3;
            fen2 = double.Parse(textBox9.Text) * 4;
            fen3 = double.Parse(textBox9.Text) * 1;
            fen4 = double.Parse(textBox9.Text) * 1;
            fen5 = double.Parse(textBox9.Text) * 1;
            fen6 = double.Parse(textBox9.Text) * 2;

            fen_mf1 = double.Parse(textBox9.Text) * 0.816;
            fen_mf2 = double.Parse(textBox9.Text) * 1.398;
            fen_mf3 = double.Parse(textBox9.Text) * 1.202;
            fen_mf4 = double.Parse(textBox9.Text) * 0.938;

            fen_tm1 = double.Parse(textBox9.Text) * 0.462;
            fen_tm2 = double.Parse(textBox9.Text) * 0.458;
            fen_tm3 = double.Parse(textBox9.Text) * 0.460;

            fen_ts1 = double.Parse(textBox9.Text) * 0.519;
            fen_ts2 = double.Parse(textBox9.Text) * 0.481;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            mf1 = double.Parse(textBox16.Text) * 2.653;
            mf2 = double.Parse(textBox16.Text) * 1.720;
            mf3 = double.Parse(textBox16.Text) * 1.421;
            mf4 = double.Parse(textBox16.Text) * 2.292;

            tm1 = double.Parse(textBox16.Text) * 2.312;
            tm2 = double.Parse(textBox16.Text) * 2.016;
            tm3 = double.Parse(textBox16.Text) * 1.655;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            geo1 = double.Parse(textBox15.Text) * 1.327;
            geo2 = double.Parse(textBox15.Text) * 0.753;
            geo3 = double.Parse(textBox15.Text) * 0.546;
            geo4 = double.Parse(textBox15.Text) * 1.146;


            lys_tm1 = double.Parse(textBox15.Text) * 0.925;
            lys_tm2 = double.Parse(textBox15.Text) * 0.733;
            lys_tm3 = double.Parse(textBox15.Text) * 0.644;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            fiz_mf1 = double.Parse(textBox14.Text) * 1.020;
            fiz_mf2 = double.Parse(textBox14.Text) * 1.398;
            fiz_mf3 = double.Parse(textBox14.Text) * 1.421;
            fiz_mf4 = double.Parse(textBox14.Text) * 1.354;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            kim_mf1 = double.Parse(textBox13.Text) * 0.612;
            kim_mf2 = double.Parse(textBox13.Text) * 1.290;
            kim_mf3 = double.Parse(textBox13.Text) * 1.530;
            kim_mf4 = double.Parse(textBox13.Text) * 0.938;
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            biyo_mf1 = double.Parse(textBox13.Text) * 0.510;
            biyo_mf2 = double.Parse(textBox13.Text) * 1.290;
            biyo_mf3 = double.Parse(textBox13.Text) * 1.639;
            biyo_mf4 = double.Parse(textBox13.Text) * 0.521;
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            edeb_tm1 = double.Parse(textBox29.Text) * 1.664;
            edeb_tm2 = double.Parse(textBox29.Text) * 2.016;
            edeb_tm3 = double.Parse(textBox29.Text) * 2.299;

            edeb_ts1 = double.Parse(textBox29.Text) * 1.557;
            edeb_ts2 = double.Parse(textBox29.Text) * 2.404;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            cog_tm1 = double.Parse(textBox28.Text) * 0.647;
            cog_tm2 = double.Parse(textBox28.Text) * 0.733;
            cog_tm3 = double.Parse(textBox28.Text) * 0.920;

            cog_ts1 = double.Parse(textBox28.Text) * 0.830;
            cog_ts2 = double.Parse(textBox28.Text) * 0.481;
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            tar_ts1 = double.Parse(textBox38.Text) * 1.557;
            tar_ts2 = double.Parse(textBox38.Text) * 1.442;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            cog2_ts1 = double.Parse(textBox37.Text) * 0.727;
            cog2_ts2 = double.Parse(textBox37.Text) * 0.481;
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            fel_ts1 = double.Parse(textBox34.Text) * 1.557;
            fel_ts2 = double.Parse(textBox34.Text) * 0.962;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != (char)08))
            {
                e.Handled = true;
            }
        }

    }
}
