using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emir";
            int yas = 19;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin DEMİROĞ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem VARIŞ";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay BİLGİN";
            kurs3.IzlenmeOrani = 99;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}