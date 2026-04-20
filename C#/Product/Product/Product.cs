using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    internal class Product
    {
        private string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }

        private int price = 0;
        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price turi būti teigiama reikšmė");

                price = value;

                //if (value > 0)
                //{
                //    price = value;
                //}

            }
        }

        private int quantity = 0;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if(value < 0)
                    throw new ArgumentException($"Quantity cant be negative");

                quantity = value;
            }
        }

        private static int productCount = 0;

        public static int ProductCount
        {
            get { return productCount; }
        }

        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;

            productCount++;
        }

        public int TotalValue 
        { 
            get { return Price * Quantity; }
        }

        public void ApplyDiscount(double percent)
        {
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentException("Procentas turi buti tarp 0 ir 100");
            }

            Price = (int)(Price * (1 - percent / 100));
        }

        public void ApplyDiscount(double percent, int minQuantity)
        {
            if (Quantity >= minQuantity)
            {
                if (percent < 0 || percent > 100)
                {
                    throw new ArgumentException("Procentas turi buti tarp 0 ir 100");
                }

                Price = (int)(Price * (1 - percent / 100));
            }
        }

        public void ApplyDiscount(double percent, int minQuantity, double maxPrice)
        {
            if (Quantity >= minQuantity && Price < maxPrice)
            {
               
                    if (percent < 0 || percent > 100)
                    {
                        throw new ArgumentException("Procentas turi buti tarp 0 ir 100");
                    }

                    Price = (int)(Price * (1 - percent / 100));
                
            }
        }

        public void CreateDefault()
        {
            return new Product("Unknown", 1, 0);
        }

        public static Product CreateDefault(string name)
        {
            return new Product(name, 1, 0);
        }

    }
}
