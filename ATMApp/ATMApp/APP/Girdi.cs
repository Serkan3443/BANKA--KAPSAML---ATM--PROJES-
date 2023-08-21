using ATMApp.KULLANICI_ARAYUZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.APP
{
     class Girdi
    {
        static void Main(string[] args)
        {
            Uygulama.Hosgeldiniz();
            Program program= new Program();
            program.VerileriBaslat();
            program.KullaniciKartNumarasiVeSifreKontrol();
            program.Hosgeldiniz();

            Yarar.DevamEtmekİcinEntereBas();
        }
    }
}
