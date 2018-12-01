using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace GamesForEveryone.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Name 01",
                    Description = "Description 01",
                    Category = "Category_01",
                    Price = 275
                },
                new Product
                {
                    Name = "Name 02",
                    Description = "Description 02",
                    Category = "Category_01",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Name 03",
                    Description = "Description 03",
                    Category = "Category_02",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Name 04",
                    Description = "Description 04",
                    Category = "Category_02",
                    Price = 34.95m
                },
                new Product
                {
                    Name = "Name 05",
                    Description = "Description 05",
                    Category = "Category_02",
                    Price = 79500
                },
                new Product
                {
                    Name = "Name 06",
                    Description = "Description 06",
                    Category = "Category_03",
                    Price = 16
                },
                new Product
                {
                    Name = "Name 07",
                    Description = "Description 07",
                    Category = "Category_03",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Name 08",
                    Description = "Description 08",
                    Category = "Category_03",
                    Price = 75
                },
                new Product
                {
                    Name = "Name 09",
                    Description = "Description 09",
                    Category = "Category_03",
                    Price = 1200
                });
                context.SaveChanges();
            }
        }
    }
}
