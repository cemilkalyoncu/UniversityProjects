namespace Dershane_Projesi
{
    partial class Form_Kullanici_Duzen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kullanici_Duzen));
            this.dataGridView_Kullanici_Adi_Sifre = new System.Windows.Forms.DataGridView();
            this.groupBox_Kullanici_Adi_Sifre = new System.Windows.Forms.GroupBox();
            this.button_Kullanici_Duzenle = new System.Windows.Forms.Button();
            this.button_Kullanici_Sil = new System.Windows.Forms.Button();
            this.button_Yeni_Kullanici = new System.Windows.Forms.Button();
            this.button_Kullanici_Kaydet = new System.Windows.Forms.Button();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kullanici_Adi_Sifre)).BeginInit();
            this.groupBox_Kullanici_Adi_Sifre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Kullanici_Adi_Sifre
            // 
            this.dataGridView_Kullanici_Adi_Sifre.AllowUserToAddRows = false;
            this.dataGridView_Kullanici_Adi_Sifre.AllowUserToDeleteRows = false;
            this.dataGridView_Kullanici_Adi_Sifre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Kullanici_Adi_Sifre.Location = new System.Drawing.Point(12, 117);
            this.dataGridView_Kullanici_Adi_Sifre.Name = "dataGridView_Kullanici_Adi_Sifre";
            this.dataGridView_Kullanici_Adi_Sifre.ReadOnly = true;
            this.dataGridView_Kullanici_Adi_Sifre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Kullanici_Adi_Sifre.Size = new System.Drawing.Size(437, 145);
            this.dataGridView_Kullanici_Adi_Sifre.TabIndex = 5;
            this.dataGridView_Kullanici_Adi_Sifre.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Kullanici_Adi_Sifre_MouseDoubleClick);
            // 
            // groupBox_Kullanici_Adi_Sifre
            // 
            this.groupBox_Kullanici_Adi_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.button_Kullanici_Duzenle);
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.button_Kullanici_Sil);
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.button_Yeni_Kullanici);
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.button_Kullanici_Kaydet);
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.textBox_Sifre);
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.textBox_Kullanici_Adi);
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.label2);
            this.groupBox_Kullanici_Adi_Sifre.Controls.Add(this.label1);
            this.groupBox_Kullanici_Adi_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox_Kullanici_Adi_Sifre.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_Kullanici_Adi_Sifre.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Kullanici_Adi_Sifre.Name = "groupBox_Kullanici_Adi_Sifre";
            this.groupBox_Kullanici_Adi_Sifre.Size = new System.Drawing.Size(437, 99);
            this.groupBox_Kullanici_Adi_Sifre.TabIndex = 0;
            this.groupBox_Kullanici_Adi_Sifre.TabStop = false;
            this.groupBox_Kullanici_Adi_Sifre.Text = "Kullanıcı";
            // 
            // button_Kullanici_Duzenle
            // 
            this.button_Kullanici_Duzenle.FlatAppearance.BorderSize = 0;
            this.button_Kullanici_Duzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Kullanici_Duzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Kullanici_Duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kullanici_Duzenle.ForeColor = System.Drawing.Color.Black;
            this.button_Kullanici_Duzenle.Image = ((System.Drawing.Image)(resources.GetObject("button_Kullanici_Duzenle.Image")));
            this.button_Kullanici_Duzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kullanici_Duzenle.Location = new System.Drawing.Point(301, 19);
            this.button_Kullanici_Duzenle.Name = "button_Kullanici_Duzenle";
            this.button_Kullanici_Duzenle.Size = new System.Drawing.Size(62, 64);
            this.button_Kullanici_Duzenle.TabIndex = 3;
            this.button_Kullanici_Duzenle.UseVisualStyleBackColor = true;
            this.button_Kullanici_Duzenle.Visible = false;
            this.button_Kullanici_Duzenle.Click += new System.EventHandler(this.button_Kullanici_Duzenle_Click);
            // 
            // button_Kullanici_Sil
            // 
            this.button_Kullanici_Sil.FlatAppearance.BorderSize = 0;
            this.button_Kullanici_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Kullanici_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Kullanici_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kullanici_Sil.ForeColor = System.Drawing.Color.Black;
            this.button_Kullanici_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Kullanici_Sil.Image")));
            this.button_Kullanici_Sil.Location = new System.Drawing.Point(369, 19);
            this.button_Kullanici_Sil.Name = "button_Kullanici_Sil";
            this.button_Kullanici_Sil.Size = new System.Drawing.Size(62, 64);
            this.button_Kullanici_Sil.TabIndex = 4;
            this.button_Kullanici_Sil.UseVisualStyleBackColor = true;
            this.button_Kullanici_Sil.Click += new System.EventHandler(this.button_Kullanici_Sil_Click);
            // 
            // button_Yeni_Kullanici
            // 
            this.button_Yeni_Kullanici.FlatAppearance.BorderSize = 0;
            this.button_Yeni_Kullanici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Yeni_Kullanici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Yeni_Kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Yeni_Kullanici.ForeColor = System.Drawing.Color.Black;
            this.button_Yeni_Kullanici.Image = ((System.Drawing.Image)(resources.GetObject("button_Yeni_Kullanici.Image")));
            this.button_Yeni_Kullanici.Location = new System.Drawing.Point(233, 19);
            this.button_Yeni_Kullanici.Name = "button_Yeni_Kullanici";
            this.button_Yeni_Kullanici.Size = new System.Drawing.Size(62, 64);
            this.button_Yeni_Kullanici.TabIndex = 2;
            this.button_Yeni_Kullanici.UseVisualStyleBackColor = true;
            this.button_Yeni_Kullanici.Click += new System.EventHandler(this.button_Yeni_Kullanici_Click);
            // 
            // button_Kullanici_Kaydet
            // 
            this.button_Kullanici_Kaydet.FlatAppearance.BorderSize = 0;
            this.button_Kullanici_Kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Kullanici_Kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Kullanici_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kullanici_Kaydet.ForeColor = System.Drawing.Color.Black;
            this.button_Kullanici_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Kullanici_Kaydet.Image")));
            this.button_Kullanici_Kaydet.Location = new System.Drawing.Point(301, 19);
            this.button_Kullanici_Kaydet.Name = "button_Kullanici_Kaydet";
            this.button_Kullanici_Kaydet.Size = new System.Drawing.Size(62, 64);
            this.button_Kullanici_Kaydet.TabIndex = 49;
            this.button_Kullanici_Kaydet.UseVisualStyleBackColor = true;
            this.button_Kullanici_Kaydet.Click += new System.EventHandler(this.button_Kullanici_Kaydet_Click);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(98, 55);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(114, 20);
            this.textBox_Sifre.TabIndex = 1;
            this.textBox_Sifre.Enter += new System.EventHandler(this.textBox_Kullanici_Adi_Enter);
            this.textBox_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kullanici_Adi_KeyPress);
            this.textBox_Sifre.Leave += new System.EventHandler(this.textBox_Sifre_Leave);
            // 
            // textBox_Kullanici_Adi
            // 
            this.textBox_Kullanici_Adi.Location = new System.Drawing.Point(98, 25);
            this.textBox_Kullanici_Adi.Name = "textBox_Kullanici_Adi";
            this.textBox_Kullanici_Adi.Size = new System.Drawing.Size(114, 20);
            this.textBox_Kullanici_Adi.TabIndex = 0;
            this.textBox_Kullanici_Adi.Enter += new System.EventHandler(this.textBox_Kullanici_Adi_Enter);
            this.textBox_Kullanici_Adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kullanici_Adi_KeyPress);
            this.textBox_Kullanici_Adi.Leave += new System.EventHandler(this.textBox_Kullanici_Adi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Form_Kullanici_Duzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(538, 312);
            this.Controls.Add(this.dataGridView_Kullanici_Adi_Sifre);
            this.Controls.Add(this.groupBox_Kullanici_Adi_Sifre);
            this.Name = "Form_Kullanici_Duzen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Düzen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_kullaniciDuzen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kullanici_Adi_Sifre)).EndInit();
            this.groupBox_Kullanici_Adi_Sifre.ResumeLayout(false);
            this.groupBox_Kullanici_Adi_Sifre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Kullanici_Adi_Sifre;
        private System.Windows.Forms.GroupBox groupBox_Kullanici_Adi_Sifre;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_Kullanici_Adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_Kullanici_Duzenle;
        private System.Windows.Forms.Button button_Kullanici_Sil;
        private System.Windows.Forms.Button button_Yeni_Kullanici;
        private System.Windows.Forms.Button button_Kullanici_Kaydet;
    }
}