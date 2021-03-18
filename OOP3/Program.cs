using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasıtKrediManager = new TasıtKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerSevice databaseLoggerService = new DatabaseLoggerSevice();
            ILoggerSevice fileLoggerService = new FileLoggerSevice();

            // logger servisim birden cok loglama çeşidi içeriyor alternatiflerin birini kullanabiliriz


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };
           
           //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
