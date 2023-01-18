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
    public partial class frm_avm_personel_verileri : Form
    {

        public frm_avm_personel_verileri()
        {
            InitializeComponent();
        }
        public int avm_id;
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");


        private void avm_personel_Load(object sender, EventArgs e)
        {
            //Personellerin genel verilerini datagridview'e aktarır.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select avmp.personel_adi as 'Personel Adı', avmp.personel_soyadi as'Personel Soyadı',poz.pozisyon_adi as 'Pozisyonu' , avmp.maas as 'Maaşı',v.vardiya_saat_araligi as 'Çalışma Saatleri'  From avm_personel avmp join pozisyon poz on poz.pozisyon_id=avmp.pozisyon join adres a on a.adres_id=avmp.adres join vardiya v on v.vardiya_id=avmp.vardiya Where avmp.calisma_yeri=@avm_id", baglanti);
            komut0.Parameters.AddWithValue("@avm_id",avm_id);
            SqlDataAdapter da = new SqlDataAdapter(komut0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_avm_personel.DataSource = dt;

            //Personellerin pozisyonlara göre maaşlarını grafiğe aktarır.
            ch_pozisyon_maas.Series["Maaş"].Points.Clear();
            SqlCommand komut1 = new SqlCommand("Select poz.pozisyon_adi, sum(avmp.maas) as 'Maaş' From avm_personel avmp join pozisyon poz on poz.pozisyon_id=avmp.pozisyon join adres a on a.adres_id=avmp.adres join vardiya v on v.vardiya_id=avmp.vardiya Where avmp.calisma_yeri=@avm_id Group By avmp.pozisyon,poz.pozisyon_adi ", baglanti);
            komut1.Parameters.AddWithValue("@avm_id",avm_id);
            SqlDataReader okuyucu1 = komut1.ExecuteReader();

            while (okuyucu1.Read()) 
            {
                ch_pozisyon_maas.Series["Maaş"].Points.AddXY(okuyucu1[0],okuyucu1[1]);
            }
            
            baglanti.Close();
            //*****************


        }
    }
}
