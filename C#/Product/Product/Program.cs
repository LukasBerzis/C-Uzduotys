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

            Product p = new Product("TV", 1000, 10);

            Console.WriteLine($"{p.Name} TotalValue: {p.Price}");

            p.ApplyDiscount(10, 5, 500);     
            p.ApplyDiscount(10, 5, 1500);

            Console.WriteLine($"{p.Name} TotalValue: {p.Price}");

            Product p1 = Product.CreateDefault();
            Product p2 = Product.CreateDefault("Laptop");

            Console.WriteLine($"{p1.Name} - {p1.Price} - {p1.Quantity}");
            Console.WriteLine($"{p2.Name} - {p2.Price} - {p2.Quantity}");

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