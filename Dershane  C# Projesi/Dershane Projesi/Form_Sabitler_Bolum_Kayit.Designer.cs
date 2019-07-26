namespace WindowsFormsApplication1
{
    partial class Form_Sabitler_Bolum_Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sabitler_Bolum_Kayit));
            this.button_Bolum_Sil = new System.Windows.Forms.Button();
            this.button_Yeni_Kayit = new System.Windows.Forms.Button();
            this.button_Bolum_Kaydet = new System.Windows.Forms.Button();
            this.dataGridView_Bolum_Kayit = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Bolum_Aciklama = new System.Windows.Forms.TextBox();
            this.textBox_Bolum_Adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Kayit_Listele = new System.Windows.Forms.Button();
            this.toolTip_Bolum_Kayit = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_Bolum_Kayit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bolum_Kayit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Bolum_Kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Bolum_Sil
            // 
            this.button_Bolum_Sil.Image = global::WindowsFormsApplication1.Properties.Resources.sil;
            this.button_Bolum_Sil.Location = new System.Drawing.Point(379, 54);
            this.button_Bolum_Sil.Name = "button_Bolum_Sil";
            this.button_Bolum_Sil.Size = new System.Drawing.Size(43, 37);
            this.button_Bolum_Sil.TabIndex = 5;
            this.button_Bolum_Sil.UseVisualStyleBackColor = true;
            this.button_Bolum_Sil.Click += new System.EventHandler(this.button_Bolum_Sil_Click);
            // 
            // button_Yeni_Kayit
            // 
            this.button_Yeni_Kayit.Image = global::WindowsFormsApplication1.Properties.Resources.yeni;
            this.button_Yeni_Kayit.Location = new System.Drawing.Point(281, 54);
            this.button_Yeni_Kayit.Name = "button_Yeni_Kayit";
            this.button_Yeni_Kayit.Size = new System.Drawing.Size(43, 37);
            this.button_Yeni_Kayit.TabIndex = 4;
            this.button_Yeni_Kayit.UseVisualStyleBackColor = true;
            this.button_Yeni_Kayit.Click += new System.EventHandler(this.button_Yeni_Kayit_Click);
            // 
            // button_Bolum_Kaydet
            // 
            this.button_Bolum_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Bolum_Kaydet.Image")));
            this.button_Bolum_Kaydet.Location = new System.Drawing.Point(330, 54);
            this.button_Bolum_Kaydet.Name = "button_Bolum_Kaydet";
            this.button_Bolum_Kaydet.Size = new System.Drawing.Size(43, 37);
            this.button_Bolum_Kaydet.TabIndex = 3;
            this.button_Bolum_Kaydet.UseVisualStyleBackColor = true;
            this.button_Bolum_Kaydet.Click += new System.EventHandler(this.button_Bolum_Kaydet_Click);
            // 
            // dataGridView_Bolum_Kayit
            // 
            this.dataGridView_Bolum_Kayit.AllowUserToAddRows = false;
            this.dataGridView_Bolum_Kayit.AllowUserToDeleteRows = false;
            this.dataGridView_Bolum_Kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bolum_Kayit.Location = new System.Drawing.Point(7, 131);
            this.dataGridView_Bolum_Kayit.Name = "dataGridView_Bolum_Kayit";
            this.dataGridView_Bolum_Kayit.ReadOnly = true;
            this.dataGridView_Bolum_Kayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Bolum_Kayit.Size = new System.Drawing.Size(415, 196);
            this.dataGridView_Bolum_Kayit.TabIndex = 27;
            this.dataGridView_Bolum_Kayit.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Bolum_Kayit_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 39);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(87, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "        Bölüm Kayıt Modülü        ";
            // 
            // textBox_Bolum_Aciklama
            // 
            this.textBox_Bolum_Aciklama.Location = new System.Drawing.Point(100, 99);
            this.textBox_Bolum_Aciklama.Name = "textBox_Bolum_Aciklama";
            this.textBox_Bolum_Aciklama.Size = new System.Drawing.Size(166, 20);
            this.textBox_Bolum_Aciklama.TabIndex = 2;
            // 
            // textBox_Bolum_Adi
            // 
            this.textBox_Bolum_Adi.Location = new System.Drawing.Point(100, 62);
            this.textBox_Bolum_Adi.Name = "textBox_Bolum_Adi";
            this.textBox_Bolum_Adi.Size = new System.Drawing.Size(117, 20);
            this.textBox_Bolum_Adi.TabIndex = 1;
            this.textBox_Bolum_Adi.Leave += new System.EventHandler(this.textBox_Bolum_Adi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Adı :";
            // 
            // button_Kayit_Listele
            // 
            this.button_Kayit_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kayit_Listele.Location = new System.Drawing.Point(305, 99);
            this.button_Kayit_Listele.Name = "button_Kayit_Listele";
            this.button_Kayit_Listele.Size = new System.Drawing.Size(92, 26);
            this.button_Kayit_Listele.TabIndex = 0;
            this.button_Kayit_Listele.Text = "Listele";
            this.button_Kayit_Listele.UseVisualStyleBackColor = true;
            this.button_Kayit_Listele.Click += new System.EventHandler(this.button_Kayit_Listele_Click);
            // 
            // errorProvider_Bolum_Kayit
            // 
            this.errorProvider_Bolum_Kayit.ContainerControl = this;
            // 
            // Form_Sabitler_Bolum_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 331);
            this.Controls.Add(this.button_Kayit_Listele);
            this.Controls.Add(this.button_Bolum_Sil);
            this.Controls.Add(this.button_Yeni_Kayit);
            this.Controls.Add(this.button_Bolum_Kaydet);
            this.Controls.Add(this.dataGridView_Bolum_Kayit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Bolum_Aciklama);
            this.Controls.Add(this.textBox_Bolum_Adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Sabitler_Bolum_Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölüm Kayıt";
            this.Load += new System.EventHandler(this.Form_Sabitler_Bolum_Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bolum_Kayit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Bolum_Kayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Bolum_Sil;
        private System.Windows.Forms.Button button_Yeni_Kayit;
        private System.Windows.Forms.Button button_Bolum_Kaydet;
        private System.Windows.Forms.DataGridView dataGridView_Bolum_Kayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Bolum_Aciklama;
        private System.Windows.Forms.TextBox textBox_Bolum_Adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Kayit_Listele;
        private System.Windows.Forms.ToolTip toolTip_Bolum_Kayit;
        private System.Windows.Forms.ErrorProvider errorProvider_Bolum_Kayit;

    }
}