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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti conn = new SqlBaglanti();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", conn.Baglanti());
            da.Fill(dt);
            dgvBransPaneli.DataSource = dt;
        }

        private void btnBPaneliEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEkle = new SqlCommand("insert into Tbl_Branslar (BransAdi) values (@b)",conn.Baglanti());
            cmdEkle.Parameters.AddWithValue("@b", txtBPaneliAd.Text);
            cmdEkle.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Ekleme işlemi tamamlandı.");
            dgvBransPaneli.Update();
        }

        private void dgvBransPaneli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvBransPaneli.SelectedCells[0].RowIndex;
            txtBPaneliId.Text = dgvBransPaneli.Rows[secilen].Cells[0].Value.ToString();
            txtBPaneliAd.Text = dgvBransPaneli.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnBPaneliSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSil = new SqlCommand("delete from Tbl_Branslar where BransId = @s", conn.Baglanti());
            cmdSil.Parameters.AddWithValue("@s", txtBPaneliId.Text);
            cmdSil.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Silme işlemi tamamlandı.");
            dgvBransPaneli.Update();

        }

        private void btnBPaneliGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSil = new SqlCommand("update Tbl_Branslar set BransAdi = @u2 where BransId = @u1", conn.Baglanti());
            cmdSil.Parameters.AddWithValue("@u1", txtBPaneliId.Text);
            cmdSil.Parameters.AddWithValue("@u2", txtBPaneliAd.Text);
            cmdSil.ExecuteNonQuery();
            conn.Baglanti().Close();
            MessageBox.Show("Güncelleme işlemi tamamlandı.");
        }
    }
}
