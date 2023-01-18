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
    public partial class frm_avm_yonetici_ekrani : Form
    {
        // Ekranın üçgen kenarlı olması için tasarım sitesinden çekilen kod.
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


        public int avm_yonetici_id;
        public int avm_id;
        public frm_avm_yonetici_ekrani()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
      
        

        private void avm_yonetici_ekrani_Load(object sender, EventArgs e)
        {


            btn_ana_sayfa.PerformClick();


            //Giriş yapan yöneticinin id bilgisiyle personel tablosundan avm id'sinin alınması.
            baglanti.Open();
            
            SqlCommand komut0 = new SqlCommand("Select calisma_yeri From avm_personel Where personel_id=@yonetici_id", baglanti);
            komut0.Parameters.AddWithValue("@yonetici_id", avm_yonetici_id);
            SqlDataReader okuyucu0 = komut0.ExecuteReader();
            while (okuyucu0.Read())
            {
                avm_id = Convert.ToInt32(okuyucu0[0]);
                
            }
            baglanti.Close();
            //*****************



        }



        private void btn_avm_personel_Click(object sender, EventArgs e)
        {
            frm_avm_personel_verileri avm_personel_verileri = new frm_avm_personel_verileri();
            avm_personel_verileri.avm_id = this.avm_id;
            avm_personel_verileri.Show();
        }

       

        private void btn_avm_giderleri_Click(object sender, EventArgs e)
        {
            frm_avm_gelir_giderleri avm_gider = new frm_avm_gelir_giderleri();
            avm_gider.avm_id = this.avm_id;
            avm_gider.Show();
        }

        private void btn_avm_personeli_ekle_Click(object sender, EventArgs e)
        {
            frm_avm_personel_islemleri avm_pe = new frm_avm_personel_islemleri();
            avm_pe.avm_id = this.avm_id;
            avm_pe.Show();
        }

        

        private void btn_avm_gider_gir_Click(object sender, EventArgs e)
        {
            frm_avm_gider_gir avm_ggir = new frm_avm_gider_gir();
            avm_ggir.avm_id = this.avm_id;
            avm_ggir.Show();

        }


        private void btn_ana_sayfa_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_ana_sayfa.Height;
            pnl_nav.Top = btn_ana_sayfa.Top;
            pnl_nav.Left = btn_ana_sayfa.Left;
            btn_ana_sayfa.BackColor = Color.FromArgb(46,51,73);


            lbl_baslik.Text = "Anasayfa";
            pnl_form_loader.Controls.Clear();
            frm_avm_ana_sayfa avm_ana_sayfa = new frm_avm_ana_sayfa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avm_ana_sayfa.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(avm_ana_sayfa);
            
            avm_ana_sayfa.avm_id = this.avm_id;
            avm_ana_sayfa.avm_yonetici_id = this.avm_yonetici_id;
            avm_ana_sayfa.Show();


        }

        private void btn_magaza_islemleri_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_magaza_islemleri.Height;
            pnl_nav.Top = btn_magaza_islemleri.Top;
            pnl_nav.Left = btn_magaza_islemleri.Left;
            btn_magaza_islemleri.BackColor = Color.FromArgb(46, 51, 73);



            lbl_baslik.Text = "Mağaza İşlemleri";
            pnl_form_loader.Controls.Clear();
            frm_avm_magaza_islemleri avm_magaza_islemleri= new frm_avm_magaza_islemleri() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avm_magaza_islemleri.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(avm_magaza_islemleri);
           

            avm_magaza_islemleri.avm_yonetici_id = this.avm_yonetici_id;
            avm_magaza_islemleri.avm_id = this.avm_id;
            avm_magaza_islemleri.Show();




        }

        private void btn_personel_islemleri_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_personel_islemleri.Height;
            pnl_nav.Top = btn_personel_islemleri.Top;
            pnl_nav.Left = btn_personel_islemleri.Left;
            btn_personel_islemleri.BackColor = Color.FromArgb(46, 51, 73);



            lbl_baslik.Text = "Avm Personel İşlemleri";
            pnl_form_loader.Controls.Clear();
            frm_avm_personel_islemleri avm_personel_islemleri = new frm_avm_personel_islemleri() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avm_personel_islemleri.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(avm_personel_islemleri);
            

            avm_personel_islemleri.avm_id = this.avm_id;
            avm_personel_islemleri.Show();


        }

        private void btn_personel_verileri_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_personel_verileri.Height;
            pnl_nav.Top = btn_personel_verileri.Top;
            pnl_nav.Left = btn_personel_verileri.Left;
            btn_personel_verileri.BackColor = Color.FromArgb(46, 51, 73);


            lbl_baslik.Text = "Avm Personel Verileri";
            pnl_form_loader.Controls.Clear();
            frm_avm_personel_verileri avm_personel_verileri = new frm_avm_personel_verileri() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avm_personel_verileri.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(avm_personel_verileri);
            

            avm_personel_verileri.avm_id = this.avm_id;
            avm_personel_verileri.Show();





        }

        private void btn_avm_gelir_giderleri_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_avm_gelir_giderleri.Height;
            pnl_nav.Top = btn_avm_gelir_giderleri.Top;
            pnl_nav.Left = btn_avm_gelir_giderleri.Left;
            btn_avm_gelir_giderleri.BackColor = Color.FromArgb(46, 51, 73);


            lbl_baslik.Text = "Avm Gelir Giderleri";
            pnl_form_loader.Controls.Clear();
            frm_avm_gelir_giderleri avm_gelir_giderler = new frm_avm_gelir_giderleri() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avm_gelir_giderler.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(avm_gelir_giderler);
            

            avm_gelir_giderler.avm_id = this.avm_id;
            avm_gelir_giderler.Show();




        }

        private void btn_avm_gider_gir_Click_1(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_avm_gider_gir.Height;
            pnl_nav.Top = btn_avm_gider_gir.Top;
            pnl_nav.Left = btn_avm_gider_gir.Left;
            btn_avm_gider_gir.BackColor = Color.FromArgb(46, 51, 73);


            lbl_baslik.Text = "Avm Gider Gir";
            pnl_form_loader.Controls.Clear();
            frm_avm_gider_gir avm_gider_gir= new frm_avm_gider_gir() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            avm_gider_gir.FormBorderStyle = FormBorderStyle.None;
            this.pnl_form_loader.Controls.Add(avm_gider_gir);
            


            avm_gider_gir.avm_id = this.avm_id;
            avm_gider_gir.Show();


        }

        private void btn_fatura_kes_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_fatura_kes.Height;
            pnl_nav.Top = btn_fatura_kes.Top;
            pnl_nav.Left = btn_fatura_kes.Left;
            btn_fatura_kes.BackColor = Color.FromArgb(46, 51, 73);

        }

      
        private void btn_ana_sayfa_Leave(object sender, EventArgs e)
        {
            btn_ana_sayfa.BackColor = Color.FromArgb(24,30,54);
        }

        private void btn_magaza_islemleri_Leave(object sender, EventArgs e)
        {
            btn_magaza_islemleri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_personel_islemleri_Leave(object sender, EventArgs e)
        {
            btn_personel_islemleri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_personel_verileri_Leave(object sender, EventArgs e)
        {
            btn_personel_verileri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_avm_gelir_giderleri_Leave(object sender, EventArgs e)
        {
            btn_avm_gelir_giderleri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_avm_gider_gir_Leave(object sender, EventArgs e)
        {
            btn_avm_gider_gir.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_fatura_kes_Leave(object sender, EventArgs e)
        {
            btn_fatura_kes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button22_Leave(object sender, EventArgs e)
        {
            btn_geri.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            pnl_nav.Height = btn_geri.Height;
            pnl_nav.Top = btn_geri.Top;
            pnl_nav.Left = btn_geri.Left;
            btn_geri.BackColor = Color.FromArgb(46, 51, 73);


            this.Hide();
            frm_avm_yonetici_giris_ekrani avm_yonet_giris = new frm_avm_yonetici_giris_ekrani();
            avm_yonet_giris.Show();


        }

        private void btn_geri_Leave(object sender, EventArgs e)
        {
            btn_geri.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
