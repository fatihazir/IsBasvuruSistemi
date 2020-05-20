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
            int cmbSelectedIndex;
            if (uyluk == "TR")
            {
                cmbSelectedIndex = 0;
            }
            else if (uyluk == "KKTC")
            {
                cmbSelectedIndex = 1;
            }
            else if (uyluk == "Avrupa")
            {
                cmbSelectedIndex = 2;
            }
            else if (uyluk == "ABD")
            {
                
            }

            txtAd.Text = _kisiBilgileri.ad;
            txtSoyad.Text = _kisiBilgileri.soyad;
            txtAdres.Text = _kisiBilgileri.adres;
            txtTelefon.Text = _kisiBilgileri.telefon;
            txtEMail.Text = _kisiBilgileri.email;
            cmbUyruk.SelectedIndex = cmbSelectedIndex;

        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            

        }

        private void brnKisiBilgiSil_Click(object sender, EventArgs e)
        {

        }
    }
}
