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
    public partial class KitapAlis : Form
    {
        public KitapAlis()
        {
            InitializeComponent();
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        DataSet ds = new DataSet();

        private void KitapListesi()
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_KitapAlis", bgl.baglan());
            da.Fill(ds);
            DGVKitapAlis.DataSource = ds.Tables[0];

            SqlCommand komut = new SqlCommand("Select count(*) From Tbl_KitapAlis", bgl.baglan());
            LblKitapSayısı.Text = komut.ExecuteScalar().ToString();
            /**********************************************************************************************************/
            for (int i = 0; i < DGVKitapAlis.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();


                if (DGVKitapAlis.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    renk.BackColor = Color.Tomato;
                }
                DGVKitapAlis.Rows[i].DefaultCellStyle = renk;
            }
            /**********************************************************************************************************/
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (TxtKitapBarkod.Text == "")
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update Tbl_KitapAlis set KitapBarkodu=@KitapBarkodu,KitapAdı=@KitapAdı,Yazarı=@Yazarı,CiltNo=@CiltNo,StokSayısı=@StokSayısı,AlısFiyatı=@AlısFiyatı where KitapBarkodu=@KitapBarkodu", bgl.baglan());
                komut.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
                komut.Parameters.AddWithValue("@KitapAdı", TxtKitapAdı.Text);
                komut.Parameters.AddWithValue("@Yazarı", TxtYazarı.Text);
                komut.Parameters.AddWithValue("@CiltNo", TxtCiltNo.Text);
                komut.Parameters.AddWithValue("@StokSayısı", TxtStok.Text);
                komut.Parameters.AddWithValue("@AlısFiyatı", TxtAlisFiyat.Text);
                komut.ExecuteNonQuery();
                KitapListesi();
                /**************************************Alınmıs Kitaplar************************************/

                SqlCommand komut2 = new SqlCommand("update Tbl_AlinmisKitaplar set KitapBarkodu=@KitapBarkodu,KitapAdı=@KitapAdı,Yazarı=@Yazarı,CiltNo=@CiltNo,StokSayısı=@StokSayısı,AlısFiyatı=@AlısFiyatı where KitapBarkodu=@KitapBarkodu", bgl.baglan());
                komut2.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
                komut2.Parameters.AddWithValue("@KitapAdı", TxtKitapAdı.Text);
                komut2.Parameters.AddWithValue("@Yazarı", TxtYazarı.Text);
                komut2.Parameters.AddWithValue("@CiltNo", TxtCiltNo.Text);
                komut2.Parameters.AddWithValue("@StokSayısı", TxtStok.Text);
                komut2.Parameters.AddWithValue("@AlısFiyatı", TxtAlisFiyat.Text);
                komut2.ExecuteNonQuery();


                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                TxtKitapBarkod.Focus();
            }
        }

        private void KitapAlis_Load(object sender, EventArgs e)
        {
            KitapListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKitapBarkod.Text == "")
            {
                MessageBox.Show("Lütfen kitap bilgilerini giriniz.");
            }
            else
            {
                DataSet ds1 = new DataSet();
                ds1.Clear();
                SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where KitapBarkodu like '%" + TxtKitapBarkod.Text + "%'", bgl.baglan());
                adpr.Fill(ds1);
                DGVKontrol.DataSource = ds1.Tables[0];

                if (DGVKontrol.Rows.Count - 1 > 0)
                {
                    MessageBox.Show("Bu barkod numarasına ait kitap bulunmaktadır.");
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                else
                {

                    try
                    {
                        SqlCommand komut = new SqlCommand("insert into Tbl_KitapAlis (KitapBarkodu,KitapAdı,Yazarı,CiltNo,StokSayısı,AlısFiyatı,KayıtTarihi) values (@KitapBarkodu,@KitapAdı,@Yazarı,@CiltNo,@StokSayısı,@AlısFiyatı,@KayıtTarihi)", bgl.baglan());
                        komut.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
                        komut.Parameters.AddWithValue("@KitapAdı", TxtKitapAdı.Text);
                        komut.Parameters.AddWithValue("@Yazarı", TxtYazarı.Text);
                        komut.Parameters.AddWithValue("@CiltNo", TxtCiltNo.Text);
                        komut.Parameters.AddWithValue("@StokSayısı", TxtStok.Text);
                        komut.Parameters.AddWithValue("@AlısFiyatı", TxtAlisFiyat.Text);
                        komut.Parameters.AddWithValue("@KayıtTarihi", DateTime.Now.ToShortDateString());
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız Tamamlandı.");
                        ds.Clear();
                        KitapListesi();

                        /**************************************Alınmıs Kitaplar************************************/

                        SqlCommand komut2 = new SqlCommand("insert into Tbl_AlinmisKitaplar (KitapBarkodu,KitapAdı,Yazarı,CiltNo,StokSayısı,AlısFiyatı,KayıtTarihi) values (@KitapBarkodu,@KitapAdı,@Yazarı,@CiltNo,@StokSayısı,@AlısFiyatı,@KayıtTarihi)", bgl.baglan());
                        komut2.Parameters.AddWithValue("@KitapBarkodu", TxtKitapBarkod.Text);
                        komut2.Parameters.AddWithValue("@KitapAdı", TxtKitapAdı.Text);
                        komut2.Parameters.AddWithValue("@Yazarı", TxtYazarı.Text);
                        komut2.Parameters.AddWithValue("@CiltNo", TxtCiltNo.Text);
                        komut2.Parameters.AddWithValue("@StokSayısı", TxtStok.Text);
                        komut2.Parameters.AddWithValue("@AlısFiyatı", TxtAlisFiyat.Text);
                        komut2.Parameters.AddWithValue("@KayıtTarihi", DateTime.Now.ToShortDateString());
                        komut2.ExecuteNonQuery();

                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                        }
                        TxtKitapBarkod.Focus();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Lütfen '.' nokta simgesi ile giriş yapınız.");
                    }
                }
            }
        }
        string barkod;
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtKitapBarkod.Text == "")
            {
                MessageBox.Show("Lütfen bir kitap seçiniz.");
            }
            else
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Bu kaydı silmek istiyor musun?", "Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Delete From Tbl_KitapAlis where KitapBarkodu='" + barkod + "'", bgl.baglan());
                    komut.ExecuteNonQuery();
                    /**************************************Alınmıs Kitaplar************************************/
                    SqlCommand komut2 = new SqlCommand("Delete From Tbl_AlinmisKitaplar where KitapBarkodu='" + barkod + "'", bgl.baglan());
                    komut2.ExecuteNonQuery();

                    ds.Clear();
                    KitapListesi();

                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void DGVKitapAlis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkod = DGVKitapAlis.CurrentRow.Cells["KitapBarkodu"].Value.ToString();

            TxtKitapBarkod.Text = DGVKitapAlis.CurrentRow.Cells["KitapBarkodu"].Value.ToString();
            TxtKitapAdı.Text = DGVKitapAlis.CurrentRow.Cells["KitapAdı"].Value.ToString();
            TxtYazarı.Text = DGVKitapAlis.CurrentRow.Cells["Yazarı"].Value.ToString();
            TxtCiltNo.Text = DGVKitapAlis.CurrentRow.Cells["CiltNo"].Value.ToString();
            TxtStok.Text = DGVKitapAlis.CurrentRow.Cells["StokSayısı"].Value.ToString();
            TxtAlisFiyat.Text = DGVKitapAlis.CurrentRow.Cells["AlısFiyatı"].Value.ToString();
        }

        private void TxtKitapAra_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where KitapAdı like '%" + TxtKitapAra.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVKitapAlis.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVKitapAlis.Rows.Count - 1).ToString();
        }

        private void TxtBarkodu_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where KitapBarkodu like '%" + TxtBarkodu.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVKitapAlis.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVKitapAlis.Rows.Count - 1).ToString();
        }

        private void TxtFiyatı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where AlısFiyatı like '%" + TxtFiyatı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVKitapAlis.DataSource = ds.Tables[0];
            LblKitapSayısı.Text = (DGVKitapAlis.Rows.Count - 1).ToString();
        }

        private void TxtKitapBarkod_TextChanged(object sender, EventArgs e)
        {
            //ds.Clear();
            //SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_KitapAlis where KitapBarkodu like '%" + TxtKitapBarkod.Text + "%'", bgl.baglan());
            //adpr.Fill(ds);
            //DGVKitapAlis.DataSource = ds.Tables[0];
        }

        private void TxtKitapAdı_TextChanged(object sender, EventArgs e)
        {
            //KitapListesi();
        }
    }
}
