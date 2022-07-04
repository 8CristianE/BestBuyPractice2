using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace BestBuyPractices2
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;


        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;

        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("INSERT INTO products (Name, Price< CategoryID) VALUES (@name, @price, @categoryID);",
                new { Name = name, Price = price, CategoryID = categoryID });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products;");
        }
    }
}

