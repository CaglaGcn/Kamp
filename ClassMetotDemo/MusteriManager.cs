using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager

    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + " isimli müşteri eklenmiştir.");

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + " isimli müşteri silinmiştir.");
        }

    }
}
   
