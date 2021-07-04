using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself..-DRY
            //category:değer tutucu/alias
            string Category = "Kategoriler";
            //int studentCount = 3200;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)   
            {
                Console.WriteLine("Artıs Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Azalıs Butonu");
            }
            else
            {
                Console.WriteLine("Değişim Olmadı");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Paneli!");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu!");
            }

            Console.WriteLine(Category);

            Console.WriteLine(Category);

            Console.WriteLine(Category);

            Console.WriteLine(Category);

        }
    }
}
