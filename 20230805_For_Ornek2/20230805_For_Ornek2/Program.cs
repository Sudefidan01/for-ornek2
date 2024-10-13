using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230805_For_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Ornek 2
         //1'den 5'e kadar olan sayıların toplamını ekrana yazdıralım
            int toplam = 0;
            for (int sayi = 0; sayi <= 5; sayi++)
            {
                toplam = toplam + sayi; // toplam +=sayi;
                Console.WriteLine("Sayıların toplamı : " + toplam);
            }

            Console.ReadKey();
        }
    }
}
