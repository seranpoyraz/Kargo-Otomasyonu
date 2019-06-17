namespace KargoDBForm
{
    partial class KargoTuruIslemleri
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
            this.lbxKargoTuru = new System.Windows.Forms.ListBox();
            this.btnKTEkle = new System.Windows.Forms.Button();
            this.tbxIcerik = new System.Windows.Forms.TextBox();
            this.btnKTGuncel = new System.Windows.Forms.Button();
            this.btnKTSil = new System.Windows.Forms.Button();
            this.lblKTIcerik = new System.Windows.Forms.Label();
            this.lblKTID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxKargoTuru
            // 
            this.lbxKargoTuru.FormattingEnabled = true;
            this.lbxKargoTuru.ItemHeight = 16;
            this.lbxKargoTuru.Location = new System.Drawing.Point(12, 72);
            this.lbxKargoTuru.Name = "lbxKargoTuru";
            this.lbxKargoTuru.Size = new System.Drawing.Size(196, 340);
            this.lbxKargoTuru.TabIndex = 0;
            this.lbxKargoTuru.SelectedIndexChanged += new System.EventHandler(this.LbxKargoTuru_SelectedIndexChanged);
            // 
            // btnKTEkle
            // 
            this.btnKTEkle.Location = new System.Drawing.Point(255, 348);
            this.btnKTEkle.Name = "btnKTEkle";
            this.btnKTEkle.Size = new System.Drawing.Size(92, 64);
            this.btnKTEkle.TabIndex = 1;
            this.btnKTEkle.Text = "EKLE";
            this.btnKTEkle.UseVisualStyleBackColor = true;
            // 
            // tbxIcerik
            // 
            this.tbxIcerik.Location = new System.Drawing.Point(318, 292);
            this.tbxIcerik.Name = "tbxIcerik";
            this.tbxIcerik.Size = new System.Drawing.Size(262, 22);
            this.tbxIcerik.TabIndex = 2;
            this.tbxIcerik.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnKTGuncel
            // 
            this.btnKTGuncel.Location = new System.Drawing.Point(373, 348);
            this.btnKTGuncel.Name = "btnKTGuncel";
            this.btnKTGuncel.Size = new System.Drawing.Size(92, 64);
            this.btnKTGuncel.TabIndex = 3;
            this.btnKTGuncel.Text = "SEÇİLİ OLANI GÜNCELLE";
            this.btnKTGuncel.UseVisualStyleBackColor = true;
            // 
            // btnKTSil
            // 
            this.btnKTSil.Location = new System.Drawing.Point(585, 348);
            this.btnKTSil.Name = "btnKTSil";
            this.btnKTSil.Size = new System.Drawing.Size(92, 64);
            this.btnKTSil.TabIndex = 4;
            this.btnKTSil.Text = "SİL";
            this.btnKTSil.UseVisualStyleBackColor = true;
            this.btnKTSil.Click += new System.EventHandler(this.BtnKTSil_Click);
            // 
            // lblKTIcerik
            // 
            this.lblKTIcerik.AutoSize = true;
            this.lblKTIcerik.Location = new System.Drawing.Point(252, 292);
            this.lblKTIcerik.Name = "lblKTIcerik";
            this.lblKTIcerik.Size = new System.Drawing.Size(41, 17);
            this.lblKTIcerik.TabIndex = 5;
            this.lblKTIcerik.Text = "İçerik";
            // 
            // lblKTID
            // 
            this.lblKTID.AutoSize = true;
            this.lblKTID.Location = new System.Drawing.Point(252, 248);
            this.lblKTID.Name = "lblKTID";
            this.lblKTID.Size = new System.Drawing.Size(108, 17);
            this.lblKTID.TabIndex = 6;
            this.lblKTID.Text = "İşlem Yapılan ID";
            // 
            // KargoTuruIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 459);
            this.Controls.Add(this.lblKTID);
            this.Controls.Add(this.lblKTIcerik);
            this.Controls.Add(this.btnKTSil);
            this.Controls.Add(this.btnKTGuncel);
            this.Controls.Add(this.tbxIcerik);
            this.Controls.Add(this.btnKTEkle);
            this.Controls.Add(this.lbxKargoTuru);
            this.Name = "KargoTuruIslemleri";
            this.Text = "Kargo Otomasyonu v1.0 | Kargo Türü İşlemleri";
            this.Load += new System.EventHandler(this.KargoTuruIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKargoTuru;
        private System.Windows.Forms.Button btnKTEkle;
        private System.Windows.Forms.TextBox tbxIcerik;
        private System.Windows.Forms.Button btnKTGuncel;
        private System.Windows.Forms.Button btnKTSil;
        private System.Windows.Forms.Label lblKTIcerik;
        private System.Windows.Forms.Label lblKTID;
    }
}