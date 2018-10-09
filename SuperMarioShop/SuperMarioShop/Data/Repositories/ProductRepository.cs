using Microsoft.EntityFrameworkCore;
using SuperMarioShop.Data.interfaces;
using SuperMarioShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        // This constructor is important to inject AppDbContext(), so you can interact with database
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // We have only getters here because we will only read data from the database
        public IEnumerable<Product> Products => _appDbContext.Products.Include(c => c.Category);

        public IEnumerable<Product> PreferredProducts => _appDbContext.Products.Where(p => p.IsPreferredProduct).Include(c => c.Category);

        public Product GetProductById(int productId) => _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
    }
}
