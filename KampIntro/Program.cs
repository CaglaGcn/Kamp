using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //değer tutucu, alias = kategoriEtiketi
            //type safety

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)

            {
                Console.WriteLine("Azalış oku");
            }

            else if (dolarDun < dolarBugun) 

            {
                Console.WriteLine("Artış oku");

            }

            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}

            

