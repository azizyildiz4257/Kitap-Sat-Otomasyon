using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace Kitap_Satış_Otomasyon
{
    public partial class SQL_Yedekleme : Form
    {
        public SQL_Yedekleme()
        {
            InitializeComponent();
        }

        private void Btn_Sec_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sec_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Yedeklenecek yolu seçiniz.";
            saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak)|*.bak|Tüm Dosyalar(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Txt_Adres.Text = saveFileDialog1.FileName;
            }
        }

        private void Btn_Yedekle_Click(object sender, EventArgs e)
        {

        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("Yedekleme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Yedekle_Click_1(object sender, EventArgs e)
        {
            Server dbServer = new Server(new ServerConnection(Txt_Sunucu.Text));
            Backup dbBackup = new Backup();
            dbBackup.Action = BackupActionType.Database;
            dbBackup.Database = Txt_Veritabanı.Text;
            dbBackup.Devices.AddDevice(Txt_Adres.Text, DeviceType.File);
            dbBackup.Initialize = false;
            dbBackup.Complete += DbBackup_Complete;
            dbBackup.SqlBackup(dbServer);
        }
    }
}
