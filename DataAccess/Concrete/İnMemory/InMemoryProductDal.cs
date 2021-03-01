using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.İnMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ CategoryId=1, ProductId=1, ProductName= "Bardak" , UnitsInStock=15, UnitPrice=15 },
                new Product{ CategoryId=2, ProductId=2, ProductName= "Telefon" , UnitsInStock=3, UnitPrice=500 },
                new Product{ CategoryId=3, ProductId=3, ProductName= "Kitap" , UnitsInStock=2, UnitPrice=1500},
                new Product{ CategoryId=4, ProductId=4, ProductName= "Traş Makinesi" , UnitsInStock=65, UnitPrice=150 },
                new Product{ CategoryId=5, ProductId=5, ProductName= "Kalem" , UnitsInStock=1, UnitPrice=65 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
         }

        public void Delete(Product product)
        {
            //LİNQ- Language Integred Query
            Product productToDelete =  _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            // Gönderilen ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;            
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            // Where-Yeni bir liste haline getirip döndürür
           return _products.Where(p => p.CategoryId == categoryId).ToList();        
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
 }

