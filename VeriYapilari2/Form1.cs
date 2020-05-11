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
    }
}
