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
    public partial class frm_ilk_ana_ekran : Form
    {
        public frm_ilk_ana_ekran()
        {
            InitializeComponent();
        }

        private void btn_avmy_Click(object sender, EventArgs e)
        {
            frm_avm_yonetici_giris_ekrani giris_ekrani = new frm_avm_yonetici_giris_ekrani();
            frm_ilk_ana_ekran f1 = new frm_ilk_ana_ekran();
            this.Hide();
            giris_ekrani.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_ilk_ana_ekran frm = new frm_ilk_ana_ekran();
            frm.Focus();
        }

        private void btn_my_Click(object sender, EventArgs e)
        {
            frm_m_magaza_yonetici_giris_ekrani giris_ekrani = new frm_m_magaza_yonetici_giris_ekrani();
            this.Hide();
            giris_ekrani.Show();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
