using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOranı =65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Ahmet Demirci";
            kurs2.IzlenmeOranı = 86;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "İbrahim Kafkas";
            kurs3.IzlenmeOranı = 25;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C";
            kurs4.Egitmen = "Murat Kartal";
            kurs4.IzlenmeOranı = 99;




            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var dolasılan in kurslar)
            {
                Console.WriteLine(dolasılan.KursAdi);
            }









        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }

}
