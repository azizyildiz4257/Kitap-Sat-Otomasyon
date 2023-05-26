using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_Satış_Otomasyon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void BtnOturumKapat_Click(object sender, EventArgs e)
        {
            KitapAlis kitapAlis = new KitapAlis();
            kitapAlis.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapSatis kitapSatis = new KitapSatis();
            kitapSatis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlınmısKitaplar alınmısKitaplar = new AlınmısKitaplar();
            alınmısKitaplar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SatilmisKitaplar satilmisKitaplar = new SatilmisKitaplar();
            satilmisKitaplar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Yedekle_Click(object sender, EventArgs e)
        {
            SQL_Yedekleme sQL_Yedekleme = new SQL_Yedekleme();
            sQL_Yedekleme.Show();
        }
    }
}
