namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    partial class OgretimUyeSecilenDerslerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretimUyeSecilenDerslerForm));
            this.btn_ogrUyeSecilenDersExcelAktar = new System.Windows.Forms.Button();
            this.ogrUyeADGV = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ogrUyeADGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ogrUyeSecilenDersExcelAktar
            // 
            this.btn_ogrUyeSecilenDersExcelAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ogrUyeSecilenDersExcelAktar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrUyeSecilenDersExcelAktar.Image")));
            this.btn_ogrUyeSecilenDersExcelAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ogrUyeSecilenDersExcelAktar.Location = new System.Drawing.Point(580, 327);
            this.btn_ogrUyeSecilenDersExcelAktar.Name = "btn_ogrUyeSecilenDersExcelAktar";
            this.btn_ogrUyeSecilenDersExcelAktar.Size = new System.Drawing.Size(166, 39);
            this.btn_ogrUyeSecilenDersExcelAktar.TabIndex = 85;
            this.btn_ogrUyeSecilenDersExcelAktar.Text = "     EXCEL\'E AKTAR";
            this.btn_ogrUyeSecilenDersExcelAktar.UseVisualStyleBackColor = true;
            // 
            // ogrUyeADGV
            // 
            this.ogrUyeADGV.AutoGenerateContextFilters = true;
            this.ogrUyeADGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrUyeADGV.DateWithTime = false;
            this.ogrUyeADGV.Location = new System.Drawing.Point(13, 13);
            this.ogrUyeADGV.Name = "ogrUyeADGV";
            this.ogrUyeADGV.Size = new System.Drawing.Size(733, 297);
            this.ogrUyeADGV.TabIndex = 84;
            this.ogrUyeADGV.TimeFilter = false;
            // 
            // OgretimUyeSecilenDerslerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 378);
            this.Controls.Add(this.btn_ogrUyeSecilenDersExcelAktar);
            this.Controls.Add(this.ogrUyeADGV);
            this.Name = "OgretimUyeSecilenDerslerForm";
            this.Text = "Ogretim Uye Secilen Dersler Form";
            ((System.ComponentModel.ISupportInitialize)(this.ogrUyeADGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrUyeSecilenDersExcelAktar;
        private ADGV.AdvancedDataGridView ogrUyeADGV;
    }
}