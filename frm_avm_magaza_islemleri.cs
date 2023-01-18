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


namespace AVM_otomasyonu
{
    public partial class frm_avm_magaza_islemleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        
        public int avm_yonetici_id;
        public int avm_id;
        public frm_avm_magaza_islemleri()
        {
            InitializeComponent();
        }

        private void frm_avm_magaza_islemleri_Load(object sender, EventArgs e)
        {
            btn_kayit_goster.Enabled = false;
            btn_kayit_goster.Visible = false;
            btn_magaza_verileri.PerformClick();
          



            //Sektöre göre toplam mağaza adedini bulur, grafiğe aktarır.
            baglanti.Open();
            ch_sektor_magaza_adet.Series["Mağaza Sayısı"].Points.Clear();
            SqlCommand komut4 = new SqlCommand("Select s.sektor_adi as 'Sektör',count(m.sektor) as'Mağaza Sayısı' From magaza m join sektorler s on s.sektor_id=m.sektor  Where m.avm=@avm_id group by s.sektor_adi", baglanti);
            komut4.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataReader okuyucu4 = komut4.ExecuteReader();

            while (okuyucu4.Read())
            {
                ch_sektor_magaza_adet.Series["Mağaza Sayısı"].Points.AddXY(okuyucu4[0], okuyucu4[1]);
            }


            baglanti.Close();
            //*****************


            //Sektöre göre toplam ciroları bulur, grafiğe aktarır.
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select s.sektor_adi as'Sektör',sum(m.ciro) as'Toplam Ciro' From magaza m join sektorler s on s.sektor_id=m.sektor Where m.avm=@avm_id group by s.sektor_adi", baglanti);
            komut3.Parameters.AddWithValue("@avm_id", avm_id);
            

            ch_sektore_gore_cirolar.Series["Ciro"].Points.Clear();

            SqlDataReader okuyucu3 = komut3.ExecuteReader();
            while (okuyucu3.Read())
            {
                ch_sektore_gore_cirolar.Series["Ciro"].Points.AddXY(okuyucu3[0], okuyucu3[1]);
            }

            baglanti.Close();
            //*****************
        }

        private void btn_magaza_verileri_Click(object sender, EventArgs e)
        {
            //Mağazaların genel verilerini çeker ve datagrid'e aktarır.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select m.magaza_adi as'Mağaza Adı',s.sektor_adi as 'Sektörü',m.kira as'Kira',m.ciro as 'Ciro'  From magaza m join sektorler s on s.sektor_id=m.sektor Where m.avm=@avm_id", baglanti);
            komut0.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataAdapter da = new SqlDataAdapter(komut0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_magaza_verileri.DataSource = dt;

            baglanti.Close();
            //*****************
        }

        private void btn_kayit_goster_Click(object sender, EventArgs e)
        {
            frm_avm_magaza_kontrol magaza_istatistik = new frm_avm_magaza_kontrol();
            magaza_istatistik.btn_mgz_net_gg.Tag = btn_kayit_goster.Tag;
            magaza_istatistik.magaza_id = Convert.ToInt32(btn_kayit_goster.Tag);
            
            magaza_istatistik.Show();

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btn_kayit_goster.Tag =pictureBox1.Tag;

            btn_kayit_goster.Enabled = true;
            btn_kayit_goster.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btn_kayit_goster.Tag = pictureBox4.Tag;

            btn_kayit_goster.Enabled = true;
            btn_kayit_goster.Visible = true;
        }
    }
}
