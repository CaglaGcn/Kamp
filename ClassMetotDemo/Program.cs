using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Ali";
            string Soyadi = "Solak";
            int Yasi = 19;

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Solak";
            musteri1.Yasi = 19;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Kemal";
            musteri2.Soyadi = "Topal";
            musteri2.Yasi = 23;

            Musteri[] musteri = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri Musteri in musteri)
            {
                Console.WriteLine(musteri1.Adi);
                Console.WriteLine(musteri1.Soyadi);
                Console.WriteLine(musteri1.Yasi);
                Console.WriteLine("----");

                Console.WriteLine(musteri2.Adi);
                Console.WriteLine(musteri2.Soyadi);
                Console.WriteLine(musteri2.Yasi);
                Console.WriteLine("----");

            }

        }
}
}
