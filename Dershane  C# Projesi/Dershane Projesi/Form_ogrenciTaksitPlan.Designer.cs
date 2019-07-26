namespace Dershane_Projesi
{
    partial class Form_Ogrenci_Taksit_Plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ogrenci_Taksit_Plan));
            this.dataGridView_Taksit_Plan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Ogrenci_Taksit_Plan_Pesinat = new System.Windows.Forms.TextBox();
            this.button_Ogrenci_Taksit_Temizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Ogrenci_Taksit_Vazgec = new System.Windows.Forms.Button();
            this.comboBox_Ogrenci_Taksit_Adeti = new System.Windows.Forms.ComboBox();
            this.button_Ogrenci_Taksiklendir = new System.Windows.Forms.Button();
            this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Taksit_Plan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Taksit_Plan
            // 
            this.dataGridView_Taksit_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Taksit_Plan.Location = new System.Drawing.Point(317, 12);
            this.dataGridView_Taksit_Plan.Name = "dataGridView_Taksit_Plan";
            this.dataGridView_Taksit_Plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Taksit_Plan.Size = new System.Drawing.Size(475, 221);
            this.dataGridView_Taksit_Plan.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Ogrenci_Taksit_Plan_Pesinat);
            this.groupBox1.Controls.Add(this.button_Ogrenci_Taksit_Temizle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Ogrenci_Taksit_Vazgec);
            this.groupBox1.Controls.Add(this.comboBox_Ogrenci_Taksit_Adeti);
            this.groupBox1.Controls.Add(this.button_Ogrenci_Taksiklendir);
            this.groupBox1.Controls.Add(this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar);
            this.groupBox1.Controls.Add(this.dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 221);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taksit Plan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yıllık Ücret :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Taksitlendirilecek Miktar :";
            // 
            // textBox_Ogrenci_Taksit_Plan_Pesinat
            // 
            this.textBox_Ogrenci_Taksit_Plan_Pesinat.Location = new System.Drawing.Point(168, 23);
            this.textBox_Ogrenci_Taksit_Plan_Pesinat.Name = "textBox_Ogrenci_Taksit_Plan_Pesinat";
            this.textBox_Ogrenci_Taksit_Plan_Pesinat.Size = new System.Drawing.Size(109, 20);
            this.textBox_Ogrenci_Taksit_Plan_Pesinat.TabIndex = 0;
            this.textBox_Ogrenci_Taksit_Plan_Pesinat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ogrenci_Taksit_Plan_Pesinat_KeyPress);
            this.textBox_Ogrenci_Taksit_Plan_Pesinat.Leave += new System.EventHandler(this.textBox_Ogrenci_Taksit_Plan_Pesinat_Leave);
            // 
            // button_Ogrenci_Taksit_Temizle
            // 
            this.button_Ogrenci_Taksit_Temizle.FlatAppearance.BorderSize = 0;
            this.button_Ogrenci_Taksit_Temizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Ogrenci_Taksit_Temizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Ogrenci_Taksit_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ogrenci_Taksit_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ogrenci_Taksit_Temizle.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Ogrenci_Taksit_Temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_Ogrenci_Taksit_Temizle.Image")));
            this.button_Ogrenci_Taksit_Temizle.Location = new System.Drawing.Point(116, 143);
            this.button_Ogrenci_Taksit_Temizle.Name = "button_Ogrenci_Taksit_Temizle";
            this.button_Ogrenci_Taksit_Temizle.Size = new System.Drawing.Size(62, 64);
            this.button_Ogrenci_Taksit_Temizle.TabIndex = 30;
            this.button_Ogrenci_Taksit_Temizle.UseVisualStyleBackColor = true;
            this.button_Ogrenci_Taksit_Temizle.Click += new System.EventHandler(this.button_Ogrenci_Taksit_Temizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Taksit Adeti :";
            // 
            // button_Ogrenci_Taksit_Vazgec
            // 
            this.button_Ogrenci_Taksit_Vazgec.FlatAppearance.BorderSize = 0;
            this.button_Ogrenci_Taksit_Vazgec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Ogrenci_Taksit_Vazgec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Ogrenci_Taksit_Vazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ogrenci_Taksit_Vazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ogrenci_Taksit_Vazgec.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Ogrenci_Taksit_Vazgec.Image = ((System.Drawing.Image)(resources.GetObject("button_Ogrenci_Taksit_Vazgec.Image")));
            this.button_Ogrenci_Taksit_Vazgec.Location = new System.Drawing.Point(184, 143);
            this.button_Ogrenci_Taksit_Vazgec.Name = "button_Ogrenci_Taksit_Vazgec";
            this.button_Ogrenci_Taksit_Vazgec.Size = new System.Drawing.Size(62, 64);
            this.button_Ogrenci_Taksit_Vazgec.TabIndex = 5;
            this.button_Ogrenci_Taksit_Vazgec.UseVisualStyleBackColor = true;
            this.button_Ogrenci_Taksit_Vazgec.Click += new System.EventHandler(this.button_Ogrenci_Taksit_Vazgec_Click);
            // 
            // comboBox_Ogrenci_Taksit_Adeti
            // 
            this.comboBox_Ogrenci_Taksit_Adeti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ogrenci_Taksit_Adeti.FormattingEnabled = true;
            this.comboBox_Ogrenci_Taksit_Adeti.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Ogrenci_Taksit_Adeti.Location = new System.Drawing.Point(168, 79);
            this.comboBox_Ogrenci_Taksit_Adeti.Name = "comboBox_Ogrenci_Taksit_Adeti";
            this.comboBox_Ogrenci_Taksit_Adeti.Size = new System.Drawing.Size(78, 21);
            this.comboBox_Ogrenci_Taksit_Adeti.TabIndex = 2;
            // 
            // button_Ogrenci_Taksiklendir
            // 
            this.button_Ogrenci_Taksiklendir.FlatAppearance.BorderSize = 0;
            this.button_Ogrenci_Taksiklendir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Ogrenci_Taksiklendir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Ogrenci_Taksiklendir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ogrenci_Taksiklendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ogrenci_Taksiklendir.ForeColor = System.Drawing.Color.SlateGray;
            this.button_Ogrenci_Taksiklendir.Image = ((System.Drawing.Image)(resources.GetObject("button_Ogrenci_Taksiklendir.Image")));
            this.button_Ogrenci_Taksiklendir.Location = new System.Drawing.Point(48, 143);
            this.button_Ogrenci_Taksiklendir.Name = "button_Ogrenci_Taksiklendir";
            this.button_Ogrenci_Taksiklendir.Size = new System.Drawing.Size(62, 64);
            this.button_Ogrenci_Taksiklendir.TabIndex = 4;
            this.button_Ogrenci_Taksiklendir.UseVisualStyleBackColor = true;
            this.button_Ogrenci_Taksiklendir.Click += new System.EventHandler(this.button_Ogrenci_Taksiklendir_Click);
            // 
            // textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar
            // 
            this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Location = new System.Drawing.Point(168, 53);
            this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Name = "textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar";
            this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Size = new System.Drawing.Size(109, 20);
            this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.TabIndex = 1;
            this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ogrenci_Taksit_Plan_Pesinat_KeyPress);
            this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar.Leave += new System.EventHandler(this.textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar_Leave);
            // 
            // dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi
            // 
            this.dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi.Location = new System.Drawing.Point(168, 106);
            this.dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi.Name = "dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi";
            this.dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Taksit Başlangıç Tarihi :";
            // 
            // Form_Ogrenci_Taksit_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(804, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Taksit_Plan);
            this.Name = "Form_Ogrenci_Taksit_Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Taksit Plan";
            this.Load += new System.EventHandler(this.Form_Ogrenci_Taksit_Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Taksit_Plan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Taksit_Plan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ogrenci_Taksit_Plan_Pesinat;
        private System.Windows.Forms.Button button_Ogrenci_Taksit_Temizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Ogrenci_Taksit_Vazgec;
        private System.Windows.Forms.ComboBox comboBox_Ogrenci_Taksit_Adeti;
        public System.Windows.Forms.Button button_Ogrenci_Taksiklendir;
        private System.Windows.Forms.TextBox textBox_Ogrenci_Taksit_Plan_Taksitlendirilecek_Miktar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ogrenci_Taksit_Baslangic_Tarihi;
        private System.Windows.Forms.Label label4;

    }
}