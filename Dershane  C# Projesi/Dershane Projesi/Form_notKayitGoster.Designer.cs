namespace Dershane_Projesi
{
    partial class Form_notKayitGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_notKayitGoster));
            this.dataGridView_Not_Kayit_Listele = new System.Windows.Forms.DataGridView();
            this.toolTip_Not_Kayit_Listesi = new System.Windows.Forms.ToolTip(this.components);
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Duzenle = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Not_Kayit_Listele)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Not_Kayit_Listele
            // 
            this.dataGridView_Not_Kayit_Listele.AllowUserToAddRows = false;
            this.dataGridView_Not_Kayit_Listele.AllowUserToDeleteRows = false;
            this.dataGridView_Not_Kayit_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Not_Kayit_Listele.Location = new System.Drawing.Point(12, 44);
            this.dataGridView_Not_Kayit_Listele.Name = "dataGridView_Not_Kayit_Listele";
            this.dataGridView_Not_Kayit_Listele.ReadOnly = true;
            this.dataGridView_Not_Kayit_Listele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Not_Kayit_Listele.Size = new System.Drawing.Size(524, 233);
            this.dataGridView_Not_Kayit_Listele.TabIndex = 2;
            this.dataGridView_Not_Kayit_Listele.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Not_Kayit_Listele_CellMouseDoubleClick);
            // 
            // button_Sil
            // 
            this.button_Sil.FlatAppearance.BorderSize = 0;
            this.button_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sil.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Sil.Image")));
            this.button_Sil.Location = new System.Drawing.Point(547, 157);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(62, 64);
            this.button_Sil.TabIndex = 38;
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Duzenle
            // 
            this.button_Duzenle.FlatAppearance.BorderSize = 0;
            this.button_Duzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Duzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Duzenle.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Duzenle.Image = ((System.Drawing.Image)(resources.GetObject("button_Duzenle.Image")));
            this.button_Duzenle.Location = new System.Drawing.Point(547, 87);
            this.button_Duzenle.Name = "button_Duzenle";
            this.button_Duzenle.Size = new System.Drawing.Size(62, 64);
            this.button_Duzenle.TabIndex = 37;
            this.button_Duzenle.UseVisualStyleBackColor = true;
            this.button_Duzenle.Click += new System.EventHandler(this.button_Duzenle_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(21, 19);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(517, 13);
            this.label47.TabIndex = 39;
            this.label47.Text = "Not Bilgi _______________________________________________________________________" +
    "_______";
            // 
            // Form_notKayitGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(627, 289);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Duzenle);
            this.Controls.Add(this.dataGridView_Not_Kayit_Listele);
            this.Name = "Form_notKayitGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Kayıt Göster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_notKayitGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Not_Kayit_Listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_Not_Kayit_Listele;
        private System.Windows.Forms.ToolTip toolTip_Not_Kayit_Listesi;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Duzenle;
        private System.Windows.Forms.Label label47;
    }
}