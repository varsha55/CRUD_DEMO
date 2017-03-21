using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryProducts.Models;

namespace TryProducts
{
    interface IProductInterface
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        bool Update(Product item);
       bool Delete(int id);
    }
}
