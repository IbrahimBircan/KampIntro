using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id =1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Bayrak";
            musteri1.TcNo = "1234567890";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54123";
            musteri2.SirketAdi = "sirket adi";
            musteri2.VergiNo = "888855522222";


            // ana class miras bıraktıgı classların referanslarını alabilir
            //hem tuzel hem gerçek musteriyi asıl musteri classı tutabilir

            Musteri musteri3 = new TuzelMusteri();
            Musteri musteri4 = new GercekMusteri();

            
        }
    }
}
