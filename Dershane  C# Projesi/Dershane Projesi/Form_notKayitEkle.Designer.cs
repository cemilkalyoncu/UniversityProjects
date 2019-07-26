namespace Dershane_Projesi
{
    partial class Form_notKayitEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_notKayitEkle));
            this.errorProvider_Not_Kayit = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_Not_Kayit = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView_Not_Kayit_Ekle = new System.Windows.Forms.DataGridView();
            this.richTextBox_Not_Kayit_Hatirlatma = new System.Windows.Forms.RichTextBox();
            this.groupBox_Not_Kayit = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Hatırlatma = new System.Windows.Forms.GroupBox();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Yeni_Not = new System.Windows.Forms.Button();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Not_Kayit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Not_Kayit_Ekle)).BeginInit();
            this.groupBox_Not_Kayit.SuspendLayout();
            this.groupBox_Hatırlatma.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider_Not_Kayit
            // 
            this.errorProvider_Not_Kayit.ContainerControl = this;
            // 
            // dataGridView_Not_Kayit_Ekle
            // 
            this.dataGridView_Not_Kayit_Ekle.AllowUserToAddRows = false;
            this.dataGridView_Not_Kayit_Ekle.AllowUserToDeleteRows = false;
            this.dataGridView_Not_Kayit_Ekle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Not_Kayit_Ekle.Location = new System.Drawing.Point(12, 118);
            this.dataGridView_Not_Kayit_Ekle.Name = "dataGridView_Not_Kayit_Ekle";
            this.dataGridView_Not_Kayit_Ekle.ReadOnly = true;
            this.dataGridView_Not_Kayit_Ekle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Not_Kayit_Ekle.Size = new System.Drawing.Size(541, 152);
            this.dataGridView_Not_Kayit_Ekle.TabIndex = 5;
            this.dataGridView_Not_Kayit_Ekle.Visible = false;
            // 
            // richTextBox_Not_Kayit_Hatirlatma
            // 
            this.richTextBox_Not_Kayit_Hatirlatma.BackColor = System.Drawing.Color.White;
            this.richTextBox_Not_Kayit_Hatirlatma.Location = new System.Drawing.Point(19, 19);
            this.richTextBox_Not_Kayit_Hatirlatma.Name = "richTextBox_Not_Kayit_Hatirlatma";
            this.richTextBox_Not_Kayit_Hatirlatma.Size = new System.Drawing.Size(216, 71);
            this.richTextBox_Not_Kayit_Hatirlatma.TabIndex = 4;
            this.richTextBox_Not_Kayit_Hatirlatma.Text = "";
            this.richTextBox_Not_Kayit_Hatirlatma.Enter += new System.EventHandler(this.richTextBox_Not_Kayit_Hatirlatma_Enter);
            this.richTextBox_Not_Kayit_Hatirlatma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_Not_Kayit_Hatirlatma_KeyPress);
            this.richTextBox_Not_Kayit_Hatirlatma.Leave += new System.EventHandler(this.richTextBox_Not_Kayit_Hatirlatma_Leave);
            // 
            // groupBox_Not_Kayit
            // 
            this.groupBox_Not_Kayit.Controls.Add(this.button1);
            this.groupBox_Not_Kayit.Controls.Add(this.button2);
            this.groupBox_Not_Kayit.Controls.Add(this.textBox2);
            this.groupBox_Not_Kayit.Controls.Add(this.textBox1);
            this.groupBox_Not_Kayit.Controls.Add(this.label1);
            this.groupBox_Not_Kayit.Controls.Add(this.label2);
            this.groupBox_Not_Kayit.ForeColor = System.Drawing.Color.White;
            this.groupBox_Not_Kayit.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Not_Kayit.Name = "groupBox_Not_Kayit";
            this.groupBox_Not_Kayit.Size = new System.Drawing.Size(285, 100);
            this.groupBox_Not_Kayit.TabIndex = 0;
            this.groupBox_Not_Kayit.TabStop = false;
            this.groupBox_Not_Kayit.Text = "Not Kayıt";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(187, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 34);
            this.button1.TabIndex = 58;
            this.button1.Text = "Alarm Aç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(187, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 34);
            this.button2.TabIndex = 57;
            this.button2.Text = "Alarm Kapa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Saat";
            // 
            // groupBox_Hatırlatma
            // 
            this.groupBox_Hatırlatma.Controls.Add(this.richTextBox_Not_Kayit_Hatirlatma);
            this.groupBox_Hatırlatma.ForeColor = System.Drawing.Color.White;
            this.groupBox_Hatırlatma.Location = new System.Drawing.Point(303, 12);
            this.groupBox_Hatırlatma.Name = "groupBox_Hatırlatma";
            this.groupBox_Hatırlatma.Size = new System.Drawing.Size(250, 100);
            this.groupBox_Hatırlatma.TabIndex = 1;
            this.groupBox_Hatırlatma.TabStop = false;
            this.groupBox_Hatırlatma.Text = "Hatırlatma";
            // 
            // button_Sil
            // 
            this.button_Sil.FlatAppearance.BorderSize = 0;
            this.button_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sil.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Sil.Image")));
            this.button_Sil.Location = new System.Drawing.Point(318, 118);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(62, 64);
            this.button_Sil.TabIndex = 2;
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Yeni_Not
            // 
            this.button_Yeni_Not.FlatAppearance.BorderSize = 0;
            this.button_Yeni_Not.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Yeni_Not.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Yeni_Not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Yeni_Not.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Yeni_Not.Image = ((System.Drawing.Image)(resources.GetObject("button_Yeni_Not.Image")));
            this.button_Yeni_Not.Location = new System.Drawing.Point(182, 118);
            this.button_Yeni_Not.Name = "button_Yeni_Not";
            this.button_Yeni_Not.Size = new System.Drawing.Size(62, 64);
            this.button_Yeni_Not.TabIndex = 0;
            this.button_Yeni_Not.UseVisualStyleBackColor = true;
            this.button_Yeni_Not.Click += new System.EventHandler(this.button_Yeni_Not_Click);
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.FlatAppearance.BorderSize = 0;
            this.button_Kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kaydet.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Kaydet.Image")));
            this.button_Kaydet.Location = new System.Drawing.Point(250, 118);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(62, 64);
            this.button_Kaydet.TabIndex = 1;
            this.button_Kaydet.UseVisualStyleBackColor = true;
            this.button_Kaydet.Click += new System.EventHandler(this.button_Kaydet_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_notKayitEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(568, 382);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Yeni_Not);
            this.Controls.Add(this.button_Kaydet);
            this.Controls.Add(this.groupBox_Hatırlatma);
            this.Controls.Add(this.groupBox_Not_Kayit);
            this.Controls.Add(this.dataGridView_Not_Kayit_Ekle);
            this.Name = "Form_notKayitEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Kayıt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_notKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Not_Kayit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Not_Kayit_Ekle)).EndInit();
            this.groupBox_Not_Kayit.ResumeLayout(false);
            this.groupBox_Not_Kayit.PerformLayout();
            this.groupBox_Hatırlatma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider_Not_Kayit;
        public System.Windows.Forms.RichTextBox richTextBox_Not_Kayit_Hatirlatma;
        private System.Windows.Forms.DataGridView dataGridView_Not_Kayit_Ekle;
        private System.Windows.Forms.ToolTip toolTip_Not_Kayit;
        private System.Windows.Forms.GroupBox groupBox_Not_Kayit;
        private System.Windows.Forms.GroupBox groupBox_Hatırlatma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Yeni_Not;
        private System.Windows.Forms.Button button_Kaydet;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
    }
}