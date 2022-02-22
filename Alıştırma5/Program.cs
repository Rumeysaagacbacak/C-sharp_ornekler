using System;

namespace Alıştırma5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının 0-100 arasında olup olmadığını kontrol eden program
            
            Console.WriteLine("**** Alıştırma 5 **** ");
            int sayi =0;
            Console.Write("Lütfen sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi>=0 && sayi<=100)
            {
                Console.WriteLine("Girilen sayı 0-100 arasında");
            }
            else
            {
                Console.WriteLine("Girilen sayı 0-100 arasında değil");
            }
            Console.ReadKey();
        }
    }
}
