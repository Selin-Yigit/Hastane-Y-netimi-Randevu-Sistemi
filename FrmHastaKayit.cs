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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        SqlBaglanti conn = new SqlBaglanti(); // Sınıfı bu forma çağırdık.
        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            //komut sonunda normal şartta bağlantıyı bu formda açmış olsaydık conn yazmamız yeterliydi. Fakat biz class'ta açtığımız bağlantıyı kullandığımız için
            //class'ta oluşturduğumuz Baglanti() metodunuda çağırmamız gerekli bu sebeple => conn.Baglanti()
            SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTel, HastaSifre, HastaCinsiyet ) values(@h1,@h2,@h3,@h4,@h5,@h6)",conn.Baglanti());
            cmd.Parameters.AddWithValue("@h1", txtHKayitAd.Text);
            cmd.Parameters.AddWithValue("@h2", txtHKayitSoyad.Text);
            cmd.Parameters.AddWithValue("@h3", mtxtHKayitTc.Text);
            cmd.Parameters.AddWithValue("@h4", mtxtHKayitTel.Text);
            cmd.Parameters.AddWithValue("@h5", txtHKayitSifre.Text);
            cmd.Parameters.AddWithValue("@h6", cmbHKayitCinsiyet.Text);
            cmd.ExecuteNonQuery();
            conn.Baglanti().Close();

            MessageBox.Show("Kaydınız gerçekleştirilmiştir. Şifreniz: " + txtHKayitSifre.Text,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
