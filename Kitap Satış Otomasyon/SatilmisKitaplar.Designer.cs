namespace Kitap_Satış_Otomasyon
{
    partial class SatilmisKitaplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatilmisKitaplar));
            this.DGVSatilmisKitap = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtKargoBedel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSatış = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCiltNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYazarı = new System.Windows.Forms.TextBox();
            this.TxtKitapAdı = new System.Windows.Forms.TextBox();
            this.TxtKitapBarkod = new System.Windows.Forms.TextBox();
            this.Btnİptal = new System.Windows.Forms.Button();
            this.Btnİade = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSatısFiyatı = new System.Windows.Forms.TextBox();
            this.DTPCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.DTPKayıtTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtAlısFiyatı = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBarkodu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtKitapAra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LblKitapSayısı = new System.Windows.Forms.Label();
            this.DGVKitapAlis = new System.Windows.Forms.DataGridView();
            this.TxtKitapAlis = new System.Windows.Forms.TextBox();
            this.TxtKayıtTarihi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSatilmisKitap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKitapAlis)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSatilmisKitap
            // 
            this.DGVSatilmisKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSatilmisKitap.Location = new System.Drawing.Point(247, 0);
            this.DGVSatilmisKitap.Name = "DGVSatilmisKitap";
            this.DGVSatilmisKitap.Size = new System.Drawing.Size(1242, 469);
            this.DGVSatilmisKitap.TabIndex = 0;
            this.DGVSatilmisKitap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSatilmisKitap_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Green;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 89;
            this.label11.Text = "Kargo Bedeli";
            // 
            // TxtKargoBedel
            // 
            this.TxtKargoBedel.Enabled = false;
            this.TxtKargoBedel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKargoBedel.Location = new System.Drawing.Point(103, 199);
            this.TxtKargoBedel.Name = "TxtKargoBedel";
            this.TxtKargoBedel.Size = new System.Drawing.Size(134, 22);
            this.TxtKargoBedel.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 87;
            this.label9.Text = "Satış Fiyatı";
            // 
            // TxtSatış
            // 
            this.TxtSatış.Enabled = false;
            this.TxtSatış.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatış.Location = new System.Drawing.Point(103, 172);
            this.TxtSatış.Name = "TxtSatış";
            this.TxtSatış.Size = new System.Drawing.Size(134, 22);
            this.TxtSatış.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 85;
            this.label6.Text = "Alış Fiyatı";
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.Enabled = false;
            this.TxtAlisFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlisFiyat.Location = new System.Drawing.Point(103, 145);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            this.TxtAlisFiyat.Size = new System.Drawing.Size(134, 22);
            this.TxtAlisFiyat.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 83;
            this.label5.Text = "Stok Sayısı";
            // 
            // TxtStok
            // 
            this.TxtStok.Enabled = false;
            this.TxtStok.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStok.Location = new System.Drawing.Point(103, 118);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(134, 22);
            this.TxtStok.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 81;
            this.label4.Text = "Cilt No";
            // 
            // TxtCiltNo
            // 
            this.TxtCiltNo.Enabled = false;
            this.TxtCiltNo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCiltNo.Location = new System.Drawing.Point(103, 92);
            this.TxtCiltNo.Name = "TxtCiltNo";
            this.TxtCiltNo.Size = new System.Drawing.Size(134, 22);
            this.TxtCiltNo.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 79;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "K.BarkodNo";
            // 
            // TxtYazarı
            // 
            this.TxtYazarı.Enabled = false;
            this.TxtYazarı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarı.Location = new System.Drawing.Point(103, 66);
            this.TxtYazarı.Name = "TxtYazarı";
            this.TxtYazarı.Size = new System.Drawing.Size(134, 22);
            this.TxtYazarı.TabIndex = 76;
            // 
            // TxtKitapAdı
            // 
            this.TxtKitapAdı.Enabled = false;
            this.TxtKitapAdı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAdı.Location = new System.Drawing.Point(103, 39);
            this.TxtKitapAdı.Name = "TxtKitapAdı";
            this.TxtKitapAdı.Size = new System.Drawing.Size(134, 22);
            this.TxtKitapAdı.TabIndex = 75;
            // 
            // TxtKitapBarkod
            // 
            this.TxtKitapBarkod.Enabled = false;
            this.TxtKitapBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapBarkod.Location = new System.Drawing.Point(103, 12);
            this.TxtKitapBarkod.Name = "TxtKitapBarkod";
            this.TxtKitapBarkod.Size = new System.Drawing.Size(134, 22);
            this.TxtKitapBarkod.TabIndex = 74;
            // 
            // Btnİptal
            // 
            this.Btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btnİptal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnİptal.ForeColor = System.Drawing.Color.Black;
            this.Btnİptal.Location = new System.Drawing.Point(13, 226);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(109, 46);
            this.Btnİptal.TabIndex = 91;
            this.Btnİptal.Text = "Kapat";
            this.Btnİptal.UseVisualStyleBackColor = true;
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // Btnİade
            // 
            this.Btnİade.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnİade.ForeColor = System.Drawing.Color.Black;
            this.Btnİade.Location = new System.Drawing.Point(128, 226);
            this.Btnİade.Name = "Btnİade";
            this.Btnİade.Size = new System.Drawing.Size(109, 46);
            this.Btnİade.TabIndex = 90;
            this.Btnİade.Text = "İade Al";
            this.Btnİade.UseVisualStyleBackColor = true;
            this.Btnİade.Click += new System.EventHandler(this.Btnİade_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtSatısFiyatı);
            this.groupBox1.Controls.Add(this.DTPCikisTarihi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.DTPKayıtTarihi);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtAlısFiyatı);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtBarkodu);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtKitapAra);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(9, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 231);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 72;
            this.label7.Text = "Çıkış Tarihi ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Kayıt Tarihi ";
            // 
            // TxtSatısFiyatı
            // 
            this.TxtSatısFiyatı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatısFiyatı.Location = new System.Drawing.Point(97, 136);
            this.TxtSatısFiyatı.Name = "TxtSatısFiyatı";
            this.TxtSatısFiyatı.Size = new System.Drawing.Size(115, 22);
            this.TxtSatısFiyatı.TabIndex = 45;
            this.TxtSatısFiyatı.TextChanged += new System.EventHandler(this.TxtSatısFiyatı_TextChanged);
            // 
            // DTPCikisTarihi
            // 
            this.DTPCikisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPCikisTarihi.Location = new System.Drawing.Point(97, 191);
            this.DTPCikisTarihi.Name = "DTPCikisTarihi";
            this.DTPCikisTarihi.Size = new System.Drawing.Size(115, 22);
            this.DTPCikisTarihi.TabIndex = 71;
            this.DTPCikisTarihi.ValueChanged += new System.EventHandler(this.DTPCikisTarihi_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 44;
            this.label10.Text = "Satış Fiyatı";
            // 
            // DTPKayıtTarihi
            // 
            this.DTPKayıtTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPKayıtTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPKayıtTarihi.Location = new System.Drawing.Point(97, 163);
            this.DTPKayıtTarihi.Name = "DTPKayıtTarihi";
            this.DTPKayıtTarihi.Size = new System.Drawing.Size(115, 22);
            this.DTPKayıtTarihi.TabIndex = 69;
            this.DTPKayıtTarihi.ValueChanged += new System.EventHandler(this.DTPKayıtTarihi_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(97, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 22);
            this.textBox2.TabIndex = 43;
            this.textBox2.TextChanged += new System.EventHandler(this.TxtYazarı_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(42, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 42;
            this.label12.Text = "Yazarı";
            // 
            // TxtAlısFiyatı
            // 
            this.TxtAlısFiyatı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlısFiyatı.Location = new System.Drawing.Point(97, 109);
            this.TxtAlısFiyatı.Name = "TxtAlısFiyatı";
            this.TxtAlısFiyatı.Size = new System.Drawing.Size(115, 22);
            this.TxtAlısFiyatı.TabIndex = 41;
            this.TxtAlısFiyatı.TextChanged += new System.EventHandler(this.TxtAlısFiyatı_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "Alış Fiyatı";
            // 
            // TxtBarkodu
            // 
            this.TxtBarkodu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBarkodu.Location = new System.Drawing.Point(97, 28);
            this.TxtBarkodu.Name = "TxtBarkodu";
            this.TxtBarkodu.Size = new System.Drawing.Size(115, 22);
            this.TxtBarkodu.TabIndex = 39;
            this.TxtBarkodu.TextChanged += new System.EventHandler(this.TxtBarkodu_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(20, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "Kitap Adı";
            // 
            // TxtKitapAra
            // 
            this.TxtKitapAra.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAra.Location = new System.Drawing.Point(97, 55);
            this.TxtKitapAra.Name = "TxtKitapAra";
            this.TxtKitapAra.Size = new System.Drawing.Size(115, 22);
            this.TxtKitapAra.TabIndex = 37;
            this.TxtKitapAra.TextChanged += new System.EventHandler(this.TxtKitapAra_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(26, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Barkodu";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Green;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(242, 476);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(186, 23);
            this.label20.TabIndex = 96;
            this.label20.Text = "Toplam Kayıt Sayısı :";
            // 
            // LblKitapSayısı
            // 
            this.LblKitapSayısı.AutoSize = true;
            this.LblKitapSayısı.BackColor = System.Drawing.Color.Green;
            this.LblKitapSayısı.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKitapSayısı.ForeColor = System.Drawing.Color.Black;
            this.LblKitapSayısı.Location = new System.Drawing.Point(423, 472);
            this.LblKitapSayısı.Name = "LblKitapSayısı";
            this.LblKitapSayısı.Size = new System.Drawing.Size(28, 31);
            this.LblKitapSayısı.TabIndex = 95;
            this.LblKitapSayısı.Text = "0";
            // 
            // DGVKitapAlis
            // 
            this.DGVKitapAlis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKitapAlis.Location = new System.Drawing.Point(469, 368);
            this.DGVKitapAlis.Name = "DGVKitapAlis";
            this.DGVKitapAlis.Size = new System.Drawing.Size(223, 129);
            this.DGVKitapAlis.TabIndex = 98;
            this.DGVKitapAlis.Visible = false;
            // 
            // TxtKitapAlis
            // 
            this.TxtKitapAlis.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAlis.Location = new System.Drawing.Point(716, 475);
            this.TxtKitapAlis.Name = "TxtKitapAlis";
            this.TxtKitapAlis.Size = new System.Drawing.Size(134, 22);
            this.TxtKitapAlis.TabIndex = 99;
            this.TxtKitapAlis.Visible = false;
            this.TxtKitapAlis.TextChanged += new System.EventHandler(this.TxtKitapAlis_TextChanged);
            // 
            // TxtKayıtTarihi
            // 
            this.TxtKayıtTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKayıtTarihi.Location = new System.Drawing.Point(865, 475);
            this.TxtKayıtTarihi.Name = "TxtKayıtTarihi";
            this.TxtKayıtTarihi.Size = new System.Drawing.Size(134, 22);
            this.TxtKayıtTarihi.TabIndex = 100;
            this.TxtKayıtTarihi.Visible = false;
            // 
            // SatilmisKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.Btnİptal;
            this.ClientSize = new System.Drawing.Size(1489, 510);
            this.Controls.Add(this.TxtKayıtTarihi);
            this.Controls.Add(this.TxtKitapAlis);
            this.Controls.Add(this.DGVKitapAlis);
            this.Controls.Add(this.LblKitapSayısı);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.Btnİade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtKargoBedel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSatış);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAlisFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCiltNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtYazarı);
            this.Controls.Add(this.TxtKitapAdı);
            this.Controls.Add(this.TxtKitapBarkod);
            this.Controls.Add(this.DGVSatilmisKitap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SatilmisKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satılmış Kitaplar";
            this.Load += new System.EventHandler(this.SatilmisKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSatilmisKitap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKitapAlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSatilmisKitap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtKargoBedel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSatış;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAlisFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCiltNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtYazarı;
        private System.Windows.Forms.TextBox TxtKitapAdı;
        private System.Windows.Forms.TextBox TxtKitapBarkod;
        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.Button Btnİade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSatısFiyatı;
        private System.Windows.Forms.DateTimePicker DTPCikisTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTPKayıtTarihi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtAlısFiyatı;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBarkodu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtKitapAra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label LblKitapSayısı;
        private System.Windows.Forms.DataGridView DGVKitapAlis;
        private System.Windows.Forms.TextBox TxtKitapAlis;
        private System.Windows.Forms.TextBox TxtKayıtTarihi;
    }
}