using System;
using System.Collections.Generic;

namespace PrettyHairBL
{
    public class StockRepository2
    {
        public List<Product> Products { get; set; }
         
        public StockRepository2()
        {
            Products = new List<Product>();
        }
        public List<Product> GetProducts()
        {
            return Products;
        }

        public List<Product> GetUnsellableProducts()
        {
            List<Product> unsellables = new List<Product>();
            foreach (var item in Products)
            {
                if (item.Unsellable == true)
                    unsellables.Add(item);
            }
            return unsellables;
        }
    }
}
