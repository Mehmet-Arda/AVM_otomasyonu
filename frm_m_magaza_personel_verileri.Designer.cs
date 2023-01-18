namespace AVM_otomasyonu
{
    partial class frm_m_magaza_personel_verileri
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
            this.ch_pozisyon_eleman = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_pozisyon_maas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dg_magaza_personel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ch_pozisyon_eleman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_pozisyon_maas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_magaza_personel)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_pozisyon_eleman
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_pozisyon_eleman.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_pozisyon_eleman.Legends.Add(legend1);
            this.ch_pozisyon_eleman.Location = new System.Drawing.Point(412, 12);
            this.ch_pozisyon_eleman.Name = "ch_pozisyon_eleman";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "Eleman Sayısı";
            this.ch_pozisyon_eleman.Series.Add(series1);
            this.ch_pozisyon_eleman.Size = new System.Drawing.Size(336, 249);
            this.ch_pozisyon_eleman.TabIndex = 14;
            this.ch_pozisyon_eleman.Text = "chart1";
            // 
            // ch_pozisyon_maas
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_pozisyon_maas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_pozisyon_maas.Legends.Add(legend2);
            this.ch_pozisyon_maas.Location = new System.Drawing.Point(58, 12);
            this.ch_pozisyon_maas.Name = "ch_pozisyon_maas";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Maaş";
            this.ch_pozisyon_maas.Series.Add(series2);
            this.ch_pozisyon_maas.Size = new System.Drawing.Size(337, 249);
            this.ch_pozisyon_maas.TabIndex = 13;
            this.ch_pozisyon_maas.Text = "chart1";
            // 
            // dg_magaza_personel
            // 
            this.dg_magaza_personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_magaza_personel.BackgroundColor = System.Drawing.Color.White;
            this.dg_magaza_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_magaza_personel.Location = new System.Drawing.Point(124, 285);
            this.dg_magaza_personel.Name = "dg_magaza_personel";
            this.dg_magaza_personel.Size = new System.Drawing.Size(547, 158);
            this.dg_magaza_personel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(83, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pozisyonlara Göre Maaş Dağılımı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(428, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pozisyonlara Göre Eleman Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(298, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Genel Personel Bilgileri";
            // 
            // magaza_personel_verileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_pozisyon_eleman);
            this.Controls.Add(this.ch_pozisyon_maas);
            this.Controls.Add(this.dg_magaza_personel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "magaza_personel_verileri";
            this.Text = "magaza_personel_verileri";
            this.Load += new System.EventHandler(this.magaza_personel_verileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_pozisyon_eleman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_pozisyon_maas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_magaza_personel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_pozisyon_eleman;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_pozisyon_maas;
        private System.Windows.Forms.DataGridView dg_magaza_personel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}