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
    public partial class SubeIslemleri : Form
    {
        KargoDBDal islemler = new KargoDBDal();
        public SubeIslemleri()
        {
            InitializeComponent();
        }

        private void SubeIslemleri_Load(object sender, EventArgs e)
        {
            islemler.LoadSubeler(dgwSubeler);
        }

        private void BtnSsil_Click(object sender, EventArgs e)
        {

            DialogResult eminMisiniz = new DialogResult();
            eminMisiniz = MessageBox.Show("Seçili kayıt veritabanından silinecektir. Devam etmek istediğinizden emin misiniz?", "Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (eminMisiniz == DialogResult.Yes)
            {
                islemler.SubeSil(Convert.ToInt32(dgwSubeler.CurrentRow.Cells[0].Value));

            }
        }

        private void BtnSekle_Click(object sender, EventArgs e)
        {
            Subeler sube = new Subeler(Convert.ToInt32(dgwSubeler.CurrentRow.Cells[0].Value), tbxSubeAdi.Text, tbxSubeTelefon.Text,tbxSubeAdres.Text);
            islemler.SubeEkle(sube);
            MessageBox.Show("Yeni şube eklendi");
            islemler.LoadSubeler(dgwSubeler);

        }

        private void DgwSubeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSID.Text = dgwSubeler.CurrentRow.Cells[0].Value.ToString();
            tbxSubeAdi.Text= dgwSubeler.CurrentRow.Cells[1].Value.ToString();
            tbxSubeTelefon.Text=dgwSubeler.CurrentRow.Cells[2].Value.ToString();
            tbxSubeAdres.Text = dgwSubeler.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnSguncelle_Click(object sender, EventArgs e)
        {
            Subeler sube = new Subeler(Convert.ToInt32(dgwSubeler.CurrentRow.Cells[0].Value), tbxSubeAdi.Text, tbxSubeTelefon.Text, tbxSubeAdres.Text);
            islemler.SubeGuncelle(sube);
            MessageBox.Show("Şube Güncellendi");
            islemler.LoadSubeler(dgwSubeler);


        }

        private void TbxSubeAra_TextChanged(object sender, EventArgs e)
        {
            islemler.SubeAra(dgwSubeler,tbxSubeAra.Text);
        }

        private void BtnAnaMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
    }
}
