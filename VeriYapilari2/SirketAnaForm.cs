﻿using System;
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

        public DatabaseIslemleri db { get; set; }
        public Sirket sirketFormIci { get; set; }

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
                item.SubItems.Add(ilan.ArananElemanOzellikleri);
                item.SubItems.Add(ilan.Pozisyon);
                item2.SubItems.Add(ilan.IsTanimi);
                item2.SubItems.Add(ilan.ArananElemanOzellikleri);
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
            ListViewItem theClickedItem = listViewIlanlarDuzenlemeBolmesi.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                int ilanNumarasi;
                ilanNumarasi = Convert.ToInt32(theClickedItem.Text);
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanNumarasi);
                richTextBoxIsTanimiIlanDuzenle.Text = ilan.IsTanimi;
                richTextBoxArananElemanOzellikleriIlanDuzenle.Text = ilan.ArananElemanOzellikleri;
                txtPozisyonIlanDuzenle.Text = ilan.Pozisyon;
            }
        }

        private void btnIlaniDuzenle_Click(object sender, EventArgs e)
        {
            Ilan ilan = new Ilan();
            ilan.IsTanimi = richTextBoxIsTanimiIlanDuzenle.Text;
            ilan.ArananElemanOzellikleri = richTextBoxArananElemanOzellikleriIlanDuzenle.Text;
            ilan.Pozisyon= txtPozisyonIlanDuzenle.Text;
            ListViewItem theClickedtwo = listViewIlanlarDuzenlemeBolmesi.FocusedItem;
            int ilanID = Convert.ToInt32(theClickedtwo.Text);
            sirketFormIci.Ilanlar.IsIlaniGuncelle(ilanID,ilan);
            MessageBox.Show("Başarıyla ilanınızı güncellediniz!");
            ilanListele();
        }

        private void listViewIlanlarIsAlmaBolmesi_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem theClickedItem = listViewIlanlarIsAlmaBolmesi.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                listViewEnUygunKisi.Items.Clear();
                int ilanID;
                ilanID = Convert.ToInt32(theClickedItem.Text);
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanID);
                // başvuranlar heap ağacından çekilecek

                //sonra aşağıda item olarak eklenecek
                ListViewItem item = new ListViewItem(ilan.IlanNumarasi.ToString());
                item.SubItems.Add(ilan.IsTanimi);
                listViewEnUygunKisi.Items.Add(item);
                
                
            }
        }
    }
}
