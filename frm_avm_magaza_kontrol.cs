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
    public partial class frm_avm_magaza_kontrol : Form
    {
        public frm_avm_magaza_kontrol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public int magaza_id;
        public void buton_ac_kapa(Control Buton, bool x) 
        {
            Buton.Visible = x;
            Buton.Enabled = x;
            cmb_magaza_fatura_tarihi.Enabled = x;
            cmb_magaza_fatura_tarihi.Visible = x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buton_ac_kapa(btn_son_ay, true);
            buton_ac_kapa(btn_3_ay, true);
            buton_ac_kapa(button4, true);
            btn_son_ay.Tag = magaza_id;
            btn_3_ay.Tag = magaza_id;
            button4.Tag = magaza_id;
        }

        private void avmy_magaza_kontrol_Load(object sender, EventArgs e)
        {
            
            buton_ac_kapa(btn_son_ay, false);
            buton_ac_kapa(btn_3_ay, false);
            buton_ac_kapa(button4, false);

            //Mağaza fatura kesim tarihlerinin seçilebilir olması amacıyla combobox'a aktarılması.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select fatura_kesim_tarihi From magaza_net_gelir_gider Where magaza=@magaza_id", baglanti);
            komut0.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataReader okuyucu = komut0.ExecuteReader();

            //MessageBox.Show(magaza_id.ToString());

            while (okuyucu.Read()) 
            {
                cmb_magaza_fatura_tarihi.Items.Add(okuyucu[0]);
            }
            baglanti.Close();
            //*****************
        }
        //Select musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro',giderler_toplami as 'Giderler Toplamı'From magaza_net_gelir_gider Where fatura_kesim_tarihi = (Select max(fatura_kesim_tarihi) From magaza_net_gelir_gider Where magaza = @magaza_id) and magaza = @magaza_id
        private void button2_Click(object sender, EventArgs e)
        {
            //Mağazanın son aya ait net gelir giderinin ilgili grafik ve tabloya aktarılması.
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select fatura_kesim_tarihi as'Fatura Tarihi', musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro', giderler_toplami as 'Giderler Toplamı'From magaza_net_gelir_gider Where fatura_kesim_tarihi = (Select max(fatura_kesim_tarihi) From magaza_net_gelir_gider Where magaza = @magaza_id) and magaza = @magaza_id", baglanti);
            komut1.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            ch_mcg.Series["Müşteri"].Points.Clear();
            ch_mcg.Series["Ciro"].Points.Clear();
            ch_mcg.Series["GiderToplam"].Points.Clear();

            SqlDataReader okuyucu = komut1.ExecuteReader();
            while (okuyucu.Read()) 
            {
                ch_mcg.Series["Müşteri"].Points.AddXY(okuyucu[0].ToString(), okuyucu[1]);
                ch_mcg.Series["Ciro"].Points.AddXY(okuyucu[0].ToString(), okuyucu[2]);
                ch_mcg.Series["GiderToplam"].Points.AddXY(okuyucu[0].ToString(), okuyucu[3]);
            }

            baglanti.Close();
            //*****************
        }
        //Select fatura_kesim_tarihi as'Fatura Tarihi',musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro', giderler_toplami as 'Giderler Toplamı' From magaza_net_gelir_gider Where fatura_kesim_tarihi in (Select top 3(fatura_kesim_tarihi) From magaza_net_gelir_gider  Where magaza = @magaza_id order by fatura_kesim_tarihi) and magaza = @magaza_id
        private void button3_Click(object sender, EventArgs e)
        {
            //Mağazanın son 3 aya ait net gelir giderinin ilgili grafik ve tabloya aktarılması.
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select fatura_kesim_tarihi as'Fatura Tarihi',musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro', giderler_toplami as 'Giderler Toplamı' From magaza_net_gelir_gider Where fatura_kesim_tarihi in (Select top 3(fatura_kesim_tarihi) From magaza_net_gelir_gider  Where magaza = @magaza_id order by fatura_kesim_tarihi) and magaza = @magaza_id", baglanti);
            komut2.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            ch_mcg.Series["Müşteri"].Points.Clear();
            ch_mcg.Series["Ciro"].Points.Clear();
            ch_mcg.Series["GiderToplam"].Points.Clear();
            SqlDataReader okuyucu = komut2.ExecuteReader();
            while (okuyucu.Read())
            {
                ch_mcg.Series["Müşteri"].Points.AddXY(okuyucu[0], okuyucu[1]);
                ch_mcg.Series["Ciro"].Points.AddXY(okuyucu[0], okuyucu[2]);
                ch_mcg.Series["GiderToplam"].Points.AddXY(okuyucu[0], okuyucu[3]);
            }

            baglanti.Close();
            //*****************

        }//"exec Magaza_Personel_Bilgi @magaza_id"
        //Select mp.personel_adi, mp.personel_soyadi, poz.pozisyon_adi, mp.maas, v.vardiya_saat_araligi From magaza_personel mp inner join pozisyon poz on poz.pozisyon_id = mp.pozisyon inner join vardiya v on v.vardiya_id = mp.vardiya inner join adres a on a.adres_id = mp.adres Where mp.calisma_yeri=@magaza_id
        private void btn_mgz_prsnl_Click(object sender, EventArgs e)
        {
            //Mağazanın genel personel bilgilerini çekip tabloya aktarılması.
            SqlCommand komut3 = new SqlCommand("Select mp.personel_adi as 'Personel Adı', mp.personel_soyadi as 'Personel Soyadı', poz.pozisyon_adi as 'Pozisyon', mp.maas as'Maaş', v.vardiya_saat_araligi as'Vardiya' From magaza_personel mp inner join pozisyon poz on poz.pozisyon_id = mp.pozisyon inner join vardiya v on v.vardiya_id = mp.vardiya inner join adres a on a.adres_id = mp.adres Where mp.calisma_yeri=@magaza_id", baglanti);
            komut3.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            dataGridView2.DataSource = dt3;

            //*****************
        }
        //Select gitur.gider_adi as'Gider Adı', mg.miktar as'Miktar' From magaza_giderleri mg join gider_turleri gitur on gitur.gider_tur_id= mg.gider_turu Where gider_yeri = @magaza_id
        private void btn_mgz_gg_Click(object sender, EventArgs e)
        {
            //Mağazanın gider türüne göre gider miktarlarını tablo ve grafiğe aktarılması.
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select gitur.gider_adi as'Gider Adı', mg.miktar as'Miktar' From magaza_giderleri mg join gider_turleri gitur on gitur.gider_turu_id= mg.gider_turu Where gider_yeri = @magaza_id", baglanti);
            komut4.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dataGridView3.DataSource = dt4;

            chart3.Series["Giderler"].Points.Clear();

            SqlDataReader okuyucu = komut4.ExecuteReader();
            while (okuyucu.Read()) 
            {
                chart3.Series["Giderler"].Points.AddXY(okuyucu[0], okuyucu[1]);
            }
            baglanti.Close();
            //*****************


        }
        //Select musteri_sayisi as 'Müşteri Sayısı', ciro as 'Ciro',giderler_toplami as 'Giderler Toplamı'From magaza_net_gelir_gider Where fatura_kesim_tarihi = '2018-04-21' and magaza = 1
        private void cmb_fatura_tarihi_SelectedIndexChanged(object sender, EventArgs e)
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

            ch_mcg.Series["Müşteri"].Points.Clear();
            ch_mcg.Series["Ciro"].Points.Clear();
            ch_mcg.Series["GiderToplam"].Points.Clear();
            SqlDataReader okuyucu = komut4.ExecuteReader();
            while (okuyucu.Read())
            {
                ch_mcg.Series["Müşteri"].Points.AddXY(tarih, okuyucu[0]);
                ch_mcg.Series["Ciro"].Points.AddXY(tarih, okuyucu[1]);
                ch_mcg.Series["GiderToplam"].Points.AddXY(tarih, okuyucu[2]);
            }

            baglanti.Close();
            //*****************
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            frm_avm_magaza_islemleri avmk = new frm_avm_magaza_islemleri();
            avmk.btn_kayit_goster.Visible = false;
            avmk.btn_kayit_goster.Enabled = false;
            this.Hide();
        }
    }
}
