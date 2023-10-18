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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string sTC;
        SqlBaglanti conn = new SqlBaglanti();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblSDetayTC.Text = sTC;
            SqlCommand cmd = new SqlCommand("select SekreterAd, SekreterSoyad from Tbl_Sekreterler where SekreterTc = @s",conn.Baglanti());
            cmd.Parameters.AddWithValue("@s", sTC);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblSDetayAdSoyad.Text = dr[0] + " " + dr[1];
            }
            conn.Baglanti().Close();

            //Branşlar
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select BransAdi from Tbl_Branslar", conn.Baglanti());
            da.Fill(dt);
            dgvSDetayBrans.DataSource = dt;

            // Doktor bilgileri
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select DoktorAd, DoktorSoyad, DoktorBrans from Tbl_Doktorlar", conn.Baglanti());
            da2.Fill(dt2);
            dgvSDetayDoktor.DataSource = dt2;

            //Brans Combobox
            SqlCommand cmdBrans = new SqlCommand("select BransAdi from Tbl_Branslar", conn.Baglanti());
            SqlDataReader drBrans = cmdBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cmbSDetayBrans.Items.Add(drBrans[0].ToString());
            }
            conn.Baglanti().Close();
        }

        private void btnSDetayKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values( @r1, @r2, @r3,@r4) ", conn.Baglanti());
            cmdKaydet.Parameters.AddWithValue("@r1", mtxtSDetayTarih.Text);
            cmdKaydet.Parameters.AddWithValue("@r2", mtxtSDetaySaat.Text);
            cmdKaydet.Parameters.AddWithValue("@r3", cmbSDetayBrans.Text);
            cmdKaydet.Parameters.AddWithValue("@r4", cmbSDetayDoktor.Text);
            cmdKaydet.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Randevu kaydı oluşturulmuştur.");
        }

        private void cmbSDetayBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSDetayDoktor.Items.Clear();
            SqlCommand cmdDoktor = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @b1 ", conn.Baglanti());
            cmdDoktor.Parameters.AddWithValue("@b1", cmbSDetayBrans.Text);
            SqlDataReader drDoktor = cmdDoktor.ExecuteReader();
            while (drDoktor.Read())
            {
                cmbSDetayDoktor.Items.Add(drDoktor[0]+" " + drDoktor[1]);
            }
            conn.Baglanti().Close();
        }

        private void btnSDetayDuyuru_Click(object sender, EventArgs e)
        {
            SqlCommand cmdDuyuru = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values(@d) ", conn.Baglanti());
            cmdDuyuru.Parameters.AddWithValue("@d", rtxtSDetayDuyuru.Text);
            cmdDuyuru.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Duyuru oluşturulmuştur.");
        }

        private void btnSDetayDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli doktor = new FrmDoktorPaneli();
            doktor.Show();
        }

        private void btnSDetayBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli brans = new FrmBransPaneli();
            brans.Show();
        }

        private void btnSDetayRandListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi randevu = new FrmRandevuListesi();
            randevu.Show();
        }

        private void btnSDetayDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular duyuru = new FrmDuyurular();
            duyuru.Show();
        }
    }
}
