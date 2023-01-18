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
    public partial class frm_avm_ana_sayfa : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");

        public frm_avm_ana_sayfa()
        {
            InitializeComponent();
        }
        public int avm_yonetici_id;
        public int avm_id;
      

        private void frm_avm_ana_sayfa_Load(object sender, EventArgs e)
        {

            //Giriş yapan yöneticinin id bilgisiyle, personel tablosundan yönettiği avm id'sinin alınması.
            baglanti.Open();
           
            SqlCommand komut0 = new SqlCommand("Select calisma_yeri From avm_personel Where personel_id=@yonetici_id", baglanti);
            komut0.Parameters.AddWithValue("@yonetici_id", avm_yonetici_id);
            SqlDataReader okuyucu0 = komut0.ExecuteReader();
            while (okuyucu0.Read())
            {
                avm_id = Convert.ToInt32(okuyucu0[0]);
                lbl_avm_id.Text = okuyucu0[0].ToString();
            }
            baglanti.Close();
            //*****************

            btn_uc_ay_veriler.PerformClick();
            


            //Avm fatura kesim tarihlerinin seçilebilir olması amacıyla combobox'a aktarılması.
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select tarih From avm_net_gelir_gider Where avm=@avm_id", baglanti);
            komut2.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                cmb_avm_fatura_tarihi.Items.Add(okuyucu2[0]);
            }
            baglanti.Close();
            //*****************



            //Avm'nin genel bilgilerinin, avm id'yi parametre olarak kullanarak,
            //çağırılıp ilgili label'ların text'ine yazılması.
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select  avm.avm_adi as 'Avm Adı', avm.personel_sayisi as'Çalışan Sayısı', avm.ziyaretci_sayisi as 'Ziyaretçi Sayısı',avm.ciro as 'Ciro', avm.acilis_tarihi as 'Açılış Tarihi',avm.acilis_kapanis_saati From avm Where avm.avm_id=@avm_id", baglanti);
            komut5.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataReader okuyucu5 = komut5.ExecuteReader();

            while (okuyucu5.Read())
            {
                lbl_avm_adi.Text = okuyucu5[0].ToString();
                lbl_avm_ziyaretci.Text = okuyucu5[2].ToString();
                lbl_personel.Text = okuyucu5[1].ToString();
                lbl_ciro.Text = okuyucu5[3].ToString();
                lbl_acilis_tarihi.Text = okuyucu5[4].ToString();
                lbl_acilis_kapanis.Text = okuyucu5[5].ToString();
                lbl_avm_id.Text = avm_id.ToString();
            }
            baglanti.Close();
            //*****************





        }

        private void btn_personel_islemlerii_Click(object sender, EventArgs e)
        {

        }

        private void btn_son_ay_veriler_Click_1(object sender, EventArgs e)
        {
            //Avm'nin son aya ait net gelir ve giderlerini, ilgili tablo ve grafiğe çağırılıp aktarılması.
            baglanti.Open();
            //Select ziyaretci_sayisi as'Ziyaretçi Sayısı',giderler_toplami as'Giderler Toplamı', gelirler_toplami as 'Gelirler Toplamı', tarih as 'Fatura Tarihi' From avm_net_gelir_gider Where avm=@avm_id and tarih=(Select max(tarih) From avm_net_gelir_gider Where avm=@avm_id)
            SqlCommand komut1 = new SqlCommand("Select ziyaretci_sayisi as'Ziyaretçi Sayısı', gelirler_toplami as 'Gelirler Toplamı',giderler_toplami as'Giderler Toplamı', tarih as 'Fatura Tarihi'  From avm_net_gelir_gider Where tarih=(Select max(tarih) From avm_net_gelir_gider Where avm=@avm_id)and avm=@avm_id", baglanti);
            komut1.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            avm_net_gg_dg.DataSource = dt;


            avm_net_gg_chart.Series["Toplam Gelir"].Points.Clear();
            avm_net_gg_chart.Series["Toplam Gider"].Points.Clear();

            avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.Clear();

            SqlDataReader okuyucu1 = komut1.ExecuteReader();
            while (okuyucu1.Read())
            {
                avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.AddXY(okuyucu1[3], okuyucu1[0]);
                avm_net_gg_chart.Series["Toplam Gelir"].Points.AddXY(okuyucu1[3], okuyucu1[1]);
                avm_net_gg_chart.Series["Toplam Gider"].Points.AddXY(okuyucu1[3], okuyucu1[2]);
            }
            baglanti.Close();
            //*****************

        }

        private void btn_tum_veriler_Click_1(object sender, EventArgs e)
        {
            //Avm'nin tüm zamanlara ait net gelir ve giderlerini, ilgili tablo ve grafiğe çağırılıp aktarılması.
            baglanti.Open();
            //Select ziyaretci_sayisi as'Ziyaretçi Sayısı',giderler_toplami as'Giderler Toplamı', gelirler_toplami as 'Gelirler Toplamı', tarih as 'Fatura Tarihi' From avm_net_gelir_gider Where avm=@avm_id and tarih=(Select max(tarih) From avm_net_gelir_gider Where avm=@avm_id)
            SqlCommand komut1 = new SqlCommand("Select ziyaretci_sayisi as 'Ziyaretçi Sayısı', gelirler_toplami as 'Gelirler Toplamı', giderler_toplami as'Giderler Toplamı', tarih as 'Fatura Tarihi'  From avm_net_gelir_gider Where avm = @avm_id", baglanti);
            komut1.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            avm_net_gg_dg.DataSource = dt;


            avm_net_gg_chart.Series["Toplam Gelir"].Points.Clear();
            avm_net_gg_chart.Series["Toplam Gider"].Points.Clear();

            avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.Clear();

            SqlDataReader okuyucu1 = komut1.ExecuteReader();
            while (okuyucu1.Read())
            {
                avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.AddXY(okuyucu1[3], okuyucu1[0]);
                avm_net_gg_chart.Series["Toplam Gelir"].Points.AddXY(okuyucu1[3], okuyucu1[1]);
                avm_net_gg_chart.Series["Toplam Gider"].Points.AddXY(okuyucu1[3], okuyucu1[2]);
            }
            baglanti.Close();
            //*****************

        }

        private void cmb_avm_fatura_tarihi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Combobox'ta yer alan fatura tarihlerinden biri seçildiğinde, seçilen tarihe ait
            //net gelir giderin tekrardan ilgili tablo ve grafiklere aktarılması.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select ziyaretci_sayisi as'Ziyaretçi Sayısı', gelirler_toplami as 'Gelirler Toplamı',giderler_toplami as'Giderler Toplamı', tarih as 'Fatura Tarihi'  From avm_net_gelir_gider Where tarih=@tarih and avm=@avm_id", baglanti);
            komut0.Parameters.AddWithValue("@tarih", cmb_avm_fatura_tarihi.SelectedItem);
            komut0.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataAdapter da = new SqlDataAdapter(komut0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            avm_net_gg_dg.DataSource = dt;


            avm_net_gg_chart.Series["Toplam Gelir"].Points.Clear();
            avm_net_gg_chart.Series["Toplam Gider"].Points.Clear();

            avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.Clear();

            SqlDataReader okuyucu = komut0.ExecuteReader();
            while (okuyucu.Read())
            {
                avm_net_gg_chart.Series["Toplam Gelir"].Points.AddXY(okuyucu[3], okuyucu[1]);
                avm_net_gg_chart.Series["Toplam Gider"].Points.AddXY(okuyucu[3], okuyucu[2]);

                avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.AddXY(okuyucu[3], okuyucu[0]);
            }

            baglanti.Close();
            //*****************
        }

        private void btn_avm_giderlerii_Click(object sender, EventArgs e)
        {

        }

        private void btn_avm_gelirlerii_Click(object sender, EventArgs e)
        {

        }

        private void btn_personel_islemlerii_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_uc_ay_veriler_Click(object sender, EventArgs e)
        {
            //Avm'nin son 3 aya ait net gelir ve giderlerini, ilgili tablo ve grafiğe çağırılıp aktarılması.
            baglanti.Open();
            //Select ziyaretci_sayisi as'Ziyaretçi Sayısı',giderler_toplami as'Giderler Toplamı', gelirler_toplami as 'Gelirler Toplamı', tarih as 'Fatura Tarihi' From avm_net_gelir_gider Where avm=@avm_id and tarih=(Select max(tarih) From avm_net_gelir_gider Where avm=@avm_id)
            SqlCommand komut1 = new SqlCommand("Select ziyaretci_sayisi as 'Ziyaretçi Sayısı', gelirler_toplami as 'Gelirler Toplamı', giderler_toplami as'Giderler Toplamı', tarih as 'Fatura Tarihi'  From avm_net_gelir_gider Where tarih in (Select top 3 tarih From avm_net_gelir_gider order by tarih desc)and avm = @avm_id", baglanti);
            komut1.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            avm_net_gg_dg.DataSource = dt;


            avm_net_gg_chart.Series["Toplam Gelir"].Points.Clear();
            avm_net_gg_chart.Series["Toplam Gider"].Points.Clear();

            avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.Clear();

            SqlDataReader okuyucu1 = komut1.ExecuteReader();
            while (okuyucu1.Read())
            {
                avm_ziyaretci_chart.Series["Ziyaretçi Sayısı"].Points.AddXY(okuyucu1[3], okuyucu1[0]);
                avm_net_gg_chart.Series["Toplam Gelir"].Points.AddXY(okuyucu1[3], okuyucu1[1]);
                avm_net_gg_chart.Series["Toplam Gider"].Points.AddXY(okuyucu1[3], okuyucu1[2]);
            }
            baglanti.Close();
            //*****************
        }


    }
}
