using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    class KHareketleriJoin
    {
        int hareketID;
        int KargoID;
        string gönderici;
        string alici;
        DateTime teslimTarihi;
        int kuryeID;
        string kuryeAdSoyad;
        int subeID;
        string subeAdi;
        string durumu;

        public KHareketleriJoin(int hareketID, int kargoID, string gönderici, string alici, DateTime teslimTarihi, int kuryeID, string kuryeAdSoyad, int subeID, string subeAdi, string durumu)
        {
            this.hareketID = hareketID;
            KargoID = kargoID;
            this.gönderici = gönderici;
            this.alici = alici;
            this.teslimTarihi = teslimTarihi;
            this.kuryeID = kuryeID;
            this.kuryeAdSoyad = kuryeAdSoyad;
            this.subeID = subeID;
            this.subeAdi = subeAdi;
            this.durumu = durumu;
        }

        public int HareketID { get => hareketID; set => hareketID = value; }
        public int KargoID1 { get => KargoID; set => KargoID = value; }
        public string Gönderici { get => gönderici; set => gönderici = value; }
        public string Alici { get => alici; set => alici = value; }
        public DateTime TeslimTarihi { get => teslimTarihi; set => teslimTarihi = value; }
        public int KuryeID { get => kuryeID; set => kuryeID = value; }
        public string KuryeAdSoyad { get => kuryeAdSoyad; set => kuryeAdSoyad = value; }
        public int SubeID { get => subeID; set => subeID = value; }
        public string SubeAdi { get => subeAdi; set => subeAdi = value; }
        public string Durumu { get => durumu; set => durumu = value; }
    }
}
