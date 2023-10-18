using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimiRandevuSistemi
{
    public partial class FrmHastaGuncelle : Form
    {
        public FrmHastaGuncelle()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti conn = new SqlBaglanti();
        private void FrmHastaGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("select * from Tbl_Hastalar where HastaTC = @d1", conn.Baglanti());
            cmd4.Parameters.AddWithValue("@d1",tc);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                txtHGüncelleAd.Text = dr4[1].ToString();
                txtHGüncelleSoyad.Text = dr4[2].ToString();
                mtxtHGüncelleTC.Text = dr4[3].ToString();
                mtxtHGüncelleTel.Text = dr4[4].ToString();
                txtHGüncelleSifre.Text = dr4[5].ToString();
                cmbHGüncelleCinsiyet.Text = dr4[6].ToString();
            }
            conn.Baglanti().Close();
        }

        private void btnHGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand("update Tbl_Hastalar set HastaAd = @g1, HastaSoyad= @g2, HastaTel= @g3, HastaSifre= @g4, HastaCinsiyet= @g5 where HastaTc = @h1", conn.Baglanti());
            cmd5.Parameters.AddWithValue("@h1", tc);
            cmd5.Parameters.AddWithValue("@g1", txtHGüncelleAd.Text);
            cmd5.Parameters.AddWithValue("@g2", txtHGüncelleSoyad.Text);
            cmd5.Parameters.AddWithValue("@g3", mtxtHGüncelleTel.Text);
            cmd5.Parameters.AddWithValue("@g4", txtHGüncelleSifre.Text);
            cmd5.Parameters.AddWithValue("@g5", cmbHGüncelleCinsiyet.Text);
            cmd5.ExecuteNonQuery();
            
            conn.Baglanti().Close();

            MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
