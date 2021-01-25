using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)

        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel kurs", "Java","C#"}; 



            {
                for (int i = 0; i < kurslar.Length; i++)
                {
                    Console.WriteLine(kurslar[i]);
                }
                Console.WriteLine("Sayfa Sonu - footer");
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)

            {
                Console.WriteLine(kurs);
            }
        }
    }
}
