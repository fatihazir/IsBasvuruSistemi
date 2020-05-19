using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public class HeapDugumu
    {
        public int IlanNumarasi { get; set; }
        public KisiBilgileri Kisi { get; set; }
        public int IseUygunluk { get; set; }
        public HeapDugumu(int deger,KisiBilgileri kisi, int iseUygunluk)
        {
            this.IlanNumarasi = deger;
            this.Kisi = kisi;
            this.IseUygunluk = iseUygunluk;
        }
    }
}
