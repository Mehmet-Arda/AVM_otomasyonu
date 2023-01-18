namespace AVM_otomasyonu
{
    partial class frm_avm_personel_verileri
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
            this.dg_avm_personel = new System.Windows.Forms.DataGridView();
            this.ch_pozisyon_maas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_avm_personel = new System.Windows.Forms.Label();
            this.lbl_pozisyon_maas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_avm_personel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_pozisyon_maas)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_avm_personel
            // 
            this.dg_avm_personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_avm_personel.BackgroundColor = System.Drawing.Color.White;
            this.dg_avm_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_avm_personel.Location = new System.Drawing.Point(64, 46);
            this.dg_avm_personel.Name = "dg_avm_personel";
            this.dg_avm_personel.Size = new System.Drawing.Size(668, 221);
            this.dg_avm_personel.TabIndex = 0;
            // 
            // ch_pozisyon_maas
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_pozisyon_maas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_pozisyon_maas.Legends.Add(legend1);
            this.ch_pozisyon_maas.Location = new System.Drawing.Point(286, 273);
            this.ch_pozisyon_maas.Name = "ch_pozisyon_maas";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Maaş";
            this.ch_pozisyon_maas.Series.Add(series1);
            this.ch_pozisyon_maas.Size = new System.Drawing.Size(466, 288);
            this.ch_pozisyon_maas.TabIndex = 1;
            this.ch_pozisyon_maas.Text = "chart1";
            // 
            // lbl_avm_personel
            // 
            this.lbl_avm_personel.AutoSize = true;
            this.lbl_avm_personel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_avm_personel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avm_personel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_avm_personel.Location = new System.Drawing.Point(60, 20);
            this.lbl_avm_personel.Name = "lbl_avm_personel";
            this.lbl_avm_personel.Size = new System.Drawing.Size(110, 23);
            this.lbl_avm_personel.TabIndex = 2;
            this.lbl_avm_personel.Text = "Personeller";
            // 
            // lbl_pozisyon_maas
            // 
            this.lbl_pozisyon_maas.AutoSize = true;
            this.lbl_pozisyon_maas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pozisyon_maas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pozisyon_maas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.lbl_pozisyon_maas.Location = new System.Drawing.Point(60, 526);
            this.lbl_pozisyon_maas.Name = "lbl_pozisyon_maas";
            this.lbl_pozisyon_maas.Size = new System.Drawing.Size(288, 23);
            this.lbl_pozisyon_maas.TabIndex = 3;
            this.lbl_pozisyon_maas.Text = "Pozisyonlara Göre Maaş Dağılımı";
            // 
            // frm_avm_personel_verileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.lbl_pozisyon_maas);
            this.Controls.Add(this.lbl_avm_personel);
            this.Controls.Add(this.ch_pozisyon_maas);
            this.Controls.Add(this.dg_avm_personel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_avm_personel_verileri";
            this.Text = "frm_avm_personel_verileri";
            this.Load += new System.EventHandler(this.avm_personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_avm_personel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_pozisyon_maas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_avm_personel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_pozisyon_maas;
        private System.Windows.Forms.Label lbl_avm_personel;
        private System.Windows.Forms.Label lbl_pozisyon_maas;
    }
}