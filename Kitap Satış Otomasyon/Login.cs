using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kitap_Satış_Otomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAdi=@p1 and Sifre=@p2", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", Txt_KullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa frm = new Anasayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

            //if (TxtKullanıcıAdı.Text == "M.F.Bilir" && TxtŞifre.Text == "123456")
            //{
            //    Anasayfa anasayfa = new Anasayfa();
            //    anasayfa.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            //}
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Txt_KullaniciAdi.Text = "deneme";
            Txt_Sifre.Text = "123";
        }

        /*
         SqlConnection bağlanti = new SqlConnection("Data Source=LAPTOP-QKT6284C;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yönetici where KullaniciAd=@p1 and Sifre=@p2", bağlanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa frm=new AnaSayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Yanlış Şifre");
            }

            bağlanti.Close();
        }
         */
    }
}
