using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.ADRES.Varlıklar
{
   public class KullaniciHesaplari
    {
        public int Id { get; set; }
        public long  KartNumarasi{ get; set; }
        public int  KartSifresi { get; set; }
        public long  KullaniciHesapNumarasi { get; set; }
        public string TamAd { get; set; }
        public decimal HesapBakiyesi{ get; set; }
        public int  ToplamGiris{ get; set; }
        public bool KilitliMi{ get; set; }
    }
}
