﻿using System;

namespace KampIntro6
{
    class Program
    {
        static void Main(string[] args)
        { 
            //type safety -tip güvenliği
            // Do not repeat yourself = Kendini tekrarla
            // değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmişMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }

            if (sistemeGirişYapmişMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap botunu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
