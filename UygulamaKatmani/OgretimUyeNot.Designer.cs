namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    partial class OgretimUyeNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretimUyeNot));
            this.btn_excele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_excelden = new System.Windows.Forms.Button();
            this.txt_dosya = new System.Windows.Forms.TextBox();
            this.cmb_sayfa = new System.Windows.Forms.ComboBox();
            this.btn_veritabaniAktar = new System.Windows.Forms.Button();
            this.adgw_excel = new ADGV.AdvancedDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_ders = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgw_excel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_excele
            // 
            this.btn_excele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_excele.Image = ((System.Drawing.Image)(resources.GetObject("btn_excele.Image")));
            this.btn_excele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excele.Location = new System.Drawing.Point(622, 109);
            this.btn_excele.Name = "btn_excele";
            this.btn_excele.Size = new System.Drawing.Size(166, 39);
            this.btn_excele.TabIndex = 84;
            this.btn_excele.Text = "     EXCEL\'E AKTAR";
            this.btn_excele.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_veritabaniAktar);
            this.groupBox1.Controls.Add(this.cmb_sayfa);
            this.groupBox1.Controls.Add(this.txt_dosya);
            this.groupBox1.Controls.Add(this.btn_excelden);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 186);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Derse Not Ekleme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_excelden
            // 
            this.btn_excelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_excelden.Image = ((System.Drawing.Image)(resources.GetObject("btn_excelden.Image")));
            this.btn_excelden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excelden.Location = new System.Drawing.Point(6, 19);
            this.btn_excelden.Name = "btn_excelden";
            this.btn_excelden.Size = new System.Drawing.Size(159, 26);
            this.btn_excelden.TabIndex = 85;
            this.btn_excelden.Text = "     Excel\'den aktar";
            this.btn_excelden.UseVisualStyleBackColor = true;
            // 
            // txt_dosya
            // 
            this.txt_dosya.Location = new System.Drawing.Point(201, 23);
            this.txt_dosya.Name = "txt_dosya";
            this.txt_dosya.ReadOnly = true;
            this.txt_dosya.Size = new System.Drawing.Size(194, 20);
            this.txt_dosya.TabIndex = 86;
            // 
            // cmb_sayfa
            // 
            this.cmb_sayfa.FormattingEnabled = true;
            this.cmb_sayfa.Location = new System.Drawing.Point(201, 50);
            this.cmb_sayfa.Name = "cmb_sayfa";
            this.cmb_sayfa.Size = new System.Drawing.Size(194, 21);
            this.cmb_sayfa.TabIndex = 87;
            // 
            // btn_veritabaniAktar
            // 
            this.btn_veritabaniAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_veritabaniAktar.Image = ((System.Drawing.Image)(resources.GetObject("btn_veritabaniAktar.Image")));
            this.btn_veritabaniAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_veritabaniAktar.Location = new System.Drawing.Point(236, 122);
            this.btn_veritabaniAktar.Name = "btn_veritabaniAktar";
            this.btn_veritabaniAktar.Size = new System.Drawing.Size(159, 45);
            this.btn_veritabaniAktar.TabIndex = 88;
            this.btn_veritabaniAktar.Text = "       Veritabanı\'na aktar";
            this.btn_veritabaniAktar.UseVisualStyleBackColor = true;
            // 
            // adgw_excel
            // 
            this.adgw_excel.AutoGenerateContextFilters = true;
            this.adgw_excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgw_excel.DateWithTime = false;
            this.adgw_excel.Location = new System.Drawing.Point(12, 288);
            this.adgw_excel.Name = "adgw_excel";
            this.adgw_excel.Size = new System.Drawing.Size(776, 150);
            this.adgw_excel.TabIndex = 0;
            this.adgw_excel.TimeFilter = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_ders);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 78);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Derse Not Ekleme";
            // 
            // cmb_ders
            // 
            this.cmb_ders.FormattingEnabled = true;
            this.cmb_ders.Location = new System.Drawing.Point(6, 19);
            this.cmb_ders.Name = "cmb_ders";
            this.cmb_ders.Size = new System.Drawing.Size(194, 21);
            this.cmb_ders.TabIndex = 87;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(236, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 26);
            this.button2.TabIndex = 85;
            this.button2.Text = "     Excel İndir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // OgretimUyeNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_excele);
            this.Controls.Add(this.adgw_excel);
            this.Name = "OgretimUyeNot";
            this.Text = "Öğretim Üyesi Not Giriş Formu";
            this.Load += new System.EventHandler(this.OgretimUyeNot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgw_excel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_excele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_excelden;
        private System.Windows.Forms.Button btn_veritabaniAktar;
        private System.Windows.Forms.ComboBox cmb_sayfa;
        private System.Windows.Forms.TextBox txt_dosya;
        private ADGV.AdvancedDataGridView adgw_excel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_ders;
        private System.Windows.Forms.Button button2;
    }
}