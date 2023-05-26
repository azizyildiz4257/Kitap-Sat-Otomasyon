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
    public partial class KitapSatis : Form
    {
        public KitapSatis()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KitapListesi()
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_KitapAlis", bgl.baglan());
            da.Fill(ds);
            DGVKitapSatis.DataSource = ds.Tables[0];

            SqlCommand komut = new SqlCommand("Select count(*) From Tbl_KitapAlis", bgl.baglan());
            LblKitapSayısı.Text = komut.ExecuteScalar().ToString();
            /**********************************************************************************************************/
            for (int i = 0; i < DGVKitapSatis.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();


                if (DGVKitapSatis.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    renk.BackColor = Color.Tomato;
                }
                DGVKitapSatis.Rows[i].DefaultCellStyle = renk;
            }
            /**********************************************************************************************************/
        }

        string barkod;
        private void DGVKitapSatis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkod = DGVKitapSatis.CurrentRow.Cells["KitapBarkodu"].Value.ToString();

            TxtKitapBarkod.Text = DGVKitapSatis.CurrentRow.Cells["KitapBarkodu"].Value.ToString();
            TxtKitapAdı.Text = DGVKitapSatis.CurrentRow.Cells["KitapAdı"].Value.ToString();
            TxtYazarı.Text = DGVKitapSatis.CurrentRow.Cells["Yazarı"].Value.ToString();
            TxtCiltNo.Text = DGVKitapSatis.CurrentRow.Cells["CiltNo"].Value.ToString();
            TxtStok.Text = DGVKitapSatis.CurrentRow.Cells["StokSayısı"].Value.ToString();
            TxtAlisFiyat.Text = DGVKitapSatis.CurrentRow.Cells["AlısFiyatı"].Value.ToString();

            TxtSatış.Focus();

            ds1.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapSatis where KitapBarkodu like '%" + TxtKitapBarkod.Text + "%'", bgl.baglan());
            adpr.Fill(ds1);
            DGVGizli.DataSource = ds1.Tables[0];
        }

        private void KitapSatis_Load(object sender, EventArgs e)
        {
            KitapListesi();
        }
        int satisMiktari;
        private void AlinmisKitaplar()
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_KitapSatis (SatisNo,KitapBarkodu,KitapAdı,Yazarı,CiltNo,StokSayısı,AlısFiyatı,SatısFiyatı,KargoBedeli,KayıtTarihi,CıkısTarihi) values (@SatisNo,@KitapBarkodu,@KitapAdı,@Yazarı,@CiltNo,@StokSayısı,@AlısFiyatı,@SatısFiyatı,@KargoBedeli,@KayıtTarihi,@CıkısTarihi)", bgl.baglan());
            komut2.Parameters.AddWithValue("@SatisNo", Txt_SatisNo.Text);
            komut2.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
            komut2.Parameters.AddWithValue("@KitapAdı", TxtKitapAdı.Text);
            komut2.Parameters.AddWithValue("@Yazarı", TxtYazarı.Text);
            komut2.Parameters.AddWithValue("@CiltNo", TxtCiltNo.Text);
            komut2.Parameters.AddWithValue("@StokSayısı", TxtStok.Text);
            komut2.Parameters.AddWithValue("@AlısFiyatı", TxtAlisFiyat.Text);
            komut2.Parameters.AddWithValue("@SatısFiyatı", TxtSatış.Text);
            komut2.Parameters.AddWithValue("@KargoBedeli", TxtKargoBedel.Text);
            komut2.Parameters.AddWithValue("@KayıtTarihi", DGVKitapSatis.CurrentRow.Cells["KayıtTarihi"].Value.ToString());
            komut2.Parameters.AddWithValue("@CıkısTarihi", DateTime.Now.ToShortDateString());
            komut2.ExecuteNonQuery();
            MessageBox.Show("Satış İşlemi Tamamlandı.");

            /************************************************AlınmısKitaplar*******************************************/

            SqlCommand komut3 = new SqlCommand("update Tbl_AlinmisKitaplar set SatısFiyatı=@SatısFiyatı,KargoBedeli=@KargoBedeli,CıkısTarihi=@CıkısTarihi where KitapBarkodu=@KitapBarkodu", bgl.baglan());
            komut3.Parameters.AddWithValue("@SatısFiyatı", TxtSatış.Text);
            komut3.Parameters.AddWithValue("@KargoBedeli", TxtKargoBedel.Text);
            komut3.Parameters.AddWithValue("@CıkısTarihi", DateTime.Now.ToShortDateString());
            komut3.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
            komut3.ExecuteNonQuery();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            TxtSatış.Focus();
            //SqlCommand komut7 = new SqlCommand("update KitapSatis set SatısMiktarı=SatısMiktarı+1 where KitapBarkodu='" + barkod + "'", bgl.baglan());
            //komut7.ExecuteNonQuery();
            //string satisMiktari = Txt_SatisMiktari.Text;
            //int sm = int.Parse(satisMiktari);

            SqlCommand komut4 = new SqlCommand("update Tbl_KitapAlis set StokSayısı=StokSayısı-" + satisMiktari + " where KitapBarkodu='" + barkod + "'", bgl.baglan());
            komut4.ExecuteNonQuery();

            SqlCommand komut5 = new SqlCommand("update Tbl_AlinmisKitaplar set StokSayısı=StokSayısı-" + satisMiktari + " where KitapBarkodu='" + barkod + "'", bgl.baglan());
            komut5.ExecuteNonQuery();

            //SqlCommand komut8 = new SqlCommand("Delete From Tbl_KitapAlis where KitapBarkodu='" + barkod + "' and StokSayısı<'" + Txt_SatisMiktari.Text + "' ", bgl.baglan());
            //komut8.ExecuteNonQuery();

            for (int i = 0; i < DGVKitapSatis.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();


                if (DGVKitapSatis.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    renk.BackColor = Color.Tomato;
                }
                DGVKitapSatis.Rows[i].DefaultCellStyle = renk;
            }

            //SqlCommand komut = new SqlCommand("Delete From Tbl_KitapAlis where KitapBarkodu='" + barkod + "' and StokSayısı=0", bgl.baglan());
            //komut.ExecuteNonQuery();

            SqlCommand komut6 = new SqlCommand("update Tbl_KitapSatis set StokSayısı=StokSayısı-" + satisMiktari + " where KitapBarkodu='" + barkod + "'", bgl.baglan());
            komut6.ExecuteNonQuery();

            KitapListesi();
        }
        int satisNo;
        private void BtnSatış_Click(object sender, EventArgs e)
        {
            if (TxtKitapBarkod.Text == "")
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            }
            else if (TxtSatış.Text == "")
            {
                MessageBox.Show("Lütfen Satış Fiyatını Giriniz.");
                TxtSatış.Focus();
            }
            else if (TxtKargoBedel.Text == "")
            {
                MessageBox.Show("Lütfen Kargo Bedelini Giriniz.");
                TxtKargoBedel.Focus();
            }
            else
            {

                if (int.Parse(TxtStok.Text) < int.Parse(Txt_SatisMiktari.Text))
                {
                    MessageBox.Show("Stokta '" + TxtStok.Text + "' adet ürün bulunmaktadır. Satış işlemi yapılamaz.");
                    Txt_SatisMiktari.Focus();
                }
                else
                {
                    if (int.Parse(TxtSatış.Text) <= int.Parse(TxtAlisFiyat.Text))
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Satış fiyatı alış fiyatından düşük bu fiyata satmak istediğine emin misin?", "Onay Formu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {
                            satisMiktari = int.Parse(Txt_SatisMiktari.Text);
                            satisNo++;
                            Txt_SatisNo.Text = satisNo.ToString();
                            if (DGVGizli.Rows.Count - 1 > 0)
                            {
                                //SqlCommand komut = new SqlCommand("UPDATE Tbl_KitapSatis SET KitapBarkodu='" + barkod + "'", bgl.baglan());
                                //komut.ExecuteNonQuery();

                                AlinmisKitaplar();
                            }
                            else
                            {
                                AlinmisKitaplar();
                            }

                        }
                        else
                        {
                            TxtSatış.Text = "";
                            TxtSatış.Focus();
                        }
                    }
                    else
                    {
                        satisMiktari = int.Parse(Txt_SatisMiktari.Text);
                        if (DGVGizli.Rows.Count - 1 > 0)
                        {
                            //SqlCommand komut = new SqlCommand("UPDATE Tbl_KitapSatis SET KitapBarkodu='" + barkod + "'", bgl.baglan());
                            //komut.ExecuteNonQuery();

                            AlinmisKitaplar();
                        }
                        else
                        {
                            AlinmisKitaplar();
                        }
                    }
                }
            }
        }

        private void TxtBarkodu_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where KitapBarkodu like '%" + TxtBarkodu.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVKitapSatis.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVKitapSatis.Rows.Count - 1).ToString();
        }

        private void TxtKitapAra_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where KitapAdı like '%" + TxtKitapAra.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVKitapSatis.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVKitapSatis.Rows.Count - 1).ToString();
        }

        private void TxtFiyatı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where AlısFiyatı like '%" + TxtFiyatı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVKitapSatis.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVKitapSatis.Rows.Count - 1).ToString();
        }
    }
}
