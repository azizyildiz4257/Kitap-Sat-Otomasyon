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

namespace Kitap_Satış_Otomasyon
{
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        DataSet ds = new DataSet();
        private void Kitaplistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select SatisNo,KitapAdı,AlısFiyatı,SatısFiyatı,KargoBedeli from Tbl_KitapSatis", bgl.baglan());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            Kitaplistele();

            SqlCommand komut = new SqlCommand("Select count(*) From Tbl_AlinmisKitaplar", bgl.baglan());
            LblAlınanKitapSayısı.Text = komut.ExecuteScalar().ToString();

            SqlCommand komut2 = new SqlCommand("Select count(*) From Tbl_KitapSatis", bgl.baglan());
            LblSatılanKitapSayısı.Text = komut2.ExecuteScalar().ToString();

            SqlCommand komut3 = new SqlCommand("Select sum(StokSayısı) From Tbl_KitapAlis", bgl.baglan());
            LblKalemBazındaKitapSayısı.Text = komut3.ExecuteScalar().ToString();
            if (LblKalemBazındaKitapSayısı.Text == "")
            {
                LblKalemBazındaKitapSayısı.Text = "0";
            }

            SqlCommand komut4 = new SqlCommand("Select sum(AlısFiyatı) From Tbl_KitapAlis", bgl.baglan());
            LblToplamAlısFiyatı.Text = komut4.ExecuteScalar().ToString();
            if (LblToplamAlısFiyatı.Text == "")
            {
                LblToplamAlısFiyatı.Text = "0";
            }

            SqlCommand komut5 = new SqlCommand("Select sum(SatısFiyatı) From Tbl_KitapSatis", bgl.baglan());
            LblToplamSatısFiyatı.Text = komut5.ExecuteScalar().ToString();
            if (LblToplamSatısFiyatı.Text == "")
            {
                LblToplamSatısFiyatı.Text = "0";
            }

            SqlCommand komut6 = new SqlCommand("Select sum(KargoBedeli) From Tbl_KitapSatis", bgl.baglan());
            LblToplamKargoBedeli.Text = komut6.ExecuteScalar().ToString();
            if (LblToplamKargoBedeli.Text == "")
            {
                LblToplamKargoBedeli.Text = "0";
            }

            SqlCommand komut7 = new SqlCommand("Select sum(SatısFiyatı)-sum(AlısFiyatı) From Tbl_KitapSatis", bgl.baglan());
            LblToplamKar.Text = komut7.ExecuteScalar().ToString();
            if (LblToplamKar.Text == "")
            {
                LblToplamKar.Text = "0";
            }

            SqlCommand komut8 = new SqlCommand("Select count(*) From Tbl_KitapAlis", bgl.baglan());
            Lbl_UrunBazindaKitapSayisi.Text = komut8.ExecuteScalar().ToString();
        }

        private void TxtKitapAra_TextChanged(object sender, EventArgs e)
        {
            /*************************************************************************************************/
        }

        private void TxtAlısFiyatı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where AlısFiyatı like '%" + TxtAlısFiyatı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TxtSatısFiyatı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where SatısFiyatı like '%" + TxtSatısFiyatı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TxtKargoBedel_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where KargoBedeli like '%" + TxtKargoBedel.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TxtKitapAra_TextChanged_1(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where KitapAdı like '%" + TxtKitapAra.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
