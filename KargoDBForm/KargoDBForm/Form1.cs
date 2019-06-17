using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoDBForm
{
    public partial class Form1 : Form
    {
        KargoDBDal islemler = new KargoDBDal();
        decimal desi=0;
        decimal agirlik=0;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            islemler.LoadMusteriler(dgwMusteriler);
            islemler.LoadKargoTurleri(cbxKargoTurleri);
            ttMusteriAra.ShowAlways = true;
            ttMusteriAra.SetToolTip(tbxAra, "İsme göre müşteri araması");

        }



        private void CbxKargoTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblKargoTuruID.Text=cbxKargoTurleri.SelectedItem.ToString();
        }


        private void TbxDesi_TextChanged(object sender, EventArgs e)
        {
            desi = Convert.ToDecimal(tbxDesi.Text);

        }

        private void TbxAgirlik_TextChanged(object sender, EventArgs e)
        {
            agirlik = Convert.ToDecimal(tbxAgirlik.Text);
            tbxUcret.Text = (desi * agirlik * 5).ToString();

        }
        
        private void DgwMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGonderici_Click(object sender, EventArgs e)
        {
            tbxGonderen.Text = dgwMusteriler.CurrentRow.Cells[1].Value.ToString()+" "+ dgwMusteriler.CurrentRow.Cells[2].Value.ToString();
            lblGondericiID.Text= dgwMusteriler.CurrentRow.Cells[0].Value.ToString();

        }

        private void BtnAlici_Click(object sender, EventArgs e)
        {
            tbxAlici.Text = dgwMusteriler.CurrentRow.Cells[1].Value.ToString()+" "+ dgwMusteriler.CurrentRow.Cells[2].Value.ToString();
            lblAliciID.Text = dgwMusteriler.CurrentRow.Cells[0].Value.ToString();

        }


        private void BtnKTISlemler_Click(object sender, EventArgs e)
        {
            KargoTuruIslemleri kt = new KargoTuruIslemleri();
            kt.ShowDialog();
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {

            Menu fm = new Menu();
            this.Close();
            fm.Show();
            
        }

        private void BtnMusteriISlemleri_Click(object sender, EventArgs e)
        {
            MusteriIslemleri mi = new MusteriIslemleri();
            mi.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            islemler.MusteriAra(tbxAra.Text, dgwMusteriler);
        }

        private void BtnYeniKargo_Click(object sender, EventArgs e)
        {
            bool secim = true;
            if (rbcGonderici.Checked == true)
            {
                secim = true;
            }

            else if (rdbAlici.Checked == true)
            {
                secim = false;

            }

            Kargo yeniKargo = new Kargo(Convert.ToInt32(lblAliciID.Text), Convert.ToInt32(lblGondericiID.Text), Convert.ToInt32(lblKargoTuruID.Text), Convert.ToDecimal(tbxDesi.Text), Convert.ToDecimal(tbxAgirlik.Text), secim, Convert.ToDecimal(tbxUcret.Text));

            islemler.KargoEkle(yeniKargo);

            KHareketleri yeniHareket = new KHareketleri(islemler.SonKargoIDAl(),islemler.RastgeleKuryeIDAl(),"Kargo oluştu");

            islemler.KargoHareketEkle(yeniHareket);

        }

        private void tbxMAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            islemler.LoadMusteriler(dgwMusteriler);

        }
    }
}
