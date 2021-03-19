using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Silgi",
                UnitPrice = 15,
                UnitsInStock= 5
            };


            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
