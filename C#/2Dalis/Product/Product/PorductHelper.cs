using Shop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    internal class PorductHelper
    {


        public  static Product MostExpensive(List<Product> products)
        {
            Product MostExpensiveProduct = products[0];

            foreach (var item in products)
            {
                if (item.Price > MostExpensiveProduct.Price)
                {
                    MostExpensiveProduct = item;
                }
            }

            return MostExpensiveProduct;
        }

        public static Product? MostExpensive2(List<Product> products, double maxPrice)
        {
            if (products == null || products.Count == 0)
            { 
                return null;
            }

            Product MostExpensiveProduct = null;

            foreach (var item in products)
            {
                if (item.Price <= maxPrice)
                {
                    if (MostExpensiveProduct == null || item.Price > MostExpensiveProduct.Price)
                    {
                        MostExpensiveProduct = item;
                    }
                }
            }

            return MostExpensiveProduct;
        }
    }
}
