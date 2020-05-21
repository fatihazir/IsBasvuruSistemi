using System;
using System.Threading;

namespace VeriYapilari2
{
    public class IsDeneyimi
    {
        public int IsDeneyimId { get; set; }
        public string IsyeriAd { get; set; }
        public string IsyeriAdres { get; set; }
        public string IsyerindekiPozisyonu { get; set; }
        public int IsyeriCalismaYili { get; set; }
        public string KisininEgitimDurumu { get; set; }
        public string KisininOkulAdi { get; set; }
        public string KisininOkulBolumu { get; set; }
        public int KisininBolumeBaslangicYili { get; set; }
        public int KisininBolumuBitirmeYili { get; set; }
        public string KisininNotOrtalamasi { get; set; }

        public IsDeneyimi()
        {
            this.IsDeneyimId = RandomDeneyimId();
        }

        private int RandomDeneyimId()
        {
            Thread.Sleep(20);
            Random queueNumber = new Random();
            int number = queueNumber.Next(0, 10);
            return number;
        }
    }
}