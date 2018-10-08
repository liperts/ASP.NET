using SuperMarioShop.Data.interfaces;
using SuperMarioShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Data.mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name = "Super Mug",
                        Price = 12.95M, ShortDescription = "Your coffee never be the same",
                        LongDescription = "Hit pause and take a break from your quest to rescue Princess Toadstool and Dinosaur Land from the clutches of the evil Bowser and enjoy a cup with this stylish Super Nintendo SNES Super Mario World Heat Change Mug.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/Mug01_L.jpg",
                        InStock = 30,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "../Images/Mug01_S.jpg"
                    },
                    new Product {
                        Name = "Game Over T-Shirt",
                        Price = 18.95M, ShortDescription = "Super Mario Bros \"Game Over\" T-shirt.",
                        LongDescription = "Treat your little gamer to this Super Mario Bros t-shirt. Printed all over with a colourful pattern featuring Mario, Luigi, Yoshi, Bowser and more, and finished with a bold ‘Game Over’ slogan, it’ll make a super addition to their weekend wardrobe.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/TShirt01_L.jpg",
                        InStock = 20,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../Images/TShirt01_S.jpg"
                    },
                    new Product {
                        Name = "30th Anniv T-Shirt",
                        Price = 20.95M, ShortDescription = "Super Mario Bros. 30th Anniversary T-Shirt",
                        LongDescription = "This Super Mario Bros. 30th Anniversary T-Shirt is available in a range of sizes (from Small to XL) and features a chest print of the Super Mario Bros. 30th Anniversary logo.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/TShirt02_L.jpg",
                        InStock = 100,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../Images/TShirt02_S.jpg"
                    },
                    new Product
                    {
                        Name = "Version's Mug",
                        Price = 12.95M,
                        ShortDescription = "Super Mario Dates Boxed Mug",
                        LongDescription = "Travel back to 1987 and the birth of a video game giant with this brilliant Mario mug from Nintendo. See just how the moustached hero has changed over the years as this mug illustrates the many different appearances the plumber has had. From 1987 onwards, every year that passes Mario seems to look better and better. Official merchandise.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "../Images/Mug02_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../Images/Mug02_S.jpg"
                    }
                };
            }
            set { }
        }
        public IEnumerable<Product> PreferredProducts { get; set; }
        
        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
