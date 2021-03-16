using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sistemeGirisYapildiMi = true;
            double dolarDun=7.35;
            double dolarBugun=7.47;







            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("dolar azalmış");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("dolar artmış");
            }
            else
            {
                Console.WriteLine("dolar sabit kalmış");
            }



            if (sistemeGirisYapildiMi==true)
            {
                Console.WriteLine( "sisteme giriş yapıldı" );
            }
            else
            {
                Console.WriteLine("Giris Yapılmadı");
            }

        }
    }
}
