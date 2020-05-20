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
            string sirketEposta = txtSirketPosta.Text;
            string sifre = txtSirketSifre.Text;
            Sirket dbSirket = new Sirket();
            dbSirket = db.SirketGirisYap(sirketEposta, sifre);

            if (dbSirket.SirketAd != null)
            {
                SirketAnaForm sirketFormunuAc = new SirketAnaForm();
                sirketFormunuAc.labelSirketIsmi.Text = dbSirket.SirketAd;
                sirketFormunuAc.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız!");
            }
        }

        private void btnSirketBilgiKaydet_Click(object sender, EventArgs e)
        {
            Sirket apple = new Sirket();
            apple.SirketEposta = "deneme";
            apple.sifre = "123";
            apple.SirketAd = "ad";
            db.Sirketler.Add(apple);
        }

        private void LoginFormu_Load(object sender, EventArgs e)
        {
            Sirket ilkSirket = db.DatabasedenIlkSirketCekimi();

        }
    }
}