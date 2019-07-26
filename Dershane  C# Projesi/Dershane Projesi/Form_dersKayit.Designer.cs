namespace Dershane_Projesi
{
    partial class Form_dersKayit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dersKayit));
            this.groupBox_Ogrenci_Bolum_Kayit = new System.Windows.Forms.GroupBox();
            this.button_Ders_Sil = new System.Windows.Forms.Button();
            this.button_Ders_Yeni_Kayit = new System.Windows.Forms.Button();
            this.button_Ders_Kaydet = new System.Windows.Forms.Button();
            this.button_Kayit_Listele = new System.Windows.Forms.Button();
            this.textBox_Ders_Aciklama = new System.Windows.Forms.TextBox();
            this.textBox_Ders_Adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Ders_Kayit = new System.Windows.Forms.DataGridView();
            this.toolTip_Ders_Kayit = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_Ders_Kayit = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_Ogrenci_Bolum_Kayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ders_Kayit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Ders_Kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Ogrenci_Bolum_Kayit
            // 
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Ders_Sil);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Ders_Yeni_Kayit);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Ders_Kaydet);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Kayit_Listele);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.textBox_Ders_Aciklama);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.textBox_Ders_Adi);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.label2);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.label1);
            this.groupBox_Ogrenci_Bolum_Kayit.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_Ogrenci_Bolum_Kayit.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Ogrenci_Bolum_Kayit.Name = "groupBox_Ogrenci_Bolum_Kayit";
            this.groupBox_Ogrenci_Bolum_Kayit.Size = new System.Drawing.Size(475, 163);
            this.groupBox_Ogrenci_Bolum_Kayit.TabIndex = 0;
            this.groupBox_Ogrenci_Bolum_Kayit.TabStop = false;
            this.groupBox_Ogrenci_Bolum_Kayit.Text = "Ders Kayıt";
            // 
            // button_Ders_Sil
            // 
            this.button_Ders_Sil.FlatAppearance.BorderSize = 0;
            this.button_Ders_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Ders_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Ders_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ders_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Ders_Sil.Image")));
            this.button_Ders_Sil.Location = new System.Drawing.Point(407, 19);
            this.button_Ders_Sil.Name = "button_Ders_Sil";
            this.button_Ders_Sil.Size = new System.Drawing.Size(62, 64);
            this.button_Ders_Sil.TabIndex = 4;
            this.button_Ders_Sil.UseVisualStyleBackColor = true;
            this.button_Ders_Sil.Click += new System.EventHandler(this.button_Bolum_Sil_Click);
            // 
            // button_Ders_Yeni_Kayit
            // 
            this.button_Ders_Yeni_Kayit.FlatAppearance.BorderSize = 0;
            this.button_Ders_Yeni_Kayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Ders_Yeni_Kayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Ders_Yeni_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ders_Yeni_Kayit.Image = ((System.Drawing.Image)(resources.GetObject("button_Ders_Yeni_Kayit.Image")));
            this.button_Ders_Yeni_Kayit.Location = new System.Drawing.Point(271, 19);
            this.button_Ders_Yeni_Kayit.Name = "button_Ders_Yeni_Kayit";
            this.button_Ders_Yeni_Kayit.Size = new System.Drawing.Size(62, 64);
            this.button_Ders_Yeni_Kayit.TabIndex = 2;
            this.button_Ders_Yeni_Kayit.UseVisualStyleBackColor = true;
            this.button_Ders_Yeni_Kayit.Click += new System.EventHandler(this.button_Yeni_Kayit_Click);
            // 
            // button_Ders_Kaydet
            // 
            this.button_Ders_Kaydet.FlatAppearance.BorderSize = 0;
            this.button_Ders_Kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Ders_Kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Ders_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ders_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Ders_Kaydet.Image")));
            this.button_Ders_Kaydet.Location = new System.Drawing.Point(339, 19);
            this.button_Ders_Kaydet.Name = "button_Ders_Kaydet";
            this.button_Ders_Kaydet.Size = new System.Drawing.Size(62, 64);
            this.button_Ders_Kaydet.TabIndex = 3;
            this.button_Ders_Kaydet.UseVisualStyleBackColor = true;
            this.button_Ders_Kaydet.Click += new System.EventHandler(this.button_Bolum_Kaydet_Click);
            // 
            // button_Kayit_Listele
            // 
            this.button_Kayit_Listele.FlatAppearance.BorderSize = 0;
            this.button_Kayit_Listele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Kayit_Listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Kayit_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kayit_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kayit_Listele.ForeColor = System.Drawing.Color.Black;
            this.button_Kayit_Listele.Image = ((System.Drawing.Image)(resources.GetObject("button_Kayit_Listele.Image")));
            this.button_Kayit_Listele.Location = new System.Drawing.Point(325, 89);
            this.button_Kayit_Listele.Name = "button_Kayit_Listele";
            this.button_Kayit_Listele.Size = new System.Drawing.Size(89, 64);
            this.button_Kayit_Listele.TabIndex = 5;
            this.button_Kayit_Listele.UseVisualStyleBackColor = true;
            this.button_Kayit_Listele.Click += new System.EventHandler(this.button_Kayit_Listele_Click);
            // 
            // textBox_Ders_Aciklama
            // 
            this.textBox_Ders_Aciklama.Location = new System.Drawing.Point(85, 54);
            this.textBox_Ders_Aciklama.Multiline = true;
            this.textBox_Ders_Aciklama.Name = "textBox_Ders_Aciklama";
            this.textBox_Ders_Aciklama.Size = new System.Drawing.Size(170, 69);
            this.textBox_Ders_Aciklama.TabIndex = 1;
            this.textBox_Ders_Aciklama.Enter += new System.EventHandler(this.textBox_Ders_Adi_Enter);
            this.textBox_Ders_Aciklama.Leave += new System.EventHandler(this.textBox_Ders_Aciklama_Leave);
            // 
            // textBox_Ders_Adi
            // 
            this.textBox_Ders_Adi.Location = new System.Drawing.Point(85, 28);
            this.textBox_Ders_Adi.Name = "textBox_Ders_Adi";
            this.textBox_Ders_Adi.Size = new System.Drawing.Size(117, 20);
            this.textBox_Ders_Adi.TabIndex = 0;
            this.textBox_Ders_Adi.Enter += new System.EventHandler(this.textBox_Ders_Adi_Enter);
            this.textBox_Ders_Adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ders_Adi_KeyPress);
            this.textBox_Ders_Adi.Leave += new System.EventHandler(this.textBox_Ders_Adi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Adı :";
            // 
            // dataGridView_Ders_Kayit
            // 
            this.dataGridView_Ders_Kayit.AllowUserToAddRows = false;
            this.dataGridView_Ders_Kayit.AllowUserToDeleteRows = false;
            this.dataGridView_Ders_Kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ders_Kayit.Location = new System.Drawing.Point(12, 181);
            this.dataGridView_Ders_Kayit.Name = "dataGridView_Ders_Kayit";
            this.dataGridView_Ders_Kayit.ReadOnly = true;
            this.dataGridView_Ders_Kayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Ders_Kayit.Size = new System.Drawing.Size(475, 165);
            this.dataGridView_Ders_Kayit.TabIndex = 6;
            this.dataGridView_Ders_Kayit.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Ders_Kayit_CellMouseDoubleClick);
            // 
            // errorProvider_Ders_Kayit
            // 
            this.errorProvider_Ders_Kayit.ContainerControl = this;
            // 
            // Form_dersKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(499, 358);
            this.Controls.Add(this.groupBox_Ogrenci_Bolum_Kayit);
            this.Controls.Add(this.dataGridView_Ders_Kayit);
            this.Name = "Form_dersKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Kayıt";
            this.Load += new System.EventHandler(this.Form_dersKayit_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ders_Adi_KeyPress);
            this.groupBox_Ogrenci_Bolum_Kayit.ResumeLayout(false);
            this.groupBox_Ogrenci_Bolum_Kayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ders_Kayit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Ders_Kayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Ogrenci_Bolum_Kayit;
        private System.Windows.Forms.Button button_Ders_Sil;
        private System.Windows.Forms.Button button_Ders_Yeni_Kayit;
        private System.Windows.Forms.Button button_Ders_Kaydet;
        private System.Windows.Forms.Button button_Kayit_Listele;
        private System.Windows.Forms.TextBox textBox_Ders_Aciklama;
        private System.Windows.Forms.TextBox textBox_Ders_Adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Ders_Kayit;
        private System.Windows.Forms.ToolTip toolTip_Ders_Kayit;
        private System.Windows.Forms.ErrorProvider errorProvider_Ders_Kayit;

    }
}