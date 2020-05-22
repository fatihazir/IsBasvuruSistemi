namespace VeriYapilari2
{
    public class İkiliAramaAgacDugumu
    {
        public KisiBilgileri Kisi;
        public double Tc;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;

        public İkiliAramaAgacDugumu()
        {
        }

        public İkiliAramaAgacDugumu(double tc, KisiBilgileri kisi)
        {
            this.Kisi = kisi;
            this.Tc = tc;
            sol = null;
            sag = null;
        }
    }
}