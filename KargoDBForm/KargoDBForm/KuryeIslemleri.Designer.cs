namespace KargoDBForm
{
    partial class KuryeIslemleri
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
            this.dgwKuryeler = new System.Windows.Forms.DataGridView();
            this.tbxKuryeSoyad = new System.Windows.Forms.TextBox();
            this.tbxKuryeAd = new System.Windows.Forms.TextBox();
            this.cbxSubeler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKuryeKAydet = new System.Windows.Forms.Button();
            this.btnKuryeGuncel = new System.Windows.Forms.Button();
            this.btnKuryeSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKuryeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKuryeler
            // 
            this.dgwKuryeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKuryeler.Location = new System.Drawing.Point(28, 25);
            this.dgwKuryeler.Name = "dgwKuryeler";
            this.dgwKuryeler.RowHeadersWidth = 51;
            this.dgwKuryeler.RowTemplate.Height = 24;
            this.dgwKuryeler.Size = new System.Drawing.Size(749, 199);
            this.dgwKuryeler.TabIndex = 0;
            this.dgwKuryeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwKuryeler_CellContentClick);
            // 
            // tbxKuryeSoyad
            // 
            this.tbxKuryeSoyad.Location = new System.Drawing.Point(145, 309);
            this.tbxKuryeSoyad.Name = "tbxKuryeSoyad";
            this.tbxKuryeSoyad.Size = new System.Drawing.Size(151, 22);
            this.tbxKuryeSoyad.TabIndex = 1;
            // 
            // tbxKuryeAd
            // 
            this.tbxKuryeAd.Location = new System.Drawing.Point(145, 260);
            this.tbxKuryeAd.Name = "tbxKuryeAd";
            this.tbxKuryeAd.Size = new System.Drawing.Size(151, 22);
            this.tbxKuryeAd.TabIndex = 2;
            // 
            // cbxSubeler
            // 
            this.cbxSubeler.FormattingEnabled = true;
            this.cbxSubeler.Location = new System.Drawing.Point(145, 360);
            this.cbxSubeler.Name = "cbxSubeler";
            this.cbxSubeler.Size = new System.Drawing.Size(151, 24);
            this.cbxSubeler.TabIndex = 3;
            this.cbxSubeler.Text = "Şubeler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kurye Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kurye Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şubesi:";
            // 
            // btnKuryeKAydet
            // 
            this.btnKuryeKAydet.Location = new System.Drawing.Point(36, 408);
            this.btnKuryeKAydet.Name = "btnKuryeKAydet";
            this.btnKuryeKAydet.Size = new System.Drawing.Size(107, 68);
            this.btnKuryeKAydet.TabIndex = 7;
            this.btnKuryeKAydet.Text = "KURYE EKLE";
            this.btnKuryeKAydet.UseVisualStyleBackColor = true;
            this.btnKuryeKAydet.Click += new System.EventHandler(this.BtnKuryeKAydet_Click);
            // 
            // btnKuryeGuncel
            // 
            this.btnKuryeGuncel.Location = new System.Drawing.Point(199, 408);
            this.btnKuryeGuncel.Name = "btnKuryeGuncel";
            this.btnKuryeGuncel.Size = new System.Drawing.Size(97, 68);
            this.btnKuryeGuncel.TabIndex = 8;
            this.btnKuryeGuncel.Text = "SEÇİLİ OLANI GÜNCELLE";
            this.btnKuryeGuncel.UseVisualStyleBackColor = true;
            this.btnKuryeGuncel.Click += new System.EventHandler(this.BtnKuryeGuncel_Click);
            // 
            // btnKuryeSil
            // 
            this.btnKuryeSil.Location = new System.Drawing.Point(605, 251);
            this.btnKuryeSil.Name = "btnKuryeSil";
            this.btnKuryeSil.Size = new System.Drawing.Size(172, 31);
            this.btnKuryeSil.TabIndex = 9;
            this.btnKuryeSil.Text = "SEÇİLİ OLANI SİL";
            this.btnKuryeSil.UseVisualStyleBackColor = true;
            this.btnKuryeSil.Click += new System.EventHandler(this.BtnKuryeSil_Click);
            // 
            // KuryeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnKuryeSil);
            this.Controls.Add(this.btnKuryeGuncel);
            this.Controls.Add(this.btnKuryeKAydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSubeler);
            this.Controls.Add(this.tbxKuryeAd);
            this.Controls.Add(this.tbxKuryeSoyad);
            this.Controls.Add(this.dgwKuryeler);
            this.Name = "KuryeIslemleri";
            this.Text = "KuryeIslemleri";
            this.Load += new System.EventHandler(this.KuryeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKuryeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKuryeler;
        private System.Windows.Forms.TextBox tbxKuryeSoyad;
        private System.Windows.Forms.TextBox tbxKuryeAd;
        private System.Windows.Forms.ComboBox cbxSubeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKuryeKAydet;
        private System.Windows.Forms.Button btnKuryeGuncel;
        private System.Windows.Forms.Button btnKuryeSil;
    }
}