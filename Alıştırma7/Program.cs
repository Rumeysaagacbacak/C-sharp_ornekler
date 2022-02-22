using System;

namespace Alıştırma7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cümledeki harf sayısını bulan program
            Console.WriteLine("**** Alıştırma 7 **** ");
            Console.WriteLine("Lütfen cümle giriniz :");
            string cumle =Console.ReadLine();
            string liste =  "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           +"abcçdefgğhiıjklmnoöprsştuüvyz";
            int sayac=0;
            for (int i = 0; i < cumle.Length; i++)
            {if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Girdiğiniz cümlede "+sayac+ " harf vardır");
            Console.ReadKey();
        }
    }
}
