using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class LoginFormu : Form
    {
        private DatabaseIslemleri db = new DatabaseIslemleri();

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
                SirketAnaForm sirketFormunuAc = new SirketAnaForm();
                sirketFormunuAc.labelSirketIsmi.Text = dbSirket.SirketAd;
                sirketFormunuAc.db = db;
                sirketFormunuAc.sirketFormIci = dbSirket;
                sirketFormunuAc.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız!");
            }
        }

        private void btnSirketBilgiKaydet_Click(object sender, EventArgs e)
        {
            Sirket apple = new Sirket();
            apple.SirketEposta = "deneme";
            apple.sifre = "123";
            apple.SirketAd = "ad";
            db.Sirketler.Add(apple);
        }

        private void LoginFormu_Load(object sender, EventArgs e)
        {
            

        }

        private void btnGirisYapKullanici_Click(object sender, EventArgs e)
        {
            //336621312
            ulong tc = Convert.ToUInt32(txtTcNo.Text);
            string sifre = txtSifre.Text;
            KisiBilgileri kisi = new KisiBilgileri();
            kisi = db.DatabasedenIlkKisiCekimi();
            İkiliAramaAgacDugumu ikiliAramaAgacDugumu = new İkiliAramaAgacDugumu(kisi.tcKimlikNumarasi, kisi);
            İkiliAramaAgacı dbIkılıAramaAgaci = new İkiliAramaAgacı(ikiliAramaAgacDugumu);
            kisi = dbIkılıAramaAgaci.BireyselGirisYap(tc, sifre);

            if (kisi.ad != null)
            {
                KullaniciFormu kullaniciFormu = new KullaniciFormu();
                kullaniciFormu.formIciKisi = kisi;
                kullaniciFormu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız.");
            }
        }
    }
}