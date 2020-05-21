using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class KullaniciFormu : Form
    {
        public DatabaseIslemleri db { get; set; }
        public KisiBilgileri formIciKisi { get; set; }
        public KullaniciFormu()
        {
            InitializeComponent();
        }

        private İkiliAramaAgacı _ikiliAramaAgaci = new İkiliAramaAgacı();
       
        Sirket _sirket = new Sirket();

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }

        private void İş_Başvuru_Formu_Load(object sender, EventArgs e)
        {

            string uyluk = formIciKisi.uyruk;
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

            string medeniDurum = formIciKisi.medeniDurum;
            int cmbMedeniSelectedIndex = 0;

            if (medeniDurum == "Bekar")
            {
                cmbMedeniSelectedIndex = 0;
            }
            else if (medeniDurum == "Evli")
            {
                cmbMedeniSelectedIndex = 1;
            }

            txtAd.Text = formIciKisi.ad;
            txtSoyad.Text = formIciKisi.soyad;
            txtAdres.Text = formIciKisi.adres;
            txtTelefon.Text = formIciKisi.telefon;
            txtEMail.Text = formIciKisi.email;
            cmbUyruk.SelectedIndex = cmbUyrukSelectedIndex;
            txtDogumTarih.Text = formIciKisi.dogumTarihi;
            txtDogumYeri.Text = formIciKisi.dogumYeri;
            cmbMedeniDurum.SelectedIndex = cmbMedeniSelectedIndex;
            txtTCKimlik.Text = Convert.ToString(formIciKisi.tcKimlikNumarasi);
            txtIlgiAlan.Text = formIciKisi.ilgiAlanlari;
            txtYabanciDil.Text = formIciKisi.yabanciDil;

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

            formIciKisi.ad = txtAd.Text;
            formIciKisi.soyad = txtSoyad.Text;
            formIciKisi.adres = txtAdres.Text;
            formIciKisi.telefon = txtTelefon.Text;
            formIciKisi.email = txtEMail.Text;
            formIciKisi.medeniDurum = medeniDurum;
            formIciKisi.dogumTarihi = txtDogumTarih.Text;
            formIciKisi.dogumYeri = txtDogumYeri.Text;
            formIciKisi.ilgiAlanlari = txtIlgiAlan.Text;
            formIciKisi.yabanciDil = txtYabanciDil.Text;
            formIciKisi.uyruk = uyruk;

            _ikiliAramaAgaci.KisiGuncelle(formIciKisi.tcKimlikNumarasi, formIciKisi);
        }

        private void brnKisiBilgiSil_Click(object sender, EventArgs e)
        {
            _ikiliAramaAgaci.Sil(formIciKisi.tcKimlikNumarasi);
        }

        private void dgvIlanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}