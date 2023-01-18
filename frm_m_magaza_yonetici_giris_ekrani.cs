﻿using System;
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
    public partial class frm_m_magaza_yonetici_giris_ekrani : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = YUKSEL\SQLEXPRESS; Initial Catalog = avm_otomasyon; Integrated Security = True");

        public frm_m_magaza_yonetici_giris_ekrani()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            //Mağaza yönetici tablosundan kayıtlı yöneticilerin,
            //kullanıcı adı ve şifre bilgilerinin key-value listesine kaydeder.
            int yonetici_personel_no = 0;
            baglanti.Open();
            string kullanici_adi = txt_kullanici_adi.Text;
            int sifre = Convert.ToInt32(txt_sifre.Text);
            SqlCommand komut = new SqlCommand("Select * From magaza_yonetici", baglanti);
            SqlDataReader okuyucu = komut.ExecuteReader();
            List<KeyValuePair<string, int>> lst = new List<KeyValuePair<string, int>>();

            while (okuyucu.Read())
            {
                lst.Add(new KeyValuePair<string, int>(okuyucu[1].ToString(), Convert.ToInt32(okuyucu[2])));
            }

            baglanti.Close();


            //Giriş ekranında girilen kullanıcı adı ve şifrenin key-value listesinde olup olmadığının kontrolünü yapar.
            //Böylece girilen veriler bir yöneticiye mi ait tespit edilir.
            //Çünkü o listede sadece yöneticilerin kullanıcı adı-şifre bilgileri kayıtlıdır.
            if (lst.Contains(new KeyValuePair<string, int>(kullanici_adi, sifre)))
            {
                //Eğer girilen bilgiler listedeyse aşağıdaki komut, o kullanıcı adı ve şifreye sahip
                //yöneticinin personel id'sini bulur ve değişkene kaydeder.
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Select personel From magaza_yonetici my Where my.kullanici_adi=@ka and my.sifre=@sifre", baglanti);
                komut2.Parameters.AddWithValue("@ka", kullanici_adi);
                komut2.Parameters.AddWithValue("@sifre", sifre);
                SqlDataReader okuyucu2 = komut2.ExecuteReader();


                while (okuyucu2.Read())
                {
                    yonetici_personel_no = Convert.ToInt32(okuyucu2[0]);
                }
                baglanti.Close();
                //*****************


                //Bulunan personel numarasına ait yöneticinin bilgileri, personel tablosundan çekilir.
                //Devamında bir sonraki "yönetici ekranı" formunu açar.
                baglanti.Open();

                frm_m_magaza_yonetici_ekrani m_yonet_ekrani = new frm_m_magaza_yonetici_ekrani();

                SqlCommand komut3 = new SqlCommand("Select personel_adi,personel_soyadi From magaza_personel Where personel_id=@yonetici_id", baglanti);
                komut3.Parameters.AddWithValue("@yonetici_id", yonetici_personel_no);
                SqlDataReader okuyucu3 = komut3.ExecuteReader();
                while (okuyucu3.Read())
                {
                    m_yonet_ekrani.lbl_hosgeldiniz.Text = String.Format("{0} {1}", okuyucu3[0], okuyucu3[1]);
                }
                m_yonet_ekrani.magaza_yonetici_id = yonetici_personel_no;
                m_yonet_ekrani.Show();
                this.Close();
                baglanti.Close();
                //*****************
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre girdiniz.");
            }
            //*****************

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void magaza_yonetici_giris_ekrani_Load(object sender, EventArgs e)
        {

        }

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_giris.PerformClick(); }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            frm_ilk_ana_ekran frm1 = new frm_ilk_ana_ekran();
            frm1.Show();
            this.Hide();
        }

        private void lbl_temizle_Click(object sender, EventArgs e)
        {
            txt_kullanici_adi.Text = "";
            txt_sifre.Text = "";
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
