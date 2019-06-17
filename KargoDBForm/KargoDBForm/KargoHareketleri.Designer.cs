namespace KargoDBForm
{
    partial class KargoHareketleri
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
            this.dgwKargo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxKuryeler = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbxDurumGuncel = new System.Windows.Forms.TextBox();
            this.btnYeniKargo = new System.Windows.Forms.Button();
            this.lblDurumGuncel = new System.Windows.Forms.Label();
            this.lblKurye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSubeAra = new System.Windows.Forms.TextBox();
            this.tbxKuryeAra = new System.Windows.Forms.TextBox();
            this.tbxMusteriAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLisAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKargo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwKargo
            // 
            this.dgwKargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKargo.Location = new System.Drawing.Point(38, 41);
            this.dgwKargo.Margin = new System.Windows.Forms.Padding(2);
            this.dgwKargo.Name = "dgwKargo";
            this.dgwKargo.RowHeadersWidth = 51;
            this.dgwKargo.RowTemplate.Height = 24;
            this.dgwKargo.Size = new System.Drawing.Size(590, 183);
            this.dgwKargo.TabIndex = 0;
            this.dgwKargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKargo_CellClick);
            this.dgwKargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxKuryeler);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.tbxDurumGuncel);
            this.groupBox2.Controls.Add(this.btnYeniKargo);
            this.groupBox2.Controls.Add(this.lblDurumGuncel);
            this.groupBox2.Controls.Add(this.lblKurye);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(38, 280);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(505, 275);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kargo Durum Güncelle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 48;
            // 
            // cbxKuryeler
            // 
            this.cbxKuryeler.FormattingEnabled = true;
            this.cbxKuryeler.Location = new System.Drawing.Point(118, 114);
            this.cbxKuryeler.Name = "cbxKuryeler";
            this.cbxKuryeler.Size = new System.Drawing.Size(154, 23);
            this.cbxKuryeler.TabIndex = 49;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 48;
            this.button2.Text = "KARGO İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Teslim Tarhi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 21);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.Value = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            // 
            // tbxDurumGuncel
            // 
            this.tbxDurumGuncel.Location = new System.Drawing.Point(118, 161);
            this.tbxDurumGuncel.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDurumGuncel.Name = "tbxDurumGuncel";
            this.tbxDurumGuncel.Size = new System.Drawing.Size(154, 21);
            this.tbxDurumGuncel.TabIndex = 41;
            // 
            // btnYeniKargo
            // 
            this.btnYeniKargo.Location = new System.Drawing.Point(178, 215);
            this.btnYeniKargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniKargo.Name = "btnYeniKargo";
            this.btnYeniKargo.Size = new System.Drawing.Size(94, 45);
            this.btnYeniKargo.TabIndex = 38;
            this.btnYeniKargo.Text = "TESLİM EDİLDİ";
            this.btnYeniKargo.UseVisualStyleBackColor = true;
            this.btnYeniKargo.Click += new System.EventHandler(this.BtnYeniKargo_Click);
            // 
            // lblDurumGuncel
            // 
            this.lblDurumGuncel.AutoSize = true;
            this.lblDurumGuncel.Location = new System.Drawing.Point(11, 162);
            this.lblDurumGuncel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurumGuncel.Name = "lblDurumGuncel";
            this.lblDurumGuncel.Size = new System.Drawing.Size(103, 15);
            this.lblDurumGuncel.TabIndex = 27;
            this.lblDurumGuncel.Text = "Durum Güncelle: ";
            // 
            // lblKurye
            // 
            this.lblKurye.AutoSize = true;
            this.lblKurye.Location = new System.Drawing.Point(11, 114);
            this.lblKurye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKurye.Name = "lblKurye";
            this.lblKurye.Size = new System.Drawing.Size(82, 15);
            this.lblKurye.TabIndex = 26;
            this.lblKurye.Text = "Kurye Seçimi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(35, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Dikkat! Teslim edilmeyen kargoların Teslim Tarihi 01.01.2000 olarak gözükmektedir" +
    ".";
            // 
            // tbxSubeAra
            // 
            this.tbxSubeAra.Location = new System.Drawing.Point(639, 154);
            this.tbxSubeAra.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSubeAra.Name = "tbxSubeAra";
            this.tbxSubeAra.Size = new System.Drawing.Size(178, 20);
            this.tbxSubeAra.TabIndex = 41;
            this.tbxSubeAra.TextChanged += new System.EventHandler(this.tbxSubeAra_TextChanged);
            // 
            // tbxKuryeAra
            // 
            this.tbxKuryeAra.Location = new System.Drawing.Point(639, 103);
            this.tbxKuryeAra.Margin = new System.Windows.Forms.Padding(2);
            this.tbxKuryeAra.Name = "tbxKuryeAra";
            this.tbxKuryeAra.Size = new System.Drawing.Size(178, 20);
            this.tbxKuryeAra.TabIndex = 42;
            this.tbxKuryeAra.TextChanged += new System.EventHandler(this.tbxKuryeAra_TextChanged);
            // 
            // tbxMusteriAra
            // 
            this.tbxMusteriAra.Location = new System.Drawing.Point(639, 58);
            this.tbxMusteriAra.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMusteriAra.Name = "tbxMusteriAra";
            this.tbxMusteriAra.Size = new System.Drawing.Size(178, 20);
            this.tbxMusteriAra.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Gönderici/Alıcı Adına Göre Filtreleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Kurye Adına Göre Filtreleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Şebe Adına Göre Filtreleme";
            // 
            // btnLisAra
            // 
            this.btnLisAra.Location = new System.Drawing.Point(639, 193);
            this.btnLisAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnLisAra.Name = "btnLisAra";
            this.btnLisAra.Size = new System.Drawing.Size(177, 31);
            this.btnLisAra.TabIndex = 47;
            this.btnLisAra.Text = "LİSTELE";
            this.btnLisAra.UseVisualStyleBackColor = true;
            this.btnLisAra.Click += new System.EventHandler(this.btnLisAra_Click);
            // 
            // KargoHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 593);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLisAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMusteriAra);
            this.Controls.Add(this.tbxKuryeAra);
            this.Controls.Add(this.tbxSubeAra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwKargo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KargoHareketleri";
            this.Text = "Kargo Otomasyonu v1.0 | Kargo Hareketleri";
            this.Load += new System.EventHandler(this.KargoHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKargo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKargo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYeniKargo;
        private System.Windows.Forms.Label lblDurumGuncel;
        private System.Windows.Forms.Label lblKurye;
        private System.Windows.Forms.TextBox tbxDurumGuncel;
        private System.Windows.Forms.TextBox tbxSubeAra;
        private System.Windows.Forms.TextBox tbxKuryeAra;
        private System.Windows.Forms.TextBox tbxMusteriAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLisAra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxKuryeler;
        private System.Windows.Forms.Label label6;
    }
}