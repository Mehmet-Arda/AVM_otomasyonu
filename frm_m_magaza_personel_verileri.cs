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
    public partial class frm_m_magaza_personel_verileri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public int magaza_id;
        public int magaza_yonetici_id;
        public int avm_id;
        public frm_m_magaza_personel_verileri()
        {
            InitializeComponent();
        }

        private void magaza_personel_verileri_Load(object sender, EventArgs e)
        {
            //Personellerin genel verilerini datagridview'e aktarır.
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select mp.personel_adi as 'Personel Adı',mp.personel_soyadi as'Personel Soyadı',a.ili as'Adres',mp.telno as'Tel No',p.pozisyon_adi as'Pozisyon',mp.maas as'Maaş', v.vardiya_saat_araligi as'Çalışma Saatleri' From magaza_personel mp join pozisyon p on p.pozisyon_id=mp.pozisyon join vardiya v on v.vardiya_id=mp.vardiya join adres a on a.adres_id=mp.adres Where mp.calisma_yeri=@magaza_id", baglanti);
            komut2.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_magaza_personel.DataSource = dt;

            baglanti.Close();
            //*****************





            //Personellerin pozisyonlara göre maaşlarını grafiğe aktarır.
            baglanti.Open();
            ch_pozisyon_maas.Series["Maaş"].Points.Clear();
            SqlCommand komut3 = new SqlCommand("Select Distinct p.pozisyon_adi as'Pozisyon',mp.maas as'Maaş' From magaza_personel mp join pozisyon p on p.pozisyon_id=mp.pozisyon join vardiya v on v.vardiya_id=mp.vardiya join adres a on a.adres_id=mp.adres Where mp.calisma_yeri=@magaza_id", baglanti);
            komut3.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataReader okuyucu3 = komut3.ExecuteReader();

            while (okuyucu3.Read())
            {
                ch_pozisyon_maas.Series["Maaş"].Points.AddXY(okuyucu3[0], okuyucu3[1]);
            }


            baglanti.Close();
            //*****************




            //Personellerin pozisyonlara göre eleman sayısını grafiğe aktarır.
            baglanti.Open();
            ch_pozisyon_eleman.Series["Eleman Sayısı"].Points.Clear();
            SqlCommand komut4 = new SqlCommand("Select Distinct p.pozisyon_adi as'Pozisyon',count(mp.personel_id)as'Eleman Sayısı' From magaza_personel mp join pozisyon p on p.pozisyon_id=mp.pozisyon join vardiya v on v.vardiya_id=mp.vardiya join adres a on a.adres_id=mp.adres Where mp.calisma_yeri=@magaza_id group by p.pozisyon_adi", baglanti);
            komut4.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataReader okuyucu4 = komut4.ExecuteReader();

            while (okuyucu4.Read())
            {
                ch_pozisyon_eleman.Series["Eleman Sayısı"].Points.AddXY(okuyucu4[0], okuyucu4[1]);
            }


            baglanti.Close();
            //*****************





        }
    }
}
