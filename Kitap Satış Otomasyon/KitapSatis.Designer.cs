namespace Kitap_Satış_Otomasyon
{
    partial class KitapSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapSatis));
            this.LblKitapSayısı = new System.Windows.Forms.Label();
            this.TxtFiyatı = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBarkodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKitapAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_SatisNo = new System.Windows.Forms.TextBox();
            this.DGVKitapSatis = new System.Windows.Forms.DataGridView();
            this.Btnİptal = new System.Windows.Forms.Button();
            this.BtnSatış = new System.Windows.Forms.Button();
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSatış = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtKargoBedel = new System.Windows.Forms.TextBox();
            this.DGVGizli = new System.Windows.Forms.DataGridView();
            this.Txt_SatisMiktari = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKitapSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGizli)).BeginInit();
            this.SuspendLayout();
            // 
            // LblKitapSayısı
            // 
            this.LblKitapSayısı.AutoSize = true;
            this.LblKitapSayısı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblKitapSayısı.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKitapSayısı.ForeColor = System.Drawing.Color.Black;
            this.LblKitapSayısı.Location = new System.Drawing.Point(187, 432);
            this.LblKitapSayısı.Name = "LblKitapSayısı";
            this.LblKitapSayısı.Size = new System.Drawing.Size(28, 31);
            this.LblKitapSayısı.TabIndex = 68;
            this.LblKitapSayısı.Text = "0";
            // 
            // TxtFiyatı
            // 
            this.TxtFiyatı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyatı.Location = new System.Drawing.Point(88, 81);
            this.TxtFiyatı.Name = "TxtFiyatı";
            this.TxtFiyatı.Size = new System.Drawing.Size(117, 22);
            this.TxtFiyatı.TabIndex = 41;
            this.TxtFiyatı.TextChanged += new System.EventHandler(this.TxtFiyatı_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Alış Fiyatı";
            // 
            // TxtBarkodu
            // 
            this.TxtBarkodu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBarkodu.Location = new System.Drawing.Point(88, 27);
            this.TxtBarkodu.Name = "TxtBarkodu";
            this.TxtBarkodu.Size = new System.Drawing.Size(117, 22);
            this.TxtBarkodu.TabIndex = 39;
            this.TxtBarkodu.TextChanged += new System.EventHandler(this.TxtBarkodu_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kitap Adı";
            // 
            // TxtKitapAra
            // 
            this.TxtKitapAra.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAra.Location = new System.Drawing.Point(88, 54);
            this.TxtKitapAra.Name = "TxtKitapAra";
            this.TxtKitapAra.Size = new System.Drawing.Size(117, 22);
            this.TxtKitapAra.TabIndex = 37;
            this.TxtKitapAra.TextChanged += new System.EventHandler(this.TxtKitapAra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(20, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Barkodu";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label20.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(6, 436);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(186, 23);
            this.label20.TabIndex = 69;
            this.label20.Text = "Toplam Kayıt Sayısı :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.Txt_SatisNo);
            this.groupBox1.Controls.Add(this.TxtFiyatı);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtBarkodu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtKitapAra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 121);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitaplarda Ara";
            // 
            // Txt_SatisNo
            // 
            this.Txt_SatisNo.Enabled = false;
            this.Txt_SatisNo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_SatisNo.Location = new System.Drawing.Point(48, -1);
            this.Txt_SatisNo.Name = "Txt_SatisNo";
            this.Txt_SatisNo.Size = new System.Drawing.Size(134, 22);
            this.Txt_SatisNo.TabIndex = 77;
            this.Txt_SatisNo.Visible = false;
            // 
            // DGVKitapSatis
            // 
            this.DGVKitapSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKitapSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVKitapSatis.Location = new System.Drawing.Point(245, 0);
            this.DGVKitapSatis.Name = "DGVKitapSatis";
            this.DGVKitapSatis.Size = new System.Drawing.Size(842, 466);
            this.DGVKitapSatis.TabIndex = 66;
            this.DGVKitapSatis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKitapSatis_CellDoubleClick);
            // 
            // Btnİptal
            // 
            this.Btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btnİptal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnİptal.ForeColor = System.Drawing.Color.Black;
            this.Btnİptal.Location = new System.Drawing.Point(9, 258);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(109, 46);
            this.Btnİptal.TabIndex = 65;
            this.Btnİptal.Text = "Kapat";
            this.Btnİptal.UseVisualStyleBackColor = true;
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // BtnSatış
            // 
            this.BtnSatış.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSatış.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatış.ForeColor = System.Drawing.Color.Black;
            this.BtnSatış.Location = new System.Drawing.Point(124, 258);
            this.BtnSatış.Name = "BtnSatış";
            this.BtnSatış.Size = new System.Drawing.Size(109, 46);
            this.BtnSatış.TabIndex = 64;
            this.BtnSatış.Text = "Satış Yap";
            this.BtnSatış.UseVisualStyleBackColor = true;
            this.BtnSatış.Click += new System.EventHandler(this.BtnSatış_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Alış Fiyatı";
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.Enabled = false;
            this.TxtAlisFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlisFiyat.Location = new System.Drawing.Point(99, 148);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            this.TxtAlisFiyat.Size = new System.Drawing.Size(134, 22);
            this.TxtAlisFiyat.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Stok Sayısı";
            // 
            // TxtStok
            // 
            this.TxtStok.Enabled = false;
            this.TxtStok.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStok.Location = new System.Drawing.Point(99, 121);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(134, 22);
            this.TxtStok.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Cilt No";
            // 
            // TxtCiltNo
            // 
            this.TxtCiltNo.Enabled = false;
            this.TxtCiltNo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCiltNo.Location = new System.Drawing.Point(99, 94);
            this.TxtCiltNo.Name = "TxtCiltNo";
            this.TxtCiltNo.Size = new System.Drawing.Size(134, 22);
            this.TxtCiltNo.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "K.BarkodNo";
            // 
            // TxtYazarı
            // 
            this.TxtYazarı.Enabled = false;
            this.TxtYazarı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarı.Location = new System.Drawing.Point(99, 67);
            this.TxtYazarı.Name = "TxtYazarı";
            this.TxtYazarı.Size = new System.Drawing.Size(134, 22);
            this.TxtYazarı.TabIndex = 51;
            // 
            // TxtKitapAdı
            // 
            this.TxtKitapAdı.Enabled = false;
            this.TxtKitapAdı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAdı.Location = new System.Drawing.Point(99, 40);
            this.TxtKitapAdı.Name = "TxtKitapAdı";
            this.TxtKitapAdı.Size = new System.Drawing.Size(134, 22);
            this.TxtKitapAdı.TabIndex = 50;
            // 
            // TxtKitapBarkod
            // 
            this.TxtKitapBarkod.Enabled = false;
            this.TxtKitapBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapBarkod.Location = new System.Drawing.Point(99, 13);
            this.TxtKitapBarkod.Name = "TxtKitapBarkod";
            this.TxtKitapBarkod.Size = new System.Drawing.Size(134, 22);
            this.TxtKitapBarkod.TabIndex = 49;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(245, 466);
            this.splitter1.TabIndex = 61;
            this.splitter1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 71;
            this.label9.Text = "Satış Fiyatı";
            // 
            // TxtSatış
            // 
            this.TxtSatış.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatış.Location = new System.Drawing.Point(99, 175);
            this.TxtSatış.Name = "TxtSatış";
            this.TxtSatış.Size = new System.Drawing.Size(134, 22);
            this.TxtSatış.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 73;
            this.label11.Text = "Kargo Bedeli";
            // 
            // TxtKargoBedel
            // 
            this.TxtKargoBedel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKargoBedel.Location = new System.Drawing.Point(99, 229);
            this.TxtKargoBedel.Name = "TxtKargoBedel";
            this.TxtKargoBedel.Size = new System.Drawing.Size(134, 22);
            this.TxtKargoBedel.TabIndex = 2;
            // 
            // DGVGizli
            // 
            this.DGVGizli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGizli.Location = new System.Drawing.Point(214, 258);
            this.DGVGizli.Name = "DGVGizli";
            this.DGVGizli.Size = new System.Drawing.Size(845, 198);
            this.DGVGizli.TabIndex = 74;
            this.DGVGizli.Visible = false;
            // 
            // Txt_SatisMiktari
            // 
            this.Txt_SatisMiktari.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_SatisMiktari.Location = new System.Drawing.Point(99, 202);
            this.Txt_SatisMiktari.Name = "Txt_SatisMiktari";
            this.Txt_SatisMiktari.Size = new System.Drawing.Size(134, 22);
            this.Txt_SatisMiktari.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 76;
            this.label12.Text = "Satış Miktarı";
            // 
            // KitapSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelButton = this.Btnİptal;
            this.ClientSize = new System.Drawing.Size(1087, 466);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Txt_SatisMiktari);
            this.Controls.Add(this.DGVGizli);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtKargoBedel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSatış);
            this.Controls.Add(this.LblKitapSayısı);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVKitapSatis);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.BtnSatış);
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
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KitapSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Satış";
            this.Load += new System.EventHandler(this.KitapSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKitapSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGizli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKitapSayısı;
        private System.Windows.Forms.TextBox TxtFiyatı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBarkodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKitapAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVKitapSatis;
        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.Button BtnSatış;
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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSatış;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtKargoBedel;
        private System.Windows.Forms.DataGridView DGVGizli;
        private System.Windows.Forms.TextBox Txt_SatisMiktari;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_SatisNo;
    }
}