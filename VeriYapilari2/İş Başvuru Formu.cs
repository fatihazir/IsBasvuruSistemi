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
    public partial class KullaniciFormu : Form
    {
        public KullaniciFormu()
        {
            InitializeComponent();
        }
        İkiliAramaAgacı _ikiliAramaAgaci = new İkiliAramaAgacı();
        DatabaseIslemleri _databaseIslemleri = new DatabaseIslemleri();
        KisiBilgileri _kisiBilgileri = new KisiBilgileri();

        

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
            else if(uyluk == "Diger")
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

        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            

        }

        private void brnKisiBilgiSil_Click(object sender, EventArgs e)
        {

        }
    }
}
