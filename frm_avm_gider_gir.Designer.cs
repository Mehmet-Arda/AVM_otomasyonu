namespace AVM_otomasyonu
{
    partial class frm_avm_gider_gir
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_avm_personel_gider_hesapla = new System.Windows.Forms.Button();
            this.lbl_su = new System.Windows.Forms.Label();
            this.lbl_elektrik = new System.Windows.Forms.Label();
            this.lbl_gaz = new System.Windows.Forms.Label();
            this.lbl_reklam = new System.Windows.Forms.Label();
            this.mtb_su_gideri = new System.Windows.Forms.MaskedTextBox();
            this.mtb_elektrik_gideri = new System.Windows.Forms.MaskedTextBox();
            this.mtb_reklam_gideri = new System.Windows.Forms.MaskedTextBox();
            this.txt_personel_gideri = new System.Windows.Forms.TextBox();
            this.lbl_eleman = new System.Windows.Forms.Label();
            this.mtb_gaz_gideri = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(282, 366);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(224, 81);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Son Ayın Giderlerini Güncelle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_avm_personel_gider_hesapla
            // 
            this.btn_avm_personel_gider_hesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_avm_personel_gider_hesapla.FlatAppearance.BorderSize = 0;
            this.btn_avm_personel_gider_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avm_personel_gider_hesapla.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_avm_personel_gider_hesapla.ForeColor = System.Drawing.Color.White;
            this.btn_avm_personel_gider_hesapla.Location = new System.Drawing.Point(416, 227);
            this.btn_avm_personel_gider_hesapla.Name = "btn_avm_personel_gider_hesapla";
            this.btn_avm_personel_gider_hesapla.Size = new System.Drawing.Size(116, 80);
            this.btn_avm_personel_gider_hesapla.TabIndex = 1;
            this.btn_avm_personel_gider_hesapla.Text = "Personel Giderlerini Hesapla";
            this.btn_avm_personel_gider_hesapla.UseVisualStyleBackColor = false;
            this.btn_avm_personel_gider_hesapla.Click += new System.EventHandler(this.btn_avm_personel_gider_hesapla_Click);
            // 
            // lbl_su
            // 
            this.lbl_su.AutoSize = true;
            this.lbl_su.BackColor = System.Drawing.Color.Transparent;
            this.lbl_su.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_su.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_su.Location = new System.Drawing.Point(190, 134);
            this.lbl_su.Name = "lbl_su";
            this.lbl_su.Size = new System.Drawing.Size(88, 23);
            this.lbl_su.TabIndex = 2;
            this.lbl_su.Text = "Su Gideri";
            // 
            // lbl_elektrik
            // 
            this.lbl_elektrik.AutoSize = true;
            this.lbl_elektrik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_elektrik.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_elektrik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_elektrik.Location = new System.Drawing.Point(202, 171);
            this.lbl_elektrik.Name = "lbl_elektrik";
            this.lbl_elektrik.Size = new System.Drawing.Size(76, 23);
            this.lbl_elektrik.TabIndex = 3;
            this.lbl_elektrik.Text = "Elektrik";
            // 
            // lbl_gaz
            // 
            this.lbl_gaz.AutoSize = true;
            this.lbl_gaz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gaz.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_gaz.Location = new System.Drawing.Point(237, 208);
            this.lbl_gaz.Name = "lbl_gaz";
            this.lbl_gaz.Size = new System.Drawing.Size(41, 23);
            this.lbl_gaz.TabIndex = 4;
            this.lbl_gaz.Text = "Gaz";
            // 
            // lbl_reklam
            // 
            this.lbl_reklam.AutoSize = true;
            this.lbl_reklam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reklam.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_reklam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_reklam.Location = new System.Drawing.Point(204, 245);
            this.lbl_reklam.Name = "lbl_reklam";
            this.lbl_reklam.Size = new System.Drawing.Size(74, 23);
            this.lbl_reklam.TabIndex = 5;
            this.lbl_reklam.Text = "Reklam";
            // 
            // mtb_su_gideri
            // 
            this.mtb_su_gideri.BackColor = System.Drawing.Color.White;
            this.mtb_su_gideri.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_su_gideri.Location = new System.Drawing.Point(282, 136);
            this.mtb_su_gideri.Name = "mtb_su_gideri";
            this.mtb_su_gideri.Size = new System.Drawing.Size(100, 27);
            this.mtb_su_gideri.TabIndex = 7;
            // 
            // mtb_elektrik_gideri
            // 
            this.mtb_elektrik_gideri.BackColor = System.Drawing.Color.White;
            this.mtb_elektrik_gideri.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_elektrik_gideri.Location = new System.Drawing.Point(282, 172);
            this.mtb_elektrik_gideri.Name = "mtb_elektrik_gideri";
            this.mtb_elektrik_gideri.Size = new System.Drawing.Size(100, 27);
            this.mtb_elektrik_gideri.TabIndex = 8;
            // 
            // mtb_reklam_gideri
            // 
            this.mtb_reklam_gideri.BackColor = System.Drawing.Color.White;
            this.mtb_reklam_gideri.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_reklam_gideri.Location = new System.Drawing.Point(282, 244);
            this.mtb_reklam_gideri.Name = "mtb_reklam_gideri";
            this.mtb_reklam_gideri.Size = new System.Drawing.Size(100, 27);
            this.mtb_reklam_gideri.TabIndex = 10;
            // 
            // txt_personel_gideri
            // 
            this.txt_personel_gideri.BackColor = System.Drawing.Color.White;
            this.txt_personel_gideri.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_personel_gideri.Location = new System.Drawing.Point(282, 280);
            this.txt_personel_gideri.Name = "txt_personel_gideri";
            this.txt_personel_gideri.Size = new System.Drawing.Size(100, 27);
            this.txt_personel_gideri.TabIndex = 11;
            // 
            // lbl_eleman
            // 
            this.lbl_eleman.AutoSize = true;
            this.lbl_eleman.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eleman.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eleman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_eleman.Location = new System.Drawing.Point(113, 282);
            this.lbl_eleman.Name = "lbl_eleman";
            this.lbl_eleman.Size = new System.Drawing.Size(165, 23);
            this.lbl_eleman.TabIndex = 12;
            this.lbl_eleman.Text = "Personel Giderleri";
            // 
            // mtb_gaz_gideri
            // 
            this.mtb_gaz_gideri.BackColor = System.Drawing.Color.White;
            this.mtb_gaz_gideri.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtb_gaz_gideri.Location = new System.Drawing.Point(282, 208);
            this.mtb_gaz_gideri.Name = "mtb_gaz_gideri";
            this.mtb_gaz_gideri.Size = new System.Drawing.Size(100, 27);
            this.mtb_gaz_gideri.TabIndex = 13;
            // 
            // frm_avm_gider_gir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.mtb_gaz_gideri);
            this.Controls.Add(this.lbl_eleman);
            this.Controls.Add(this.txt_personel_gideri);
            this.Controls.Add(this.mtb_reklam_gideri);
            this.Controls.Add(this.mtb_elektrik_gideri);
            this.Controls.Add(this.mtb_su_gideri);
            this.Controls.Add(this.lbl_reklam);
            this.Controls.Add(this.lbl_gaz);
            this.Controls.Add(this.lbl_elektrik);
            this.Controls.Add(this.lbl_su);
            this.Controls.Add(this.btn_avm_personel_gider_hesapla);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_avm_gider_gir";
            this.Text = "frm_avm_gider_gir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_avm_personel_gider_hesapla;
        private System.Windows.Forms.Label lbl_su;
        private System.Windows.Forms.Label lbl_elektrik;
        private System.Windows.Forms.Label lbl_gaz;
        private System.Windows.Forms.Label lbl_reklam;
        private System.Windows.Forms.MaskedTextBox mtb_su_gideri;
        private System.Windows.Forms.MaskedTextBox mtb_elektrik_gideri;
        private System.Windows.Forms.MaskedTextBox mtb_reklam_gideri;
        private System.Windows.Forms.TextBox txt_personel_gideri;
        private System.Windows.Forms.Label lbl_eleman;
        private System.Windows.Forms.MaskedTextBox mtb_gaz_gideri;
    }
}