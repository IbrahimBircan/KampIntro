using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerSevice loggerSevice) 
        {
            // bu kısım hatalı kod
            // bütün basvurular konuta bagımlı oldu
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            krediManager.Hesapla();
            loggerSevice.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {

        }
    }
}
