using System;

namespace SınavSonucu
{

    class Program
    {

        static void Main(string[] args)
        {
            int vize1;
            int vize2;
            int final;
            double sonuc;

            Console.WriteLine("1. Vize Notunu Giriniz.");
            vize1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Vize Notunu Giriniz.");
            vize2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Final Notunu Giriniz.");
            final = int.Parse(Console.ReadLine());

            sonuc = ((vize1 + vize2) / 2) * 0.30 + (final * 0.70);


            if (sonuc >= 0 && sonuc < 39)
            {
                Console.WriteLine("Sınav Sonucu FF'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else if (sonuc >= 39 && sonuc < 46)
            {
                Console.WriteLine("Sınav Sonucu FD'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else if (sonuc >= 46 && sonuc < 53)
            {
                Console.WriteLine("Sınav Sonucu DD'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else if (sonuc >= 53 && sonuc < 60)
            {
                Console.WriteLine("Sınav Sonucu DC'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else if (sonuc >= 60 && sonuc < 67)
            {
                Console.WriteLine("Sınav Sonucu CC'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else if (sonuc >= 67 && sonuc < 74)
            {
                Console.WriteLine("Sınav Sonucu CB'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else if (sonuc >= 74 && sonuc < 81)
            {
                Console.WriteLine("Sınav Sonucu BB'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else if (sonuc >= 81 && sonuc < 87)
            {
                Console.WriteLine("Sınav Sonucu BA'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sınav Sonucu AA'dir. Sınav Notu:" + sonuc);
                Console.ReadKey();
            }

        }
    }
}
