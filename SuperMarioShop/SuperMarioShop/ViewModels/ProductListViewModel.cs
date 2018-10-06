using SuperMarioShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.ViewModels
{
    public class ProductListViewModel
    {
        // properties
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
