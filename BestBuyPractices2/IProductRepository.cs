using System;
using System.Collections.Generic;

namespace BestBuyPractices2
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, double price, int categoryID);
    }
}

