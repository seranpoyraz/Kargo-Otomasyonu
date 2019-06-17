using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    class KargoTuru
    {
        int kargoTuruID;
        string icerik;

        public int KargoTuruID { get => kargoTuruID; set => kargoTuruID = value; }
        public string Icerik { get => icerik; set => icerik = value; }

        public KargoTuru(int kargoTuruID, string icerik)
        {
            this.kargoTuruID = kargoTuruID;
            this.icerik = icerik;
        }

        public KargoTuru(string icerik)
        {
            this.icerik = icerik;
        }

        public override string ToString()
        {
            return kargoTuruID.ToString();
        }
    }
}
