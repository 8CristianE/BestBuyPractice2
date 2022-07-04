using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace BestBuyPractices2
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);
            
            var repo = new DapperDepartmentRepository(conn);

            Console.WriteLine("Departments");
            var departments = repo.GetAllDepartments();

            foreach(var d in departments)
            {
                Console.WriteLine($"{d.DepartmentID}: { d.Name}");

            }

            Console.WriteLine("Enter name for new Department");
            var dName = Console.ReadLine();

            repo.InsertDepartment(dName);

            departments = repo.GetAllDepartments();

            foreach (var d in departments)
            {
                Console.WriteLine($"{d.DepartmentID}: { d.Name}");
           

            var pRepo = new DapperProductRepository(conn);
            var products = new pRepo.GetAllProducts();

            foreach(var p in products)
            {
                Console.WriteLine($"{p.ProductID}:{p.Name}${p.Price}");
            }
            Console.WriteLine("Name of new Product");
            var pName = Console.ReadLine();

            Console.WriteLine("Price?");
            var pPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the category id?");
            var pCat = int.Parse(Console.ReadLine());

            pRepo.CreateProduct(pName, pPrice, pCat);

            foreach (var p  in products)
            {
                Console.WriteLine($"{p.ProductID}: {p.Name} ${p.Price}");
            }



        }
    }
}

