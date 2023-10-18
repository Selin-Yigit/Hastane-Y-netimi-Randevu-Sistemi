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

namespace HastaneYönetimiRandevuSistemi
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti conn = new SqlBaglanti();
        private void lnkHGirisKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit hKayit = new FrmHastaKayit();
            hKayit.Show();
        }

        private void btnHGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Hastalar where HastaTC = @TC and HastaSifre = @Sifre",conn.Baglanti());
            cmd.Parameters.AddWithValue("@TC", mtxtHGirisTc.Text);
            cmd.Parameters.AddWithValue("Sifre", txtHGirisSifre.Text);
            SqlDataReader dr =  cmd.ExecuteReader();

            if (dr.Read()) 
            {
                FrmHastaDetay hDetay = new FrmHastaDetay();
                hDetay.tc = mtxtHGirisTc.Text;
                hDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz TC veya Sifre hatalıdır.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            conn.Baglanti().Close();
        }
    }
}
