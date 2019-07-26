namespace Dershane_Projesi
{
    partial class Form_Personel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Personel));
            this.textBox_Personel_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Personel_Soyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Personel_Tel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbPersonelBilgi = new System.Windows.Forms.GroupBox();
            this.comboBox_Personel_Yetki = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Personel_Adres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Personel_Bilgi_Liste = new System.Windows.Forms.DataGridView();
            this.button_Personel_Sil = new System.Windows.Forms.Button();
            this.button_Personel_Kaydet = new System.Windows.Forms.Button();
            this.button_Personel_Duzenle = new System.Windows.Forms.Button();
            this.button_Yeni_Personel_Ekle = new System.Windows.Forms.Button();
            this.grpbPersonelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Personel_Bilgi_Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Personel_Adi
            // 
            this.textBox_Personel_Adi.Location = new System.Drawing.Point(93, 19);
            this.textBox_Personel_Adi.Name = "textBox_Personel_Adi";
            this.textBox_Personel_Adi.Size = new System.Drawing.Size(95, 20);
            this.textBox_Personel_Adi.TabIndex = 0;
            this.textBox_Personel_Adi.Enter += new System.EventHandler(this.textBox_Personel_Adi_Enter);
            this.textBox_Personel_Adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Personel_Adi_KeyPress);
            this.textBox_Personel_Adi.Leave += new System.EventHandler(this.textBox_Personel_Adi_Leave);
            // 
            // textBox_Personel_Soyadi
            // 
            this.textBox_Personel_Soyadi.Location = new System.Drawing.Point(93, 44);
            this.textBox_Personel_Soyadi.Name = "textBox_Personel_Soyadi";
            this.textBox_Personel_Soyadi.Size = new System.Drawing.Size(121, 20);
            this.textBox_Personel_Soyadi.TabIndex = 1;
            this.textBox_Personel_Soyadi.Enter += new System.EventHandler(this.textBox_Personel_Adi_Enter);
            this.textBox_Personel_Soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Personel_Adi_KeyPress);
            this.textBox_Personel_Soyadi.Leave += new System.EventHandler(this.textBox_Personel_Soyadi_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Soyadı :";
            // 
            // textBox_Personel_Tel
            // 
            this.textBox_Personel_Tel.Location = new System.Drawing.Point(93, 96);
            this.textBox_Personel_Tel.Name = "textBox_Personel_Tel";
            this.textBox_Personel_Tel.Size = new System.Drawing.Size(121, 20);
            this.textBox_Personel_Tel.TabIndex = 3;
            this.textBox_Personel_Tel.Enter += new System.EventHandler(this.textBox_Personel_Adi_Enter);
            this.textBox_Personel_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Personel_Tel_KeyPress);
            this.textBox_Personel_Tel.Leave += new System.EventHandler(this.textBox_Personel_Tel_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tel :";
            // 
            // grpbPersonelBilgi
            // 
            this.grpbPersonelBilgi.BackColor = System.Drawing.Color.Transparent;
            this.grpbPersonelBilgi.Controls.Add(this.comboBox_Personel_Yetki);
            this.grpbPersonelBilgi.Controls.Add(this.label3);
            this.grpbPersonelBilgi.Controls.Add(this.textBox_Personel_Adres);
            this.grpbPersonelBilgi.Controls.Add(this.label2);
            this.grpbPersonelBilgi.Controls.Add(this.label6);
            this.grpbPersonelBilgi.Controls.Add(this.textBox_Personel_Tel);
            this.grpbPersonelBilgi.Controls.Add(this.label7);
            this.grpbPersonelBilgi.Controls.Add(this.label1);
            this.grpbPersonelBilgi.Controls.Add(this.textBox_Personel_Soyadi);
            this.grpbPersonelBilgi.Controls.Add(this.textBox_Personel_Adi);
            this.grpbPersonelBilgi.ForeColor = System.Drawing.SystemColors.Control;
            this.grpbPersonelBilgi.Location = new System.Drawing.Point(12, 12);
            this.grpbPersonelBilgi.Name = "grpbPersonelBilgi";
            this.grpbPersonelBilgi.Size = new System.Drawing.Size(303, 236);
            this.grpbPersonelBilgi.TabIndex = 27;
            this.grpbPersonelBilgi.TabStop = false;
            this.grpbPersonelBilgi.Text = "Personel Bilgi";
            // 
            // comboBox_Personel_Yetki
            // 
            this.comboBox_Personel_Yetki.DisplayMember = "Genel Müdür";
            this.comboBox_Personel_Yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Personel_Yetki.FormattingEnabled = true;
            this.comboBox_Personel_Yetki.Items.AddRange(new object[] {
            "Genel Müdür",
            "Müdür",
            "Müdür Yardımcısı",
            "Sekreter",
            "Öğretmen"});
            this.comboBox_Personel_Yetki.Location = new System.Drawing.Point(93, 70);
            this.comboBox_Personel_Yetki.Name = "comboBox_Personel_Yetki";
            this.comboBox_Personel_Yetki.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Personel_Yetki.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Personel Yetki :";
            // 
            // textBox_Personel_Adres
            // 
            this.textBox_Personel_Adres.Location = new System.Drawing.Point(93, 122);
            this.textBox_Personel_Adres.Multiline = true;
            this.textBox_Personel_Adres.Name = "textBox_Personel_Adres";
            this.textBox_Personel_Adres.Size = new System.Drawing.Size(196, 102);
            this.textBox_Personel_Adres.TabIndex = 4;
            this.textBox_Personel_Adres.Enter += new System.EventHandler(this.textBox_Personel_Adi_Enter);
            this.textBox_Personel_Adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Personel_Adres_KeyPress);
            this.textBox_Personel_Adres.Leave += new System.EventHandler(this.textBox_Personel_Adres_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Adres :";
            // 
            // dataGridView_Personel_Bilgi_Liste
            // 
            this.dataGridView_Personel_Bilgi_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Personel_Bilgi_Liste.Location = new System.Drawing.Point(321, 12);
            this.dataGridView_Personel_Bilgi_Liste.Name = "dataGridView_Personel_Bilgi_Liste";
            this.dataGridView_Personel_Bilgi_Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Personel_Bilgi_Liste.Size = new System.Drawing.Size(477, 299);
            this.dataGridView_Personel_Bilgi_Liste.TabIndex = 9;
            this.dataGridView_Personel_Bilgi_Liste.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Personel_Bilgi_Liste_CellMouseDoubleClick);
            // 
            // button_Personel_Sil
            // 
            this.button_Personel_Sil.BackColor = System.Drawing.Color.SlateGray;
            this.button_Personel_Sil.FlatAppearance.BorderSize = 0;
            this.button_Personel_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Personel_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Personel_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Personel_Sil.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Personel_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Personel_Sil.Image")));
            this.button_Personel_Sil.Location = new System.Drawing.Point(224, 254);
            this.button_Personel_Sil.Name = "button_Personel_Sil";
            this.button_Personel_Sil.Size = new System.Drawing.Size(62, 64);
            this.button_Personel_Sil.TabIndex = 8;
            this.button_Personel_Sil.UseVisualStyleBackColor = false;
            this.button_Personel_Sil.Click += new System.EventHandler(this.button_Personel_Sil_Click);
            // 
            // button_Personel_Kaydet
            // 
            this.button_Personel_Kaydet.BackColor = System.Drawing.Color.SlateGray;
            this.button_Personel_Kaydet.FlatAppearance.BorderSize = 0;
            this.button_Personel_Kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Personel_Kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Personel_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Personel_Kaydet.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Personel_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Personel_Kaydet.Image")));
            this.button_Personel_Kaydet.Location = new System.Drawing.Point(88, 254);
            this.button_Personel_Kaydet.Name = "button_Personel_Kaydet";
            this.button_Personel_Kaydet.Size = new System.Drawing.Size(62, 64);
            this.button_Personel_Kaydet.TabIndex = 6;
            this.button_Personel_Kaydet.UseVisualStyleBackColor = false;
            this.button_Personel_Kaydet.Click += new System.EventHandler(this.button_Personel_Kaydet_Click);
            // 
            // button_Personel_Duzenle
            // 
            this.button_Personel_Duzenle.BackColor = System.Drawing.Color.SlateGray;
            this.button_Personel_Duzenle.FlatAppearance.BorderSize = 0;
            this.button_Personel_Duzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Personel_Duzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Personel_Duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Personel_Duzenle.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Personel_Duzenle.Image = ((System.Drawing.Image)(resources.GetObject("button_Personel_Duzenle.Image")));
            this.button_Personel_Duzenle.Location = new System.Drawing.Point(156, 254);
            this.button_Personel_Duzenle.Name = "button_Personel_Duzenle";
            this.button_Personel_Duzenle.Size = new System.Drawing.Size(62, 64);
            this.button_Personel_Duzenle.TabIndex = 7;
            this.button_Personel_Duzenle.UseVisualStyleBackColor = false;
            this.button_Personel_Duzenle.Click += new System.EventHandler(this.button_Personel_Duzenle_Click);
            // 
            // button_Yeni_Personel_Ekle
            // 
            this.button_Yeni_Personel_Ekle.BackColor = System.Drawing.Color.SlateGray;
            this.button_Yeni_Personel_Ekle.FlatAppearance.BorderSize = 0;
            this.button_Yeni_Personel_Ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Yeni_Personel_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Yeni_Personel_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Yeni_Personel_Ekle.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Yeni_Personel_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_Yeni_Personel_Ekle.Image")));
            this.button_Yeni_Personel_Ekle.Location = new System.Drawing.Point(20, 254);
            this.button_Yeni_Personel_Ekle.Name = "button_Yeni_Personel_Ekle";
            this.button_Yeni_Personel_Ekle.Size = new System.Drawing.Size(62, 64);
            this.button_Yeni_Personel_Ekle.TabIndex = 5;
            this.button_Yeni_Personel_Ekle.UseVisualStyleBackColor = false;
            this.button_Yeni_Personel_Ekle.Click += new System.EventHandler(this.button_Yeni_Personel_Ekle_Click);
            // 
            // Form_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(814, 353);
            this.Controls.Add(this.button_Personel_Sil);
            this.Controls.Add(this.button_Personel_Kaydet);
            this.Controls.Add(this.button_Personel_Duzenle);
            this.Controls.Add(this.button_Yeni_Personel_Ekle);
            this.Controls.Add(this.dataGridView_Personel_Bilgi_Liste);
            this.Controls.Add(this.grpbPersonelBilgi);
            this.Name = "Form_Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Bilgi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Personel_Load);
            this.grpbPersonelBilgi.ResumeLayout(false);
            this.grpbPersonelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Personel_Bilgi_Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Personel_Adi;
        private System.Windows.Forms.TextBox textBox_Personel_Soyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Personel_Tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbPersonelBilgi;
        private System.Windows.Forms.TextBox textBox_Personel_Adres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Personel_Bilgi_Liste;
        private System.Windows.Forms.Button button_Personel_Sil;
        private System.Windows.Forms.Button button_Personel_Kaydet;
        private System.Windows.Forms.Button button_Personel_Duzenle;
        private System.Windows.Forms.Button button_Yeni_Personel_Ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Personel_Yetki;
    }
}