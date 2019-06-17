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
    public partial class KargoTuruIslemleri : Form
    {
        KargoDBDal islemler = new KargoDBDal();
        public KargoTuruIslemleri()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KargoTuruIslemleri_Load(object sender, EventArgs e)
        {
            islemler.LoadListBoxKargoTurleri(lbxKargoTuru);
        }

        private void LbxKargoTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKTID.Text = lbxKargoTuru.SelectedIndex.ToString();
        }

        private void BtnKTSil_Click(object sender, EventArgs e)
        {
            
        }
    }
}
