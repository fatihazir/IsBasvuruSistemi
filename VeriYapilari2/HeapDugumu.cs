namespace VeriYapilari2
{
    public class HeapDugumu
    {
        public int IlanNumarasi { get; set; }
        public KisiBilgileri Kisi { get; set; }
        public int IseUygunluk { get; set; }

        public HeapDugumu(int ilanNo, KisiBilgileri kisi, int iseUygunluk)
        {
            this.IlanNumarasi = ilanNo;
            this.Kisi = kisi;
            this.IseUygunluk = iseUygunluk;
        }
    }
}