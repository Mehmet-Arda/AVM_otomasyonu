namespace AVM_otomasyonu
{
    partial class frm_avm_personel_islemleri
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_telNo = new System.Windows.Forms.Label();
            this.lbl_pozisyon = new System.Windows.Forms.Label();
            this.lbl_maas = new System.Windows.Forms.Label();
            this.lbl_vardiya = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.mtb_telNo = new System.Windows.Forms.MaskedTextBox();
            this.cmb_pozisyon = new System.Windows.Forms.ComboBox();
            this.cmb_vardiya = new System.Windows.Forms.ComboBox();
            this.mtb_maas = new System.Windows.Forms.MaskedTextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.dg_personel_listesi = new System.Windows.Forms.DataGridView();
            this.lbl_per_id = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_personel_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.BackColor = System.Drawing.Color.White;
            this.lbl_ad.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_ad.Location = new System.Drawing.Point(100, 74);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(37, 23);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Adı";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.BackColor = System.Drawing.Color.White;
            this.lbl_soyad.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_soyad.Location = new System.Drawing.Point(72, 119);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(66, 23);
            this.lbl_soyad.TabIndex = 1;
            this.lbl_soyad.Text = "Soyadı";
            // 
            // lbl_telNo
            // 
            this.lbl_telNo.AutoSize = true;
            this.lbl_telNo.BackColor = System.Drawing.Color.White;
            this.lbl_telNo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_telNo.Location = new System.Drawing.Point(73, 164);
            this.lbl_telNo.Name = "lbl_telNo";
            this.lbl_telNo.Size = new System.Drawing.Size(62, 23);
            this.lbl_telNo.TabIndex = 2;
            this.lbl_telNo.Text = "Tel No";
            // 
            // lbl_pozisyon
            // 
            this.lbl_pozisyon.AutoSize = true;
            this.lbl_pozisyon.BackColor = System.Drawing.Color.White;
            this.lbl_pozisyon.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pozisyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_pozisyon.Location = new System.Drawing.Point(53, 209);
            this.lbl_pozisyon.Name = "lbl_pozisyon";
            this.lbl_pozisyon.Size = new System.Drawing.Size(85, 23);
            this.lbl_pozisyon.TabIndex = 3;
            this.lbl_pozisyon.Text = "Pozisyon";
            // 
            // lbl_maas
            // 
            this.lbl_maas.AutoSize = true;
            this.lbl_maas.BackColor = System.Drawing.Color.White;
            this.lbl_maas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_maas.Location = new System.Drawing.Point(82, 254);
            this.lbl_maas.Name = "lbl_maas";
            this.lbl_maas.Size = new System.Drawing.Size(55, 23);
            this.lbl_maas.TabIndex = 4;
            this.lbl_maas.Text = "Maaş";
            // 
            // lbl_vardiya
            // 
            this.lbl_vardiya.AutoSize = true;
            this.lbl_vardiya.BackColor = System.Drawing.Color.White;
            this.lbl_vardiya.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vardiya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_vardiya.Location = new System.Drawing.Point(68, 299);
            this.lbl_vardiya.Name = "lbl_vardiya";
            this.lbl_vardiya.Size = new System.Drawing.Size(73, 23);
            this.lbl_vardiya.TabIndex = 5;
            this.lbl_vardiya.Text = "Vardiya";
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(146, 74);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(131, 27);
            this.txt_ad.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(146, 119);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(131, 27);
            this.txt_soyad.TabIndex = 7;
            // 
            // mtb_telNo
            // 
            this.mtb_telNo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_telNo.Location = new System.Drawing.Point(146, 164);
            this.mtb_telNo.Mask = "(999) 000-0000";
            this.mtb_telNo.Name = "mtb_telNo";
            this.mtb_telNo.Size = new System.Drawing.Size(97, 27);
            this.mtb_telNo.TabIndex = 8;
            // 
            // cmb_pozisyon
            // 
            this.cmb_pozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pozisyon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_pozisyon.FormattingEnabled = true;
            this.cmb_pozisyon.Location = new System.Drawing.Point(146, 209);
            this.cmb_pozisyon.Name = "cmb_pozisyon";
            this.cmb_pozisyon.Size = new System.Drawing.Size(121, 27);
            this.cmb_pozisyon.TabIndex = 11;
            // 
            // cmb_vardiya
            // 
            this.cmb_vardiya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vardiya.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_vardiya.FormattingEnabled = true;
            this.cmb_vardiya.Location = new System.Drawing.Point(146, 300);
            this.cmb_vardiya.Name = "cmb_vardiya";
            this.cmb_vardiya.Size = new System.Drawing.Size(121, 27);
            this.cmb_vardiya.TabIndex = 12;
            // 
            // mtb_maas
            // 
            this.mtb_maas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_maas.Location = new System.Drawing.Point(146, 255);
            this.mtb_maas.Mask = "00000";
            this.mtb_maas.Name = "mtb_maas";
            this.mtb_maas.Size = new System.Drawing.Size(56, 27);
            this.mtb_maas.TabIndex = 13;
            this.mtb_maas.ValidatingType = typeof(int);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(146, 393);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(97, 43);
            this.btn_ekle.TabIndex = 14;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.Location = new System.Drawing.Point(146, 442);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(97, 43);
            this.btn_listele.TabIndex = 15;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(146, 491);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(97, 43);
            this.btn_guncelle.TabIndex = 16;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_ara.FlatAppearance.BorderSize = 0;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Location = new System.Drawing.Point(249, 442);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(78, 43);
            this.btn_ara.TabIndex = 17;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // dg_personel_listesi
            // 
            this.dg_personel_listesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_personel_listesi.BackgroundColor = System.Drawing.Color.White;
            this.dg_personel_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_personel_listesi.Location = new System.Drawing.Point(295, 52);
            this.dg_personel_listesi.MultiSelect = false;
            this.dg_personel_listesi.Name = "dg_personel_listesi";
            this.dg_personel_listesi.ReadOnly = true;
            this.dg_personel_listesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_personel_listesi.Size = new System.Drawing.Size(466, 281);
            this.dg_personel_listesi.TabIndex = 18;
            this.dg_personel_listesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_personel_listesi_CellContentClick);
            // 
            // lbl_per_id
            // 
            this.lbl_per_id.AutoSize = true;
            this.lbl_per_id.BackColor = System.Drawing.Color.White;
            this.lbl_per_id.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_per_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_per_id.Location = new System.Drawing.Point(146, 41);
            this.lbl_per_id.Name = "lbl_per_id";
            this.lbl_per_id.Size = new System.Drawing.Size(109, 23);
            this.lbl_per_id.TabIndex = 19;
            this.lbl_per_id.Text = "Personel_id";
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_temizle.FlatAppearance.BorderSize = 0;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Location = new System.Drawing.Point(333, 491);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(98, 43);
            this.btn_temizle.TabIndex = 20;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(249, 491);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(78, 43);
            this.btn_sil.TabIndex = 21;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // frm_avm_personel_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.lbl_per_id);
            this.Controls.Add(this.dg_personel_listesi);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbl_vardiya);
            this.Controls.Add(this.lbl_maas);
            this.Controls.Add(this.lbl_pozisyon);
            this.Controls.Add(this.lbl_telNo);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.mtb_maas);
            this.Controls.Add(this.cmb_vardiya);
            this.Controls.Add(this.cmb_pozisyon);
            this.Controls.Add(this.mtb_telNo);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_avm_personel_islemleri";
            this.Text = "avm_personel_ekleme";
            this.Load += new System.EventHandler(this.avm_personel_ekleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_personel_listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_telNo;
        private System.Windows.Forms.Label lbl_pozisyon;
        private System.Windows.Forms.Label lbl_maas;
        private System.Windows.Forms.Label lbl_vardiya;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.MaskedTextBox mtb_telNo;
        private System.Windows.Forms.ComboBox cmb_pozisyon;
        private System.Windows.Forms.ComboBox cmb_vardiya;
        private System.Windows.Forms.MaskedTextBox mtb_maas;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.DataGridView dg_personel_listesi;
        private System.Windows.Forms.Label lbl_per_id;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
    }
}