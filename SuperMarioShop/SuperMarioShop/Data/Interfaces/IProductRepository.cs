using SuperMarioShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; set; }
        IEnumerable<Product> PreferredProducts { get; set; }
        Product GetProductById(int productId);
    }
}
