using System;
using System.Collections.Generic;

namespace VeriYapilari2
{
    public class DatabaseIslemleri : Sirket
    {
        public List<KisiBilgileri> Kisiler = new List<KisiBilgileri>();

        public List<Sirket> Sirketler = new List<Sirket>();

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
                tempKisi.IsyeriAd = TempKisiBilgisi[11];
                tempKisi.IsyeriAdres = TempKisiBilgisi[12];
                tempKisi.IsyerindekiPozisyonu = TempKisiBilgisi[13];
                tempKisi.IsyeriCalismaYili = Convert.ToInt32(TempKisiBilgisi[14]);
                tempKisi.KisininEgitimDurumu = TempKisiBilgisi[15];
                tempKisi.KisininOkulAdi = TempKisiBilgisi[16];
                tempKisi.KİsininOkulBolumu = TempKisiBilgisi[17];
                tempKisi.KisininBolumeBaslangicYili = Convert.ToInt32(TempKisiBilgisi[18]);
                tempKisi.KisininBolumuBitirmeYili = Convert.ToInt32(TempKisiBilgisi[19]);
                tempKisi.KisininNotOrtalamasi = TempKisiBilgisi[20];
                tempKisi.tcKimlikNumarasi = Convert.ToInt32(TempKisiBilgisi[21]);
                tempKisi.sifre = TempKisiBilgisi[22];
            }
            Kisiler.Add(tempKisi);
        }

        public KisiBilgileri KisiGetir(int tc)
        {
            foreach (KisiBilgileri kisi in Kisiler)
            {
                if (kisi.tcKimlikNumarasi == tc)
                {
                    return kisi;
                }
            }

            KisiBilgileri bos = new KisiBilgileri();
            return bos;
        }

        public Sirket SirketGetir(string sirketAdi)
        {
            foreach (Sirket sirket in Sirketler)
            {
                if (sirket.SirketAd == sirketAdi)
                {
                    return sirket;
                }
            }

            Sirket bos = new Sirket();
            return bos;
        }

        public bool GirisYap(int tc, string sifre)
        {
            foreach (KisiBilgileri kisi in Kisiler)
            {
                if (kisi.tcKimlikNumarasi == tc && kisi.sifre == sifre)
                {
                    return true;
                }
            }

            return false;
        }

        public bool GirisYap(string sirketAdi)
        {
            foreach (Sirket sirket in Sirketler)
            {
                if (sirket.SirketAd == sirketAdi)
                {
                    return true;
                }
            }

            return false;
        }
    }
}