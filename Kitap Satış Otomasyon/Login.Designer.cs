namespace Kitap_Satış_Otomasyon
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnÇıkış = new System.Windows.Forms.Button();
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // BtnÇıkış
            // 
            this.BtnÇıkış.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnÇıkış.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnÇıkış.Location = new System.Drawing.Point(251, 114);
            this.BtnÇıkış.Name = "BtnÇıkış";
            this.BtnÇıkış.Size = new System.Drawing.Size(82, 27);
            this.BtnÇıkış.TabIndex = 37;
            this.BtnÇıkış.Text = "Çıkış";
            this.BtnÇıkış.UseVisualStyleBackColor = true;
            this.BtnÇıkış.Click += new System.EventHandler(this.BtnÇıkış_Click);
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiriş.Location = new System.Drawing.Point(339, 114);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(82, 27);
            this.BtnGiriş.TabIndex = 36;
            this.BtnGiriş.Text = "Giriş";
            this.BtnGiriş.UseVisualStyleBackColor = true;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Sifre.Location = new System.Drawing.Point(287, 77);
            this.Txt_Sifre.MaxLength = 6;
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.PasswordChar = '•';
            this.Txt_Sifre.Size = new System.Drawing.Size(134, 22);
            this.Txt_Sifre.TabIndex = 35;
            // 
            // Txt_KullaniciAdi
            // 
            this.Txt_KullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_KullaniciAdi.Location = new System.Drawing.Point(287, 44);
            this.Txt_KullaniciAdi.Name = "Txt_KullaniciAdi";
            this.Txt_KullaniciAdi.Size = new System.Drawing.Size(134, 24);
            this.Txt_KullaniciAdi.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(235, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // Login
            // 
            this.AcceptButton = this.BtnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.CancelButton = this.BtnÇıkış;
            this.ClientSize = new System.Drawing.Size(457, 181);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnÇıkış);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Txt_KullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnÇıkış;
        private System.Windows.Forms.Button BtnGiriş;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.TextBox Txt_KullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}