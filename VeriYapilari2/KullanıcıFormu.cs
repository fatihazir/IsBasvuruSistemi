using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class KullaniciFormu : Form
    {
        public DatabaseIslemleri db { get; set; }

        public KisiBilgileri formIciKisi { get; set; }

        private İkiliAramaAgacı _ikiliAramaAgaci = new İkiliAramaAgacı();
        private IsDeneyimi _isDeneyimi = new IsDeneyimi();

        //private Ilan _ilan = new Ilan();
        public void ilanListele()
        {
            listViewKullaniciIlanlarBolmesi.Items.Clear();
            Ilan ilan = new Ilan();
            foreach (Sirket sirket in db.Sirketler)
            {
                for (int i = 0; i < 10; i++)
                {
                    ilan = sirket.Ilanlar.GetIsIlaniForEditingAndListing(i);
                    if (ilan == null)
                    {
                        continue;
                    }

                    int sayac = 0;
                   
                        foreach (var item in ilan.heap.heapArray)
                        {
                            if (item == null)
                            {
                                continue;
                            }
                            else if (item.Kisi.tcKimlikNumarasi != formIciKisi.tcKimlikNumarasi)
                            {
                                
                                ListViewItem temp = new ListViewItem(ilan.IlanNumarasi.ToString());
                                temp.SubItems.Add(ilan.IsTanimi);
                                temp.SubItems.Add(ilan.ArananElemanOzellikleri);
                                temp.SubItems.Add(ilan.Pozisyon);
                                listViewKullaniciIlanlarBolmesi.Items.Add(temp);

                            }

                            else if ()
                            {
                                
                            }

                            sayac++;
                        } 
                    
                }
            }
        }

        public KullaniciFormu()
            {
                InitializeComponent();
            }

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
                ilanListele();
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

            private void btnIlanGuncelle_Click(object sender, EventArgs e)
            {
                ilanListele();
                MessageBox.Show("İlanlar başarıyla güncellendi!");
            }

            private void btnIlanBasvur_Click(object sender, EventArgs e)
            {
                ListViewItem theClickedItem = listViewKullaniciIlanlarBolmesi.FocusedItem;
                if (theClickedItem == null)
                {
                    MessageBox.Show("Lütfen bir ilana tıklayınız!");
                }
                else
                {
                    int ilanID;
                    ilanID = Convert.ToInt32(theClickedItem.Text);
                    foreach (Sirket sirket in db.Sirketler)
                    {
                        Ilan ilan = new Ilan();
                        ilan = sirket.Ilanlar.GetIsIlani(ilanID);
                        if (ilan.IsTanimi == null)
                        {
                            break;
                        }
                        //_ilan.heap.Insert(ilanID, _kisiBilgileri, _kisiBilgileri.iseUygunlukDurumu);
                        ilan.heap.Insert(ilan.IlanNumarasi, formIciKisi, formIciKisi.iseUygunlukDurumu);
                    }

                    //MessageBox.Show("İlan ID" + _ilanID.ToString() + " Burada bu numarayı işleyip başvurmamız lazım.");
                }
            }

            private void btnIsDeneyimiKaydet_Click(object sender, EventArgs e)
            {
                _isDeneyimi.IsyeriAd = txtIsyeriAd.Text;
                _isDeneyimi.IsyeriAdres = txtIsyeriAdres.Text;
                _isDeneyimi.IsyerindekiPozisyonu = txtIsyeriPozisyon.Text;
                _isDeneyimi.IsyeriCalismaYili = Convert.ToInt32(txtIsyeriCalismaYili.Text);
                _isDeneyimi.KisininEgitimDurumu = txtEgitimDurumu.Text;
                _isDeneyimi.KisininOkulAdi = txtOkulAdi.Text;
                _isDeneyimi.KisininOkulBolumu = txtKisininBolumu.Text;
                _isDeneyimi.KisininBolumeBaslangicYili = Convert.ToInt32(txtBolumBaslangicYili.Text);
                _isDeneyimi.KisininBolumuBitirmeYili = Convert.ToInt32(txtBolumBitisYili.Text);
                _isDeneyimi.KisininNotOrtalamasi = txtNotOrtalamasi.Text;

                _ikiliAramaAgaci.IsDeneyimiEkle(formIciKisi.tcKimlikNumarasi, _isDeneyimi);

                //Halihazırda kayıtlı olan is deneyimlerini görüntüleyebileceği ve güncelleyenileceği bir sayfa.
            }
        }
    }