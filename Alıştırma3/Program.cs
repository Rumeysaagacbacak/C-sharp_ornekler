using System;

namespace Alıştırma3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program
            //alanı iksinin çarpımı çevresi ise (2x(iki sayının toplamı))
            Console.WriteLine("**** Alıştırma 3 **** ");
            int kkenar,ukenar,toplam,carpım = 0;
            //Console.WriteLine("Lütfen Kısa Kenarı giriniz : ");
            Console.Write("Kısa kenar : ");
            kkenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenar : ");
            ukenar = Convert.ToInt32(Console.ReadLine());
            toplam=2*(ukenar+kkenar);
            carpım=kkenar*ukenar;
            Console.WriteLine("Alan : {0}",carpım);
            Console.WriteLine("Çevre : {0}",toplam);
        }
    }
}
