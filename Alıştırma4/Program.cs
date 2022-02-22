using System;

namespace Alıştırma4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Alıştırma 4 **** ");
            int sayi;
            Console.Write("Lütfen sayı giriniz :  ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi%2 == 0)
            {
               Console.Write(sayi+" "+"sayısı çift sayıdır");
            }
            else
            {
                Console.Write(sayi+" "+"sayısı tek sayıdır");
            }
            Console.ReadKey();
        }
    }
}
