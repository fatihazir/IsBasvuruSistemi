namespace VeriYapilari2
{
    public class HashChainEntry
    {
        private string durum;

        private int anahtar;

        private object deger;

        private HashChainEntry next;

        private Sirket sirket;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }

        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }

        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }

        public HashChainEntry Next
        {
            get { return next; }
            set { next = value; }
        }

        public HashChainEntry(int anahtar, object deger, string durum, Sirket sirket)
        {
            this.anahtar = anahtar;
            this.durum = durum;
            this.deger = deger;
            this.next = null;
            this.sirket = sirket;
        }
    }
}