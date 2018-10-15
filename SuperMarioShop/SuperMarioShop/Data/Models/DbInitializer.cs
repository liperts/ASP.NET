using SuperMarioShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using SuperMarioShop.Data;
using System;

namespace SuperMarioShop
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "Super Mug",
                        Price = 12.95M,
                        ShortDescription = "Your coffee never be the same",
                        LongDescription = "Hit pause and take a break from your quest to rescue Princess Toadstool and Dinosaur Land from the clutches of the evil Bowser and enjoy a cup with this stylish Super Nintendo SNES Super Mario World Heat Change Mug.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug01_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "../../Images/Mug01_S.jpg"
                    },
                    new Product
                    {
                        Name = "Version's Mug",
                        Price = 12.95M,
                        ShortDescription = "Super Mario Dates Boxed Mug",
                        LongDescription = "Travel back to 1987 and the birth of a video game giant with this brilliant Mario mug from Nintendo. See just how the moustached hero has changed over the years as this mug illustrates the many different appearances the plumber has had. From 1987 onwards, every year that passes Mario seems to look better and better. Official merchandise.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug02_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug02_S.jpg"
                    },
                    new Product
                    {
                        Name = "Heat Change Mug",
                        Price = 10.95M,
                        ShortDescription = "Super Mario Brothers Heat Change Ceramic Mug",
                        Category = Categories["Mug"],
                        LongDescription = "The mug is inspired by the classic video games first released in the 1980s. Whether a quirky Secret Santa package or a level-up bonus for a Mario obsessed fan. Whether you’re an avid coffee or hot chocolate drinker. This Super Mario Bros. Heat Change Mug Collector’s edition will sure to start conversation in the office or coffee shop. When cold displays a plain Mario level background but when a hot drink background changes color and extra details appear, such as coins, enemies, clouds, and Mario himself. Perfect for Nintendo, Super Mario Bros., Video game, or classics fans. This Heat Changing Collector’s Edition Super Mario Bros. Mug will make their day and become their favorite cup. This Collector’s Edition Mug is an Officially Licensed Product of Nintendo. NOT safe for dishwasher use nor microwave use. Standard sized drinking mug, capacity 300ml.",
                        ImageUrl = "../../Images/Mug03_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug03_S.jpg"
                    },
                    new Product
                    {
                        Name = "Vintage Pixels Mug",
                        Price = 15.95M,
                        ShortDescription = "Super Mario Bros 3 Vintage Pixels V02 Mug",
                        LongDescription = "Premium ceramic. 11oz capacity. Microwave and top-shelf dishwasher safe. Embedded image. Vacuum-form printed in U.S.A.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug04_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug04_S.jpg"
                    },
                    new Product
                    {
                        Name = "Pocket Mug",
                        Price = 15.95M,
                        ShortDescription = "Pocket Super Mario Mug",
                        LongDescription = "Premium ceramic. 11oz capacity. Microwave and top-shelf dishwasher safe. Embedded image. Vacuum-form printed in U.S.A.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug05_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug05_S.jpg"
                    },
                    new Product
                    {
                        Name = "Black NES Mug",
                        Price = 15.95M,
                        ShortDescription = "Super Mario Bros. Black NES Ceramic Coffee Mug",
                        LongDescription = "Authentic black Super Mario Bros. coffee mug. This ceramic mug holds 11 ounces and features the classic \"NES\" Mario game cartridge design on both sides of the mug. Officially licensed.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug06_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug06_S.jpg"
                    },
                    new Product
                    {
                        Name = "Bowser Mug",
                        Price = 19.95M,
                        ShortDescription = "Super Mario – Bowser Heat Change Mug",
                        LongDescription = "Officially licensed Super Mario Maker Bowser Heat Changing Ceramic Coffee Mug! Features heat changing graphics, flames appear from Bowser’s mouth when any hot beverage is added. Hand wash. Do not microwave. Not dishwasher safe. 20 oz.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug07_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug07_S.jpg"
                    },
                    new Product
                    {
                        Name = "Nintendo Mug",
                        Price = 17.95M,
                        ShortDescription = "Nintendo Super Mario Mario Kanji Mug",
                        LongDescription = "Perfect for all Nintendo fans, the Super Mario Mug features classic images from the iconic video game. An officially licensed product, the ceramic mug has a capacity of 315ml / 11oz and is dishwasher and microwave safe. Presented in an secure gift box, the mug is a great gift idea.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug08_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug08_S.jpg"
                    },
                    new Product
                    {
                        Name = "Thank You Mug",
                        Price = 15.95M,
                        ShortDescription = "Super Mario Bros. Thank You Mario Coffee Mug",
                        LongDescription = "Officially licensed ceramic Super Mario Bros. coffee mug. This mug comes in black and features a Thank You Mario game screen on both sides. Holds 11 ounces.",
                        Category = Categories["Mug"],
                        ImageUrl = "../../Images/Mug09_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/Mug09_S.jpg"
                    },
                    new Product
                    {
                        Name = "Game Over T-Shirt",
                        Price = 18.95M,
                        ShortDescription = "Super Mario Bros \"Game Over\" T-shirt.",
                        LongDescription = "Treat your little gamer to this Super Mario Bros t-shirt. Printed all over with a colourful pattern featuring Mario, Luigi, Yoshi, Bowser and more, and finished with a bold ‘Game Over’ slogan, it’ll make a super addition to their weekend wardrobe.",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt01_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/TShirt01_S.jpg"
                    },
                    new Product
                    {
                        Name = "30th Anniv T-Shirt",
                        Price = 20.95M,
                        ShortDescription = "Super Mario Bros. 30th Anniversary T-Shirt",
                        LongDescription = "This Super Mario Bros. 30th Anniversary T-Shirt is available in a range of sizes (from Small to XL) and features a chest print of the Super Mario Bros. 30th Anniversary logo.",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt02_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/TShirt02_S.jpg"
                    },
                    new Product
                    {
                        Name = "Here We Go T-Shirt",
                        Price = 19.95M,
                        ShortDescription = "Super Mario Bros: Mario is Go T-shirt",
                        LongDescription = "The Super Mario Bros: Mario is Go T-shirt is officially licensed Nintendo merchandise. You can be confident that it will be of the highest quality and give you that warm, fuzzy feeling that only comes from supporting the creators. Show your love for Nintendo by getting your hands on the Super Mario Bros: Mario is Go T-shirt. You know you want to :)",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt03_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/TShirt03_S.jpg"
                    },
                    new Product
                    {
                        Name = "Super Mario T-Shirt",
                        Price = 15.95M,
                        ShortDescription = "Cool design tees Game fans",
                        LongDescription = "Super Mario T shirt Hot short sleeve Cool design tees Game fans clothing Men cotton Tshirt",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt04_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/TShirt04_S.jpg"
                    },
                    new Product
                    {
                        Name = "Periodic Table T-Shirt",
                        Price = 19.95M,
                        ShortDescription = "Nintendo Periodic Table of Super Mario T-shirt",
                        LongDescription = "In case you ever needed to know how the characters of the Super Mario universe interact with each other, there's a t-shirt for that! This officially licensed Nintendo tee features the periodic table of Super Mario, complete with all the one-ups, villians, and side-kicks you could ever need.",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt05_L.jpg",
                        InStock = 0,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/TShirt05_S.jpg"
                    },
                    new Product
                    {
                        Name = "Pocket T-Shirt",
                        Price = 20.95M,
                        ShortDescription = "Pocket Super Mario T-Shirt",
                        LongDescription = "100% combed ringspun cotton. The perfect fabric for a graphic tee and the softest in the business.",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt06_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "../../Images/TShirt06_S.jpg"
                    },
                    new Product
                    {
                        Name = "8 Bit T-Shirt",
                        Price = 12.95M,
                        ShortDescription = "8 Bit Mario Inspired Design Top 100% Cotton",
                        LongDescription = "Super Mario T-shirt, 8 Bit Mario Inspired Design Tee Top 100% Cotton For Man Tee",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt07_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/TShirt07_S.jpg"
                    },
                    new Product
                    {
                        Name = "Enemies T-Shirt",
                        Price = 14.95M,
                        ShortDescription = "Nintendo Super Mario Know Your Enemies T-Shirt",
                        LongDescription = "Officially licensed and stamped with the Official Nintendo seal of quality. Super Mario is Nintendo's iconic Italian Plumber, who has been in over 200 games since his debut in 'Donkey Kong' - Since then, Mario has been sighted Dancing, playing football, occasionally racing and of course- jumping. T-Shirts are made from pre-shrunk 100% Cotton (Grey 90% Cotton / 10% Polyester). If you prefer a baggy fit, please order a size up.",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt08_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "../../Images/TShirt08_S.jpg"
                    },
                    new Product
                    {
                        Name = "Mosaic T-Shirt",
                        Price = 22.95M,
                        ShortDescription = "Super Mario Mosaic Men UTGP Nintendo T-Shirt",
                        LongDescription = "Material: 100% Cotton; Size: approx.length 64cm, width 46.5cm, sleeve 19.5cm Limited availability; Pictures shown may vary from actual product.",
                        Category = Categories["T-Shirt"],
                        ImageUrl = "../../Images/TShirt09_L.jpg",
                        InStock = 10,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "../../Images/TShirt09_S.jpg"
                    }
                );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Mug", Description="All Super Mario's mugs" },
                        new Category { CategoryName = "T-Shirt", Description="All Super Mario's t-shirts" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }
                return categories;
            }
        }
    }
}
