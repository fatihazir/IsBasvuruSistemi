using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari2
{
    public class CalisaninEgitimDurumuBilgileri : CalisaninEskiIsyeriBilgileri
    {
        public string KisininEgitimDurumu { get; set; }
        public string KisininOkulAdi{ get; set; }
        public String  KİsininOkulBolumu { get; set; }
        public int KisininBolumeBaslangicYili { get; set; }
        public int KisininBolumuBitirmeYili { get; set; }
        public float KisininNotOrtalamasi { get; set; }
        
    }
}
