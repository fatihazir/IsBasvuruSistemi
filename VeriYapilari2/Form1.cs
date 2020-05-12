using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LinkedListTest_Click(object sender, EventArgs e)
        {
            IsDeneyimi birey = new IsDeneyimi();
            
            birey.IsyeriAd = "amazon";
            birey.IsyeriAdres = "kenya";
            birey.IsyeriCalismaYili = 4;
            birey.IsyerindekiPozisyonu = "Cayci";
            birey.KisininBolumeBaslangicYili = 40;
            birey.KisininBolumuBitirmeYili = 2028;
            birey.KisininEgitimDurumu = "Universite";
            birey.KisininNotOrtalamasi = 4.5;
            birey.KisininOkulAdi = "kenya caycilari dernegi";
            birey.KİsininOkulBolumu = "gastronomi";

            LinkedList lnkdlst = new LinkedList();
            lnkdlst.InsertFirst(birey.KisininBolumeBaslangicYili.ToString());
            lnkdlst.InsertFirst(birey.IsyeriAd);
            lnkdlst.InsertFirst(birey.IsyeriAdres);
            lnkdlst.InsertFirst(birey.KisininNotOrtalamasi.ToString());
            

            MessageBox.Show(lnkdlst.DisplayElements());



        }

        private void btnIlanSirketCompTest_Click(object sender, EventArgs e)
        {
            Sirket sirket = new Sirket();
            sirket.SirketAd = "fatihcomp";
            sirket.SirketAdres = "nergiz";
            sirket.SirketEposta = "fatihhazirceng";
            sirket.SirketTelefon = 45154;

            Ilan yeniIlan = new Ilan("Kundakci", "Kundaklayacak kisi", "10 yıl ve ustu kundakcilik tecrubesi", sirket);
            MessageBox.Show(yeniIlan.IlanBilgileriYazdir());

            HashChain hashChain = new HashChain();
            bool temp;

            temp = hashChain.AddIsIlani(yeniIlan.IlanNumarasi, yeniIlan);
            if (temp)
            {
                MessageBox.Show("is ilanı eklendi");
            }
            else
            {
                MessageBox.Show("ilan eklenemedi");
            }
        }
    }
}
