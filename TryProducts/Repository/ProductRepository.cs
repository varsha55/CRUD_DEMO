using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryProducts.Models;

namespace TryProducts.Repository
{
    
    public class ProductRepository : IProductInterface
    {
        TestDB1Entities ProductDB = new TestDB1Entities();

        public Product Add(Product item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            ProductDB.Products.Add(item);
            ProductDB.SaveChanges();
            return item;
          
        }

        public bool Delete(int id)
        {
            Product product = ProductDB.Products.Find(id);
            ProductDB.Products.Remove(product);
            ProductDB.SaveChanges();
            return true;

        }

        public Product Get(int id)
        {
            return ProductDB.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductDB.Products;
        }

        public bool Update(Product item)
        {
            var products = ProductDB.Products.Single(a => a.Id == item.Id);
            products.Name = item.Name;
            products.Price = item.Price;
            products.Category = item.Category;
            ProductDB.SaveChanges();
            return true;
        }
    }
}