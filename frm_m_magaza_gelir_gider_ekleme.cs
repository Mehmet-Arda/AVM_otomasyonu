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
    public partial class frm_m_magaza_gelir_gider_ekleme : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public int magaza_id;
        public int avm_id;
        public int magaza_yonetici_id;
        public frm_m_magaza_gelir_gider_ekleme()
        {
            InitializeComponent();
        }

        private void btn_avm_personel_gider_hesapla_Click(object sender, EventArgs e)
        {
            //Personellerin maaşları toplamını ilgili textbox'a yazar.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select sum(maas) From magaza_personel  Where calisma_yeri = @magaza_id group by calisma_yeri", baglanti);
            komut0.Parameters.AddWithValue("@magaza_id", magaza_id);
            SqlDataReader okuyucu = komut0.ExecuteReader();
            while (okuyucu.Read())
            {
                txt_personel_gideri.Text = okuyucu[0].ToString();
            }


            baglanti.Close();
            //*****************


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Textbox'lara girilen avm gider miktarlarını ilgili tabloda günceller.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Update magaza_giderleri set gider_turu = (Select gider_turu_id From gider_turleri Where gider_adi = @gider_turu), gider_yeri= @magaza_id, miktar = @miktar Where gider_turu=(Select gider_turu_id From gider_turleri Where gider_adi=@gider_turu) and gider_yeri=@magaza_id", baglanti);
            komut0.Parameters.AddWithValue("@gider_turu", "Su");
            komut0.Parameters.AddWithValue("@magaza_id", magaza_id);
            komut0.Parameters.AddWithValue("@miktar", Convert.ToInt32(mtb_su_gideri.Text));
            komut0.ExecuteNonQuery();


            SqlCommand komut1 = new SqlCommand("Update magaza_giderleri set gider_turu = (Select gider_turu_id From gider_turleri Where gider_adi = @gider_turu), gider_yeri= @magaza_id, miktar = @miktar Where gider_turu=(Select gider_turu_id From gider_turleri Where gider_adi=@gider_turu) and gider_yeri=@magaza_id", baglanti);
            komut1.Parameters.AddWithValue("@gider_turu", "Elektrik");
            komut1.Parameters.AddWithValue("@magaza_id", magaza_id);
            komut1.Parameters.AddWithValue("@miktar", Convert.ToInt32(mtb_elektrik_gideri.Text));
            komut1.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("Update magaza_giderleri set gider_turu = (Select gider_turu_id From gider_turleri Where gider_adi = @gider_turu), gider_yeri= @magaza_id, miktar = @miktar Where gider_turu=(Select gider_turu_id From gider_turleri Where gider_adi=@gider_turu) and gider_yeri=@magaza_id", baglanti);
            komut2.Parameters.AddWithValue("@gider_turu", "Gaz");
            komut2.Parameters.AddWithValue("@magaza_id", magaza_id);
            komut2.Parameters.AddWithValue("@miktar", Convert.ToInt32(mtb_gaz_gideri.Text));
            komut2.ExecuteNonQuery();


            SqlCommand komut3 = new SqlCommand("Update magaza_giderleri set gider_turu = (Select gider_turu_id From gider_turleri Where gider_adi = @gider_turu), gider_yeri= @magaza_id, miktar = @miktar Where gider_turu=(Select gider_turu_id From gider_turleri Where gider_adi=@gider_turu) and gider_yeri=@magaza_id", baglanti);
            komut3.Parameters.AddWithValue("@gider_turu", "Reklam");
            komut3.Parameters.AddWithValue("@magaza_id", magaza_id);
            komut3.Parameters.AddWithValue("@miktar", Convert.ToInt32(mtb_reklam_gideri.Text));
            komut3.ExecuteNonQuery();


            SqlCommand komut4 = new SqlCommand("Update magaza_giderleri set gider_turu = (Select gider_turu_id From gider_turleri Where gider_adi = @gider_turu), gider_yeri= @magaza_id, miktar = @miktar Where gider_turu=(Select gider_turu_id From gider_turleri Where gider_adi=@gider_turu) and gider_yeri=@magaza_id", baglanti);
            komut4.Parameters.AddWithValue("@gider_turu", "Eleman");
            komut4.Parameters.AddWithValue("@magaza_id", magaza_id);
            komut4.Parameters.AddWithValue("@miktar", Convert.ToInt32(txt_personel_gideri.Text));
            komut4.ExecuteNonQuery();

            SqlCommand komut5 = new SqlCommand("Update magaza_giderleri set gider_turu = (Select gider_turu_id From gider_turleri Where gider_adi = @gider_turu), gider_yeri= @magaza_id, miktar = @miktar Where gider_turu=(Select gider_turu_id From gider_turleri Where gider_adi=@gider_turu) and gider_yeri=@magaza_id", baglanti);
            komut5.Parameters.AddWithValue("@gider_turu", "Kira");
            komut5.Parameters.AddWithValue("@magaza_id", magaza_id);
            komut5.Parameters.AddWithValue("@miktar", Convert.ToInt32(mtb_kira.Text));
            komut5.ExecuteNonQuery();



            baglanti.Close();
            //*****************





        }

       
    }
}
