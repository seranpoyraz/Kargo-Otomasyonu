namespace KargoDBForm
{
    partial class SubeIslemleri
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
            this.dgwSubeler = new System.Windows.Forms.DataGridView();
            this.tbxSubeAdres = new System.Windows.Forms.TextBox();
            this.tbxSubeTelefon = new System.Windows.Forms.TextBox();
            this.tbxSubeAdi = new System.Windows.Forms.TextBox();
            this.lblSID = new System.Windows.Forms.Label();
            this.lblSad = new System.Windows.Forms.Label();
            this.lblStel = new System.Windows.Forms.Label();
            this.lblSAdres = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSguncelle = new System.Windows.Forms.Button();
            this.btnSekle = new System.Windows.Forms.Button();
            this.btnSsil = new System.Windows.Forms.Button();
            this.lblSubeAra = new System.Windows.Forms.Label();
            this.tbxSubeAra = new System.Windows.Forms.TextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwSubeler
            // 
            this.dgwSubeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSubeler.Location = new System.Drawing.Point(12, 92);
            this.dgwSubeler.Name = "dgwSubeler";
            this.dgwSubeler.RowHeadersWidth = 51;
            this.dgwSubeler.RowTemplate.Height = 24;
            this.dgwSubeler.Size = new System.Drawing.Size(467, 339);
            this.dgwSubeler.TabIndex = 0;
            this.dgwSubeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwSubeler_CellContentClick);
            // 
            // tbxSubeAdres
            // 
            this.tbxSubeAdres.Location = new System.Drawing.Point(132, 176);
            this.tbxSubeAdres.Multiline = true;
            this.tbxSubeAdres.Name = "tbxSubeAdres";
            this.tbxSubeAdres.Size = new System.Drawing.Size(166, 51);
            this.tbxSubeAdres.TabIndex = 1;
            // 
            // tbxSubeTelefon
            // 
            this.tbxSubeTelefon.Location = new System.Drawing.Point(132, 130);
            this.tbxSubeTelefon.Name = "tbxSubeTelefon";
            this.tbxSubeTelefon.Size = new System.Drawing.Size(166, 22);
            this.tbxSubeTelefon.TabIndex = 2;
            // 
            // tbxSubeAdi
            // 
            this.tbxSubeAdi.Location = new System.Drawing.Point(132, 89);
            this.tbxSubeAdi.Name = "tbxSubeAdi";
            this.tbxSubeAdi.Size = new System.Drawing.Size(166, 22);
            this.tbxSubeAdi.TabIndex = 3;
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(26, 36);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(58, 17);
            this.lblSID.TabIndex = 4;
            this.lblSID.Text = "Şube ID";
            // 
            // lblSad
            // 
            this.lblSad.AutoSize = true;
            this.lblSad.Location = new System.Drawing.Point(26, 89);
            this.lblSad.Name = "lblSad";
            this.lblSad.Size = new System.Drawing.Size(69, 17);
            this.lblSad.TabIndex = 5;
            this.lblSad.Text = "Şube Adı:";
            // 
            // lblStel
            // 
            this.lblStel.AutoSize = true;
            this.lblStel.Location = new System.Drawing.Point(26, 130);
            this.lblStel.Name = "lblStel";
            this.lblStel.Size = new System.Drawing.Size(97, 17);
            this.lblStel.TabIndex = 6;
            this.lblStel.Text = "Şube Telefon:";
            // 
            // lblSAdres
            // 
            this.lblSAdres.AutoSize = true;
            this.lblSAdres.Location = new System.Drawing.Point(26, 176);
            this.lblSAdres.Name = "lblSAdres";
            this.lblSAdres.Size = new System.Drawing.Size(86, 17);
            this.lblSAdres.TabIndex = 7;
            this.lblSAdres.Text = "Şube Adres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSguncelle);
            this.groupBox1.Controls.Add(this.btnSekle);
            this.groupBox1.Controls.Add(this.lblSAdres);
            this.groupBox1.Controls.Add(this.lblStel);
            this.groupBox1.Controls.Add(this.lblSad);
            this.groupBox1.Controls.Add(this.lblSID);
            this.groupBox1.Controls.Add(this.tbxSubeAdi);
            this.groupBox1.Controls.Add(this.tbxSubeTelefon);
            this.groupBox1.Controls.Add(this.tbxSubeAdres);
            this.groupBox1.Location = new System.Drawing.Point(496, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 339);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şube İşlemleri";
            // 
            // btnSguncelle
            // 
            this.btnSguncelle.Location = new System.Drawing.Point(234, 255);
            this.btnSguncelle.Name = "btnSguncelle";
            this.btnSguncelle.Size = new System.Drawing.Size(121, 64);
            this.btnSguncelle.TabIndex = 10;
            this.btnSguncelle.Text = "SEÇİLİ ŞUBEYİ GÜNCELLE";
            this.btnSguncelle.UseVisualStyleBackColor = true;
            this.btnSguncelle.Click += new System.EventHandler(this.BtnSguncelle_Click);
            // 
            // btnSekle
            // 
            this.btnSekle.Location = new System.Drawing.Point(20, 255);
            this.btnSekle.Name = "btnSekle";
            this.btnSekle.Size = new System.Drawing.Size(115, 64);
            this.btnSekle.TabIndex = 9;
            this.btnSekle.Text = "YENİ ŞUBE EKLE";
            this.btnSekle.UseVisualStyleBackColor = true;
            this.btnSekle.Click += new System.EventHandler(this.BtnSekle_Click);
            // 
            // btnSsil
            // 
            this.btnSsil.Location = new System.Drawing.Point(12, 449);
            this.btnSsil.Name = "btnSsil";
            this.btnSsil.Size = new System.Drawing.Size(112, 58);
            this.btnSsil.TabIndex = 8;
            this.btnSsil.Text = "SEÇİLİ ŞUBEYİ SİL";
            this.btnSsil.UseVisualStyleBackColor = true;
            this.btnSsil.Click += new System.EventHandler(this.BtnSsil_Click);
            // 
            // lblSubeAra
            // 
            this.lblSubeAra.AutoSize = true;
            this.lblSubeAra.Location = new System.Drawing.Point(12, 56);
            this.lblSubeAra.Name = "lblSubeAra";
            this.lblSubeAra.Size = new System.Drawing.Size(71, 17);
            this.lblSubeAra.TabIndex = 9;
            this.lblSubeAra.Text = "Şube Ara:";
            // 
            // tbxSubeAra
            // 
            this.tbxSubeAra.Location = new System.Drawing.Point(98, 53);
            this.tbxSubeAra.Name = "tbxSubeAra";
            this.tbxSubeAra.Size = new System.Drawing.Size(151, 22);
            this.tbxSubeAra.TabIndex = 10;
            this.tbxSubeAra.TextChanged += new System.EventHandler(this.TbxSubeAra_TextChanged);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(744, 484);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(125, 55);
            this.btnAnaMenu.TabIndex = 41;
            this.btnAnaMenu.Text = "ANA MENÜ";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.BtnAnaMenu_Click);
            // 
            // SubeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.tbxSubeAra);
            this.Controls.Add(this.lblSubeAra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwSubeler);
            this.Controls.Add(this.btnSsil);
            this.Name = "SubeIslemleri";
            this.Text = "KArgo Otomasyonu v1.0 | Şube İşlemleri";
            this.Load += new System.EventHandler(this.SubeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSubeler;
        private System.Windows.Forms.TextBox tbxSubeAdres;
        private System.Windows.Forms.TextBox tbxSubeTelefon;
        private System.Windows.Forms.TextBox tbxSubeAdi;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Label lblSad;
        private System.Windows.Forms.Label lblStel;
        private System.Windows.Forms.Label lblSAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSguncelle;
        private System.Windows.Forms.Button btnSekle;
        private System.Windows.Forms.Button btnSsil;
        private System.Windows.Forms.Label lblSubeAra;
        private System.Windows.Forms.TextBox tbxSubeAra;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}