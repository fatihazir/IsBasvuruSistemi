using System;
using System.Collections.Generic;

namespace VeriYapilari2
{
    public class DatabaseIslemleri : Sirket
    {
        public List<KisiBilgileri> Kisiler = new List<KisiBilgileri>();

        public List<Sirket> Sirketler = new List<Sirket>();

        private KisiBilgileri tempKisi = new KisiBilgileri();
        private Sirket tempSirket = new Sirket();

        public DatabaseIslemleri()
        {
            DatabasedenIlkKisiCekimi();
            DatabasedenIlkSirketCekimi();
        }

        public void DatabasedenIlkSirketCekimi()
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
                tempSirket.sifre = TempSirketBilgisi[6];
            }
            Sirketler.Add(tempSirket);
        }

        public void DatabasedenIlkKisiCekimi()
        {
            KisiBilgileri tempKisi = new KisiBilgileri();
            IsDeneyimi tempIsDeneyimi = new IsDeneyimi();
            LinkedList tempIsDeneyimiLinkedList = new LinkedList();

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
            Kisiler.Add(tempKisi);
        }

        public KisiBilgileri KisiGetir()
        {
            return tempKisi;
        }

        public Sirket SirketGetir()
        {
            return tempSirket;
        }

        public bool GirisYap(ulong tc, string sifre)
        {
            foreach (KisiBilgileri kisi in Kisiler)
            {
                if (kisi.tcKimlikNumarasi == tc && kisi.sifre == sifre)
                {
                    tempKisi = kisi;
                    return true;
                }
            }

            return false;
        }

        public bool GirisYap(string sirketAdi, string sifre)
        {
            foreach (Sirket sirket in Sirketler)
            {
                if (sirket.SirketAd == sirketAdi && sirket.sifre == sifre)
                {
                    tempSirket = sirket;
                    return true;
                }
            }

            return false;
        }
    }
}