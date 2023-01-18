namespace AVM_otomasyonu
{
    partial class frm_m_magaza_giderleri
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
            this.ch_gider_turu_giderler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dg_magaza_giderler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ch_gider_turu_giderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_magaza_giderler)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_gider_turu_giderler
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_gider_turu_giderler.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_gider_turu_giderler.Legends.Add(legend1);
            this.ch_gider_turu_giderler.Location = new System.Drawing.Point(243, 23);
            this.ch_gider_turu_giderler.Name = "ch_gider_turu_giderler";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Giderler";
            this.ch_gider_turu_giderler.Series.Add(series1);
            this.ch_gider_turu_giderler.Size = new System.Drawing.Size(313, 253);
            this.ch_gider_turu_giderler.TabIndex = 21;
            this.ch_gider_turu_giderler.Text = "chart2";
            // 
            // dg_magaza_giderler
            // 
            this.dg_magaza_giderler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_magaza_giderler.BackgroundColor = System.Drawing.Color.White;
            this.dg_magaza_giderler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_magaza_giderler.Location = new System.Drawing.Point(243, 282);
            this.dg_magaza_giderler.Name = "dg_magaza_giderler";
            this.dg_magaza_giderler.Size = new System.Drawing.Size(265, 139);
            this.dg_magaza_giderler.TabIndex = 20;
            // 
            // frm_m_magaza_giderleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 475);
            this.Controls.Add(this.ch_gider_turu_giderler);
            this.Controls.Add(this.dg_magaza_giderler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_m_magaza_giderleri";
            this.Text = "frm_m_magaza_giderleri";
            this.Load += new System.EventHandler(this.frm_m_magaza_giderleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_gider_turu_giderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_magaza_giderler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_gider_turu_giderler;
        private System.Windows.Forms.DataGridView dg_magaza_giderler;
    }
}