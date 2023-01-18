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
    public partial class frm_avm_gelir_giderleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public frm_avm_gelir_giderleri()
        {
            InitializeComponent();
        }
        public int avm_id;
        private void avm_giderleri_Load(object sender, EventArgs e)
        {
            //Gider türü ve miktarını ilgili datagridview'e ve grafiğe yazar.
            baglanti.Open();

            ch_avm_giderler.Series["Miktar"].Points.Clear();
            SqlCommand komut1 = new SqlCommand("Select gidertur.gider_adi as'Gider Türü', avmgider.miktar as'Miktar' From avm_giderleri avmgider join gider_turleri gidertur on gidertur.gider_turu_id=avmgider.gider_turu Where avmgider.avm=@avm_id ", baglanti);
            komut1.Parameters.AddWithValue("@avm_id", avm_id);

            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_avm_giderler.DataSource = dt;


            SqlDataReader okuyucu1 = komut1.ExecuteReader();

            while (okuyucu1.Read())
            {
                ch_avm_giderler.Series["Miktar"].Points.AddXY(okuyucu1[0], okuyucu1[1]);
            }
            //ch_avm_gelirler.Series["Miktar"].Label = "";

            baglanti.Close();

            //*****************


            //Gelir türü ve miktarını ilgili datagridview'e ve grafiğe yazar.
            baglanti.Open();

            ch_avm_gelirler.Series["Miktar"].Points.Clear();
            SqlCommand komut2 = new SqlCommand("Select gelirtur.gelir_turu_adi as'Gelir Türü', avmgelir.miktar as'Miktar' From avm_gelirler avmgelir join gelir_turleri gelirtur on gelirtur.gelir_turu_id=avmgelir.gelir_turu Where avmgelir.avm=@avm_id", baglanti);
            komut2.Parameters.AddWithValue("@avm_id", avm_id);

            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dg_avm_gelirler.DataSource = dt2;


            SqlDataReader okuyucu2 = komut2.ExecuteReader();
            while (okuyucu2.Read())
            {
                ch_avm_gelirler.Series["Miktar"].Points.AddXY(okuyucu2[0], okuyucu2[1]);
            }
            //ch_avm_gelirler.Series["Miktar"].Label = "";

            baglanti.Close();

            //*****************



        }

        private void ch_avm_giderler_Click(object sender, EventArgs e)
        {

        }
    }
}
