namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    partial class OgrenciForm
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
            this.btn_ogrenciBilgi = new System.Windows.Forms.Button();
            this.btn_ogrenciSecilenDers = new System.Windows.Forms.Button();
            this.btn_ogrenciDerseYazilma = new System.Windows.Forms.Button();
            this.btn_ogrenciDersProgram = new System.Windows.Forms.Button();
            this.btn_ogrenciTranskript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ogrenciBilgi
            // 
            this.btn_ogrenciBilgi.BackColor = System.Drawing.Color.Tomato;
            this.btn_ogrenciBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciBilgi.Location = new System.Drawing.Point(73, 42);
            this.btn_ogrenciBilgi.Name = "btn_ogrenciBilgi";
            this.btn_ogrenciBilgi.Size = new System.Drawing.Size(176, 105);
            this.btn_ogrenciBilgi.TabIndex = 0;
            this.btn_ogrenciBilgi.Text = "Öğrenci Bilgileri";
            this.btn_ogrenciBilgi.UseVisualStyleBackColor = false;
            this.btn_ogrenciBilgi.Click += new System.EventHandler(this.btn_ogrenciBilgi_Click);
            // 
            // btn_ogrenciSecilenDers
            // 
            this.btn_ogrenciSecilenDers.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ogrenciSecilenDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciSecilenDers.Location = new System.Drawing.Point(293, 42);
            this.btn_ogrenciSecilenDers.Name = "btn_ogrenciSecilenDers";
            this.btn_ogrenciSecilenDers.Size = new System.Drawing.Size(176, 105);
            this.btn_ogrenciSecilenDers.TabIndex = 1;
            this.btn_ogrenciSecilenDers.Text = "Seçilen Dersler";
            this.btn_ogrenciSecilenDers.UseVisualStyleBackColor = false;
            this.btn_ogrenciSecilenDers.Click += new System.EventHandler(this.btn_ogrenciSecilenDers_Click);
            // 
            // btn_ogrenciDerseYazilma
            // 
            this.btn_ogrenciDerseYazilma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ogrenciDerseYazilma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciDerseYazilma.Location = new System.Drawing.Point(73, 179);
            this.btn_ogrenciDerseYazilma.Name = "btn_ogrenciDerseYazilma";
            this.btn_ogrenciDerseYazilma.Size = new System.Drawing.Size(176, 105);
            this.btn_ogrenciDerseYazilma.TabIndex = 2;
            this.btn_ogrenciDerseYazilma.Text = "Derse Yazılma";
            this.btn_ogrenciDerseYazilma.UseVisualStyleBackColor = false;
            this.btn_ogrenciDerseYazilma.Click += new System.EventHandler(this.btn_ogrenciDerseYazilma_Click);
            // 
            // btn_ogrenciDersProgram
            // 
            this.btn_ogrenciDersProgram.BackColor = System.Drawing.Color.Gold;
            this.btn_ogrenciDersProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciDersProgram.Location = new System.Drawing.Point(293, 179);
            this.btn_ogrenciDersProgram.Name = "btn_ogrenciDersProgram";
            this.btn_ogrenciDersProgram.Size = new System.Drawing.Size(176, 105);
            this.btn_ogrenciDersProgram.TabIndex = 3;
            this.btn_ogrenciDersProgram.Text = "Ders Programı";
            this.btn_ogrenciDersProgram.UseVisualStyleBackColor = false;
            this.btn_ogrenciDersProgram.Click += new System.EventHandler(this.btn_ogrenciDersProgram_Click);
            // 
            // btn_ogrenciTranskript
            // 
            this.btn_ogrenciTranskript.BackColor = System.Drawing.Color.Khaki;
            this.btn_ogrenciTranskript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciTranskript.Location = new System.Drawing.Point(512, 42);
            this.btn_ogrenciTranskript.Name = "btn_ogrenciTranskript";
            this.btn_ogrenciTranskript.Size = new System.Drawing.Size(176, 105);
            this.btn_ogrenciTranskript.TabIndex = 4;
            this.btn_ogrenciTranskript.Text = "Transkript";
            this.btn_ogrenciTranskript.UseVisualStyleBackColor = false;
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 333);
            this.Controls.Add(this.btn_ogrenciTranskript);
            this.Controls.Add(this.btn_ogrenciDersProgram);
            this.Controls.Add(this.btn_ogrenciDerseYazilma);
            this.Controls.Add(this.btn_ogrenciSecilenDers);
            this.Controls.Add(this.btn_ogrenciBilgi);
            this.Name = "OgrenciForm";
            this.Text = "Ogrenci Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgrenciForm_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrenciBilgi;
        private System.Windows.Forms.Button btn_ogrenciSecilenDers;
        private System.Windows.Forms.Button btn_ogrenciDerseYazilma;
        private System.Windows.Forms.Button btn_ogrenciDersProgram;
        private System.Windows.Forms.Button btn_ogrenciTranskript;
    }
}