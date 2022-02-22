using System;

namespace Alistirma1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ad ve soyad bilgisini string değişenlere alarak ekranda yazdırma
            
            Console.WriteLine("**** Alıştırma 1 **** ");
            string ad;
            Console.Write("Adınız : ");
            ad=Console.ReadLine();
            string soyad;
            Console.Write("Soyadınız : ");
            soyad=Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + ad +" "+ soyad);
            Console.ReadKey();
            
        }
    }
}
