using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Name = "Elma",
                Price=7,
                Explanation="Amasya Elması",
            };
            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 5;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1,product2};
            //type-safe : tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("*-----------------*");
            }

            Console.WriteLine("********Metotlar*********");
            Console.WriteLine("Metot 1 Solid");
            //instance - örnek
            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            Console.WriteLine("------------------------");
            Console.WriteLine("Metot 2 Solid değil");
            basketManager.Add2("Armut","Taze",15);
            basketManager.Add2("Elma", "Amasya Elması", 10);
            basketManager.Add2("Kayısı", "Malatya", 7);
            basketManager.Add2("ZAA","Xd",5.5);
            /*Add2 metodunda herhangi bir parametre ekleme durumunda
             tüm sayfalar hata verecektir tek tek girmek gereklidir
             o yüzden solid değildir*/
        }
    }
}


/*Don't repeat yourself - DRY
Clean Code
Best Practice : En iyi uygulama teknikleri*/