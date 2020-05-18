using System;
using System.Collections.Generic;

namespace VeriYapilari2
{
    public class DatabaseIslemleri : Sirket
    {
        public List<Sirket> DatabasedenSirketleriCek()
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

        public List<KisiBilgileri> DatabasedenKisileriCek()
        {
            List<KisiBilgileri> Kisiler = new List<KisiBilgileri>();
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
                tempKisi.kisiId = Convert.ToInt32(TempKisiBilgisi[21]);

                Kisiler.Add(tempKisi);
            }

            return Kisiler;
        }
    }
}