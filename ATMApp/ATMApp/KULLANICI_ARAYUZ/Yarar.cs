using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.KULLANICI_ARAYUZ
{
    public static  class Yarar
    {
        public static string GizliGirisiAl(string girdi)
        {
            bool Girdidir = true;
            string İsaret = "";
            StringBuilder giris=new StringBuilder();

            while(true)
            {
                if (Girdidir)
                    Console.WriteLine(girdi);
                Girdidir= false;
                ConsoleKeyInfo giristusu = Console.ReadKey(true);

                if(giristusu.Key==ConsoleKey.Enter)
                {
                    if(giris.Length==6)
                    {
                        break;
                    }
                    else
                    {
                        MesajYazdir("\nLütfen 6 hane girin. ", false);
                        giris.Clear();
                        Girdidir = true;
                        continue;
                    }
                }
                if(giristusu.Key==ConsoleKey.Backspace && giris.Length>0)
                {
                    giris.Remove(giris.Length-1,1);
                }
                else if(giristusu.Key !=ConsoleKey.Backspace)
                {
                    giris.Append(giristusu.KeyChar);
                    Console.Write(İsaret + "*");
                }
            }
            return giris.ToString();
        }


        public static void MesajYazdir(string msj, bool basariliMi=true)
        {
            if(basariliMi)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msj);
            Console.ForegroundColor = ConsoleColor.White;
            DevamEtmekİcinEntereBas();
        }
        public static string KullaniciGirisi(string girdi)
        {
            Console.WriteLine($"Kart numaranızı {girdi}");
            return Console.ReadLine();
        }
        public static void AnimasyonuYazdirma(int zamanlayici=10)
        {
            
            for (int i = 0; i < zamanlayici; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.Clear();
        }
        public static void DevamEtmekİcinEntereBas()
        {
            Console.WriteLine("\n\nDevam Etmek İçin Enter`e Basın...\n");
            Console.ReadLine();
        }
    }
}
