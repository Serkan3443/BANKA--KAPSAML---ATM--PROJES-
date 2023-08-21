using ATMApp.ADRES.Varlıklar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.KULLANICI_ARAYUZ
{
    public static class Uygulama
    {
        internal static void Hosgeldiniz()
        {
            Console.Clear();
            Console.Title = "ATM PROJEM";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n**********ATM UYGULAMASINA HOŞGELDİNİZ**********\n\n");
            Console.WriteLine("Lütfen ATM kartınızı takın ");
            Console.WriteLine("Not:Gerçek ATM makinesi kabul edecek ve doğrulayacaktır, " +
                "fiziksel bir ATM kartı, kart numarasını okuyun ve doğrulayın");
            Yarar.DevamEtmekİcinEntereBas();
        }
        internal static KullaniciHesaplari KullaniciGirisFormu()
        {
            KullaniciHesaplari HesaplariKullanmaZamani = new KullaniciHesaplari();

            HesaplariKullanmaZamani.KartNumarasi = Dogrulayici.Convert<long>("Kart Numaran.");
            HesaplariKullanmaZamani.KartSifresi = Convert.ToInt32(Yarar.GizliGirisiAl("Kart Şifrenizi Girin:"));
            return HesaplariKullanmaZamani;
        }
        internal static void Girisİlerleme()
        {
            Console.WriteLine("\nKart Numarası Ve Pin Kontrolü...");
            Yarar.AnimasyonuYazdirma();
        }
        internal static void KilitEkraniniYazdir()
        {
            Console.Clear();
            Yarar.MesajYazdir("Hesabınız Kilitli, Hesabınızın kilidini açmak için Lütfen en yakın şubeye  gidiniz.Teşekkür ederiz",true);
            Yarar.DevamEtmekİcinEntereBas();
            Environment.Exit(1);
        }
    }
}




