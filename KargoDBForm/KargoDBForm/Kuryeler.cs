using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    class Kuryeler
    {
        int kuryeID;
        int subeID;
        string ad;
        string soyad;

        public Kuryeler(int subeID, string ad, string soyad)
        {
            this.subeID = subeID;
            this.ad = ad;
            this.soyad = soyad;
        }

        public Kuryeler(int kuryeID, int subeID, string ad, string soyad)
        {
            this.kuryeID = kuryeID;
            this.subeID = subeID;
            this.ad = ad;
            this.soyad = soyad;
        }

        public int KuryeID { get => kuryeID; set => kuryeID = value; }
        public int SubeID { get => subeID; set => subeID = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
    }
}
