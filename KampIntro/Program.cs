
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself
            // Değer tutucu - alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.40;
            double dolarBugun = 7.25;

            Console.WriteLine(kategoriEtiketi);

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azaldı");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Arttı");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

        }
    }
}
