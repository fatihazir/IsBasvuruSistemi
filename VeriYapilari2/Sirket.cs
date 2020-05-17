using System;

namespace VeriYapilari2
{
    public class Sirket
    {
        public int SirketID { get; set; }
        public string SirketAd { get; set; }
        public string SirketAdres { get; set; }
        public string SirketFax { get; set; }
        public double SirketTelefon { get; set; }
        public string SirketEposta { get; set; }

        public string SirketBilgileriYazdir()
        {
            string temp;
            temp = "Sirket Id :  " + SirketID + Environment.NewLine +
                   "Sirket ad : " + SirketAd + Environment.NewLine +
                   "Sirket adres : " + SirketAdres + Environment.NewLine +
                   "Sirket fax : " + SirketFax + Environment.NewLine +
                   "Sirket telefon : " + SirketTelefon + Environment.NewLine +
                   "Sirket eposta : " + SirketEposta;

            return temp;
        }
        public int BilgiGuncelle(string ad, string adres, string fax, double telefon, string eposta)
        {
            this.SirketAd = ad;
            this.SirketAdres = adres;
            this.SirketFax = fax;
            this.SirketEposta = eposta;
            this.SirketTelefon = telefon;
            return 1;
        }

        public int SirketSil(int sirketID)
        {
            //BURADA MİNİK SİLME İŞLEMLERİ GERÇEKLEŞECEK
            return 1;
        }
    }
}