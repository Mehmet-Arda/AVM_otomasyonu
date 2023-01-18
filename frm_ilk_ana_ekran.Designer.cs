namespace AVM_otomasyonu
{
    partial class frm_ilk_ana_ekran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_avmy = new System.Windows.Forms.Button();
            this.btn_my = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(594, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(37, 43);
            this.btn_kapat.TabIndex = 53;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_avmy
            // 
            this.btn_avmy.BackColor = System.Drawing.Color.Transparent;
            this.btn_avmy.FlatAppearance.BorderSize = 0;
            this.btn_avmy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avmy.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_avmy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_avmy.Image = global::AVM_otomasyonu.Properties.Resources.yonetici;
            this.btn_avmy.Location = new System.Drawing.Point(325, 94);
            this.btn_avmy.Name = "btn_avmy";
            this.btn_avmy.Size = new System.Drawing.Size(213, 296);
            this.btn_avmy.TabIndex = 1;
            this.btn_avmy.Text = "AVM Yönetici Girişi";
            this.btn_avmy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_avmy.UseVisualStyleBackColor = false;
            this.btn_avmy.Click += new System.EventHandler(this.btn_avmy_Click);
            // 
            // btn_my
            // 
            this.btn_my.BackColor = System.Drawing.Color.Transparent;
            this.btn_my.FlatAppearance.BorderSize = 0;
            this.btn_my.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_my.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_my.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_my.Image = global::AVM_otomasyonu.Properties.Resources.yonetici;
            this.btn_my.Location = new System.Drawing.Point(69, 94);
            this.btn_my.Name = "btn_my";
            this.btn_my.Size = new System.Drawing.Size(198, 296);
            this.btn_my.TabIndex = 0;
            this.btn_my.Text = "Mağaza Yönetici Girişi";
            this.btn_my.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_my.UseVisualStyleBackColor = false;
            this.btn_my.Click += new System.EventHandler(this.btn_my_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(548, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 43);
            this.button1.TabIndex = 54;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_baslik.Location = new System.Drawing.Point(157, 37);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(277, 36);
            this.lbl_baslik.TabIndex = 55;
            this.lbl_baslik.Text = "AVM Otomasyonu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(597, 486);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_avmy);
            this.Controls.Add(this.btn_my);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_my;
        private System.Windows.Forms.Button btn_avmy;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_baslik;
    }
}

