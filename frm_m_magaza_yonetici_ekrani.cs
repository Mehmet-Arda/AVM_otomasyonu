using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace AVM_otomasyonu
{
    public partial class frm_m_magaza_yonetici_ekrani : Form
    {
        //Ekranın üçgen kenarlı olması için tasarım sitesinden çekilen kod. 
        //http://www.iwebmakers.ml

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        //*****************


        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public int magaza_id;
        public int magaza_yonetici_id;
        public int avm_id;
        public frm_m_magaza_yonetici_ekrani()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void magaza_yonetici_ekrani_Load(object sender, EventArgs e)
        {
            //Giriş yapan yöneticinin id bilgisiyle personel tablosundan mağaza id'sinin alınması.
            baglanti.Open();
            
            SqlCommand komut0 = new SqlCommand("Select calisma_yeri From magaza_personel Where personel_id=@yonetici_id", baglanti);
            komut0.Parameters.AddWithValue("@yonetici_id", magaza_yonetici_id);
            SqlDataReader okuyucu0 = komut0.ExecuteReader();
            while (okuyucu0.Read())
            {
                magaza_id = Convert.ToInt32(okuyucu0[0]);
                
            }
            baglanti.Close();
            //*****************

            btn_ana_sayfa.PerformClick();


        }

        


        private void btn_ana_sayfa_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_ana_sayfa.Height;
            pnl_nav.Top = btn_ana_sayfa.Top;
            pnl_nav.Left = btn_ana_sayfa.Left;
            btn_ana_sayfa.BackColor = Color.FromArgb(46, 51, 73);

            
            
            frm_m_magaza_ana_sayfa magaza_ana_sayfa = new frm_m_magaza_ana_sayfa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lbl_baslik.Text = "Ana Sayfa";
            this.pnl_form_loader.Controls.Clear();
            magaza_ana_sayfa.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(magaza_ana_sayfa);
            

            magaza_ana_sayfa.avm_id = this.avm_id;
            magaza_ana_sayfa.magaza_yonetici_id = this.magaza_yonetici_id;
            magaza_ana_sayfa.magaza_id = this.magaza_id;
            magaza_ana_sayfa.Show();

        }

        private void btn_personel_islemleri_Click_1(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_personel_islemleri.Height;
            pnl_nav.Top = btn_personel_islemleri.Top;
            pnl_nav.Left = btn_personel_islemleri.Left;
            btn_personel_islemleri.BackColor = Color.FromArgb(46, 51, 73);


            frm_m_magaza_personel_islemleri magaza_per_islemleri = new frm_m_magaza_personel_islemleri() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lbl_baslik.Text = "Personel İşlemleri";
            this.pnl_form_loader.Controls.Clear();
            magaza_per_islemleri.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(magaza_per_islemleri);



            magaza_per_islemleri.avm_id = this.avm_id;
            magaza_per_islemleri.magaza_id = this.magaza_id;
            magaza_per_islemleri.magaza_yonetici_id = this.magaza_yonetici_id;
            magaza_per_islemleri.Show();
        }

        private void btn_personel_verileri_Click_1(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_personel_verileri.Height;
            pnl_nav.Top = btn_personel_verileri.Top;
            pnl_nav.Left = btn_personel_verileri.Left;
            btn_personel_verileri.BackColor = Color.FromArgb(46, 51, 73);


            frm_m_magaza_personel_verileri mp_verileri = new frm_m_magaza_personel_verileri() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lbl_baslik.Text = "Personel Verileri";
            this.pnl_form_loader.Controls.Clear();
            mp_verileri.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(mp_verileri);


            mp_verileri.magaza_id = this.magaza_id;
            mp_verileri.magaza_yonetici_id = this.magaza_yonetici_id;
            mp_verileri.avm_id = this.avm_id;
            mp_verileri.Show();
        }

        private void btn_magaza_giderleri_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_magaza_giderleri.Height;
            pnl_nav.Top = btn_magaza_giderleri.Top;
            pnl_nav.Left = btn_magaza_giderleri.Left;
            btn_magaza_giderleri.BackColor = Color.FromArgb(46, 51, 73);


            frm_m_magaza_giderleri magaza_giderleri = new frm_m_magaza_giderleri() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lbl_baslik.Text = "Mağaza Giderleri";
            this.pnl_form_loader.Controls.Clear();
            magaza_giderleri.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(magaza_giderleri);


            magaza_giderleri.magaza_id = this.magaza_id;
            magaza_giderleri.magaza_yonetici_id = this.magaza_yonetici_id;
            magaza_giderleri.avm_id = this.avm_id;
            magaza_giderleri.Show();
        }

        private void btn_magaza_gg_gir_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_magaza_gider_gir.Height;
            pnl_nav.Top = btn_magaza_gider_gir.Top;
            pnl_nav.Left = btn_magaza_gider_gir.Left;
            btn_magaza_gider_gir.BackColor = Color.FromArgb(46, 51, 73);


            frm_m_magaza_gelir_gider_ekleme magaza_gg = new frm_m_magaza_gelir_gider_ekleme() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lbl_baslik.Text = "Mağaza Gider Gir";
            this.pnl_form_loader.Controls.Clear();
            magaza_gg.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(magaza_gg);


            magaza_gg.magaza_id = this.magaza_id;
            magaza_gg.magaza_yonetici_id = this.magaza_yonetici_id;
            magaza_gg.avm_id = this.avm_id;
            magaza_gg.Show();

        }

        private void btn_ana_sayfa_Leave(object sender, EventArgs e)
        {
            btn_ana_sayfa.BackColor = Color.FromArgb(24,30,54);
        }

        private void btn_personel_islemleri_Leave(object sender, EventArgs e)
        {
            btn_personel_islemleri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_personel_verileri_Leave(object sender, EventArgs e)
        {
            btn_personel_verileri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_magaza_giderleri_Leave(object sender, EventArgs e)
        {
            btn_magaza_giderleri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_magaza_gg_gir_Leave(object sender, EventArgs e)
        {
            btn_magaza_gider_gir.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_fatura_kes_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_fatura_kes.Height;
            pnl_nav.Top = btn_fatura_kes.Top;
            pnl_nav.Left = btn_fatura_kes.Left;
            btn_fatura_kes.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_fatura_kes_Leave(object sender, EventArgs e)
        {
            btn_fatura_kes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_geri.Height;
            pnl_nav.Top = btn_geri.Top;
            pnl_nav.Left = btn_geri.Left;
            btn_geri.BackColor = Color.FromArgb(46, 51, 73);


            this.Hide();
            frm_m_magaza_yonetici_giris_ekrani magaza_yg = new frm_m_magaza_yonetici_giris_ekrani();
            magaza_yg.Show();
        }

        private void btn_geri_Leave(object sender, EventArgs e)
        {
            btn_geri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
