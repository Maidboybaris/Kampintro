using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Ad = "elma";
            urun1.Fiyat = 15;
            urun1.Acıklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Ad = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Acıklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product  urunlerim in urunler)
            {
                Console.WriteLine(urunlerim.Ad);
                Console.WriteLine(urunlerim.Fiyat);
                Console.WriteLine(urunlerim.Acıklama);
                Console.WriteLine("---------------------");

            }
            Console.WriteLine("------------------Metotlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Elma","Yeşil elma", 7,100);
           


        }

    }
}
