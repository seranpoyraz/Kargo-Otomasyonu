using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoDBForm
{
    public class Kargo
    {
        int kargoID;
        int aliciID;
        int gondericiID;
        int kargoturuID;
        DateTime teslimTarih;
        decimal desi;
        decimal agirlik;
        bool kimOdeyecek;
        decimal ucret;

        public Kargo(int kargoID, DateTime teslimTarih)
        {
            this.kargoID = kargoID;
            this.teslimTarih = teslimTarih;
        }

        public Kargo(int aliciID, int gondericiID, int kargoturuID, decimal desi, decimal agirlik, bool kimOdeyecek, decimal ucret)
        {
            this.aliciID = aliciID;
            this.gondericiID = gondericiID;
            this.kargoturuID = kargoturuID;
            this.desi = desi;
            this.agirlik = agirlik;
            this.kimOdeyecek = kimOdeyecek;
            this.ucret = ucret;
        }

        public Kargo(int aliciID, int gondericiID, int kargoturuID, DateTime teslimtarih, decimal desi, decimal agirlik, bool kimOdeyecek, decimal ucret)
        {
            this.aliciID = aliciID;
            this.gondericiID = gondericiID;
            this.kargoturuID = kargoturuID;
            this.teslimTarih = teslimtarih;
            this.desi = desi;
            this.agirlik = agirlik;
            this.kimOdeyecek = kimOdeyecek;
            this.ucret = ucret;
        }

        public Kargo(int kargoID, int aliciID, int gondericiID, int kargoturuID, DateTime teslimtarihi, decimal desi, decimal agirlik, bool kimOdeyecek, decimal ucret)
        {
            this.kargoID = kargoID;
            this.aliciID = aliciID;
            this.gondericiID = gondericiID;
            this.kargoturuID = kargoturuID;
            this.teslimTarih = teslimtarihi;
            this.desi = desi;
            this.agirlik = agirlik;
            this.kimOdeyecek = kimOdeyecek;
            this.ucret = ucret;
        }

        public int KargoID { get => kargoID; set => kargoID = value; }
        public int AliciID { get => aliciID; set => aliciID = value; }
        public int GondericiID { get => gondericiID; set => gondericiID = value; }
        public int KargoturuID { get => kargoturuID; set => kargoturuID = value; }
        public DateTime Teslimtarih { get => teslimTarih; set => teslimTarih = value; }
        public decimal Desi { get => desi; set => desi = value; }
        public decimal Agirlik { get => agirlik; set => agirlik = value; }
        public bool KimOdeyecek { get => kimOdeyecek; set => kimOdeyecek = value; }
        public decimal Ucret { get => ucret; set => ucret = value; }
    }
}
