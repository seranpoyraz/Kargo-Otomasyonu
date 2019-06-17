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
    public partial class KargoHareketleri : Form
    {
        KargoDBDal islemler = new KargoDBDal();
        public KargoHareketleri()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KargoHareketleri_Load(object sender, EventArgs e)
        {
            islemler.LoadKargoHareket(dgwKargo);
            islemler.LoadComboBoxKuryeler(cbxKuryeler);
        }

        private void BtnYeniKargo_Click(object sender, EventArgs e)
        {

            int KuryeID = cbxKuryeler.SelectedIndex + 1;
            Kargo yeniKargo = new Kargo(Convert.ToInt32(dgwKargo.CurrentRow.Cells[1].Value), dateTimePicker1.Value);
            KHareketleri guncelHareket = new KHareketleri(Convert.ToInt32(dgwKargo.CurrentRow.Cells[0].Value), Convert.ToInt32(dgwKargo.CurrentRow.Cells[1].Value), KuryeID,tbxDurumGuncel.Text);
            islemler.KargoGuncelle(yeniKargo);
            islemler.KargoHareketGuncelle(guncelHareket);
            islemler.LoadKargoHareket(dgwKargo);
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult eminMisiniz = new DialogResult();
            eminMisiniz = MessageBox.Show("Seçili kayıt veritabanından silinecektir. Devam etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (eminMisiniz == DialogResult.Yes)
            {
                islemler.KargoSil(Convert.ToInt32(dgwKargo.CurrentRow.Cells[0].Value));
            }
        }

        private void btnLisAra_Click(object sender, EventArgs e)
        {
            islemler.KHareketFiltreKuryeAd(dgwKargo, tbxKuryeAra.Text);

            islemler.KHareketFiltreMusteriAd(dgwKargo, tbxMusteriAra.Text);
            islemler.KHareketFiltreSubeAra(dgwKargo, tbxSubeAra.Text);

        }

        private void tbxKuryeAra_TextChanged(object sender, EventArgs e)
        {
            dgwKargo.ClearSelection();
        }

        private void tbxSubeAra_TextChanged(object sender, EventArgs e)
        {
            dgwKargo.ClearSelection();

        }

        private void dgwKargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxDurumGuncel.Text = dgwKargo.CurrentRow.Cells[9].Value.ToString();

        }
    }
}
