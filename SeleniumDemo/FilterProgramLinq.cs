using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    internal class FilterProgramLinq
    {
        [TestMethod]
        public void linqtest()
        {

            List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Product { Id = 2, Name = "Phone", Price = 500 },
            new Product { Id = 3, Name = "Tablet", Price = 300 },
            new Product { Id = 4, Name = "Keyboard", Price = 50 },
            new Product { Id = 5, Name = "Monitor", Price = 200 },
        };


            var affordableProducts = products.Where(p => p.Price < 500);

            
            foreach (var product in affordableProducts)
            {
                Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}