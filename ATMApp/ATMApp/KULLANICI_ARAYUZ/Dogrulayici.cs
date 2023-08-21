using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.KULLANICI_ARAYUZ
{
    public static class Dogrulayici
    {
        public static T Convert<T>(string girdi )
        {
            bool deger = false;
            string Kullanicigirisi;

            while(!deger)
            {
                Kullanicigirisi=Yarar.KullaniciGirisi(girdi);

                try
                {
                   var donusturucu= TypeDescriptor.GetConverter(typeof(T));
                    if(donusturucu!=null)
                    {
                        return (T) donusturucu.ConvertFromString(Kullanicigirisi);
                    }
                    else
                    {
                        return default;
                    }

                }
                catch
                {
                    Yarar.MesajYazdir("Geçersiz giriş, Tekrar deneyin.", false);
                }
            }
            return default;
        }
    }
}
