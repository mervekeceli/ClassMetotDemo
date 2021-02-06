using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //naming convention-isismlendirme kuralı
       /* public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler :) " + urun.Adi + " sepete eklendi!");
        }*/

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adindaki musteriyi eklediniz.");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri Adi: "+musteri.Ad);
                Console.WriteLine("Musteri Soyadi: " + musteri.Soyad);
                Console.WriteLine("Musteri Yasi: " + musteri.Yas);
                Console.WriteLine();
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" adli musteri bilgileri silindi.");
        }
    }
}
