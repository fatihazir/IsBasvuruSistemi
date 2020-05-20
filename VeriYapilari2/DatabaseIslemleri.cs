using System;
using System.Collections.Generic;

namespace VeriYapilari2
{
    public class DatabaseIslemleri : Sirket
    {

        public List<Sirket> Sirketler = new List<Sirket>();


        public DatabaseIslemleri()
        {
            
        }

        public Sirket DatabasedenIlkSirketCekimi()
        {
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
                return tempSirket;

            }

            return tempSirket; //BU CALISIRSA BOS DONECEKTİR.
        }

        public Ilan DatabasedenIlkIlanCekimi()
        {
            Ilan tempSirketIlani = new Ilan();

            string[] satirlar = System.IO.File.ReadAllLines("./IlanDb.txt");

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] TempSirketIlanlari = satirlar[i].Split(',');

                tempSirketIlani.IsTanimi = TempSirketIlanlari[0];
                tempSirketIlani.Pozisyon = TempSirketIlanlari[1];
                tempSirketIlani.ArananElemanOzellikleri = TempSirketIlanlari[2];

                return tempSirketIlani;
            }

            return tempSirketIlani; // BU CALISIRSA BOS DONECEKTİR.
        }

        public KisiBilgileri DatabasedenIlkKisiCekimi()
        {
            KisiBilgileri tempKisi = new KisiBilgileri();
            IsDeneyimi tempIsDeneyimi = new IsDeneyimi();
           

            string[] satirlar = System.IO.File.ReadAllLines("./KisiDb.txt");

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] TempKisiBilgisi = satirlar[i].Split(';');

                tempKisi.ad = TempKisiBilgisi[0];
                tempKisi.soyad = TempKisiBilgisi[1];
                tempKisi.adres = TempKisiBilgisi[2];
                tempKisi.telefon = TempKisiBilgisi[3];
                tempKisi.email = TempKisiBilgisi[4];
                tempKisi.uyruk = TempKisiBilgisi[5];
                tempKisi.dogumTarihi = TempKisiBilgisi[6];
                tempKisi.dogumYeri = TempKisiBilgisi[7];
                tempKisi.medeniDurum = TempKisiBilgisi[8];
                tempKisi.yabanciDil = TempKisiBilgisi[9];
                tempKisi.ilgiAlanlari = TempKisiBilgisi[10];

                tempIsDeneyimi.IsyeriAd = TempKisiBilgisi[11];
                tempIsDeneyimi.IsyeriAdres = TempKisiBilgisi[12];
                tempIsDeneyimi.IsyerindekiPozisyonu = TempKisiBilgisi[13];
                tempIsDeneyimi.IsyeriCalismaYili = Convert.ToInt32(TempKisiBilgisi[14]);
                tempIsDeneyimi.KisininEgitimDurumu = TempKisiBilgisi[15];
                tempIsDeneyimi.KisininOkulAdi = TempKisiBilgisi[16];
                tempIsDeneyimi.KisininOkulBolumu = TempKisiBilgisi[17];
                tempIsDeneyimi.KisininBolumeBaslangicYili = Convert.ToInt32(TempKisiBilgisi[18]);
                tempIsDeneyimi.KisininBolumuBitirmeYili = Convert.ToInt32(TempKisiBilgisi[19]);
                tempIsDeneyimi.KisininNotOrtalamasi = TempKisiBilgisi[20];

                tempKisi.IsDeneyimleri.InsertLast(tempIsDeneyimi);
                tempKisi.tcKimlikNumarasi = Convert.ToUInt32(TempKisiBilgisi[21]);
                tempKisi.sifre = TempKisiBilgisi[22];

            }

            return tempKisi; // donulen degeri ikili arama ağacına ekleyeceğiz.
        }


        

        public bool SirketGirisYap(string sirketAdi, string sifre)
        {
            foreach (Sirket sirket in Sirketler)
            {
                if (sirket.SirketAd == sirketAdi && sirket.sifre == sifre)
                {
                    
                    return true;
                }
            }

            return false;
        }
    }
}