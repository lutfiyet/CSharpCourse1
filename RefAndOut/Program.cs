using System;
using System.Linq;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2(20);
            //var result2 = Add2(50);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(Add2(20,30));

            //int n1 = 20;
            //int n2 = 100;
            //int result3 = Add3(ref n1,n2);
            //Console.WriteLine(result3);
            //Console.WriteLine(n1);//değer tiplerle çalıştığımız için sonuç 20.
            //Console.WriteLine(Multiply(2,4));
            //Console.WriteLine(Multiply(2,4,5));
            Console.WriteLine(Add4(1,2,3,4,5,6,7,8));
            Console.ReadLine();
        }
        //void bir şeyi yaptırmak için ekrana çıktı ver,kayıt yap gibi.
        static void Add()
        {
            Console.WriteLine("Added!!");
        }
        //static int yazdık çünkü işlem yapıp sonuç döndürdük ve bu işlem int değerinde.
        //defualt olarak değer verilebilir ama bu parametlerin en sonunda olmalı.
        static int Add2(int number1,int number2=30)
        {
            int result = number1 + number2;
            return result;
          
        }
        static int Add3(ref int n1,int n2)
        {
            n1 = 30;
            int result = n1 + n2;
            return result;
        }
        static int Multiply(int n1,int n2)
        {
            var result = n1 * n2;
            return result;
        }
        static int Multiply(int n1,int n2,int n3)
        {
            var result = n1 * n2 * n3;
            return result;
        }
        static int Add4(params int[] numbers)
        {
            var result = numbers.Sum();
            return result;
        }
    }
}
