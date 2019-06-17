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
    public partial class YonetimPaneli : Form
    {
        public YonetimPaneli()
        {
            InitializeComponent();
        }



        private void YonetimPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnMIslemler_Click_1(object sender, EventArgs e)
        {
            MusteriIslemleri fmi = new MusteriIslemleri();
            fmi.ShowDialog();           
        }

        private void btnKTISlemler_Click(object sender, EventArgs e)
        {
            KargoTuruIslemleri kti = new KargoTuruIslemleri();
            kti.ShowDialog();
        }

        private void btnSIslemler_Click(object sender, EventArgs e)
        {
            SubeIslemleri fsi = new SubeIslemleri();
            fsi.ShowDialog();
        }

        private void btnKuIslemler_Click(object sender, EventArgs e)
        {
            KuryeIslemleri fki = new KuryeIslemleri();
            fki.ShowDialog();
        }
    }
}
