using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    public class KHareketleri
    {
        int hareketID;
        int kargoID;
        int kuryeID;
        string durum;

        public KHareketleri(int kargoID, string durum)
        {
            this.kargoID = kargoID;
            this.durum = durum;
        }

        public KHareketleri(int kargoID, int kuryeID, string durum)
        {
            this.kargoID = kargoID;
            this.kuryeID = kuryeID;
            this.durum = durum;
        }

        public KHareketleri(int hareketID, int kargoID, int kuryeID, string durum)
        {
            this.hareketID = hareketID;
            this.kargoID = kargoID;
            this.kuryeID = kuryeID;
            this.durum = durum;
        }

        public int HareketID { get => hareketID; set => hareketID = value; }
        public int KargoID { get => kargoID; set => kargoID = value; }
        public int KuryeID { get => kuryeID; set => kuryeID = value; }
        public string Durum { get => durum; set => durum = value; }
    }
}
