using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    public class Subeler
    {
        int subeID;
        string ad;
        string telefon;
        string adres;

        public int SubeID { get => subeID; set => subeID = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }

        public Subeler(int subeID, string ad, string telefon, string adres)
        {
            this.subeID = subeID;
            this.ad = ad;
            this.telefon = telefon;
            this.adres = adres;
        }

        public Subeler(string ad, string telefon, string adres)
        {
            this.ad = ad;
            this.telefon = telefon;
            this.adres = adres;
        }
    }
}
