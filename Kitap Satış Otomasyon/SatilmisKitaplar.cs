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
    public partial class SatilmisKitaplar : Form
    {
        public SatilmisKitaplar()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();

        private void KitapSatisListesi()
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_KitapSatis", bgl.baglan());
            da.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];

            ds1.Clear();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_KitapAlis", bgl.baglan());
            da1.Fill(ds1);
            DGVKitapAlis.DataSource = ds1.Tables[0];

            SqlCommand komut = new SqlCommand("Select count(*) From Tbl_KitapSatis", bgl.baglan());
            LblKitapSayısı.Text = komut.ExecuteScalar().ToString();
        }

        private void SatilmisKitaplar_Load(object sender, EventArgs e)
        {
            KitapSatisListesi();
        }
        string barkod;
        string SatısNo;
        private void DGVSatilmisKitap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkod = DGVSatilmisKitap.CurrentRow.Cells["KitapBarkodu"].Value.ToString();
            SatısNo = DGVSatilmisKitap.CurrentRow.Cells["SatısNo"].Value.ToString();
            TxtKitapAlis.Text = DGVSatilmisKitap.CurrentRow.Cells["KitapBarkodu"].Value.ToString();

            TxtKitapBarkod.Text = DGVSatilmisKitap.CurrentRow.Cells["KitapBarkodu"].Value.ToString();
            TxtKitapAdı.Text = DGVSatilmisKitap.CurrentRow.Cells["KitapAdı"].Value.ToString();
            TxtYazarı.Text = DGVSatilmisKitap.CurrentRow.Cells["Yazarı"].Value.ToString();
            TxtCiltNo.Text = DGVSatilmisKitap.CurrentRow.Cells["CiltNo"].Value.ToString();
            TxtStok.Text = DGVSatilmisKitap.CurrentRow.Cells["StokSayısı"].Value.ToString();
            TxtAlisFiyat.Text = DGVSatilmisKitap.CurrentRow.Cells["AlısFiyatı"].Value.ToString();
            TxtSatış.Text = DGVSatilmisKitap.CurrentRow.Cells["SatısFiyatı"].Value.ToString();
            TxtKargoBedel.Text = DGVSatilmisKitap.CurrentRow.Cells["KargoBedeli"].Value.ToString();
            TxtKayıtTarihi.Text = DGVSatilmisKitap.CurrentRow.Cells["KayıtTarihi"].Value.ToString();
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnİade_Click(object sender, EventArgs e)
        {
            if (TxtKitapBarkod.Text == "")
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            }
            else
            {
                //SqlCommand komut2 = new SqlCommand("update KitapAlis set KitapBarkodu=@KitapBarkodu,KitapAdı=@KitapAdı,Yazarı=@Yazarı,CiltNo=@CiltNo,StokSayısı=@StokSayısı,AlısFiyatı=@AlısFiyatı,KayıtTarihi=@KayıtTarihi where KitapBarkodu=@KitapBarkodu and StokSayısı=StokSayısı+1 where KitapBarkodu='" + barkod + "'", bgl.baglan());
                //komut2.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
                //komut2.Parameters.AddWithValue("@KitapAdı", TxtKitapAdı.Text);
                //komut2.Parameters.AddWithValue("@Yazarı", TxtYazarı.Text);
                //komut2.Parameters.AddWithValue("@CiltNo", TxtCiltNo.Text);
                //komut2.Parameters.AddWithValue("@StokSayısı", TxtStok.Text);
                //komut2.Parameters.AddWithValue("@AlısFiyatı", TxtAlisFiyat.Text);
                //komut2.Parameters.AddWithValue("@KayıtTarihi", DGVSatilmisKitap.CurrentRow.Cells["KayıtTarihi"].Value.ToString());
                //komut2.ExecuteNonQuery();
                if (DGVKitapAlis.Rows.Count - 1 > 0)
                {
                    SqlCommand komut4 = new SqlCommand("update Tbl_KitapAlis set StokSayısı=StokSayısı+1 where KitapBarkodu='" + barkod + "'", bgl.baglan());
                    komut4.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand komut10 = new SqlCommand("insert into Tbl_KitapAlis (KitapBarkodu,KitapAdı,Yazarı,CiltNo,StokSayısı,AlısFiyatı,KayıtTarihi) values (@KitapBarkodu,@KitapAdı,@Yazarı,@CiltNo,@StokSayısı,@AlısFiyatı,@KayıtTarihi)", bgl.baglan());
                    komut10.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
                    komut10.Parameters.AddWithValue("@KitapAdı", TxtKitapAdı.Text);
                    komut10.Parameters.AddWithValue("@Yazarı", TxtYazarı.Text);
                    komut10.Parameters.AddWithValue("@CiltNo", TxtCiltNo.Text);
                    komut10.Parameters.AddWithValue("@StokSayısı", TxtStok.Text);
                    komut10.Parameters.AddWithValue("@AlısFiyatı", TxtAlisFiyat.Text);
                    komut10.Parameters.AddWithValue("@KayıtTarihi", TxtKayıtTarihi.Text);
                    komut10.ExecuteNonQuery();

                    SqlCommand komut4 = new SqlCommand("update Tbl_KitapAlis set StokSayısı=StokSayısı+1 where KitapBarkodu='" + barkod + "'", bgl.baglan());
                    komut4.ExecuteNonQuery();
                }
                    MessageBox.Show("İade işlemi tamamlandı.");

                SqlCommand komut5 = new SqlCommand("update Tbl_AlinmisKitaplar set StokSayısı=StokSayısı+1 where KitapBarkodu='" + barkod + "'", bgl.baglan());
                komut5.ExecuteNonQuery();

                SqlCommand komut6 = new SqlCommand("update Tbl_KitapSatis set StokSayısı=StokSayısı+1 where KitapBarkodu='" + barkod + "'", bgl.baglan());
                komut6.ExecuteNonQuery();

                SqlCommand komut = new SqlCommand("Delete From Tbl_KitapSatis where KitapBarkodu='" + barkod + "'and SatısNo='" + SatısNo + "'", bgl.baglan());
                komut.ExecuteNonQuery();

                KitapSatisListesi();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void TxtBarkodu_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where KitapBarkodu like '%" + TxtBarkodu.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtKitapAra_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where KitapAdı like '%" + TxtKitapAra.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtYazarı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where Yazarı like '%" + TxtYazarı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtAlısFiyatı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where AlısFiyatı like '%" + TxtAlısFiyatı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtSatısFiyatı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where SatısFiyatı like '%" + TxtSatısFiyatı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }

        private void DTPKayıtTarihi_ValueChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where KayıtTarihi like '%" + DTPKayıtTarihi.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }

        private void DTPCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where CıkısTarihi like '%" + DTPCikisTarihi.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVSatilmisKitap.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }

        private void LblKitapAlis_Click(object sender, EventArgs e)
        {

        }

        private void TxtKitapAlis_TextChanged(object sender, EventArgs e)
        {
            ds1.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where KitapBarkodu like '%" + TxtKitapAlis.Text + "%'", bgl.baglan());
            adpr.Fill(ds1);
            DGVKitapAlis.DataSource = ds1.Tables[0];
            LblKitapSayısı.Text = (DGVSatilmisKitap.Rows.Count - 1).ToString();
        }
    }
}
