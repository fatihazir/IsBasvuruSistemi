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
    public partial class SirketAnaForm : Form
    {
        // Şirket bilgilerinin çekilmesi. Ve sirket'e eşi.

        private DatabaseIslemleri db = new DatabaseIslemleri();
        private Sirket sirketFormIci = new Sirket();

        public void ilanListele()
        {
            listViewIlanlarDuzenlemeBolmesi.Items.Clear();
            listViewIlanlarIsAlmaBolmesi.Items.Clear();
            Ilan ilan = new Ilan();
            for (int i = 0; i < 10; i++)
            {
                ilan = sirketFormIci.Ilanlar.GetIsIlaniForEditingAndListing(i);
                if (ilan == null)
                {
                    continue;
                }
                ListViewItem item = new ListViewItem(ilan.IlanNumarasi.ToString());
                ListViewItem item2 = new ListViewItem(ilan.IlanNumarasi.ToString());
                item.SubItems.Add(ilan.IsTanimi);
                item.SubItems.Add(ilan.ArananElemanOzellikleri);  //www.yazilimkodlama.com
                item.SubItems.Add(ilan.Pozisyon);
                item2.SubItems.Add(ilan.IsTanimi);
                item2.SubItems.Add(ilan.ArananElemanOzellikleri);  //www.yazilimkodlama.com
                item2.SubItems.Add(ilan.Pozisyon);
                listViewIlanlarDuzenlemeBolmesi.Items.Add(item);
                listViewIlanlarIsAlmaBolmesi.Items.Add(item2);
            }
        }

        public SirketAnaForm()
        {
            InitializeComponent();
            
            
        }

        private void sirketBilgiGuncelleButon_Click(object sender, EventArgs e)
        {
            string yeniSirketAd, yeniSirketAdres, yeniSirketEPosta, yeniSirketFax;
            string yeniSirketTelefon;
            yeniSirketAd = txtSirketAdi.Text;
            yeniSirketAdres = richTxtSirketAdres.Text;
            yeniSirketEPosta = txtSirketEPosta.Text;
            yeniSirketFax = txtSirketFax.Text;
            yeniSirketTelefon = txtSirketTelefon.Text;

            if (sirketFormIci.BilgiGuncelle(yeniSirketAd, yeniSirketAdres,
            yeniSirketFax, yeniSirketTelefon, yeniSirketEPosta))
            {
                MessageBox.Show("Şirket bilgileri güncellendi!");
            }
            else
            {
                MessageBox.Show("Şirket bilgisi güncellenirken hata oluştu!");
            }
        }

        private void sirketSilButon_Click(object sender, EventArgs e)
        {
            int sirketID = sirketFormIci.SirketID;
            if (db.DatabasedenSirketSilme(sirketID))
            {
                MessageBox.Show("Şirket başarıyla silindi, giriş ekranına yönlendiriliyorsunuz.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Şirket silinirken hata oluştu!");
            }
        }

        private void sirketYeniIlanVerButon_Click(object sender, EventArgs e)
        {
            //veriler çekilip yeni bir ilan oluşturlacak. veriler Hash table a atılacak
            string ilanTanimi, arananElamanOzellikleri, pozisyon;
            ilanTanimi = richTxtYeniIsIlani.Text;
            arananElamanOzellikleri = richTxtYeniArananEleman.Text;
            pozisyon = txtYeniIlanPozisyon.Text;
            //aga burayı kontrol et yanlış olabilir
            Ilan yeniIlan = new Ilan();
            yeniIlan.IsTanimi = ilanTanimi;
            yeniIlan.Pozisyon = pozisyon;
            yeniIlan.ArananElemanOzellikleri = arananElamanOzellikleri;
            if (sirketFormIci.Ilanlar.AddIsIlani(yeniIlan.IlanNumarasi, yeniIlan, sirketFormIci))
            {
                MessageBox.Show("Başarıyla yeni bir ilan eklendi!");
                ilanListele();
            }
            else
            {
                MessageBox.Show("İlan eklenirken bir sorun ortaya çıktı!");
            }
            
        }

        private void ilanIseAlButon_Click(object sender, EventArgs e)
        {
            //en uygun kişi masked text boxundan kişi, ilan ve şirket bilgileri çekilir,
            //ilan güncellenir
            //kişi güncellenir
            int kisiID;
            int ilanID;
            int sirketID;
            //ilan.BilgiGuncelle(ilanID); //burada ilanın bilgisi güncellenebilir "iş verildi" gibi
        }

        private void ilanSilButon_Click(object sender, EventArgs e)
        {
            //tıklanan ilan bilgisi çekilir
            //silinecek ilanın bilgileri "Silindi" olarak güncellenir (bu gerekli mi emin değilim)
            //ilgili ilan silinir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EN AZ 2 YIL İŞ DENEYİMİNE SAHİP OLAN İLANLAR LİSTELENECEK VE LİSTVİEW İÇİNE YAZILACAK
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //YABANCI DİLİ OLANLAR LİSTELENECEK VE LİSTVİEW İÇİNE YAZILACAK
        }

        private void SirketAnaForm_Load(object sender, EventArgs e)
        {
            foreach (Sirket sirket in db.Sirketler)
            {
                if (sirket.SirketAd == labelSirketIsmi.Text)
                {
                    sirketFormIci = sirket;
                    break;
                }
            }
            txtSirketAdi.Text = sirketFormIci.SirketAd;
            richTxtSirketAdres.Text = sirketFormIci.SirketAdres;
            txtSirketEPosta.Text = sirketFormIci.SirketEposta;
            txtSirketFax.Text = sirketFormIci.SirketFax;
            txtSirketTelefon.Text = sirketFormIci.SirketTelefon;
            ilanListele();
        }

        private void btnIlanIncele_Click(object sender, EventArgs e)
        {
            ListViewItem theClickedtwo = listViewIlanlarDuzenlemeBolmesi.FocusedItem;
            if (theClickedtwo == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                int ilanID;
                ilanID = Convert.ToInt32(theClickedtwo.Text);
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanID);
                richTextBoxIsTanimiIlanDuzenle.Text = ilan.IsTanimi;
                richTextBoxArananElemanOzellikleriIlanDuzenle.Text = ilan.ArananElemanOzellikleri;
                txtPozisyonIlanDuzenle.Text = ilan.Pozisyon;
            }
        }

        private void btnIlaniDuzenle_Click(object sender, EventArgs e)
        {
            string isTanimi = richTextBoxIsTanimiIlanDuzenle.Text;
            string arananElemanOzellikleri = richTextBoxArananElemanOzellikleriIlanDuzenle.Text;
            string pozisyon = txtPozisyonIlanDuzenle.Text;
            ListViewItem theClickedtwo = listViewIlanlarDuzenlemeBolmesi.FocusedItem;
            int ilanID;
            ilanID = Convert.ToInt32(theClickedtwo.Text);
            Ilan ilan = new Ilan();
            ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanID);
            ilan.IsTanimi = isTanimi;
            ilan.ArananElemanOzellikleri = arananElemanOzellikleri;
            ilan.Pozisyon = pozisyon;
            MessageBox.Show("Başarıyla ilanınızı güncellediniz!");
            ilanListele();
        }
    }
}
