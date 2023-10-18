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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti conn = new SqlBaglanti();
        private void btnDGiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC = @d1 and DoktorSifre = @d2", conn.Baglanti());
            cmd.Parameters.AddWithValue("@d1", mtxtDGirisTc.Text);
            cmd.Parameters.AddWithValue("@d2", txtDGirisSifre.Text);
           SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmDoktorDetay doktor = new FrmDoktorDetay();
                doktor.tc = mtxtDGirisTc.Text;
                doktor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc ya da Şifre hatalı.");
            }
            conn.Baglanti().Close();

           
        }
    }
}
