using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.İnMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open clossed principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);                
            }
        }
    }
}
