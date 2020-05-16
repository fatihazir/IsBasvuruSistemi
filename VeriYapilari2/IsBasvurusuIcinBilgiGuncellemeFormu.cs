using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class IsBasvurusuIcinBilgiGuncellemeFormu : Form
    {
        public IsBasvurusuIcinBilgiGuncellemeFormu()
        {
            InitializeComponent();
        }

        // Kisinin cekilmesi. Ve kisi'ye esitlenmesi.

        private KisiBilgileri kisi = new KisiBilgileri();

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            string medeniDurum = " ";
            switch (cmbKisiMedeniDurum.SelectedIndex)
            {
                case 0:
                    medeniDurum = "Evli";
                    break;

                case 1:
                    medeniDurum = "Bekar";
                    break;

                case 2:
                    medeniDurum = "Belirsiz";
                    break;

                default:
                    break;
            }

            kisi.BilgiGuncelle(txtKisiAd.Text, txtKisiSoyad.Text, txtKisiAdres.Text,
                                                        txtKisiTelefon.Text, txtKisiEmail.Text,
                                                        txtKisiUyruk.Text, txtKisiDogumTarihi.Text,
                                                        txtKisiDogumYeri.Text, medeniDurum, txtKisiYabanciDil.Text,
                                                        txtKisiIlgiAlanlari.Text);
        }

        private void IsBasvurusuIcinBilgiGuncellemeFormu_Load(object sender, EventArgs e)
        {
            int medeniDurum = 0;
            kisi.ad = "fat";

            switch (kisi.medeniDurum)
            {
                case "Evli":
                    medeniDurum = 0;
                    break;

                case "Bekar":
                    medeniDurum = 1;
                    break;

                case "Belirsiz":
                    medeniDurum = 2;
                    break;

                default:
                    break;
            }

            txtKisiAd.Text = kisi.ad;
            txtKisiSoyad.Text = kisi.soyad;
            txtKisiTelefon.Text = kisi.telefon;
            txtKisiEmail.Text = kisi.email;
            txtKisiDogumTarihi.Text = kisi.dogumTarihi;
            txtKisiDogumYeri.Text = kisi.dogumYeri;
            txtKisiTelefon.Text = kisi.telefon;
            txtKisiUyruk.Text = kisi.uyruk;
            txtKisiIlgiAlanlari.Text = kisi.ilgliAlanlari;
            cmbKisiMedeniDurum.SelectedIndex = medeniDurum;
        }
    }
}