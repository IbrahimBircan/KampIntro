using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"yazılım gelistirici kursu", "java kursu","react kursu","c++ kursu" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine("foreach "+kurs);
            }


            



        }
    }
}
