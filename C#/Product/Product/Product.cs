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

    }
}
