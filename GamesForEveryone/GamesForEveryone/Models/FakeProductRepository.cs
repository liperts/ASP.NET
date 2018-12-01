using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesForEveryone.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product { Name = "SNES", Price = 99 },
            new Product { Name = "Nintendo Switch", Price = 299 },
            new Product { Name = "PS4", Price = 499 }
        }.AsQueryable<Product>();
    }
}
