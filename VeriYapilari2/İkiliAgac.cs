using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
   public class İkiliAgac
    {
        private İkiliAgacDugumu kok;
        private string dugumler;
        public object sol { get; private set; }

        public object sag { get; private set; }

        public İkiliAgac(İkiliAgacDugumu kok)
        {
            this.kok = kok;
        }
       
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        private int DugumSayisi(İkiliAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }

        private int YaprakSayisi(İkiliAgacDugumu kok)
        {
            throw new NotImplementedException();
        }

        public int YaprakSayisi(İkiliAgac dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }

        private int YaprakSayisi(object sol)
        {
            throw new NotImplementedException();
        }

        public string DugumleriYazdir()
        {
            return dugumler;
        }
        //Gezinme İşlemleri
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAgacDugumu dugum)
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
        private void InOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAgacDugumu dugum)
        {
            dugumler += dugum.veri + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
    }
}
