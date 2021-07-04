using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Altta tek tek girildi bu yanlıştır dizi hali doğrudur.     
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama Temel Kurs";
            string kurs3 = "Java";


            //array - dizi
            //i=i+2 or i+=2 : iki iki arttır.
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlama Temel Kurs","Java","C++"};

            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //foreach dizi temelli yapıları tek tek döner.Dizilere uygulanır.
            //kurs in kurslardaki "kurs" takma ad yani alias başka herhangi bir şey yazılabilir.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
