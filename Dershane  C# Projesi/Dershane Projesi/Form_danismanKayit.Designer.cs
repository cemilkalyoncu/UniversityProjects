namespace Dershane_Projesi
{
    partial class Form_danismanKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_danismanKayit));
            this.groupBox_Ogrenci_Bolum_Kayit = new System.Windows.Forms.GroupBox();
            this.comboBox_Danisman_Girdigi_Ders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Danisman_Sil = new System.Windows.Forms.Button();
            this.button_Danisman_Yeni_Kayit = new System.Windows.Forms.Button();
            this.button_Danisman_Kaydet = new System.Windows.Forms.Button();
            this.button_Danisman_Kayit_Listele = new System.Windows.Forms.Button();
            this.textBox_Danisman_Adi_Soyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip_Danisman_Kayit = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_Danisman_Kayit = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_Danisman_Kayit = new System.Windows.Forms.DataGridView();
            this.groupBox_Ogrenci_Bolum_Kayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Danisman_Kayit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Danisman_Kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Ogrenci_Bolum_Kayit
            // 
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.comboBox_Danisman_Girdigi_Ders);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.label2);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Danisman_Sil);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Danisman_Yeni_Kayit);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Danisman_Kaydet);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.button_Danisman_Kayit_Listele);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.textBox_Danisman_Adi_Soyadi);
            this.groupBox_Ogrenci_Bolum_Kayit.Controls.Add(this.label1);
            this.groupBox_Ogrenci_Bolum_Kayit.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox_Ogrenci_Bolum_Kayit.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Ogrenci_Bolum_Kayit.Name = "groupBox_Ogrenci_Bolum_Kayit";
            this.groupBox_Ogrenci_Bolum_Kayit.Size = new System.Drawing.Size(475, 163);
            this.groupBox_Ogrenci_Bolum_Kayit.TabIndex = 7;
            this.groupBox_Ogrenci_Bolum_Kayit.TabStop = false;
            this.groupBox_Ogrenci_Bolum_Kayit.Text = "Danışman Kayıt";
            // 
            // comboBox_Danisman_Girdigi_Ders
            // 
            this.comboBox_Danisman_Girdigi_Ders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Danisman_Girdigi_Ders.FormattingEnabled = true;
            this.comboBox_Danisman_Girdigi_Ders.Location = new System.Drawing.Point(87, 54);
            this.comboBox_Danisman_Girdigi_Ders.Name = "comboBox_Danisman_Girdigi_Ders";
            this.comboBox_Danisman_Girdigi_Ders.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Danisman_Girdigi_Ders.TabIndex = 45;
            this.comboBox_Danisman_Girdigi_Ders.Enter += new System.EventHandler(this.textBox_Danisman_Adi_Soyadi_Enter);
            this.comboBox_Danisman_Girdigi_Ders.Leave += new System.EventHandler(this.comboBox_Danisman_Girdigi_Ders_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Girdiği Ders:";
            // 
            // button_Danisman_Sil
            // 
            this.button_Danisman_Sil.FlatAppearance.BorderSize = 0;
            this.button_Danisman_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Danisman_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Danisman_Sil.Image")));
            this.button_Danisman_Sil.Location = new System.Drawing.Point(407, 19);
            this.button_Danisman_Sil.Name = "button_Danisman_Sil";
            this.button_Danisman_Sil.Size = new System.Drawing.Size(62, 64);
            this.button_Danisman_Sil.TabIndex = 4;
            this.button_Danisman_Sil.UseVisualStyleBackColor = true;
            this.button_Danisman_Sil.Click += new System.EventHandler(this.button_Danisman_Sil_Click);
            // 
            // button_Danisman_Yeni_Kayit
            // 
            this.button_Danisman_Yeni_Kayit.FlatAppearance.BorderSize = 0;
            this.button_Danisman_Yeni_Kayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Yeni_Kayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Yeni_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Danisman_Yeni_Kayit.Image = ((System.Drawing.Image)(resources.GetObject("button_Danisman_Yeni_Kayit.Image")));
            this.button_Danisman_Yeni_Kayit.Location = new System.Drawing.Point(271, 19);
            this.button_Danisman_Yeni_Kayit.Name = "button_Danisman_Yeni_Kayit";
            this.button_Danisman_Yeni_Kayit.Size = new System.Drawing.Size(62, 64);
            this.button_Danisman_Yeni_Kayit.TabIndex = 2;
            this.button_Danisman_Yeni_Kayit.UseVisualStyleBackColor = true;
            this.button_Danisman_Yeni_Kayit.Click += new System.EventHandler(this.button_Danisman_Yeni_Kayit_Click);
            // 
            // button_Danisman_Kaydet
            // 
            this.button_Danisman_Kaydet.FlatAppearance.BorderSize = 0;
            this.button_Danisman_Kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Danisman_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Danisman_Kaydet.Image")));
            this.button_Danisman_Kaydet.Location = new System.Drawing.Point(339, 19);
            this.button_Danisman_Kaydet.Name = "button_Danisman_Kaydet";
            this.button_Danisman_Kaydet.Size = new System.Drawing.Size(62, 64);
            this.button_Danisman_Kaydet.TabIndex = 3;
            this.button_Danisman_Kaydet.UseVisualStyleBackColor = true;
            this.button_Danisman_Kaydet.Click += new System.EventHandler(this.button_Danisman_Kaydet_Click);
            // 
            // button_Danisman_Kayit_Listele
            // 
            this.button_Danisman_Kayit_Listele.FlatAppearance.BorderSize = 0;
            this.button_Danisman_Kayit_Listele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Kayit_Listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Danisman_Kayit_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Danisman_Kayit_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Danisman_Kayit_Listele.ForeColor = System.Drawing.Color.Black;
            this.button_Danisman_Kayit_Listele.Image = ((System.Drawing.Image)(resources.GetObject("button_Danisman_Kayit_Listele.Image")));
            this.button_Danisman_Kayit_Listele.Location = new System.Drawing.Point(325, 89);
            this.button_Danisman_Kayit_Listele.Name = "button_Danisman_Kayit_Listele";
            this.button_Danisman_Kayit_Listele.Size = new System.Drawing.Size(89, 64);
            this.button_Danisman_Kayit_Listele.TabIndex = 5;
            this.button_Danisman_Kayit_Listele.UseVisualStyleBackColor = true;
            this.button_Danisman_Kayit_Listele.Click += new System.EventHandler(this.button_Danisman_Kayit_Listele_Click);
            // 
            // textBox_Danisman_Adi_Soyadi
            // 
            this.textBox_Danisman_Adi_Soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Danisman_Adi_Soyadi.Location = new System.Drawing.Point(87, 28);
            this.textBox_Danisman_Adi_Soyadi.Name = "textBox_Danisman_Adi_Soyadi";
            this.textBox_Danisman_Adi_Soyadi.Size = new System.Drawing.Size(156, 20);
            this.textBox_Danisman_Adi_Soyadi.TabIndex = 0;
            this.textBox_Danisman_Adi_Soyadi.Enter += new System.EventHandler(this.textBox_Danisman_Adi_Soyadi_Enter);
            this.textBox_Danisman_Adi_Soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Danisman_Adi_Soyadi_KeyPress);
            this.textBox_Danisman_Adi_Soyadi.Leave += new System.EventHandler(this.textBox_Danisman_Adi_Soyadi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Adı Soyadi:";
            // 
            // errorProvider_Danisman_Kayit
            // 
            this.errorProvider_Danisman_Kayit.ContainerControl = this;
            // 
            // dataGridView_Danisman_Kayit
            // 
            this.dataGridView_Danisman_Kayit.AllowUserToAddRows = false;
            this.dataGridView_Danisman_Kayit.AllowUserToDeleteRows = false;
            this.dataGridView_Danisman_Kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Danisman_Kayit.Location = new System.Drawing.Point(12, 181);
            this.dataGridView_Danisman_Kayit.Name = "dataGridView_Danisman_Kayit";
            this.dataGridView_Danisman_Kayit.ReadOnly = true;
            this.dataGridView_Danisman_Kayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Danisman_Kayit.Size = new System.Drawing.Size(475, 165);
            this.dataGridView_Danisman_Kayit.TabIndex = 8;
            this.dataGridView_Danisman_Kayit.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Bolum_Kayit_CellMouseDoubleClick);
            // 
            // Form_danismanKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(499, 358);
            this.Controls.Add(this.dataGridView_Danisman_Kayit);
            this.Controls.Add(this.groupBox_Ogrenci_Bolum_Kayit);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form_danismanKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danışman Bilgi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_danismanKayit_FormClosing);
            this.Load += new System.EventHandler(this.Form_danismanEkle_Load);
            this.groupBox_Ogrenci_Bolum_Kayit.ResumeLayout(false);
            this.groupBox_Ogrenci_Bolum_Kayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Danisman_Kayit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Danisman_Kayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Ogrenci_Bolum_Kayit;
        private System.Windows.Forms.Button button_Danisman_Sil;
        private System.Windows.Forms.Button button_Danisman_Yeni_Kayit;
        private System.Windows.Forms.Button button_Danisman_Kaydet;
        private System.Windows.Forms.Button button_Danisman_Kayit_Listele;
        private System.Windows.Forms.TextBox textBox_Danisman_Adi_Soyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip_Danisman_Kayit;
        private System.Windows.Forms.ErrorProvider errorProvider_Danisman_Kayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Danisman_Girdigi_Ders;
        private System.Windows.Forms.DataGridView dataGridView_Danisman_Kayit;

    }
}