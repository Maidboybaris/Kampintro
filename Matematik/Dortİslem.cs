using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class Dortİslem
    {
        public void toplama(int sayi1, int sayi2)
        {
            int topla = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + topla);
        }
        public void cikar(int sayi1,int sayi2)
        {
            int kalan = sayi1 - sayi2;
            Console.WriteLine("kalam :" + kalan);
        }
        public void carpma(int sayi1,int sayi2)
        {
            int carpım = sayi1 * sayi2;
            Console.WriteLine("Çarpım :" + carpım);

        }
        public void bölme(int sayi1,int sayi2)
        {
            int bölüm = sayi1 / sayi2;
            Console.WriteLine("bölüm :" + bölüm);
        }

       

        
            
        
    }
}
