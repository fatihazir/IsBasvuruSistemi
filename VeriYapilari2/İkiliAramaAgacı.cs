using System.Collections.Generic;

namespace VeriYapilari2
{
    public class İkiliAramaAgacı
    {
        public İkiliAramaAgacDugumu kok;

        private int dugumSayaci;

        public List<İkiliAramaAgacDugumu> InOrderDugumlerListesi = new List<İkiliAramaAgacDugumu>();
        public List<İkiliAramaAgacDugumu> PreOrderDugumlerListesi = new List<İkiliAramaAgacDugumu>();
        public List<İkiliAramaAgacDugumu> PostOrderDugumlerListesi = new List<İkiliAramaAgacDugumu>();

        public İkiliAramaAgacı()
        {
        }

        public İkiliAramaAgacı(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }

        public int DugumlerinSayisiniGetir()
        {
            dugumSayaci = 0
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

        public void PreOrderListesiniGetir()
        {
            PreOrder();
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

        public void InOrderListesiniGetir()
        {
            InOrder();
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
            ZiyaretPostOrder(dugum);
        }

        private void ZiyaretPostOrder(İkiliAramaAgacDugumu dugum)
        {
            dugumSayaci++;
            PostOrderDugumlerListesi.Add(dugum);
        }

        public void PostOrderListesiniGetir()
        {
            PostOrder();
        }

        public int maxDepth(İkiliAramaAgacDugumu node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = maxDepth(node.sag);
                int rDepth = maxDepth(node.sol);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }
        public void Ekle(double deger, KisiBilgileri kisi)
        {
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            İkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (deger == (double)tempSearch.Tc)
                    return;
                else if (deger < (double)tempSearch.Tc)
                {
                    tempSearch = tempSearch.sol;
                }
                else
                {
                    tempSearch = tempSearch.sag;
                }
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger, kisi);
            //Ağaç boş, köke ekle
            if (kok == null)
            {
                kok = eklenecek;
            }
            else if (deger < (double)tempParent.Tc)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }

        public İkiliAramaAgacDugumu Ara(double tc)
        {
            return AraInt(kok, tc);
        }

        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum,
                                            double tc)
        {
            if (dugum == null)
                return null;
            else if ((double)dugum.Tc == tc)
                return dugum;
            else if ((double)dugum.Tc > tc)
                return (AraInt(dugum.sol, tc));
            else
                return (AraInt(dugum.sag, tc));
        }

        public İkiliAramaAgacDugumu KisiBilgileriniBul(double tc)
        {
            İkiliAramaAgacDugumu tempDugum = new İkiliAramaAgacDugumu();
            tempDugum = Ara(tc);

            return tempDugum;
        }

        public KisiBilgileri BireyselGirisYap(double tc, string sifre)
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

        public void KisiGuncelle(double tc, KisiBilgileri kisi)
        {
            Ara(tc).Kisi = kisi;
        }

        private bool parentBuyukMu = false;
        private İkiliAramaAgacDugumu araParent = new İkiliAramaAgacDugumu();

        public bool Sil(double tc)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while ((double)current.Tc != tc)
            {
                parent = current;
                if (tc < (double)current.Tc)
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
                if ((double)parent.Tc > tc)
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
                if ((double)parent.Tc < tc)
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
                if ((double)temp.Tc > (double)tempParent.Tc)
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

        public void IsDeneyimiEkle(double tc, IsDeneyimi isDeneyimi)
        {
            Ara(tc).Kisi.IsDeneyimleri.InsertLast(isDeneyimi);
        }
    }
}