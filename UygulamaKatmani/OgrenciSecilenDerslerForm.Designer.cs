namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    partial class OgrenciSecilenDerslerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciSecilenDerslerForm));
            this.btn_ogrenciSecilenDersExcelAktar = new System.Windows.Forms.Button();
            this.ogrenciADGV = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciADGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ogrenciSecilenDersExcelAktar
            // 
            this.btn_ogrenciSecilenDersExcelAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ogrenciSecilenDersExcelAktar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrenciSecilenDersExcelAktar.Image")));
            this.btn_ogrenciSecilenDersExcelAktar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ogrenciSecilenDersExcelAktar.Location = new System.Drawing.Point(579, 326);
            this.btn_ogrenciSecilenDersExcelAktar.Name = "btn_ogrenciSecilenDersExcelAktar";
            this.btn_ogrenciSecilenDersExcelAktar.Size = new System.Drawing.Size(166, 39);
            this.btn_ogrenciSecilenDersExcelAktar.TabIndex = 83;
            this.btn_ogrenciSecilenDersExcelAktar.Text = "     EXCEL\'E AKTAR";
            this.btn_ogrenciSecilenDersExcelAktar.UseVisualStyleBackColor = true;
            // 
            // ogrenciADGV
            // 
            this.ogrenciADGV.AutoGenerateContextFilters = true;
            this.ogrenciADGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciADGV.DateWithTime = false;
            this.ogrenciADGV.Location = new System.Drawing.Point(12, 12);
            this.ogrenciADGV.Name = "ogrenciADGV";
            this.ogrenciADGV.Size = new System.Drawing.Size(733, 297);
            this.ogrenciADGV.TabIndex = 82;
            this.ogrenciADGV.TimeFilter = false;
            // 
            // OgrenciSecilenDerslerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 378);
            this.Controls.Add(this.btn_ogrenciSecilenDersExcelAktar);
            this.Controls.Add(this.ogrenciADGV);
            this.Name = "OgrenciSecilenDerslerForm";
            this.Text = "Ogrenci Secilen Dersler Form";
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciADGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrenciSecilenDersExcelAktar;
        private ADGV.AdvancedDataGridView ogrenciADGV;
    }
}