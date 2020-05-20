using System;
using System.Windows.Forms;

namespace VeriYapilari2
{
    public partial class IsBasvurusuIcinIlanaBasvurmaFormu : Form
    {
        public IsBasvurusuIcinIlanaBasvurmaFormu()
        {
            InitializeComponent();
        }

        private void btnIlanaBasvur_Click(object sender, EventArgs e)
        {
            // basvurualan ilan bir daha gorunmeyecek.
            //DialogResult ile ikili pencere açılıp onay alınacak.
        }

        private void IsBasvurusuIcinIlanaBasvurmaFormu_Load(object sender, EventArgs e)
        {
            //dgvIlanListesi dolacak.
        }
    }
}