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
        public ulong Tc;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        private ulong deger;

        public İkiliAramaAgacDugumu()
        {
        }

        

        public İkiliAramaAgacDugumu(ulong tc, KisiBilgileri kisi)
        {
            this.Kisi = kisi;
            this.Tc = tc;
            sol = null;
            sag = null;
        }
    }
}
