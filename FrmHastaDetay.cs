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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        SqlBaglanti conn = new SqlBaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad getirme
            lblHDetayTC.Text = tc;
            SqlCommand cmd = new SqlCommand("select HastaAd, HastaSoyad from Tbl_Hastalar where HastaTc = @TC", conn.Baglanti());
            cmd.Parameters.AddWithValue("@TC", lblHDetayTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblHDetayAdSoyad.Text = dr[0] + " " + dr[1];
            }
            conn.Baglanti().Close();

            //Randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTC = " + tc,conn.Baglanti());
            da.Fill(dt);// sanal bir tablo oluşturma mantığı var.
            dgvHDetayRandGecmisi.DataSource = dt;

            //Branşların çekilmesi

            SqlCommand cmd2 = new SqlCommand("select BransAdi from Tbl_Branslar", conn.Baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbHDetayBrans.Items.Add(dr2[0]);
            }
            conn.Baglanti().Close();

        }

        private void cmbHDetayBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHDetayDoktor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @d1", conn.Baglanti());
            cmd3.Parameters.AddWithValue("@d1", cmbHDetayBrans.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmbHDetayDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            conn.Baglanti().Close();
        }

        private void cmbHDetayDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans = " +"'"+ cmbHDetayBrans.Text + "' and RandevuDoktor =" + "'" + cmbHDetayDoktor.Text + "'and RandevuDurum =0", conn.Baglanti());
            da.Fill(dt);
            dgvHDetayAktifRnd.DataSource = dt;
        }

        private void lnkHDetayUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaGuncelle hGuncelle = new FrmHastaGuncelle();
            hGuncelle.tc = lblHDetayTC.Text;
            hGuncelle.Show();

        }

        private void btnHDetayRandevu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Randevular set RandevuDurum = 1, HastaTC = @p1, HastaSikayet = @p2 where RandevuId = @p3",conn.Baglanti());
            cmd.Parameters.AddWithValue("@p1", lblHDetayTC.Text);
            cmd.Parameters.AddWithValue("@p2", rtxtHDetaySikayet.Text);
            cmd.Parameters.AddWithValue("@p3", txtHDetayRandId.Text);
            cmd.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Randevu alındı.");
        }

        private void dgvHDetayAktifRnd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvHDetayAktifRnd.SelectedCells[0].RowIndex;
            txtHDetayRandId.Text= dgvHDetayAktifRnd.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
