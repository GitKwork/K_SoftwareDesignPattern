using NullObject.Infrastructure;
using NullObject.Products;
using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new string[]
            {
                "молоко",
                "печеньки",
                "сливки",
                "содовая",
                "кофе",
                "латте",
                "мильфей",
                "какао"
                };


            foreach (string productName in products)
            {
                Product product = Shop.GetProduct(productName);
                Console.WriteLine(product.KcalOfEnergy);
                product.Eat();
                Console.WriteLine();
            }


        }
    }
}