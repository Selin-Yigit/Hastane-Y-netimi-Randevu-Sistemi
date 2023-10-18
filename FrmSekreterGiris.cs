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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti conn = new SqlBaglanti();
        private void btnSGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Sekreterler where SekreterTc= @s1 and SekreterSifre = @s2",conn.Baglanti());
            cmd.Parameters.AddWithValue("@s1", mtxtSGirisTc.Text);
            cmd.Parameters.AddWithValue("@s2",txtSGirisSifre.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay sDetay = new FrmSekreterDetay();
                sDetay.sTC = mtxtSGirisTc.Text;
                sDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz TC veya Sifre hatalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Baglanti().Close();
        }
    }
}
