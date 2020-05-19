using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class TestFormu : Form
    {
        public TestFormu()
        {
            InitializeComponent();
        }
        private DatabaseIslemleri db = new DatabaseIslemleri();
        private void btnSirketIlanTest_Click(object sender, EventArgs e)
        {
            Sirket sirket1 = new Sirket();
            sirket1.SirketAd = "Fatih company";
            sirket1.SirketAdres = "izmir";

            Ilan ilan1 = new Ilan(sirket1);
            ilan1.IsTanimi = "kolee";
            ilan1.ArananElemanOzellikleri = "nefes alsın";
            ilan1.Pozisyon = "kucak";
            db.Sirketler.Add(sirket1);

            Ilan ilan2 = new Ilan(sirket1);
            ilan2.IsTanimi = "hizmetkar";
            ilan2.ArananElemanOzellikleri = "nefes versin";
            ilan2.Pozisyon = "baş";

           




            MessageBox.Show(ilan2.IlanBilgileriYazdir());
        }

        private void btnTxtDb_Click(object sender, EventArgs e)
        {
        }

        private void btnSirketCekmeTesti_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKisiCekmeTesti_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

        }

            İkiliAramaAgacı aramaAgaci = new İkiliAramaAgacı();
        

        private void BtnDugumAra_Click(object sender, EventArgs e)
        {
            if (aramaAgaci == null)
            {
                MessageBox.Show("Öncelikle ağacı oluşturmalısınız!");
                return;
            }

            İkiliAramaAgacDugumu dugum = aramaAgaci.Ara(Convert.ToUInt32(txtAra.Text));
            if (dugum != null)
                MessageBox.Show(dugum.veri + " düğümü bulundu.");
            else
                MessageBox.Show(txtAra.Text + " düğümü bulunamadı....");
        }

        private void BtnAraDugumEkle_Click(object sender, EventArgs e)
        {
            KisiBilgileri kisi1 = new KisiBilgileri();
            KisiBilgileri kisi2 = new KisiBilgileri();
            KisiBilgileri kisi3 = new KisiBilgileri();
            KisiBilgileri kisi4 = new KisiBilgileri();
            KisiBilgileri kisi5 = new KisiBilgileri();
            KisiBilgileri kisi6 = new KisiBilgileri();

            ulong tc1, tc2, tc3, tc4, tc5, tc6;
            tc1 = kisi1.tcKimlikNumarasi = 121;
            tc2 = kisi2.tcKimlikNumarasi = 122;
            tc3 = kisi3.tcKimlikNumarasi = 80;
            tc4 = kisi4.tcKimlikNumarasi = 124;
            tc5 = kisi5.tcKimlikNumarasi = 125;
            tc6 = kisi6.tcKimlikNumarasi = 126;

            aramaAgaci.Ekle(tc1, kisi1);
            aramaAgaci.Ekle(tc2, kisi2);
            

        }

        private void btnFatihTest_Click(object sender, EventArgs e)
        {
            KisiBilgileri fatih = new KisiBilgileri();  //Kisi sorunsuz.
            fatih.ad = "fatih";
            fatih.soyad = "soyad";
            fatih.adres = "goncalar";
            fatih.dogumTarihi = "05.01.200";
            fatih.email = "fatihhazirceng@gmail";
            fatih.medeniDurum = "bekar";
            fatih.ilgiAlanlari = "kitap, dizi, kod";
            fatih.yabanciDil = "ing, tr, arapca, lehce";

            IsDeneyimi ilkIs = new IsDeneyimi(); // is deneyimi sorunsuz.
            ilkIs.IsyeriAdres = "alsancak";
            ilkIs.IsyerindekiPozisyonu = "gelistrici";
            ilkIs.IsyeriCalismaYili = 4;
            ilkIs.KisininEgitimDurumu = "universite";
            ilkIs.KisininOkulAdi = "bakırcay";
            ilkIs.KisininNotOrtalamasi = "3";
            ilkIs.KisininBolumuBitirmeYili = 2022;

            IsDeneyimi ikinciIs = new IsDeneyimi();
            ikinciIs.IsyeriAdres = "konak";
            ikinciIs.IsyerindekiPozisyonu = "gelistrici";
            ikinciIs.IsyeriCalismaYili = 6;
            ikinciIs.KisininEgitimDurumu = "universite";
            ikinciIs.KisininOkulAdi = "bakırcay";
            ikinciIs.KisininNotOrtalamasi = "3";
            ikinciIs.KisininBolumuBitirmeYili = 2022;

            fatih.IsDeneyimleri.InsertLast(ilkIs);  // linkedlist sorunsuz.
            fatih.IsDeneyimleri.InsertLast(ikinciIs);

            Sirket Atolye15 = new Sirket(); // Sirket olusturma basarili.
            Atolye15.SirketAd = "atolye15";
            Atolye15.SirketAdres = "alsancak";
            Atolye15.SirketEposta = "info.atolye";
            Atolye15.SirketFax = "456789";
            Atolye15.SirketTelefon = "5557468255";
            


            Ilan ilkIlan = new Ilan(Atolye15);
            ilkIlan.ArananElemanOzellikleri = "adam ol";
            ilkIlan.IsTanimi = "gelistirici";
            ilkIlan.Pozisyon = "gelistriric";

            Ilan ikincIlan = new Ilan(Atolye15);
            ikincIlan.ArananElemanOzellikleri = "temizlikci";
            ikincIlan.IsTanimi = "temizlikci";
            ikincIlan.Pozisyon = "temilikci";

            HashChain hash = new HashChain();
            hash.AddIsIlani(ilkIlan.IlanNumarasi, ilkIlan);
            hash.AddIsIlani(ikincIlan.IlanNumarasi, ikincIlan);

            Heap heap = new Heap(10); // Heap başarili.
            heap.Insert(ilkIlan.IlanNumarasi, fatih, fatih.iseUygunlukDurumu);

        }
    }
}