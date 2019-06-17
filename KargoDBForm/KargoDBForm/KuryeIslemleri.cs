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
    public partial class KuryeIslemleri : Form
    {
        KargoDBDal islemler = new KargoDBDal();
        public KuryeIslemleri()
        {
            InitializeComponent();
        }


        private void KuryeIslemleri_Load(object sender, EventArgs e)
        {
            islemler.LoadKuryeler(dgwKuryeler);
            islemler.LoadComboBoxSubeler(cbxSubeler);
        }

        private void BtnKuryeKAydet_Click(object sender, EventArgs e)
        {
            Kuryeler kurye = new Kuryeler(Convert.ToInt32(dgwKuryeler.CurrentRow.Cells[1]),tbxKuryeAd.Text, tbxKuryeSoyad.Text);
            islemler.KuryeEkle(kurye);
            MessageBox.Show("Kurye Eklendi!");

        }

        private void BtnKuryeGuncel_Click(object sender, EventArgs e)
        {
            Kuryeler kurye = new Kuryeler(Convert.ToInt32(dgwKuryeler.CurrentRow.Cells[1]), tbxKuryeAd.Text, tbxKuryeSoyad.Text);
            islemler.KuryeGuncelle(kurye);
            MessageBox.Show("Güncellendi!");


        }

        private void BtnKuryeSil_Click(object sender, EventArgs e)
        {
            DialogResult eminMisiniz = new DialogResult();
            eminMisiniz = MessageBox.Show("Seçili kayıt veritabanından silinecektir. Devam etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (eminMisiniz == DialogResult.Yes)
            {
                islemler.KuryeSil(Convert.ToInt32(dgwKuryeler.CurrentRow.Cells[0]));
            }
        }

        private void DgwKuryeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKuryeAd.Text = dgwKuryeler.CurrentRow.Cells[2].ToString();
            tbxKuryeSoyad.Text = dgwKuryeler.CurrentRow.Cells[3].ToString();


        }
    }
}
