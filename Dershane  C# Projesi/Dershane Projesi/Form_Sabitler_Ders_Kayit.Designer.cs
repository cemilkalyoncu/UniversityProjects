namespace WindowsFormsApplication1
{
    partial class Form_Sabitler_Ders_Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sabitler_Ders_Kayit));
            this.button_Kayit_Listele = new System.Windows.Forms.Button();
            this.dataGridView_Ders_Kayit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ders_Aciklama = new System.Windows.Forms.TextBox();
            this.textBox_Ders_Adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip_Ders_Kayit = new System.Windows.Forms.ToolTip(this.components);
            this.button_Ders_Sil = new System.Windows.Forms.Button();
            this.button_Ders_Yeni_Kayit = new System.Windows.Forms.Button();
            this.button_Ders_Kaydet = new System.Windows.Forms.Button();
            this.errorProvider_Ders_Kayit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ders_Kayit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Ders_Kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Kayit_Listele
            // 
            this.button_Kayit_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kayit_Listele.Location = new System.Drawing.Point(303, 95);
            this.button_Kayit_Listele.Name = "button_Kayit_Listele";
            this.button_Kayit_Listele.Size = new System.Drawing.Size(92, 26);
            this.button_Kayit_Listele.TabIndex = 0;
            this.button_Kayit_Listele.Text = "Listele";
            this.button_Kayit_Listele.UseVisualStyleBackColor = true;
            this.button_Kayit_Listele.Click += new System.EventHandler(this.button_Kayit_Listele_Click);
            // 
            // dataGridView_Ders_Kayit
            // 
            this.dataGridView_Ders_Kayit.AllowUserToAddRows = false;
            this.dataGridView_Ders_Kayit.AllowUserToDeleteRows = false;
            this.dataGridView_Ders_Kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ders_Kayit.Location = new System.Drawing.Point(6, 127);
            this.dataGridView_Ders_Kayit.Name = "dataGridView_Ders_Kayit";
            this.dataGridView_Ders_Kayit.ReadOnly = true;
            this.dataGridView_Ders_Kayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Ders_Kayit.Size = new System.Drawing.Size(415, 197);
            this.dataGridView_Ders_Kayit.TabIndex = 38;
            this.dataGridView_Ders_Kayit.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Ders_Kayit_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ders Adı :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 39);
            this.panel1.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(79, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "        Ders Kayıt Modülü        ";
            // 
            // textBox_Ders_Aciklama
            // 
            this.textBox_Ders_Aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Ders_Aciklama.Location = new System.Drawing.Point(91, 95);
            this.textBox_Ders_Aciklama.Name = "textBox_Ders_Aciklama";
            this.textBox_Ders_Aciklama.Size = new System.Drawing.Size(176, 20);
            this.textBox_Ders_Aciklama.TabIndex = 2;
            // 
            // textBox_Ders_Adi
            // 
            this.textBox_Ders_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Ders_Adi.Location = new System.Drawing.Point(91, 58);
            this.textBox_Ders_Adi.Name = "textBox_Ders_Adi";
            this.textBox_Ders_Adi.Size = new System.Drawing.Size(117, 20);
            this.textBox_Ders_Adi.TabIndex = 1;
            this.textBox_Ders_Adi.Leave += new System.EventHandler(this.textBox_Ders_Adi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Açıklama :";
            // 
            // button_Ders_Sil
            // 
            this.button_Ders_Sil.Image = global::WindowsFormsApplication1.Properties.Resources.sil;
            this.button_Ders_Sil.Location = new System.Drawing.Point(378, 51);
            this.button_Ders_Sil.Name = "button_Ders_Sil";
            this.button_Ders_Sil.Size = new System.Drawing.Size(43, 37);
            this.button_Ders_Sil.TabIndex = 5;
            this.button_Ders_Sil.UseVisualStyleBackColor = true;
            this.button_Ders_Sil.Click += new System.EventHandler(this.button_Ders_Sil_Click);
            // 
            // button_Ders_Yeni_Kayit
            // 
            this.button_Ders_Yeni_Kayit.Image = global::WindowsFormsApplication1.Properties.Resources.yeni;
            this.button_Ders_Yeni_Kayit.Location = new System.Drawing.Point(280, 50);
            this.button_Ders_Yeni_Kayit.Name = "button_Ders_Yeni_Kayit";
            this.button_Ders_Yeni_Kayit.Size = new System.Drawing.Size(43, 37);
            this.button_Ders_Yeni_Kayit.TabIndex = 4;
            this.button_Ders_Yeni_Kayit.UseVisualStyleBackColor = true;
            this.button_Ders_Yeni_Kayit.Click += new System.EventHandler(this.button_Ders_Yeni_Kayit_Click);
            // 
            // button_Ders_Kaydet
            // 
            this.button_Ders_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_Ders_Kaydet.Image")));
            this.button_Ders_Kaydet.Location = new System.Drawing.Point(329, 50);
            this.button_Ders_Kaydet.Name = "button_Ders_Kaydet";
            this.button_Ders_Kaydet.Size = new System.Drawing.Size(43, 37);
            this.button_Ders_Kaydet.TabIndex = 3;
            this.button_Ders_Kaydet.UseVisualStyleBackColor = true;
            this.button_Ders_Kaydet.Click += new System.EventHandler(this.button_Ders_Kaydet_Click);
            // 
            // errorProvider_Ders_Kayit
            // 
            this.errorProvider_Ders_Kayit.ContainerControl = this;
            // 
            // Form_Sabitler_Ders_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 329);
            this.Controls.Add(this.button_Kayit_Listele);
            this.Controls.Add(this.button_Ders_Sil);
            this.Controls.Add(this.button_Ders_Yeni_Kayit);
            this.Controls.Add(this.button_Ders_Kaydet);
            this.Controls.Add(this.dataGridView_Ders_Kayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Ders_Aciklama);
            this.Controls.Add(this.textBox_Ders_Adi);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Sabitler_Ders_Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Sabitler_Ders_Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ders_Kayit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Ders_Kayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Kayit_Listele;
        private System.Windows.Forms.Button button_Ders_Sil;
        private System.Windows.Forms.Button button_Ders_Yeni_Kayit;
        private System.Windows.Forms.Button button_Ders_Kaydet;
        private System.Windows.Forms.DataGridView dataGridView_Ders_Kayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ders_Aciklama;
        private System.Windows.Forms.TextBox textBox_Ders_Adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip_Ders_Kayit;
        private System.Windows.Forms.ErrorProvider errorProvider_Ders_Kayit;
    }
}