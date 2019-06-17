namespace KargoDBForm
{
    partial class YonetimPaneli
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
            this.btnKuIslemler = new System.Windows.Forms.Button();
            this.btnSIslemler = new System.Windows.Forms.Button();
            this.btnKTISlemler = new System.Windows.Forms.Button();
            this.btnMIslemler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKuIslemler
            // 
            this.btnKuIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKuIslemler.Location = new System.Drawing.Point(217, 192);
            this.btnKuIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.btnKuIslemler.Name = "btnKuIslemler";
            this.btnKuIslemler.Size = new System.Drawing.Size(124, 77);
            this.btnKuIslemler.TabIndex = 52;
            this.btnKuIslemler.Text = "KURYE İŞLEMLERİ";
            this.btnKuIslemler.UseVisualStyleBackColor = true;
            this.btnKuIslemler.Click += new System.EventHandler(this.btnKuIslemler_Click);
            // 
            // btnSIslemler
            // 
            this.btnSIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSIslemler.Location = new System.Drawing.Point(79, 192);
            this.btnSIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.btnSIslemler.Name = "btnSIslemler";
            this.btnSIslemler.Size = new System.Drawing.Size(124, 77);
            this.btnSIslemler.TabIndex = 51;
            this.btnSIslemler.Text = "ŞUBE İŞLEMLERİ";
            this.btnSIslemler.UseVisualStyleBackColor = true;
            this.btnSIslemler.Click += new System.EventHandler(this.btnSIslemler_Click);
            // 
            // btnKTISlemler
            // 
            this.btnKTISlemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKTISlemler.Location = new System.Drawing.Point(217, 97);
            this.btnKTISlemler.Margin = new System.Windows.Forms.Padding(2);
            this.btnKTISlemler.Name = "btnKTISlemler";
            this.btnKTISlemler.Size = new System.Drawing.Size(124, 77);
            this.btnKTISlemler.TabIndex = 50;
            this.btnKTISlemler.Text = "KARGO TÜRÜ İŞLEMLERİ";
            this.btnKTISlemler.UseVisualStyleBackColor = true;
            this.btnKTISlemler.Click += new System.EventHandler(this.btnKTISlemler_Click);
            // 
            // btnMIslemler
            // 
            this.btnMIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMIslemler.Location = new System.Drawing.Point(79, 97);
            this.btnMIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.btnMIslemler.Name = "btnMIslemler";
            this.btnMIslemler.Size = new System.Drawing.Size(124, 77);
            this.btnMIslemler.TabIndex = 49;
            this.btnMIslemler.Text = "MÜŞTERİ İŞLEMLERİ";
            this.btnMIslemler.UseVisualStyleBackColor = true;
            this.btnMIslemler.Click += new System.EventHandler(this.btnMIslemler_Click_1);
            // 
            // YonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 386);
            this.Controls.Add(this.btnKuIslemler);
            this.Controls.Add(this.btnSIslemler);
            this.Controls.Add(this.btnKTISlemler);
            this.Controls.Add(this.btnMIslemler);
            this.Name = "YonetimPaneli";
            this.Text = "Kargo Otomasyonu v1.0 | Yönetim Paneli";
            this.Load += new System.EventHandler(this.YonetimPaneli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKuIslemler;
        private System.Windows.Forms.Button btnSIslemler;
        private System.Windows.Forms.Button btnKTISlemler;
        private System.Windows.Forms.Button btnMIslemler;
    }
}