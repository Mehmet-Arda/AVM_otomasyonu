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
    public partial class frm_m_magaza_ana_sayfa : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public int magaza_id;
        public int magaza_yonetici_id;
        public int avm_id;
        public frm_m_magaza_ana_sayfa()
        {
            InitializeComponent();
        }

        private void frm_magaza_ana_sayfa_Load(object sender, EventArgs e)
        {
            //Mağazanın genel bilgilerini, mağaza id'yi parametre olarak kullanarak,
            //çağırılıp ilgili label'ların text'ine yazılması.
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select  m.magaza_adi as 'Mağaza Adı' ,s.sektor_adi as'Sektörü',m.calisan_sayisi as'Çalışan Sayısı',m.avm,m.kira as 'Kira',m.borc as'Borç',m.ciro as 'Ciro', m.acilis_tarihi as 'Açılış Tarihi' From magaza m join sektorler s on s.sektor_id=m.sektor Where m.magaza_id=@magaza_id", baglanti);
            komut1.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataReader okuyucu1 = komut1.ExecuteReader();

            while (okuyucu1.Read())
            {
                lbl_magaza_adi.Text = okuyucu1[0].ToString();
                lbl_magaza_sektor.Text = okuyucu1[1].ToString();
                lbl_calisan_sayisi.Text = okuyucu1[2].ToString();
                lbl_kira.Text = okuyucu1[4].ToString();
                lbl_borc.Text = okuyucu1[5].ToString();
                lbl_ciro.Text = okuyucu1[6].ToString();
                lbl_acilis_tarihi.Text = okuyucu1[6].ToString();
                avm_id = Convert.ToInt32(okuyucu1[3]);
            }
            baglanti.Close();
            //*****************
            lbl_magaza_id.Text = magaza_id.ToString();




            //Mağaza fatura kesim tarihlerinin seçilebilir olması amacıyla combobox'a aktarılması.
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select fatura_kesim_tarihi From magaza_net_gelir_gider Where magaza=@magaza_id", baglanti);
            komut5.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataReader okuyucu5 = komut5.ExecuteReader();

            //MessageBox.Show(magaza_id.ToString());

            while (okuyucu5.Read())
            {
                cmb_magaza_fatura_tarihi.Items.Add(okuyucu5[0]);
            }
            baglanti.Close();
            //*****************
            btn_net_gg_uc_ay.PerformClick();


        }

        private void btn_net_gg_son_ay_Click(object sender, EventArgs e)
        {
            //Mağazanın son aya ait net gelir ve giderlerini, ilgili tablo ve grafiğe çağırılıp aktarılması.
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select fatura_kesim_tarihi as'Fatura Tarihi',musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro',giderler_toplami as 'Giderler Toplamı'From magaza_net_gelir_gider Where fatura_kesim_tarihi = (Select max(fatura_kesim_tarihi) From magaza_net_gelir_gider Where magaza = @magaza_id) and magaza = @magaza_id", baglanti);
            komut6.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da2 = new SqlDataAdapter(komut6);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            chart2.Series["Müşteri"].Points.Clear();
            chart1.Series["Ciro"].Points.Clear();
            chart1.Series["GiderToplam"].Points.Clear();
            SqlDataReader okuyucu6 = komut6.ExecuteReader();
            while (okuyucu6.Read())
            {
                chart2.Series["Müşteri"].Points.AddXY(okuyucu6[0], okuyucu6[1]);
                chart1.Series["Ciro"].Points.AddXY(okuyucu6[0], okuyucu6[2]);
                chart1.Series["GiderToplam"].Points.AddXY(okuyucu6[0], okuyucu6[3]);
            }

            baglanti.Close();

            //*****************
        }

        private void btn_net_gg_uc_ay_Click(object sender, EventArgs e)
        {
            //Mağazanın son 3 aya ait net gelir ve giderlerini, ilgili tablo ve grafiğe çağırılıp aktarılması.
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select fatura_kesim_tarihi as'Fatura Tarihi',musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro', giderler_toplami as 'Giderler Toplamı' From magaza_net_gelir_gider Where fatura_kesim_tarihi in (Select top 3(fatura_kesim_tarihi) From magaza_net_gelir_gider  Where magaza = @magaza_id order by fatura_kesim_tarihi) and magaza = @magaza_id", baglanti);
            komut7.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da7 = new SqlDataAdapter(komut7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            dataGridView1.DataSource = dt7;


            chart2.Series["Müşteri"].Points.Clear();
            chart1.Series["Ciro"].Points.Clear();
            chart1.Series["GiderToplam"].Points.Clear();
            SqlDataReader okuyucu7 = komut7.ExecuteReader();
            while (okuyucu7.Read())
            {
                chart2.Series["Müşteri"].Points.AddXY(okuyucu7[0], okuyucu7[1]);
                chart1.Series["Ciro"].Points.AddXY(okuyucu7[0], okuyucu7[2]);
                chart1.Series["GiderToplam"].Points.AddXY(okuyucu7[0], okuyucu7[3]);

            }

            baglanti.Close();
            //*****************
            




        }

        private void cmb_magaza_fatura_tarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox'ta yer alan fatura tarihlerinden biri seçildiğinde, seçilen tarihe ait
            //net gelir giderin tekrardan ilgili tablo ve grafiklere aktarılması.
            baglanti.Open();
            string tarih = cmb_magaza_fatura_tarihi.SelectedItem.ToString();
            SqlCommand komut4 = new SqlCommand("Select musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro',giderler_toplami as 'Giderler Toplamı'From magaza_net_gelir_gider Where fatura_kesim_tarihi = @tarih and magaza = @magaza_id", baglanti);
            komut4.Parameters.AddWithValue("@tarih", cmb_magaza_fatura_tarihi.SelectedItem);
            komut4.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            chart2.Series["Müşteri"].Points.Clear();
            chart1.Series["Ciro"].Points.Clear();
            chart1.Series["GiderToplam"].Points.Clear();
            SqlDataReader okuyucu = komut4.ExecuteReader();
            while (okuyucu.Read())
            {
                chart2.Series["Müşteri"].Points.AddXY(tarih, okuyucu[0]);
                chart1.Series["Ciro"].Points.AddXY(tarih, okuyucu[1]);
                chart1.Series["GiderToplam"].Points.AddXY(tarih, okuyucu[2]);
            }

            baglanti.Close();
            //*****************



        }

        private void btn_net_gg_tum_zamanlar_Click(object sender, EventArgs e)
        {
            //Mağazanın tüm zamanlara ait net gelir ve giderlerini, ilgili tablo ve grafiğe çağırılıp aktarılması.
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select fatura_kesim_tarihi as'Fatura Tarihi',musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro', giderler_toplami as 'Giderler Toplamı' From magaza_net_gelir_gider Where magaza = @magaza_id", baglanti);
            komut7.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da7 = new SqlDataAdapter(komut7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            dataGridView1.DataSource = dt7;


            chart2.Series["Müşteri"].Points.Clear();
            chart1.Series["Ciro"].Points.Clear();
            chart1.Series["GiderToplam"].Points.Clear();
            SqlDataReader okuyucu7 = komut7.ExecuteReader();
            while (okuyucu7.Read())
            {
                chart2.Series["Müşteri"].Points.AddXY(okuyucu7[0], okuyucu7[1]);
                chart1.Series["Ciro"].Points.AddXY(okuyucu7[0], okuyucu7[2]);
                chart1.Series["GiderToplam"].Points.AddXY(okuyucu7[0], okuyucu7[3]);

            }

            baglanti.Close();
            //*****************

        }
    }
}
