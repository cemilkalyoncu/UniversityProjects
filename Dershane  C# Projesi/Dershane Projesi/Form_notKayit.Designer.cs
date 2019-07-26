namespace Dershane_Projesi
{
    partial class Form_notKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_notKayit));
            this.button_Not_Kayit_Ekle = new System.Windows.Forms.Button();
            this.button_Not_Kayit_Goster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Not_Kayit_Ekle
            // 
            this.button_Not_Kayit_Ekle.BackColor = System.Drawing.Color.Transparent;
            this.button_Not_Kayit_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Not_Kayit_Ekle.FlatAppearance.BorderSize = 0;
            this.button_Not_Kayit_Ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Not_Kayit_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Not_Kayit_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Not_Kayit_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Not_Kayit_Ekle.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Not_Kayit_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_Not_Kayit_Ekle.Image")));
            this.button_Not_Kayit_Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Not_Kayit_Ekle.Location = new System.Drawing.Point(67, 112);
            this.button_Not_Kayit_Ekle.Name = "button_Not_Kayit_Ekle";
            this.button_Not_Kayit_Ekle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Not_Kayit_Ekle.Size = new System.Drawing.Size(151, 42);
            this.button_Not_Kayit_Ekle.TabIndex = 1;
            this.button_Not_Kayit_Ekle.Text = "                 Not Kayıt Ekle";
            this.button_Not_Kayit_Ekle.UseVisualStyleBackColor = false;
            this.button_Not_Kayit_Ekle.Click += new System.EventHandler(this.button_Ogrenci_Grup_Kayit_Click);
            // 
            // button_Not_Kayit_Goster
            // 
            this.button_Not_Kayit_Goster.BackColor = System.Drawing.Color.Transparent;
            this.button_Not_Kayit_Goster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Not_Kayit_Goster.FlatAppearance.BorderSize = 0;
            this.button_Not_Kayit_Goster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Not_Kayit_Goster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Not_Kayit_Goster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Not_Kayit_Goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Not_Kayit_Goster.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Not_Kayit_Goster.Image = ((System.Drawing.Image)(resources.GetObject("button_Not_Kayit_Goster.Image")));
            this.button_Not_Kayit_Goster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Not_Kayit_Goster.Location = new System.Drawing.Point(67, 207);
            this.button_Not_Kayit_Goster.Name = "button_Not_Kayit_Goster";
            this.button_Not_Kayit_Goster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Not_Kayit_Goster.Size = new System.Drawing.Size(151, 42);
            this.button_Not_Kayit_Goster.TabIndex = 2;
            this.button_Not_Kayit_Goster.Text = "             Not Kayıt Göster";
            this.button_Not_Kayit_Goster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Not_Kayit_Goster.UseVisualStyleBackColor = false;
            this.button_Not_Kayit_Goster.Click += new System.EventHandler(this.button_Not_Kayit_Goster_Click);
            // 
            // Form_notKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(740, 351);
            this.Controls.Add(this.button_Not_Kayit_Goster);
            this.Controls.Add(this.button_Not_Kayit_Ekle);
            this.Name = "Form_notKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Kayıt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button_Not_Kayit_Ekle;
        public System.Windows.Forms.Button button_Not_Kayit_Goster;
    }
}