using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        // To store the references of products
        public Product Product { get; set; }

        public int Amount { get; set; }

        // Every item belongs to a cart
        public string ShoppingCartId { get; set; }
    }
}
