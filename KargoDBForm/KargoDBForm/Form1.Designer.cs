namespace KargoDBForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.lblMusteriAra = new System.Windows.Forms.Label();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.cbxKargoTurleri = new System.Windows.Forms.ComboBox();
            this.tbxGonderen = new System.Windows.Forms.TextBox();
            this.tbxAlici = new System.Windows.Forms.TextBox();
            this.tbxAgirlik = new System.Windows.Forms.TextBox();
            this.tbxDesi = new System.Windows.Forms.TextBox();
            this.lblGonderen = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblDesi = new System.Windows.Forms.Label();
            this.lblAgirlik = new System.Windows.Forms.Label();
            this.lblKargoTuru = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.tbxUcret = new System.Windows.Forms.TextBox();
            this.btnGonderici = new System.Windows.Forms.Button();
            this.btnAlici = new System.Windows.Forms.Button();
            this.lblKargoTuruID = new System.Windows.Forms.Label();
            this.lblGondericiID = new System.Windows.Forms.Label();
            this.lblAliciID = new System.Windows.Forms.Label();
            this.rdbAlici = new System.Windows.Forms.RadioButton();
            this.rbcGonderici = new System.Windows.Forms.RadioButton();
            this.btnYeniKargo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnMusteriISlemleri = new System.Windows.Forms.Button();
            this.ttMusteriAra = new System.Windows.Forms.ToolTip(this.components);
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.Location = new System.Drawing.Point(11, 89);
            this.dgwMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.RowHeadersWidth = 51;
            this.dgwMusteriler.RowTemplate.Height = 24;
            this.dgwMusteriler.Size = new System.Drawing.Size(502, 182);
            this.dgwMusteriler.TabIndex = 0;
            this.dgwMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwMusteriler_CellContentClick);
            // 
            // lblMusteriAra
            // 
            this.lblMusteriAra.AutoSize = true;
            this.lblMusteriAra.Location = new System.Drawing.Point(11, 56);
            this.lblMusteriAra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriAra.Name = "lblMusteriAra";
            this.lblMusteriAra.Size = new System.Drawing.Size(63, 13);
            this.lblMusteriAra.TabIndex = 1;
            this.lblMusteriAra.Text = "Müşteri Ara:";
            // 
            // tbxAra
            // 
            this.tbxAra.Location = new System.Drawing.Point(79, 54);
            this.tbxAra.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(122, 20);
            this.tbxAra.TabIndex = 2;
            this.tbxAra.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // cbxKargoTurleri
            // 
            this.cbxKargoTurleri.FormattingEnabled = true;
            this.cbxKargoTurleri.Location = new System.Drawing.Point(89, 104);
            this.cbxKargoTurleri.Margin = new System.Windows.Forms.Padding(2);
            this.cbxKargoTurleri.Name = "cbxKargoTurleri";
            this.cbxKargoTurleri.Size = new System.Drawing.Size(154, 23);
            this.cbxKargoTurleri.TabIndex = 12;
            this.cbxKargoTurleri.Text = "Kargo Türleri";
            this.cbxKargoTurleri.SelectedIndexChanged += new System.EventHandler(this.CbxKargoTurleri_SelectedIndexChanged);
            // 
            // tbxGonderen
            // 
            this.tbxGonderen.Location = new System.Drawing.Point(89, 33);
            this.tbxGonderen.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGonderen.Name = "tbxGonderen";
            this.tbxGonderen.Size = new System.Drawing.Size(154, 21);
            this.tbxGonderen.TabIndex = 14;
            // 
            // tbxAlici
            // 
            this.tbxAlici.Location = new System.Drawing.Point(89, 70);
            this.tbxAlici.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAlici.Name = "tbxAlici";
            this.tbxAlici.Size = new System.Drawing.Size(154, 21);
            this.tbxAlici.TabIndex = 15;
            // 
            // tbxAgirlik
            // 
            this.tbxAgirlik.Location = new System.Drawing.Point(89, 180);
            this.tbxAgirlik.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAgirlik.Name = "tbxAgirlik";
            this.tbxAgirlik.Size = new System.Drawing.Size(154, 21);
            this.tbxAgirlik.TabIndex = 19;
            this.tbxAgirlik.TextChanged += new System.EventHandler(this.TbxAgirlik_TextChanged);
            // 
            // tbxDesi
            // 
            this.tbxDesi.Location = new System.Drawing.Point(89, 146);
            this.tbxDesi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDesi.Name = "tbxDesi";
            this.tbxDesi.Size = new System.Drawing.Size(154, 21);
            this.tbxDesi.TabIndex = 20;
            this.tbxDesi.TextChanged += new System.EventHandler(this.TbxDesi_TextChanged);
            // 
            // lblGonderen
            // 
            this.lblGonderen.AutoSize = true;
            this.lblGonderen.Location = new System.Drawing.Point(6, 33);
            this.lblGonderen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGonderen.Name = "lblGonderen";
            this.lblGonderen.Size = new System.Drawing.Size(65, 15);
            this.lblGonderen.TabIndex = 21;
            this.lblGonderen.Text = "Gönderen:";
            // 
            // lblAlici
            // 
            this.lblAlici.AutoSize = true;
            this.lblAlici.Location = new System.Drawing.Point(6, 72);
            this.lblAlici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(32, 15);
            this.lblAlici.TabIndex = 22;
            this.lblAlici.Text = "Alıcı:";
            // 
            // lblDesi
            // 
            this.lblDesi.AutoSize = true;
            this.lblDesi.Location = new System.Drawing.Point(6, 146);
            this.lblDesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesi.Name = "lblDesi";
            this.lblDesi.Size = new System.Drawing.Size(35, 15);
            this.lblDesi.TabIndex = 26;
            this.lblDesi.Text = "Desi:";
            // 
            // lblAgirlik
            // 
            this.lblAgirlik.AutoSize = true;
            this.lblAgirlik.Location = new System.Drawing.Point(6, 178);
            this.lblAgirlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgirlik.Name = "lblAgirlik";
            this.lblAgirlik.Size = new System.Drawing.Size(43, 15);
            this.lblAgirlik.TabIndex = 27;
            this.lblAgirlik.Text = "Ağırlık:";
            // 
            // lblKargoTuru
            // 
            this.lblKargoTuru.AutoSize = true;
            this.lblKargoTuru.Location = new System.Drawing.Point(4, 105);
            this.lblKargoTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKargoTuru.Name = "lblKargoTuru";
            this.lblKargoTuru.Size = new System.Drawing.Size(71, 15);
            this.lblKargoTuru.TabIndex = 28;
            this.lblKargoTuru.Text = "Kargo Türü:";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(6, 218);
            this.lblUcret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(39, 15);
            this.lblUcret.TabIndex = 29;
            this.lblUcret.Text = "Ücret:";
            // 
            // tbxUcret
            // 
            this.tbxUcret.Location = new System.Drawing.Point(89, 216);
            this.tbxUcret.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUcret.Name = "tbxUcret";
            this.tbxUcret.ReadOnly = true;
            this.tbxUcret.Size = new System.Drawing.Size(154, 21);
            this.tbxUcret.TabIndex = 30;
            // 
            // btnGonderici
            // 
            this.btnGonderici.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonderici.Location = new System.Drawing.Point(254, 36);
            this.btnGonderici.Margin = new System.Windows.Forms.Padding(2);
            this.btnGonderici.Name = "btnGonderici";
            this.btnGonderici.Size = new System.Drawing.Size(70, 20);
            this.btnGonderici.TabIndex = 31;
            this.btnGonderici.Text = "Seçim Yap";
            this.btnGonderici.UseVisualStyleBackColor = true;
            this.btnGonderici.Click += new System.EventHandler(this.BtnGonderici_Click);
            // 
            // btnAlici
            // 
            this.btnAlici.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlici.Location = new System.Drawing.Point(254, 70);
            this.btnAlici.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlici.Name = "btnAlici";
            this.btnAlici.Size = new System.Drawing.Size(70, 20);
            this.btnAlici.TabIndex = 32;
            this.btnAlici.Text = "Seçim Yap";
            this.btnAlici.UseVisualStyleBackColor = true;
            this.btnAlici.Click += new System.EventHandler(this.BtnAlici_Click);
            // 
            // lblKargoTuruID
            // 
            this.lblKargoTuruID.AutoSize = true;
            this.lblKargoTuruID.Location = new System.Drawing.Point(251, 111);
            this.lblKargoTuruID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKargoTuruID.Name = "lblKargoTuruID";
            this.lblKargoTuruID.Size = new System.Drawing.Size(83, 15);
            this.lblKargoTuruID.TabIndex = 33;
            this.lblKargoTuruID.Text = "Kargo Turu ID";
            // 
            // lblGondericiID
            // 
            this.lblGondericiID.AutoSize = true;
            this.lblGondericiID.Location = new System.Drawing.Point(349, 37);
            this.lblGondericiID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGondericiID.Name = "lblGondericiID";
            this.lblGondericiID.Size = new System.Drawing.Size(75, 15);
            this.lblGondericiID.TabIndex = 34;
            this.lblGondericiID.Text = "Gönderici ID";
            // 
            // lblAliciID
            // 
            this.lblAliciID.AutoSize = true;
            this.lblAliciID.Location = new System.Drawing.Point(349, 74);
            this.lblAliciID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAliciID.Name = "lblAliciID";
            this.lblAliciID.Size = new System.Drawing.Size(44, 15);
            this.lblAliciID.TabIndex = 35;
            this.lblAliciID.Text = "Alıcı ID";
            // 
            // rdbAlici
            // 
            this.rdbAlici.AutoSize = true;
            this.rdbAlici.Location = new System.Drawing.Point(8, 251);
            this.rdbAlici.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAlici.Name = "rdbAlici";
            this.rdbAlici.Size = new System.Drawing.Size(97, 19);
            this.rdbAlici.TabIndex = 36;
            this.rdbAlici.TabStop = true;
            this.rdbAlici.Text = "Alıcı Ödemeli";
            this.rdbAlici.UseVisualStyleBackColor = true;
            // 
            // rbcGonderici
            // 
            this.rbcGonderici.AutoSize = true;
            this.rbcGonderici.Location = new System.Drawing.Point(113, 251);
            this.rbcGonderici.Margin = new System.Windows.Forms.Padding(2);
            this.rbcGonderici.Name = "rbcGonderici";
            this.rbcGonderici.Size = new System.Drawing.Size(130, 19);
            this.rbcGonderici.TabIndex = 37;
            this.rbcGonderici.TabStop = true;
            this.rbcGonderici.Text = "Gönderen Ödemeli";
            this.rbcGonderici.UseVisualStyleBackColor = true;
            // 
            // btnYeniKargo
            // 
            this.btnYeniKargo.Location = new System.Drawing.Point(305, 238);
            this.btnYeniKargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniKargo.Name = "btnYeniKargo";
            this.btnYeniKargo.Size = new System.Drawing.Size(94, 45);
            this.btnYeniKargo.TabIndex = 38;
            this.btnYeniKargo.Text = "KARGO OLUŞTUR";
            this.btnYeniKargo.UseVisualStyleBackColor = true;
            this.btnYeniKargo.Click += new System.EventHandler(this.BtnYeniKargo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYeniKargo);
            this.groupBox2.Controls.Add(this.rbcGonderici);
            this.groupBox2.Controls.Add(this.rdbAlici);
            this.groupBox2.Controls.Add(this.lblAliciID);
            this.groupBox2.Controls.Add(this.lblGondericiID);
            this.groupBox2.Controls.Add(this.lblKargoTuruID);
            this.groupBox2.Controls.Add(this.btnAlici);
            this.groupBox2.Controls.Add(this.btnGonderici);
            this.groupBox2.Controls.Add(this.tbxUcret);
            this.groupBox2.Controls.Add(this.lblUcret);
            this.groupBox2.Controls.Add(this.lblKargoTuru);
            this.groupBox2.Controls.Add(this.lblAgirlik);
            this.groupBox2.Controls.Add(this.lblDesi);
            this.groupBox2.Controls.Add(this.lblAlici);
            this.groupBox2.Controls.Add(this.lblGonderen);
            this.groupBox2.Controls.Add(this.tbxDesi);
            this.groupBox2.Controls.Add(this.tbxAgirlik);
            this.groupBox2.Controls.Add(this.tbxAlici);
            this.groupBox2.Controls.Add(this.tbxGonderen);
            this.groupBox2.Controls.Add(this.cbxKargoTurleri);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(11, 308);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(457, 296);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kargo Oluştur";
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(529, 547);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(94, 45);
            this.btnAnaMenu.TabIndex = 40;
            this.btnAnaMenu.Text = "ANA MENÜ";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // btnMusteriISlemleri
            // 
            this.btnMusteriISlemleri.Location = new System.Drawing.Point(567, 227);
            this.btnMusteriISlemleri.Margin = new System.Windows.Forms.Padding(2);
            this.btnMusteriISlemleri.Name = "btnMusteriISlemleri";
            this.btnMusteriISlemleri.Size = new System.Drawing.Size(107, 44);
            this.btnMusteriISlemleri.TabIndex = 41;
            this.btnMusteriISlemleri.Text = "YENİ MÜŞTERİ GİRİŞİ";
            this.btnMusteriISlemleri.UseVisualStyleBackColor = true;
            this.btnMusteriISlemleri.Click += new System.EventHandler(this.BtnMusteriISlemleri_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackgroundImage = global::KargoDBForm.Properties.Resources.icon_refresh_48px_512;
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYenile.Location = new System.Drawing.Point(518, 227);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(44, 44);
            this.btnYenile.TabIndex = 42;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 618);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnMusteriISlemleri);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.lblMusteriAra);
            this.Controls.Add(this.dgwMusteriler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kargo Otomasyonu v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteriler;
        private System.Windows.Forms.Label lblMusteriAra;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.ComboBox cbxKargoTurleri;
        private System.Windows.Forms.TextBox tbxGonderen;
        private System.Windows.Forms.TextBox tbxAlici;
        private System.Windows.Forms.TextBox tbxAgirlik;
        private System.Windows.Forms.TextBox tbxDesi;
        private System.Windows.Forms.Label lblGonderen;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblDesi;
        private System.Windows.Forms.Label lblAgirlik;
        private System.Windows.Forms.Label lblKargoTuru;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox tbxUcret;
        private System.Windows.Forms.Button btnGonderici;
        private System.Windows.Forms.Button btnAlici;
        private System.Windows.Forms.Label lblKargoTuruID;
        private System.Windows.Forms.Label lblGondericiID;
        private System.Windows.Forms.Label lblAliciID;
        private System.Windows.Forms.RadioButton rdbAlici;
        private System.Windows.Forms.RadioButton rbcGonderici;
        private System.Windows.Forms.Button btnYeniKargo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnMusteriISlemleri;
        private System.Windows.Forms.ToolTip ttMusteriAra;
        private System.Windows.Forms.Button btnYenile;
    }
}

