using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BavuruYap(IKrediManager kredi,ILoggerService loggerService)
        {
            //Bavuran bilgilerini değerlendirme
            kredi.Hesapla();
            loggerService.Log();    
        } 
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        } 
    }
}
