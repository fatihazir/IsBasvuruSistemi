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
            db.Sirketler.Add(sirket1);

            Ilan ilan2 = new Ilan(sirket1);
            ilan2.IsTanimi = "hizmetkar";
            ilan2.ArananElemanOzellikleri = "nefes versin";
            ilan2.Pozisyon = "baş";

            HashChain hashTable = new HashChain();
            hashTable.AddIsIlani(ilan1.IlanNumarasi, ilan1);
            hashTable.AddIsIlani(ilan2.IlanNumarasi, ilan2);




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

            İkiliAramaAgacı aramaAgaci = new İkiliAramaAgacı();
        
        private void BtnDugumAra_Click(object sender, EventArgs e)
        {
       
            if (aramaAgaci == null)
            {
                MessageBox.Show("Öncelikle ağacı oluşturmalısınız!");
                return;
            }

            //İkiliAramaAgacDugumu dugum = aramaAgaci.Ara(Convert.ToUInt32(txtAra.Text));
            //if (dugum != null)
            //    MessageBox.Show(dugum.veri + " düğümü bulundu.");
            //else
            //    MessageBox.Show(txtAra.Text + " düğümü bulunamadı....");
        }

        private void BtnAraDugumEkle_Click_(object sender, EventArgs e)
        {
            KisiBilgileri kisi4 = new KisiBilgileri();
            KisiBilgileri kisi5 = new KisiBilgileri();
            KisiBilgileri kisi6 = new KisiBilgileri();



            kisi4.tcKimlikNumarasi = 124;
            kisi4.ad = "fatih";
            kisi5.tcKimlikNumarasi = 125;
            kisi5.ad = "burak";
            kisi6.tcKimlikNumarasi = 126;
            kisi6.ad = "emre";

            aramaAgaci.Ekle(kisi4.tcKimlikNumarasi, kisi4);
            aramaAgaci.Ekle(kisi5.tcKimlikNumarasi, kisi5);
            aramaAgaci.Ekle(kisi6.tcKimlikNumarasi, kisi6);
        }
    }
}