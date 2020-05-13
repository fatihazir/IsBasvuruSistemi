using System;

namespace VeriYapilari2
{
    public class Sirket
    {
        public int SirketID { get; set; }
        public string SirketAd { get; set; }
        public string SirketAdres { get; set; }
        public double SirketTelefon { get; set; }
        public string SirketEposta { get; set; }

        public string SirketBilgileriYazdir()
        {
            string temp;
            temp = "Sirket Id :  " + SirketID + Environment.NewLine +
                   "Sirket ad : " + SirketAd + Environment.NewLine +
                   "Sirket adres : " + SirketAdres + Environment.NewLine +
                   "Sirket telefon : " + SirketTelefon + Environment.NewLine +
                   "Sirket eposta : " + SirketEposta;

            return temp;
        }
    }
}