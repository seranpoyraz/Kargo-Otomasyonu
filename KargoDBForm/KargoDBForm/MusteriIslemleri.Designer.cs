namespace KargoDBForm
{
    partial class MusteriIslemleri
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
            this.dgwMusteriIslemleri = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMIKaydet = new System.Windows.Forms.Button();
            this.lblMITelefon = new System.Windows.Forms.Label();
            this.lblMIAdres = new System.Windows.Forms.Label();
            this.lblMISoyad = new System.Windows.Forms.Label();
            this.lblMIAd = new System.Windows.Forms.Label();
            this.tbxMITel = new System.Windows.Forms.MaskedTextBox();
            this.tbxMIAdres = new System.Windows.Forms.TextBox();
            this.tbxMISoyad = new System.Windows.Forms.TextBox();
            this.tbxMIAd = new System.Windows.Forms.TextBox();
            this.tbxMIAra = new System.Windows.Forms.TextBox();
            this.lblMIAra = new System.Windows.Forms.Label();
            this.btnMISil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMKaydet = new System.Windows.Forms.Button();
            this.lblMTelefon = new System.Windows.Forms.Label();
            this.lblMAdres = new System.Windows.Forms.Label();
            this.lblMSoyad = new System.Windows.Forms.Label();
            this.lblMAd = new System.Windows.Forms.Label();
            this.tbxMTel = new System.Windows.Forms.MaskedTextBox();
            this.tbxMAdres = new System.Windows.Forms.TextBox();
            this.tbxMSoyad = new System.Windows.Forms.TextBox();
            this.tbxMAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriIslemleri)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMusteriIslemleri
            // 
            this.dgwMusteriIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriIslemleri.Location = new System.Drawing.Point(12, 70);
            this.dgwMusteriIslemleri.Name = "dgwMusteriIslemleri";
            this.dgwMusteriIslemleri.RowHeadersWidth = 51;
            this.dgwMusteriIslemleri.RowTemplate.Height = 24;
            this.dgwMusteriIslemleri.Size = new System.Drawing.Size(1093, 295);
            this.dgwMusteriIslemleri.TabIndex = 1;
            this.dgwMusteriIslemleri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwMusteriIslemleri_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMIKaydet);
            this.groupBox3.Controls.Add(this.lblMITelefon);
            this.groupBox3.Controls.Add(this.lblMIAdres);
            this.groupBox3.Controls.Add(this.lblMISoyad);
            this.groupBox3.Controls.Add(this.lblMIAd);
            this.groupBox3.Controls.Add(this.tbxMITel);
            this.groupBox3.Controls.Add(this.tbxMIAdres);
            this.groupBox3.Controls.Add(this.tbxMISoyad);
            this.groupBox3.Controls.Add(this.tbxMIAd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 224);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Güncelle";
            // 
            // btnMIKaydet
            // 
            this.btnMIKaydet.Location = new System.Drawing.Point(273, 176);
            this.btnMIKaydet.Name = "btnMIKaydet";
            this.btnMIKaydet.Size = new System.Drawing.Size(81, 42);
            this.btnMIKaydet.TabIndex = 12;
            this.btnMIKaydet.Text = "KAYDET";
            this.btnMIKaydet.UseVisualStyleBackColor = true;
            this.btnMIKaydet.Click += new System.EventHandler(this.BtnMIKaydet_Click);
            // 
            // lblMITelefon
            // 
            this.lblMITelefon.AutoSize = true;
            this.lblMITelefon.Location = new System.Drawing.Point(17, 176);
            this.lblMITelefon.Name = "lblMITelefon";
            this.lblMITelefon.Size = new System.Drawing.Size(61, 18);
            this.lblMITelefon.TabIndex = 10;
            this.lblMITelefon.Text = "Telefon:";
            // 
            // lblMIAdres
            // 
            this.lblMIAdres.AutoSize = true;
            this.lblMIAdres.Location = new System.Drawing.Point(17, 105);
            this.lblMIAdres.Name = "lblMIAdres";
            this.lblMIAdres.Size = new System.Drawing.Size(50, 18);
            this.lblMIAdres.TabIndex = 9;
            this.lblMIAdres.Text = "Adres:";
            // 
            // lblMISoyad
            // 
            this.lblMISoyad.AutoSize = true;
            this.lblMISoyad.Location = new System.Drawing.Point(17, 74);
            this.lblMISoyad.Name = "lblMISoyad";
            this.lblMISoyad.Size = new System.Drawing.Size(54, 18);
            this.lblMISoyad.TabIndex = 8;
            this.lblMISoyad.Text = "Soyad:";
            // 
            // lblMIAd
            // 
            this.lblMIAd.AutoSize = true;
            this.lblMIAd.Location = new System.Drawing.Point(17, 42);
            this.lblMIAd.Name = "lblMIAd";
            this.lblMIAd.Size = new System.Drawing.Size(29, 18);
            this.lblMIAd.TabIndex = 7;
            this.lblMIAd.Text = "Ad:";
            // 
            // tbxMITel
            // 
            this.tbxMITel.Location = new System.Drawing.Point(103, 176);
            this.tbxMITel.Mask = "(999) 000-0000";
            this.tbxMITel.Name = "tbxMITel";
            this.tbxMITel.Size = new System.Drawing.Size(146, 24);
            this.tbxMITel.TabIndex = 6;
            // 
            // tbxMIAdres
            // 
            this.tbxMIAdres.Location = new System.Drawing.Point(103, 105);
            this.tbxMIAdres.Multiline = true;
            this.tbxMIAdres.Name = "tbxMIAdres";
            this.tbxMIAdres.Size = new System.Drawing.Size(146, 52);
            this.tbxMIAdres.TabIndex = 5;
            // 
            // tbxMISoyad
            // 
            this.tbxMISoyad.Location = new System.Drawing.Point(103, 69);
            this.tbxMISoyad.Name = "tbxMISoyad";
            this.tbxMISoyad.Size = new System.Drawing.Size(146, 24);
            this.tbxMISoyad.TabIndex = 4;
            // 
            // tbxMIAd
            // 
            this.tbxMIAd.Location = new System.Drawing.Point(103, 37);
            this.tbxMIAd.Name = "tbxMIAd";
            this.tbxMIAd.Size = new System.Drawing.Size(146, 24);
            this.tbxMIAd.TabIndex = 3;
            this.tbxMIAd.TextChanged += new System.EventHandler(this.TbxMIAd_TextChanged);
            // 
            // tbxMIAra
            // 
            this.tbxMIAra.Location = new System.Drawing.Point(785, 27);
            this.tbxMIAra.Name = "tbxMIAra";
            this.tbxMIAra.Size = new System.Drawing.Size(320, 22);
            this.tbxMIAra.TabIndex = 14;
            this.tbxMIAra.TextChanged += new System.EventHandler(this.TbxMIAra_TextChanged);
            // 
            // lblMIAra
            // 
            this.lblMIAra.AutoSize = true;
            this.lblMIAra.Location = new System.Drawing.Point(695, 30);
            this.lblMIAra.Name = "lblMIAra";
            this.lblMIAra.Size = new System.Drawing.Size(84, 17);
            this.lblMIAra.TabIndex = 13;
            this.lblMIAra.Text = "Müşteri Ara:";
            // 
            // btnMISil
            // 
            this.btnMISil.Location = new System.Drawing.Point(977, 396);
            this.btnMISil.Name = "btnMISil";
            this.btnMISil.Size = new System.Drawing.Size(128, 48);
            this.btnMISil.TabIndex = 19;
            this.btnMISil.Text = "Seçili Kaydı Sil";
            this.btnMISil.UseVisualStyleBackColor = true;
            this.btnMISil.Click += new System.EventHandler(this.BtnMISil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMKaydet);
            this.groupBox1.Controls.Add(this.lblMTelefon);
            this.groupBox1.Controls.Add(this.lblMAdres);
            this.groupBox1.Controls.Add(this.lblMSoyad);
            this.groupBox1.Controls.Add(this.lblMAd);
            this.groupBox1.Controls.Add(this.tbxMTel);
            this.groupBox1.Controls.Add(this.tbxMAdres);
            this.groupBox1.Controls.Add(this.tbxMSoyad);
            this.groupBox1.Controls.Add(this.tbxMAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(511, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 218);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Girişi";
            // 
            // btnMKaydet
            // 
            this.btnMKaydet.Location = new System.Drawing.Point(273, 169);
            this.btnMKaydet.Name = "btnMKaydet";
            this.btnMKaydet.Size = new System.Drawing.Size(87, 43);
            this.btnMKaydet.TabIndex = 12;
            this.btnMKaydet.Text = "KAYDET";
            this.btnMKaydet.UseVisualStyleBackColor = true;
            this.btnMKaydet.Click += new System.EventHandler(this.BtnMKaydet_Click);
            // 
            // lblMTelefon
            // 
            this.lblMTelefon.AutoSize = true;
            this.lblMTelefon.Location = new System.Drawing.Point(17, 176);
            this.lblMTelefon.Name = "lblMTelefon";
            this.lblMTelefon.Size = new System.Drawing.Size(61, 18);
            this.lblMTelefon.TabIndex = 10;
            this.lblMTelefon.Text = "Telefon:";
            // 
            // lblMAdres
            // 
            this.lblMAdres.AutoSize = true;
            this.lblMAdres.Location = new System.Drawing.Point(17, 105);
            this.lblMAdres.Name = "lblMAdres";
            this.lblMAdres.Size = new System.Drawing.Size(50, 18);
            this.lblMAdres.TabIndex = 9;
            this.lblMAdres.Text = "Adres:";
            // 
            // lblMSoyad
            // 
            this.lblMSoyad.AutoSize = true;
            this.lblMSoyad.Location = new System.Drawing.Point(17, 74);
            this.lblMSoyad.Name = "lblMSoyad";
            this.lblMSoyad.Size = new System.Drawing.Size(54, 18);
            this.lblMSoyad.TabIndex = 8;
            this.lblMSoyad.Text = "Soyad:";
            // 
            // lblMAd
            // 
            this.lblMAd.AutoSize = true;
            this.lblMAd.Location = new System.Drawing.Point(17, 42);
            this.lblMAd.Name = "lblMAd";
            this.lblMAd.Size = new System.Drawing.Size(29, 18);
            this.lblMAd.TabIndex = 7;
            this.lblMAd.Text = "Ad:";
            // 
            // tbxMTel
            // 
            this.tbxMTel.Location = new System.Drawing.Point(103, 176);
            this.tbxMTel.Mask = "(999) 000-0000";
            this.tbxMTel.Name = "tbxMTel";
            this.tbxMTel.Size = new System.Drawing.Size(146, 24);
            this.tbxMTel.TabIndex = 6;
            // 
            // tbxMAdres
            // 
            this.tbxMAdres.Location = new System.Drawing.Point(103, 105);
            this.tbxMAdres.Multiline = true;
            this.tbxMAdres.Name = "tbxMAdres";
            this.tbxMAdres.Size = new System.Drawing.Size(146, 52);
            this.tbxMAdres.TabIndex = 5;
            // 
            // tbxMSoyad
            // 
            this.tbxMSoyad.Location = new System.Drawing.Point(103, 69);
            this.tbxMSoyad.Name = "tbxMSoyad";
            this.tbxMSoyad.Size = new System.Drawing.Size(146, 24);
            this.tbxMSoyad.TabIndex = 4;
            // 
            // tbxMAd
            // 
            this.tbxMAd.Location = new System.Drawing.Point(103, 37);
            this.tbxMAd.Name = "tbxMAd";
            this.tbxMAd.Size = new System.Drawing.Size(146, 24);
            this.tbxMAd.TabIndex = 3;
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMISil);
            this.Controls.Add(this.tbxMIAra);
            this.Controls.Add(this.lblMIAra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgwMusteriIslemleri);
            this.Name = "MusteriIslemleri";
            this.Text = "Kargo Otomasyonu v1.0 | Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriIslemleri)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteriIslemleri;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMIKaydet;
        private System.Windows.Forms.Label lblMITelefon;
        private System.Windows.Forms.Label lblMIAdres;
        private System.Windows.Forms.Label lblMISoyad;
        private System.Windows.Forms.Label lblMIAd;
        private System.Windows.Forms.MaskedTextBox tbxMITel;
        private System.Windows.Forms.TextBox tbxMIAdres;
        private System.Windows.Forms.TextBox tbxMISoyad;
        private System.Windows.Forms.TextBox tbxMIAd;
        private System.Windows.Forms.TextBox tbxMIAra;
        private System.Windows.Forms.Label lblMIAra;
        private System.Windows.Forms.Button btnMISil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMKaydet;
        private System.Windows.Forms.Label lblMTelefon;
        private System.Windows.Forms.Label lblMAdres;
        private System.Windows.Forms.Label lblMSoyad;
        private System.Windows.Forms.Label lblMAd;
        private System.Windows.Forms.MaskedTextBox tbxMTel;
        private System.Windows.Forms.TextBox tbxMAdres;
        private System.Windows.Forms.TextBox tbxMSoyad;
        private System.Windows.Forms.TextBox tbxMAd;
    }
}