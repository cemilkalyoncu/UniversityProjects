namespace WindowsFormsApplication1
{
    partial class Form_Sabitler_Sinif_Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sabitler_Sinif_Kayit));
            this.button_Sinif_Sil = new System.Windows.Forms.Button();
            this.button_Yeni_Sinif = new System.Windows.Forms.Button();
            this.button_Sinif_Kaydet = new System.Windows.Forms.Button();
            this.dataGridView_Sinif_Kayit = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Sinif_Aciklama = new System.Windows.Forms.TextBox();
            this.textBox_Sinif_Adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Kayit_Listele = new System.Windows.Forms.Button();
            this.toolTip_Sinif_Kaydi = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_Sinif_Kayit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sinif_Kayit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Sinif_Kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Sinif_Sil
            // 
            this.button_Sinif_Sil.Image = global::WindowsFormsApplication1.Properties.Resources.sil;
            this.button_Sinif_Sil.Location = new System.Drawing.Point(379, 53);
            this.button_Sinif_Sil.Name = "button_Sinif_Sil";
            this.button_Sinif_Sil.Size = new System.Drawing.Size(43, 37);
            this.button_Sinif_Sil.TabIndex = 5;
            this.button_Sinif_Sil.UseVisualStyleBackColor = true;
            this.button_Sinif_Sil.Click += new System.EventHandler(this.button_Sinif_Sil_Click);
            // 
            // button_Yeni_Sinif
            // 
            this.button_Yeni_Sinif.Image = global::WindowsFormsApplication1.Properties.Resources.yeni;
            this.button_Yeni_Sinif.Location = new System.Drawing.Point(281, 54);
            this.button_Yeni_Sinif.Name = "button_Yeni_Sinif";
            this.button_Yeni_Sinif.Size = new System.Drawing.Size(43, 37);
            this.button_Yeni_Sinif.TabIndex = 4;
            this.button_Yeni_Sinif.UseVisualStyleBackColor = true;
            this.button_Yeni_Sinif.Click += new System.EventHandler(this.button_Yeni_Sinif_Click);
            // 
            // button_Sinif_Kaydet
            // 
            this.button_Sinif_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Sinif_Kaydet.Image")));
            this.button_Sinif_Kaydet.Location = new System.Drawing.Point(330, 54);
            this.button_Sinif_Kaydet.Name = "button_Sinif_Kaydet";
            this.button_Sinif_Kaydet.Size = new System.Drawing.Size(43, 37);
            this.button_Sinif_Kaydet.TabIndex = 3;
            this.button_Sinif_Kaydet.UseVisualStyleBackColor = true;
            this.button_Sinif_Kaydet.Click += new System.EventHandler(this.button_Sinif_Kaydet_Click);
            // 
            // dataGridView_Sinif_Kayit
            // 
            this.dataGridView_Sinif_Kayit.AllowUserToAddRows = false;
            this.dataGridView_Sinif_Kayit.AllowUserToDeleteRows = false;
            this.dataGridView_Sinif_Kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sinif_Kayit.Location = new System.Drawing.Point(7, 129);
            this.dataGridView_Sinif_Kayit.Name = "dataGridView_Sinif_Kayit";
            this.dataGridView_Sinif_Kayit.ReadOnly = true;
            this.dataGridView_Sinif_Kayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Sinif_Kayit.Size = new System.Drawing.Size(415, 198);
            this.dataGridView_Sinif_Kayit.TabIndex = 27;
            this.dataGridView_Sinif_Kayit.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Sinif_Kayit_CellMouseDoubleClick);
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
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "        Sınıf Kayıt Modülü        ";
            // 
            // textBox_Sinif_Aciklama
            // 
            this.textBox_Sinif_Aciklama.Location = new System.Drawing.Point(99, 90);
            this.textBox_Sinif_Aciklama.Name = "textBox_Sinif_Aciklama";
            this.textBox_Sinif_Aciklama.Size = new System.Drawing.Size(163, 20);
            this.textBox_Sinif_Aciklama.TabIndex = 2;
            // 
            // textBox_Sinif_Adi
            // 
            this.textBox_Sinif_Adi.Location = new System.Drawing.Point(99, 53);
            this.textBox_Sinif_Adi.Name = "textBox_Sinif_Adi";
            this.textBox_Sinif_Adi.Size = new System.Drawing.Size(127, 20);
            this.textBox_Sinif_Adi.TabIndex = 1;
            this.textBox_Sinif_Adi.Leave += new System.EventHandler(this.textBox_Sinif_Adi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Adı :";
            // 
            // button_Kayit_Listele
            // 
            this.button_Kayit_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kayit_Listele.Location = new System.Drawing.Point(301, 97);
            this.button_Kayit_Listele.Name = "button_Kayit_Listele";
            this.button_Kayit_Listele.Size = new System.Drawing.Size(92, 26);
            this.button_Kayit_Listele.TabIndex = 0;
            this.button_Kayit_Listele.Text = "Listele";
            this.button_Kayit_Listele.UseVisualStyleBackColor = true;
            this.button_Kayit_Listele.Click += new System.EventHandler(this.button_Kayit_Listele_Click);
            // 
            // errorProvider_Sinif_Kayit
            // 
            this.errorProvider_Sinif_Kayit.ContainerControl = this;
            // 
            // Form_Sabitler_Sinif_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 331);
            this.Controls.Add(this.button_Kayit_Listele);
            this.Controls.Add(this.button_Sinif_Sil);
            this.Controls.Add(this.button_Yeni_Sinif);
            this.Controls.Add(this.button_Sinif_Kaydet);
            this.Controls.Add(this.dataGridView_Sinif_Kayit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Sinif_Aciklama);
            this.Controls.Add(this.textBox_Sinif_Adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Sabitler_Sinif_Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Sabitler_Sinif_Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sinif_Kayit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Sinif_Kayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Sinif_Sil;
        private System.Windows.Forms.Button button_Yeni_Sinif;
        private System.Windows.Forms.Button button_Sinif_Kaydet;
        private System.Windows.Forms.DataGridView dataGridView_Sinif_Kayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Sinif_Aciklama;
        private System.Windows.Forms.TextBox textBox_Sinif_Adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Kayit_Listele;
        private System.Windows.Forms.ToolTip toolTip_Sinif_Kaydi;
        private System.Windows.Forms.ErrorProvider errorProvider_Sinif_Kayit;

    }
}