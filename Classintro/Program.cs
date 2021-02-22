using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.EğitmenAdı = "Barışcan Sakin";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.EğitmenAdı = "Kerem Varış";
            kurs2.İzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.EğitmenAdı = "Berkay Bilgin";
            kurs3.İzlenmeOranı = 80;

            Console.WriteLine(kurs1.EğitmenAdı + " " + kurs1.KursAdı);

            Kurs[] Kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3
            };

            foreach (var kurs in Kurslar )
            {
                Console.WriteLine(kurs.KursAdı + " " + kurs.EğitmenAdı + " " + kurs.İzlenmeOranı);
            }

            
            // ALIŞTIRMA YAPTIM.
            
            Console.WriteLine("Hello World!");

            Öğrenci x = new Öğrenci();
            x.ÖğrenciAdı = "Öğrenci 1";
            x.SınavNotu = 70;

            Öğrenci x2 = new Öğrenci();
            x2.ÖğrenciAdı = "Öğrenci 2";
            x2.SınavNotu = 78;

            Öğrenci x3 = new Öğrenci();
            x3.ÖğrenciAdı = "Öğrenci 3";
            x3.SınavNotu = 90;

            Öğrenci x4 = new Öğrenci();
            x4.ÖğrenciAdı= "Öğrenci 4";
            x4.SınavNotu = 80;

            Öğrenci x5 = new Öğrenci();
            x5.ÖğrenciAdı = "Öğrenci 5";
            x5.SınavNotu = 79;

            Öğrenci x6 = new Öğrenci();
            x6.ÖğrenciAdı = "Öğrenci 6";
            x6.SınavNotu = 75;

            Öğrenci x7 = new Öğrenci();
            x7.ÖğrenciAdı = "Öğrenci 7";
            x7.SınavNotu = 60;

            Öğrenci x8 = new Öğrenci();
            x8.ÖğrenciAdı = "Öğrenci 8";
            x8.SınavNotu = 50;

            Öğrenci x9 = new Öğrenci();
            x9.ÖğrenciAdı = "Öğrenci 9";
            x9.SınavNotu = 69;

            Öğrenci x10 = new Öğrenci();
            x10.ÖğrenciAdı = "Öğrenci 10";
            x10.SınavNotu = 28;

            Öğrenci[] y = new Öğrenci[] {x,x2,x3,x4,x5,x6,x7,x8,x9,x10};

            foreach (var Öğrenciler in y)
            {
                

                if (Öğrenciler.SınavNotu >=70)
                {
                    Console.WriteLine(Öğrenciler.ÖğrenciAdı + " " + "Puanı = " + Öğrenciler.SınavNotu + " " + "Sınav Sonucu : " + " " + "Sınavı Geçmiştir.");
                }
                else
                {
                    Console.WriteLine(Öğrenciler.ÖğrenciAdı + " " + "Puanı = " + Öğrenciler.SınavNotu + " " + " " + "Sınav Sonucu : " + "Sınavı Geçememiştir.");
                }



            }
            // ALIŞTIRMA SONU.
            

            
            

            

            
            

            

            
            

            

        }

    }
}

class Kurs
{
    public string KursAdı { get; set; }

    public string EğitmenAdı { get; set; }

    public int İzlenmeOranı { get; set; }
}


// ALIŞTIRMA İÇİN CLASS 
class Öğrenci
{
    public string  ÖğrenciAdı { get; set; }

    public int SınavNotu { get; set; }
}
//ALIŞTIRMA CLASS BİTİŞİ