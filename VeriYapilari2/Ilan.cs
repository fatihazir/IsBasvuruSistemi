using System;
using System.Net.Security;

namespace VeriYapilari2
{
    public class Ilan : Sirket
    {
        public int IlanNumarasi { get; set; }
        public string IsTanimi { get; set; }
        public string Pozisyon { get; set; }
        public int IlaninIsyeriIdsi { get; set; }
        public string ArananElemanOzellikleri { get; set; }

        public Ilan(Sirket sirket)
        {
            this.IlanNumarasi = RandomIlanNumarasi();
            this.IlaninIsyeriIdsi = sirket.SirketID;
            this.SirketAd = sirket.SirketAd;
            this.SirketAdres = sirket.SirketAdres;
            this.SirketEposta = sirket.SirketEposta;
            this.SirketFax = sirket.SirketFax;
            this.SirketTelefon = sirket.SirketTelefon;
            
        }

        private int RandomIlanNumarasi()
        {
            Random queueNumber = new Random();
            int number = queueNumber.Next(1000, 2000);
            return number;
        }

        public string IlanBilgileriYazdir()
        {
            string temp;
            temp = "Ilan numarasi :  " + IlanNumarasi + Environment.NewLine +
                   "Is tanimi : " + IsTanimi + Environment.NewLine +
                   "Aranan eleman ozellikleri : " + ArananElemanOzellikleri + Environment.NewLine +
                   "Sirket ıd : " + SirketID + Environment.NewLine +
                   "Sirket ad : " + SirketAd + Environment.NewLine +
                   "Sirket adres : " + SirketAdres + Environment.NewLine +
                   "Sirket telefon : " + SirketTelefon + Environment.NewLine +
                   "Sirket eposta : " + SirketEposta;

            return temp;
        }
    }
}