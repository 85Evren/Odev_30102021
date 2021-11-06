using System;

namespace Odev_30102021_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long sayi;//--

            Console.WriteLine("1. Sayıyı Giriniz");
            sayi = long.Parse(Console.ReadLine());

            if (sayi == 0)
            {
                Console.WriteLine("Girilen Sayı Sıfıra Eşittir.");
                Console.ReadKey();
            }
            else if (sayi > 0)
            {
                Console.WriteLine("Girilen Sayı Pozitiftir.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Girilen Sayı Negatiftir.");
                Console.ReadKey();
            }

        }
    }
}
