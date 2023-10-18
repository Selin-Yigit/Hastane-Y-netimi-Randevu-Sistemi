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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti conn = new SqlBaglanti();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad getirme
            lblDDetayTC.Text = tc;
            SqlCommand cmd = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorTC = @TC", conn.Baglanti());
            cmd.Parameters.AddWithValue("@TC", lblDDetayTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblDDetayAdSoyad.Text = dr[0] + " " + dr[1];
            }
            conn.Baglanti().Close();

            //Randevu geçmişi
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor = " + "'"+lblDDetayAdSoyad.Text+"'", conn.Baglanti());
            da.Fill(dt);// sanal bir tablo oluşturma mantığı var.
            dgvDDetayRndListesi.DataSource = dt;
            
        }

        private void btnDDetayUpdate_Click(object sender, EventArgs e)
        {
            FrmDoktorGuncelle drUpdate = new FrmDoktorGuncelle();
            drUpdate.tc = lblDDetayTC.Text;
            drUpdate.Show();
        }

        private void btnDDetayDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular duyuru = new FrmDuyurular();
            duyuru.Show();
        }

        private void dgvDDetayRndListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvDDetayRndListesi.SelectedCells[0].RowIndex;
            rtxtDDetaySikayet.Text = dgvDDetayRndListesi.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnDDetayCikis_Click(object sender, EventArgs e)
        {
            FrmGirisler giris = new FrmGirisler();
            giris.Show();
            this.Hide();
        }
    }

        
}
