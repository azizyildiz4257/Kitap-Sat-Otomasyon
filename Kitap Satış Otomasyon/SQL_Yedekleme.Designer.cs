namespace Kitap_Satış_Otomasyon
{
    partial class SQL_Yedekleme
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Sunucu = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Yedekle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sec = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Adres = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Veritabanı = new DevExpress.XtraEditors.TextEdit();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Sunucu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Adres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Veritabanı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sunucu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Veritabanı :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(44, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Adres :";
            // 
            // Txt_Sunucu
            // 
            this.Txt_Sunucu.EditValue = ".";
            this.Txt_Sunucu.Location = new System.Drawing.Point(100, 12);
            this.Txt_Sunucu.Name = "Txt_Sunucu";
            this.Txt_Sunucu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Sunucu.Properties.Appearance.Options.UseFont = true;
            this.Txt_Sunucu.Size = new System.Drawing.Size(213, 22);
            this.Txt_Sunucu.TabIndex = 4;
            // 
            // Btn_Yedekle
            // 
            this.Btn_Yedekle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Yedekle.Appearance.Options.UseFont = true;
            this.Btn_Yedekle.Location = new System.Drawing.Point(100, 97);
            this.Btn_Yedekle.Name = "Btn_Yedekle";
            this.Btn_Yedekle.Size = new System.Drawing.Size(97, 28);
            this.Btn_Yedekle.TabIndex = 11;
            this.Btn_Yedekle.Text = "Yedekle";
            this.Btn_Yedekle.Click += new System.EventHandler(this.Btn_Yedekle_Click_1);
            // 
            // Btn_Sec
            // 
            this.Btn_Sec.Location = new System.Drawing.Point(291, 69);
            this.Btn_Sec.Name = "Btn_Sec";
            this.Btn_Sec.Size = new System.Drawing.Size(22, 22);
            this.Btn_Sec.TabIndex = 10;
            this.Btn_Sec.Text = "...";
            this.Btn_Sec.Click += new System.EventHandler(this.Btn_Sec_Click_1);
            // 
            // Txt_Adres
            // 
            this.Txt_Adres.Location = new System.Drawing.Point(100, 69);
            this.Txt_Adres.Name = "Txt_Adres";
            this.Txt_Adres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Adres.Properties.Appearance.Options.UseFont = true;
            this.Txt_Adres.Size = new System.Drawing.Size(185, 22);
            this.Txt_Adres.TabIndex = 9;
            // 
            // Txt_Veritabanı
            // 
            this.Txt_Veritabanı.EditValue = "KütüphaneBilgileri";
            this.Txt_Veritabanı.Location = new System.Drawing.Point(100, 40);
            this.Txt_Veritabanı.Name = "Txt_Veritabanı";
            this.Txt_Veritabanı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Veritabanı.Properties.Appearance.Options.UseFont = true;
            this.Txt_Veritabanı.Size = new System.Drawing.Size(213, 22);
            this.Txt_Veritabanı.TabIndex = 8;
            // 
            // SQL_Yedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(324, 136);
            this.Controls.Add(this.Btn_Yedekle);
            this.Controls.Add(this.Btn_Sec);
            this.Controls.Add(this.Txt_Adres);
            this.Controls.Add(this.Txt_Veritabanı);
            this.Controls.Add(this.Txt_Sunucu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "SQL_Yedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Yedekleme";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Sunucu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Adres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Veritabanı.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_Sunucu;
        private DevExpress.XtraEditors.SimpleButton Btn_Yedekle;
        private DevExpress.XtraEditors.SimpleButton Btn_Sec;
        private DevExpress.XtraEditors.TextEdit Txt_Adres;
        private DevExpress.XtraEditors.TextEdit Txt_Veritabanı;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}