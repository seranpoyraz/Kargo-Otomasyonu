using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    public class Musteriler
    {
        int musteriID;
        string ad;
        string soyad;
        string adres;
        string telefon;

        public int MusteriID { get => musteriID; set => musteriID = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public Musteriler(int musteriID, string ad, string soyad, string adres, string telefon)
        {
            this.musteriID = musteriID;
            this.ad = ad;
            this.soyad = soyad;
            this.adres = adres;
            this.telefon = telefon;
        }

        public Musteriler(string ad, string soyad, string adres, string telefon)
        {
            
            this.ad = ad;
            this.soyad = soyad;
            this.adres = adres;
            this.telefon = telefon;
        }
    }
}
