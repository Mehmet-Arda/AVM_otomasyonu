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
    public partial class frm_avm_personel_islemleri : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");
        public frm_avm_personel_islemleri()
        {
            InitializeComponent();
        }
        public int avm_id;
        public int personel_id;


        private void avm_personel_ekleme_Load(object sender, EventArgs e)
        {
            //Personellerin bulunabileceği mesleki konumları tablodan çağırıp combobox'a kaydeder.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select pozisyon_adi as 'Pozisyon' From pozisyon",baglanti);
            SqlDataReader okuyucu0 = komut0.ExecuteReader();

            while (okuyucu0.Read()) 
            {
                cmb_pozisyon.Items.Add(okuyucu0[0]);
            }
            baglanti.Close();
            //*****************

            //Personellerin vardiya saat aralığını combobox'a aktarır.
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select vardiya_saat_araligi as 'Vardiya' From vardiya", baglanti);
            SqlDataReader okuyucu1 = komut1.ExecuteReader();

            while (okuyucu1.Read())
            {
                cmb_vardiya.Items.Add(okuyucu1[0]);
            }


            baglanti.Close();
            //*****************
            lbl_per_id.Text = "";


        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            //Personele ait (textbox'a vs.) girilen bilgiler ile personel tablosuna yeni bir kayıt ekler.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Insert avm_personel(personel_adi, personel_soyadi, telno,adres, pozisyon, calisma_yeri, maas, vardiya) VALUES(@ad, @soyad, @telNo,1, (Select pozisyon_id From pozisyon Where pozisyon_adi = @pozisyon), @avm_id, @maas, (Select vardiya_id From vardiya Where vardiya_saat_araligi = @vardiya))",baglanti);
            komut0.Parameters.AddWithValue("@ad",txt_ad.Text);
            komut0.Parameters.AddWithValue("@soyad",txt_soyad.Text);
            komut0.Parameters.AddWithValue("@telNo",mtb_telNo.Text);
            komut0.Parameters.AddWithValue("@pozisyon",cmb_pozisyon.SelectedItem);
            komut0.Parameters.AddWithValue("@avm_id",avm_id);
            komut0.Parameters.AddWithValue("@maas",mtb_maas.Text);
            komut0.Parameters.AddWithValue("@vardiya",cmb_vardiya.SelectedItem);
            komut0.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi");

            baglanti.Close();
            //*****************


        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            //Personellerin genel verilerini tablodan çağırıp ilgili datagrid'e aktarır.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select avmp.personel_adi as 'Personel Adı', avmp.personel_soyadi as'Personel Soyadı',poz.pozisyon_adi as 'Pozisyonu' , avmp.maas as 'Maaşı',v.vardiya_saat_araligi as 'Çalışma Saatleri'  From avm_personel avmp join pozisyon poz on poz.pozisyon_id=avmp.pozisyon join adres a on a.adres_id=avmp.adres join vardiya v on v.vardiya_id=avmp.vardiya Where avmp.calisma_yeri=@avm_id", baglanti);
            komut0.Parameters.AddWithValue("@avm_id", avm_id);
            SqlDataAdapter da = new SqlDataAdapter(komut0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_personel_listesi.DataSource = dt;
            baglanti.Close();
            //*****************
        }

        
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //Personele ait (textbox'a vs.) girilen bilgiler ile personel tablosunda varolan kaydı günceller.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Update avm_personel Set personel_adi =@ad, personel_soyadi = @soyad, telno = @telNo,adres=@adres, pozisyon = (Select pozisyon_id From pozisyon Where pozisyon_adi=@pozisyon),calisma_yeri=@avm_id,maas=@maas,vardiya=(Select vardiya_id From vardiya Where vardiya_saat_araligi=@vardiya) Where avm_personel.personel_id=@personel_id", baglanti);
            komut0.Parameters.AddWithValue("@ad", txt_ad.Text);
            komut0.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            komut0.Parameters.AddWithValue("@telNo", mtb_telNo.Text);
            komut0.Parameters.AddWithValue("@pozisyon", cmb_pozisyon.SelectedItem);
            komut0.Parameters.AddWithValue("@avm_id", avm_id);
            komut0.Parameters.AddWithValue("@maas", Convert.ToInt32(mtb_maas.Text));
            komut0.Parameters.AddWithValue("@vardiya", cmb_vardiya.SelectedItem);
            komut0.Parameters.AddWithValue("@adres", 1);
            komut0.Parameters.AddWithValue("@personel_id",personel_id);
            komut0.ExecuteNonQuery();
            MessageBox.Show("Personel Güncellendi");

            baglanti.Close();
            //*****************

        }
        
        private void dg_personel_listesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Personel verilerini tutan datagrid'de herhangi bir hücreye tıklandığında,
            //o personele ait verilerin ilgili texbox'a vs. yazılır.

            txt_ad.Text = dg_personel_listesi.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_soyad.Text = dg_personel_listesi.Rows[e.RowIndex].Cells[1].Value.ToString();
            //mtb_telNo.Text= dg_personel_listesi.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_pozisyon.SelectedItem = dg_personel_listesi.Rows[e.RowIndex].Cells[2].Value;
            mtb_maas.Text = dg_personel_listesi.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmb_vardiya.SelectedItem = dg_personel_listesi.Rows[e.RowIndex].Cells[4].Value;

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select personel_id From avm_personel Where personel_adi=@ad and personel_soyadi=@soyad and pozisyon=(Select pozisyon_id From pozisyon Where pozisyon_adi=@pozisyon)", baglanti);
            komut1.Parameters.AddWithValue("@ad", txt_ad.Text);
            komut1.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            komut1.Parameters.AddWithValue("@pozisyon", cmb_pozisyon.SelectedItem);
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read())
            {
                personel_id = Convert.ToInt32(oku[0]);
                lbl_per_id.Text =string.Format("Personel id: {0}",oku[0].ToString());
                //MessageBox.Show(personel_id.ToString());
            }

            baglanti.Close();

            //*****************
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            //Personel adı textbox'ına girilen ada göre personel tablosunda arama işlemi yapar ve bulduğunda
            //sadece o elemana ait verileri listeler.

            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select avmp.personel_adi as 'Personel Adı', avmp.personel_soyadi as'Personel Soyadı',poz.pozisyon_adi as 'Pozisyonu' , avmp.maas as 'Maaşı',v.vardiya_saat_araligi as 'Çalışma Saatleri'  From avm_personel avmp join pozisyon poz on poz.pozisyon_id=avmp.pozisyon join adres a on a.adres_id=avmp.adres join vardiya v on v.vardiya_id=avmp.vardiya Where avmp.calisma_yeri=@avm_id and avmp.personel_adi like @personel_adi", baglanti);
            komut0.Parameters.AddWithValue("@avm_id", avm_id);
            komut0.Parameters.AddWithValue("@personel_adi", txt_ad.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut0);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_personel_listesi.DataSource = dt;
            baglanti.Close();
            
            //*****************
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ad.Text= "";
            txt_soyad.Text = "";
            mtb_maas.Text = "";
            mtb_telNo.Text = "";
            cmb_pozisyon.SelectedIndex = -1;
            cmb_vardiya.SelectedIndex = -1;
            lbl_per_id.Text = "";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //Seçili personel id'sine ait personelin verilerini tablodan siler.
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Delete From avm_personel Where personel_id=@personel_id", baglanti);
            komut0.Parameters.AddWithValue("@personel_id", personel_id);
            komut0.ExecuteNonQuery();
            MessageBox.Show("Personel Silindi");
            baglanti.Close();
            //*****************

        }
    }
}
