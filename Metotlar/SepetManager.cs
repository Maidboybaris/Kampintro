using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product  product  )
        {
            Console.WriteLine("Ürün Sepete eklendi : " + product.Ad);
        }
        public void Ekle2(string urunAdi, string urunAcıklamasi, double fiyat, int stok)
        {
            Console.WriteLine("Ürün sepete eklendi. :"  + urunAdi);
        }
    }
    
}
