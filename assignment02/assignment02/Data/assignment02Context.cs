using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace assignment02.Models
{
    public class assignment02Context : DbContext
    {
        public assignment02Context (DbContextOptions<assignment02Context> options)
            : base(options)
        {
        }

        public DbSet<assignment02.Models.Member> Member { get; set; }
    }
}
