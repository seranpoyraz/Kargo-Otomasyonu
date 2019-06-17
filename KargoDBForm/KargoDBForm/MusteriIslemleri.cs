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
    public partial class MusteriIslemleri : Form
    {
        KargoDBDal islemler = new KargoDBDal();
        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            islemler.LoadMusteriler(dgwMusteriIslemleri);

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void TbxMIAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgwMusteriIslemleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMIAd.Text = dgwMusteriIslemleri.CurrentRow.Cells[1].Value.ToString();
            tbxMISoyad.Text= dgwMusteriIslemleri.CurrentRow.Cells[2].Value.ToString();
            tbxMIAdres.Text= dgwMusteriIslemleri.CurrentRow.Cells[3].Value.ToString();
            tbxMITel.Text= dgwMusteriIslemleri.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnMIKaydet_Click(object sender, EventArgs e)
        {

            Musteriler guncelMusteri = new Musteriler(Convert.ToInt32(dgwMusteriIslemleri.CurrentRow.Cells[0].Value),tbxMIAd.Text,tbxMISoyad.Text,tbxMIAdres.Text,tbxMITel.Text);
            islemler.MusteriGuncelle(guncelMusteri);
            islemler.LoadMusteriler(dgwMusteriIslemleri);

        }

        private void BtnMISil_Click(object sender, EventArgs e)
        {

            int MusteriID = Convert.ToInt32(dgwMusteriIslemleri.CurrentRow.Cells[0].Value);


            DialogResult eminMisiniz = new DialogResult();
            eminMisiniz = MessageBox.Show("Seçili kayıt veritabanından silinecektir. Devam etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (eminMisiniz == DialogResult.Yes)
            {
                islemler.MusteriSil(MusteriID);
                islemler.LoadMusteriler(dgwMusteriIslemleri);
            }
            

        }

        private void BtnMKaydet_Click(object sender, EventArgs e)
        {
            islemler.MusteriEkle(new Musteriler(tbxMAd.Text, tbxMSoyad.Text, tbxMAdres.Text, tbxMTel.Text));
            MessageBox.Show("Yeni Müşteri kaydedildi!");
            islemler.LoadMusteriler(dgwMusteriIslemleri);
        }

        private void TbxMIAra_TextChanged(object sender, EventArgs e)
        {
            islemler.MusteriAra(tbxMIAra.Text, dgwMusteriIslemleri);

        }
    }
}
