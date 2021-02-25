using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gercçek Müşteri
            GercekMusteri müşteri1 = new GercekMusteri();
            müşteri1.Id = 125;
            müşteri1.MusteriNo = "12345";
            müşteri1.Adi = "Barış";
            müşteri1.Soyadi = "Sakin";
            müşteri1.TcNo = "12364457";
            // tüzel Müşteri
            TuzelMusteri müşteri2 = new TuzelMusteri();
            müşteri2.Id = 126;
            müşteri2.MusteriNo = "12364218";
            müşteri2.SirketAdi = "Sakinnn";
            müşteri2.VergiNo = "1234567890";
            // base class referans tutucudur.
        }
    }
}
