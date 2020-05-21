﻿using System.Collections.Generic;

namespace VeriYapilari2
{
    public class İkiliAramaAgacı
    {
        private İkiliAramaAgacDugumu kok;

        private int dugumSayaci;

        private List<İkiliAramaAgacDugumu> InOrderDugumlerListesi = new List<İkiliAramaAgacDugumu>();
        private List<İkiliAramaAgacDugumu> PreOrderDugumlerListesi = new List<İkiliAramaAgacDugumu>();
        private List<İkiliAramaAgacDugumu> PostOrderDugumlerListesi = new List<İkiliAramaAgacDugumu>();

        public İkiliAramaAgacı()
        {
        }

        public İkiliAramaAgacı(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }

        public int DugumlerinSayisiniGetir()
        {
            InOrder();
            return dugumSayaci;
        }

        public void PreOrder()
        {
            PreOrderInt(kok);
        }

        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            ZiyaretPreOrder(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }

        private void ZiyaretPreOrder(İkiliAramaAgacDugumu dugum)
        {
            dugumSayaci++;
            PreOrderDugumlerListesi.Add(dugum);
        }

        public List<İkiliAramaAgacDugumu> PreOrderListesiniGetir()
        {
            PreOrder();
            return PreOrderDugumlerListesi;
        }

        public void InOrder()
        {
            dugumSayaci = 0;
            InOrderInt(kok);
        }

        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            ZiyaretInOrder(dugum);
            InOrderInt(dugum.sag);
        }

        private void ZiyaretInOrder(İkiliAramaAgacDugumu dugum)
        {
            dugumSayaci++;
            InOrderDugumlerListesi.Add(dugum);
        }

        public List<İkiliAramaAgacDugumu> InOrderListesiniGetir()
        {
            InOrder();
            return InOrderDugumlerListesi;
        }

        public void PostOrder()
        {
            PostOrderInt(kok);
        }

        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            ZiyaretPreOrder(dugum);
        }

        private void ZiyaretPostOrder(İkiliAramaAgacDugumu dugum)
        {
            dugumSayaci++;
            PostOrderDugumlerListesi.Add(dugum);
        }

        public List<İkiliAramaAgacDugumu> PostOrderListesiniGetir()
        {
            PostOrder();
            return PostOrderDugumlerListesi;
        }

        private int derinlik = -1;

        public int DerinligiGetir()
        {
            return derinlik;
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
                {
                    if (tempSearch.sag == null && tempSearch.sol == null)
                    {
                        derinlik++;
                    }
                    tempSearch = tempSearch.sol;
                }
                else
                {
                    if (tempSearch.sag == null && tempSearch.sol == null)
                    {
                        derinlik++;
                    }
                    tempSearch = tempSearch.sag;
                }
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger, kisi);
            //Ağaç boş, köke ekle
            if (kok == null)
            {
                kok = eklenecek;
                derinlik++;
            }
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
            else if ((ulong)dugum.Tc == tc)
                return dugum;
            else if ((ulong)dugum.Tc > tc)
                return (AraInt(dugum.sol, tc));
            else
                return (AraInt(dugum.sag, tc));
        }

        public İkiliAramaAgacDugumu KisiBilgileriniBul(ulong tc)
        {
            İkiliAramaAgacDugumu tempDugum = new İkiliAramaAgacDugumu();
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

        public void KisiIsDeneyimiEkle(ulong tc, IsDeneyimi isDeneyimi)
        {
            Ara(tc).Kisi.IsDeneyimleri.InsertLast(isDeneyimi);
        }

        private bool parentBuyukMu = false;
        private İkiliAramaAgacDugumu araParent = new İkiliAramaAgacDugumu();

        public bool Sil(ulong tc)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while ((ulong)current.Tc != tc)
            {
                parent = current;
                if (tc < (ulong)current.Tc)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (issol)
                {
                    parent.sol = null;
                    parent.Kisi = null;
                    parent.Tc = 0;
                }
                else
                {
                    parent.sag = null;
                    parent.Kisi = null;
                    parent.Tc = 0;
                }
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if ((ulong)parent.Tc > tc)
                {
                    parent.sol = current.sol;
                    parent.Kisi = null;
                    parent.Tc = 0;
                }
                else
                {
                    parent.sag = current.sol;
                    parent.Kisi = null;
                    parent.Tc = 0;
                }
            }
            else if (current.sol == null)
            {
                if ((ulong)parent.Tc < tc)
                {
                    parent.sag = current.sag;
                    parent.Kisi = null;
                    parent.Tc = 0;
                }
                else
                {
                    parent.sol = current.sag;
                    parent.Kisi = null;
                    parent.Tc = 0;
                }
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                İkiliAramaAgacDugumu successor = Successor(current);

                current.Tc = successor.Tc;
                successor = null;

                if (parentBuyukMu)
                {
                    araParent.sol = successor.sag;
                }
            }
            return true;
            parentBuyukMu = false;
        }

        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            return MinDeger(silDugum.sag);
        }

        public İkiliAramaAgacDugumu MinDeger(İkiliAramaAgacDugumu temp)
        {
            if (temp.sol == null)
            {
                return temp;
            }
            while (temp.sol != null)
            {
                var tempParent = temp.sol;
                if ((ulong)temp.Tc > (ulong)tempParent.Tc)
                {
                    parentBuyukMu = true;
                    araParent = temp;
                }
                else
                {
                    parentBuyukMu = false;
                }

                temp = temp.sol;
            }
            return temp;
        }

        public void IsDeneyimiEkle(ulong tc, IsDeneyimi isDeneyimi)
        {
            Ara(tc).Kisi.IsDeneyimleri.InsertLast(isDeneyimi);
        }

        public void IsDeneyiminiGuncelle(ulong tc, int isDeneyimiId, IsDeneyimi isDeneyimi)
        {
            Ara(tc).Kisi.IsDeneyimleri.GetElement(isDeneyimiId).Data = isDeneyimi;
        }

        public void IsDeneyimiGuncelle(ulong tc, int isDeneyimiId, IsDeneyimi isDeneyimi)
        {
            Ara(tc).Kisi.IsDeneyimleri.GetElement(isDeneyimiId).Data = isDeneyimi;
        }
    }
}