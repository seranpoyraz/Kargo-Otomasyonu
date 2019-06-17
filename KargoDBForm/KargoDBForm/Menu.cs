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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnKargoOlustur_Click(object sender, EventArgs e)
        {
            Form1 fko = new Form1();
            fko.Show();

        }

        private void BtnKargoTakip_Click(object sender, EventArgs e)
        {
            KargoHareketleri fkh = new KargoHareketleri();
            fkh.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciGirisi kg = new KullaniciGirisi();
            kg.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
