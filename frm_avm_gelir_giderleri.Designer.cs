namespace AVM_otomasyonu
{
    partial class frm_avm_gelir_giderleri
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch_avm_giderler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dg_avm_giderler = new System.Windows.Forms.DataGridView();
            this.dg_avm_gelirler = new System.Windows.Forms.DataGridView();
            this.ch_avm_gelirler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ch_avm_giderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_avm_giderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_avm_gelirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_avm_gelirler)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_avm_giderler
            // 
            chartArea3.Name = "ChartArea1";
            this.ch_avm_giderler.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ch_avm_giderler.Legends.Add(legend3);
            this.ch_avm_giderler.Location = new System.Drawing.Point(52, 47);
            this.ch_avm_giderler.Name = "ch_avm_giderler";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Miktar";
            this.ch_avm_giderler.Series.Add(series3);
            this.ch_avm_giderler.Size = new System.Drawing.Size(330, 293);
            this.ch_avm_giderler.TabIndex = 0;
            this.ch_avm_giderler.Text = "chart1";
            this.ch_avm_giderler.Click += new System.EventHandler(this.ch_avm_giderler_Click);
            // 
            // dg_avm_giderler
            // 
            this.dg_avm_giderler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_avm_giderler.BackgroundColor = System.Drawing.Color.White;
            this.dg_avm_giderler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_avm_giderler.Location = new System.Drawing.Point(64, 363);
            this.dg_avm_giderler.Name = "dg_avm_giderler";
            this.dg_avm_giderler.Size = new System.Drawing.Size(250, 136);
            this.dg_avm_giderler.TabIndex = 1;
            // 
            // dg_avm_gelirler
            // 
            this.dg_avm_gelirler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_avm_gelirler.BackgroundColor = System.Drawing.Color.White;
            this.dg_avm_gelirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_avm_gelirler.Location = new System.Drawing.Point(410, 363);
            this.dg_avm_gelirler.Name = "dg_avm_gelirler";
            this.dg_avm_gelirler.Size = new System.Drawing.Size(251, 112);
            this.dg_avm_gelirler.TabIndex = 4;
            // 
            // ch_avm_gelirler
            // 
            chartArea4.Name = "ChartArea1";
            this.ch_avm_gelirler.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ch_avm_gelirler.Legends.Add(legend4);
            this.ch_avm_gelirler.Location = new System.Drawing.Point(401, 51);
            this.ch_avm_gelirler.Name = "ch_avm_gelirler";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Miktar";
            this.ch_avm_gelirler.Series.Add(series4);
            this.ch_avm_gelirler.Size = new System.Drawing.Size(327, 292);
            this.ch_avm_gelirler.TabIndex = 3;
            this.ch_avm_gelirler.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giderler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(388, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gelirler";
            // 
            // frm_avm_gelir_giderleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_avm_gelirler);
            this.Controls.Add(this.ch_avm_gelirler);
            this.Controls.Add(this.dg_avm_giderler);
            this.Controls.Add(this.ch_avm_giderler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_avm_gelir_giderleri";
            this.Text = "avm_gelir_giderleri";
            this.Load += new System.EventHandler(this.avm_giderleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_avm_giderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_avm_giderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_avm_gelirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_avm_gelirler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_avm_giderler;
        private System.Windows.Forms.DataGridView dg_avm_giderler;
        private System.Windows.Forms.DataGridView dg_avm_gelirler;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_avm_gelirler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}