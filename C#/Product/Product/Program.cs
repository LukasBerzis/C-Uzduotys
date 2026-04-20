using System;
using Shop;
using Helper;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>()
            {
                new Product ("Sofa", 499, 13) ,
                new Product ("Kede", 67, 30) ,
                new Product ("Saldytuvas", 1377,  5) ,
                new Product ("Kondicionerius", 325, 17) ,
                new Product ("Stalas", 199, 9) ,
            };

            int AllProductValue = 0;

            foreach (var item in list)
            {
                AllProductValue += item.TotalValue;
                Console.WriteLine($"{item.Name} - {item.Price} - {item.Quantity} - Total Value: {item.TotalValue}");
            }

            Console.WriteLine("Visu produktu bendara suma: " + AllProductValue);

            Console.WriteLine($"Brangiausias Produktas: {PorductHelper.MostExpensive(list).Name} {PorductHelper.MostExpensive(list).Price} ");

            Console.WriteLine("Iveskite max price");
            double PriceMax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Brangiausias Produktas: {PorductHelper.MostExpensive2(list, PriceMax).Name} {PorductHelper.MostExpensive2(list, PriceMax).Price} ");

            //Product p1 = new Product("Obuoliai", 2, 10);
            //Product p2 = new Product("Bananas", 3, 5);
            //Product p3 = new Product("Pienas", 4, 2);

            //Console.WriteLine($"{p1.Name} TotalValue: {p1.TotalValue}");
            //Console.WriteLine($"{p2.Name} TotalValue: {p2.TotalValue}");
            //Console.WriteLine($"{p3.Name} TotalValue: {p3.TotalValue}");

            //Console.WriteLine($"Sukurta produktų: {Product.ProductCount}");
        }
    }
}