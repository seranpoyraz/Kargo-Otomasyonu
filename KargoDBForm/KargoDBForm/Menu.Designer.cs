namespace KargoDBForm
{
    partial class Menu
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
            this.btnKargoTakip = new System.Windows.Forms.Button();
            this.btnKargoOlustur = new System.Windows.Forms.Button();
            this.btnYonetimPaneli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKargoTakip
            // 
            this.btnKargoTakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargoTakip.Location = new System.Drawing.Point(62, 223);
            this.btnKargoTakip.Margin = new System.Windows.Forms.Padding(2);
            this.btnKargoTakip.Name = "btnKargoTakip";
            this.btnKargoTakip.Size = new System.Drawing.Size(262, 77);
            this.btnKargoTakip.TabIndex = 49;
            this.btnKargoTakip.Text = "KARGO HAREKETLERİ";
            this.btnKargoTakip.UseVisualStyleBackColor = true;
            this.btnKargoTakip.Click += new System.EventHandler(this.BtnKargoTakip_Click);
            // 
            // btnKargoOlustur
            // 
            this.btnKargoOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKargoOlustur.Location = new System.Drawing.Point(62, 67);
            this.btnKargoOlustur.Margin = new System.Windows.Forms.Padding(2);
            this.btnKargoOlustur.Name = "btnKargoOlustur";
            this.btnKargoOlustur.Size = new System.Drawing.Size(262, 77);
            this.btnKargoOlustur.TabIndex = 50;
            this.btnKargoOlustur.Text = "KARGO OLUŞTUR";
            this.btnKargoOlustur.UseVisualStyleBackColor = true;
            this.btnKargoOlustur.Click += new System.EventHandler(this.BtnKargoOlustur_Click);
            // 
            // btnYonetimPaneli
            // 
            this.btnYonetimPaneli.Location = new System.Drawing.Point(62, 318);
            this.btnYonetimPaneli.Name = "btnYonetimPaneli";
            this.btnYonetimPaneli.Size = new System.Drawing.Size(262, 73);
            this.btnYonetimPaneli.TabIndex = 51;
            this.btnYonetimPaneli.Text = "YÖNETİM PANELİ";
            this.btnYonetimPaneli.UseVisualStyleBackColor = true;
            this.btnYonetimPaneli.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 421);
            this.Controls.Add(this.btnYonetimPaneli);
            this.Controls.Add(this.btnKargoOlustur);
            this.Controls.Add(this.btnKargoTakip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Kargo Otomasyonu v1.0 | ANA MENÜ";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKargoTakip;
        private System.Windows.Forms.Button btnKargoOlustur;
        private System.Windows.Forms.Button btnYonetimPaneli;
    }
}