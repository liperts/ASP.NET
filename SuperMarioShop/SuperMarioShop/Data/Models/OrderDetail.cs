using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        // The following two properties makes possible for the Entity Framework...
        // ...to understand the relation between an Order and an OrderDetail
        public virtual Product Product { get; set; }

        public virtual Order Order { get; set; }
    }
}
