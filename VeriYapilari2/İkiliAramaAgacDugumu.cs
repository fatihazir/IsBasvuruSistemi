using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
   public class İkiliAramaAgacDugumu
   {

        public KisiBilgileri Kisi;
        public object veri;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        public İkiliAramaAgacDugumu()
        {
        }

        public İkiliAramaAgacDugumu(object veri, KisiBilgileri kisi)
        {
            this.Kisi = kisi;
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}
