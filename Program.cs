// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);
            }
            else {
                Console.WriteLine("basarisiz");
            }

            TMetotlar instance = new.Metotlar();
            instance.Topla(2,3, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //metot overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);

            //metot imzasi
            
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}