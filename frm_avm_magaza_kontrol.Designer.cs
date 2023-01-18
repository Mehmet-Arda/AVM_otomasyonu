namespace AVM_otomasyonu
{
    partial class frm_avm_magaza_kontrol
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_mgz_net_gg = new System.Windows.Forms.Button();
            this.btn_son_ay = new System.Windows.Forms.Button();
            this.btn_3_ay = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_mgz_prsnl = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_mgz_gider = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmb_magaza_fatura_tarihi = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.ch_mcg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_mcg)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mgz_net_gg
            // 
            this.btn_mgz_net_gg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_mgz_net_gg.FlatAppearance.BorderSize = 0;
            this.btn_mgz_net_gg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mgz_net_gg.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mgz_net_gg.ForeColor = System.Drawing.Color.White;
            this.btn_mgz_net_gg.Location = new System.Drawing.Point(10, 27);
            this.btn_mgz_net_gg.Name = "btn_mgz_net_gg";
            this.btn_mgz_net_gg.Size = new System.Drawing.Size(140, 45);
            this.btn_mgz_net_gg.TabIndex = 0;
            this.btn_mgz_net_gg.Text = "Mağaza Net Gelir Giderini Göster";
            this.btn_mgz_net_gg.UseVisualStyleBackColor = false;
            this.btn_mgz_net_gg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_son_ay
            // 
            this.btn_son_ay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_son_ay.FlatAppearance.BorderSize = 0;
            this.btn_son_ay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_son_ay.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_son_ay.ForeColor = System.Drawing.Color.White;
            this.btn_son_ay.Location = new System.Drawing.Point(10, 78);
            this.btn_son_ay.Name = "btn_son_ay";
            this.btn_son_ay.Size = new System.Drawing.Size(88, 34);
            this.btn_son_ay.TabIndex = 1;
            this.btn_son_ay.Text = "Son Bir Ay";
            this.btn_son_ay.UseVisualStyleBackColor = false;
            this.btn_son_ay.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_3_ay
            // 
            this.btn_3_ay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_3_ay.FlatAppearance.BorderSize = 0;
            this.btn_3_ay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3_ay.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_3_ay.ForeColor = System.Drawing.Color.White;
            this.btn_3_ay.Location = new System.Drawing.Point(10, 118);
            this.btn_3_ay.Name = "btn_3_ay";
            this.btn_3_ay.Size = new System.Drawing.Size(88, 33);
            this.btn_3_ay.TabIndex = 2;
            this.btn_3_ay.Text = "3 Ay";
            this.btn_3_ay.UseVisualStyleBackColor = false;
            this.btn_3_ay.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(10, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "6 ay";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 107);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_mgz_prsnl
            // 
            this.btn_mgz_prsnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_mgz_prsnl.FlatAppearance.BorderSize = 0;
            this.btn_mgz_prsnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mgz_prsnl.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mgz_prsnl.ForeColor = System.Drawing.Color.White;
            this.btn_mgz_prsnl.Location = new System.Drawing.Point(10, 265);
            this.btn_mgz_prsnl.Name = "btn_mgz_prsnl";
            this.btn_mgz_prsnl.Size = new System.Drawing.Size(133, 50);
            this.btn_mgz_prsnl.TabIndex = 5;
            this.btn_mgz_prsnl.Text = "Mağaza Personel Bilgisi";
            this.btn_mgz_prsnl.UseVisualStyleBackColor = false;
            this.btn_mgz_prsnl.Click += new System.EventHandler(this.btn_mgz_prsnl_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(158, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(495, 175);
            this.dataGridView2.TabIndex = 6;
            // 
            // btn_mgz_gider
            // 
            this.btn_mgz_gider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_mgz_gider.FlatAppearance.BorderSize = 0;
            this.btn_mgz_gider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mgz_gider.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mgz_gider.ForeColor = System.Drawing.Color.White;
            this.btn_mgz_gider.Location = new System.Drawing.Point(10, 380);
            this.btn_mgz_gider.Name = "btn_mgz_gider";
            this.btn_mgz_gider.Size = new System.Drawing.Size(142, 58);
            this.btn_mgz_gider.TabIndex = 7;
            this.btn_mgz_gider.Text = "Mağaza Gider Türü ve Giderler";
            this.btn_mgz_gider.UseVisualStyleBackColor = false;
            this.btn_mgz_gider.Click += new System.EventHandler(this.btn_mgz_gg_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(158, 321);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(320, 117);
            this.dataGridView3.TabIndex = 8;
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(484, 321);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Giderler";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(304, 196);
            this.chart3.TabIndex = 9;
            this.chart3.Text = "chart3";
            // 
            // cmb_magaza_fatura_tarihi
            // 
            this.cmb_magaza_fatura_tarihi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_magaza_fatura_tarihi.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_magaza_fatura_tarihi.FormattingEnabled = true;
            this.cmb_magaza_fatura_tarihi.Location = new System.Drawing.Point(10, 193);
            this.cmb_magaza_fatura_tarihi.Name = "cmb_magaza_fatura_tarihi";
            this.cmb_magaza_fatura_tarihi.Size = new System.Drawing.Size(121, 21);
            this.cmb_magaza_fatura_tarihi.TabIndex = 11;
            this.cmb_magaza_fatura_tarihi.SelectedIndexChanged += new System.EventHandler(this.cmb_fatura_tarihi_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(12, 8);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(80, 16);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Mağaza id";
            // 
            // btn_kapat
            // 
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.Black;
            this.btn_kapat.Location = new System.Drawing.Point(939, 5);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(37, 43);
            this.btn_kapat.TabIndex = 52;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // ch_mcg
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_mcg.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_mcg.Legends.Add(legend2);
            this.ch_mcg.Location = new System.Drawing.Point(659, 46);
            this.ch_mcg.Name = "ch_mcg";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Müşteri";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Ciro";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "GiderToplam";
            this.ch_mcg.Series.Add(series2);
            this.ch_mcg.Series.Add(series3);
            this.ch_mcg.Series.Add(series4);
            this.ch_mcg.Size = new System.Drawing.Size(295, 269);
            this.ch_mcg.TabIndex = 53;
            this.ch_mcg.Text = "chart1";
            // 
            // frm_avm_magaza_kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 532);
            this.Controls.Add(this.ch_mcg);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmb_magaza_fatura_tarihi);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btn_mgz_gider);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_mgz_prsnl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_3_ay);
            this.Controls.Add(this.btn_son_ay);
            this.Controls.Add(this.btn_mgz_net_gg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_avm_magaza_kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.avmy_magaza_kontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_mcg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_son_ay;
        private System.Windows.Forms.Button btn_3_ay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_mgz_prsnl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_mgz_gider;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.ComboBox cmb_magaza_fatura_tarihi;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Button btn_mgz_net_gg;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_mcg;
    }
}