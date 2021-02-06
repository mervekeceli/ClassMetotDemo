using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Merve";
            musteri1.Soyad = "KECELI";
            musteri1.Yas = 20;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Berkant Alperen";
            musteri2.Soyad = "OZDEMIR";
            musteri2.Yas = 22;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Beyza";
            musteri3.Soyad = "KECELI";
            musteri3.Yas = 15;

            MusteriManager musteriManager = new MusteriManager();

            //Musteri Ekleme
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("\n");


            //musteri listeleme
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.MusteriListele(musteriler);
            Console.WriteLine("\n");


            //musteri silme
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
        }
    }
}
