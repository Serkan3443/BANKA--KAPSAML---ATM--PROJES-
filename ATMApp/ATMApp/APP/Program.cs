using ATMApp.ADRES.Arayüzler;
using ATMApp.ADRES.Varlıklar;
using ATMApp.KULLANICI_ARAYUZ;

namespace ATMApp.APP
{
    public class Program: IKullaniciGirisi
    {
        private List<KullaniciHesaplari> kullaniciHesaplariListe;
        private KullaniciHesaplari seciliHesap;
        public void VerileriBaslat()
        {
            kullaniciHesaplariListe = new List<KullaniciHesaplari>
            {
                new KullaniciHesaplari{Id=1, TamAd="Serkan Kabadayıoğulları", KullaniciHesapNumarasi=123456, KartNumarasi=321321, KartSifresi=123123,HesapBakiyesi=50000.00m, KilitliMi=false},
                new KullaniciHesaplari{Id=2, TamAd="Canan Şenlik", KullaniciHesapNumarasi=456789, KartNumarasi=654654, KartSifresi=456456,HesapBakiyesi=4000.00m, KilitliMi=false},
                new KullaniciHesaplari{Id=3, TamAd="Arda Güler", KullaniciHesapNumarasi=123555, KartNumarasi=987987, KartSifresi=789789,HesapBakiyesi=2000.00m, KilitliMi=true}
            };
        }
        public void KullaniciKartNumarasiVeSifreKontrol()
        {
            bool YanlisGiris = false;
            while (YanlisGiris == false)
            {
                KullaniciHesaplari GirisHesabi = Uygulama.KullaniciGirisFormu();
                Uygulama.Girisİlerleme();
                foreach(KullaniciHesaplari hesap in kullaniciHesaplariListe )
                {
                    seciliHesap = hesap;
                    if(GirisHesabi.KartNumarasi.Equals(seciliHesap.KartNumarasi))
                    {
                        seciliHesap.ToplamGiris++;
                        if(GirisHesabi.KartSifresi.Equals(seciliHesap.KartSifresi))
                        {
                            seciliHesap = hesap;
                            if(seciliHesap.KilitliMi || seciliHesap.ToplamGiris > 3)
                            {
                                // kilitli mesajı yazdır
                                Uygulama.KilitEkraniniYazdir();
                            }
                            else
                            {
                                seciliHesap.ToplamGiris = 0;
                                YanlisGiris = true;
                                break;
                            }
                        }
                    }
                    if (YanlisGiris == false)
                    {
                        Yarar.MesajYazdir("\n Geçersiz Kart Numarsı Veya Pin", false);
                        seciliHesap.KilitliMi = seciliHesap.ToplamGiris == 3;
                        if (seciliHesap.KilitliMi)
                        {
                            Uygulama.KilitEkraniniYazdir();
                        }
                    }
                    Console.Clear();
                }
            }
                    
        }
        public void Hosgeldiniz()
        {
            Console.WriteLine($"Tekrar Hoşgeldiniz, {seciliHesap.TamAd}");
        }

    }
}






