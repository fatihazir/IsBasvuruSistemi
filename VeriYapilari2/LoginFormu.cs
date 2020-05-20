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

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            ulong tc = Convert.ToUInt32(txtTcNo.Text);
            string sifre = txtSifre.Text;
            bool girisDogrulama;
        }

        private void btnSirketGirisi_Click(object sender, EventArgs e)
        {
            //BURADA DEĞİŞİKLİK OLACAK LOGİN FORMDA ARTIK ŞİRKET ADI DEĞİL E POSTA İLE GİRİŞ YAPILIYOR
            string sirketAdi = txtSirketAdi.Text;
            string sifre = txtSirketSifre.Text;
            

            if (db.SirketGirisYap(sirketAdi, sifre))
            {
                SirketAnaForm sirketFormunuAc = new SirketAnaForm();
                //sirketFormunuAc.labelSirketIsmi.Text = deneme.SirketAd;
                sirketFormunuAc.Show();

            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız!");
            }
        }
    }
}