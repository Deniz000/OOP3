using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager = new KonutKrediManager(); // katılım yoluyla da referan yolu tutuluyor

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, 
                new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});
            //ya da aşağıdaki gi tanımlayabilrdim !!

            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager, tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
