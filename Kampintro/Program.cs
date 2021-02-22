using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategoriler";
            Console.WriteLine(KategoriEtiketi);
            bool GirisYapmisMi = false;
            double DolarDun = 7.45;
            double DolarBugun = 7.45;
            
            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Eşittir Oku");
            }
            
            
            
            
            if (GirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            
             
            

            

        }
    }
}
