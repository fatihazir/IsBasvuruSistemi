using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public class Sirket
    {
        public int SirketID { get; private set; }
        public string SirketAd { get; set; }
        public string SirketAdres { get; set; }
        public string SirketFax { get; set; }
        public string SirketTelefon { get; set; }
        public string SirketEposta { get; set; }
        public List<Ilan> Ilanlar = new List<Ilan>();

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

        public void DatabaseyeSirketEkle(Sirket sirket)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"SirketDb.txt", true);
                sw.WriteLine(sirket.SirketID.ToString() +
                             "," + sirket.SirketAd +
                             "," + sirket.SirketAdres +
                             "," + sirket.SirketFax +
                             "," + sirket.SirketTelefon +
                             "," + sirket.SirketEposta);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Islem Hatalı >> " + ex);
            }

            MessageBox.Show("Islem basarili.");
        }

        public List<Sirket> DatabasedenSirketCek()
        {
            List<Sirket> Sirketler = new List<Sirket>();
            Sirket tempSirket = new Sirket();
            string[] satirlar = System.IO.File.ReadAllLines("./SirketDb.txt");

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] TempSirketBilgisi = satirlar[i].Split(',');

                tempSirket.SirketID = Convert.ToInt32(TempSirketBilgisi[0]);
                tempSirket.SirketAd = TempSirketBilgisi[1];
                tempSirket.SirketAdres = TempSirketBilgisi[2];
                tempSirket.SirketFax = TempSirketBilgisi[3];
                tempSirket.SirketTelefon = TempSirketBilgisi[4];
                tempSirket.SirketEposta = TempSirketBilgisi[5];

                Sirketler.Add(tempSirket);
            }

            return Sirketler;
        }
    }
}