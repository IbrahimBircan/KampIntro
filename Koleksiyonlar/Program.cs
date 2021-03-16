using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> islemler2 =new List<string> {"Engin","Murat","Kerem","Halil" };
            

            Console.WriteLine(islemler2[0]);
            Console.WriteLine(islemler2[1]);
            Console.WriteLine(islemler2[2]);
            Console.WriteLine(islemler2[3]);
            islemler2.Add("İlker");
            Console.WriteLine(islemler2[4]);
            Console.WriteLine(islemler2[0]);
        }
    }
}
