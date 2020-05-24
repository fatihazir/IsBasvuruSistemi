using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class LoginFormu : Form
    {
        private DatabaseIslemleri db = new DatabaseIslemleri();

        private SirketAnaForm sirketFormu = new SirketAnaForm();
        private KullaniciFormu kullaniciFormu = new KullaniciFormu();

        private İkiliAramaAgacı _IkılıAramaAgaci = new İkiliAramaAgacı();

        private KisiBilgileri kisi = new KisiBilgileri();

        public LoginFormu()
        {
            InitializeComponent();
        }

        private void btnSirketGirisi_Click(object sender, EventArgs e)
        {
            string sirketEposta = txtSirketPosta.Text;
            string sifre = txtSirketSifre.Text;
            Sirket dbSirket = new Sirket();
            dbSirket = db.SirketGirisYap(sirketEposta, sifre);

            if (dbSirket.SirketAd != null)
            {
                sirketFormu.labelSirketIsmi.Text = dbSirket.SirketAd;
                sirketFormu.db = db;
                sirketFormu.sirketFormIci = dbSirket;
                sirketFormu.ikiliAramaAgacı = _IkılıAramaAgaci;
                sirketFormu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız!");
            }
        }

        private void btnSirketBilgiKaydet_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            if (maskedSirketSifre.Text == maskedSirketSifreDogrula.Text)
            {
                kontrol = true;
            }

            if (maskedSirketSifre.Text != maskedSirketSifreDogrula.Text)
            {
                MessageBox.Show("Sifreler aynı değil. Lütfen dogru yazdıgınızdan emin olun.");
            }

            if (kontrol)
            {
                Sirket yeniSirket = new Sirket();
                yeniSirket.SirketEposta = txtSirketEPosta.Text;
                yeniSirket.SirketAd = txtSirketAd.Text;
                yeniSirket.SirketAdres = txtSirketAdres.Text;
                yeniSirket.SirketFax = txtSirketFax.Text;
                yeniSirket.SirketTelefon = txtSirketTelNo.Text;
                yeniSirket.sifre = maskedSirketSifreDogrula.Text;
                db.Sirketler.Add(yeniSirket);
                MessageBox.Show("Yeni şirket başarıyla eklendi!");
                MessageBox.Show("Bilgileriniz : "+ Environment.NewLine+ yeniSirket.SirketBilgileriYazdir());
                kontrol = false;
                MessageBox.Show("Lütfen giriş yap sekmesinden giriş yapınız.");
            }
            else
            {
                MessageBox.Show("Sirket eklenirken hata oldu. Lütfen verilerinizi gözden geçirip tekrar deneyin.");
            }
        }

        private void btnGirisYapKullanici_Click(object sender, EventArgs e)
        {
            double tc = Convert.ToDouble(txtTcNo.Text);
            string sifre = txtSifre.Text;

            kisi = _IkılıAramaAgaci.BireyselGirisYap(tc, sifre);

            if (kisi.ad != null)
            {
                kullaniciFormu.formIciKisi = kisi;
                kullaniciFormu.db = db;
                kullaniciFormu._ikiliAramaAgaci = _IkılıAramaAgaci;

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

            bool kontrol = false;
            if (maskedBireyselSifre.Text == maskedBireyselSifreDogrula.Text)
            {
                kontrol = true;
            }
            if (maskedBireyselSifre.Text != maskedBireyselSifreDogrula.Text)
            {
                MessageBox.Show("Sifreler aynı değil. Lütfen dogru yazdıgınızdan emin olun.");
            }

            if (kontrol)
            {
                KisiBilgileri kisi = new KisiBilgileri();
                kisi.ad = txtKayitAd.Text;
                kisi.soyad = txtKayitSoyad.Text;
                kisi.tcKimlikNumarasi = Convert.ToDouble(txtKayitTCKimlik.Text);
                kisi.dogumTarihi = txtKayitDogumTarih.Text;
                kisi.dogumYeri = txtKayitDogumYer.Text;
                kisi.telefon = txtKayitTelNo.Text;
                kisi.email = txtKayitEMail.Text;
                kisi.uyruk = uyruk;
                kisi.medeniDurum = medeniDurum;
                kisi.ilgiAlanlari = txtKayitIlgiAlan.Text;
                kisi.adres = txtKayitAdres.Text;
                kisi.yabanciDil = txtYabanciDil.Text.ToUpper();
                kisi.sifre = maskedBireyselSifreDogrula.Text;

                _IkılıAramaAgaci.Ekle(kisi.tcKimlikNumarasi, kisi);

                MessageBox.Show("Kayıt başarılı. Bilgileriniz: " + Environment.NewLine + kisi.KisiBilgileriYazdir());
                kontrol = false;
                MessageBox.Show("Lütfen giriş yap sekmesinden giriş yapınız.");
            }
            else
            {
                MessageBox.Show("Kayıt olurken hata meydana geldi. Lütfen verilerinizi dogru girdiğinize emin olun.");
            }
        }

        private void LoginFormu_Load(object sender, EventArgs e)
        {
            kisi = db.DatabasedenIlkKisiCekimi();
            _IkılıAramaAgaci.Ekle(kisi.tcKimlikNumarasi, kisi);
        }
    }
}