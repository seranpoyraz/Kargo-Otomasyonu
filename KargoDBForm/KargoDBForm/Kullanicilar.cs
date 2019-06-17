using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    public class Kullanicilar
    {
        int kullaniciID;
        string kullaniciAdi;
        string sifre;
        string yetki;

        public Kullanicilar(string kullaniciAdi, string sifre)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
        }

        public Kullanicilar(string kullaniciAdi, string sifre, string yetki)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public Kullanicilar(int kullaniciID, string kullaniciAdi, string sifre, string yetki)
        {
            this.kullaniciID = kullaniciID;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public int KullaniciID { get => kullaniciID; set => kullaniciID = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Yetki { get => yetki; set => yetki = value; }
    }
}
