using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllByCategoryId();
        List<Product> GetByUNitPrice(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);

        
    }
}
