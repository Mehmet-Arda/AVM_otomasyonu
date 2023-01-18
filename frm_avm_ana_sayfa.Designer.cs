namespace AVM_otomasyonu
{
    partial class frm_avm_ana_sayfa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_son_ay_veriler = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_avm_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_avm_adi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_avm_ziyaretci = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_acilis_kapanis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_ciro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_acilis_tarihi = new System.Windows.Forms.Label();
            this.lbl__id = new System.Windows.Forms.Label();
            this.btn_tum_veriler = new System.Windows.Forms.Button();
            this.avm_net_gg_dg = new System.Windows.Forms.DataGridView();
            this.avm_net_gg_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.avm_ziyaretci_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmb_avm_fatura_tarihi = new System.Windows.Forms.ComboBox();
            this.lbl_tarih_sec = new System.Windows.Forms.Label();
            this.btn_uc_ay_veriler = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avm_net_gg_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avm_net_gg_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avm_ziyaretci_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_son_ay_veriler
            // 
            this.btn_son_ay_veriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_son_ay_veriler.FlatAppearance.BorderSize = 0;
            this.btn_son_ay_veriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_son_ay_veriler.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_son_ay_veriler.ForeColor = System.Drawing.Color.White;
            this.btn_son_ay_veriler.Location = new System.Drawing.Point(74, 398);
            this.btn_son_ay_veriler.Name = "btn_son_ay_veriler";
            this.btn_son_ay_veriler.Size = new System.Drawing.Size(111, 67);
            this.btn_son_ay_veriler.TabIndex = 53;
            this.btn_son_ay_veriler.Text = "Son Ayın Verilerini Göster";
            this.btn_son_ay_veriler.UseVisualStyleBackColor = false;
            this.btn_son_ay_veriler.Click += new System.EventHandler(this.btn_son_ay_veriler_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lbl_avm_id);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbl_avm_adi);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lbl_avm_ziyaretci);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbl_personel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbl_acilis_kapanis);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbl_ciro);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbl_acilis_tarihi);
            this.panel3.Controls.Add(this.lbl__id);
            this.panel3.Location = new System.Drawing.Point(98, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 72);
            this.panel3.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Avm id";
            // 
            // lbl_avm_id
            // 
            this.lbl_avm_id.AutoSize = true;
            this.lbl_avm_id.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avm_id.ForeColor = System.Drawing.Color.White;
            this.lbl_avm_id.Location = new System.Drawing.Point(17, 42);
            this.lbl_avm_id.Name = "lbl_avm_id";
            this.lbl_avm_id.Size = new System.Drawing.Size(55, 18);
            this.lbl_avm_id.TabIndex = 14;
            this.lbl_avm_id.Text = "Avm id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(568, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Kuruluş Tarihi";
            // 
            // lbl_avm_adi
            // 
            this.lbl_avm_adi.AutoSize = true;
            this.lbl_avm_adi.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avm_adi.ForeColor = System.Drawing.Color.White;
            this.lbl_avm_adi.Location = new System.Drawing.Point(85, 42);
            this.lbl_avm_adi.Name = "lbl_avm_adi";
            this.lbl_avm_adi.Size = new System.Drawing.Size(65, 18);
            this.lbl_avm_adi.TabIndex = 33;
            this.lbl_avm_adi.Text = "Avm Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(376, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ciro";
            // 
            // lbl_avm_ziyaretci
            // 
            this.lbl_avm_ziyaretci.AutoSize = true;
            this.lbl_avm_ziyaretci.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avm_ziyaretci.ForeColor = System.Drawing.Color.White;
            this.lbl_avm_ziyaretci.Location = new System.Drawing.Point(172, 42);
            this.lbl_avm_ziyaretci.Name = "lbl_avm_ziyaretci";
            this.lbl_avm_ziyaretci.Size = new System.Drawing.Size(65, 18);
            this.lbl_avm_ziyaretci.TabIndex = 34;
            this.lbl_avm_ziyaretci.Text = "Ziyaretçi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(449, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Açılış - Kapanış";
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personel.ForeColor = System.Drawing.Color.White;
            this.lbl_personel.Location = new System.Drawing.Point(295, 44);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(26, 18);
            this.lbl_personel.TabIndex = 35;
            this.lbl_personel.Text = "PS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(264, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Personel Sayısı";
            // 
            // lbl_acilis_kapanis
            // 
            this.lbl_acilis_kapanis.AutoSize = true;
            this.lbl_acilis_kapanis.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_acilis_kapanis.ForeColor = System.Drawing.Color.White;
            this.lbl_acilis_kapanis.Location = new System.Drawing.Point(448, 42);
            this.lbl_acilis_kapanis.Name = "lbl_acilis_kapanis";
            this.lbl_acilis_kapanis.Size = new System.Drawing.Size(114, 18);
            this.lbl_acilis_kapanis.TabIndex = 36;
            this.lbl_acilis_kapanis.Text = "Açılış - Kapanış";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(150, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ziyaretçi Sayısı";
            // 
            // lbl_ciro
            // 
            this.lbl_ciro.AutoSize = true;
            this.lbl_ciro.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ciro.ForeColor = System.Drawing.Color.White;
            this.lbl_ciro.Location = new System.Drawing.Point(376, 42);
            this.lbl_ciro.Name = "lbl_ciro";
            this.lbl_ciro.Size = new System.Drawing.Size(35, 18);
            this.lbl_ciro.TabIndex = 37;
            this.lbl_ciro.Text = "Ciro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(85, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "AVM Adı";
            // 
            // lbl_acilis_tarihi
            // 
            this.lbl_acilis_tarihi.AutoSize = true;
            this.lbl_acilis_tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_acilis_tarihi.ForeColor = System.Drawing.Color.White;
            this.lbl_acilis_tarihi.Location = new System.Drawing.Point(568, 42);
            this.lbl_acilis_tarihi.Name = "lbl_acilis_tarihi";
            this.lbl_acilis_tarihi.Size = new System.Drawing.Size(97, 15);
            this.lbl_acilis_tarihi.TabIndex = 38;
            this.lbl_acilis_tarihi.Text = "Kuruluş Tarihi";
            // 
            // lbl__id
            // 
            this.lbl__id.AutoSize = true;
            this.lbl__id.Location = new System.Drawing.Point(697, 49);
            this.lbl__id.Name = "lbl__id";
            this.lbl__id.Size = new System.Drawing.Size(56, 13);
            this.lbl__id.TabIndex = 39;
            this.lbl__id.Text = "Mağaza id";
            // 
            // btn_tum_veriler
            // 
            this.btn_tum_veriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_tum_veriler.FlatAppearance.BorderSize = 0;
            this.btn_tum_veriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tum_veriler.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tum_veriler.ForeColor = System.Drawing.Color.White;
            this.btn_tum_veriler.Location = new System.Drawing.Point(74, 340);
            this.btn_tum_veriler.Name = "btn_tum_veriler";
            this.btn_tum_veriler.Size = new System.Drawing.Size(111, 55);
            this.btn_tum_veriler.TabIndex = 54;
            this.btn_tum_veriler.Text = "Tüm Verileri Göster";
            this.btn_tum_veriler.UseVisualStyleBackColor = false;
            this.btn_tum_veriler.Click += new System.EventHandler(this.btn_tum_veriler_Click_1);
            // 
            // avm_net_gg_dg
            // 
            this.avm_net_gg_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.avm_net_gg_dg.BackgroundColor = System.Drawing.Color.White;
            this.avm_net_gg_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avm_net_gg_dg.Location = new System.Drawing.Point(356, 329);
            this.avm_net_gg_dg.Name = "avm_net_gg_dg";
            this.avm_net_gg_dg.Size = new System.Drawing.Size(372, 106);
            this.avm_net_gg_dg.TabIndex = 55;
            // 
            // avm_net_gg_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.avm_net_gg_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.avm_net_gg_chart.Legends.Add(legend1);
            this.avm_net_gg_chart.Location = new System.Drawing.Point(396, 12);
            this.avm_net_gg_chart.Name = "avm_net_gg_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Toplam Gelir";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Toplam Gider";
            this.avm_net_gg_chart.Series.Add(series1);
            this.avm_net_gg_chart.Series.Add(series2);
            this.avm_net_gg_chart.Size = new System.Drawing.Size(332, 311);
            this.avm_net_gg_chart.TabIndex = 56;
            this.avm_net_gg_chart.Text = "chart1";
            // 
            // avm_ziyaretci_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.avm_ziyaretci_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.avm_ziyaretci_chart.Legends.Add(legend2);
            this.avm_ziyaretci_chart.Location = new System.Drawing.Point(22, 12);
            this.avm_ziyaretci_chart.Name = "avm_ziyaretci_chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 20;
            series3.MarkerSize = 20;
            series3.Name = "Ziyaretçi Sayısı";
            this.avm_ziyaretci_chart.Series.Add(series3);
            this.avm_ziyaretci_chart.Size = new System.Drawing.Size(368, 310);
            this.avm_ziyaretci_chart.TabIndex = 57;
            this.avm_ziyaretci_chart.Text = "chart1";
            // 
            // cmb_avm_fatura_tarihi
            // 
            this.cmb_avm_fatura_tarihi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_avm_fatura_tarihi.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_avm_fatura_tarihi.FormattingEnabled = true;
            this.cmb_avm_fatura_tarihi.Location = new System.Drawing.Point(191, 420);
            this.cmb_avm_fatura_tarihi.Name = "cmb_avm_fatura_tarihi";
            this.cmb_avm_fatura_tarihi.Size = new System.Drawing.Size(135, 21);
            this.cmb_avm_fatura_tarihi.TabIndex = 58;
            this.cmb_avm_fatura_tarihi.SelectedIndexChanged += new System.EventHandler(this.cmb_avm_fatura_tarihi_SelectedIndexChanged_1);
            // 
            // lbl_tarih_sec
            // 
            this.lbl_tarih_sec.AutoSize = true;
            this.lbl_tarih_sec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tarih_sec.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih_sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_tarih_sec.Location = new System.Drawing.Point(191, 398);
            this.lbl_tarih_sec.Name = "lbl_tarih_sec";
            this.lbl_tarih_sec.Size = new System.Drawing.Size(157, 19);
            this.lbl_tarih_sec.TabIndex = 59;
            this.lbl_tarih_sec.Text = "Tarihli Faturayı Getir";
            // 
            // btn_uc_ay_veriler
            // 
            this.btn_uc_ay_veriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_uc_ay_veriler.FlatAppearance.BorderSize = 0;
            this.btn_uc_ay_veriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uc_ay_veriler.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uc_ay_veriler.ForeColor = System.Drawing.Color.White;
            this.btn_uc_ay_veriler.Location = new System.Drawing.Point(191, 340);
            this.btn_uc_ay_veriler.Name = "btn_uc_ay_veriler";
            this.btn_uc_ay_veriler.Size = new System.Drawing.Size(97, 55);
            this.btn_uc_ay_veriler.TabIndex = 69;
            this.btn_uc_ay_veriler.Text = "Üç Aylık";
            this.btn_uc_ay_veriler.UseVisualStyleBackColor = false;
            this.btn_uc_ay_veriler.Click += new System.EventHandler(this.btn_uc_ay_veriler_Click);
            // 
            // frm_avm_ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.btn_uc_ay_veriler);
            this.Controls.Add(this.btn_tum_veriler);
            this.Controls.Add(this.btn_son_ay_veriler);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.avm_net_gg_dg);
            this.Controls.Add(this.avm_net_gg_chart);
            this.Controls.Add(this.avm_ziyaretci_chart);
            this.Controls.Add(this.cmb_avm_fatura_tarihi);
            this.Controls.Add(this.lbl_tarih_sec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_avm_ana_sayfa";
            this.Text = "frm_avm_ana_sayfa";
            this.Load += new System.EventHandler(this.frm_avm_ana_sayfa_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avm_net_gg_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avm_net_gg_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avm_ziyaretci_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_son_ay_veriler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lbl_avm_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_avm_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_avm_ziyaretci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_acilis_kapanis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ciro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_acilis_tarihi;
        private System.Windows.Forms.Label lbl__id;
        private System.Windows.Forms.Button btn_tum_veriler;
        private System.Windows.Forms.DataGridView avm_net_gg_dg;
        private System.Windows.Forms.DataVisualization.Charting.Chart avm_net_gg_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart avm_ziyaretci_chart;
        private System.Windows.Forms.ComboBox cmb_avm_fatura_tarihi;
        private System.Windows.Forms.Label lbl_tarih_sec;
        private System.Windows.Forms.Button btn_uc_ay_veriler;
    }
}