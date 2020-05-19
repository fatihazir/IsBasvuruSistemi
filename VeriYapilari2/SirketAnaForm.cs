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
    public partial class SirketAnaForm : Form
    {
        // Şirket bilgilerinin çekilmesi. Ve sirket'e eşi.

        private DatabaseIslemleri db = new DatabaseIslemleri();
        private Sirket sirketFormIci = new Sirket();
        public SirketAnaForm()
        {
            InitializeComponent();
            
            
        }

        private void sirketBilgiGuncelleButon_Click(object sender, EventArgs e)
        {
            //burada şirket bilgileri güncellenecek


            string yeniSirketAd, yeniSirketAdres, yeniSirketEPosta, yeniSirketFax;
            string yeniSirketTelefon;
            yeniSirketAd = txtSirketAd.Text;
            yeniSirketAdres = richTxtSirketAdres.Text;
            yeniSirketEPosta = txtSirketEPosta.Text;
            yeniSirketFax = txtSirketFaks.Text;
            yeniSirketTelefon = txtSirketTelefon.Text;

           

            if (sirketFormIci.BilgiGuncelle(yeniSirketAd, yeniSirketAdres,
            yeniSirketFax, yeniSirketTelefon, yeniSirketEPosta))
            {
                MessageBox.Show("Aga kalk güncelledin");
            }
            else
            {
                MessageBox.Show("Sana da yaranmıyo aq ne hatası çıktı yine git bul şunu");
            }
        }

        private void sirketSilButon_Click(object sender, EventArgs e)
        {
            DialogResult durum = new DialogResult();
            // EMİN MİSİN SORUSU VE DOUBLE CHECK.
            // fatih senden çaldım bunu da nası kullanılıyor aq bu dialogbox ı
            int sirketID = sirketFormIci.SirketID;
            //int silindimi = sirket.SirketSil(sirketID);
            //if (silindimi == 1)
            //{
            //    MessageBox.Show("Aga kalk sildin");
            //}
            //else
            //{
            //    MessageBox.Show("Sana da yaranmıyo aq ne hatası çıktı yine git bul şunu");
            //}
        }

        private void sirketYeniIlanVerButon_Click(object sender, EventArgs e)
        {
            //veriler çekilip yeni bir ilan oluşturlacak. veriler Hash table a atılacak
            string ilanTanimi, arananElamanOzellikleri, pozisyon;
            ilanTanimi = richTxtYeniIsIlani.Text;
            arananElamanOzellikleri = richTxtYeniArananEleman.Text;
            pozisyon = txtYeniIlanPozisyon.Text;
            int sirketID = sirketFormIci.SirketID;
            //aga burayı kontrol et yanlış olabilir
            
            MessageBox.Show("Aga kalk yeni ilan ekledin");
        }

        private void ilanIseAlButon_Click(object sender, EventArgs e)
        {
            //en uygun kişi masked text boxundan kişi, ilan ve şirket bilgileri çekilir,
            //ilan güncellenir
            //kişi güncellenir
            int kisiID;
            int ilanID;
            int sirketID;
            //ilan.BilgiGuncelle(ilanID); //burada ilanın bilgisi güncellenebilir "iş verildi" gibi
        }

        private void ilanSilButon_Click(object sender, EventArgs e)
        {
            //tıklanan ilan bilgisi çekilir
            //silinecek ilanın bilgileri "Silindi" olarak güncellenir (bu gerekli mi emin değilim)
            //ilgili ilan silinir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EN AZ 2 YIL İŞ DENEYİMİNE SAHİP OLAN İLANLAR LİSTELENECEK VE LİSTVİEW İÇİNE YAZILACAK
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //YABANCI DİLİ OLANLAR LİSTELENECEK VE LİSTVİEW İÇİNE YAZILACAK
        }

        private void SirketAnaForm_Load(object sender, EventArgs e)
        {
            //BURADA GİRİŞ YAPAN ŞİRKETİN BİLGİLERİNİ ÇEKERİZ
            //BURADA RASTGELE ŞİRKET BİLGİSİ EKLİOM KIZMAIN .d
            foreach (Sirket sirket in db.Sirketler)
            {
                if (sirket.SirketAd == labelSirketIsmi.Text)
                {
                    sirketFormIci = sirket;
                    break;
                }
            }
            txtSirketAd.Text = sirketFormIci.SirketAd;
            richTxtSirketAdres.Text = sirketFormIci.SirketAdres;
            txtSirketEPosta.Text = sirketFormIci.SirketEposta;
            txtSirketFaks.Text = sirketFormIci.SirketFax;
            txtSirketTelefon.Text = sirketFormIci.SirketTelefon;
        }

        private void TxtSirketAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
