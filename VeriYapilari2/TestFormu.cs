using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class TestFormu : Form
    {
        public TestFormu()
        {
            InitializeComponent();
        }
        private DatabaseIslemleri db = new DatabaseIslemleri();
        private void btnSirketIlanTest_Click(object sender, EventArgs e)
        {
            Sirket sirket1 = new Sirket();
            sirket1.SirketAd = "Fatih company";
            sirket1.SirketAdres = "izmir";

            Ilan ilan1 = new Ilan(sirket1);
            ilan1.IsTanimi = "kolee";
            ilan1.ArananElemanOzellikleri = "nefes alsın";
            ilan1.Pozisyon = "kucak";

            sirket1.Ilanlar.Add(ilan1);

            Ilan ilan2 = new Ilan(sirket1);
            ilan2.IsTanimi = "hizmetkar";
            ilan2.ArananElemanOzellikleri = "nefes versin";
            ilan2.Pozisyon = "baş";

            sirket1.Ilanlar.Add(ilan2);

            KisiBilgileri kisi = new KisiBilgileri();
            kisi.ad = "hayat";
            kisi.email = "hayatkisi@gmail.com";
            db.Kisiler.Add(kisi);

            MessageBox.Show(ilan2.IlanBilgileriYazdir());
        }

        private void btnTxtDb_Click(object sender, EventArgs e)
        {
        }

        private void btnSirketCekmeTesti_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKisiCekmeTesti_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

        }
    }
}