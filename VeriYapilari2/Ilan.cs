using System;

namespace VeriYapilari2
{
    public class Ilan : Sirket
    {
        public int IlanNumarasi { get; set; }
        public string IsTanimi { get; set; }
        public string Pozisyon { get; set; }
        public string ArananElemanOzellikleri { get; set; }

        public Ilan(string pozisyon, string isTanimi, string arananElemanOzellikleri, int sirketId, string sirketAd, string sirketAdres, double sirketTelefon, string sirketEposta)
        {
            this.IlanNumarasi = RandomIlanNumarasi();
            this.Pozisyon = pozisyon;
            this.IsTanimi = isTanimi;
            this.ArananElemanOzellikleri = arananElemanOzellikleri;
            this.SirketID = sirketId;
            this.SirketAd = sirketAd;
            this.SirketAdres = sirketAdres;
            this.SirketTelefon = sirketTelefon;
            this.SirketEposta = sirketEposta;
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