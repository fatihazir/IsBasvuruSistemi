using System;
using System.Collections.Generic;

namespace VeriYapilari2
{
    public class Sirket
    {
        public int SirketID { get; set; }
        public string SirketAd { get; set; }
        public string SirketAdres { get; set; }
        public string SirketFax { get; set; }
        public string SirketTelefon { get; set; }
        public string SirketEposta { get; set; }

        public HashChain Ilanlar = new HashChain();
        public string sifre { get; set; }

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

        public bool BilgiGuncelle(string ad, string adres, string fax, string telefon, string eposta)
        {
            this.SirketAd = ad;
            this.SirketAdres = adres;
            this.SirketFax = fax;
            this.SirketEposta = eposta;
            this.SirketTelefon = telefon;
            return true;
        }

        public Sirket()
        {
            this.SirketID = RandomSirketId();
        }

        private int RandomSirketId()
        {
            Random queueNumber = new Random();
            int number = queueNumber.Next(5000, 6000);
            return number;
        }

        public bool SirketSil(int sirketID)
        {
            //BURADA MİNİK SİLME İŞLEMLERİ GERÇEKLEŞECEK
            return true;
        }
    }
}