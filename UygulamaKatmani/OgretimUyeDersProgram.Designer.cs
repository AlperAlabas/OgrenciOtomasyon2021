namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    partial class OgretimUyeDersProgram
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
            this.cmb_ogrUyeBolumProgram = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.cmb_ogrUyeFakulteProgram = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.ogrUyeDGVprogram = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ogrUyeDGVprogram)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_ogrUyeBolumProgram
            // 
            this.cmb_ogrUyeBolumProgram.FormattingEnabled = true;
            this.cmb_ogrUyeBolumProgram.Location = new System.Drawing.Point(289, 15);
            this.cmb_ogrUyeBolumProgram.Name = "cmb_ogrUyeBolumProgram";
            this.cmb_ogrUyeBolumProgram.Size = new System.Drawing.Size(101, 21);
            this.cmb_ogrUyeBolumProgram.TabIndex = 29;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(271, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(11, 13);
            this.label40.TabIndex = 28;
            this.label40.Text = ":";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(223, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 13);
            this.label41.TabIndex = 27;
            this.label41.Text = "Bölüm";
            // 
            // cmb_ogrUyeFakulteProgram
            // 
            this.cmb_ogrUyeFakulteProgram.FormattingEnabled = true;
            this.cmb_ogrUyeFakulteProgram.Location = new System.Drawing.Point(84, 12);
            this.cmb_ogrUyeFakulteProgram.Name = "cmb_ogrUyeFakulteProgram";
            this.cmb_ogrUyeFakulteProgram.Size = new System.Drawing.Size(101, 21);
            this.cmb_ogrUyeFakulteProgram.TabIndex = 26;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.Location = new System.Drawing.Point(69, 15);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(11, 13);
            this.label42.TabIndex = 25;
            this.label42.Text = ":";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label43.Location = new System.Drawing.Point(16, 15);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(49, 13);
            this.label43.TabIndex = 24;
            this.label43.Text = "Fakülte";
            // 
            // ogrUyeDGVprogram
            // 
            this.ogrUyeDGVprogram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrUyeDGVprogram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrUyeDGVprogram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ogrUyeDGVprogram.Location = new System.Drawing.Point(13, 53);
            this.ogrUyeDGVprogram.Name = "ogrUyeDGVprogram";
            this.ogrUyeDGVprogram.Size = new System.Drawing.Size(774, 437);
            this.ogrUyeDGVprogram.TabIndex = 23;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Saatler";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pazartesi";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Salı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Çarşamba";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Perşembe";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cuma";
            this.Column5.Name = "Column5";
            // 
            // OgretimUyeDersProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.cmb_ogrUyeBolumProgram);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.cmb_ogrUyeFakulteProgram);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.ogrUyeDGVprogram);
            this.Name = "OgretimUyeDersProgram";
            this.Text = "OgretimUyeDersProgram";
            ((System.ComponentModel.ISupportInitialize)(this.ogrUyeDGVprogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ogrUyeBolumProgram;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cmb_ogrUyeFakulteProgram;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.DataGridView ogrUyeDGVprogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}