using System;

namespace VeriYapilari2
{
    public class Ilan
    {
        public int IlanNumarasi { get; set; }
        public string IsTanimi { get; set; }
        public string Pozisyon { get; set; }
        public string ArananElemanOzellikleri { get; set; }
        public Sirket IlaninSirketi { get; set; }

        public Ilan(string pozisyon, string isTanimi, string arananElemanOzellikleri, Sirket sirket)
        {
            this.IlanNumarasi = RandomIlanNumarasi();
            this.Pozisyon = pozisyon;
            this.IsTanimi = isTanimi;
            this.ArananElemanOzellikleri = arananElemanOzellikleri;
            this.IlaninSirketi = sirket; // Composition. Her ilanin bir sirketi olmak zorunda yani ilan yaratılırken sirketi ile yaratılır.
            // Ama tersi dogru degildir. Her sirketin ilanı olmak zoruna degildir.
        }

        private int RandomIlanNumarasi()
        {
            Random queueNumber = new Random();
            int number = queueNumber.Next(1000, 2000);
            return number;
        }

        public string IlanBilgileriYazdir()
        {
            string temp;
            temp = "Ilan numarasi :  " + IlanNumarasi + Environment.NewLine +
                   "Is tanimi : " + IsTanimi + Environment.NewLine +
                   "Aranan eleman ozellikleri : " + ArananElemanOzellikleri + Environment.NewLine +
                   IlaninSirketi.SirketBilgileriYazdir();

            return temp;
        }
    }
}