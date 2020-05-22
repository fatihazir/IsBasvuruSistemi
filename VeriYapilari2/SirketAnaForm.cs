using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class SirketAnaForm : Form
    {
        // Şirket bilgilerinin çekilmesi. Ve sirket'e eşi.
        private int tiklanilanIlanID { get; set; }
        public DatabaseIslemleri db { get; set; }
        public Sirket sirketFormIci { get; set; }
        public SortOrder Sorting { get; set; }
        public İkiliAramaAgacı ikiliAramaAgacı { get; set; }
        public void ilanListele()
        {
            listViewIlanlarDuzenlemeBolmesi.Items.Clear();
            listViewBasvuranlariListeleBasvuranlarKismi.Items.Clear();
            listViewBasvuranlariListeleKismi.Items.Clear();
            listViewIlanlarIsAlmaBolmesi.Items.Clear();
            Ilan ilan = new Ilan();
            for (int i = 0; i < 10; i++)
            {
                ilan = sirketFormIci.Ilanlar.GetIsIlaniForEditingAndListing(i);
                if (ilan == null)
                {
                    continue;
                }
                if (sirketFormIci.Ilanlar.GetIsIlaniNextDegilAmaKendisi(ilan.IlanNumarasi).next != null)
                {
                    foreach (HashChainEntry ilanNextIcınde in sirketFormIci.Ilanlar.ilanlariamanextliolanlarigetir())
                    {
                        ListViewItem temp1 = new ListViewItem(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IlanNumarasi.ToString());
                        ListViewItem temp2 = new ListViewItem(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IlanNumarasi.ToString());
                        ListViewItem temp3 = new ListViewItem(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IlanNumarasi.ToString());
                        temp2.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IsTanimi);
                        temp2.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).ArananElemanOzellikleri);
                        temp2.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).Pozisyon);
                        temp3.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IsTanimi);
                        temp3.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).ArananElemanOzellikleri);
                        temp3.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).Pozisyon);
                        temp1.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).IsTanimi);
                        temp1.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).ArananElemanOzellikleri);
                        temp1.SubItems.Add(sirketFormIci.Ilanlar.GetIsIlani(ilanNextIcınde.Anahtar).Pozisyon);
                        listViewIlanlarDuzenlemeBolmesi.Items.Add(temp1);
                        listViewBasvuranlariListeleKismi.Items.Add(temp2);
                        listViewIlanlarIsAlmaBolmesi.Items.Add(temp3);
                    }
                };
                ListViewItem item = new ListViewItem(ilan.IlanNumarasi.ToString());
                ListViewItem item2 = new ListViewItem(ilan.IlanNumarasi.ToString());
                ListViewItem item3 = new ListViewItem(ilan.IlanNumarasi.ToString());
                item.SubItems.Add(ilan.IsTanimi);
                item.SubItems.Add(ilan.ArananElemanOzellikleri);
                item.SubItems.Add(ilan.Pozisyon);
                item2.SubItems.Add(ilan.IsTanimi);
                item2.SubItems.Add(ilan.ArananElemanOzellikleri);
                item2.SubItems.Add(ilan.Pozisyon);
                item3.SubItems.Add(ilan.IsTanimi);
                item3.SubItems.Add(ilan.ArananElemanOzellikleri);
                item3.SubItems.Add(ilan.Pozisyon);
                listViewIlanlarDuzenlemeBolmesi.Items.Add(item);
                listViewIlanlarIsAlmaBolmesi.Items.Add(item2);
                listViewBasvuranlariListeleKismi.Items.Add(item3);
                
            }
        }

        public SirketAnaForm()
        {
            InitializeComponent();
        }

        private void sirketBilgiGuncelleButon_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Şirket bilgilerinizi güncellemek istediginize emin misiniz?.",
                "", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                string yeniSirketAd, yeniSirketAdres, yeniSirketEPosta, yeniSirketFax;
                string yeniSirketTelefon;
                yeniSirketAd = txtSirketAdi.Text;
                yeniSirketAdres = richTxtSirketAdres.Text;
                yeniSirketEPosta = txtSirketEPosta.Text;
                yeniSirketFax = txtSirketFax.Text;
                yeniSirketTelefon = txtSirketTelefon.Text;

                if (sirketFormIci.BilgiGuncelle(yeniSirketAd, yeniSirketAdres,
                yeniSirketFax, yeniSirketTelefon, yeniSirketEPosta))
                {
                    MessageBox.Show("Şirket bilgileri güncellendi!");
                }
                else
                {
                    MessageBox.Show("Şirket bilgisi güncellenirken hata oluştu!");
                } 
            }
        }

        private void sirketSilButon_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Şirket bilgilerini silerseniz sistemi kullanmak için yeni kayıt olusturmak zorunda kalırsınız.",
                "Kaydı silmek istiyor musunuz?", MessageBoxButtons.YesNo);
            if (true)
            {
                int sirketID = sirketFormIci.SirketID;
                if (db.DatabasedenSirketSilme(sirketID))
                {
                    MessageBox.Show("Şirket başarıyla silindi, giriş ekranına yönlendiriliyorsunuz.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Şirket silinirken hata oluştu!");
                } 
            }
        }

        private void sirketYeniIlanVerButon_Click(object sender, EventArgs e)
        {
            //veriler çekilip yeni bir ilan oluşturlacak. veriler Hash table a atılacak
            string ilanTanimi, arananElamanOzellikleri, pozisyon;
            ilanTanimi = richTxtYeniIsIlani.Text;
            arananElamanOzellikleri = richTxtYeniArananEleman.Text;
            pozisyon = txtYeniIlanPozisyon.Text;
            //aga burayı kontrol et yanlış olabilir
            Ilan yeniIlan = new Ilan();
            yeniIlan.IsTanimi = ilanTanimi;
            yeniIlan.Pozisyon = pozisyon;
            yeniIlan.ArananElemanOzellikleri = arananElamanOzellikleri;
            if (sirketFormIci.Ilanlar.AddIsIlani(yeniIlan.IlanNumarasi, yeniIlan, sirketFormIci))
            {
                MessageBox.Show("Başarıyla yeni bir ilan eklendi!");
                ilanListele();
            }
            else
            {
                MessageBox.Show("İlan eklenirken bir sorun ortaya çıktı!");
            }
        }

        private void ilanIseAlButon_Click(object sender, EventArgs e)
        {
            int kisiID;
            int sirketID;
            ulong musteriTCNo;

            ListViewItem theClickedItem = listViewEnUygunKisi.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                musteriTCNo = Convert.ToUInt32(theClickedItem.Text);
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(tiklanilanIlanID);
                IsDeneyimi yeniIsDeneyimi = new IsDeneyimi();
                yeniIsDeneyimi.IsyeriAd = sirketFormIci.SirketAd;
                yeniIsDeneyimi.IsyeriAdres = sirketFormIci.SirketAdres;
                yeniIsDeneyimi.IsyeriCalismaYili = 0;
                yeniIsDeneyimi.IsyerindekiPozisyonu = ilan.Pozisyon;
                yeniIsDeneyimi.KisininBolumeBaslangicYili = 2015;
                yeniIsDeneyimi.KisininBolumuBitirmeYili = 2018;
                yeniIsDeneyimi.KisininEgitimDurumu = "Öğretmen";
                yeniIsDeneyimi.KisininNotOrtalamasi = "5.5";
                yeniIsDeneyimi.KisininOkulAdi = "Bakırçay Üniversitesi";
                yeniIsDeneyimi.KisininOkulBolumu = "Bilgisayar Mühendisliği";

                sirketFormIci.Ilanlar.DeleteIsIlani(ilan.IlanNumarasi);
                ikiliAramaAgacı.KisiBilgileriniBul(musteriTCNo).Kisi.IsDeneyimleri.InsertLast(yeniIsDeneyimi);
                listViewEnUygunKisi.Items.Clear();
                ilanListele();
                MessageBox.Show("Çalışan başarıyla işe alındı!");
            }
        }

        private void ilanSilButon_Click(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Kişi bilgilerini silerseniz sistemi kullanmak için yeni kayıt olusturmak zorunda kalırsınız.",
                "Kaydı silmek istiyor musunuz?", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == durum)
            {
                ListViewItem theClickedItem = listViewIlanlarIsAlmaBolmesi.FocusedItem;
                if (theClickedItem == null)
                {
                    MessageBox.Show("Lütfen bir ilana tıklayınız!");
                }
                else
                {
                    int ilanNumarasi;
                    ilanNumarasi = Convert.ToInt32(theClickedItem.Text);
                    Ilan ilan = new Ilan();
                    ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanNumarasi);
                    sirketFormIci.Ilanlar.DeleteIsIlani(ilan.IlanNumarasi);
                    MessageBox.Show("Başarıyla ilan silindi!");
                    ilanListele();

                } 
            }
        }

        private void SirketAnaForm_Load(object sender, EventArgs e)
        {
            foreach (Sirket sirket in db.Sirketler)
            {
                if (sirket.SirketAd == labelSirketIsmi.Text)
                {
                    sirketFormIci = sirket;
                    break;
                }
            }
            txtSirketAdi.Text = sirketFormIci.SirketAd;
            richTxtSirketAdres.Text = sirketFormIci.SirketAdres;
            txtSirketEPosta.Text = sirketFormIci.SirketEposta;
            txtSirketFax.Text = sirketFormIci.SirketFax;
            txtSirketTelefon.Text = sirketFormIci.SirketTelefon;
            ilanListele();
        }

        private void btnIlanIncele_Click(object sender, EventArgs e)
        {
            ListViewItem theClickedItem = listViewIlanlarDuzenlemeBolmesi.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                int ilanNumarasi;
                ilanNumarasi = Convert.ToInt32(theClickedItem.Text);
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanNumarasi);
                richTextBoxIsTanimiIlanDuzenle.Text = ilan.IsTanimi;
                richTextBoxArananElemanOzellikleriIlanDuzenle.Text = ilan.ArananElemanOzellikleri;
                txtPozisyonIlanDuzenle.Text = ilan.Pozisyon;
            }
        }

        private void btnIlaniDuzenle_Click(object sender, EventArgs e)
        {
            ListViewItem theClickedtwo = listViewIlanlarDuzenlemeBolmesi.FocusedItem;

            if (theClickedtwo == null)
            {
                MessageBox.Show("Once bir ilan seçiniz.");
            }
            else
            {
                if (theClickedtwo != null)
                {
                    Ilan ilan = new Ilan();
                    ilan.IsTanimi = richTextBoxIsTanimiIlanDuzenle.Text;
                    ilan.ArananElemanOzellikleri = richTextBoxArananElemanOzellikleriIlanDuzenle.Text;
                    ilan.Pozisyon = txtPozisyonIlanDuzenle.Text;

                    int ilanID = Convert.ToInt32(theClickedtwo.Text);
                    sirketFormIci.Ilanlar.IsIlaniGuncelle(ilanID, ilan);
                    MessageBox.Show("Başarıyla ilanınızı güncellediniz!");
                    ilanListele();
                }
                else
                {
                    MessageBox.Show("Once ilan seçin.");
                }  
            }
            
        }

        private void listViewIlanlarIsAlmaBolmesi_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem theClickedItem = listViewIlanlarIsAlmaBolmesi.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                listViewEnUygunKisi.Items.Clear();
                int ilanID;
                ilanID = Convert.ToInt32(theClickedItem.Text);
                tiklanilanIlanID = ilanID;
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanID);
                int sayacBasvuranlarIcinEgerNullsa = 0;
                KisiBilgileri kisi = new KisiBilgileri();
                HeapDugumu heapEnUygunMusteri = new HeapDugumu(ilan.IlanNumarasi, kisi, -1);
                foreach (HeapDugumu heap in ilan.heap.heapArray)
                {
                    if (heap != null)
                    {
                        if (heap.IseUygunluk > heapEnUygunMusteri.IseUygunluk)
                        {
                            listViewEnUygunKisi.Items.Clear();
                            heapEnUygunMusteri = heap;
                            ListViewItem item = new ListViewItem(heap.Kisi.tcKimlikNumarasi.ToString());
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.ad);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.soyad);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.adres);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.telefon);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.email);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.uyruk);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.dogumTarihi);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.dogumYeri);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.medeniDurum);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.yabanciDil);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.ilgiAlanlari);
                            item.SubItems.Add(heapEnUygunMusteri.Kisi.iseUygunlukDurumu.ToString());
                            listViewEnUygunKisi.Items.Add(item);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        sayacBasvuranlarIcinEgerNullsa++;
                    }
                }
                if (sayacBasvuranlarIcinEgerNullsa == ilan.heap.maxSize)
                {
                    MessageBox.Show("Hiçkimse bu ilana başvurmamış!");
                }
            }
        }

        private void btnIlanBasvuranlariGetir_Click(object sender, EventArgs e)
        {
            ListViewItem theClickedItem = listViewBasvuranlariListeleKismi.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                listViewBasvuranlariListeleBasvuranlarKismi.Items.Clear();
                int ilanID;
                ilanID = Convert.ToInt32(theClickedItem.Text);
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanID);
                int sayacBasvuranlarIcinEgerNullsa = 0;
                foreach (HeapDugumu heap in ilan.heap.heapArray)
                {
                    if (heap != null)
                    {
                        ListViewItem item = new ListViewItem(heap.Kisi.tcKimlikNumarasi.ToString());
                        item.SubItems.Add(heap.Kisi.ad);
                        item.SubItems.Add(heap.Kisi.soyad);
                        item.SubItems.Add(heap.Kisi.adres);
                        item.SubItems.Add(heap.Kisi.telefon);
                        item.SubItems.Add(heap.Kisi.email);
                        item.SubItems.Add(heap.Kisi.uyruk);
                        item.SubItems.Add(heap.Kisi.dogumTarihi);
                        item.SubItems.Add(heap.Kisi.dogumYeri);
                        item.SubItems.Add(heap.Kisi.medeniDurum);
                        item.SubItems.Add(heap.Kisi.yabanciDil);
                        item.SubItems.Add(heap.Kisi.ilgiAlanlari);
                        item.SubItems.Add(heap.Kisi.iseUygunlukDurumu.ToString());
                        listViewBasvuranlariListeleBasvuranlarKismi.Items.Add(item);
                    }
                    else
                    {
                        sayacBasvuranlarIcinEgerNullsa++;
                    }
                }
                if (sayacBasvuranlarIcinEgerNullsa == ilan.heap.maxSize)
                {
                    MessageBox.Show("Hiçkimse bu ilana başvurmamış!");
                }
            }
        }

        private void btnIlanGuncelleBasvuruKismi_Click(object sender, EventArgs e)
        {
            ilanListele();
            MessageBox.Show("Başarıyla ilanlar güncellendi!");
        }

        private void listViewIlanlarIsAlmaBolmesi_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listViewIlanlarIsAlmaBolmesi.Sorting == SortOrder.Descending)
            {
                listViewIlanlarIsAlmaBolmesi.Sorting = SortOrder.Ascending;
            }
            else
            {
                listViewIlanlarIsAlmaBolmesi.Sorting = SortOrder.Descending;
            }
        }

        private void listViewIlanlarDuzenlemeBolmesi_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listViewIlanlarDuzenlemeBolmesi.Sorting == SortOrder.Descending)
            {
                listViewIlanlarDuzenlemeBolmesi.Sorting = SortOrder.Ascending;
            }
            else
            {
                listViewIlanlarDuzenlemeBolmesi.Sorting = SortOrder.Descending;
            }
        }

        private void listViewBasvuranlariListeleKismi_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listViewBasvuranlariListeleKismi.Sorting == SortOrder.Descending)
            {
                listViewBasvuranlariListeleKismi.Sorting = SortOrder.Ascending;
            }
            else
            {
                listViewBasvuranlariListeleKismi.Sorting = SortOrder.Descending;
            }
        }

        private void listViewBasvuranlariListeleBasvuranlarKismi_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void btnEnAzIkıYılListele_Click(object sender, EventArgs e)
        {
            //EN AZ 2 YIL İŞ DENEYİMİNE SAHİP OLAN İLANLAR LİSTELENECEK VE LİSTVİEW İÇİNE YAZILACAK

            //listViewBasvuranlariListeleBasvuranlarKismi <<<->>>> ilgili liste
            ListViewItem theClickedItem = listViewBasvuranlariListeleKismi.FocusedItem;
            if (theClickedItem == null)
            {
                MessageBox.Show("Lütfen bir ilana tıklayınız!");
            }
            else
            {
                listViewBasvuranlariListeleBasvuranlarKismi.Items.Clear();
                int ilanID;
                ilanID = Convert.ToInt32(theClickedItem.Text);
                Ilan ilan = new Ilan();
                ilan = sirketFormIci.Ilanlar.GetIsIlani(ilanID);
                int sayacBasvuranlarIcinEgerNullsa = 0;
                foreach (HeapDugumu heap in ilan.heap.heapArray)
                {
                    if (heap != null)
                    {
                        for (int i = 0; i < heap.Kisi.IsDeneyimleri.Size; i++)
                        {
                            if (heap.Kisi.IsDeneyimleri.GetElement(i).Data.IsyeriCalismaYili >= 2)
                            {
                                ListViewItem item = new ListViewItem(heap.Kisi.tcKimlikNumarasi.ToString());
                                item.SubItems.Add(heap.Kisi.ad);
                                item.SubItems.Add(heap.Kisi.soyad);
                                item.SubItems.Add(heap.Kisi.adres);
                                item.SubItems.Add(heap.Kisi.telefon);
                                item.SubItems.Add(heap.Kisi.email);
                                item.SubItems.Add(heap.Kisi.uyruk);
                                item.SubItems.Add(heap.Kisi.dogumTarihi);
                                item.SubItems.Add(heap.Kisi.dogumYeri);
                                item.SubItems.Add(heap.Kisi.medeniDurum);
                                item.SubItems.Add(heap.Kisi.yabanciDil);
                                item.SubItems.Add(heap.Kisi.ilgiAlanlari);
                                item.SubItems.Add(heap.Kisi.iseUygunlukDurumu.ToString());
                                listViewBasvuranlariListeleBasvuranlarKismi.Items.Add(item);
                            }
                        }
                    }
                    else
                    {
                        sayacBasvuranlarIcinEgerNullsa++;
                    }
                }
                if (sayacBasvuranlarIcinEgerNullsa == ilan.heap.maxSize)
                {
                    MessageBox.Show("Hiçkimse bu ilana başvurmamış!");
                }
            }
        }

        private void btnPreOrderListele_Click(object sender, EventArgs e)
        {
            lvFarkliListele.Items.Clear();
            ikiliAramaAgacı.PreOrderListesiniGetir();
            foreach (İkiliAramaAgacDugumu ikiliAramaAgacDugumu in ikiliAramaAgacı.PreOrderDugumlerListesi)
            {
                ListViewItem item = new ListViewItem(ikiliAramaAgacDugumu.Kisi.tcKimlikNumarasi.ToString());
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.ad);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.soyad);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.adres);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.telefon);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.email);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.uyruk);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.dogumTarihi);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.dogumYeri);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.medeniDurum);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.yabanciDil);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.ilgiAlanlari);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.iseUygunlukDurumu.ToString());
                lvFarkliListele.Items.Add(item);
            }
        }

        private void btnInOrderListele_Click(object sender, EventArgs e)
        {
            lvFarkliListele.Items.Clear();
            ikiliAramaAgacı.InOrderListesiniGetir();
            foreach (İkiliAramaAgacDugumu ikiliAramaAgacDugumu in ikiliAramaAgacı.InOrderDugumlerListesi)
            {
                ListViewItem item = new ListViewItem(ikiliAramaAgacDugumu.Kisi.tcKimlikNumarasi.ToString());
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.ad);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.soyad);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.adres);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.telefon);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.email);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.uyruk);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.dogumTarihi);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.dogumYeri);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.medeniDurum);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.yabanciDil);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.ilgiAlanlari);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.iseUygunlukDurumu.ToString());
                lvFarkliListele.Items.Add(item);
            }
        }

        private void btnPostOrderListele_Click(object sender, EventArgs e)
        {
            lvFarkliListele.Items.Clear();
            ikiliAramaAgacı.PostOrderListesiniGetir();
            foreach (İkiliAramaAgacDugumu ikiliAramaAgacDugumu in ikiliAramaAgacı.PostOrderDugumlerListesi)
            {
                ListViewItem item = new ListViewItem(ikiliAramaAgacDugumu.Kisi.tcKimlikNumarasi.ToString());
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.ad);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.soyad);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.adres);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.telefon);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.email);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.uyruk);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.dogumTarihi);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.dogumYeri);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.medeniDurum);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.yabanciDil);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.ilgiAlanlari);
                item.SubItems.Add(ikiliAramaAgacDugumu.Kisi.iseUygunlukDurumu.ToString());
                lvFarkliListele.Items.Add(item);
            }
        }

        private void btnFarkliListeleGoruntule_Click(object sender, EventArgs e)
        {
            txtElemanSayisi.Text = ikiliAramaAgacı.DugumlerinSayisiniGetir().ToString();
            //https://www.geeksforgeeks.org/write-a-c-program-to-find-the-maximum-depth-or-height-of-a-tree/ bu siteden alındı
            txtDerinlikSayisi.Text = ikiliAramaAgacı.maxDepth(ikiliAramaAgacı.kok).ToString();

        }

        private void btnIlanGuncelleDuzenleKismi_Click(object sender, EventArgs e)
        {
            ilanListele();
            MessageBox.Show("Başarıyla ilanlar güncellendi!");
        }

        private void btnIlanGuncelleIlanlarimKismi_Click(object sender, EventArgs e)
        {
            ilanListele();
            MessageBox.Show("Başarıyla ilanlar güncellendi!");
        }
    }
}