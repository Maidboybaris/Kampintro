using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BavuruYap(ihtiyacKrediManager);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            
            
        }
    }
}
