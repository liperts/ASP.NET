using SuperMarioShop.Data.interfaces;
using SuperMarioShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Mug", Description = "Beautiful mugs to drink whatever you want"},
                    new Category { CategoryName = "T-Shirt", Description = "Creative t-shirts made by fans" }
                };
            }
        }
    }
}
