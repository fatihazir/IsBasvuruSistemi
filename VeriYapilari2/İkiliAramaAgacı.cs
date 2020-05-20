using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
   public class İkiliAramaAgacı
    {
         private İkiliAramaAgacDugumu kok;
        private string dugumler;

       
        
        public İkiliAramaAgacı()
        {
        }
        public void ElemanlarıGetir()
        {
                
            
        }
        public İkiliAramaAgacı(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi (İkiliAramaAgacDugumu dugum)
        {
            throw new NotImplementedException();

        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            throw new NotImplementedException();
  
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            //dugumler += dugum.veri + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(ulong deger, KisiBilgileri kisi)
        {
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            İkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (deger == (ulong)tempSearch.Tc)
                    return;
                else if (deger < (ulong)tempSearch.Tc)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger, kisi);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (deger < (ulong)tempParent.Tc)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }

    
        public İkiliAramaAgacDugumu Ara(ulong tc)
        {
            return AraInt(kok, tc);
        }
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum, 
                                            ulong tc)
        {
            if (dugum == null)
                return null;
            else if ((ulong)dugum.Tc== tc)
                return dugum;
            else if ((ulong)dugum.Tc > tc)
                return (AraInt(dugum.sol, tc));
            else
                return (AraInt(dugum.sag, tc));
        }

        public İkiliAramaAgacDugumu KisiBilgileriniBul (ulong tc)
        {
            İkiliAramaAgacDugumu  tempDugum = new İkiliAramaAgacDugumu();
            tempDugum = Ara(tc);

            return tempDugum;
        }

        public KisiBilgileri BireyselGirisYap(ulong tc, string sifre)
        {
            İkiliAramaAgacDugumu tempDugum = new İkiliAramaAgacDugumu();
            tempDugum = KisiBilgileriniBul(tc);

            if (tempDugum.Kisi.sifre == sifre)
            {
                return tempDugum.Kisi;
            }
            else
            {
                KisiBilgileri bos = new KisiBilgileri();
                return bos;
            }

        }

        public void KisiGuncelle(ulong tc, KisiBilgileri kisi)
        {
            Ara(tc).Kisi = kisi;
        }




    }
}
