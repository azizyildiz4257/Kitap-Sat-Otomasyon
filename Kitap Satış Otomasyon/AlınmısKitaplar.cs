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
    public partial class AlınmısKitaplar : Form
    {
        public AlınmısKitaplar()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        DataSet ds = new DataSet();

        private void AlinmisKitapListesi()
        {
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar", bgl.baglan());
            da.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];

            SqlCommand komut = new SqlCommand("Select count(*) From Tbl_AlinmisKitaplar", bgl.baglan());
            LblKitapSayısı.Text = komut.ExecuteScalar().ToString();

            DGVRenk();
        }

        private void DGVRenk()
        {
            for (int i = 0; i < DGVAlinmisKitap.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (DGVAlinmisKitap.Rows[i].Cells[8].Value.ToString() == "")
                {
                    renk.BackColor = Color.LawnGreen;
                }
                if (DGVAlinmisKitap.Rows[i].Cells[8].Value.ToString() != "" && DGVAlinmisKitap.Rows[i].Cells[5].Value.ToString() != "0")
                {
                    renk.BackColor = Color.LightSeaGreen;
                }
                if (DGVAlinmisKitap.Rows[i].Cells[5].Value.ToString() == "0")
                {
                    renk.BackColor = Color.Red;
                }
                DGVAlinmisKitap.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void TxtBarkodu_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar where KitapBarkodu like '%" + TxtBarkodu.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];

            DGVRenk();
            LblKitapSayısı.Text = (DGVAlinmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtKitapAra_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar where KitapAdı like '%" + TxtKitapAra.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];
            
            DGVRenk();
            LblKitapSayısı.Text = (DGVAlinmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtYazarı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar where Yazarı like '%" + TxtYazarı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];

            DGVRenk();
            LblKitapSayısı.Text = (DGVAlinmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtFiyatı_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar where AlısFiyatı like '%" + TxtFiyatı.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];

            DGVRenk();
            LblKitapSayısı.Text = (DGVAlinmisKitap.Rows.Count - 1).ToString();
        }

        private void TxtSatış_TextChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar where SatısFiyatı like '%" + TxtSatış.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];

            DGVRenk();
            LblKitapSayısı.Text = (DGVAlinmisKitap.Rows.Count - 1).ToString();
        }

        private void DTPKayıtTarihi_ValueChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar where KayıtTarihi like '%" + DTPKayıtTarihi.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];

            DGVRenk();
            LblKitapSayısı.Text = (DGVAlinmisKitap.Rows.Count - 1).ToString();
        }

        private void AlınmısKitaplar_Load(object sender, EventArgs e)
        {
            AlinmisKitapListesi();
        }

        private void DTPCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            ds.Clear();
            SqlDataAdapter adpr = new SqlDataAdapter("Select * From Tbl_AlinmisKitaplar where CıkısTarihi like '%" + DTPCikisTarihi.Text + "%'", bgl.baglan());
            adpr.Fill(ds);
            DGVAlinmisKitap.DataSource = ds.Tables[0];

            DGVRenk();
            LblKitapSayısı.Text = (DGVAlinmisKitap.Rows.Count - 1).ToString();
        }
    }
}
