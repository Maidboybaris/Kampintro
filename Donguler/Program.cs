    using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string[] Kurslar = new string[] {"Kurs1","Kurs2","Kurs3","Kurs4"};
            
            
            
            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }
            Console.WriteLine("For bitti.");

            foreach (string  Kurs in Kurslar )
            {
                Console.WriteLine(Kurs);
            } 
            Console.WriteLine("Sayfa sonu - Footer");
        }
    }
}
