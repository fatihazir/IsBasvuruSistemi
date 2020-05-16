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
    public partial class IsBasvurusuIcinKayitlanmaFormu : Form
    {
        public IsBasvurusuIcinKayitlanmaFormu()
        {
            InitializeComponent();
        }
        public KisiBilgileri yeniKayit;
        public void btnKisiKayitOl_Click(object sender, EventArgs e)
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
           
            yeniKayit = new KisiBilgileri(txtKisiAd.Text, txtKisiSoyad.Text, txtKisiAdres.Text,
                                                        txtKisiTelefon.Text, txtKisiEmail.Text,
                                                        txtKisiUyruk.Text,txtKisiDogumTarihi.Text,
                                                        txtKisiDogumYeri.Text, medeniDurum, txtKisiYabanciDil.Text,
                                                        txtKisiIlgiAlanlari.Text);


        }
    }
}
