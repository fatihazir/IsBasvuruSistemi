using System;
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
        public double tcKimlikNumarasi { get; set; }
        public string sifre { get; set; }

        public LinkedList IsDeneyimleri = new LinkedList();

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
                   "Kişinin İlgi Alanları: " + ilgiAlanlari;
            return temp;
        }

        public KisiBilgileri()
        {
            this.iseUygunlukDurumu = RandomIsUygunluk();
        }
    }
}