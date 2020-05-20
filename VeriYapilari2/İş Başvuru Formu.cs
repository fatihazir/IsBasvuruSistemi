using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class KullaniciFormu : Form
    {
        public KullaniciFormu()
        {
            InitializeComponent();
        }

        private İkiliAramaAgacı _ikiliAramaAgaci = new İkiliAramaAgacı();
        private DatabaseIslemleri _databaseIslemleri = new DatabaseIslemleri();
        private KisiBilgileri _kisiBilgileri = new KisiBilgileri();
       
        Sirket _sirket = new Sirket();

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }

        private void İş_Başvuru_Formu_Load(object sender, EventArgs e)
        {
            //Login kısmında olacak
            _kisiBilgileri = _databaseIslemleri.DatabasedenIlkKisiCekimi();
            _ikiliAramaAgaci.Ekle(_kisiBilgileri.tcKimlikNumarasi, _kisiBilgileri);

            string uyluk = _kisiBilgileri.uyruk;
            int cmbUyrukSelectedIndex = 0;
            if (uyluk == "TR")
            {
                cmbUyrukSelectedIndex = 0;
            }
            else if (uyluk == "KKTC")
            {
                cmbUyrukSelectedIndex = 1;
            }
            else if (uyluk == "Avrupa")
            {
                cmbUyrukSelectedIndex = 2;
            }
            else if (uyluk == "ABD")
            {
                cmbUyrukSelectedIndex = 3;
            }
            else if (uyluk == "İngiltere")
            {
                cmbUyrukSelectedIndex = 4;
            }
            else
            {
                cmbUyrukSelectedIndex = 5;
            }

            string medeniDurum = _kisiBilgileri.medeniDurum;
            int cmbMedeniSelectedIndex = 0;

            if (medeniDurum == "Bekar")
            {
                cmbMedeniSelectedIndex = 0;
            }
            else if (medeniDurum == "Evli")
            {
                cmbMedeniSelectedIndex = 1;
            }

            txtAd.Text = _kisiBilgileri.ad;
            txtSoyad.Text = _kisiBilgileri.soyad;
            txtAdres.Text = _kisiBilgileri.adres;
            txtTelefon.Text = _kisiBilgileri.telefon;
            txtEMail.Text = _kisiBilgileri.email;
            cmbUyruk.SelectedIndex = cmbUyrukSelectedIndex;
            txtDogumTarih.Text = _kisiBilgileri.dogumTarihi;
            txtDogumYeri.Text = _kisiBilgileri.dogumYeri;
            cmbMedeniDurum.SelectedIndex = cmbMedeniSelectedIndex;
            txtTCKimlik.Text = Convert.ToString(_kisiBilgileri.tcKimlikNumarasi);
            txtIlgiAlan.Text = _kisiBilgileri.ilgiAlanlari;
            txtYabanciDil.Text = _kisiBilgileri.yabanciDil;

            dgvIlanlar.DataSource = _sirket.Ilanlar.GetIsIlaniForEditingAndListing();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string medeniDurum = "";
            switch (cmbUyruk.SelectedIndex)
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
            if (cmbUyruk.SelectedIndex == 0)
            {
                uyruk = "TR";
            }
            else if (cmbUyruk.SelectedIndex == 1)
            {
                uyruk = "KKTC";
            }
            else if (cmbUyruk.SelectedIndex == 2)
            {
                uyruk = "Avrupa";
            }
            else if (cmbUyruk.SelectedIndex == 3)
            {
                uyruk = "ABD";
            }
            else if (cmbUyruk.SelectedIndex == 4)
            {
                uyruk = "İngiltere";
            }
            else
            {
                uyruk = "Diger";
            }

            _kisiBilgileri.ad = txtAd.Text;
            _kisiBilgileri.soyad = txtSoyad.Text;
            _kisiBilgileri.adres = txtAdres.Text;
            _kisiBilgileri.telefon = txtTelefon.Text;
            _kisiBilgileri.email = txtEMail.Text;
            _kisiBilgileri.medeniDurum = medeniDurum;
            _kisiBilgileri.dogumTarihi = txtDogumTarih.Text;
            _kisiBilgileri.dogumYeri = txtDogumYeri.Text;
            _kisiBilgileri.ilgiAlanlari = txtIlgiAlan.Text;
            _kisiBilgileri.yabanciDil = txtYabanciDil.Text;
            _kisiBilgileri.uyruk = uyruk;

            _ikiliAramaAgaci.KisiGuncelle(_kisiBilgileri.tcKimlikNumarasi, _kisiBilgileri);
        }

        private void brnKisiBilgiSil_Click(object sender, EventArgs e)
        {
            _ikiliAramaAgaci.Sil(_kisiBilgileri.tcKimlikNumarasi);
        }

        private void dgvIlanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}