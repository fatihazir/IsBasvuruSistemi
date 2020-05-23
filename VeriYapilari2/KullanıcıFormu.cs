using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class KullaniciFormu : Form
    {
        public DatabaseIslemleri db { get; set; }

        public KisiBilgileri formIciKisi { get; set; }

        public İkiliAramaAgacı _ikiliAramaAgaci { get; set; }

        public Sirket formIcıSirket { get; set; }
        private IsDeneyimi _isDeneyimi = new IsDeneyimi();

        public void isDeneyimiListele()
        {
            listViewIsDeneyimleriGoruntule.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                IsDeneyimi isDeneyimi = new IsDeneyimi();
                if (formIciKisi.IsDeneyimleri.GetElement(i) == null)
                {
                    continue;
                }
                else
                {
                    isDeneyimi = formIciKisi.IsDeneyimleri.GetElement(i).Data;  // Null dönüyor.

                    if (isDeneyimi.IsyeriAd != null)
                    {
                        ListViewItem temp = new ListViewItem(isDeneyimi.IsDeneyimId.ToString());
                        temp.SubItems.Add(isDeneyimi.IsyeriAd); // şirket ad
                        temp.SubItems.Add(isDeneyimi.IsyeriAdres); // şirket in sonraki sütundaki değeri
                        temp.SubItems.Add(isDeneyimi.IsyerindekiPozisyonu);// şirket in sonraki sütundaki değeri
                        temp.SubItems.Add(Convert.ToString(isDeneyimi.IsyeriCalismaYili));
                        temp.SubItems.Add(isDeneyimi.KisininEgitimDurumu);
                        temp.SubItems.Add(isDeneyimi.KisininOkulAdi);
                        temp.SubItems.Add(isDeneyimi.KisininOkulBolumu);
                        temp.SubItems.Add(Convert.ToString(isDeneyimi.KisininBolumeBaslangicYili));
                        temp.SubItems.Add(Convert.ToString(isDeneyimi.KisininBolumuBitirmeYili));
                        temp.SubItems.Add(isDeneyimi.KisininNotOrtalamasi);

                        listViewIsDeneyimleriGoruntule.Items.Add(temp);
                    }
                }
            }
        }

        public void ilanListele()
        {
            listViewKullaniciIlanlarBolmesi.Items.Clear();
            Ilan ilan = new Ilan();
            Ilan ilan3 = new Ilan();
            HashChainEntry ilan2;
            foreach (Sirket sirket in db.Sirketler)
            {
                for (int i = 0; i < 10; i++)
                {
                    ilan = sirket.Ilanlar.GetIsIlaniForEditingAndListing(i);
                    if (ilan == null)
                    {
                        continue;
                    }
                    if (sirket.Ilanlar.GetIsIlaniNextDegilAmaKendisi(ilan.IlanNumarasi).next != null)
                    {
                        foreach (HashChainEntry ilanNextIcınde in sirket.Ilanlar.ilanlariamanextliolanlarigetir())
                        {
                            ListViewItem temp2 = new ListViewItem(sirket.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IlanNumarasi.ToString());
                            temp2.SubItems.Add(sirket.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IsTanimi);
                            temp2.SubItems.Add(sirket.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).ArananElemanOzellikleri);
                            temp2.SubItems.Add(sirket.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).Pozisyon);
                            temp2.SubItems.Add(sirket.SirketAd);
                            listViewKullaniciIlanlarBolmesi.Items.Add(temp2);
                        }
                    };

                    int sayacNull = 0;
                    int sayacBaskaKisi = 0;

                    foreach (var item in ilan.heap.heapArray)
                    {
                        if (item == null)
                        {
                            sayacNull++;
                            continue;
                        }
                        else if (item.Kisi.tcKimlikNumarasi == formIciKisi.tcKimlikNumarasi)
                        {
                            break;
                        }
                        else if (item.Kisi.tcKimlikNumarasi != formIciKisi.tcKimlikNumarasi)
                        {
                            sayacBaskaKisi++;
                        }
                    }
                    if (sayacBaskaKisi + sayacNull == ilan.heap.maxSize)
                    {
                        ListViewItem temp = new ListViewItem(ilan.IlanNumarasi.ToString());
                        temp.SubItems.Add(ilan.IsTanimi);
                        temp.SubItems.Add(ilan.ArananElemanOzellikleri);
                        temp.SubItems.Add(ilan.Pozisyon);
                        temp.SubItems.Add(sirket.SirketAd);
                        listViewKullaniciIlanlarBolmesi.Items.Add(temp);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public KullaniciFormu()
        {
            InitializeComponent();
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
            isDeneyimiListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string medeniDurum = "";
            switch (cmbMedeniDurum.SelectedIndex)
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

            try
            {
                formIciKisi.ad = txtAd.Text;
                formIciKisi.soyad = txtSoyad.Text;
                formIciKisi.adres = txtAdres.Text;
                formIciKisi.telefon = txtTelefon.Text;
                formIciKisi.email = txtEMail.Text;
                formIciKisi.medeniDurum = medeniDurum;
                formIciKisi.dogumTarihi = txtDogumTarih.Text;
                formIciKisi.dogumYeri = txtDogumYeri.Text;
                formIciKisi.ilgiAlanlari = txtIlgiAlan.Text;
                formIciKisi.yabanciDil = txtYabanciDil.Text.ToUpper();
                formIciKisi.uyruk = uyruk;

                _ikiliAramaAgaci.KisiGuncelle(formIciKisi.tcKimlikNumarasi, formIciKisi);

                MessageBox.Show("Verileriniz güncellendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata olustu : " + "exception");
            }
        }

        private void brnKisiBilgiSil_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Kişi bilgilerini silerseniz sistemi kullanmak için yeni kayıt olusturmak zorunda kalırsınız.",
                "Kaydı silmek istiyor musunuz?", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                _ikiliAramaAgaci.Sil(formIciKisi.tcKimlikNumarasi);
                this.Close();
            }
        }

        private void btnIlanGuncelle_Click(object sender, EventArgs e)
        {
            ilanListele();
            MessageBox.Show("İlanlar Listesi Guncellendi.");
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
                Ilan ilan = new Ilan();
                int ilanID;
                ilanID = Convert.ToInt32(theClickedItem.Text);
                foreach (Sirket sirket in db.Sirketler)
                {
                    ilan = sirket.Ilanlar.GetIsIlani(ilanID);
                    if (ilan == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (ilan.IsTanimi == null)
                        {
                            break;
                        }
                        ilan.heap.Insert(ilan.IlanNumarasi, formIciKisi, formIciKisi.iseUygunlukDurumu);
                    }
                }

                ilanListele();
                MessageBox.Show("Islem başarılı. Başvurdunuguz ilanın bilgileri : " + Environment.NewLine +
                                ilan.IlanBilgileriYazdir());
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

            MessageBox.Show("İs deneyiminiz eklendi.");
            isDeneyimiListele();
        }

        private void btnIsDeneyimGoruntule_Click(object sender, EventArgs e)
        {
            ListViewItem theClickedItem = listViewIsDeneyimleriGoruntule.FocusedItem;

            IsDeneyimi isDeneyimi = new IsDeneyimi();

            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir iş deneyimine tıklayınız!");
            }
            else
            {
                int işDeneyimiNumarasi = 0;
                işDeneyimiNumarasi = Convert.ToInt32(theClickedItem.Text);
                isDeneyimi = formIciKisi.IsDeneyimleri.GetElement(işDeneyimiNumarasi).Data;

                txtGIsDeneyimAd.Text = isDeneyimi.IsyeriAd;
                txtGIsDeneyimAdres.Text = isDeneyimi.IsyeriAdres;
                txtGIsDeneyimPozisyon.Text = isDeneyimi.IsyerindekiPozisyonu;
                txtGIsDeneyimCalismaYil.Text = Convert.ToString(isDeneyimi.IsyeriCalismaYili);
                txtGIsDeneyimiOkulAd.Text = isDeneyimi.KisininOkulAdi;
                txtGIsDeneyimEgitimDurumu.Text = isDeneyimi.KisininEgitimDurumu;
                txtGIsDeneyimKisiBolum.Text = isDeneyimi.KisininEgitimDurumu;
                txtGIsDeneyimKisiBolum.Text = isDeneyimi.KisininOkulBolumu;
                txtGIsDeneyimOkulNot.Text = isDeneyimi.KisininNotOrtalamasi;
                txtGIsDeneyimBaslangicYil.Text = isDeneyimi.KisininBolumeBaslangicYili.ToString();
                txtGIsDeneyimBitisYil.Text = isDeneyimi.KisininBolumuBitirmeYili.ToString();
            }
        }

        private void IlanlarListesi(object sender, ColumnClickEventArgs e)
        {
            if (listViewKullaniciIlanlarBolmesi.Sorting == SortOrder.Descending)
            {
                listViewKullaniciIlanlarBolmesi.Sorting = SortOrder.Ascending;
            }
            else
            {
                listViewKullaniciIlanlarBolmesi.Sorting = SortOrder.Descending;
            }
        }

        private void btnIsDeneyimGuncelle_Click(object sender, EventArgs e)
        {
            ListViewItem theClickedItem = listViewIsDeneyimleriGoruntule.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen güncellemek istediginiz iş deneyimine tıklayınız!");
            }
            else
            {
                DialogResult durum = MessageBox.Show("İs deneyiminiz otomatik olarak listede güncellenecektir.", "İş deneyimini güncellemek istediginize emin misiniz?"
                          , MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    int işDeneyimiNumarasi = 0;
                    işDeneyimiNumarasi = Convert.ToInt32(theClickedItem.Text);

                    IsDeneyimi isDeneyimi = formIciKisi.IsDeneyimleri.GetElement(işDeneyimiNumarasi).Data;

                    isDeneyimi.IsyeriAd = txtGIsDeneyimAd.Text;
                    isDeneyimi.IsyeriAdres = txtGIsDeneyimAdres.Text;
                    isDeneyimi.IsyerindekiPozisyonu = txtGIsDeneyimPozisyon.Text;
                    isDeneyimi.IsyeriCalismaYili = Convert.ToUInt16(txtGIsDeneyimCalismaYil.Text);
                    isDeneyimi.KisininOkulAdi = txtGIsDeneyimiOkulAd.Text;
                    isDeneyimi.KisininEgitimDurumu = txtGIsDeneyimEgitimDurumu.Text;
                    isDeneyimi.KisininOkulBolumu = txtGIsDeneyimKisiBolum.Text;
                    isDeneyimi.KisininNotOrtalamasi = txtGIsDeneyimOkulNot.Text;
                    isDeneyimi.KisininBolumeBaslangicYili = Convert.ToInt32(txtGIsDeneyimBaslangicYil.Text);
                    isDeneyimi.KisininBolumuBitirmeYili = Convert.ToInt32(txtGIsDeneyimBitisYil.Text);

                    formIciKisi.IsDeneyimleri.GetElement(işDeneyimiNumarasi).Data = isDeneyimi;

                    isDeneyimiListele();
                }
            }
        }

        private void IsDeneyiminiKategorizeEt(object sender, ColumnClickEventArgs e)
        {
            if (listViewIsDeneyimleriGoruntule.Sorting == SortOrder.Descending)
            {
                listViewIsDeneyimleriGoruntule.Sorting = SortOrder.Ascending;
            }
            else
            {
                listViewIsDeneyimleriGoruntule.Sorting = SortOrder.Descending;
            }
        }
    }
}