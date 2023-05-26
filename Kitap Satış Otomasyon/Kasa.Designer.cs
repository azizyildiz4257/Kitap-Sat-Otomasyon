namespace Kitap_Satış_Otomasyon
{
    partial class Kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LblSatılanKitapSayısı = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtKargoBedel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtSatısFiyatı = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtAlısFiyatı = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtKitapAra = new System.Windows.Forms.TextBox();
            this.LblToplamKar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblToplamKargoBedeli = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblToplamSatısFiyatı = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblToplamAlısFiyatı = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblKalemBazındaKitapSayısı = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAlınanKitapSayısı = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_UrunBazindaKitapSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 444);
            this.dataGridView1.TabIndex = 111;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Green;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(304, 444);
            this.splitter1.TabIndex = 115;
            this.splitter1.TabStop = false;
            // 
            // LblSatılanKitapSayısı
            // 
            this.LblSatılanKitapSayısı.AutoSize = true;
            this.LblSatılanKitapSayısı.BackColor = System.Drawing.Color.Green;
            this.LblSatılanKitapSayısı.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSatılanKitapSayısı.ForeColor = System.Drawing.Color.DarkGray;
            this.LblSatılanKitapSayısı.Location = new System.Drawing.Point(224, 203);
            this.LblSatılanKitapSayısı.Name = "LblSatılanKitapSayısı";
            this.LblSatılanKitapSayısı.Size = new System.Drawing.Size(24, 28);
            this.LblSatılanKitapSayısı.TabIndex = 129;
            this.LblSatılanKitapSayısı.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(65, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 130;
            this.label3.Text = "Satılan Kitap Sayısı :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.TxtKargoBedel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TxtSatısFiyatı);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TxtAlısFiyatı);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.TxtKitapAra);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 163);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // TxtKargoBedel
            // 
            this.TxtKargoBedel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKargoBedel.Location = new System.Drawing.Point(116, 121);
            this.TxtKargoBedel.Name = "TxtKargoBedel";
            this.TxtKargoBedel.Size = new System.Drawing.Size(143, 24);
            this.TxtKargoBedel.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 21);
            this.label16.TabIndex = 46;
            this.label16.Text = "Kargo Bedeli";
            // 
            // TxtSatısFiyatı
            // 
            this.TxtSatısFiyatı.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatısFiyatı.Location = new System.Drawing.Point(116, 90);
            this.TxtSatısFiyatı.Name = "TxtSatısFiyatı";
            this.TxtSatısFiyatı.Size = new System.Drawing.Size(143, 24);
            this.TxtSatısFiyatı.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(19, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 21);
            this.label15.TabIndex = 44;
            this.label15.Text = "Satış Fiyatı";
            // 
            // TxtAlısFiyatı
            // 
            this.TxtAlısFiyatı.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlısFiyatı.Location = new System.Drawing.Point(116, 59);
            this.TxtAlısFiyatı.Name = "TxtAlısFiyatı";
            this.TxtAlısFiyatı.Size = new System.Drawing.Size(143, 24);
            this.TxtAlısFiyatı.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(26, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 21);
            this.label17.TabIndex = 40;
            this.label17.Text = "Alış Fiyatı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(34, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 21);
            this.label18.TabIndex = 38;
            this.label18.Text = "Kitap Adı";
            // 
            // TxtKitapAra
            // 
            this.TxtKitapAra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAra.Location = new System.Drawing.Point(116, 28);
            this.TxtKitapAra.Name = "TxtKitapAra";
            this.TxtKitapAra.Size = new System.Drawing.Size(143, 24);
            this.TxtKitapAra.TabIndex = 37;
            this.TxtKitapAra.TextChanged += new System.EventHandler(this.TxtKitapAra_TextChanged_1);
            // 
            // LblToplamKar
            // 
            this.LblToplamKar.AutoSize = true;
            this.LblToplamKar.BackColor = System.Drawing.Color.Green;
            this.LblToplamKar.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamKar.ForeColor = System.Drawing.Color.DarkGray;
            this.LblToplamKar.Location = new System.Drawing.Point(224, 407);
            this.LblToplamKar.Name = "LblToplamKar";
            this.LblToplamKar.Size = new System.Drawing.Size(24, 28);
            this.LblToplamKar.TabIndex = 126;
            this.LblToplamKar.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(120, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 127;
            this.label10.Text = "Toplam Kar :";
            // 
            // LblToplamKargoBedeli
            // 
            this.LblToplamKargoBedeli.AutoSize = true;
            this.LblToplamKargoBedeli.BackColor = System.Drawing.Color.Green;
            this.LblToplamKargoBedeli.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamKargoBedeli.ForeColor = System.Drawing.Color.DarkGray;
            this.LblToplamKargoBedeli.Location = new System.Drawing.Point(224, 373);
            this.LblToplamKargoBedeli.Name = "LblToplamKargoBedeli";
            this.LblToplamKargoBedeli.Size = new System.Drawing.Size(24, 28);
            this.LblToplamKargoBedeli.TabIndex = 124;
            this.LblToplamKargoBedeli.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(57, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 19);
            this.label8.TabIndex = 125;
            this.label8.Text = "Toplam Kargo Bedeli :";
            // 
            // LblToplamSatısFiyatı
            // 
            this.LblToplamSatısFiyatı.AutoSize = true;
            this.LblToplamSatısFiyatı.BackColor = System.Drawing.Color.Green;
            this.LblToplamSatısFiyatı.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamSatısFiyatı.ForeColor = System.Drawing.Color.DarkGray;
            this.LblToplamSatısFiyatı.Location = new System.Drawing.Point(224, 339);
            this.LblToplamSatısFiyatı.Name = "LblToplamSatısFiyatı";
            this.LblToplamSatısFiyatı.Size = new System.Drawing.Size(24, 28);
            this.LblToplamSatısFiyatı.TabIndex = 122;
            this.LblToplamSatısFiyatı.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(67, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 123;
            this.label6.Text = "Toplam Satış Fiyatı :";
            // 
            // LblToplamAlısFiyatı
            // 
            this.LblToplamAlısFiyatı.AutoSize = true;
            this.LblToplamAlısFiyatı.BackColor = System.Drawing.Color.Green;
            this.LblToplamAlısFiyatı.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamAlısFiyatı.ForeColor = System.Drawing.Color.DarkGray;
            this.LblToplamAlısFiyatı.Location = new System.Drawing.Point(224, 305);
            this.LblToplamAlısFiyatı.Name = "LblToplamAlısFiyatı";
            this.LblToplamAlısFiyatı.Size = new System.Drawing.Size(24, 28);
            this.LblToplamAlısFiyatı.TabIndex = 120;
            this.LblToplamAlısFiyatı.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(74, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 121;
            this.label4.Text = "Toplam Alış Fiyatı :";
            // 
            // LblKalemBazındaKitapSayısı
            // 
            this.LblKalemBazındaKitapSayısı.AutoSize = true;
            this.LblKalemBazındaKitapSayısı.BackColor = System.Drawing.Color.Green;
            this.LblKalemBazındaKitapSayısı.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKalemBazındaKitapSayısı.ForeColor = System.Drawing.Color.DarkGray;
            this.LblKalemBazındaKitapSayısı.Location = new System.Drawing.Point(224, 237);
            this.LblKalemBazındaKitapSayısı.Name = "LblKalemBazındaKitapSayısı";
            this.LblKalemBazındaKitapSayısı.Size = new System.Drawing.Size(24, 28);
            this.LblKalemBazındaKitapSayısı.TabIndex = 118;
            this.LblKalemBazındaKitapSayısı.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(19, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 119;
            this.label2.Text = "Ürün Bazında Kitap Sayısı :";
            // 
            // LblAlınanKitapSayısı
            // 
            this.LblAlınanKitapSayısı.AutoSize = true;
            this.LblAlınanKitapSayısı.BackColor = System.Drawing.Color.Green;
            this.LblAlınanKitapSayısı.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAlınanKitapSayısı.ForeColor = System.Drawing.Color.DarkGray;
            this.LblAlınanKitapSayısı.Location = new System.Drawing.Point(224, 169);
            this.LblAlınanKitapSayısı.Name = "LblAlınanKitapSayısı";
            this.LblAlınanKitapSayısı.Size = new System.Drawing.Size(24, 28);
            this.LblAlınanKitapSayısı.TabIndex = 116;
            this.LblAlınanKitapSayısı.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Green;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Coral;
            this.label20.Location = new System.Drawing.Point(66, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 19);
            this.label20.TabIndex = 117;
            this.label20.Text = "Alınan Kitap Sayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 131;
            this.label1.Text = "Kalem Bazında Kitap Sayısı :";
            // 
            // Lbl_UrunBazindaKitapSayisi
            // 
            this.Lbl_UrunBazindaKitapSayisi.AutoSize = true;
            this.Lbl_UrunBazindaKitapSayisi.BackColor = System.Drawing.Color.Green;
            this.Lbl_UrunBazindaKitapSayisi.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_UrunBazindaKitapSayisi.ForeColor = System.Drawing.Color.DarkGray;
            this.Lbl_UrunBazindaKitapSayisi.Location = new System.Drawing.Point(224, 271);
            this.Lbl_UrunBazindaKitapSayisi.Name = "Lbl_UrunBazindaKitapSayisi";
            this.Lbl_UrunBazindaKitapSayisi.Size = new System.Drawing.Size(24, 28);
            this.Lbl_UrunBazindaKitapSayisi.TabIndex = 132;
            this.Lbl_UrunBazindaKitapSayisi.Text = "0";
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(844, 444);
            this.Controls.Add(this.Lbl_UrunBazindaKitapSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSatılanKitapSayısı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblToplamKar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblToplamKargoBedeli);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblToplamSatısFiyatı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblToplamAlısFiyatı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblKalemBazındaKitapSayısı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblAlınanKitapSayısı);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label LblSatılanKitapSayısı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtKargoBedel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtSatısFiyatı;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtAlısFiyatı;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtKitapAra;
        private System.Windows.Forms.Label LblToplamKar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblToplamKargoBedeli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblToplamSatısFiyatı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblToplamAlısFiyatı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblKalemBazındaKitapSayısı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAlınanKitapSayısı;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_UrunBazindaKitapSayisi;
    }
}