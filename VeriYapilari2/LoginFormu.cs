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
            int tc = Convert.ToInt32(txtTcNo.Text);
            string sifre = txtSifre.Text;
            bool girisDogrulama;

            girisDogrulama = db.GirisYap(tc, sifre);

            if (girisDogrulama)
            {
                KisiBilgileri deneme = new KisiBilgileri();
                deneme = db.KisiGetir();
            }

            girisDogrulama = false;
        }

        private void LoginFormu_Load(object sender, EventArgs e)
        {
        }

        private void btnSirketGirisi_Click(object sender, EventArgs e)
        {
            string sirketAdi = txtSirketAdi.Text;
            string sifre = txtSirketSifre.Text;
            bool girisDogrulama;
            girisDogrulama = db.GirisYap(sirketAdi, sifre);

            if (girisDogrulama)
            {
                Sirket deneme = new Sirket();
                deneme = db.SirketGetir();
            }

            girisDogrulama = false;
        }
    }
}