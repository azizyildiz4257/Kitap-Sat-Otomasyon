namespace Kitap_Satış_Otomasyon
{
    partial class AlınmısKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlınmısKitaplar));
            this.DGVAlinmisKitap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSatış = new System.Windows.Forms.TextBox();
            this.DTPCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPKayıtTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtYazarı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiyatı = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBarkodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKitapAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LblKitapSayısı = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGizli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlinmisKitap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVAlinmisKitap
            // 
            this.DGVAlinmisKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlinmisKitap.Location = new System.Drawing.Point(259, 0);
            this.DGVAlinmisKitap.Name = "DGVAlinmisKitap";
            this.DGVAlinmisKitap.Size = new System.Drawing.Size(1140, 435);
            this.DGVAlinmisKitap.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSatış);
            this.groupBox1.Controls.Add(this.DTPCikisTarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DTPKayıtTarihi);
            this.groupBox1.Controls.Add(this.TxtYazarı);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtFiyatı);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtBarkodu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtKitapAra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 231);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Çıkış Tarihi ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Kayıt Tarihi ";
            // 
            // TxtSatış
            // 
            this.TxtSatış.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatış.Location = new System.Drawing.Point(100, 136);
            this.TxtSatış.Name = "TxtSatış";
            this.TxtSatış.Size = new System.Drawing.Size(117, 22);
            this.TxtSatış.TabIndex = 45;
            this.TxtSatış.TextChanged += new System.EventHandler(this.TxtSatış_TextChanged);
            // 
            // DTPCikisTarihi
            // 
            this.DTPCikisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPCikisTarihi.Location = new System.Drawing.Point(100, 191);
            this.DTPCikisTarihi.Name = "DTPCikisTarihi";
            this.DTPCikisTarihi.Size = new System.Drawing.Size(117, 22);
            this.DTPCikisTarihi.TabIndex = 71;
            this.DTPCikisTarihi.ValueChanged += new System.EventHandler(this.DTPCikisTarihi_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Satış Fiyatı";
            // 
            // DTPKayıtTarihi
            // 
            this.DTPKayıtTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPKayıtTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPKayıtTarihi.Location = new System.Drawing.Point(100, 163);
            this.DTPKayıtTarihi.Name = "DTPKayıtTarihi";
            this.DTPKayıtTarihi.Size = new System.Drawing.Size(117, 22);
            this.DTPKayıtTarihi.TabIndex = 69;
            this.DTPKayıtTarihi.ValueChanged += new System.EventHandler(this.DTPKayıtTarihi_ValueChanged);
            // 
            // TxtYazarı
            // 
            this.TxtYazarı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarı.Location = new System.Drawing.Point(100, 82);
            this.TxtYazarı.Name = "TxtYazarı";
            this.TxtYazarı.Size = new System.Drawing.Size(117, 22);
            this.TxtYazarı.TabIndex = 43;
            this.TxtYazarı.TextChanged += new System.EventHandler(this.TxtYazarı_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Yazarı";
            // 
            // TxtFiyatı
            // 
            this.TxtFiyatı.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyatı.Location = new System.Drawing.Point(100, 109);
            this.TxtFiyatı.Name = "TxtFiyatı";
            this.TxtFiyatı.Size = new System.Drawing.Size(117, 22);
            this.TxtFiyatı.TabIndex = 41;
            this.TxtFiyatı.TextChanged += new System.EventHandler(this.TxtFiyatı_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Alış Fiyatı";
            // 
            // TxtBarkodu
            // 
            this.TxtBarkodu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBarkodu.Location = new System.Drawing.Point(100, 28);
            this.TxtBarkodu.Name = "TxtBarkodu";
            this.TxtBarkodu.Size = new System.Drawing.Size(117, 22);
            this.TxtBarkodu.TabIndex = 39;
            this.TxtBarkodu.TextChanged += new System.EventHandler(this.TxtBarkodu_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Kitap Adı";
            // 
            // TxtKitapAra
            // 
            this.TxtKitapAra.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKitapAra.Location = new System.Drawing.Point(100, 55);
            this.TxtKitapAra.Name = "TxtKitapAra";
            this.TxtKitapAra.Size = new System.Drawing.Size(117, 22);
            this.TxtKitapAra.TabIndex = 37;
            this.TxtKitapAra.TextChanged += new System.EventHandler(this.TxtKitapAra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(32, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Barkodu";
            // 
            // LblKitapSayısı
            // 
            this.LblKitapSayısı.AutoSize = true;
            this.LblKitapSayısı.BackColor = System.Drawing.Color.Green;
            this.LblKitapSayısı.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKitapSayısı.ForeColor = System.Drawing.Color.Black;
            this.LblKitapSayısı.Location = new System.Drawing.Point(188, 233);
            this.LblKitapSayısı.Name = "LblKitapSayısı";
            this.LblKitapSayısı.Size = new System.Drawing.Size(28, 31);
            this.LblKitapSayısı.TabIndex = 70;
            this.LblKitapSayısı.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Green;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(8, 238);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(186, 23);
            this.label20.TabIndex = 71;
            this.label20.Text = "Toplam Kayıt Sayısı :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 200);
            this.panel1.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(259, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(648, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 74;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(438, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 75;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(282, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Satılmamış Kitaplar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(671, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 19);
            this.label6.TabIndex = 76;
            this.label6.Text = "Satılmış Stokta Bulunan Kitaplar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(461, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 19);
            this.label9.TabIndex = 77;
            this.label9.Text = "Stokta Olmayan Kitaplar";
            // 
            // BtnGizli
            // 
            this.BtnGizli.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGizli.Location = new System.Drawing.Point(313, 176);
            this.BtnGizli.Name = "BtnGizli";
            this.BtnGizli.Size = new System.Drawing.Size(17, 12);
            this.BtnGizli.TabIndex = 78;
            this.BtnGizli.Text = "button4";
            this.BtnGizli.UseVisualStyleBackColor = true;
            this.BtnGizli.Visible = false;
            // 
            // AlınmısKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.BtnGizli;
            this.ClientSize = new System.Drawing.Size(1399, 470);
            this.Controls.Add(this.BtnGizli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblKitapSayısı);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVAlinmisKitap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlınmısKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alınmış Kitaplar";
            this.Load += new System.EventHandler(this.AlınmısKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlinmisKitap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAlinmisKitap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSatış;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYazarı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFiyatı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBarkodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtKitapAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTPKayıtTarihi;
        private System.Windows.Forms.Label LblKitapSayısı;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPCikisTarihi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGizli;
    }
}