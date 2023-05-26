namespace Kitap_Satış_Otomasyon
{
    partial class KitapAlis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapAlis));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYazarı = new System.Windows.Forms.TextBox();
            this.TxtKitapAdı = new System.Windows.Forms.TextBox();
            this.TxtKitapBarkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCiltNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAlisFiyat = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.Btnİptal = new System.Windows.Forms.Button();
            this.DGVKitapAlis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFiyatı = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBarkodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKitapAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LblKitapSayısı = new System.Windows.Forms.Label();
            this.DGVKontrol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKitapAlis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "K.BarkodNo";
            // 
            // TxtYazarı
            // 
            this.TxtYazarı.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarı.Location = new System.Drawing.Point(99, 65);
            this.TxtYazarı.Name = "TxtYazarı";
            this.TxtYazarı.Size = new System.Drawing.Size(134, 22);
            this.TxtYazarı.TabIndex = 14;
            // 
            // TxtKitapAdı
            // 
            this.TxtKitapAdı.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAdı.Location = new System.Drawing.Point(99, 39);
            this.TxtKitapAdı.Name = "TxtKitapAdı";
            this.TxtKitapAdı.Size = new System.Drawing.Size(134, 22);
            this.TxtKitapAdı.TabIndex = 13;
            this.TxtKitapAdı.TextChanged += new System.EventHandler(this.TxtKitapAdı_TextChanged);
            // 
            // TxtKitapBarkod
            // 
            this.TxtKitapBarkod.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapBarkod.Location = new System.Drawing.Point(99, 13);
            this.TxtKitapBarkod.Name = "TxtKitapBarkod";
            this.TxtKitapBarkod.Size = new System.Drawing.Size(134, 22);
            this.TxtKitapBarkod.TabIndex = 12;
            this.TxtKitapBarkod.TextChanged += new System.EventHandler(this.TxtKitapBarkod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cilt No";
            // 
            // TxtCiltNo
            // 
            this.TxtCiltNo.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCiltNo.Location = new System.Drawing.Point(99, 91);
            this.TxtCiltNo.Name = "TxtCiltNo";
            this.TxtCiltNo.Size = new System.Drawing.Size(134, 22);
            this.TxtCiltNo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Alış Adeti";
            // 
            // TxtStok
            // 
            this.TxtStok.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtStok.Location = new System.Drawing.Point(99, 117);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(134, 22);
            this.TxtStok.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Alış Fiyatı";
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlisFiyat.Location = new System.Drawing.Point(99, 143);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            this.TxtAlisFiyat.Size = new System.Drawing.Size(134, 22);
            this.TxtAlisFiyat.TabIndex = 22;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(245, 438);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(10, 173);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(109, 46);
            this.BtnKaydet.TabIndex = 25;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGüncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnGüncelle.Location = new System.Drawing.Point(125, 173);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(109, 46);
            this.BtnGüncelle.TabIndex = 26;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.Black;
            this.BtnSil.Location = new System.Drawing.Point(125, 225);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(109, 46);
            this.BtnSil.TabIndex = 27;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // Btnİptal
            // 
            this.Btnİptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btnİptal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnİptal.ForeColor = System.Drawing.Color.Black;
            this.Btnİptal.Location = new System.Drawing.Point(10, 225);
            this.Btnİptal.Name = "Btnİptal";
            this.Btnİptal.Size = new System.Drawing.Size(109, 46);
            this.Btnİptal.TabIndex = 28;
            this.Btnİptal.Text = "Kapat";
            this.Btnİptal.UseVisualStyleBackColor = true;
            this.Btnİptal.Click += new System.EventHandler(this.Btnİptal_Click);
            // 
            // DGVKitapAlis
            // 
            this.DGVKitapAlis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKitapAlis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVKitapAlis.Location = new System.Drawing.Point(245, 0);
            this.DGVKitapAlis.Name = "DGVKitapAlis";
            this.DGVKitapAlis.Size = new System.Drawing.Size(842, 438);
            this.DGVKitapAlis.TabIndex = 29;
            this.DGVKitapAlis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKitapAlis_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.TxtFiyatı);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtBarkodu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtKitapAra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 121);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitaplarda Ara";
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
            this.label8.Location = new System.Drawing.Point(35, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Fiyatı";
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
            this.label7.Location = new System.Drawing.Point(12, 55);
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
            this.label10.Location = new System.Drawing.Point(18, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Barkodu";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(6, 404);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(186, 23);
            this.label20.TabIndex = 48;
            this.label20.Text = "Toplam Kayıt Sayısı :";
            // 
            // LblKitapSayısı
            // 
            this.LblKitapSayısı.AutoSize = true;
            this.LblKitapSayısı.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKitapSayısı.ForeColor = System.Drawing.Color.Black;
            this.LblKitapSayısı.Location = new System.Drawing.Point(187, 400);
            this.LblKitapSayısı.Name = "LblKitapSayısı";
            this.LblKitapSayısı.Size = new System.Drawing.Size(28, 31);
            this.LblKitapSayısı.TabIndex = 47;
            this.LblKitapSayısı.Text = "0";
            // 
            // DGVKontrol
            // 
            this.DGVKontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKontrol.Location = new System.Drawing.Point(219, 407);
            this.DGVKontrol.Name = "DGVKontrol";
            this.DGVKontrol.Size = new System.Drawing.Size(20, 20);
            this.DGVKontrol.TabIndex = 49;
            this.DGVKontrol.Visible = false;
            // 
            // KitapAlis
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelButton = this.Btnİptal;
            this.ClientSize = new System.Drawing.Size(1087, 438);
            this.Controls.Add(this.DGVKontrol);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.LblKitapSayısı);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVKitapAlis);
            this.Controls.Add(this.Btnİptal);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnKaydet);
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
            this.Name = "KitapAlis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Kayıt";
            this.Load += new System.EventHandler(this.KitapAlis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKitapAlis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKontrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtYazarı;
        private System.Windows.Forms.TextBox TxtKitapAdı;
        private System.Windows.Forms.TextBox TxtKitapBarkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCiltNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAlisFiyat;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button Btnİptal;
        private System.Windows.Forms.DataGridView DGVKitapAlis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtKitapAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label LblKitapSayısı;
        private System.Windows.Forms.TextBox TxtFiyatı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBarkodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVKontrol;
    }
}