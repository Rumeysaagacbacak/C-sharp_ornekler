using System;

namespace Alıştırma6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vücut Kitle İndeksi hesaplayan program
            
            Console.WriteLine("**** Alıştırma 6 **** ");
            double boy ;
            Console.Write("Lütfen boyunuzu (m)(örnek=1,60) giriniz : ");
            boy = Convert.ToDouble(Console.ReadLine());
            double kilo ;
            Console.Write("Lütfen kilonuzu giriniz (kg) giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            double indeks=0;
            indeks=kilo/(boy*boy );
            Console.WriteLine("Vücut kitle indexiniz : {0}",indeks);
            if(indeks <18)
            {
                Console.WriteLine("Zayıf");
            }
            else if(indeks>=18 && indeks<25)
            {
                Console.WriteLine("Normal");
            }
            else if(indeks >=25 && indeks<30)
            {
                Console.WriteLine("Kilolu");
            }
            else if(indeks >=30 && indeks<33)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ciddi Obez");
            }
            Console.ReadKey();           
        }
    }
}
