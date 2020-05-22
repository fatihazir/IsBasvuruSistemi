using System;
using System.Threading;

namespace VeriYapilari2
{
    public class Ilan
    {
        public int IlanNumarasi { get; set; }
        public string IsTanimi { get; set; }
        public string Pozisyon { get; set; }

        public string ArananElemanOzellikleri { get; set; }

        public string IlanSirketAd { get; set; }

        public Heap heap = new Heap(10);

        public Ilan()
        {
            this.IlanNumarasi = RandomIlanNumarasi();
        }

        private int RandomIlanNumarasi()
        {
            Thread.Sleep(20);
            Random queueNumber = new Random();
            int number = queueNumber.Next(1000, 2000);
            return number;
        }

        public string IlanBilgileriYazdir()
        {
            string temp;
            temp = "Ilan numarasi :  " + IlanNumarasi + Environment.NewLine +
                   "Is tanimi : " + IsTanimi + Environment.NewLine +
                   "Aranan eleman ozellikleri : " + ArananElemanOzellikleri;

            return temp;
        }
    }
}