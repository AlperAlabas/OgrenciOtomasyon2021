namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    partial class YoneticiForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_idari = new System.Windows.Forms.Button();
            this.btn_ogrUyeDanismanlik = new System.Windows.Forms.Button();
            this.btn_kullaniciIslemleri = new System.Windows.Forms.Button();
            this.btn_dersOlusturma = new System.Windows.Forms.Button();
            this.btn_personelBilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(695, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 105);
            this.button1.TabIndex = 16;
            this.button1.Text = "Personel Bilgileri";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_idari
            // 
            this.btn_idari.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_idari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_idari.Location = new System.Drawing.Point(44, 191);
            this.btn_idari.Name = "btn_idari";
            this.btn_idari.Size = new System.Drawing.Size(176, 105);
            this.btn_idari.TabIndex = 15;
            this.btn_idari.Text = "İdari İşlemler";
            this.btn_idari.UseVisualStyleBackColor = false;
            // 
            // btn_ogrUyeDanismanlik
            // 
            this.btn_ogrUyeDanismanlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ogrUyeDanismanlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrUyeDanismanlik.Location = new System.Drawing.Point(668, 195);
            this.btn_ogrUyeDanismanlik.Name = "btn_ogrUyeDanismanlik";
            this.btn_ogrUyeDanismanlik.Size = new System.Drawing.Size(176, 105);
            this.btn_ogrUyeDanismanlik.TabIndex = 14;
            this.btn_ogrUyeDanismanlik.Text = "Danışmanlık";
            this.btn_ogrUyeDanismanlik.UseVisualStyleBackColor = false;
            // 
            // btn_kullaniciIslemleri
            // 
            this.btn_kullaniciIslemleri.BackColor = System.Drawing.Color.Gold;
            this.btn_kullaniciIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullaniciIslemleri.Location = new System.Drawing.Point(261, 191);
            this.btn_kullaniciIslemleri.Name = "btn_kullaniciIslemleri";
            this.btn_kullaniciIslemleri.Size = new System.Drawing.Size(176, 105);
            this.btn_kullaniciIslemleri.TabIndex = 13;
            this.btn_kullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.btn_kullaniciIslemleri.UseVisualStyleBackColor = false;
            this.btn_kullaniciIslemleri.Click += new System.EventHandler(this.btn_kullaniciIslemleri_Click);
            // 
            // btn_dersOlusturma
            // 
            this.btn_dersOlusturma.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_dersOlusturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dersOlusturma.Location = new System.Drawing.Point(261, 34);
            this.btn_dersOlusturma.Name = "btn_dersOlusturma";
            this.btn_dersOlusturma.Size = new System.Drawing.Size(176, 105);
            this.btn_dersOlusturma.TabIndex = 12;
            this.btn_dersOlusturma.Text = "Ders İşlemleri";
            this.btn_dersOlusturma.UseVisualStyleBackColor = false;
            this.btn_dersOlusturma.Click += new System.EventHandler(this.btn_dersOlusturma_Click);
            // 
            // btn_personelBilgi
            // 
            this.btn_personelBilgi.BackColor = System.Drawing.Color.Tomato;
            this.btn_personelBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personelBilgi.Location = new System.Drawing.Point(44, 34);
            this.btn_personelBilgi.Name = "btn_personelBilgi";
            this.btn_personelBilgi.Size = new System.Drawing.Size(176, 105);
            this.btn_personelBilgi.TabIndex = 17;
            this.btn_personelBilgi.Text = "Personel Bilgileri";
            this.btn_personelBilgi.UseVisualStyleBackColor = false;
            this.btn_personelBilgi.Click += new System.EventHandler(this.btn_personelBilgi_Click);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 339);
            this.Controls.Add(this.btn_personelBilgi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_idari);
            this.Controls.Add(this.btn_ogrUyeDanismanlik);
            this.Controls.Add(this.btn_kullaniciIslemleri);
            this.Controls.Add(this.btn_dersOlusturma);
            this.Name = "YoneticiForm";
            this.Text = "YoneticiForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YoneticiForm_FormClosed);
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_idari;
        private System.Windows.Forms.Button btn_ogrUyeDanismanlik;
        private System.Windows.Forms.Button btn_kullaniciIslemleri;
        private System.Windows.Forms.Button btn_dersOlusturma;
        private System.Windows.Forms.Button btn_personelBilgi;
    }
}