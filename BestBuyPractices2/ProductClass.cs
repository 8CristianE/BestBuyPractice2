using System;
namespace BestBuyPractices2
{
    public class ProductClass
    {
        public ProductClass()
        {
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public string StockLevel { get; set; }

    }
}

