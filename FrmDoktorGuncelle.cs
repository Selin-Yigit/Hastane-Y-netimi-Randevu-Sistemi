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
    public partial class FrmDoktorGuncelle : Form
    {
        public FrmDoktorGuncelle()
        {
            InitializeComponent();
        }

        private void btnDGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand("update Tbl_Doktorlar set DoktorAd = @g1, DoktorSoyad= @g2, DoktorBrans= @g3, DoktorSifre= @g4 where DoktorTC = @h1", conn.Baglanti());
            cmd5.Parameters.AddWithValue("@h1", tc);
            cmd5.Parameters.AddWithValue("@g1", txtDGüncelleAd.Text);
            cmd5.Parameters.AddWithValue("@g2", txtDGüncelleSoyad.Text);
            cmd5.Parameters.AddWithValue("@g3", cmbDGüncelleBrans.Text);
            cmd5.Parameters.AddWithValue("@g4", txtDGüncelleSifre.Text);
            cmd5.ExecuteNonQuery();

            conn.Baglanti().Close();

            MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string tc;
        SqlBaglanti conn = new SqlBaglanti();
        private void FrmDoktorGuncelle_Load(object sender, EventArgs e)
        {

            SqlCommand cmd4 = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC = @d1", conn.Baglanti());
            cmd4.Parameters.AddWithValue("@d1", tc);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                txtDGüncelleAd.Text = dr4[1].ToString();
                txtDGüncelleSoyad.Text = dr4[2].ToString();
                cmbDGüncelleBrans.Text = dr4[3].ToString();
                mtxtDGüncelleTC.Text = dr4[4].ToString();
                txtDGüncelleSifre.Text = dr4[5].ToString();
            }
            conn.Baglanti().Close();

            SqlCommand cmd = new SqlCommand("select * from Tbl_Branslar", conn.Baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              cmbDGüncelleBrans.Items.Add(dr[1].ToString());
            }
            conn.Baglanti().Close();


        }
    }
}
