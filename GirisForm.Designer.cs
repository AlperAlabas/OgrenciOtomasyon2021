namespace OgrenciOtomasyon2021
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_kullaniciSifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciGiris = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(294, 149);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(88, 39);
            this.btn_giris.TabIndex = 39;
            this.btn_giris.Text = "       Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            this.btn_giris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_giris_KeyDown);
            this.btn_giris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_giris_KeyPress);
            // 
            // txt_kullaniciSifre
            // 
            this.txt_kullaniciSifre.Location = new System.Drawing.Point(175, 174);
            this.txt_kullaniciSifre.Name = "txt_kullaniciSifre";
            this.txt_kullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciSifre.TabIndex = 38;
            this.txt_kullaniciSifre.UseSystemPasswordChar = true;
            this.txt_kullaniciSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kullaniciSifre_KeyDown);
            // 
            // txt_kullaniciGiris
            // 
            this.txt_kullaniciGiris.Location = new System.Drawing.Point(175, 143);
            this.txt_kullaniciGiris.Name = "txt_kullaniciGiris";
            this.txt_kullaniciGiris.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciGiris.TabIndex = 37;
            this.txt_kullaniciGiris.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(156, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(156, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Öğrenci Otomasyon Sistemi";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(433, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_kullaniciSifre);
            this.Controls.Add(this.txt_kullaniciGiris);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "GirisForm";
            this.Text = "Kullanıcı Giriş Formu";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_kullaniciSifre;
        private System.Windows.Forms.TextBox txt_kullaniciGiris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

