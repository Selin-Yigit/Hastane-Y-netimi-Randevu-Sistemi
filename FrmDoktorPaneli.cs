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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti conn = new SqlBaglanti();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Doktorlar", conn.Baglanti());
            da2.Fill(dt2);
            dgvDPaneli.DataSource = dt2;

            // cmb Brasnlar
            SqlCommand cmdBrans = new SqlCommand("select BransAdi from Tbl_Branslar", conn.Baglanti());
            SqlDataReader drBrans = cmdBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cmbDPaneliBrans.Items.Add(drBrans[0].ToString());
            }
            conn.Baglanti().Close();
        }

        private void btnDPaneliEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values(@d1,@d2,@d3,@d4,@d5)",conn.Baglanti());
            cmd.Parameters.AddWithValue("@d1", txtDPaneliAd.Text);
            cmd.Parameters.AddWithValue("@d2", txtDPaneliSoyad.Text);
            cmd.Parameters.AddWithValue("@d3", cmbDPaneliBrans.Text);
            cmd.Parameters.AddWithValue("@d4", mtxtDPaneliTC.Text);
            cmd.Parameters.AddWithValue("@d5", txtDPaneliSifre.Text);
            cmd.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Ekleme işlemi tamamlanmıştır.");
        }

        private void dgvDPaneli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvDPaneli.SelectedCells[0].RowIndex;
            txtDPaneliAd.Text = dgvDPaneli.Rows[secilen].Cells[1].Value.ToString();
            txtDPaneliSoyad.Text = dgvDPaneli.Rows[secilen].Cells[2].Value.ToString();
            cmbDPaneliBrans.Text = dgvDPaneli.Rows[secilen].Cells[3].Value.ToString();
            mtxtDPaneliTC.Text = dgvDPaneli.Rows[secilen].Cells[4].Value.ToString();
            txtDPaneliSifre.Text = dgvDPaneli.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnDPaneliSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSil = new SqlCommand("delete from Tbl_Doktorlar where DoktorTc = @s", conn.Baglanti());
            cmdSil.Parameters.AddWithValue("@s", mtxtDPaneliTC.Text);
            cmdSil.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Silme işlemi tamamlanmıştır.");
        }

        private void btnDPaneliGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdUpdate = new SqlCommand("update Tbl_Doktorlar set DoktorAd = @u1, DoktorSoyad = @u2, DoktorBrans = @u3, DoktorSifre = @u5 where DoktorTC = @u4", conn.Baglanti());
            cmdUpdate.Parameters.AddWithValue("@u1", txtDPaneliAd.Text);
            cmdUpdate.Parameters.AddWithValue("@u2", txtDPaneliSoyad.Text);
            cmdUpdate.Parameters.AddWithValue("@u3", cmbDPaneliBrans.Text);
            cmdUpdate.Parameters.AddWithValue("@u4", mtxtDPaneliTC.Text);
            cmdUpdate.Parameters.AddWithValue("@u5", txtDPaneliSifre.Text);
            cmdUpdate.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Güncelleme işlemi tamamlanmıştır.");
        }
    }
}
