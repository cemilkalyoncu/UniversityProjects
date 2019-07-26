namespace Dershane_Projesi
{
    partial class Form_Kullanici_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kullanici_Giris));
            this.button_Vazgec = new System.Windows.Forms.Button();
            this.textBox_Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Kullanici_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider_Kullanici_Giris = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Giris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Kullanici_Giris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Vazgec
            // 
            this.button_Vazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Vazgec.FlatAppearance.BorderSize = 0;
            this.button_Vazgec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Vazgec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Vazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Vazgec.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Vazgec.Image = ((System.Drawing.Image)(resources.GetObject("button_Vazgec.Image")));
            this.button_Vazgec.Location = new System.Drawing.Point(182, 179);
            this.button_Vazgec.Name = "button_Vazgec";
            this.button_Vazgec.Size = new System.Drawing.Size(62, 64);
            this.button_Vazgec.TabIndex = 3;
            this.button_Vazgec.UseVisualStyleBackColor = true;
            this.button_Vazgec.Click += new System.EventHandler(this.button_Vazgec_Click);
            // 
            // textBox_Kullanici_Adi
            // 
            this.textBox_Kullanici_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kullanici_Adi.Location = new System.Drawing.Point(132, 119);
            this.textBox_Kullanici_Adi.Name = "textBox_Kullanici_Adi";
            this.textBox_Kullanici_Adi.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kullanici_Adi.TabIndex = 0;
            this.textBox_Kullanici_Adi.Enter += new System.EventHandler(this.textBox_Kullanici_Adi_Enter);
            this.textBox_Kullanici_Adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Kullanici_Adi_KeyDown);
            this.textBox_Kullanici_Adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kullanici_Adi_KeyPress);
            this.textBox_Kullanici_Adi.Leave += new System.EventHandler(this.textbox_Kullanici_Adi_Leave);
            // 
            // textBox_Kullanici_Sifre
            // 
            this.textBox_Kullanici_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kullanici_Sifre.Location = new System.Drawing.Point(132, 147);
            this.textBox_Kullanici_Sifre.Name = "textBox_Kullanici_Sifre";
            this.textBox_Kullanici_Sifre.PasswordChar = '*';
            this.textBox_Kullanici_Sifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kullanici_Sifre.TabIndex = 1;
            this.textBox_Kullanici_Sifre.Enter += new System.EventHandler(this.textBox_Kullanici_Sifre_Enter);
            this.textBox_Kullanici_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Kullanici_Adi_KeyPress);
            this.textBox_Kullanici_Sifre.Leave += new System.EventHandler(this.textbox_Kullanici_Sifre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(36, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parola :";
            // 
            // errorProvider_Kullanici_Giris
            // 
            this.errorProvider_Kullanici_Giris.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_Giris
            // 
            this.button_Giris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Giris.FlatAppearance.BorderSize = 0;
            this.button_Giris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Giris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Giris.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Giris.Image = ((System.Drawing.Image)(resources.GetObject("button_Giris.Image")));
            this.button_Giris.Location = new System.Drawing.Point(88, 179);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(62, 64);
            this.button_Giris.TabIndex = 2;
            this.button_Giris.UseVisualStyleBackColor = true;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // Form_Kullanici_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_Vazgec;
            this.ClientSize = new System.Drawing.Size(281, 255);
            this.ControlBox = false;
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Kullanici_Sifre);
            this.Controls.Add(this.textBox_Kullanici_Adi);
            this.Controls.Add(this.button_Vazgec);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Kullanici_Giris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Kullanici_Giris_FormClosing);
            this.Load += new System.EventHandler(this.Form_kullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Kullanici_Giris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Vazgec;
        private System.Windows.Forms.TextBox textBox_Kullanici_Adi;
        private System.Windows.Forms.TextBox textBox_Kullanici_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider_Kullanici_Giris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Giris;
    }
}

