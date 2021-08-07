using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        //Naming convention - isimlendirme kuralları add değil Add
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: "+ product.Name+ " : "+ product.Price + " tl" );
        }
        //Add2 metodunda yeni parametre eklendiğinde Add2 kullanılan tüm sayfalarda yeni parametreyi tek tek girmek zorunda kalınır.
        public void Add2(string productName, string explanation, double price)
        {
            Console.WriteLine("Teberikler. Sepete Eklendi! : " + productName+" : " + price);
        }
    }
}
