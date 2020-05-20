using System;
using System.Collections.Generic;
using System.Threading;

namespace VeriYapilari2
{
    public class KisiBilgileri
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string uyruk { get; set; }
        public string dogumTarihi { get; set; }
        public string dogumYeri { get; set; }
        public string medeniDurum { get; set; }
        public string yabanciDil { get; set; }
        public string ilgiAlanlari { get; set; }
        public int iseUygunlukDurumu { get; set; }
        public ulong tcKimlikNumarasi { get; set; }
        public string sifre { get; set; }

        public LinkedList IsDeneyimleri = new LinkedList();

        public KisiBilgileri BilgiGuncelle(string ad, string soyad, string adres, string telefon, string email, string uyruk,
                            string dogumTarihi, string dogumYeri, string medeniDurum, string yabanciDil,
                            string ilgliAlanlari)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.adres = adres;
            this.telefon = telefon;
            this.email = email;
            this.uyruk = uyruk;
            this.dogumTarihi = dogumTarihi;
            this.dogumYeri = dogumYeri;
            this.medeniDurum = medeniDurum;
            this.yabanciDil = yabanciDil;
            this.ilgiAlanlari = ilgliAlanlari;
            
        }

        private int RandomIsUygunluk()
        {
            Thread.Sleep(20);
            Random queueNumber = new Random();
            int number = queueNumber.Next(0, 10);
            return number;
        }

        public string KisiBilgileriYazdir()
        {
            string temp;
            temp = "Kişinin Adı: " + ad + Environment.NewLine +
                   "Kişinin Soyadı: " + soyad + Environment.NewLine +
                   "Tc kimlik numrasi: " + tcKimlikNumarasi + Environment.NewLine +
                   "Kişinin Adresi: " + adres + Environment.NewLine +
                   "Kişinin Telefonu: " + telefon + Environment.NewLine +
                   "Kişinin Email Adresi: " + email + Environment.NewLine +
                   "Kişinin Uyruğu: " + uyruk + Environment.NewLine +
                   "Kişinin Doğum Tarihi: " + dogumTarihi + Environment.NewLine +
                   "Kişinin Doğum Yeri: " + dogumYeri + Environment.NewLine +
                   "Kişinin Medeni Durumu: " + medeniDurum + Environment.NewLine +
                   "Kişinin Yabancı Dil veya Dilleri: " + yabanciDil + Environment.NewLine +
                   "Kişinin İlgi Alanları: " + ilgiAlanlari + Environment.NewLine +
                   "Kişinin İşe Uygunluk Durumu: " + iseUygunlukDurumu;
            return temp;
        }

        public KisiBilgileri()
        {
            this.iseUygunlukDurumu = RandomIsUygunluk();
        }
    }
}