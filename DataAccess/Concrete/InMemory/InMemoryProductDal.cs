using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitsInStock=15,UnitPrice=15},
            new Product { ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitsInStock = 1, UnitPrice = 550 },
            new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitsInStock=5,UnitPrice=2500},
            new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitsInStock=7,UnitPrice=300},
            new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitsInStock=50,UnitPrice=75}
        };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ = Language Integrated Query
            Product prodcutToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(prodcutToDelete);
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product prodcutToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            prodcutToUpdate.ProductName = product.ProductName;
            prodcutToUpdate.UnitsInStock=product.UnitsInStock;
            prodcutToUpdate.UnitPrice = product.UnitPrice;
            prodcutToUpdate.CategoryId = product.CategoryId;

        }
    }
}
