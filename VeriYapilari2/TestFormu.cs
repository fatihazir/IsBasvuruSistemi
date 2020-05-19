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
        private void BtnAraDugumEkle_Click(object sender, EventArgs e)
        {

            KisiBilgileri kisi1 = new KisiBilgileri();
            KisiBilgileri kisi2 = new KisiBilgileri();
            KisiBilgileri kisi3 = new KisiBilgileri();
            KisiBilgileri kisi4 = new KisiBilgileri();
            KisiBilgileri kisi5 = new KisiBilgileri();
            KisiBilgileri kisi6 = new KisiBilgileri();

            ulong tc1, tc2, tc3, tc4, tc5, tc6;
            tc1 = kisi1.tcKimlikNumarasi = 121;
            tc2 = kisi2.tcKimlikNumarasi = 122;
            tc3 = kisi3.tcKimlikNumarasi = 80;
            tc4 = kisi4.tcKimlikNumarasi = 124;
            tc5 = kisi5.tcKimlikNumarasi = 125;
            tc6 = kisi6.tcKimlikNumarasi = 126;

            aramaAgaci.Ekle(tc1);
            aramaAgaci.Ekle(tc2);
            aramaAgaci.Ekle(tc3);
            aramaAgaci.Ekle(tc4);
            aramaAgaci.Ekle(tc5);
            aramaAgaci.Ekle(tc6);
           
        }
        private void BtnDugumAra_Click(object sender, EventArgs e)
        {
       
            if (aramaAgaci == null)
            {
                MessageBox.Show("Öncelikle ağacı oluşturmalısınız!");
                return;
            }

            İkiliAramaAgacDugumu dugum = aramaAgaci.Ara(Convert.ToUInt32(txtAra.Text));
            if (dugum != null)
                MessageBox.Show(dugum.veri + " düğümü bulundu.");
            else
                MessageBox.Show(txtAra.Text + " düğümü bulunamadı....");
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}