namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    partial class OgretimUyeDanismanlikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretimUyeDanismanlikForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_danismanOgrenciEkle = new System.Windows.Forms.Button();
            this.btn_danismanOgrenciSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danıismanlikADGV = new ADGV.AdvancedDataGridView();
            this.btn_ogrUyeAra = new System.Windows.Forms.Button();
            this.cmb_ogrUyeAranacakKriter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ogrUyeAranacakMetin = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.adgw_randevu = new ADGV.AdvancedDataGridView();
            this.btn_ranAdd = new System.Windows.Forms.Button();
            this.btn_ranDelete = new System.Windows.Forms.Button();
            this.dt_randevu = new System.Windows.Forms.DateTimePicker();
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_ranSaat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ranOgrId = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danıismanlikADGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgw_randevu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danışmanlık İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_danismanOgrenciEkle
            // 
            this.btn_danismanOgrenciEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_danismanOgrenciEkle.BackgroundImage")));
            this.btn_danismanOgrenciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_danismanOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_danismanOgrenciEkle.Location = new System.Drawing.Point(399, 334);
            this.btn_danismanOgrenciEkle.Name = "btn_danismanOgrenciEkle";
            this.btn_danismanOgrenciEkle.Size = new System.Drawing.Size(122, 40);
            this.btn_danismanOgrenciEkle.TabIndex = 109;
            this.btn_danismanOgrenciEkle.Text = "       Kayıt Ekleme";
            this.btn_danismanOgrenciEkle.UseVisualStyleBackColor = true;
            // 
            // btn_danismanOgrenciSil
            // 
            this.btn_danismanOgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_danismanOgrenciSil.Image = ((System.Drawing.Image)(resources.GetObject("btn_danismanOgrenciSil.Image")));
            this.btn_danismanOgrenciSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danismanOgrenciSil.Location = new System.Drawing.Point(276, 334);
            this.btn_danismanOgrenciSil.Name = "btn_danismanOgrenciSil";
            this.btn_danismanOgrenciSil.Size = new System.Drawing.Size(105, 40);
            this.btn_danismanOgrenciSil.TabIndex = 108;
            this.btn_danismanOgrenciSil.Text = "       Öğrenci Sil";
            this.btn_danismanOgrenciSil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_danismanOgrenciEkle);
            this.groupBox1.Controls.Add(this.danıismanlikADGV);
            this.groupBox1.Controls.Add(this.btn_danismanOgrenciSil);
            this.groupBox1.Controls.Add(this.btn_ogrUyeAra);
            this.groupBox1.Controls.Add(this.cmb_ogrUyeAranacakKriter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ogrUyeAranacakMetin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 380);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ara";
            // 
            // danıismanlikADGV
            // 
            this.danıismanlikADGV.AutoGenerateContextFilters = true;
            this.danıismanlikADGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danıismanlikADGV.DateWithTime = false;
            this.danıismanlikADGV.Location = new System.Drawing.Point(9, 101);
            this.danıismanlikADGV.Name = "danıismanlikADGV";
            this.danıismanlikADGV.Size = new System.Drawing.Size(512, 227);
            this.danıismanlikADGV.TabIndex = 99;
            this.danıismanlikADGV.TimeFilter = false;
            // 
            // btn_ogrUyeAra
            // 
            this.btn_ogrUyeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btn_ogrUyeAra.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrUyeAra.Image")));
            this.btn_ogrUyeAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ogrUyeAra.Location = new System.Drawing.Point(227, 56);
            this.btn_ogrUyeAra.Name = "btn_ogrUyeAra";
            this.btn_ogrUyeAra.Size = new System.Drawing.Size(37, 29);
            this.btn_ogrUyeAra.TabIndex = 98;
            this.btn_ogrUyeAra.UseVisualStyleBackColor = true;
            // 
            // cmb_ogrUyeAranacakKriter
            // 
            this.cmb_ogrUyeAranacakKriter.FormattingEnabled = true;
            this.cmb_ogrUyeAranacakKriter.Location = new System.Drawing.Point(121, 32);
            this.cmb_ogrUyeAranacakKriter.Name = "cmb_ogrUyeAranacakKriter";
            this.cmb_ogrUyeAranacakKriter.Size = new System.Drawing.Size(100, 21);
            this.cmb_ogrUyeAranacakKriter.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aranacak Metin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranacak Kriter";
            // 
            // txt_ogrUyeAranacakMetin
            // 
            this.txt_ogrUyeAranacakMetin.Location = new System.Drawing.Point(121, 60);
            this.txt_ogrUyeAranacakMetin.Name = "txt_ogrUyeAranacakMetin";
            this.txt_ogrUyeAranacakMetin.Size = new System.Drawing.Size(100, 20);
            this.txt_ogrUyeAranacakMetin.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.adgw_randevu);
            this.tabPage2.Controls.Add(this.btn_ranAdd);
            this.tabPage2.Controls.Add(this.btn_ranDelete);
            this.tabPage2.Controls.Add(this.dt_randevu);
            this.tabPage2.Controls.Add(this.txt_baslik);
            this.tabPage2.Controls.Add(this.txt_aciklama);
            this.tabPage2.Controls.Add(this.txt_ranSaat);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_ranOgrId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Randevu Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 119;
            this.label15.Text = "Öğrenci ID        :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 118;
            this.label14.Text = "Randevu Saati :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 117;
            this.label13.Text = "Randevu Tarihi :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "Açıklama           :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 115;
            this.label11.Text = " Başlık              :";
            // 
            // adgw_randevu
            // 
            this.adgw_randevu.AutoGenerateContextFilters = true;
            this.adgw_randevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgw_randevu.DateWithTime = false;
            this.adgw_randevu.Location = new System.Drawing.Point(9, 173);
            this.adgw_randevu.Name = "adgw_randevu";
            this.adgw_randevu.Size = new System.Drawing.Size(516, 151);
            this.adgw_randevu.TabIndex = 114;
            this.adgw_randevu.TimeFilter = false;
            // 
            // btn_ranAdd
            // 
            this.btn_ranAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ranAdd.BackgroundImage")));
            this.btn_ranAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ranAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ranAdd.Location = new System.Drawing.Point(372, 343);
            this.btn_ranAdd.Name = "btn_ranAdd";
            this.btn_ranAdd.Size = new System.Drawing.Size(153, 40);
            this.btn_ranAdd.TabIndex = 113;
            this.btn_ranAdd.Text = "       Randevu Ekleme";
            this.btn_ranAdd.UseVisualStyleBackColor = true;
            // 
            // btn_ranDelete
            // 
            this.btn_ranDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ranDelete.Image = ((System.Drawing.Image)(resources.GetObject("btn_ranDelete.Image")));
            this.btn_ranDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ranDelete.Location = new System.Drawing.Point(231, 343);
            this.btn_ranDelete.Name = "btn_ranDelete";
            this.btn_ranDelete.Size = new System.Drawing.Size(135, 40);
            this.btn_ranDelete.TabIndex = 112;
            this.btn_ranDelete.Text = "       Randevu Sil";
            this.btn_ranDelete.UseVisualStyleBackColor = true;
            // 
            // dt_randevu
            // 
            this.dt_randevu.Location = new System.Drawing.Point(121, 73);
            this.dt_randevu.Name = "dt_randevu";
            this.dt_randevu.Size = new System.Drawing.Size(229, 20);
            this.dt_randevu.TabIndex = 111;
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(121, 22);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(229, 20);
            this.txt_baslik.TabIndex = 110;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(121, 47);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(229, 20);
            this.txt_aciklama.TabIndex = 109;
            // 
            // txt_ranSaat
            // 
            this.txt_ranSaat.Location = new System.Drawing.Point(121, 97);
            this.txt_ranSaat.Name = "txt_ranSaat";
            this.txt_ranSaat.Size = new System.Drawing.Size(229, 20);
            this.txt_ranSaat.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 100;
            // 
            // txt_ranOgrId
            // 
            this.txt_ranOgrId.Location = new System.Drawing.Point(121, 129);
            this.txt_ranOgrId.Name = "txt_ranOgrId";
            this.txt_ranOgrId.Size = new System.Drawing.Size(115, 20);
            this.txt_ranOgrId.TabIndex = 99;
            // 
            // OgretimUyeDanismanlikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 430);
            this.Controls.Add(this.tabControl1);
            this.Name = "OgretimUyeDanismanlikForm";
            this.Text = "Ogretim Uyesi Danismanlik Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danıismanlikADGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgw_randevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ogrUyeAranacakMetin;
        private System.Windows.Forms.ComboBox cmb_ogrUyeAranacakKriter;
        private System.Windows.Forms.Button btn_ogrUyeAra;
        private ADGV.AdvancedDataGridView danıismanlikADGV;
        private System.Windows.Forms.Button btn_danismanOgrenciEkle;
        private System.Windows.Forms.Button btn_danismanOgrenciSil;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private ADGV.AdvancedDataGridView adgw_randevu;
        private System.Windows.Forms.Button btn_ranAdd;
        private System.Windows.Forms.Button btn_ranDelete;
        private System.Windows.Forms.DateTimePicker dt_randevu;
        private System.Windows.Forms.TextBox txt_baslik;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_ranSaat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ranOgrId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}