﻿using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class LoginFormu : Form
    {
        private DatabaseIslemleri db = new DatabaseIslemleri();
        private SirketAnaForm sirketFormu = new SirketAnaForm();
        private İkiliAramaAgacı _IkılıAramaAgaci = new İkiliAramaAgacı();

        public LoginFormu()
        {
            InitializeComponent();
        }

        private void btnSirketGirisi_Click(object sender, EventArgs e)
        {
            //"hayatsu@gmail.com" = txtSirketPosta.Text;
            //"hayat123" = txtSirketSifre.Text;
            string sirketEposta = txtSirketPosta.Text;
            string sifre = txtSirketSifre.Text;
            Sirket dbSirket = new Sirket();
            dbSirket = db.SirketGirisYap(sirketEposta, sifre);

            if (dbSirket.SirketAd != null)
            {
                sirketFormu.labelSirketIsmi.Text = dbSirket.SirketAd;
                sirketFormu.db = db;
                sirketFormu.sirketFormIci = dbSirket;
                sirketFormu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız!");
            }
        }

        private void btnSirketBilgiKaydet_Click(object sender, EventArgs e)
        {
            Sirket yeniSirket = new Sirket();
            yeniSirket.SirketEposta = txtSirketEPosta.Text;
            yeniSirket.SirketAd = txtSirketAd.Text;
            yeniSirket.SirketAdres = txtSirketAdres.Text;
            yeniSirket.SirketFax = txtSirketFax.Text;
            yeniSirket.SirketTelefon = txtSirketTelNo.Text;
            yeniSirket.sifre = txtSirketSifreKayit.Text;
            db.Sirketler.Add(yeniSirket);
            MessageBox.Show("Başarıyla yeni şirket eklendi!");
        }

        private void btnGirisYapKullanici_Click(object sender, EventArgs e)
        {
            KisiBilgileri kisi = new KisiBilgileri();
            kisi = db.DatabasedenIlkKisiCekimi();
            _IkılıAramaAgaci.Ekle(kisi.tcKimlikNumarasi, kisi);

            //336621312
            ulong tc = Convert.ToUInt32(txtTcNo.Text);
            string sifre = txtSifre.Text;

            kisi = _IkılıAramaAgaci.BireyselGirisYap(tc, sifre);

            if (kisi.ad != null)
            {
                KullaniciFormu kullaniciFormu = new KullaniciFormu();
                kullaniciFormu.formIciKisi = kisi;
                kullaniciFormu.db = db;
                kullaniciFormu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız.");
            }
        }

        private void btnBireyselKaydet_Click(object sender, EventArgs e)
        {
            string medeniDurum = "";
            switch (cmbKayitMedeniDurum.SelectedIndex)
            {
                case 0:
                    medeniDurum = "Bekar";
                    break;

                case 1:
                    medeniDurum = "Evli";
                    break;

                default:
                    break;
            }

            string uyruk = "";
            if (cmbKayitUyruk.SelectedIndex == 0)
            {
                uyruk = "TR";
            }
            else if (cmbKayitUyruk.SelectedIndex == 1)
            {
                uyruk = "KKTC";
            }
            else if (cmbKayitUyruk.SelectedIndex == 2)
            {
                uyruk = "Avrupa";
            }
            else if (cmbKayitUyruk.SelectedIndex == 3)
            {
                uyruk = "ABD";
            }
            else if (cmbKayitUyruk.SelectedIndex == 4)
            {
                uyruk = "İngiltere";
            }
            else
            {
                uyruk = "Diger";
            }
            KisiBilgileri kisi = new KisiBilgileri();
            kisi.ad = txtKayitAd.Text;
            kisi.soyad = txtKayitSoyad.Text;
            kisi.tcKimlikNumarasi = Convert.ToUInt32(txtTcNo.Text);
            kisi.dogumTarihi = txtKayitDogumTarih.Text;
            kisi.dogumYeri = txtKayitDogumYer.Text;
            kisi.telefon = txtKayitTelNo.Text;
            kisi.email = txtKayitEMail.Text;
            kisi.uyruk = uyruk;
            kisi.medeniDurum = medeniDurum;
            kisi.ilgiAlanlari = txtKayitIlgiAlan.Text;
            kisi.adres = txtKayitAdres.Text;
            kisi.yabanciDil = txtYabanciDil.Text;

            _IkılıAramaAgaci.Ekle(kisi.tcKimlikNumarasi, kisi);
        }

        

        
    }
}