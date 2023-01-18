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
    public partial class frm_m_magaza_giderleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public int magaza_id;
        public int magaza_yonetici_id;
        public int avm_id;
        public frm_m_magaza_giderleri()
        {
            InitializeComponent();
        }

        private void frm_m_magaza_giderleri_Load(object sender, EventArgs e)
        {
            //Giderler

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select gitur.gider_adi as'Gider Adı', mg.miktar as'Miktar' From magaza_giderleri mg join gider_turleri gitur on gitur.gider_turu_id= mg.gider_turu Where gider_yeri = @magaza_id", baglanti);
            komut6.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataAdapter da6 = new SqlDataAdapter(komut6);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            dg_magaza_giderler.DataSource = dt6;

            ch_gider_turu_giderler.Series["Giderler"].Points.Clear();

            SqlDataReader okuyucu6 = komut6.ExecuteReader();
            while (okuyucu6.Read())
            {
                ch_gider_turu_giderler.Series["Giderler"].Points.AddXY(okuyucu6[0], okuyucu6[1]);
            }
            baglanti.Close();

        }
    }
}
