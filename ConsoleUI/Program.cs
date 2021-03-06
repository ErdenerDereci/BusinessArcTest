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
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            Product product = new Product
            {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Silgi",
                UnitPrice = 15,
                UnitsInStock = 5
            };


            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(item.ProductName+" ======= "+item.CategoryName);
            }
        }
    }
}
