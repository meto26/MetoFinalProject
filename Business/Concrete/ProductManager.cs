using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.İnMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAllByCategoryId()
        {
            //İş kodları
            //Yetkisi var mı?
            
            return _productDal.GetAll();
            
        }

        public List<Product> GetByUNitPrice(int id)
        {
            //CategoryId göndeilen id'ye eşitse onları filtrele
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
