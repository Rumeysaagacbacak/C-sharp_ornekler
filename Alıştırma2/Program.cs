using System;

namespace Alıştırma2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 sayı isteyerek bu sayıların toplamını bulan program
            Console.WriteLine("**** Alıştırma 2 **** ");
            int sayi1,sayi2,toplam = 0;
            Console.WriteLine("Lütfen 2 sayı giriniz : ");
            Console.Write("1. sayı : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayı : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam =sayi1+sayi2;
            Console.WriteLine( sayi1 +" "+"ve"+" "+sayi2 +" "+"Sayılarının toplamı = {0}",toplam);
            Console.ReadKey();
        }
    }
}
