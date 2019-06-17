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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YonetimPaneli yf = new YonetimPaneli();
            Menu m = new Menu();
            Kullanicilar kullanici = new Kullanicilar(tbxUser.Text, tbxPassword.Text);
            KargoDBDal islemler = new KargoDBDal();
            if(islemler.KullaniciGirisi(kullanici, yf, lblKullaniciMesaj) == true)
            {
                m.Close();
                this.Hide();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
